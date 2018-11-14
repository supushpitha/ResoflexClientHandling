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
        private DataTable resoTbl = new DataTable();
        private int event_id;
        
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

        public DataTable eventResourcesSource()
        {
            MySqlDataReader reader = DBConnection.getData("select resource_id, name from resource ");

            DataTable dt = new DataTable();
            dt.Load(reader);

            reader.Close();

            return dt;
        }

        public DataTable tasksSource(int schNo, int projId)
        {
            MySqlDataReader reader = DBConnection.getData("select sch_task_id, task from schedule_task where sch_no=" + schNo + " and proj_id=" + projId);

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

            eventResoCombo.DataSource = eventResourcesSource();
            eventResoCombo.ValueMember = "resource_id";
            eventResoCombo.DisplayMember = "name";
            
            engGrid.Columns.Add("staff_id", typeof(int));
            engGrid.Columns.Add("fullname", typeof(string));
            
            feedbackGrid.Columns.Add("staff_id", typeof(int));
            feedbackGrid.Columns.Add("fullname", typeof(string));
            feedbackGrid.Columns.Add("feedback", typeof(string));
            feedbackGrid.Columns.Add("task", typeof(string));
            feedbackGrid.Columns.Add("app", typeof(double));
            feedbackGrid.Columns.Add("used", typeof(double));
            
            resoTbl.Columns.Add("resource_id", typeof(int));
            resoTbl.Columns.Add("name", typeof(string));
            resoTbl.Columns.Add("qty", typeof(int));
            resoTbl.PrimaryKey = new DataColumn[] { resoTbl.Columns["resource_id"] };

            serviceEngGrid.DataSource = engGrid;
            clientFeedback.DataSource = feedbackGrid;
            resoGrid.DataSource = resoTbl;

            serviceEngFeed.DataSource = engGrid;
            serviceEngFeed.ValueMember = "staff_id";
            serviceEngFeed.DisplayMember = "fullname";

            clientFeedback.Columns[0].Visible = false;
            serviceEngGrid.Columns[0].Visible = false;
            resoGrid.Columns[0].Visible = false;
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

            eventResoCombo.DataSource = eventResourcesSource();
            eventResoCombo.ValueMember = "resource_id";
            eventResoCombo.DisplayMember = "name";

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
            feedbackGrid.Columns.Add("app", typeof(double));
            feedbackGrid.Columns.Add("used", typeof(double));

            //reso columns
            resoTbl.Columns.Add("resource_id", typeof(int));
            resoTbl.Columns.Add("name", typeof(string));
            resoTbl.Columns.Add("qty", typeof(int));
            resoTbl.PrimaryKey = new DataColumn[] { resoTbl.Columns["resource_id"] };

            serviceEngGrid.DataSource = engGrid;
            clientFeedback.DataSource = feedbackGrid;
            resoGrid.DataSource = resoTbl;

            serviceEngFeed.DataSource = engGrid;
            serviceEngFeed.ValueMember = "staff_id";
            serviceEngFeed.DisplayMember = "fullname";
                        
            projectName.SelectedValue = proj_id;
            eventsSch.SelectedValue = sch_no;

            clientFeedback.Columns[0].Visible = false;
            serviceEngGrid.Columns[0].Visible = false;
            resoGrid.Columns[0].Visible = false;
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
        
        private void addEng_MouseClick(object sender, MouseEventArgs e)
        {
            DataRow row;

            row = engGrid.NewRow();
            row["staff_id"] = serviceEngCombo.SelectedValue;
            row["fullname"] = serviceEngCombo.Text.ToString();

            bool contain = false;

            foreach (DataGridViewRow item in serviceEngGrid.Rows)
            {
                if ((int)row["staff_id"] == (int)item.Cells[0].Value)
                {
                    contain = true;
                }
            }

            if (!contain)
            {
                engGrid.Rows.Add(row);
            }
            else
            {
                MessageBox.Show("This service engineer is already added!");
            }
        }
        
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
            DateTime to = Convert.ToDateTime(eventEndDate.Text.ToString() + " " + eventEndTime.Text.ToString());
            DateTime from = Convert.ToDateTime(eventStartDate.Text.ToString() + " " + eventStartTime.Text.ToString());

            if (!Validation.isEmpty(todoList.Text))
            {
                if (!Validation.isEmpty(meals.Text))
                {
                    if (!Validation.isDataTableEmpty(engGrid))
                    {
                        if (to > from)
                        {
                            addEvent();
                        }
                        else
                        {
                            MessageBox.Show("Please check the date selection!", "Error");
                        }
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
        
        private void addEvent()
        {
            Event evnt = new Event();

            ArrayList serviceEng = new ArrayList();
            ArrayList mailEng = new ArrayList();
            ArrayList resoArray = new ArrayList();

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
                bool done = false;

                foreach (EventTechnician etch in serviceEng)
                {
                    if (etch.Technician.StaffId == (int)dr[0])
                    {
                        etch.addTask(dr[2].ToString(), dr[3].ToString(), (double)dr[4], (double)dr[5]);
                        done = true;
                    }
                }

                if (!done)
                    serviceEng.Add(new EventTechnician(new Event(event_id), new Staff((int)dr[0]), dr[2].ToString(), dr[3].ToString(), (double)dr[4], (double)dr[5]));
            }

            foreach (DataRow dr in engGrid.Rows)
            {
                mailEng.Add(new Staff((int)dr[0]));
            }

            foreach (DataRow dr in resoTbl.Rows)
            {
                resoArray.Add(new Resource((int)dr[0], (int)dr[2]));
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
            evnt.ResoArray = resoArray;
            evnt.Checklist = checkList.Text.ToString();
            evnt.TravelMode = travelingMode.Text.ToString();
            evnt.AccommodationMode = accomodation.Text.ToString();
            evnt.Meals = meals.Text.ToString();
            evnt.Other = other.Text.ToString();
            evnt.Feedback = overFeedback.Text.ToString();
            
            if (Database.addEvent(evnt))
            {
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
        
        private void addReso_Click(object sender, EventArgs e)
        {
            DataRow row;

            row = resoTbl.NewRow();
            row["resource_id"] = eventResoCombo.SelectedValue;
            row["name"] = eventResoCombo.Text.ToString();

            if (Validation.isNumber(resoQty.Text.ToString()))
            {
                bool contain = false;

                foreach (DataGridViewRow item in resoGrid.Rows)
                {
                    if ((int)row["resource_id"] == (int)item.Cells[0].Value)
                    {
                        int i = (int)item.Cells[2].Value;
                        item.Cells[2].Value = i + int.Parse(resoQty.Text);
                        contain = true;
                    }
                }

                if (!contain)
                {
                    row["qty"] = int.Parse(resoQty.Text);
                    resoTbl.Rows.Add(row);
                }
            }
            else
            {
                MessageBox.Show("Enter a numeric value");
            }
        }

        private void removerReso_Click(object sender, EventArgs e)
        {
            for (int i = resoTbl.Rows.Count - 1; i >= 0; i--)
            {
                DataRow r = resoTbl.Rows[i];
                DataGridViewRow gr = resoGrid.CurrentRow;

                if (r["resource_id"].ToString().Equals(gr.Cells[0].Value.ToString()))
                {
                    resoTbl.Rows[i].Delete();

                    break;
                }
            }
        }

        private void serviceEngGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            /*MySqlDataReader reader = DBConnection.getData("select event_id from event where proj_id = " + projectName.SelectedValue + " and sch_no = " + eventsSch.SelectedValue + ";");

            if (reader.Read())
            {
                event_id = reader.GetInt16("event_id");

                reader.Close();

                AddExpensesForm addExpFrm = new AddExpensesForm(int.Parse(projectName.SelectedValue.ToString()), event_id, int.Parse(eventsSch.SelectedValue.ToString()));

                addExpFrm.Show();
            }*/
        }
        
        private void metroButton2_Click(object sender, EventArgs e)
        {
            todoList.Text = "";
            checkList.Text = "";
            meals.Text = "";
            overFeedback.Text = "";
            other.Text = "";
            taskCmbBox.SelectedIndex = -1;
            usedTime.Text = "";
            eventStartDate.Text = "";
            eventEndDate.Text = "";
        }
        
        private void metroButton4_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow row;

                row = feedbackGrid.NewRow();
                row["staff_id"] = serviceEngFeed.SelectedValue;
                row["fullname"] = serviceEngFeed.Text.ToString();
                row["feedback"] = feedback.Text.ToString();
                row["task"] = taskCmbBox.SelectedItem.ToString();

                if ((Validation.isDouble(usedTime.Text.ToString())) && (Validation.isDouble(appTime.Text.ToString())))
                {
                    row["used"] = double.Parse(usedTime.Text.ToString());
                    row["app"] = double.Parse(appTime.Text.ToString());
                    feedbackGrid.Rows.Add(row);

                    taskCmbBox.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Invalid time!");
                }
                
                usedTime.Text = "";
                appTime.Text = "";
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Make sure to add previous information!", "Add Event", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void eventsSch_SelectedIndexChanged(object sender, EventArgs e)
        {
            int proj_id, sch_no;

            if (eventsSch.SelectedItem != null)
            {
                if (projectName.SelectedItem != null)
                {
                    if (int.TryParse(projectName.SelectedValue.ToString(), out proj_id) && int.TryParse(eventsSch.SelectedValue.ToString(), out sch_no))
                    {
                        taskCmbBox.DataSource = tasksSource(sch_no, proj_id);
                        taskCmbBox.ValueMember = "sch_task_id";
                        taskCmbBox.DisplayMember = "task";
                    }
                }
                else
                {
                    MessageBox.Show("First choose a project!");
                }
            }
        }
    }
}
