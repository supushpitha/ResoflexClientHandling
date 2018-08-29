using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;
using ResoflexClientHandlingSystem.Role;
using System;
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
    public partial class JobPerformanceAddEntryForm : MetroFramework.Forms.MetroForm
    {
        private int employeeNo = 0;

        public JobPerformanceAddEntryForm()
        {
            InitializeComponent();
        }

        public JobPerformanceAddEntryForm(int employeeNo, string employeeName)
        {
            InitializeComponent();
            
            metroLabel9.Text = employeeNo.ToString();
            this.employeeNo = employeeNo;
            metroLabel10.Text = employeeName;
        }

      

        private DataTable jobPerformanceRecords()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("SELECT * FROM job_performance where staff_id = '" + employeeNo + "' order by perf_year desc");
            table.Load(reader); 
            return table;
        }

        private void JobPerformanceAddEntryForm_Load(object sender, EventArgs e)
        {
            JPUpdateBtn.Enabled = false;
            jobPerformanceGrid.DataSource = jobPerformanceRecords();
        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //DateTime temp = DateTime.Parse(metroDateTime1.Text);
            //string prefYear = temp.ToString("yyyy-MM-dd");
            try
            {
                DateTime date = jobPerformanceDateTime.Value;
                int staffId = employeeNo;
                int knowledge = Int32.Parse(knowledgeTxtbox.Text);
                int saftey = Int32.Parse(safetyTexbox.Text);
                int quality = Int32.Parse(qualityTxtbox.Text);
                int adaptability = Int32.Parse(adaptabilityTxtbox.Text);
                int productivity = Int32.Parse(productivityTxtbox.Text);
                int initiative = Int32.Parse(initiativeTxtbox.Text);


                int jobPerformanceNo = 0;


                JobPerformance JPObj = new JobPerformance(staffId, date, knowledge, saftey, quality, adaptability, productivity, initiative);

                Database.addJobPerformance(JPObj);
                Notification.showNotification();
            }
            catch (Exception ex) {

                MessageBox.Show("Something went wrong! + " + ex + "", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void metroButton2_Click(object sender, EventArgs e)
        {

            try
            {

                DateTime date = jobPerformanceDateTime.Value;
                int staffId = employeeNo;
                int knowledge = Int32.Parse(knowledgeTxtbox.Text);
                int saftey = Int32.Parse(safetyTexbox.Text);
                int quality = Int32.Parse(qualityTxtbox.Text);
                int adaptability = Int32.Parse(adaptabilityTxtbox.Text);
                int productivity = Int32.Parse(productivityTxtbox.Text);
                int initiative = Int32.Parse(initiativeTxtbox.Text);


                int jobPerformanceNo = 0;


                JobPerformance JPObj = new JobPerformance(staffId, date, knowledge, saftey, quality, adaptability, productivity, initiative);
                Database.updateJobPerformance(JPObj);
                Notification.showNotification();
                JPaddBtn.Enabled = true;
                JPUpdateBtn.Enabled = false;
                jobPerformanceDateTime.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong! + " + ex + "", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void jobPerformanceGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            JPaddBtn.Enabled = false;
            JPUpdateBtn.Enabled = true;
            jobPerformanceDateTime.Enabled = false;
            jobPerformanceDateTime.Text = jobPerformanceGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            knowledgeTxtbox.Text = jobPerformanceGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            safetyTexbox.Text = jobPerformanceGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            qualityTxtbox.Text = jobPerformanceGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            adaptabilityTxtbox.Text = jobPerformanceGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            productivityTxtbox.Text = jobPerformanceGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
            initiativeTxtbox.Text = jobPerformanceGrid.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

            
            JPaddBtn.Enabled = true;
            JPUpdateBtn.Enabled = false;
            jobPerformanceDateTime.Enabled = true;
            jobPerformanceDateTime.Text = DateTime.Now.ToString("h:mm:ss tt");


            knowledgeTxtbox.Text = null;
            safetyTexbox.Text = null;
            qualityTxtbox.Text = null;
            adaptabilityTxtbox.Text = null;
            productivityTxtbox.Text = null;
            initiativeTxtbox.Text = null;
        }
    }
}
