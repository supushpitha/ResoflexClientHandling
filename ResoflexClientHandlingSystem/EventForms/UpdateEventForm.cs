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

namespace ResoflexClientHandlingSystem.EventForms
{
    public partial class UpdateEventForm : MetroFramework.Forms.MetroForm
    {
        private DataTable engGrid = new DataTable();
        private DataTable feedbackGrid = new DataTable();
        private DataTable resoTbl = new DataTable();
        int eventID;
        private Event et;
        
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
            MySqlDataReader reader = DBConnection.getData("select task from schedule_task where sch_no=" + schNo + " and proj_id=" + projId);

            DataTable dt = new DataTable();
            dt.Load(reader);

            reader.Close();

            return dt;
        }

        public UpdateEventForm()
        {
            InitializeComponent();
        }

        public UpdateEventForm(Event evnt)
        {
            InitializeComponent();

            et = evnt;
            eventID = evnt.EventId;

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

            projectNameChange(evnt.EventProject.ProjectID);

            engGrid.Columns.Add("staff_id", typeof(int));
            engGrid.Columns.Add("fullname", typeof(string));

            feedbackGrid.Columns.Add("staff_id", typeof(int));
            feedbackGrid.Columns.Add("fullname", typeof(string));
            feedbackGrid.Columns.Add("feedback", typeof(string));
            feedbackGrid.Columns.Add("task", typeof(string));
            feedbackGrid.Columns.Add("app", typeof(string));
            feedbackGrid.Columns.Add("used", typeof(string));

            serviceEngGrid.DataSource = engGrid;
            clientFeedback.DataSource = feedbackGrid;

            serviceEngFeed.DataSource = engGrid;
            serviceEngFeed.ValueMember = "staff_id";
            serviceEngFeed.DisplayMember = "fullname";

            projectName.SelectedValue = evnt.EventProject.ProjectID;
            eventClientName.SelectedValue = evnt.EventProject.ClientOfProject.ClientID;
            eventsSch.SelectedValue = evnt.ScheduleId.ScheduleId;
            scheduleType.SelectedValue = evnt.Type.EventTypeId;
            todoList.Text = evnt.TodoList;
            eventStartDate.Value = evnt.From;
            eventStartTime.Value = evnt.From;
            eventEndDate.Value = evnt.To;
            eventEndTime.Value = evnt.To;
            travelingMode.Text = evnt.TravelMode;
            accomodation.Text = evnt.AccommodationMode;
            meals.Text = evnt.Meals;
            checkList.Text = evnt.Checklist;
            overFeedback.Text = evnt.Feedback;
            other.Text = evnt.Other;

            ArrayList eng = evnt.ServEngineer;

            foreach (var item in eng)
            {
                DataRow erow, frow;
                EventTechnician et = (EventTechnician)item;
                
                erow = engGrid.NewRow();
                erow["staff_id"] = et.Technician.StaffId;
                erow["fullname"] = et.Technician.FirstName + " " + et.Technician.LastName;
                engGrid.Rows.Add(erow);
                
                foreach (EventTask tsk in et.Task)
                {
                    frow = feedbackGrid.NewRow();

                    frow["staff_id"] = et.Technician.StaffId;
                    frow["fullname"] = et.Technician.FirstName + " " + et.Technician.LastName;
                    frow["task"] = tsk.Task;
                    frow["feedback"] = tsk.Fb;
                    frow["app"] = tsk.AppTime;
                    frow["used"] = tsk.UsedTime;

                    try
                    {
                        feedbackGrid.Rows.Add(frow);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("" + exc);
                    }
                }
            }
            
            ArrayList reso = evnt.ResoArray;

            resoTbl.Columns.Add("resource_id", typeof(int));
            resoTbl.Columns.Add("name", typeof(string));
            resoTbl.Columns.Add("qty", typeof(int));
            resoTbl.PrimaryKey = new DataColumn[] { resoTbl.Columns["resource_id"] };

            foreach (var item in reso)
            {
                DataRow row;
                Resource r = (Resource)item;

                row = resoTbl.NewRow();
                row["resource_id"] = r.ResourceId;
                row["name"] = r.Name;
                row["qty"] = r.TotalQty;

                resoTbl.Rows.Add(row);
            }

            resoGrid.DataSource = resoTbl;

            clientFeedback.Columns[0].Visible = false;
            serviceEngGrid.Columns[0].Visible = false;
            resoGrid.Columns[0].Visible = false;
        }
        
        public void onProjectNameChange(object sender, EventArgs e)
        {
            projectNameChange(0);
        }

        public void projectNameChange(int pid)
        {
            int proj_id;

            if (pid == 0) {
                
                proj_id = int.Parse(projectName.SelectedValue.ToString());
            }
            else
            {
                proj_id = pid;
            }
            
            MySqlDataReader reader = DBConnection.getData("select s.sch_no, p.client_id from schedule s, project p where s.proj_id =" + proj_id + " and (p.proj_id = s.proj_id);");

            DataTable dt = new DataTable();
            dt.Load(reader);

            eventsSch.DataSource = dt;
            eventsSch.ValueMember = "sch_no";
            eventsSch.DisplayMember = "sch_no";

            DataRow row = dt.Rows[0];

            eventClientName.SelectedValue = row["client_id"];

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

        private void addReso_Click(object sender, EventArgs e)
        {
            DataRow row;

            row = resoTbl.NewRow();
            row["resource_id"] = eventResoCombo.SelectedValue;
            row["name"] = eventResoCombo.Text.ToString();

            bool contain = false;

            if (Validation.isNumber(resoQty.Text.ToString()))
            {
                foreach (DataGridViewRow item in resoGrid.Rows)
                {
                    if ((int)row["resource_id"] == (int)item.Cells[0].Value)
                    {
                        int i = (int)item.Cells[2].Value;
                        item.Cells[2].Value = i + int.Parse(resoQty.Text);
                        contain = true;

                        Resource r = new Resource();
                        r.ResourceId = (int)eventResoCombo.SelectedValue;
                        r.TotalQty = i + int.Parse(resoQty.Text);

                        if (Database.updateEventResource(et, r))
                        {

                            MessageBox.Show("Resource quantity updated !");
                        }
                    }
                }

                if (!contain)
                {
                    Resource r = new Resource();
                    r.ResourceId = (int)eventResoCombo.SelectedValue;
                    r.TotalQty = int.Parse(resoQty.Text);

                    if (Database.addEventResource(et, r))
                    {

                        MessageBox.Show("Resource added !");
                    }

                    row["qty"] = int.Parse(resoQty.Text);
                    resoTbl.Rows.Add(row);
                }
            }
            else
            {
                MessageBox.Show("Enter a numeric value");
            }
        }
        
        private void removeResource_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = resoGrid.CurrentRow;

            int reso_id = int.Parse(row.Cells[0].Value.ToString());

            if (Database.removeEventResource(et, reso_id))
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

                MessageBox.Show("Resource removed !");
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

                        if(!Validation.isDataTableEmpty(feedbackGrid))
                        {
                            if (to > from)
                            {
                                updateEvent();
                            }
                            else
                            {
                                MessageBox.Show("Please check the date selection!", "Error");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tasks for service engineers should be assigned!", "Error");
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

        public void updateEvent()
        {
            Event evnt = new Event();

            evnt.EventId = eventID;
            evnt.EventProject = new Project(int.Parse(projectName.SelectedValue.ToString()), int.Parse(eventClientName.SelectedValue.ToString()));
            evnt.ScheduleId = new Schedule(int.Parse(eventsSch.SelectedValue.ToString()));
            evnt.Type = new EventType(int.Parse(scheduleType.SelectedValue.ToString()));
            evnt.From = Convert.ToDateTime(eventStartDate.Text.ToString() + " " + eventStartTime.Text.ToString());
            evnt.To = Convert.ToDateTime(eventEndDate.Text.ToString() + " " + eventEndTime.Text.ToString());
            evnt.Feedback = overFeedback.Text;
            evnt.Other = other.Text;
            evnt.TodoList = todoList.Text;
            evnt.Checklist = checkList.Text;
            evnt.TravelMode = travelingMode.Text;
            evnt.AccommodationMode = accomodation.Text;
            evnt.Meals = meals.Text;
            
            ArrayList eng = new ArrayList();
            
            foreach (DataRow dr in feedbackGrid.Rows)
            {
                bool done = false;

                foreach (EventTechnician etch in eng)
                {
                    if (etch.Technician.StaffId == (int)dr[0])
                    {
                        etch.addTask(dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                        done = true;
                        break;
                    }
                }

                if (!done)
                    eng.Add(new EventTechnician(null, new Staff((int)dr[0]), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString()));
            }

            foreach (DataRow dr in engGrid.Rows)
            {
                int engId = (int)dr[0];
                bool exists = false;

                foreach (EventTechnician et in eng)
                {
                    if (et.Technician.StaffId == engId)
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    eng.Add(new EventTechnician(null, new Staff(engId), null));
                }
            }

            evnt.ServEngineer = eng;

            if (Database.updateEvent(evnt))
            {
                if (evntSendMail.Checked)
                {
                    notifyIconEvent.Icon = SystemIcons.Application;
                    notifyIconEvent.BalloonTipText = "Sending Email!";
                    notifyIconEvent.ShowBalloonTip(1000);

                    foreach (var ary in evnt.ServEngineer)
                    {
                        EventTechnician et = (EventTechnician)ary;

                        MySqlDataReader reader = DBConnection.getData("select email, first_name, last_name from staff where staff_id = " + et.Technician.StaffId + " ");

                        reader.Read();

                        string subject = "New Event Change";
                        string body = "Dear " + reader.GetString("first_name") + " " + reader.GetString("last_name") +
                            "\n An event has been added or upfated for project " + projectName.Text.ToString() + ". Please check your events ASAP.";

                        Internet.sendMail(reader.GetString("email"), subject, body);

                        reader.Close();
                    }

                    notifyIconEvent.Icon = SystemIcons.Application;
                    notifyIconEvent.BalloonTipText = "Email(s) Sent!";
                    notifyIconEvent.ShowBalloonTip(1000);
                }

                MessageBox.Show("Event Successfully Updated !");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update the event !");
                this.Close();
            }
        }
        
        private void metroButton3_Click(object sender, EventArgs e)
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
                row["task"] = taskCmbBox.SelectedValue.ToString();

                if (usedTime.Text.ToString().Contains(':') && appTime.Text.ToString().Contains(':'))
                {
                    if (Validation.isNumber(usedTime.Text.ToString().Split(':')[0]) && Validation.isNumber(usedTime.Text.ToString().Split(':')[1]))
                    {
                        if (Validation.isNumber(appTime.Text.ToString().Split(':')[0]) && Validation.isNumber(appTime.Text.ToString().Split(':')[1]))
                        {
                            int uHr = int.Parse(usedTime.Text.ToString().Split(':')[0]);
                            int uMin = int.Parse(usedTime.Text.ToString().Split(':')[1]);

                            int aHr = int.Parse(appTime.Text.ToString().Split(':')[0]);
                            int aMin = int.Parse(appTime.Text.ToString().Split(':')[1]);

                            if ((uHr >= 0 && aHr >= 0) && (uMin >= 0 && aMin >= 0) && (uMin <= 60 && aMin <= 60))
                            {
                                row["used"] = usedTime.Text.ToString();
                                row["app"] = appTime.Text.ToString();

                                feedbackGrid.Rows.Add(row);

                                taskCmbBox.SelectedIndex = -1;
                                usedTime.Text = "";
                                appTime.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Hours and Minutes must be greater than or equal 0 and\nMinutes must also be less than or equal 60", "Add Task", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Time! Time can only contain numbers and the separator(:)", "Add Task", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Time! Time can only contain numbers and the separator(:)", "Add Task", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Time format is wrong! should be HH:MM", "Add Task", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                        taskCmbBox.ValueMember = "task";
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
