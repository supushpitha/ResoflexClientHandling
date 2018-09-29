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

            string expression = "%M %Y";
            //DataTable table = new DataTable();
            //MySqlDataReader reader = DBConnection.getData("SELECT date_format(comm_year,'" + expression + "') as EvaluationDate, Influence, Presentation,Relationship, Listening, Negotiation FROM communication_skills where staff_id = '" + employeeNo + "' order by comm_year desc");
            //table.Load(reader);
            //return table;

            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("SELECT date_format(perf_year,'"+ expression + "') as EvaluationDate, Knowledge,Saftey,Quality,Adaptability,Productivity,Initiative FROM job_performance where staff_id = "+employeeNo+" order by perf_year desc");
            table.Load(reader); 
            return table;
        }

        private void JobPerformanceAddEntryForm_Load(object sender, EventArgs e)
        {
            AprilBtn.Checked = true;
            JPUpdateBtn.Enabled = false;
            jobPerformanceGrid.DataSource = jobPerformanceRecords();

            int currentYear = DateTime.Now.Year;
            int gap = 5;
            int tempYear = currentYear - (gap - 1);
            metroComboBox1.DataSource = Enumerable.Range(tempYear, gap).ToList();
            metroComboBox1.SelectedIndex = metroComboBox1.Items.IndexOf(DateTime.Now.Year);
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
            //int staffId = employeeNo;
            //int influence = Int32.Parse(influenceTxtbox.Text);
            //int presentation = int.Parse(presentationTxtbox.Text);
            //int relationships = Int32.Parse(relationshipTxtbox.Text);
            //int listening = int.Parse(listeningTxtbox.Text);
            //int negotiation = int.Parse(negotiationTxtbox.Text);

            //CommunicationSkills cS = new CommunicationSkills(staffId, getDate(), influence, presentation, relationships, listening, negotiation);

            //string msg = Database.addCommunicationSkills(cS);

            //notifyIcon1.Icon = SystemIcons.Application;
            //notifyIcon1.BalloonTipText = msg;
            //notifyIcon1.ShowBalloonTip(1000);

            try
            {
                int staffId = employeeNo;
                int knowledge = Int32.Parse(knowledgeTxtbox.Text);
                int saftey = Int32.Parse(safetyTexbox.Text);
                int quality = Int32.Parse(qualityTxtbox.Text);
                int adaptability = Int32.Parse(adaptabilityTxtbox.Text);
                int productivity = Int32.Parse(productivityTxtbox.Text);
                int initiative = Int32.Parse(initiativeTxtbox.Text);
              

                JobPerformance JPObj = new JobPerformance(staffId, getDate(), knowledge, saftey, quality, adaptability, productivity, initiative);

                string msg = Database.addJobPerformance(JPObj);
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipText = msg;
                notifyIcon1.ShowBalloonTip(1000);
            }
            catch (Exception ex) {

                MessageBox.Show("Something went wrong! + " + ex + "", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public DateTime getDate()
        {
            DateTime madeDate;
            if (AprilBtn.Checked == true)
            {
                madeDate = Convert.ToDateTime("4" + "/" + "1" + "/" + metroComboBox1.Text.ToString());
                return madeDate;
            }
            else if (AugustBtn.Checked == true)
            {
                madeDate = Convert.ToDateTime("8" + "/" + "1" + "/" + metroComboBox1.Text.ToString());
                return madeDate;
            }
            else
            {
                madeDate = Convert.ToDateTime("12" + "/" + "1" + "/" + metroComboBox1.Text.ToString());
                return madeDate;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            //int staffId = employeeNo;
            //int influence = Int32.Parse(influenceTxtbox.Text);
            //int presentation = Int32.Parse(presentationTxtbox.Text);
            //int relationships = Int32.Parse(relationshipTxtbox.Text);
            //int listening = Int32.Parse(listeningTxtbox.Text);
            //int negotiation = Int32.Parse(negotiationTxtbox.Text);



            //CommunicationSkills cS = new CommunicationSkills(staffId, getDate(), influence, presentation, relationships, listening, negotiation);
            //Database.updateCommunicationSkills(cS);
            ////Notification.showNotification();
            //notifyIcon1.Icon = SystemIcons.Application;
            //notifyIcon1.BalloonTipText = "Record Updated!";
            //notifyIcon1.ShowBalloonTip(1000);
            //CSAddBtn.Enabled = true;
            //CSUpdateBtn.Enabled = false;

            try
            {
                
                int staffId = employeeNo;
                int knowledge = Int32.Parse(knowledgeTxtbox.Text);
                int saftey = Int32.Parse(safetyTexbox.Text);
                int quality = Int32.Parse(qualityTxtbox.Text);
                int adaptability = Int32.Parse(adaptabilityTxtbox.Text);
                int productivity = Int32.Parse(productivityTxtbox.Text);
                int initiative = Int32.Parse(initiativeTxtbox.Text);


                JobPerformance JPObj = new JobPerformance(staffId, getDate(), knowledge, saftey, quality, adaptability, productivity, initiative);
                Database.updateJobPerformance(JPObj);
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipText = "Record Updated!";
                notifyIcon1.ShowBalloonTip(1000);
                JPaddBtn.Enabled = true;
                JPUpdateBtn.Enabled = false;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong! + " + ex + "", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void jobPerformanceGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            //CSAddBtn.Enabled = false;
            //CSUpdateBtn.Enabled = true;

            //influenceTxtbox.Text = metroGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //presentationTxtbox.Text = metroGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //relationshipTxtbox.Text = metroGrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
            //listeningTxtbox.Text = metroGrid1.Rows[e.RowIndex].Cells[4].Value.ToString();
            //negotiationTxtbox.Text = metroGrid1.Rows[e.RowIndex].Cells[5].Value.ToString();

            //DateTime fetchedDate = Convert.ToDateTime(metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString());
            //string dateCut1 = fetchedDate.ToString("MMMM");
            //string dateCut2 = fetchedDate.ToString("yyyy");
            //if (dateCut1.Equals("April"))
            //{
            //    CSAprilRadioBtn.Checked = true;
            //    CSAprilRadioBtn.Enabled = false;
            //    CSAugustRadioBtn.Enabled = false;
            //    CSDecemberRadioBtn.Enabled = false;
            //}
            //else if (dateCut1.Equals("August"))
            //{
            //    CSAugustRadioBtn.Checked = true;
            //    CSAugustRadioBtn.Enabled = false;
            //    CSAprilRadioBtn.Enabled = false;
            //    CSDecemberRadioBtn.Enabled = false;
            //}
            //else
            //{
            //    CSDecemberRadioBtn.Checked = true;
            //    CSDecemberRadioBtn.Enabled = false;
            //    CSAprilRadioBtn.Enabled = false;
            //    CSAugustRadioBtn.Enabled = false;
            //}
            //metroComboBox1.Text = dateCut2;
            //metroComboBox1.Enabled = false;
            //CSAddBtn.Enabled = false;
            //CSUpdateBtn.Enabled = true;



            JPaddBtn.Enabled = false;
            JPUpdateBtn.Enabled = true;

            knowledgeTxtbox.Text = jobPerformanceGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            safetyTexbox.Text = jobPerformanceGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            qualityTxtbox.Text = jobPerformanceGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            adaptabilityTxtbox.Text = jobPerformanceGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            productivityTxtbox.Text = jobPerformanceGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            initiativeTxtbox.Text = jobPerformanceGrid.Rows[e.RowIndex].Cells[6].Value.ToString();

            DateTime fetchedDate = Convert.ToDateTime(jobPerformanceGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            string dateCut1 = fetchedDate.ToString("MMMM");
            string dateCut2 = fetchedDate.ToString("yyyy");
            if (dateCut1.Equals("April"))
            {
                AprilBtn.Checked = true;
                AprilBtn.Enabled = false;
                AugustBtn.Enabled = false;
                DecemberBtn.Enabled = false;
            }
            else if (dateCut1.Equals("August"))
            {
                AugustBtn.Checked = true;
                AugustBtn.Enabled = false;
                AprilBtn.Enabled = false;
                DecemberBtn.Enabled = false;
            }
            else
            {
                DecemberBtn.Checked = true;
                DecemberBtn.Enabled = false;
                AprilBtn.Enabled = false;
                AugustBtn.Enabled = false;
            }
            metroComboBox1.Text = dateCut2;
            metroComboBox1.Enabled = false;
            JPaddBtn.Enabled = false;
            JPUpdateBtn.Enabled = true;

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            //CSAddBtn.Enabled = true;
            //CSUpdateBtn.Enabled = false;
            //metroComboBox1.Enabled = true;
            //CSAprilRadioBtn.Enabled = true;
            //CSAugustRadioBtn.Enabled = true;
            //CSDecemberRadioBtn.Enabled = true;

            //influenceTxtbox.Text = null;
            //presentationTxtbox.Text = null;
            //relationshipTxtbox.Text = null;
            //listeningTxtbox.Text = null;
            //negotiationTxtbox.Text = null;

            JPaddBtn.Enabled = true;
            JPUpdateBtn.Enabled = false;
            metroComboBox1.Enabled = true;
            AprilBtn.Enabled = true;
            AugustBtn.Enabled = true;
            DecemberBtn.Enabled = true;


            knowledgeTxtbox.Text = null;
            safetyTexbox.Text = null;
            qualityTxtbox.Text = null;
            adaptabilityTxtbox.Text = null;
            productivityTxtbox.Text = null;
            initiativeTxtbox.Text = null;
        }

        public void onlyNumbers(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void knowledgeTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
            knowledgeTxtbox.MaxLength = 2;
        }

        private void safetyTexbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
            safetyTexbox.MaxLength = 2;
        }

        private void qualityTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
            qualityTxtbox.MaxLength = 2;
        }

        private void adaptabilityTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
            adaptabilityTxtbox.MaxLength = 2;
        }

        private void productivityTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
            productivityTxtbox.MaxLength = 2;
        }

        private void initiativeTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
            initiativeTxtbox.MaxLength = 2;
        }
    }
}
