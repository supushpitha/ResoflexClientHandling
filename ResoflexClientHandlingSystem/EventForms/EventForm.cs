using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;
using ResoflexClientHandlingSystem.EventForms;
using ResoflexClientHandlingSystem.EventForms.EventReports;
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

            eventGrid.Columns[0].Visible = false;
            eventGrid.Columns[1].Visible = false;
            eventGrid.Columns[2].Visible = false;
            eventGrid.Columns[3].Visible = false;
            
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
            this.Hide();
            pm.ShowDialog();
            this.Close();
        }

        private void addEvent_Click(object sender, EventArgs e)
        {
            AddEventForm ef = new AddEventForm();
            ef.ShowDialog();

            eventGrid.DataSource = getEvents();
        }
        
        private DataTable getEvents()
        {
            DataTable dt = new DataTable();

            MySqlDataReader reader = DBConnection.getData("select e.event_id as Event_Id, e.proj_id, e.visit_type_id, e.sch_no as Schedule_No, p.proj_name as Project_Name, c.name as Client_Name, vt.type as Schedule_Type, e.from_date_time as Start_Date_and_Time, e.to_date_time as End_Date_and_Time, e.check_list as Check_List, e.Other as Other, e.feedback as Feedback, e.travelling_mode as Travelling_Mode, e.accommodation_mode as Accomodation, e.meals as Meals " +
                "from event e, project p, visit_type vt, client c " +
                "where (e.proj_id = p.proj_id) and(e.visit_type_id = vt.visit_type_id) and (p.client_id = c.client_id) " +
                "order by e.event_id DESC limit 10;");

            dt.Load(reader);

            reader.Close();

            totalEventsTile();
            incompleteScheduleTile();

            return dt;
        }
        
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
        
        private void searchScheduleByProjectName_TextChanged(object sender, EventArgs e)
        {

            string projName = projectName.Text.ToString();

            string sql = "select e.event_id as Event_Id, e.proj_id, e.visit_type_id, e.sch_no as Schedule_No, p.proj_name as Project_Name,c.name as Client_Name, vt.type as Schedule_Type, e.from_date_time as Start_Date_and_Time, e.to_date_time as End_Date_and_Time, e.to_do_list as TODO_List, e.check_list as Check_List, e.Other as Other, e.feedback as Feedback, e.travelling_mode as Travelling_Mode, e.accommodation_mode as Accomodation, e.meals as Meals " +
                "from event e, project p, visit_type vt, client c " +
                "where (e.proj_id = p.proj_id) and(e.visit_type_id = vt.visit_type_id) and (p.client_id = c.client_id) and (p.proj_name like '%" + projName + "%') " +
                "order by e.event_id DESC limit 10;";

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
                MessageBox.Show("Something went wrong!\nPlease check your MySQL database connection...", "Search by project name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void searchScheduleByClientName_TextChanged(object sender, EventArgs e)
        {

            string cName = clientName.Text.ToString();

            string sql = "select e.event_id as Event_Id, e.proj_id, e.visit_type_id, e.sch_no as Schedule_No, p.proj_name as Project_Name,c.name as Client_Name, vt.type as Schedule_Type, e.from_date_time as Start_Date_and_Time, e.to_date_time as End_Date_and_Time, e.to_do_list as TODO_List, e.check_list as Check_List, e.Other as Other, e.feedback as Feedback, e.travelling_mode as Travelling_Mode, e.accommodation_mode as Accomodation, e.meals as Meals " +
                "from event e, project p, visit_type vt, client c " +
                "where (e.proj_id = p.proj_id) and(e.visit_type_id = vt.visit_type_id) and (p.client_id = c.client_id) and (c.name like '%" + cName + "%') " +
                "order by e.event_id DESC limit 10;";

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
                MessageBox.Show("Something went wrong!\nPlease check your MySQL database connection...", "Search by client name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
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

            DialogResult res = MessageBox.Show("Are you sure you want to delete this schedule?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                if (Database.deleteEvent(evnt))
                {
                    MessageBox.Show("Event Successfully Deleted!");

                    eventGrid.DataSource = getEvents();
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
                MySqlDataReader reader = DBConnection.getData("select e.event_id, e.proj_id, e.visit_type_id, e.to_date_time, e.from_date_time, e.sch_no, e.feedback, e.Other, e.resource, e.check_list, e.travelling_mode, e.accommodation_mode, e.meals, p.client_id " +
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
                    evnt.Checklist = reader.GetString("check_list");
                    evnt.TravelMode = reader.GetString("travelling_mode");
                    evnt.AccommodationMode = reader.GetString("accommodation_mode");
                    evnt.Meals = reader.GetString("meals");

                    reader.Close();

                    string tasks = "";

                    reader = DBConnection.getData("select task from schedule_task where sch_no=" + sch_no + " and proj_id=" + proj_id + " order by sch_task_id");

                    while (reader.Read())
                    {
                        tasks += reader.GetString(0) + "/";
                    }

                    reader.Close();

                    evnt.TodoList = tasks;

                    MySqlDataReader reader1 = DBConnection.getData("select et.event_staff_id, s.staff_id, s.first_name, s.last_name " +
                        "from event_technicians et, staff s " +
                        "where (s.staff_id = et.staff_id) and et.event_id = " + event_id + " and et.proj_id = " + proj_id + " and et.sch_no = " + sch_no + ";");

                    ArrayList serEng = new ArrayList();

                    while (reader1.Read())
                    {
                        EventTechnician et = new EventTechnician();

                        et.Technician = new Staff(reader1.GetInt16("staff_id"), reader1.GetString("first_name"), reader1.GetString("last_name"));

                        MySqlDataReader r = DBConnection.getDataViaTmpConnection("select task, used_time, appointed_time, feedback from event_technician__task where event_tech_id=" + reader1.GetString(0));

                        while (r.Read())
                        {
                            double u = double.Parse("" + r.GetTimeSpan(1).Hours + "." + r.GetTimeSpan(1).Minutes);
                            double a = double.Parse("" + r.GetTimeSpan(2).Hours + "." + r.GetTimeSpan(2).Minutes);

                            et.Task.Add(new EventTask(r.GetString(0), r.GetString("feedback"), u, a));
                        }

                        r.Close();
                        DBConnection.closeTmpConnection();

                        serEng.Add(et);
                    }

                    evnt.ServEngineer = serEng;

                    reader1.Close();

                    ArrayList resoArray = new ArrayList();

                    MySqlDataReader reader3 = DBConnection.getData("select sr.resource_id, sr.qty, r.name from event_resources sr, resource r where (sr.event_id = " + event_id + " and sr.sch_no =" + sch_no + " and sr.proj_id = " + proj_id + ") and (sr.resource_id = r.resource_id);");

                    while (reader3.Read())
                    {
                        Resource reso = new Resource();
                        reso.ResourceId = int.Parse(reader3.GetString("resource_id"));
                        reso.Name = reader3.GetString("name");
                        reso.TotalQty = int.Parse(reader3.GetString("qty"));

                        resoArray.Add(reso);
                    }

                    evnt.ResoArray = resoArray;

                    reader3.Close();
                }
                else
                {
                    evnt = null;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Something went wrong!\n" + exc, "Update/View Event", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return evnt;
        }
        
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

        private void btnExp_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = eventGrid.CurrentRow;

            AddExpensesForm aef = new AddExpensesForm(int.Parse(row.Cells[1].Value.ToString()),
                int.Parse(row.Cells[0].Value.ToString()),
                int.Parse(row.Cells[3].Value.ToString()),
                row.Cells[4].Value.ToString(),
                row.Cells[5].Value.ToString(),
                Convert.ToDateTime(row.Cells[7].Value.ToString()),
                Convert.ToDateTime(row.Cells[8].Value.ToString()),
                row.Cells[13].Value.ToString(),
                row.Cells[14].Value.ToString(),
                row.Cells[15].Value.ToString());

            aef.ShowDialog();
        }

        private void btnOtherReports_Click(object sender, EventArgs e)
        {
            OtherReports other = new OtherReports();
            other.ShowDialog();
        }

        private void reports_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = eventGrid.CurrentRow;

            int event_id = int.Parse(row.Cells[0].Value.ToString());
            int proj_id = int.Parse(row.Cells[1].Value.ToString());
            int sch_no = int.Parse(row.Cells[3].Value.ToString());

            EventReportForm erf = new EventReportForm(proj_id, sch_no, event_id);
            erf.ShowDialog();
        }
    }
}
