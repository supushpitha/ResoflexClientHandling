using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;
using ResoflexClientHandlingSystem.EventForms;
using ResoflexClientHandlingSystem.Role;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResoflexClientHandlingSystem
{
    public partial class EventForm : MetroFramework.Forms.MetroForm
    {
        public EventForm()
        {
            InitializeComponent();

            eventGrid.DataSource = getEvents();

            eventGrid.Columns[1].Visible = false;
            eventGrid.Columns[2].Visible = false;

            //Autocompelete data source
            projectName.AutoCompleteCustomSource = projectNameAutoComplete();
            clientName.AutoCompleteCustomSource = clientNameAutoComplete();

            totalEventsTile();
            incompleteScheduleTile();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {

        }

        private void schHome_Click(object sender, EventArgs e)
        {
            ProjectManager pm = new ProjectManager();
            this.Close();
            pm.Show();
        }

        private void addEvent_Click(object sender, EventArgs e)
        {
            AddEventForm ef = new AddEventForm();
            ef.ShowDialog();
            eventGrid.DataSource = getEvents();
        }

        //Data for grid
        private DataTable getEvents()
        {
            DataTable dt = new DataTable();

            MySqlDataReader reader = DBConnection.getData("select e.event_id as Event_Id, e.proj_id, e.visit_type_id, e.sch_no as Schedule_No, p.proj_name as Project_Name, vt.type as Schedule_Type, e.from_date_time as Start_Date_and_Time, e.to_date_time as End_Date_and_Time, e.to_do_list as TODO_List, e.resource as Resources, e.check_list as Check_List, e.Other as Other, e.feedback as Feedback, e.travelling_mode as Travelling_Mode, e.accommodation_mode as Accomodation, e.meals as Meals " +
                "from event e, project p, visit_type vt, client c " +
                "where (e.proj_id = p.proj_id) and(e.visit_type_id = vt.visit_type_id) and (p.client_id = c.client_id) " +
                "order by e.event_id, e.proj_id;");

            dt.Load(reader);

            reader.Close();

            totalEventsTile();
            incompleteScheduleTile();

            return dt;
        }

        //for autocomplete project names
        private AutoCompleteStringCollection projectNameAutoComplete()
        {
            DataTable dt = new DataTable();

            MySqlDataReader reader = DBConnection.getData("select proj_name from project");
            dt.Load(reader);

            AutoCompleteStringCollection colString = new AutoCompleteStringCollection();

            foreach (DataRow item in dt.Rows)
            {
                colString.Add(Convert.ToString(item[0]));
            }

            reader.Close();

            return colString;
        }

        //for autocomplete client names
        private AutoCompleteStringCollection clientNameAutoComplete()
        {
            DataTable dt = new DataTable();

            MySqlDataReader reader = DBConnection.getData("select name from client");
            dt.Load(reader);

            AutoCompleteStringCollection colString = new AutoCompleteStringCollection();

            foreach (DataRow item in dt.Rows)
            {
                colString.Add(Convert.ToString(item[0]));
            }

            reader.Close();

            return colString;
        }

        //search by project name
        private void searchScheduleByProjectName_TextChanged(object sender, EventArgs e)
        {

            string projName = projectName.Text.ToString();

            string sql = "select e.event_id as Event_Id, e.proj_id, e.visit_type_id, e.sch_no as Schedule_No, p.proj_name as Project_Name, vt.type as Schedule_Type, e.from_date_time as Start_Date_and_Time, e.to_date_time as End_Date_and_Time, e.to_do_list as TODO_List, e.resource as Resources, e.check_list as Check_List, e.Other as Other, e.feedback as Feedback, e.travelling_mode as Travelling_Mode, e.accommodation_mode as Accomodation, e.meals as Meals " +
                "from event e, project p, visit_type vt, client c " +
                "where (e.proj_id = p.proj_id) and(e.visit_type_id = vt.visit_type_id) and (p.client_id = c.client_id) and (p.proj_name like '%" + projName + "%') " +
                "order by e.event_id, e.proj_id;";

            try
            {   
                MySqlDataReader reader = DBConnection.getData(sql);

                DataTable dt = new DataTable();
                dt.Load(reader);
                eventGrid.DataSource = dt;

                reader.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //search by client name
        private void searchScheduleByClientName_TextChanged(object sender, EventArgs e)
        {

            string cName = clientName.Text.ToString();

            string sql = "select e.event_id as Event_Id, e.proj_id, e.visit_type_id, e.sch_no as Schedule_No, p.proj_name as Project_Name, vt.type as Schedule_Type, e.from_date_time as Start_Date_and_Time, e.to_date_time as End_Date_and_Time, e.to_do_list as TODO_List, e.resource as Resources, e.check_list as Check_List, e.Other as Other, e.feedback as Feedback, e.travelling_mode as Travelling_Mode, e.accommodation_mode as Accomodation, e.meals as Meals " +
                "from event e, project p, visit_type vt, client c " +
                "where (e.proj_id = p.proj_id) and(e.visit_type_id = vt.visit_type_id) and (p.client_id = c.client_id) and (c.name like '%" + cName + "%') " +
                "order by e.event_id, e.proj_id;";

            try
            {
                MySqlDataReader reader = DBConnection.getData(sql);

                DataTable dt = new DataTable();
                dt.Load(reader);
                eventGrid.DataSource = dt;

                reader.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //deleting event
        private void deleteEvent_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = eventGrid.CurrentRow;

            int event_id = int.Parse(row.Cells[0].Value.ToString());
            int proj_id = int.Parse(row.Cells[1].Value.ToString());
            int sch_no = int.Parse(row.Cells[3].Value.ToString());

            Event evnt = new Event();

            evnt.EventId = event_id;
            evnt.EventProject = new Project(proj_id);
            evnt.ScheduleId = new Schedule(sch_no);

            DialogResult res = MessageBox.Show("Are you sure you want delete this schedule?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                if (Database.deleteEvent(evnt))
                {
                    MessageBox.Show("Event Successfully Deleted!");

                    eventGrid.DataSource = getEvents();
                }
                else
                {
                    MessageBox.Show("Something Went Wrong!");
                }
            }
        }

        private void updateEvent_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = eventGrid.CurrentRow;

            int event_id = int.Parse(row.Cells[0].Value.ToString());
            int proj_id = int.Parse(row.Cells[1].Value.ToString());
            int sch_no = int.Parse(row.Cells[3].Value.ToString());

            Event evnt = getEventRow(proj_id, sch_no, event_id);

            UpdateEventForm uef = new UpdateEventForm(evnt);
            uef.ShowDialog();

            eventGrid.DataSource = getEvents();

        }

        private Event getEventRow(int proj_id, int sch_no, int event_id)
        {
            Event evnt = new Event();

            try
            {
                MySqlDataReader reader = DBConnection.getData("select e.event_id, e.proj_id, e.visit_type_id, e.to_date_time, e.from_date_time, e.sch_no, e.feedback, e.Other, e.to_do_list, e.resource, e.check_list, e.travelling_mode, e.accommodation_mode, e.meals, p.client_id " +
                    " from event e, project p " +
                    " where e.proj_id = p.proj_id and e.event_id = " + event_id + " and e.proj_id = " + proj_id + " and e.sch_no = " + sch_no + ";");

                if (reader.Read())
                {
                    evnt.EventId = event_id;
                    evnt.EventProject = new Project(proj_id, reader.GetInt16("client_id"));
                    evnt.ScheduleId = new Schedule(sch_no);
                    evnt.Type = new EventType(reader.GetInt16("visit_type_id"));
                    evnt.From = reader.GetDateTime("from_date_time");
                    evnt.To = reader.GetDateTime("to_date_time");
                    evnt.Feedback = reader.GetString("feedback");
                    evnt.Other = reader.GetString("other");
                    evnt.TodoList = reader.GetString("to_do_list");
                    evnt.Resource = reader.GetString("resource");
                    evnt.Checklist = reader.GetString("check_list");
                    evnt.TravelMode = reader.GetString("travelling_mode");
                    evnt.AccommodationMode = reader.GetString("accommodation_mode");
                    evnt.Meals = reader.GetString("meals");

                    reader.Close();

                    MySqlDataReader reader1 = DBConnection.getData("select s.staff_id, s.first_name, s.last_name, et.feedback, ett.task " +
                        "from event_technicians et, event_technician_task ett, staff s " +
                        "where (ett.event_tech_id = et.event_staff_id) and (s.staff_id = et.staff_id) and et.event_id = " + event_id + " and et.proj_id = " + proj_id + " and et.sch_no = " + sch_no + ";");

                    ArrayList serEng = new ArrayList();

                    while (reader1.Read())
                    {
                        EventTechnician et = new EventTechnician();

                        et.Technician = new Staff(reader1.GetInt16("staff_id"), reader1.GetString("first_name"), reader1.GetString("last_name"));
                        et.Task = reader1.GetString("task");
                        et.Feedback = reader1.GetString("feedback");

                        serEng.Add(et);
                    }

                    evnt.ServEngineer = serEng;

                    reader1.Close();
                }
                else
                {
                    evnt = null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!");
                throw;
            }


            return evnt;
        }

        //data for tiles
        public void totalEventsTile()
        {
            MySqlDataReader reader = DBConnection.getData("select count(*) as count from event;");

            if (reader.Read())
            {
                totalEvents.Text = reader.GetInt16("count").ToString();
            }
            else
            {
                totalEvents.Text = 0.ToString();
            }

            reader.Close();
        }

        public void incompleteScheduleTile()
        {
            int count = 0;

            MySqlDataReader reader = DBConnection.getData("select count(*) as count from event where to_date_time > NOW()");

            if (reader.Read())
            {
                count = reader.GetInt16("count");
            }

            reader.Close();

            incompleteEvents.Text = count.ToString();
        }
    }
}
