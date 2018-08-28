using ResoflexClientHandlingSystem.Core;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResoflexClientHandlingSystem
{

    public partial class EvaluateEmployeeForm : MetroFramework.Forms.MetroForm
    {

        int employeeNo = 0;
        string employeeName = "";
        public EvaluateEmployeeForm(int emp_no, string emp_name)
        {
            InitializeComponent();

           
            this.Text = emp_name;
            metroLabel1.Text = emp_no.ToString();

            employeeName = emp_name;
            employeeNo = emp_no;


        }

        public EvaluateEmployeeForm() {

            InitializeComponent();

        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel21_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel22_Click(object sender, EventArgs e)
        {

        }

        private void EvaluateEmployeeForm_Load(object sender, EventArgs e)
        {

            int gradeCount = 0;
            int EmptotalGrade = 0;
            double percentileDivide = 0;
            double percentile = 0;
            int totalGradeCount = 0;
            MySqlDataReader reader7 = DBConnection.getData("SELECT SUM(total) from jobperformance where emp_no = '" + employeeNo + "'group by emp_no");
            while (reader7.Read()) {
                EmptotalGrade = reader7.GetInt32("SUM(total)");
            }
            reader7.Close();

            MySqlDataReader reader8 = DBConnection.getData("SELECT COUNT(*) FROM(SELECT j.emp_no FROM jobperformance j GROUP BY j.emp_no HAVING SUM(j.total) <= '"+ EmptotalGrade + "') tmp");
            while (reader8.Read()) {
                gradeCount = reader8.GetInt32("count(*)");
            }
            reader8.Close();

            MySqlDataReader reader9 = DBConnection.getData("select count(*) from (select sum(total) from jobperformance group by emp_no) temp");
            while (reader9.Read())
            {
                totalGradeCount = reader9.GetInt32("count(*)");
            }
            reader9.Close();

            try
            {
                percentileDivide = (double)gradeCount / totalGradeCount;
            }
            catch (Exception) {
                Console.Write(e);
            }
          
            percentile = percentileDivide * 100;
            metroLabel25.Text = percentile.ToString();

            MySqlDataReader reader6 = DBConnection.getData("SELECT COUNT(*) as count,Grade FROM employeeprojects where emp_no = '" + employeeNo + "' group by grade");

            int i = 0;
                while (reader6.Read())
                {

                    switch (i) {
                        case 0:
                            metroLabel18.Text = reader6.GetString("count");
                        i++;
                            break;
                        case 1:
                            metroLabel17.Text = reader6.GetString("count");
                        i++;
                        break;
                        case 2:
                            metroLabel16.Text = reader6.GetString("count");
                        i++;
                        break;
                        case 3:
                            metroLabel15.Text = reader6.GetString("count");
                        i++;
                        break;
                        case 4:
                            metroLabel14.Text = reader6.GetString("count");
                        i++;
                        break;
                    }
                
            }
            reader6.Close();

            //MySqlDataReader reader = DBConnection.getData("SELECT * FROM jobperformance where emp_no = 23");
            //while(reader.Read()) {
            //    this.chart2.Series["Grading"].Points.AddXY("knowledge",reader.GetInt32("knowledge"));
            //    this.chart2.Series["Grading"].Points.AddXY("Safety", reader.GetInt32("safety"));
            //    this.chart2.Series["Grading"].Points.AddXY("Quality", reader.GetInt32("quality"));
            //    this.chart2.Series["Grading"].Points.AddXY("Adaptability", reader.GetInt32("adaptability"));
            //    this.chart2.Series["Grading"].Points.AddXY("Productivity", reader.GetInt32("productivity"));
            //    this.chart2.Series["Grading"].Points.AddXY("Initiative", reader.GetInt32("Initiative"));

            //}
            //reader.Close();



            MySqlDataReader reader5 = DBConnection.getData("SELECT * FROM jobperformance where date = '" + metroComboBox1.Text + "'");
            while (reader5.Read())
            {
                // total1 = (reader5.GetInt32("total"));
            }
            reader5.Close();









            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;





           /*metroComboBox1.SelectedIndex = 0;
           metroComboBox2.SelectedIndex = 0;
           */

            metroLabel31.Text = DateTime.Now.Year.ToString();

            MySqlDataReader reader2 = DBConnection.getData("SELECT date FROM jobperformance where emp_no = '" + employeeNo + "'");

            DataTable tb = new DataTable();

            tb.Load(reader2);

            metroComboBox1.DataSource = tb;
            metroComboBox1.ValueMember = "date";
            metroComboBox1.DisplayMember = "date";
            reader2.Close();

            MySqlDataReader reader4 = DBConnection.getData("SELECT date FROM jobperformance where emp_no = '" + employeeNo + "'");

            DataTable tb1 = new DataTable();

            tb.Load(reader2);

            metroComboBox2.DataSource = tb1;
            metroComboBox2.ValueMember = "date";
            metroComboBox2.DisplayMember = "date";
            reader4.Close();



            //MySqlDataReader reader4 = DBConnection.getData("SELECT * FROM jobperformance where emp_no = '" + employeeNo + "'");
            //while (reader4.Read())
            //{
            //    metroComboBox2.Items.Add(reader4.GetInt32("date"));
            //}
            //reader4.Close();


        }
       

        private void metroTile7_Click(object sender, EventArgs e)
        {
            JobPerformanceAddEntryForm obj = new JobPerformanceAddEntryForm();
            obj.Show();
        }

        int total1 = 0;
        int total2 = 0;
        int finalTotal = 0;
        double dividedAmount = 0;

        double finalPercentage = 0;

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayChart2();
            MySqlDataReader reader6 = DBConnection.getData("SELECT * FROM jobperformance where date = '" + metroComboBox1.Text + "'and emp_no = '" + employeeNo + "'");
            while (reader6.Read())
            {
                total1 = reader6.GetInt32("total");
                

            }
            reader6.Close();


        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayChart1();
            MySqlDataReader reader6 = DBConnection.getData("SELECT * FROM jobperformance where date = '" + metroComboBox2.Text.ToString() + "'and emp_no = '" + employeeNo + "'");
            while (reader6.Read())
            {
                total2 = reader6.GetInt32("total");
            }
            reader6.Close();

        }

       

        public void displayChart2()
        {
            this.chart2.Series["Grading"].Points.Clear();
            this.chart2.Series["Grading"].Points.Clear();

            MySqlDataReader reader3 = DBConnection.getData("SELECT * FROM jobperformance where date = '" + metroComboBox1.Text.ToString() + "' and emp_no = " + employeeNo + ";");
            while (reader3.Read())
            {
                this.chart2.Series["Grading"].Points.AddXY("knowledge", reader3.GetInt32("knowledge"));
                this.chart2.Series["Grading"].Points.AddXY("Safety", reader3.GetInt32("safety"));
                this.chart2.Series["Grading"].Points.AddXY("Quality", reader3.GetInt32("quality"));
                this.chart2.Series["Grading"].Points.AddXY("Adaptability", reader3.GetInt32("adaptability"));
                this.chart2.Series["Grading"].Points.AddXY("Productivity", reader3.GetInt32("productivity"));
                this.chart2.Series["Grading"].Points.AddXY("Initiative", reader3.GetInt32("Initiative"));

            }
            reader3.Close();
        }

        public void displayChart1()
        {
            this.chart1.Series["Grading"].Points.Clear();
            this.chart1.Series["Grading"].Points.Clear();

            MySqlDataReader reader3 = DBConnection.getData("SELECT * FROM jobperformance where date = '" + metroComboBox2.Text + "' and emp_no = '" + employeeNo + "'");
            while (reader3.Read())
            {
                this.chart1.Series["Grading"].Points.AddXY("knowledge", reader3.GetInt32("knowledge"));
                this.chart1.Series["Grading"].Points.AddXY("Safety", reader3.GetInt32("safety"));
                this.chart1.Series["Grading"].Points.AddXY("Quality", reader3.GetInt32("quality"));
                this.chart1.Series["Grading"].Points.AddXY("Adaptability", reader3.GetInt32("adaptability"));
                this.chart1.Series["Grading"].Points.AddXY("Productivity", reader3.GetInt32("productivity"));
                this.chart1.Series["Grading"].Points.AddXY("Initiative", reader3.GetInt32("Initiative"));

            }
            reader3.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        public void finalTotalGet()
        {
             finalTotal = total2 - total1;

             dividedAmount = (double)finalTotal/total1;

            finalPercentage = dividedAmount * 100;
            int FP = Convert.ToInt32(finalPercentage);
             metroTextBox3.Text = dividedAmount.ToString();
            metroTextBox4.Text = FP.ToString();

            if (FP < 0)
            {
                int myInt = System.Math.Abs(FP);

                if (myInt > 100)
                {
                    myInt = 100;
                }

                metroLabel27.Text = "";
                circularProgressBar2.Visible = false;
                circularProgressBar1.Visible = true;
                for (int i = 1; i <= myInt; i++)
                {

                    Thread.Sleep(25);
                    
                    circularProgressBar1.Value = i;
                    circularProgressBar1.Text = i.ToString();
                    circularProgressBar1.Update();
                }
            }
            else if (FP > 0)
            {
                if (FP>100) {
                    FP = 100;
                }
                int myInt = System.Math.Abs(FP);
                metroLabel27.Text = "";
                circularProgressBar1.Visible = false;
                circularProgressBar2.Visible = true;
                for (int i = 1; i <= FP; i++)
                {

                    Thread.Sleep(25);
                    
                    circularProgressBar2.Value = i;
                    circularProgressBar2.Text = i.ToString();
                    circularProgressBar2.Update();
                }
            }
            else {

                circularProgressBar1.Value = 0;
                circularProgressBar2.Value = 0;
                circularProgressBar1.Text = 0.ToString();
                circularProgressBar2.Text = 0.ToString();
                metroLabel27.Text = "NO IMPROVEMENT(0%)";

            }
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            finalTotalGet();
        }

        private void metroTabPage6_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel28_Click(object sender, EventArgs e)
        {

        }

        private void circularProgressBar2_Click(object sender, EventArgs e)
        {

        }
    }
}
