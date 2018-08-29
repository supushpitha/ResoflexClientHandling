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

namespace ResoflexClientHandlingSystem.AttendanceForms
{
    public partial class CommunicationSkillsAddEntryForm : MetroFramework.Forms.MetroForm
    {

        int employeeNo = 0;
        
        public CommunicationSkillsAddEntryForm(int employeeNo, string employeeName)
        {
            InitializeComponent();
            this.employeeNo = employeeNo;
            metroLabel9.Text = employeeName;
            metroLabel8.Text = employeeNo.ToString();
        }

        public CommunicationSkillsAddEntryForm()
        {
            InitializeComponent();
        }

        private DataTable CommunicationSkillsRecords()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("SELECT * FROM communication_skills where staff_id = '" + employeeNo + "' order by comm_year desc");
            table.Load(reader);
            return table;
        }

        private void CommunicationSkillsAddEntryForm_Load(object sender, EventArgs e)
        {
            CSUpdateBtn.Enabled = false;
            metroGrid1.DataSource = CommunicationSkillsRecords();
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }
        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }
        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }
        private void metroTextBox7_Click(object sender, EventArgs e)
        {

        }
        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }
        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }
        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }
        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox6_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime commYear = communicationSkillsDateTime.Value;

                int staffId = employeeNo;
                int influence = Int32.Parse(influenceTxtbox.Text);
                int presentation = int.Parse(presentationTxtbox.Text);
                int relationships = Int32.Parse(relationshipTxtbox.Text);
                int listening = int.Parse(listeningTxtbox.Text);
                int negotiation = int.Parse(negotiationTxtbox.Text);


                int jobPerformanceNo = 0;


                CommunicationSkills cS = new CommunicationSkills(staffId, commYear, influence, presentation, relationships, listening, negotiation);

                Database.addCommunicationSkills(cS);
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
                DateTime commYear = communicationSkillsDateTime.Value;
                int staffId = employeeNo;
                int influence = Int32.Parse(influenceTxtbox.Text);
                int presentation = Int32.Parse(presentationTxtbox.Text);
                int relationships = Int32.Parse(relationshipTxtbox.Text);
                int listening = Int32.Parse(listeningTxtbox.Text);
                int negotiation = Int32.Parse(negotiationTxtbox.Text);

                CommunicationSkills cS = new CommunicationSkills(staffId, commYear, influence, presentation, relationships, listening, negotiation);
                Database.updateCommunicationSkills(cS);
                Notification.showNotification();
                CSAddBtn.Enabled = true;
                CSUpdateBtn.Enabled = false;
                communicationSkillsDateTime.Enabled = true;
               
            }
            catch (Exception ex) {

                MessageBox.Show("Something went wrong! + " + ex + "", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void metroGrid1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CSAddBtn.Enabled = false;
            CSUpdateBtn.Enabled = true;
            communicationSkillsDateTime.Enabled = false;
            communicationSkillsDateTime.Text = metroGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
            influenceTxtbox.Text = metroGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
            presentationTxtbox.Text = metroGrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
            relationshipTxtbox.Text = metroGrid1.Rows[e.RowIndex].Cells[4].Value.ToString();
            listeningTxtbox.Text = metroGrid1.Rows[e.RowIndex].Cells[5].Value.ToString();
            negotiationTxtbox.Text = metroGrid1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

            CSAddBtn.Enabled = true;
            CSUpdateBtn.Enabled = false;
            communicationSkillsDateTime.Enabled = true;
            communicationSkillsDateTime.Text = DateTime.Now.ToString("h:mm:ss tt");


            influenceTxtbox.Text = null;
            presentationTxtbox.Text = null;
            relationshipTxtbox.Text = null;
            listeningTxtbox.Text = null;
            negotiationTxtbox.Text = null;
            
        }
    }
}
