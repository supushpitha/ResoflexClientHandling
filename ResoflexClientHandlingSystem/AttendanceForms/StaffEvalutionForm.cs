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
using System.Windows.Forms.DataVisualization.Charting;

namespace ResoflexClientHandlingSystem
{
    public partial class StaffEvalutionForm : MetroFramework.Forms.MetroForm
    {

        string empName1;
        string empName2;
        int staffIdEmp1;
        int staffIdEmp2;
        int month;
        int year;
       
        public StaffEvalutionForm()
        {
            InitializeComponent();

        }

        int geo = 0;

        DateTime todaysDate = DateTime.Parse(DateTime.Now.ToString("M/d/yyyy"));
        DateTime[] evalDates = new DateTime[9];
        int[] evalGrades1 = new int[9];
        int[] evalGrades2 = new int[9];

        private void Form1_Load(object sender, EventArgs e)
        {
            metroGrid3.DataSource = getStaff();
            staffAttendanceDataGrid.DataSource = staffEvaluationGetAttendace(); 
            metroGrid4.DataSource = jobPerformanceTop20();
            metroRadioButton1.Checked = true;
            metroRadioButton3.Checked = true;
            
            month = todaysDate.Month;
            year = todaysDate.Year;
            dateGenerator(year);           

            metroComboBox1.ValueMember = "staff_id";
            metroComboBox1.DisplayMember = "fullname";
            metroComboBox1.DataSource = getEmployees();

            metroComboBox2.ValueMember = "staff_id";
            metroComboBox2.DisplayMember = "fullname";
            metroComboBox2.DataSource = getEmployees();

            
            int gap = 10;
            int tempYear = (DateTime.Now.Year) - (gap - 1);
            FromComboBox.DataSource = Enumerable.Range(tempYear, gap).ToList();
            FromComboBox.SelectedIndex = FromComboBox.Items.IndexOf(DateTime.Now.Year);

            metroRadioButton7.Checked = true;
            JPRadioBtn.Checked = true;

            metroComboBox1.SelectedIndex = 0;
            metroComboBox2.SelectedIndex = 1;

            geo = 1;

            FromDateTime.Value = DateTime.Now.AddDays(-365);
            ToDateTime.Value = DateTime.Now;

        }
       
        private DataTable getStaff()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("SELECT * FROM staff");
            table.Load(reader);
            return table;
        }

        public void dateGenerator(int year)
        {
                  
           int x = 3; int monthlatest = 4; int theMonth = 4;
           
            int index = 6;

            for (int i = 0; i < 3; i++)
            {
                evalDates[i] = Convert.ToDateTime(theMonth.ToString() + "/" + "1" + "/" + (year - 2).ToString());
                evalDates[i + 3] = Convert.ToDateTime(theMonth.ToString() + "/" + "1" + "/" + (year - 1).ToString());
                theMonth = theMonth + 4;
            }

            for (int i = 0; i < x; i++)
            {
                evalDates[index] = Convert.ToDateTime(monthlatest.ToString() + "/" + "1" + "/" + year.ToString());
                index++;
                monthlatest = monthlatest + 4;
            }
            
        }

        public void displayChart()
        {


            for (int i = 0; i < 8; i++)
            {

                evalGrades1[i] = 0;
                evalGrades2[i] = 0;
            }

            this.comparisonchart.Series.Clear();

            if (comparisonchart.Series.IsUniqueName(empName1))
            {

                this.comparisonchart.Series.Add(empName1);
                this.comparisonchart.Series[empName1].Name = empName1;
            }
            else
            {
                empName1 = empName1 + "1";
                this.comparisonchart.Series.Add(empName1);
                this.comparisonchart.Series[empName1].Name = empName1;
            }

            if (empName2 == null)
            {
                MySqlDataReader nullDetectorReader = DBConnection.getData("select concat(first_name, ' ', last_name) as name, staff_id from staff order by first_name limit 3");
                while (nullDetectorReader.Read())
                {
                    empName2 = nullDetectorReader.GetString("name");
                }
                nullDetectorReader.Close();
            }


            if (comparisonchart.Series.IsUniqueName(empName2))
            {

                this.comparisonchart.Series.Add(empName2);
                this.comparisonchart.Series[empName2].Name = empName2;
            }
            else
            {
                empName2 = empName2 + "1";
                this.comparisonchart.Series.Add(empName2);
                this.comparisonchart.Series[empName2].Name = empName2;
            }


            this.comparisonchart.Series[empName1].Points.Clear();
            this.comparisonchart.Series[empName2].Points.Clear();

            if (metroRadioButton7.Checked)
            {
                this.comparisonchart.Series[empName1].ChartType = SeriesChartType.Line;
                this.comparisonchart.Series[empName2].ChartType = SeriesChartType.Line;
            }
            else
            {
                this.comparisonchart.Series[empName1].ChartType = SeriesChartType.Column;
                this.comparisonchart.Series[empName2].ChartType = SeriesChartType.Column;

            }

            this.comparisonchart.Series[empName1].CustomProperties = "LabelStyle=Top";
            this.comparisonchart.Series[empName1].Font = new Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comparisonchart.Series[empName1].IsValueShownAsLabel = true;
            this.comparisonchart.Series[empName1].LabelForeColor = Color.DeepSkyBlue;

            this.comparisonchart.Series[empName2].CustomProperties = "LabelStyle=Top";
            this.comparisonchart.Series[empName2].Font = new Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comparisonchart.Series[empName2].IsValueShownAsLabel = true;
            this.comparisonchart.Series[empName2].LabelForeColor = Color.DarkOrange;

            

            for (int i = 0; i < 8; i++)
            {
                if (JPRadioBtn.Checked)
                {
                    MySqlDataReader evalreader = DBConnection.getData("SELECT IFNULL(SUM(knowledge+Saftey+Quality+Adaptability+Productivity+Initiative), 0) as totgrade FROM job_performance where staff_id = " + staffIdEmp1 + " and DATE(perf_year) = '" + evalDates[i].ToString("y/M/d") + "'");
                    runReader(evalreader, evalGrades1, i);
                }
                else if (CRRadioBtn.Checked)
                {
                    MySqlDataReader evalreader = DBConnection.getData("SELECT IFNULL(SUM(telephone_skills+problem_resolution+salesmanship+pro_activeness+politeness), 0) as totgrade FROM client_relations where staff_id = " + staffIdEmp1 + " and DATE(rel_year) = '" + evalDates[i].ToString("y/M/d") + "'");
                    runReader(evalreader, evalGrades1, i);
                }
                else if (CSRadioBtn.Checked)
                {
                    MySqlDataReader evalreader = DBConnection.getData("SELECT IFNULL(SUM(influence+presentation+relationship+listening+negotiation), 0) as totgrade FROM communication_skills where staff_id = " + staffIdEmp1 + " and DATE(comm_year) = '" + evalDates[i].ToString("y/M/d") + "'");
                    runReader(evalreader, evalGrades1, i);
                }
                else if (ISRadioBtn.Checked)
                {
                    MySqlDataReader evalreader = DBConnection.getData("SELECT IFNULL(SUM(interaction_with_customers+interaction_with_supervisors+interaction_with_clients+motivational_skills+leadership), 0) as totgrade FROM interpersonal_skills where staff_id = " + staffIdEmp1 + " and DATE(inter_year) = '" + evalDates[i].ToString("y/M/d") + "'");
                    runReader(evalreader, evalGrades1, i);
                }
                else {
                    MySqlDataReader evalreader = DBConnection.getData("SELECT IFNULL(SUM(jp.knowledge+jp.Saftey+jp.Quality+jp.Adaptability+jp.Productivity+jp.Initiative+cr.telephone_skills+cr.problem_resolution+cr.salesmanship+cr.pro_activeness+cr.politeness+cs.influence+cs.presentation+cs.relationship+cs.listening+cs.negotiation+ps.interaction_with_customers+ps.interaction_with_supervisors+ps.interaction_with_clients+ps.motivational_skills+ps.leadership), 0) as totgrade FROM job_performance as jp INNER JOIN communication_skills as cs ON jp.staff_id = cs.staff_id INNER JOIN interpersonal_skills as ps ON cs.staff_id = ps.staff_id INNER JOIN client_relations as cr ON ps.staff_id = cr.staff_id WHERE jp.staff_id = " + staffIdEmp1 + " and jp.perf_year = '" + evalDates[i].ToString("y/M/d") + "'");
                    runReader(evalreader, evalGrades1, i);
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (JPRadioBtn.Checked)
                {
                    MySqlDataReader evalreader = DBConnection.getData("SELECT IFNULL(SUM(knowledge+Saftey+Quality+Adaptability+Productivity+Initiative), 0) as totgrade FROM job_performance where staff_id = " + staffIdEmp2 + " and DATE(perf_year) = '" + evalDates[i].ToString("y/M/d") + "'");
                    runReader(evalreader, evalGrades2, i);
                }
                else if (CRRadioBtn.Checked)
                {
                    MySqlDataReader evalreader = DBConnection.getData("SELECT IFNULL(SUM(telephone_skills+problem_resolution+salesmanship+pro_activeness+politeness), 0) as totgrade FROM client_relations where staff_id = " + staffIdEmp2 + " and DATE(rel_year) = '" + evalDates[i].ToString("y/M/d") + "'");
                    runReader(evalreader, evalGrades2, i);
                }
                else if (CSRadioBtn.Checked)
                {
                    MySqlDataReader evalreader = DBConnection.getData("SELECT IFNULL(SUM(influence+presentation+relationship+listening+negotiation), 0) as totgrade FROM communication_skills where staff_id = " + staffIdEmp2 + " and DATE(comm_year) = '" + evalDates[i].ToString("y/M/d") + "'");
                    runReader(evalreader, evalGrades2, i);
                }
                else if (ISRadioBtn.Checked)
                {
                    MySqlDataReader evalreader = DBConnection.getData("SELECT IFNULL(SUM(interaction_with_customers+interaction_with_supervisors+interaction_with_clients+motivational_skills+leadership), 0) as totgrade FROM interpersonal_skills where staff_id = " + staffIdEmp2 + " and DATE(inter_year) = '" + evalDates[i].ToString("y/M/d") + "'");
                    runReader(evalreader, evalGrades2, i);

                }
                else {
                    MySqlDataReader evalreader = DBConnection.getData("SELECT IFNULL(SUM(jp.knowledge+jp.Saftey+jp.Quality+jp.Adaptability+jp.Productivity+jp.Initiative+cr.telephone_skills+cr.problem_resolution+cr.salesmanship+cr.pro_activeness+cr.politeness+cs.influence+cs.presentation+cs.relationship+cs.listening+cs.negotiation+ps.interaction_with_customers+ps.interaction_with_supervisors+ps.interaction_with_clients+ps.motivational_skills+ps.leadership), 0) as totgrade FROM job_performance as jp INNER JOIN communication_skills as cs ON jp.staff_id = cs.staff_id INNER JOIN interpersonal_skills as ps ON cs.staff_id = ps.staff_id INNER JOIN client_relations as cr ON ps.staff_id = cr.staff_id WHERE jp.staff_id = " + staffIdEmp2 + " and jp.perf_year = '" + evalDates[i].ToString("y/M/d") + "' order by jp.staff_id");
                    runReader(evalreader, evalGrades2, i);
                }
            }
            for (int i = 0; i < 9; i++)
            {

                this.comparisonchart.Series[empName1].Points.AddXY(evalDates[i].ToString("Y"), evalGrades1[i]);
                this.comparisonchart.Series[empName2].Points.AddXY(evalDates[i].ToString("Y"), evalGrades2[i]);
            }

        }

        private DataTable getEmployees()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("select concat(first_name, ' ', last_name) as fullname, staff_id from staff order by first_name");
            table.Load(reader);
            return table;
        }

        public void runReader(MySqlDataReader reader, int[] evalGrades,int i)
        {
            while (reader.Read())
            {

                if (reader.HasRows)
                {
                    if (JPRadioBtn.Checked)
                    {
                        evalGrades[i] = (int)reader.GetInt32("totgrade") * 1 / 6;
                    }
                    else if (CRRadioBtn.Checked || CSRadioBtn.Checked || ISRadioBtn.Checked)
                    {
                        evalGrades[i] = (int)reader.GetInt32("totgrade") * 1 / 5;
                    }
                    else {
                        evalGrades[i] = (int)reader.GetInt32("totgrade") * 1 / 5;
                    }
                }
                else
                {
                    evalGrades[i] = (int)reader.GetInt32("totgrade");

                }

            }
            reader.Close();
        }

        private DataTable jobPerformanceTop20()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("select s.staff_id, s.first_name, s.last_name, s.tel1, s.tel2, s.email, s.p_address, sum(jb.knowledge + jb.Saftey + jb.Quality + jb.Adaptability + jb.Productivity + jb.Initiative) as total from staff as s Inner join job_performance as jb on s.staff_id = jb.staff_id group by staff_id order by total desc limit 2");
            table.Load(reader);
            return table;
        }

        private DataTable jobPerformanceTop50()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("select s.staff_id,s.first_name,s.last_name,s.tel1,s.tel2,s.email,s.p_address,sum(jb.knowledge+jb.Saftey+jb.Quality+jb.Adaptability+jb.Productivity+jb.Initiative) as total from staff as s Inner join job_performance as jb on s.staff_id = jb.staff_id group by staff_id order by total desc limit 3");
            table.Load(reader);
            return table;
        }

        private DataTable clientRelationsTop20()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("select s.staff_id, s.first_name, s.last_name, s.tel1, s.tel2, s.email, s.p_address, sum(cr.telephone_skills + cr.problem_resolution + cr.salesmanship + cr.pro_activeness + cr.politeness) as total from staff as s Inner join client_relations as cr on s.staff_id = cr.staff_id group by staff_id order by total desc limit 2");
            table.Load(reader);
            return table;
        }

        private DataTable clientRelationsTop50()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("select s.staff_id,s.first_name,s.last_name,s.tel1,s.tel2,s.email,s.p_address,sum(cr.telephone_skills + cr.problem_resolution + cr.salesmanship + cr.pro_activeness + cr.politeness) as total from staff as s Inner join client_relations as cr on s.staff_id = cr.staff_id group by staff_id order by total desc limit 3");
            table.Load(reader);
            return table;
        }

        private DataTable communicationSkillsTop20()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("select s.staff_id, s.first_name, s.last_name, s.tel1, s.tel2, s.email, s.p_address, sum(cs.influence + cs.presentation + cs.relationship + cs.listening + cs.negotiation) as total from staff as s Inner join communication_skills as cs on s.staff_id = cs.staff_id group by staff_id order by total desc limit 2");
            table.Load(reader);
            return table;
        }

        private DataTable communicationSkillsTop50()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("select s.staff_id, s.first_name, s.last_name, s.tel1, s.tel2, s.email, s.p_address, sum(cs.influence + cs.presentation + cs.relationship + cs.listening + cs.negotiation) as total from staff as s Inner join communication_skills as cs on s.staff_id = cs.staff_id group by staff_id order by total desc limit 3");
            table.Load(reader);
            return table;
        }

        private DataTable interpersonalSkillsTop20()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("select s.staff_id, s.first_name, s.last_name, s.tel1, s.tel2, s.email, s.p_address, sum(ins.interaction_with_customers + ins.interaction_with_supervisors + ins.interaction_with_clients + ins.motivational_skills + ins.leadership) as total from staff as s Inner join interpersonal_skills as ins on s.staff_id = ins.staff_id group by staff_id order by total desc limit 3");
            table.Load(reader);
            return table;
        }

        private DataTable interpersonalSkillsTop50()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("select s.staff_id, s.first_name, s.last_name, s.tel1, s.tel2, s.email, s.p_address, sum(ins.interaction_with_customers + ins.interaction_with_supervisors + ins.interaction_with_clients + ins.motivational_skills + ins.leadership) as total from staff as s Inner join interpersonal_skills as ins on s.staff_id = ins.staff_id group by staff_id order by total desc limit 3");
            table.Load(reader);
            return table;
        }

        private DataTable customNumberForJobPerformanceTopEmps()
        {
            string limit = "";
            try
            {
                
            }
            catch (Exception) {
                 limit = "";
            }
            try
            {
                DataTable table = new DataTable();
                MySqlDataReader reader = DBConnection.getData("select s.staff_id, s.first_name, s.last_name, s.tel1, s.tel2, s.email, s.p_address, sum(ins.interaction_with_customers + ins.interaction_with_supervisors + ins.interaction_with_clients + ins.motivational_skills + ins.leadership) as total from staff as s Inner join interpersonal_skills as ins on s.staff_id = ins.staff_id group by staff_id order by total desc limit '" + limit + "'");
                table.Load(reader);
                return table;
            }
            catch(Exception ex) {
                MessageBox.Show("Something went wrong! '" + ex + "'", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DataTable table = new DataTable();
                return table;
            }
        }

        private DataTable customNumberForClientRelationsTopEmps()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("select s.staff_id, s.first_name, s.last_name, s.tel1, s.tel2, s.email, s.p_address, sum(ins.interaction_with_customers + ins.interaction_with_supervisors + ins.interaction_with_clients + ins.motivational_skills + ins.leadership) as total from staff as s Inner join interpersonal_skills as ins on s.staff_id = ins.staff_id group by staff_id order by total desc limit 2");
            table.Load(reader);
            return table;
        }

        private DataTable customNumberForCommunicationSkillsTopEmps()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("select s.staff_id, s.first_name, s.last_name, s.tel1, s.tel2, s.email, s.p_address, sum(ins.interaction_with_customers + ins.interaction_with_supervisors + ins.interaction_with_clients + ins.motivational_skills + ins.leadership) as total from staff as s Inner join interpersonal_skills as ins on s.staff_id = ins.staff_id group by staff_id order by total desc limit 2");
            table.Load(reader);
            return table;
        }

        private DataTable customNumberForInterpersonalSkillsTopEmps()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("select s.staff_id, s.first_name, s.last_name, s.tel1, s.tel2, s.email, s.p_address, sum(ins.interaction_with_customers + ins.interaction_with_supervisors + ins.interaction_with_clients + ins.motivational_skills + ins.leadership) as total from staff as s Inner join interpersonal_skills as ins on s.staff_id = ins.staff_id group by staff_id order by total desc limit ");
            table.Load(reader);
            return table;
        }

        private DataTable searchEmployees()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("SELECT * FROM attendanceView WHERE (FirstName LIKE '%"+searchStaffAttendanceTxtBox.Text+ "%' OR LastName LIKE '%"+searchStaffAttendanceTxtBox.Text+"%' OR staffId LIKE '%" + searchStaffAttendanceTxtBox.Text + "%') AND (DATE(InTime) >= '"+FromDateTime.Value.ToString("y/M/d")+ "' AND DATE(InTime) <= '" + ToDateTime.Value.ToString("y/M/d") + "')");
            table.Load(reader);
            return table;
            
        }

        private DataTable searchFromStaff()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("SELECT * FROM staff WHERE first_name LIKE '%" + selectEmployeeTxtbox.Text + "%' OR last_name LIKE '%" + selectEmployeeTxtbox.Text + "%' OR  staff_id LIKE '%" + selectEmployeeTxtbox.Text + "%'");
            table.Load(reader);
            return table;

        }

        private DataTable getAttendance()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("SELECT staff_id as StaffId,in_time as InTime,out_time as OutTime, total_hours as TotalHours FROM attendance");
            table.Load(reader);
            return table;

        }

        private DataTable staffEvaluationGetAttendace()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("SELECT * from attendanceView");
            table.Load(reader);
            return table;

        }

        private DataTable getAttendanceByDate()
        {
            DateTime myDateTime = staffDateTime1.Value;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd");
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("SELECT * FROM attendanceview where DATE(InTime) = '" + sqlFormattedDate + "'");
            table.Load(reader);
            return table;
        }

        private DataTable getAttendanceByDate1()
        {
            DateTime myDateTime = staffDateTime2.Value;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd");
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("SELECT * FROM attendanceview where DATE(OutTime) = '" + sqlFormattedDate + "'");
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
            try
            {
                staffAttendanceDataGrid.DataSource = searchEmployees();
                
            }
            catch(Exception ex) {
                MessageBox.Show("Something went wrong! '" + ex + "'", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {

            staffAttendanceDataGrid.DataSource = searchEmployees();
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

        private void staffDateTime1_ValueChanged(object sender, EventArgs e)
        {
            staffAttendanceDataGrid.DataSource = getAttendanceByDate();
        }

        private void staffDateTime2_ValueChanged(object sender, EventArgs e)
        {
            staffAttendanceDataGrid.DataSource = getAttendanceByDate1();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            staffAttendanceDataGrid.DataSource = staffEvaluationGetAttendace();
        }

        private void selectEmployeeTxtbox_TextChanged(object sender, EventArgs e)
        {
            metroGrid3.DataSource = searchFromStaff();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
            this.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            staffIdEmp1 = Int32.Parse(metroComboBox1.SelectedValue.ToString());

            if ((staffIdEmp1 == staffIdEmp2) && (geo == 1)) {
                MessageBox.Show("You Selected the same employee", "Employee Evaluation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metroComboBox1.SelectedIndex = 0;
            }

            MySqlDataReader staff1reader = DBConnection.getData("SELECT concat(first_name, ' ', last_name) as Name from staff where staff_id = " + staffIdEmp1 + "");
            while (staff1reader.Read())
            {
                empName1 = staff1reader.GetString("Name");
            }
            staff1reader.Close();


            displayChart();
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            staffIdEmp2 = Int32.Parse(metroComboBox2.SelectedValue.ToString());

            if ((staffIdEmp2 == staffIdEmp1) && (geo == 1))

            {
                MessageBox.Show("You Selected the same employee", "Employee Evaluation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metroComboBox2.SelectedIndex = 1;
            }

            MySqlDataReader staff2reader = DBConnection.getData("SELECT concat(first_name, ' ', last_name) as Name from staff where staff_id = " + staffIdEmp2 + "");
            while (staff2reader.Read())
            {
                empName2 = staff2reader.GetString("Name");

            }
            staff2reader.Close();


            displayChart();
        }

        private void metroRadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            displayChart();
        }

        private void metroRadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            displayChart();
        }

        private void JPRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            displayChart();
        }

        private void CRRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            displayChart();
        }

        private void ISRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            displayChart();
        }

        private void FromComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedYear = FromComboBox.SelectedValue.ToString();
            int selectedYearint = Int32.Parse(selectedYear);
         
                dateGenerator(selectedYearint);
                displayChart();
           

        }

        private void FromDateTime_ValueChanged(object sender, EventArgs e)
        {

            staffAttendanceDataGrid.DataSource = searchEmployees();
        }

        private void ToDateTime_ValueChanged(object sender, EventArgs e)
        {

            staffAttendanceDataGrid.DataSource = searchEmployees();
        }
    }
}
