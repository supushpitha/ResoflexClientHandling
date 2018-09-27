using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Common;
using ResoflexClientHandlingSystem.Core;
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
    public partial class AddEventForm : MetroFramework.Forms.MetroForm
    {
        private DataTable engGrid = new DataTable();
        private DataTable feedbackGrid = new DataTable();
        private int event_id;

        //service engineer datasource
        public DataTable serviceEngDataSource()
        {
            MySqlDataReader reader = DBConnection.getData("select staff_id, first_name, last_name from staff");

            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();

            dt1.Load(reader);

            dt2.Columns.Add("staff_id", typeof(int));
            dt2.Columns.Add("fullname", typeof(string));

            foreach (DataRow dr in dt1.Rows)
            {
                DataRow row;

                row = dt2.NewRow();
                row["staff_id"] = dr["staff_id"];
                row["fullname"] = dr["first_name"].ToString() + " " + dr["last_name"].ToString();
                dt2.Rows.Add(row);
            }

            reader.Close();

            return dt2;
        }

        //travelling mode datasource
        public DataTable travelModeDataSource()
        {
            MySqlDataReader reader = DBConnection.getData("select id, details from travelingmode");

            DataTable dt = new DataTable();
            dt.Load(reader);

            reader.Close();

            return dt;
        }

        public DataTable accomodationDataSource()
        {
            MySqlDataReader reader = DBConnection.getData("select id, details from accomodation");

            DataTable dt = new DataTable();
            dt.Load(reader);

            reader.Close();

            return dt;
        }

        public DataTable projectDataSource()
        {
            MySqlDataReader reader = DBConnection.getData("select proj_id, proj_name from project");

            DataTable dt = new DataTable();
            dt.Load(reader);

            reader.Close();

            return dt;
        }

        public DataTable clientDataSource()
        {
            MySqlDataReader reader = DBConnection.getData("select client_id, name from client");

            DataTable dt = new DataTable();
            dt.Load(reader);

            reader.Close();

            return dt;
        }

        public DataTable scheduleTypeDataSource()
        {
            MySqlDataReader reader = DBConnection.getData("select visit_type_id, type from visit_type ");

            DataTable dt = new DataTable();
            dt.Load(reader);

            reader.Close();

            return dt;
        }

        public AddEventForm()
        {
            InitializeComponent();

            projectName.DataSource = projectDataSource();
            projectName.ValueMember = "proj_id";
            projectName.DisplayMember = "proj_name";

            eventClientName.DataSource = clientDataSource();
            eventClientName.ValueMember = "client_id";
            eventClientName.DisplayMember = "name";

            scheduleType.DataSource = scheduleTypeDataSource();
            scheduleType.ValueMember = "visit_type_id";
            scheduleType.DisplayMember = "type";

            travelingMode.DataSource = travelModeDataSource();
            travelingMode.ValueMember = "id";
            travelingMode.DisplayMember = "details";

            accomodation.DataSource = accomodationDataSource();
            accomodation.ValueMember = "id";
            accomodation.DisplayMember = "details";

            serviceEngCombo.DataSource = serviceEngDataSource();
            serviceEngCombo.ValueMember = "staff_id";
            serviceEngCombo.DisplayMember = "fullname";

            //to resolve startup bug
            projectNameChange(0);

            //eng grid columns
            engGrid.Columns.Add("staff_id", typeof(int));
            engGrid.Columns.Add("fullname", typeof(string));

            //feedback grid columns
            feedbackGrid.Columns.Add("staff_id", typeof(int));
            feedbackGrid.Columns.Add("fullname", typeof(string));
            feedbackGrid.Columns.Add("feedback", typeof(string));
            feedbackGrid.Columns.Add("task", typeof(string));

            serviceEngGrid.DataSource = engGrid;
            clientFeedback.DataSource = feedbackGrid;

            serviceEngFeed.DataSource = engGrid;
            serviceEngFeed.ValueMember = "staff_id";
            serviceEngFeed.DisplayMember = "fullname";
        }

        public AddEventForm(int sch_no, int proj_id)
        {
            InitializeComponent();

            projectName.DataSource = projectDataSource();
            projectName.ValueMember = "proj_id";
            projectName.DisplayMember = "proj_name";

            eventClientName.DataSource = clientDataSource();
            eventClientName.ValueMember = "client_id";
            eventClientName.DisplayMember = "name";

            scheduleType.DataSource = scheduleTypeDataSource();
            scheduleType.ValueMember = "visit_type_id";
            scheduleType.DisplayMember = "type";

            travelingMode.DataSource = travelModeDataSource();
            travelingMode.ValueMember = "id";
            travelingMode.DisplayMember = "details";

            accomodation.DataSource = accomodationDataSource();
            accomodation.ValueMember = "id";
            accomodation.DisplayMember = "details";

            serviceEngCombo.DataSource = serviceEngDataSource();
            serviceEngCombo.ValueMember = "staff_id";
            serviceEngCombo.DisplayMember = "fullname";

            //to resolve startup bug
            projectNameChange(proj_id);

            //eng grid columns
            engGrid.Columns.Add("staff_id", typeof(int));
            engGrid.Columns.Add("fullname", typeof(string));

            //feedback grid columns
            feedbackGrid.Columns.Add("staff_id", typeof(int));
            feedbackGrid.Columns.Add("fullname", typeof(string));
            feedbackGrid.Columns.Add("feedback", typeof(string));
            feedbackGrid.Columns.Add("task", typeof(string));

            serviceEngGrid.DataSource = engGrid;
            clientFeedback.DataSource = feedbackGrid;

            serviceEngFeed.DataSource = engGrid;
            serviceEngFeed.ValueMember = "staff_id";
            serviceEngFeed.DisplayMember = "fullname";
                        
            projectName.SelectedValue = proj_id;
            eventsSch.SelectedValue = sch_no;
            
        }

        private void AddEventForm_Load(object sender, EventArgs e)
        {

        }

        private void schCancel_Click(object sender, EventArgs e)
        {

        }

        private void addExpenses(object sender, EventArgs e)
        {

        }

        //when project name combox box is changed
        public void onProjectNameChange(object sender, EventArgs e)
        {
            projectNameChange(0);
        }

        public void projectNameChange(int pid)
        {
            int proj_id;

            if (pid == 0)
            {

                proj_id = int.Parse(projectName.SelectedValue.ToString());
            }
            else
            {
                proj_id = pid;
            }

            int client_id;

            MySqlDataReader reader = DBConnection.getData("select s.sch_no, p.client_id from schedule s, project p where s.proj_id =" + proj_id + " and (p.proj_id = s.proj_id);");

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);

                eventsSch.DataSource = dt;
                eventsSch.ValueMember = "sch_no";
                eventsSch.DisplayMember = "sch_no";

                DataRow row = dt.Rows[0];

                eventClientName.SelectedValue = row["client_id"];
            }
            else
            {
                eventClientName.SelectedValue = 1;
            }

            

            reader.Close();
        }

        //adding service engineers
        private void addEng_MouseClick(object sender, MouseEventArgs e)
        {
            DataRow row;

            row = engGrid.NewRow();
            row["staff_id"] = serviceEngCombo.SelectedValue;
            row["fullname"] = serviceEngCombo.Text.ToString();
            engGrid.Rows.Add(row);

        }

        //removing service engineers
        private void removeSerEng_Click(object sender, EventArgs e)
        {
            for (int i = engGrid.Rows.Count - 1; i >= 0; i--)
            {
                DataRow r = engGrid.Rows[i];
                DataGridViewRow gr = serviceEngGrid.CurrentRow;

                if (r["staff_id"].ToString().Equals(gr.Cells[0].Value.ToString()))
                {
                    engGrid.Rows[i].Delete();

                    break;
                }
            }
        }

        public void validation(object sender, EventArgs e)
        {
            if (!Validation.isEmpty(todoList.Text))
            {
                if (!Validation.isEmpty(meals.Text))
                {
                    if (!Validation.isDataTableEmpty(engGrid))
                    {
                        addEvent();
                    }
                    else
                    {
                        MessageBox.Show("Service engineers should be assigned!", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Meal field cannot be empty!", "Error");
                }
            }
            else
            {
                MessageBox.Show("Todo list field cannot be empty!", "Error");
            }
        }

        //adding details to feedback grid
        private void addFeedback_MouseClick(object sender, MouseEventArgs e)
        {
            DataRow row;

            row = feedbackGrid.NewRow();
            row["staff_id"] = serviceEngFeed.SelectedValue;
            row["fullname"] = serviceEngFeed.Text.ToString();
            row["feedback"] = feedback.Text.ToString();
            row["task"] = eventTask.Text.ToString();
            feedbackGrid.Rows.Add(row);

            eventTask.Text = "";
        }

        private void addEvent()
        {
            Event evnt = new Event();

            ArrayList serviceEng = new ArrayList();
            ArrayList mailEng = new ArrayList();

            MySqlDataReader reader = DBConnection.getData("select event_id from event where proj_id = " + projectName.SelectedValue + " and sch_no = " + eventsSch.SelectedValue + ";");

            if (reader.Read())
            {
                event_id = reader.GetInt16("event_id") + 1;
            }
            else
            {
                event_id = 1;
            }

            foreach (DataRow dr in feedbackGrid.Rows)
            {
                serviceEng.Add(new EventTechnician(new Event(event_id), new Staff((int)dr[0]), dr[2].ToString(), dr[3].ToString()));
            }

            foreach (DataRow dr in engGrid.Rows)
            {
                mailEng.Add(new Staff((int)dr[0]));
            }

            reader.Close();

            evnt.EventId = event_id;
            evnt.ScheduleId = new Schedule(int.Parse(eventsSch.SelectedValue.ToString()));
            evnt.EventProject = new Project(int.Parse(projectName.SelectedValue.ToString()));
            evnt.Type = new EventType(int.Parse(scheduleType.SelectedValue.ToString()));
            evnt.ServEngineer = serviceEng;
            evnt.To = Convert.ToDateTime(eventEndDate.Text.ToString() + " " + eventEndTime.Text.ToString());
            evnt.From = Convert.ToDateTime(eventStartDate.Text.ToString() + " " + eventStartTime.Text.ToString());
            evnt.TodoList = todoList.Text.ToString();
            evnt.Resource = resoBox.Text.ToString();
            evnt.Checklist = checkList.Text.ToString();
            evnt.TravelMode = travelingMode.Text.ToString();
            evnt.AccommodationMode = accomodation.Text.ToString();
            evnt.Meals = meals.Text.ToString();
            evnt.Other = other.Text.ToString();
            evnt.Feedback = overFeedback.Text.ToString();

            //checking if the insertion is successful
            if (Database.addEvent(evnt))
            {
                //sending mails
                if (evntSendMail.Checked)
                {
                    foreach (var ary in mailEng)
                    {
                        Staff et = (Staff)ary;

                        MySqlDataReader rdr = DBConnection.getData("select email, first_name, last_name from staff where staff_id = " + et.StaffId + " ");

                        rdr.Read();

                        string subject = "New Event Added";
                        string body = "Dear " + rdr.GetString("first_name") + " " + rdr.GetString("last_name") +
                            "\n A new event has been added for a schedule of project " + projectName.Text.ToString() + ". Please check your schedules/events ASAP.";

                        Internet.sendMail(rdr.GetString("email"), subject, body);

                        rdr.Close();
                    }
                }

                MessageBox.Show("Event Successfully Added !");
                this.Close();
            }
        }

        //adding resources
        private void addReso_Click(object sender, EventArgs e)
        {
            string resources = eventReso.Text.ToString();
            eventReso.Text = "";

            resoBox.AppendText(resources + " ");
            resoBox.AppendText(Environment.NewLine);
        }

        private void serviceEngGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader = DBConnection.getData("select event_id from event where proj_id = " + projectName.SelectedValue + " and sch_no = " + eventsSch.SelectedValue + ";");

            if (reader.Read())
            {
                event_id = reader.GetInt16("event_id") + 1;
            }
            else
            {
                event_id = 1;
            }

            reader.Close();

            AddExpensesForm add = new AddExpensesForm(int.Parse(projectName.SelectedValue.ToString()), event_id);
            
            add.Show();
        }
    }
}
