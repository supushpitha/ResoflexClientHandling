using ResoflexClientHandlingSystem.Core;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResoflexClientHandlingSystem.UserForms;

namespace ResoflexClientHandlingSystem
{
    public partial class StaffEvalutionForm : MetroFramework.Forms.MetroForm
    {
        public StaffEvalutionForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            metroGrid3.DataSource = getStaff();
            metroGrid2.DataSource = getStaff();
            metroGrid4.DataSource = jobPerformanceTop20();
            metroRadioButton1.Checked = true;
            metroRadioButton3.Checked = true;
        }

        private DataTable getStaff()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("SELECT * FROM staff");
            table.Load(reader);
            return table;
        }

        private DataTable jobPerformanceTop20()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("select s.staff_id, s.first_name, s.last_name, s.tel1, s.tel2, s.email, s.address, sum(jb.knowledge + jb.Saftey + jb.Quality + jb.Adaptability + jb.Productivity + jb.Initiative) as total from staff as s Inner join job_performance as jb on s.staff_id = jb.staff_id group by staff_id order by total desc limit 2");
            table.Load(reader);
            return table;
        }

        private DataTable jobPerformanceTop50()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("select s.staff_id,s.first_name,s.last_name,s.tel1,s.tel2,s.email,s.address,sum(jb.knowledge+jb.Saftey+jb.Quality+jb.Adaptability+jb.Productivity+jb.Initiative) as total from staff as s Inner join job_performance as jb on s.staff_id = jb.staff_id group by staff_id order by total desc limit 3");
            table.Load(reader);
            return table;
        }

        private DataTable clientRelationsTop20()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("select s.staff_id, s.first_name, s.last_name, s.tel1, s.tel2, s.email, s.address, sum(cr.telephone_skills + cr.problem_resolution + cr.salesmanship + cr.pro_activeness + cr.politeness) as total from staff as s Inner join client_relations as cr on s.staff_id = cr.staff_id group by staff_id order by total desc limit 2");
            table.Load(reader);
            return table;
        }

        private DataTable clientRelationsTop50()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("select s.staff_id,s.first_name,s.last_name,s.tel1,s.tel2,s.email,s.address,sum(cr.telephone_skills + cr.problem_resolution + cr.salesmanship + cr.pro_activeness + cr.politeness) as total from staff as s Inner join client_relations as cr on s.staff_id = cr.staff_id group by staff_id order by total desc limit 3");
            table.Load(reader);
            return table;
        }

        private DataTable communicationSkillsTop20()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("select s.staff_id, s.first_name, s.last_name, s.tel1, s.tel2, s.email, s.address, sum(cs.influence + cs.presentation + cs.relationship + cs.listening + cs.negotiation) as total from staff as s Inner join communication_skills as cs on s.staff_id = cs.staff_id group by staff_id order by total desc limit 2");
            table.Load(reader);
            return table;
        }

        private DataTable communicationSkillsTop50()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("select s.staff_id, s.first_name, s.last_name, s.tel1, s.tel2, s.email, s.address, sum(cs.influence + cs.presentation + cs.relationship + cs.listening + cs.negotiation) as total from staff as s Inner join communication_skills as cs on s.staff_id = cs.staff_id group by staff_id order by total desc limit 3");
            table.Load(reader);
            return table;
        }

        private DataTable interpersonalSkillsTop20()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("select s.staff_id, s.first_name, s.last_name, s.tel1, s.tel2, s.email, s.address, sum(ins.interaction_with_customers + ins.interaction_with_supervisors + ins.interaction_with_clients + ins.motivational_skills + ins.leadership) as total from staff as s Inner join interpersonal_skills as ins on s.staff_id = ins.staff_id group by staff_id order by total desc limit 3");
            table.Load(reader);
            return table;
        }

        private DataTable interpersonalSkillsTop50()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("select s.staff_id, s.first_name, s.last_name, s.tel1, s.tel2, s.email, s.address, sum(ins.interaction_with_customers + ins.interaction_with_supervisors + ins.interaction_with_clients + ins.motivational_skills + ins.leadership) as total from staff as s Inner join interpersonal_skills as ins on s.staff_id = ins.staff_id group by staff_id order by total desc limit 3");
            table.Load(reader);
            return table;
        }

        private DataTable customNumberForJobPerformanceTopEmps()
        {
            int limit = 10;
            try
            {
                 limit = Int32.Parse(metroTextBox3.Text);
            }
            catch (Exception) {
                 limit = 5;
            }
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("select s.staff_id, s.first_name, s.last_name, s.tel1, s.tel2, s.email, s.address, sum(ins.interaction_with_customers + ins.interaction_with_supervisors + ins.interaction_with_clients + ins.motivational_skills + ins.leadership) as total from staff as s Inner join interpersonal_skills as ins on s.staff_id = ins.staff_id group by staff_id order by total desc limit '"+ limit + "'");
            table.Load(reader);
            return table;
        }

        private DataTable customNumberForClientRelationsTopEmps()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("select s.staff_id, s.first_name, s.last_name, s.tel1, s.tel2, s.email, s.address, sum(ins.interaction_with_customers + ins.interaction_with_supervisors + ins.interaction_with_clients + ins.motivational_skills + ins.leadership) as total from staff as s Inner join interpersonal_skills as ins on s.staff_id = ins.staff_id group by staff_id order by total desc limit '" + metroTextBox3.Text + "'");
            table.Load(reader);
            return table;
        }

        private DataTable customNumberForCommunicationSkillsTopEmps()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("select s.staff_id, s.first_name, s.last_name, s.tel1, s.tel2, s.email, s.address, sum(ins.interaction_with_customers + ins.interaction_with_supervisors + ins.interaction_with_clients + ins.motivational_skills + ins.leadership) as total from staff as s Inner join interpersonal_skills as ins on s.staff_id = ins.staff_id group by staff_id order by total desc limit'" + metroTextBox3.Text + "'");
            table.Load(reader);
            return table;
        }

        private DataTable customNumberForInterpersonalSkillsTopEmps()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("select s.staff_id, s.first_name, s.last_name, s.tel1, s.tel2, s.email, s.address, sum(ins.interaction_with_customers + ins.interaction_with_supervisors + ins.interaction_with_clients + ins.motivational_skills + ins.leadership) as total from staff as s Inner join interpersonal_skills as ins on s.staff_id = ins.staff_id group by staff_id order by total desc limit '" + metroTextBox3.Text + "'");
            table.Load(reader);
            return table;
        }

        private DataTable searchEmployees()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("SELECT * FROM staff WHERE name LIKE '%"+ metroTextBox2.Text+ "%' OR  employee_no LIKE '%" + metroTextBox2.Text + "%'");
            table.Load(reader);
            return table;
            
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void metroGrid3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int emp_no = Int32.Parse(metroGrid3.Rows[e.RowIndex].Cells[0].Value.ToString());
            string emp_name = metroGrid3.Rows[e.RowIndex].Cells[1].Value.ToString();

            EvaluateEmployeeForm eEf = new EvaluateEmployeeForm(emp_no, emp_name);
            eEf.Show();

        }

        private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {

            metroGrid2.DataSource = searchEmployees();
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            RecordAttendanceForm rAF = new RecordAttendanceForm();
            rAF.Show();
        }

        private void metroRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton1.Checked == true)
            {
                metroGrid4.DataSource = jobPerformanceTop20();
            }
            else
            {
                metroGrid4.DataSource = jobPerformanceTop50();
            }
        }

        private void metroRadioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (metroRadioButton1.Checked == true)
            {
                metroGrid4.DataSource = clientRelationsTop20();
            }
            else
            {
                metroGrid4.DataSource = clientRelationsTop50();
            }
        }

        private void metroRadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton1.Checked == true)
            {
                metroGrid4.DataSource = communicationSkillsTop20();
            }
            else
            {
                metroGrid4.DataSource = communicationSkillsTop50();
            }
        }

        private void metroRadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton1.Checked == true)
            {
                metroGrid4.DataSource = interpersonalSkillsTop20();
            }
            else
            {
                metroGrid4.DataSource = interpersonalSkillsTop50();
            }
        }

        private void metroTabPage4_Click(object sender, EventArgs e)
        {

        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton3.Checked == true) {

                metroGrid4.DataSource = jobPerformanceTop20();

            } else if (metroRadioButton4.Checked == true) {

                metroGrid4.DataSource = clientRelationsTop20();

            } else if (metroRadioButton5.Checked == true) {

                metroGrid4.DataSource = communicationSkillsTop20();
            }
            else {
                metroGrid4.DataSource = interpersonalSkillsTop20();
            }
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton3.Checked == true)
            {
                metroGrid4.DataSource = jobPerformanceTop50();
            }
            else if (metroRadioButton4.Checked == true)
            {
                metroGrid4.DataSource = clientRelationsTop50();
            }
            else if (metroRadioButton5.Checked == true)
            {
                metroGrid4.DataSource = communicationSkillsTop50();
            }
            else
            {
                metroGrid4.DataSource = interpersonalSkillsTop50();
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (metroRadioButton3.Checked == true)
            {

                metroGrid4.DataSource = customNumberForJobPerformanceTopEmps();

            }
            else if (metroRadioButton4.Checked == true)
            {

                metroGrid4.DataSource = customNumberForClientRelationsTopEmps();

            }
            else if (metroRadioButton5.Checked == true)
            {

                metroGrid4.DataSource = customNumberForCommunicationSkillsTopEmps();
            }
            else
            {
                metroGrid4.DataSource = customNumberForInterpersonalSkillsTopEmps();
            }
        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            ProfileForm prffrm = new ProfileForm();
            this.Hide();
            prffrm.ShowDialog();
            this.Close();
        }
    }
}
