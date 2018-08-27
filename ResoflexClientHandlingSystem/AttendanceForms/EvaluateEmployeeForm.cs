
using ResoflexClientHandlingSystem.Role;
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
using ResoflexClientHandlingSystem.AttendanceForms;

namespace ResoflexClientHandlingSystem
{

    public partial class EvaluateEmployeeForm : MetroFramework.Forms.MetroForm
    {

        int employeeNo;
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
            metroTabControl3.SelectedIndexChanged += new EventHandler(metroTabControl3_SelectedIndexChanged);

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
            metroComboBox1.Text = "";
            metroComboBox2.Text = "";
            //-----------------------------------Variables for JP-----------------
            int gradeCountJP = 0;
            int EmptotalGradeJP = 0;
            int totalGradeCountJP = 0;
            double percentileDivideJP = 0;
            double percentileJP = 0;
            //--------------------------------------------------------------------

            //-----------------------------------Variables for CR-----------------
            int gradeCountCR = 0;
            int EmptotalGradeCR = 0;
            int totalGradeCountCR = 0;
            double percentileDivideCR = 0;
            double percentileCR = 0;
            //--------------------------------------------------------------------

            //-----------------------------------Variables for CS-----------------
            int gradeCountCS = 0;
            int EmptotalGradeCS = 0;
            int totalGradeCountCS = 0;
            double percentileDivideCS = 0;
            double percentileCS = 0;
            //--------------------------------------------------------------------

            //-----------------------------------Variables for IS-----------------
            int gradeCountIS = 0;
            int EmptotalGradeIS = 0;
            int totalGradeCountIS = 0;
            double percentileDivideIS = 0;
            double percentileIS = 0;
            //--------------------------------------------------------------------
            projectShortcomingsGrid.DataSource = getProjectShortcomings();
            //-----------------------------------------------------------------------------------------------------JP-----------------------
            MySqlDataReader reader7 = DBConnection.getData("SELECT SUM(knowledge+Saftey+Quality+Adaptability+Productivity+Initiative) as total from job_performance where staff_id = '" + employeeNo + "'group by staff_id");
            while (reader7.Read()) {
                EmptotalGradeJP = reader7.GetInt32("total");
            }
            reader7.Close();

            MySqlDataReader reader8 = DBConnection.getData("SELECT COUNT(*) FROM(SELECT j.staff_id FROM job_performance j GROUP BY j.staff_id HAVING SUM(knowledge+Saftey+Quality+Adaptability+Productivity+Initiative) <= '" + EmptotalGradeJP + "') tmp");
            while (reader8.Read()) {
                gradeCountJP = reader8.GetInt32("count(*)");
            }
            reader8.Close();

            MySqlDataReader reader9 = DBConnection.getData("select count(*) from (select sum(knowledge+Saftey+Quality+Adaptability+Productivity+Initiative) from job_performance group by staff_id) temp");
            while (reader9.Read())
            {
                totalGradeCountJP = reader9.GetInt32("count(*)");
            }
            reader9.Close();

            try
            {
                percentileDivideJP = (double)gradeCountJP / totalGradeCountJP;
            }
            catch (Exception) {
                MessageBox.Show("Something went wrong when calculating the percentile", "Logging out", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //---------------------------------------------------------------------------------------------------------------------------------



            //-----------------------------------------------------------------------------------------------------CR-----------------------
            MySqlDataReader clientRelationsReader = DBConnection.getData("SELECT SUM(telephone_skills+problem_resolution+salesmanship+pro_activeness+politeness) as total from client_relations where staff_id = '" + employeeNo + "'group by staff_id");
            while (clientRelationsReader.Read())
            {
                EmptotalGradeCR = clientRelationsReader.GetInt32("total");
            }
            clientRelationsReader.Close();

            MySqlDataReader clientRelationsReader1 = DBConnection.getData("SELECT COUNT(*) FROM(SELECT j.staff_id FROM client_relations j GROUP BY j.staff_id HAVING SUM(telephone_skills+problem_resolution+salesmanship+pro_activeness+politeness) <= '" + EmptotalGradeCR + "') tmp");
            while (clientRelationsReader1.Read())
            {
                gradeCountCR = clientRelationsReader1.GetInt32("count(*)");
            }
            clientRelationsReader1.Close();

            MySqlDataReader clientRelationsReader2 = DBConnection.getData("select count(*) from (select sum(telephone_skills+problem_resolution+salesmanship+pro_activeness+politeness) from client_relations group by staff_id) temp");
            while (clientRelationsReader2.Read())
            {
                totalGradeCountCR = clientRelationsReader2.GetInt32("count(*)");
            }
            clientRelationsReader2.Close();

            try
            {
                percentileDivideCR = (double)gradeCountCR / totalGradeCountCR;
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong when calculating the percentile", "Logging out", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //----------------------------------------------------------------------------------------------------------------------------------------------------------


            //-----------------------------------------------------------------------------------------CS-----------------------------------------------------------------
            MySqlDataReader CommunicationSkillsReader = DBConnection.getData("SELECT SUM(influence+presentation+relationship+listening+negotiation) as total from communication_skills where staff_id = '" + employeeNo + "'group by staff_id");
            while (CommunicationSkillsReader.Read())
            {
                EmptotalGradeCS = CommunicationSkillsReader.GetInt32("total");
            }
            CommunicationSkillsReader.Close();

            MySqlDataReader CommunicationSkillsReader1 = DBConnection.getData("SELECT COUNT(*) FROM(SELECT j.staff_id FROM communication_skills j GROUP BY j.staff_id HAVING SUM(influence+presentation+relationship+listening+negotiation) <= '" + EmptotalGradeCS + "') tmp");
            while (CommunicationSkillsReader1.Read())
            {
                gradeCountCS = CommunicationSkillsReader1.GetInt32("count(*)");
            }
            CommunicationSkillsReader1.Close();

            MySqlDataReader CommunicationSkillsReader2 = DBConnection.getData("select count(*) from (select sum(influence+presentation+relationship+listening+negotiation) from communication_skills group by staff_id) temp");
            while (CommunicationSkillsReader2.Read())
            {
                totalGradeCountCS = CommunicationSkillsReader2.GetInt32("count(*)");
            }
            CommunicationSkillsReader2.Close();

            try
            {
                percentileDivideCS = (double)gradeCountCS / totalGradeCountCS;
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong when calculating the percentile", "Logging out", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //-----------------------------------------------------------------------------------------------------------------------------------------------------------

            //----------------------------------------------------------------------------------------------------IS----------------------------------------------------

            MySqlDataReader interpersonalReader = DBConnection.getData("SELECT SUM(interaction_with_customers+interaction_with_supervisors+interaction_with_clients+motivational_skills+leadership) as total from interpersonal_skills where staff_id = '" + employeeNo + "'group by staff_id");
            while (interpersonalReader.Read())
            {
                EmptotalGradeIS = interpersonalReader.GetInt32("total");
            }
            interpersonalReader.Close();

            MySqlDataReader interpersonalReader1 = DBConnection.getData("SELECT COUNT(*) FROM(SELECT j.staff_id FROM interpersonal_skills j GROUP BY j.staff_id HAVING SUM(interaction_with_customers+interaction_with_supervisors+interaction_with_clients+motivational_skills+leadership) <= '" + EmptotalGradeIS + "') tmp");
            while (interpersonalReader1.Read())
            {
                gradeCountIS = interpersonalReader1.GetInt32("count(*)");
            }
            interpersonalReader1.Close();

            MySqlDataReader interpersonalReader2 = DBConnection.getData("select count(*) from (select sum(interaction_with_customers+interaction_with_supervisors+interaction_with_clients+motivational_skills+leadership) from interpersonal_skills group by staff_id) temp");
            while (interpersonalReader2.Read())
            {
                totalGradeCountIS = interpersonalReader2.GetInt32("count(*)");
            }
            interpersonalReader2.Close();

            try
            {
                percentileDivideIS = (double)gradeCountIS / totalGradeCountIS;
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong when calculating the percentile", "Logging out", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            percentileJP = percentileDivideJP * 100;
            percentileCR = percentileDivideCR * 100;
            percentileCS = percentileDivideCS * 100;
            percentileIS = percentileDivideIS * 100;

            metroLabel25.Text = percentileJP.ToString();
            metroLabel50.Text = percentileCR.ToString();
            metroLabel51.Text = percentileCS.ToString();
            metroLabel52.Text = percentileIS.ToString();


            //MySqlDataReader reader6 = DBConnection.getData("SELECT COUNT(*) as count,Grade FROM employeeprojects where staff_id = '" + employeeNo + "' group by grade");

            //int i = 0;
            //    while (reader6.Read())
            //    {

            //        switch (i) {
            //            case 0:
            //                metroLabel18.Text = reader6.GetString("count");
            //            i++;
            //                break;
            //            case 1:
            //                metroLabel17.Text = reader6.GetString("count");
            //            i++;
            //            break;
            //            case 2:
            //                metroLabel16.Text = reader6.GetString("count");
            //            i++;
            //            break;
            //            case 3:
            //                metroLabel15.Text = reader6.GetString("count");
            //            i++;
            //            break;
            //            case 4:
            //                metroLabel14.Text = reader6.GetString("count");
            //            i++;
            //            break;
            //        }

            //}
            //reader6.Close();

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
            //MySqlDataReader reader5 = DBConnection.getData("SELECT * FROM jobperformance where date = '" + metroComboBox1.Text + "'");
            //while (reader5.Read())
            //{
            //    // total1 = (reader5.GetInt32("total"));
            //}
            //reader5.Close();
            //---------------------------------------------------------------------------------------(BEGIN) DATES FOR COMBO BOXES-----------------------------------------------------------------------------------------
            //Date combo boxes for job performance
            MySqlDataReader reader2 = DBConnection.getData("SELECT DISTINCT(YEAR(perf_year)) AS year " +
                                                           "FROM job_performance WHERE staff_id = " + employeeNo);

            metroComboBox1.Items.Clear();

            while (reader2.Read())
            {
                metroComboBox1.Items.Add(reader2.GetInt32("year"));
            }

            reader2.Close();
            //--------------------------------------------------------------------------------------------------------------------------------------------
            MySqlDataReader reader4 = DBConnection.getData("SELECT DISTINCT(YEAR(perf_year)) AS year " +
                                                           "FROM job_performance WHERE staff_id = " + employeeNo);

            metroComboBox2.Items.Clear();

            while (reader4.Read())
            {
                metroComboBox2.Items.Add(reader4.GetInt32("year"));
            }

            reader4.Close();
            //--------------------------------------------------------------------------------------------------------------------------------------------
            metroComboBox1.SelectedIndex = 0;
            metroComboBox2.SelectedIndex = 1;

            displayChart1();
            displayChart2();
            //-------------------------------------------------------------------------------------------------------------------------------------------
            // End of date combo boxes for job performance
            //Date combo boxes for client relations
            MySqlDataReader dateReaderClientRelations1 = DBConnection.getData("SELECT DISTINCT(YEAR(rel_year)) AS year " +
                                                                              "FROM client_relations WHERE staff_id = " + employeeNo);
            metroComboBox4.Items.Clear();

            while (dateReaderClientRelations1.Read()) {
                metroComboBox4.Items.Add(dateReaderClientRelations1.GetInt32("year"));
            }

            dateReaderClientRelations1.Close();

            MySqlDataReader dateReaderClientRelations2 = DBConnection.getData("SELECT DISTINCT(YEAR(rel_year)) AS year " +
                                                                              "FROM client_relations WHERE staff_id = "+ employeeNo);

            metroComboBox3.Items.Clear();

            while (dateReaderClientRelations2.Read()) {
                metroComboBox3.Items.Add(dateReaderClientRelations2.GetInt32("year"));
            }

            dateReaderClientRelations2.Close();

            metroComboBox3.SelectedIndex = 1;
            metroComboBox4.SelectedIndex = 0;

            displayChart3();
            displayChart4();

            // End of date combo boxes for client relations

            //Date combo boxes for communication skills
            MySqlDataReader dateReaderCommunicationSkills1 = DBConnection.getData("SELECT DISTINCT(YEAR(comm_year)) AS year " +
                                                                              "FROM communication_skills WHERE staff_id = '" + employeeNo + "'");

            metroComboBox6.Items.Clear();

            while (dateReaderCommunicationSkills1.Read()) {
                metroComboBox6.Items.Add(dateReaderCommunicationSkills1.GetInt32("year"));
            }

            dateReaderCommunicationSkills1.Close();

            MySqlDataReader dateReaderCommunicationSkills2 = DBConnection.getData("SELECT DISTINCT(YEAR(comm_year)) AS year " +
                                                                              "FROM communication_skills WHERE staff_id = '" + employeeNo + "'");
            metroComboBox5.Items.Clear();
            while (dateReaderCommunicationSkills2.Read())
            {
                metroComboBox5.Items.Add(dateReaderCommunicationSkills2.GetInt32("year"));
            }
            dateReaderCommunicationSkills2.Close();


            metroComboBox5.SelectedIndex = 1;
            metroComboBox6.SelectedIndex = 0;

            displayChart5();
            displayChart6();

            // End of date combo boxes for communication skills

            //Date combo boxes for interpersonal skills
            MySqlDataReader dateReaderInterpersonalSkills1 = DBConnection.getData("SELECT DISTINCT(YEAR(inter_year)) AS year " +
                                                                              "FROM interpersonal_skills WHERE staff_id = '" + employeeNo + "'");

            metroComboBox8.Items.Clear();
            while (dateReaderInterpersonalSkills1.Read())
            {
                metroComboBox8.Items.Add(dateReaderInterpersonalSkills1.GetInt32("year"));
            }
            dateReaderInterpersonalSkills1.Close();


            MySqlDataReader dateReaderInterpersonalSkills2 = DBConnection.getData("SELECT DISTINCT(YEAR(inter_year)) AS year " +
                                                                              "FROM interpersonal_skills WHERE staff_id = '" + employeeNo + "'");

            metroComboBox7.Items.Clear();
            while (dateReaderInterpersonalSkills2.Read()) { 
            metroComboBox7.Items.Add(dateReaderInterpersonalSkills2.GetInt32("year"));
            
            }
            dateReaderInterpersonalSkills2.Close();

            metroComboBox7.SelectedIndex = 1;
            metroComboBox8.SelectedIndex = 0;

            displayChart7();
            displayChart8();

            // End of date combo boxes for interpersonal skills
            //-------------------------------------------------------------------------------------(END) DATES FOR COMBO BOXES---------------------------------------------------------------------------------------------

            //MySqlDataReader reader10 = DBConnection.getData("SELECT year(perf_year) FROM job_performance where staff_id = '" + employeeNo + "'");
            //while (reader10.Read())
            //{
            //  metroComboBox2.Items.Add(reader10.GetDateTime("year(perf_year)"));
            //}
            //reader10.Close();

            //MySqlDataReader reader11 = DBConnection.getData("SELECT year(perf_year) FROM job_performance where staff_id = '" + employeeNo + "'");
            //while (reader11.Read())
            //{
            //   metroComboBox2.Items.Add(reader11.GetDateTime("year(perf_year)"));
            //}
            //reader11.Close();
            eventTechnicianTasks.DataSource = getTasks();
        }
        //END OF LOAD FUNCTION

        private DataTable getTasks()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("SELECT * FROM event_technician_task");
            table.Load(reader);
            return table;
        }
        private DataTable getProjectShortcomings()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("SELECT * FROM project_shortcomings");
            table.Load(reader);
            return table;
        }

        int total1 = 0;
        int total2 = 0;
        int finalTotal = 0;
        double dividedAmount = 0;

        double finalPercentage = 0;
        int dateVal20 = 0;


        //--------------------------------------------variables for JP----------------------------------------------
        int totalJP1 = 0;
        int totalJP2 = 0;
        int finalTotalJP = 0;
        double dividedAmountJP = 0;
        double finalPercentageJP = 0;
        int dateJP1 = 0;
        int dateJP2 = 0;
        //----------------------------------------------------------------------------------------------------------

        //--------------------------------------------variables for CR----------------------------------------------
        int totalCR1 = 0;
        int totalCR2 = 0;
        int finalTotalCR = 0;
        double dividedAmountCR = 0;
        double finalPercentageCR = 0;
        int dateCR1 = 0;
        int dateCR2 = 0;
        //----------------------------------------------------------------------------------------------------------

        //--------------------------------------------variables for CS----------------------------------------------
        int totalCS1 = 0;
        int totalCS2 = 0;
        int finalTotalCS = 0;
        double dividedAmountCS = 0;
        double finalPercentageCS = 0;
        int dateCS1 = 0;
        int dateCS2 = 0;
        //----------------------------------------------------------------------------------------------------------

        //--------------------------------------------variables for IS----------------------------------------------
        int totalIS1 = 0;
        int totalIS2 = 0;
        int finalTotalIS = 0;
        double dividedAmountIS = 0;
        double finalPercentageIS = 0;
        int dateIS1 = 0;
        int dateIS2 = 0;
        //----------------------------------------------------------------------------------------------------------

        //(BEGIN)Combo box changes
        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
               
                dateJP1 = Int32.Parse(metroComboBox1.SelectedItem.ToString());
                Console.Write("\n Date nothard: " + dateJP1 + "\n");
                displayChart2();
            }
            catch
            {
                //dateJP1 = 2000;
            }
            MySqlDataReader reader6 = DBConnection.getData("SELECT IFNULL(SUM(knowledge+Saftey+Quality+Adaptability+Productivity+Initiative), 0) as total " +
                                                           "FROM job_performance where year(perf_year) = " + dateJP1 + " and staff_id = " + employeeNo);
            while (reader6.Read())
            {
                totalJP1 = reader6.GetInt32("total");
                Console.Write("\n Date hardcoded : "+totalJP1+ "\n");
                Console.Write("\n Date nothard: " + dateJP1 + "\n");
            }
            reader6.Close();
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                dateJP2 = Int32.Parse(metroComboBox2.SelectedItem.ToString());
                
                displayChart1();
            }
            catch(Exception)
            {
                //dateJP2 = 2018;
            }
            MySqlDataReader reader40 = DBConnection.getData("SELECT IFNULL(SUM(knowledge+Saftey+Quality+Adaptability+Productivity+Initiative), 0) as total " +
                                                            "FROM job_performance where year(perf_year) = " + dateJP2 + " and staff_id = " + employeeNo);
            while (reader40.Read())
            {
                totalJP2 = reader40.GetInt32("total");
                Console.Write("\n Date hardcoded : " + totalJP2 + "\n");
                Console.Write("\n Date nothard: " + dateJP2 + "\n");
            }
            reader40.Close();
        }

        public void executeCircularProgressBarJP()
        {
            finalTotalJP = totalJP2 - totalJP1;

            dividedAmountJP = (double)finalTotalJP / totalJP1;

            finalPercentageJP = dividedAmountJP * 100;
            long FP = Convert.ToInt64(finalPercentageJP);
            metroTextBox3.Text = dividedAmountJP.ToString();
            metroTextBox4.Text = FP.ToString();

            if (FP < 0)
            {
                long myInt = System.Math.Abs(FP);

                if (myInt > 100)
                {
                    myInt = 100;
                }

                metroLabel27.Text = "";
                returnReleventProgressBar().Visible = false;
                returnReleventRetrogressBar().Visible = true;
                for (int i = 1; i <= myInt; i++)
                {

                    Thread.Sleep(25);

                    returnReleventRetrogressBar().Value = i;
                    returnReleventRetrogressBar().Text = i.ToString();
                    returnReleventRetrogressBar().Update();
                }

            }
            else if (FP > 0)
            {
                if (FP > 100)
                {
                    FP = 100;
                }
                long myInt = System.Math.Abs(FP);
                metroLabel27.Text = "";
                returnReleventRetrogressBar().Visible = false;
                returnReleventProgressBar().Visible = true;
                for (int i = 1; i <= FP; i++)
                {

                    Thread.Sleep(25);

                    returnReleventProgressBar().Value = i;
                    returnReleventProgressBar().Text = i.ToString();
                    returnReleventProgressBar().Update();
                }

            }
            else
            {

                circularProgressBar1.Value = 0;
                circularProgressBar2.Value = 0;
                circularProgressBar1.Text = 0.ToString();
                circularProgressBar2.Text = 0.ToString();

                circularProgressBar3.Value = 0;
                circularProgressBar4.Value = 0;
                circularProgressBar3.Text = 0.ToString();
                circularProgressBar4.Text = 0.ToString();

                circularProgressBar5.Value = 0;
                circularProgressBar6.Value = 0;
                circularProgressBar5.Text = 0.ToString();
                circularProgressBar6.Text = 0.ToString();

                circularProgressBar7.Value = 0;
                circularProgressBar8.Value = 0;
                circularProgressBar7.Text = 0.ToString();
                circularProgressBar8.Text = 0.ToString();

                metroLabel32.Text = "NO IMPROVEMENT(0%)";
                
                
                
            }
        }

        private void metroComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               
                
                    dateCR1 = Int32.Parse(metroComboBox4.SelectedItem.ToString());
                
                displayChart3();
            }
            catch(Exception) {
                dateCR1 = 2018;
            }
            
            MySqlDataReader reader6 = DBConnection.getData("SELECT SUM(telephone_skills+problem_resolution+salesmanship+pro_activeness+politeness) as total FROM client_relations where year(rel_year) = "+dateCR1+" and staff_id = '" + employeeNo + "'");
            while (reader6.Read())
            {
                totalCR1 = reader6.GetInt32("total");
            }
            reader6.Close();

        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                    dateCR2 = Int32.Parse(metroComboBox3.SelectedItem.ToString());
                
                displayChart4();
            }
            catch (Exception)
            {

                dateCR2 = 2018;
            }
            
            MySqlDataReader reader40 = DBConnection.getData("SELECT SUM(telephone_skills+problem_resolution+salesmanship+pro_activeness+politeness) as total FROM client_relations WHERE year(rel_year) = "+dateCR2+" and staff_id = '" + employeeNo + "'");
            while (reader40.Read())
            {
                totalCR2 = reader40.GetInt32("total");
            }
            reader40.Close();
        }

        public void executeCircularProgressBarCR()
        {
            Console.Write("\n.........here\n");

            finalTotalCR = totalCR2 - totalCR1;

            Console.Write("CR1 : " + totalCR1 + "CR2 : " + totalCR2 + "\n");

            dividedAmountCR = (double)finalTotalCR / totalCR1;

            Console.Write("divid : " + dividedAmountCR + "\n");

            finalPercentageCR = dividedAmountCR * 100;
            int FP = Convert.ToInt32(finalPercentageCR);
            metroTextBox3.Text = dividedAmountCR.ToString();
            metroTextBox4.Text = FP.ToString();

            if (FP < 0)
            {
                int myInt = System.Math.Abs(FP);

                if (myInt > 100)
                {
                    myInt = 100;
                }

                metroLabel27.Text = "";
                returnReleventProgressBar().Visible = false;
                returnReleventRetrogressBar().Visible = true;
                for (int i = 1; i <= myInt; i++)
                {

                    Thread.Sleep(25);

                    returnReleventRetrogressBar().Value = i;
                    returnReleventRetrogressBar().Text = i.ToString();
                    returnReleventRetrogressBar().Update();
                }

            }
            else if (FP > 0)
            {
                if (FP > 100)
                {
                    FP = 100;
                }
                int myInt = System.Math.Abs(FP);
                metroLabel27.Text = "";
                returnReleventRetrogressBar().Visible = false;
                returnReleventProgressBar().Visible = true;
                for (int i = 1; i <= FP; i++)
                {

                    Thread.Sleep(25);

                    returnReleventProgressBar().Value = i;
                    returnReleventProgressBar().Text = i.ToString();
                    returnReleventProgressBar().Update();
                }

            }
            else
            {

                circularProgressBar1.Value = 0;
                circularProgressBar2.Value = 0;
                circularProgressBar1.Text = 0.ToString();
                circularProgressBar2.Text = 0.ToString();

                circularProgressBar3.Value = 0;
                circularProgressBar4.Value = 0;
                circularProgressBar3.Text = 0.ToString();
                circularProgressBar4.Text = 0.ToString();

                circularProgressBar5.Value = 0;
                circularProgressBar6.Value = 0;
                circularProgressBar5.Text = 0.ToString();
                circularProgressBar6.Text = 0.ToString();

                circularProgressBar7.Value = 0;
                circularProgressBar8.Value = 0;
                circularProgressBar7.Text = 0.ToString();
                circularProgressBar8.Text = 0.ToString();

                metroLabel34.Text = "NO IMPROVEMENT(0%)";

            }
        }

        private void metroComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dateCS1 = Int32.Parse(metroComboBox6.SelectedItem.ToString());
                displayChart6();
            }
            catch (Exception) {

                dateCS1 = 2018;
            }

            MySqlDataReader reader6 = DBConnection.getData("SELECT SUM(influence+presentation+relationship+listening+negotiation) as total FROM communication_skills where year(comm_year) = "+ dateCS1 + " and staff_id = '" + employeeNo + "'");
            while (reader6.Read())
            {
                totalCS1 = reader6.GetInt32("total");
            }
            reader6.Close();
        }

        private void metroComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dateCS2 = Int32.Parse(metroComboBox5.SelectedItem.ToString());

                displayChart5();
            }
            catch (Exception)
            {

                dateCS2 = 2018;
            }
            
            MySqlDataReader reader40 = DBConnection.getData("SELECT SUM(influence+presentation+relationship+listening+negotiation) as total FROM communication_skills WHERE year(comm_year) = '" + dateCS2 + "' and staff_id = '" + employeeNo + "'");
            while (reader40.Read())
            {
                totalCS2 = reader40.GetInt32("total");
            }
            reader40.Close();
        }

        public void executeCircularProgressBarCS()
        {
            Console.Write("\n.........here\n");

            finalTotalCS = totalCS2 - totalCS1;

            Console.Write("CR1 : " + totalCS1 + "CR2 : " + totalCS2 + "\n");

            dividedAmountCS = (double)finalTotalCS / totalCS1;

            Console.Write("divid : " + dividedAmountCS + "\n");

            finalPercentageCS = dividedAmountCS * 100;
            int FP = Convert.ToInt32(finalPercentageCS);
            metroTextBox3.Text = dividedAmountCS.ToString();
            metroTextBox4.Text = FP.ToString();

            if (FP < 0)
            {
                int myInt = System.Math.Abs(FP);

                if (myInt > 100)
                {
                    myInt = 100;
                }

                metroLabel27.Text = "";
                returnReleventProgressBar().Visible = false;
                returnReleventRetrogressBar().Visible = true;
                for (int i = 1; i <= myInt; i++)
                {

                    Thread.Sleep(25);

                    returnReleventRetrogressBar().Value = i;
                    returnReleventRetrogressBar().Text = i.ToString();
                    returnReleventRetrogressBar().Update();
                }

            }
            else if (FP > 0)
            {
                if (FP > 100)
                {
                    FP = 100;
                }
                int myInt = System.Math.Abs(FP);
                metroLabel27.Text = "";
                returnReleventRetrogressBar().Visible = false;
                returnReleventProgressBar().Visible = true;
                for (int i = 1; i <= FP; i++)
                {

                    Thread.Sleep(25);

                    returnReleventProgressBar().Value = i;
                    returnReleventProgressBar().Text = i.ToString();
                    returnReleventProgressBar().Update();
                }

            }
            else
            {

                circularProgressBar1.Value = 0;
                circularProgressBar2.Value = 0;
                circularProgressBar1.Text = 0.ToString();
                circularProgressBar2.Text = 0.ToString();

                circularProgressBar3.Value = 0;
                circularProgressBar4.Value = 0;
                circularProgressBar3.Text = 0.ToString();
                circularProgressBar4.Text = 0.ToString();

                circularProgressBar5.Value = 0;
                circularProgressBar6.Value = 0;
                circularProgressBar5.Text = 0.ToString();
                circularProgressBar6.Text = 0.ToString();

                circularProgressBar7.Value = 0;
                circularProgressBar8.Value = 0;
                circularProgressBar7.Text = 0.ToString();
                circularProgressBar8.Text = 0.ToString();

                metroLabel40.Text = "NO IMPROVEMENT(0%)";

            }
        }

        private void metroComboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dateIS1 = Int32.Parse(metroComboBox8.SelectedItem.ToString());
                displayChart8();
            }
            catch(Exception) {

                dateIS1 = 2018;

            }
       
            MySqlDataReader reader6 = DBConnection.getData("SELECT SUM(interaction_with_customers+interaction_with_supervisors+interaction_with_clients+motivational_skills+leadership) as total FROM interpersonal_skills where year(inter_year) = "+dateIS1+" and staff_id = '" + employeeNo + "'");
            while (reader6.Read())
            {
                totalIS1 = reader6.GetInt32("total");
            }
            reader6.Close();
        }

        private void metroComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dateIS2 = Int32.Parse(metroComboBox7.SelectedItem.ToString());
                displayChart7();
            }
            catch (Exception)
            {

                dateIS2 = 2018;
            }
            
            MySqlDataReader reader40 = DBConnection.getData("SELECT SUM(interaction_with_customers+interaction_with_supervisors+interaction_with_clients+motivational_skills+leadership) as total FROM interpersonal_skills WHERE year(inter_year) = '" + dateIS2 + "' and staff_id = '" + employeeNo + "'");
            while (reader40.Read())
            {
                totalIS2 = reader40.GetInt32("total");
            }
            reader40.Close();
        }

        public void executeCircularProgressBarIS()
        {
            Console.Write("\n.........here\n");

            finalTotalIS = totalIS2 - totalIS1;

            Console.Write("IS1 : " + totalIS1 + "IS2 : " + totalIS2+ "\n");

            dividedAmountIS = (double)finalTotalIS / totalIS1;

            Console.Write("divid : " + dividedAmountIS + "\n");

            finalPercentageIS = dividedAmountIS * 100;
            int FP = Convert.ToInt32(finalPercentageIS);
            metroTextBox3.Text = dividedAmountIS.ToString();
            metroTextBox4.Text = FP.ToString();

            if (FP < 0)
            {
                int myInt = System.Math.Abs(FP);

                if (myInt > 100)
                {
                    myInt = 100;
                }

                metroLabel27.Text = "";
                returnReleventProgressBar().Visible = false;
                returnReleventRetrogressBar().Visible = true;
                for (int i = 1; i <= myInt; i++)
                {

                    Thread.Sleep(25);

                    returnReleventRetrogressBar().Value = i;
                    returnReleventRetrogressBar().Text = i.ToString();
                    returnReleventRetrogressBar().Update();
                }

            }
            else if (FP > 0)
            {
                if (FP > 100)
                {
                    FP = 100;
                }
                int myInt = System.Math.Abs(FP);
                metroLabel27.Text = "";
                returnReleventRetrogressBar().Visible = false;
                returnReleventProgressBar().Visible = true;
                for (int i = 1; i <= FP; i++)
                {

                    Thread.Sleep(25);

                    returnReleventProgressBar().Value = i;
                    returnReleventProgressBar().Text = i.ToString();
                    returnReleventProgressBar().Update();
                }

            }
            else
            {

                circularProgressBar1.Value = 0;
                circularProgressBar2.Value = 0;
                circularProgressBar1.Text = 0.ToString();
                circularProgressBar2.Text = 0.ToString();

                circularProgressBar3.Value = 0;
                circularProgressBar4.Value = 0;
                circularProgressBar3.Text = 0.ToString();
                circularProgressBar4.Text = 0.ToString();

                circularProgressBar5.Value = 0;
                circularProgressBar6.Value = 0;
                circularProgressBar5.Text = 0.ToString();
                circularProgressBar6.Text = 0.ToString();

                circularProgressBar7.Value = 0;
                circularProgressBar8.Value = 0;
                circularProgressBar7.Text = 0.ToString();
                circularProgressBar8.Text = 0.ToString();

                metroLabel45.Text = "NO IMPROVEMENT(0%)";

            }
        }

        //(END)Combo box changes

        //Charts Begin
        public void displayChart2()
        {
            this.chart2.Series["Grading"].Points.Clear();
            this.chart2.Series["Grading"].Points.Clear();

            MySqlDataReader reader3 = DBConnection.getData("SELECT * FROM job_performance WHERE year(perf_year) = " + Int32.Parse(metroComboBox1.SelectedItem.ToString()) + " and staff_id = " + employeeNo + ";");
            while (reader3.Read())
            {
                this.chart2.Series["Grading"].Points.AddXY("knowledge", reader3.GetInt32("knowledge"));
                this.chart2.Series["Grading"].Points.AddXY("Safety", reader3.GetInt32("saftey"));
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

            MySqlDataReader reader3 = DBConnection.getData("SELECT * FROM job_performance WHERE year(perf_year) = '" + Int32.Parse(metroComboBox2.SelectedItem.ToString()) + "' and staff_id = '" + employeeNo + "'");
            while (reader3.Read())
            {
                this.chart1.Series["Grading"].Points.AddXY("knowledge", reader3.GetInt32("knowledge"));
                this.chart1.Series["Grading"].Points.AddXY("Safety", reader3.GetInt32("saftey"));
                this.chart1.Series["Grading"].Points.AddXY("Quality", reader3.GetInt32("quality"));
                this.chart1.Series["Grading"].Points.AddXY("Adaptability", reader3.GetInt32("adaptability"));
                this.chart1.Series["Grading"].Points.AddXY("Productivity", reader3.GetInt32("productivity"));
                this.chart1.Series["Grading"].Points.AddXY("Initiative", reader3.GetInt32("Initiative"));

            }
            reader3.Close();
        }

        public void displayChart3()
        {

            this.chart3.Series["Grading"].Points.Clear();
            this.chart3.Series["Grading"].Points.Clear();

            MySqlDataReader dataReaderChart3 = DBConnection.getData("SELECT * FROM client_relations WHERE year(rel_year) = '" + metroComboBox4.Text + "' and staff_id = '" + employeeNo + "'");

            while (dataReaderChart3.Read())
            {

                this.chart3.Series["Grading"].Points.AddXY("Telephone Skills", dataReaderChart3.GetInt32("telephone_skills"));
                this.chart3.Series["Grading"].Points.AddXY("Problem Resolution", dataReaderChart3.GetInt32("problem_resolution"));
                this.chart3.Series["Grading"].Points.AddXY("Salesmanship", dataReaderChart3.GetInt32("salesmanship"));
                this.chart3.Series["Grading"].Points.AddXY("Pro activeness", dataReaderChart3.GetInt32("pro_activeness"));
                this.chart3.Series["Grading"].Points.AddXY("Politeness", dataReaderChart3.GetInt32("politeness"));

            }

            dataReaderChart3.Close();

        }

        public void displayChart4()
        {

            this.chart4.Series["Grading"].Points.Clear();
            this.chart4.Series["Grading"].Points.Clear();

            MySqlDataReader dataReaderChart4 = DBConnection.getData("SELECT * FROM client_relations WHERE year(rel_year) = '" + metroComboBox3.Text + "' and staff_id = '" + employeeNo + "'");

            while (dataReaderChart4.Read())
            {

                this.chart4.Series["Grading"].Points.AddXY("Telephone Skills", dataReaderChart4.GetInt32("telephone_skills"));
                this.chart4.Series["Grading"].Points.AddXY("Problem Resolution", dataReaderChart4.GetInt32("problem_resolution"));
                this.chart4.Series["Grading"].Points.AddXY("Salesmanship", dataReaderChart4.GetInt32("salesmanship"));
                this.chart4.Series["Grading"].Points.AddXY("Pro activeness", dataReaderChart4.GetInt32("pro_activeness"));
                this.chart4.Series["Grading"].Points.AddXY("Politeness", dataReaderChart4.GetInt32("politeness"));

            }

            dataReaderChart4.Close();

        }

        public void displayChart5()
        {

            this.chart5.Series["Grading"].Points.Clear();
            this.chart5.Series["Grading"].Points.Clear();

            MySqlDataReader dataReaderChart5 = DBConnection.getData("SELECT * FROM communication_skills WHERE year(comm_year) = '" + metroComboBox5.Text + "' and staff_id = '" + employeeNo + "'");

            while (dataReaderChart5.Read())
            {

                this.chart5.Series["Grading"].Points.AddXY("Influence", dataReaderChart5.GetInt32("influence"));
                this.chart5.Series["Grading"].Points.AddXY("Presentation", dataReaderChart5.GetInt32("presentation"));
                this.chart5.Series["Grading"].Points.AddXY("Relationships", dataReaderChart5.GetInt32("relationship"));
                this.chart5.Series["Grading"].Points.AddXY("Listening", dataReaderChart5.GetInt32("listening"));
                this.chart5.Series["Grading"].Points.AddXY("Negociation", dataReaderChart5.GetInt32("negotiation"));

            }

            dataReaderChart5.Close();

        }

        public void displayChart6()
        {

            this.chart6.Series["Grading"].Points.Clear();
            this.chart6.Series["Grading"].Points.Clear();

            MySqlDataReader dataReaderChart6 = DBConnection.getData("SELECT * FROM communication_skills WHERE year(comm_year) = '" + metroComboBox6.Text + "' and staff_id = '" + employeeNo + "'");

            while (dataReaderChart6.Read())
            {

                this.chart6.Series["Grading"].Points.AddXY("Influence", dataReaderChart6.GetInt32("influence"));
                this.chart6.Series["Grading"].Points.AddXY("Presentation", dataReaderChart6.GetInt32("presentation"));
                this.chart6.Series["Grading"].Points.AddXY("Relationships", dataReaderChart6.GetInt32("relationship"));
                this.chart6.Series["Grading"].Points.AddXY("Listening", dataReaderChart6.GetInt32("listening"));
                this.chart6.Series["Grading"].Points.AddXY("Negociation", dataReaderChart6.GetInt32("negotiation"));

            }

            dataReaderChart6.Close();

        }

        public void displayChart7()
        {

            this.chart7.Series["Grading"].Points.Clear();
            this.chart7.Series["Grading"].Points.Clear();

            MySqlDataReader dataReaderChart7 = DBConnection.getData("SELECT * FROM interpersonal_skills WHERE year(inter_year) = '" + metroComboBox7.Text + "' and staff_id = '" + employeeNo + "'");

            while (dataReaderChart7.Read())
            {

                this.chart7.Series["Grading"].Points.AddXY("Interaction With Customers", dataReaderChart7.GetInt32("interaction_with_customers"));
                this.chart7.Series["Grading"].Points.AddXY("Interaction With Supervisiors", dataReaderChart7.GetInt32("interaction_with_supervisors"));
                this.chart7.Series["Grading"].Points.AddXY("Interaction With Clients", dataReaderChart7.GetInt32("interaction_with_clients"));
                this.chart7.Series["Grading"].Points.AddXY("Motivational Skills", dataReaderChart7.GetInt32("motivational_skills"));
                this.chart7.Series["Grading"].Points.AddXY("Leadership", dataReaderChart7.GetInt32("leadership"));

            }

            dataReaderChart7.Close();

        }

        public void displayChart8()
        {

            this.chart8.Series["Grading"].Points.Clear();
            this.chart8.Series["Grading"].Points.Clear();

            MySqlDataReader dataReaderChart8 = DBConnection.getData("SELECT * FROM interpersonal_skills WHERE year(inter_year) = '" + metroComboBox8.Text + "' and staff_id = '" + employeeNo + "'");

            while (dataReaderChart8.Read())
            {

                this.chart8.Series["Grading"].Points.AddXY("Interaction With Customers", dataReaderChart8.GetInt32("interaction_with_customers"));
                this.chart8.Series["Grading"].Points.AddXY("Interaction With Supervisiors", dataReaderChart8.GetInt32("interaction_with_supervisors"));
                this.chart8.Series["Grading"].Points.AddXY("Interaction With Clients", dataReaderChart8.GetInt32("interaction_with_clients"));
                this.chart8.Series["Grading"].Points.AddXY("Motivational Skills", dataReaderChart8.GetInt32("motivational_skills"));
                this.chart8.Series["Grading"].Points.AddXY("Leadership", dataReaderChart8.GetInt32("leadership"));

            }

            dataReaderChart8.Close();

        }
        //End of charts

        //public void finalTotalGet()
        //{
        //    finalTotal = total2 - total1;

        //    dividedAmount = (double)finalTotal / total1;

        //    finalPercentage = dividedAmount * 100;
        //    int FP = Convert.ToInt32(finalPercentage);
        //    metroTextBox3.Text = dividedAmount.ToString();
        //    metroTextBox4.Text = FP.ToString();

        //    if (FP < 0)
        //    {
        //        int myInt = System.Math.Abs(FP);

        //        //if (myInt > 100)
        //        //{
        //        //    myInt = 100;
        //        //}

        //        //metroLabel27.Text = "";
        //        //circularProgressBar2.Visible = false;
        //        //circularProgressBar1.Visible = true;
        //        //for (int i = 1; i <= myInt; i++)
        //        //{

        //        //    Thread.Sleep(25);

        //        //    circularProgressBar1.Value = i;
        //        //    circularProgressBar1.Text = i.ToString();
        //        //    circularProgressBar1.Update();
        //        //}
        //        selectRetrogressBar(FP);
        //    }
        //    else if (FP > 0)
        //    {
        //        //if (FP>100) {
        //        //    FP = 100;
        //        //}
        //        //int myInt = System.Math.Abs(FP);
        //        //metroLabel27.Text = "";
        //        //circularProgressBar1.Visible = false;
        //        //circularProgressBar2.Visible = true;
        //        //for (int i = 1; i <= FP; i++)
        //        //{

        //        //    Thread.Sleep(25);

        //        //    circularProgressBar2.Value = i;
        //        //    circularProgressBar2.Text = i.ToString();
        //        //    circularProgressBar2.Update();
        //        //}
        //        selectProgressbar(FP);
        //    }
        //    else {

        //        circularProgressBar1.Value = 0;
        //        circularProgressBar2.Value = 0;
        //        circularProgressBar1.Text = 0.ToString();
        //        circularProgressBar2.Text = 0.ToString();

        //        circularProgressBar3.Value = 0;
        //        circularProgressBar4.Value = 0;
        //        circularProgressBar3.Text = 0.ToString();
        //        circularProgressBar4.Text = 0.ToString();

        //        circularProgressBar5.Value = 0;
        //        circularProgressBar6.Value = 0;
        //        circularProgressBar5.Text = 0.ToString();
        //        circularProgressBar6.Text = 0.ToString();

        //        circularProgressBar7.Value = 0;
        //        circularProgressBar8.Value = 0;
        //        circularProgressBar7.Text = 0.ToString();
        //        circularProgressBar8.Text = 0.ToString();

        //        metroLabel32.Text = "NO IMPROVEMENT(0%)";

        //    }
        //}

        //The button click events for improvement percentage
        private void metroButton1_Click(object sender, EventArgs e)
        {
            //finalTotalGet();
            //finalTotalGetTesting();
            executeCircularProgressBarJP();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            //finalTotalGet();
          //  finalTotalGetTesting();
            executeCircularProgressBarIS();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //finalTotalGet();
            // finalTotalGetTesting();
            executeCircularProgressBarCR();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
       
            executeCircularProgressBarCS();
        }

        //private void metroComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (metroTabControl3.SelectedTab == metroTabPage10)
        //    {
        //        metroLabel49.Text = "Index 9 Selected";
        //    }
        //    else if (metroTabControl3.SelectedTab == metroTabPage11)
        //    {
        //        metroLabel49.Text = "Index 10 Selected";
        //    }
        //    else if (metroTabControl3.SelectedTab == metroTabPage9)
        //    {
        //        metroLabel49.Text = "Index 11 Selected";
        //    }
        //    else
        //    {
        //        metroLabel49.Text = "Index 8 Selected";
        //    }
        //}

        //private void metroTabControl3_TabIndexChanged(object sender, EventArgs e)
        //{
        //   if (metroTabControl3.SelectedTab == metroTabPage10)
        //   {
        //       metroLabel49.Text = "Index 9 Selected";
        //   }
        //   else if (metroTabControl3.SelectedTab == metroTabPage11)
        //   {
        //       metroLabel49.Text = "Index 10 Selected";
        //   }
        //   else if (metroTabControl3.SelectedTab == metroTabPage9)
        //   {
        //       metroLabel49.Text = "Index 11 Selected";
        //   }
        //   else
        //   {
        //       metroLabel49.Text = "Index 8 Selected";
        //   }

        //}

        //private void metroTabControl3_VisibleChanged(object sender, EventArgs e)
        //{

        //}

        //private void metroTabControl3_TabStopChanged(object sender, EventArgs e)
        //{
        //    //if (metroTabControl3.SelectedTab == metroTabPage10)
        //    //{
        //    //    metroLabel49.Text = "Index 9 Selected";
        //    //}
        //    //else if (metroTabControl3.SelectedTab == metroTabPage11)
        //    //{
        //    //    metroLabel49.Text = "Index 10 Selected";
        //    //}
        //    //else if (metroTabControl3.SelectedTab == metroTabPage9)
        //    //{
        //    //    metroLabel49.Text = "Index 11 Selected";
        //    //}
        //    //else
        //    //{
        //    //    metroLabel49.Text = "Index 8 Selected";
        //    //}
        //}

        private void metroTabControl3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroTabControl3.SelectedTab == metroTabPage10)
            {
               // metroLabel49.Text = "Index 9 Selected";
            }
            else if (metroTabControl3.SelectedTab == metroTabPage11)
            {
                //metroLabel49.Text = "Index 10 Selected";
            }
            else if (metroTabControl3.SelectedTab == metroTabPage9)
            {
               // metroLabel49.Text = "Index 11 Selected";
            }
            else
            {
               // metroLabel49.Text = "Index 8 Selected";
            }
        }

        public void selectRetrogressBar(int FP)
        {
            if (metroTabControl3.SelectedTab == metroTabPage8)
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
            else if (metroTabControl3.SelectedTab == metroTabPage9)
            {
                int myInt = System.Math.Abs(FP);

                if (myInt > 100)
                {
                    myInt = 100;
                }

                metroLabel27.Text = "";
                circularProgressBar3.Visible = false;
                circularProgressBar4.Visible = true;
                for (int i = 1; i <= myInt; i++)
                {

                    Thread.Sleep(25);

                    circularProgressBar4.Value = i;
                    circularProgressBar4.Text = i.ToString();
                    circularProgressBar4.Update();
                }
            }
            else if (metroTabControl3.SelectedTab == metroTabPage10)
            {
                int myInt = System.Math.Abs(FP);

                if (myInt > 100)
                {
                    myInt = 100;
                }

                metroLabel27.Text = "";
                circularProgressBar5.Visible = false;
                circularProgressBar6.Visible = true;
                for (int i = 1; i <= myInt; i++)
                {

                    Thread.Sleep(25);

                    circularProgressBar6.Value = i;
                    circularProgressBar6.Text = i.ToString();
                    circularProgressBar6.Update();
                }
            }
            else
            {
                int myInt = System.Math.Abs(FP);

                if (myInt > 100)
                {
                    myInt = 100;
                }

                metroLabel27.Text = "";
                circularProgressBar7.Visible = false;
                circularProgressBar8.Visible = true;
                for (int i = 1; i <= myInt; i++)
                {

                    Thread.Sleep(25);

                    circularProgressBar8.Value = i;
                    circularProgressBar8.Text = i.ToString();
                    circularProgressBar8.Update();
                }
            }
        }

        public void selectProgressbar(int FP)
        {
            if (metroTabControl3.SelectedTab == metroTabPage8)
            {
                if (FP > 100)
                {
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
            else if (metroTabControl3.SelectedTab == metroTabPage9)
            {
                if (FP > 100)
                {
                    FP = 100;
                }
                int myInt = System.Math.Abs(FP);
                metroLabel27.Text = "";
                circularProgressBar4.Visible = false;
                circularProgressBar3.Visible = true;
                for (int i = 1; i <= FP; i++)
                {

                    Thread.Sleep(25);

                    circularProgressBar3.Value = i;
                    circularProgressBar3.Text = i.ToString();
                    circularProgressBar3.Update();
                }
            }
            else if (metroTabControl3.SelectedTab == metroTabPage10)
            {
                if (FP > 100)
                {
                    FP = 100;
                }
                int myInt = System.Math.Abs(FP);
                metroLabel27.Text = "";
                circularProgressBar6.Visible = false;
                circularProgressBar5.Visible = true;
                for (int i = 1; i <= FP; i++)
                {

                    Thread.Sleep(25);

                    circularProgressBar5.Value = i;
                    circularProgressBar5.Text = i.ToString();
                    circularProgressBar5.Update();
                }
            }
            else
            {
                if (FP > 100)
                {
                    FP = 100;
                }
                int myInt = System.Math.Abs(FP);
                metroLabel27.Text = "";
                circularProgressBar8.Visible = false;
                circularProgressBar7.Visible = true;
                for (int i = 1; i <= FP; i++)
                {

                    Thread.Sleep(25);

                    circularProgressBar7.Value = i;
                    circularProgressBar7.Text = i.ToString();
                    circularProgressBar7.Update();
                }
            }
        }

        public CircularProgressBar.CircularProgressBar returnReleventProgressBar() {

            if (metroTabControl3.SelectedTab == metroTabPage8)
            {
                return circularProgressBar2;
            }
            else if (metroTabControl3.SelectedTab == metroTabPage9)
            {
                return circularProgressBar3;
            }
            else if (metroTabControl3.SelectedTab == metroTabPage10)
            {
                return circularProgressBar5;
            }
            else
            {
                return circularProgressBar7;
            }

         }

        public CircularProgressBar.CircularProgressBar returnReleventRetrogressBar()
        {
            if (metroTabControl3.SelectedTab == metroTabPage8)
            {
                return circularProgressBar1;
            }
            else if (metroTabControl3.SelectedTab == metroTabPage9)
            {
                return circularProgressBar4;
            }
            else if (metroTabControl3.SelectedTab == metroTabPage10)
            {
                return circularProgressBar6;
            }
            else
            {
                return circularProgressBar8;
            }

        }

        public void finalTotalGetTesting()
        {
            finalTotal = total2 - total1;

            dividedAmount = (double)finalTotal / total1;

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
                returnReleventProgressBar().Visible = false;
                returnReleventRetrogressBar().Visible = true;
                for (int i = 1; i <= myInt; i++)
                {

                    Thread.Sleep(25);

                    returnReleventRetrogressBar().Value = i;
                    returnReleventRetrogressBar().Text = i.ToString();
                    returnReleventRetrogressBar().Update();
                }
                
            }
            else if (FP > 0)
            {
                if (FP>100) {
                   FP = 100;
                }
                int myInt = System.Math.Abs(FP);
                metroLabel27.Text = "";
                returnReleventRetrogressBar().Visible = false;
                returnReleventProgressBar().Visible = true;
                for (int i = 1; i <= FP; i++)
                {

                   Thread.Sleep(25);

                    returnReleventProgressBar().Value = i;
                    returnReleventProgressBar().Text = i.ToString();
                    returnReleventProgressBar().Update();
                }
             
            }
            else
            {

                circularProgressBar1.Value = 0;
                circularProgressBar2.Value = 0;
                circularProgressBar1.Text = 0.ToString();
                circularProgressBar2.Text = 0.ToString();

                circularProgressBar3.Value = 0;
                circularProgressBar4.Value = 0;
                circularProgressBar3.Text = 0.ToString();
                circularProgressBar4.Text = 0.ToString();

                circularProgressBar5.Value = 0;
                circularProgressBar6.Value = 0;
                circularProgressBar5.Text = 0.ToString();
                circularProgressBar6.Text = 0.ToString();

                circularProgressBar7.Value = 0;
                circularProgressBar8.Value = 0;
                circularProgressBar7.Text = 0.ToString();
                circularProgressBar8.Text = 0.ToString();

                metroLabel32.Text = "NO IMPROVEMENT(0%)";

            }
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            ClientPerformanceAddEntryForm clientPerformanceAddEntryForm = new ClientPerformanceAddEntryForm(employeeNo,employeeName);
            clientPerformanceAddEntryForm.Show();
        }

        private void metroTile14_Click(object sender, EventArgs e)
        {
            CommunicationSkillsAddEntryForm communicationSkillsAddEntryForm = new CommunicationSkillsAddEntryForm(employeeNo,employeeName);
            communicationSkillsAddEntryForm.Show();
        }

        private void metroTile17_Click(object sender, EventArgs e)
        {
            InterpersonalSkillsAddEntryForm interpersonalSkillsAddEntryForm = new InterpersonalSkillsAddEntryForm(employeeNo,employeeName);
            interpersonalSkillsAddEntryForm.Show();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            JobPerformanceAddEntryForm obj = new JobPerformanceAddEntryForm(employeeNo,employeeName);
            obj.Show();
        }

        private void metroTile18_Click(object sender, EventArgs e)
        {
            int projectId = Int32.Parse(projectIdTxtbox.Text);
            int eventId = Int32.Parse(EventIdTxtbox.Text);
            string description = descriptionTxtbox.Text;

            ProjectShortcomings pSC = new ProjectShortcomings(employeeNo,projectId, eventId, description);
            Database.addProjectShortcomings(pSC);
        }

        private void projectShortcomingsGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            projectIdTxtbox.Text = projectShortcomingsGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            EventIdTxtbox.Text = projectShortcomingsGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            descriptionTxtbox.Text = projectShortcomingsGrid.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void metroTile19_Click(object sender, EventArgs e)
        {
            int projectId = Int32.Parse(projectIdTxtbox.Text);
            int eventId = Int32.Parse(EventIdTxtbox.Text);
            string description = descriptionTxtbox.Text;

            ProjectShortcomings pSC = new ProjectShortcomings(employeeNo, projectId, eventId, description);
            Database.updateProjectShortcomings(pSC);

        }

        private void metroTile20_Click(object sender, EventArgs e)
        {
            int projectId = Int32.Parse(projectIdTxtbox.Text);
            int eventId = Int32.Parse(EventIdTxtbox.Text);
            string description = descriptionTxtbox.Text;

            ProjectShortcomings pSC = new ProjectShortcomings(employeeNo, projectId, eventId, description);
            Database.deleteProjectShortcomings(pSC);

        }
    }
}
