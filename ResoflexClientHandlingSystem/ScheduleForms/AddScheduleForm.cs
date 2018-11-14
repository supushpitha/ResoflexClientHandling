using ResoflexClientHandlingSystem.Role;
using ResoflexClientHandlingSystem.Common;
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResoflexClientHandlingSystem.Core;
using System.Collections;

namespace ResoflexClientHandlingSystem
{
    public partial class AddScheduleForm : MetroFramework.Forms.MetroForm
    {
        private DataTable engGrid = new DataTable();
        private DataTable resoTbl = new DataTable();

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

        public DataTable scheduleResourcesSource()
        {
            MySqlDataReader reader = DBConnection.getData("select resource_id, name from resource ");

            DataTable dt = new DataTable();
            dt.Load(reader);

            reader.Close();

            return dt;
        }

        //Constructor
        public AddScheduleForm()
        {
            InitializeComponent();

            projectName.DataSource = projectDataSource();
            projectName.ValueMember = "proj_id";
            projectName.DisplayMember = "proj_name";

            schClientName.DataSource = clientDataSource();
            schClientName.ValueMember = "client_id";
            schClientName.DisplayMember = "name";

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

            schResoCombo.DataSource = scheduleResourcesSource();
            schResoCombo.ValueMember = "resource_id";
            schResoCombo.DisplayMember = "name";

            //to resolve startup bug
            projectNameChange();

            engGrid.Columns.Add("staff_id", typeof(int));
            engGrid.Columns.Add("fullname", typeof(string));

            resoTbl.Columns.Add("resource_id", typeof(int));
            resoTbl.Columns.Add("name", typeof(string));
            resoTbl.Columns.Add("qty", typeof(int));
            resoTbl.PrimaryKey = new DataColumn[] {resoTbl.Columns["resource_id"]};

            serviceEngGrid.DataSource = engGrid;
            resoGrid.DataSource = resoTbl;
        }

        private void AddScheduleForm_Load(object sender, EventArgs e)
        {
            prevSchedulesGrid.Columns[0].Visible = false;
        }

        //when project name combox box is changed
        public void onProjectNameChange(object sender, EventArgs e)
        {
            projectNameChange();
        }

        //when client name is changed
        public void onClientNameChnage()
        {
            int client_id = int.Parse(schClientName.SelectedValue.ToString());


        }

        //project name change method
        public void projectNameChange()
        {
            int proj_id = int.Parse(projectName.SelectedValue.ToString());
            int client_id;

            prevSchedulesGrid.DataSource = getPrevSchedules(proj_id);

            MySqlDataReader r = DBConnection.getData("select client_id from project where proj_id = " + proj_id + ";");
            r.Read();
            client_id = r.GetInt16("client_id");
            r.Close();

            MySqlDataReader reader = DBConnection.getData("select s.sch_no, p.client_id from schedule s, project p " +
                                                            "where s.proj_id =" + proj_id + " and (p.proj_id = s.proj_id) order by sch_no DESC limit 0, 1;");

            if (reader.Read())
            {

                int sn = reader.GetInt16("sch_no") + 1;
                client_id = reader.GetInt16("client_id");

                schNo.Text = sn.ToString();
                schClientName.SelectedValue = client_id;
            }
            else
            {
                schNo.Text = 1.ToString();
                schClientName.SelectedValue = client_id;
            }

            reader.Close();
        }

        //data for prevScheGrid
        public DataTable getPrevSchedules(int proj_id)
        {
            DataTable dt = new DataTable();

            MySqlDataReader prevSch = DBConnection.getData("select s.sch_no, s.to_date_time, s.from_date_time from schedule s, project p, client c" +
                                                            " where s.proj_id = " + proj_id + " and (s.proj_id = p.proj_id) and (c.client_id = p.client_id);");

            dt.Load(prevSch);

            prevSch.Close();

            return dt;
        }

        //adding service engineers
        private void addEng_Click(object sender, MouseEventArgs e)
        {
            DataRow row;

            row = engGrid.NewRow();
            row["staff_id"] = serviceEngCombo.SelectedValue;
            row["fullname"] = serviceEngCombo.Text.ToString();

            DateTime fromDate = Convert.ToDateTime(schStartDate.Text.ToString());
            DateTime toDate = Convert.ToDateTime(schEndDate.Text.ToString());

            string sql = "select count(*) as count from schedule s, schedule_technicians st " +
               "where(s.sch_no = st.sch_no and s.proj_id = st.proj_id and st.staff_id = " + serviceEngCombo.SelectedValue + ") " +
               "and ((Date(s.from_date_time) <= Date('" + fromDate.ToString("yyyy-MM-dd") + "') and Date(s.to_date_time) >= Date('" + fromDate.ToString("yyyy-MM-dd") + "')) or (Date(s.from_date_time) <= Date('" + toDate.ToString("yyyy-MM-dd") + "') and Date(s.to_date_time) >= Date('" + toDate.ToString("yyyy-MM-dd") + "')))";


            MySqlDataReader rdr = DBConnection.getData(sql);

            int taken = 0;

            if (rdr.HasRows)
            {
                rdr.Read();

                taken += rdr.GetInt16("count");
            }

            rdr.Close();

            if (taken > 0)
            {
                MessageBox.Show("This service engineer is already added to a schedule in this time period!");
            }
            else
            {
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
                    MySqlDataReader reader = DBConnection.getData("select feedback from event_technicians where staff_id = " + serviceEngCombo.SelectedValue + ";");

                    int count = 0;
                    double grade = 0;

                    while (reader.Read())
                    {
                        string value = reader.GetString("feedback");

                        switch (value)
                        {
                            case "A":
                                {
                                    grade += 5;
                                    count++;
                                    break;
                                }

                            case "B":
                                {
                                    grade += 4;
                                    count++;
                                    break;
                                }

                            case "C":
                                {
                                    grade += 3;
                                    count++;
                                    break;
                                }

                            case "D":
                                {
                                    grade += 2;
                                    count++;
                                    break;
                                }

                            case "E":
                                {
                                    grade += 1;
                                    count++;
                                    break;
                                }

                            case "None":
                                {
                                    grade += 0;
                                    break;
                                }

                            default: break;
                        }
                    }

                    reader.Close();

                    if (grade / count < 2 && grade / count > 0)
                    {
                        DialogResult res = MessageBox.Show("This service engineer have bad feedback from this client. Are you sure you want to add this service engineer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (res == DialogResult.Yes)
                        {
                            engGrid.Rows.Add(row);
                        }
                    }
                    else
                    {
                        engGrid.Rows.Add(row);
                    }
                }
                else
                {
                    MessageBox.Show("This service engineer is already added!");
                }
            }      
        }

        //removing service engineers
        private void removeSerEng_Click(object sender, EventArgs e)
        {
            for (int i = engGrid.Rows.Count - 1;  i >= 0 ; i--)
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

        //adding resources
        private void addReso_Click(object sender, EventArgs e)
        {
            DataRow row;

            row = resoTbl.NewRow();
            row["resource_id"] = schResoCombo.SelectedValue;
            row["name"] = schResoCombo.Text.ToString();

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

        //removing resources
        private void removeReso_Click(object sender, EventArgs e)
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

        public void validation(object sender, EventArgs e)
        {
            DateTime to = Convert.ToDateTime(schEndDate.Text.ToString() + " " + schEndTime.Text.ToString());
            DateTime from = Convert.ToDateTime(schStartDate.Text.ToString() + " " + schStartTime.Text.ToString());

            if (!Validation.isEmpty(todoList.Text))
            {
                if (!Validation.isEmpty(meals.Text))
                {
                    if (!Validation.isDataTableEmpty(engGrid))
                    {
                        if (Validation.isFuture(to) && Validation.isFuture(from))
                        {
                            if(to > from)
                            {
                                saveSchedule();
                            }
                            else
                            {
                                MessageBox.Show("Please check the end date!", "Error");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please check the selected dates!", "Error");
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

        //adding a new schedule
        private void saveSchedule()
        {
            Schedule schedule = new Schedule();

            ArrayList serviceEng = new ArrayList();
            ArrayList resoArray = new ArrayList();

            foreach (DataRow dr in engGrid.Rows)
            {
                serviceEng.Add(new Staff((int)dr[0]));
            }

            foreach (DataRow dr in resoTbl.Rows)
            {
                resoArray.Add(new Resource((int)dr[0], (int)dr[2]));
            }

            schedule.ScheduleId = int.Parse(schNo.Text.ToString());
            schedule.ProjectOfSchedule= new Project(int.Parse(projectName.SelectedValue.ToString()));
            schedule.Type = new EventType(int.Parse(scheduleType.SelectedValue.ToString()));
            schedule.ServEngineer = serviceEng;
            schedule.To = Convert.ToDateTime(schEndDate.Text.ToString() + " " + schEndTime.Text.ToString());
            schedule.From = Convert.ToDateTime(schStartDate.Text.ToString() + " " + schStartTime.Text.ToString());
            schedule.TodoList = todoList.Text.ToString();
            //schedule.Resource = resoBox.Text.ToString();
            schedule.ResoArray = resoArray;
            schedule.Checklist = checkList.Text.ToString();
            schedule.TravelMode = travelingMode.Text.ToString();
            schedule.AccommodationMode = accomodation.Text.ToString();
            schedule.Meals = meals.Text.ToString();
            schedule.Logs = schLogs.Text.ToString();

            //checking if the insertion is successful
            if (Database.addSchedule(schedule))
            {
                //sending mails
                if (schSendMail.Checked)
                {
                    notifyIconSch.Icon = SystemIcons.Application;
                    notifyIconSch.BalloonTipText = "Sending Email!";
                    notifyIconSch.ShowBalloonTip(1000);

                    foreach (var ary in schedule.ServEngineer)
                    {
                        Staff s = (Staff)ary;

                        MySqlDataReader reader = DBConnection.getData("select email, first_name, last_name from staff where staff_id = " + s.StaffId + " ");

                        reader.Read();

                        string subject = "New Schedule Added";
                        string body = "Dear " + reader.GetString("first_name") + " " + reader.GetString("last_name") + 
                            "\n A new schedule has been added for project " + projectName.Text.ToString() + ". Please check your schedules ASAP." ;

                        Internet.sendMail(reader.GetString("email"), subject, body);

                        reader.Close();
                    }

                    notifyIconSch.Icon = SystemIcons.Application;
                    notifyIconSch.BalloonTipText = "Email(s) Sent!";
                    notifyIconSch.ShowBalloonTip(1000);
                }

                MessageBox.Show("Schedule Successfully Added !");
                this.Close();
            }
            
        }

        /*//validation
        private void addNICtxtBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "This field cannot be empty";

            if (Validation.isEmpty(todoList.Text))
            {
                e.Cancel = true;

                todoList.Select(0, schLogs.Text.Length);

                this.addScheduleValidation.SetError(todoList, errorMsg);
            }
        }

        private void addNICtxtBox_Validated(object sender, EventArgs e)
        {
            addScheduleValidation.SetError(todoList, "");
            addScheduleValidation.Clear();
        }*/

        //closing form
        private void schCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //resetting form
        private void schReset_Click(object sender, EventArgs e)
        {
            schLogs.Text = "";
            checkList.Text = "";
            meals.Text = "";
            todoList.Text = "";
            schStartDate.Text = "";
            schEndDate.Text = "";
        }

        private void demo_Click(object sender, EventArgs e)
        {
            schLogs.Text = "No logs";
            checkList.Text = "Check for rules and regulations";
            meals.Text = "Provided";
            todoList.Text = "Train the newly added system";
            schStartDate.Text = "2018-10-17";
            schEndDate.Text = "2018-10-24";
        }
    }
}
