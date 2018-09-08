using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;
using ResoflexClientHandlingSystem.Role;
using System;
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

                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    eventGrid.DataSource = dt;
                }
                else
                {
                    //scheduleGrid.DataSource = null;

                    reader.Close();
                }
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

                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    eventGrid.DataSource = dt;
                }
                else
                {
                    //scheduleGrid.DataSource = null;

                    reader.Close();
                }
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            eventGrid.DataSource = getEvents();
        }
    }
}
