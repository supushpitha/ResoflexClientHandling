using ResoflexClientHandlingSystem.Role;
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
        //
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

            //to resolve startup bug
            projectNameChange();

        }

        private void AddScheduleForm_Load(object sender, EventArgs e)
        {

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

            MySqlDataReader reader = DBConnection.getData("select s.sch_no, p.client_id from schedule s, project p " +
                                                            "where s.proj_id =" + proj_id + " and (p.proj_id = s.proj_id) order by sch_no DESC limit 0, 1;");

            if (reader.Read())
            {

                int sn = reader.GetInt16("sch_no") + 1;
                client_id = reader.GetInt16("client_id");

                schNo.Text = sn.ToString();
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
        private void addEng_MouseClick(object sender, MouseEventArgs e)
        {
            serviceEngList.Text = serviceEngList.Text + serviceEngCombo.Text.ToString() + ",\n";
        }

        //adding resources
        private void addReso_MouseClick(object sender, MouseEventArgs e)
        {
            resoBox.Text = resoBox.Text + schReso.Text + ", ";
        }

        private void schSave_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule();

            schedule.ProjectOfSchedule.ProjectID = (int) projectName.SelectedValue;
            schedule.Type = new EventType(int.Parse(scheduleType.SelectedValue.ToString()));
            schedule.To = Convert.ToDateTime(schStartDate + " " + schStartTime);
            schedule.From = Convert.ToDateTime(schEndDate + " " + schEndTime);
            schedule.TodoList = todoList.Text.ToString();
            schedule.Resource = resoBox.Text.ToString();
            schedule.Checklist = checkList.Text.ToString();
            schedule.TravelMode = travelingMode.Text.ToString();
            schedule.AccommodationMode = accomodation.Text.ToString();
            schedule.Meals = meals.Text.ToString();

            Database.addSchedule(schedule);

            MessageBox.Show("Schedule Successfully Added !");

            this.Close();
        }
    }
}
