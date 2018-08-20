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
        private Schedule schedule;

        public void setDataSources()
        {
            MySqlDataReader reader = DBConnection.getData("select proj_id, proj_name from project");

            DataTable dt = new DataTable();
            dt.Load(reader);

            projectName.DataSource = dt;


            reader.Close();


        }

        public AddScheduleForm()
        {
            InitializeComponent();
        }

        public AddScheduleForm(Schedule schedule)
        {
            InitializeComponent();

            this.schedule = schedule;

            int proj_id = schedule.ProjectOfSchedule.ProjectID;
            
            //filling the data grids
            prevSchedulesGrid.DataSource = getPrevSchedules(proj_id);

            //getting client name; 
            MySqlDataReader clientName = DBConnection.getData("select c.name from project p, client c " +
                                                            "where p.proj_id =" + proj_id + " and (p.client_id = c.client_id)");

            clientName.Read();

            //
            schClientName.SelectedText = clientName.GetString("name"); 

            schNo.Text = this.schedule.ScheduleId.ToString();
            todoList.Text = this.schedule.TodoList.ToString();

            //getting all the service eng
            ArrayList eng = this.schedule.ServEngineer;
            String se = "";

            foreach (string serEng in eng)
            {
                se = se + serEng + ", ";
            }

            serviceEngList.Text = se + "123";
            resoBox.Text = this.schedule.Resource.ToString();
            travelingMode.SelectedValue = this.schedule.TravelMode.ToString();
            meals.Text = this.schedule.Meals.ToString();
            checkList.Text = this.schedule.Checklist.ToString();
            schStartDate.Value = this.schedule.To;
            schEndDate.Value = this.schedule.From;

            clientName.Close();
        }

        private void AddScheduleForm_Load(object sender, EventArgs e)
        {

        }

        private void serviceEngList_Click(object sender, EventArgs e)
        {

        }

        public DataTable getPrevSchedules(int proj_id)
        {
            DataTable dt = new DataTable();

            MySqlDataReader prevSch = DBConnection.getData("select s.sch_no, s.to_date_time, s.from_date_time from schedule s, project p, client c" +
                                                            " where s.proj_id = " + proj_id + " and (s.proj_id = p.proj_id) and (c.client_id = p.client_id);");

            dt.Load(prevSch);

            prevSch.Close();

            return dt;
        }
    }
}
