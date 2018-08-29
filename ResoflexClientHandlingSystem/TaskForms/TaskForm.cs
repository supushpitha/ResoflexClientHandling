using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResoflexClientHandlingSystem.TaskForms
{
    public partial class TaskForm : MetroFramework.Forms.MetroForm
    {
        public TaskForm()
        {
            InitializeComponent();

            taskGrid.DataSource = getTasks();

            firstName.AutoCompleteCustomSource = staffFirstNameAutoComplete();
            lastName.AutoCompleteCustomSource = staffLastNameAutoComplete();
        }

        private void schHome_Click(object sender, EventArgs e)
        {
            ProjectManager pm = new ProjectManager();
            this.Close();
            pm.Show();
        }

        private static DataTable getTasks()
        {
            DataTable dt = new DataTable();

            MySqlDataReader reader = DBConnection.getData("select et.event_id as Event_Id, et.sch_no as Schedule_No, p.proj_name as Project_Name, s.first_name as First_Name, s.last_name as Last_Name, et.feedback as Feedback, ett.task as Task " +
                "from event_technicians et, event_technician_task ett, staff s, project p " +
                "where (et.event_staff_id = ett.event_tech_id) and (s.staff_id = et.staff_id) and (p.proj_id = et.proj_id);");

            dt.Load(reader);

            reader.Close();

            return dt;
        }

        private void searchTaskSearchByStaffName_TextChanged(object sender, EventArgs e)
        {

            string fName = firstName.Text.ToString();
            string lName = lastName.Text.ToString();

            string sql = "select et.event_id as Event_Id, et.sch_no as Schedule_No, p.proj_name as Project_Name, s.first_name as First_Name, s.last_name as Last_Name, et.feedback as Feedback, ett.task as Task " +
                " from event_technicians et, event_technician_task ett, staff s, project p " +
                " where (et.event_staff_id = ett.event_tech_id) and (s.staff_id = et.staff_id) and (p.proj_id = et.proj_id) and (s.first_name like '%" + fName + "%' and s.last_name like '%" + lName + "%');";

            try
            {
                MySqlDataReader reader = DBConnection.getData(sql);

                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    taskGrid.DataSource = dt;
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

        //for autocomplete staff first names
        private AutoCompleteStringCollection staffFirstNameAutoComplete()
        {
            DataTable dt = new DataTable();

            MySqlDataReader reader = DBConnection.getData("select first_name from staff");
            dt.Load(reader);

            AutoCompleteStringCollection colString = new AutoCompleteStringCollection();

            foreach (DataRow item in dt.Rows)
            {
                colString.Add(Convert.ToString(item[0]));
            }

            reader.Close();

            return colString;
        }

        //for autocomplete staff last names
        private AutoCompleteStringCollection staffLastNameAutoComplete()
        {
            DataTable dt = new DataTable();

            MySqlDataReader reader = DBConnection.getData("select last_name from staff");
            dt.Load(reader);

            AutoCompleteStringCollection colString = new AutoCompleteStringCollection();

            foreach (DataRow item in dt.Rows)
            {
                colString.Add(Convert.ToString(item[0]));
            }

            reader.Close();

            return colString;
        }
    }
}
