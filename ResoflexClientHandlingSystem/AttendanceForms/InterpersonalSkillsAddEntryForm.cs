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
    public partial class InterpersonalSkillsAddEntryForm : MetroFramework.Forms.MetroForm
    {
        private int employeeNo = 0;

        public InterpersonalSkillsAddEntryForm()
        {
            InitializeComponent();
        }

        public InterpersonalSkillsAddEntryForm(int employeeNo, string employeeName)
        {
            InitializeComponent();
            metroLabel9.Text = employeeName;
            metroLabel8.Text = employeeNo.ToString();
            this.employeeNo = employeeNo;
        }

        private void InterpersonalSkillAddEntryForm_Load(object sender, EventArgs e)
        {
            ISupdateBtn.Enabled = false;
            metroGrid1.DataSource = interPersonalSkillsRecords();
        }

        private DataTable interPersonalSkillsRecords()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("SELECT * FROM interpersonal_skills where staff_id = '" + employeeNo + "'order by inter_year desc");
            table.Load(reader);
            return table;
        }

        private void CommunicationSkillsAddEntryForm_Load(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime interYear = interpersonalSkillsDateTime.Value;
                int staffId = employeeNo;
                int interactionWithCoworkers = Int32.Parse(interactionWithCoworkersTxtbox.Text);
                int interactionWithSupervisors = Int32.Parse(interactionWithSupervisorsTxtbox.Text);
                int interactionWithClients = Int32.Parse(interactionWithClientsTxtbox.Text);
                int motivationalSkills = Int32.Parse(motivationalSkillsTxtbox.Text);
                int leadership = Int32.Parse(LeadershipTxtbox.Text);


                int jobPerformanceNo = 0;


                InterpersonalSkills iPS = new InterpersonalSkills(staffId, interYear, interactionWithCoworkers, interactionWithSupervisors, interactionWithClients, motivationalSkills, leadership);
                Database.addInterpersonalSkills(iPS);
                Notification.showNotification();
            }
            catch (Exception ex) {
                MessageBox.Show("Something went wrong! + " + ex + "", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime interYear = interpersonalSkillsDateTime.Value;
                int staffId = employeeNo;
                int interactionWithCoworkers = Int32.Parse(interactionWithCoworkersTxtbox.Text);
                int interactionWithSupervisors = Int32.Parse(interactionWithSupervisorsTxtbox.Text);
                int interactionWithClients = Int32.Parse(interactionWithClientsTxtbox.Text);
                int motivationalSkills = Int32.Parse(motivationalSkillsTxtbox.Text);
                int leadership = Int32.Parse(LeadershipTxtbox.Text);

                InterpersonalSkills iPS = new InterpersonalSkills(staffId, interYear, interactionWithCoworkers, interactionWithSupervisors, interactionWithClients, motivationalSkills, leadership);
                Database.updateInterpersonalSkills(iPS);
                Notification.showNotification();
                ISaddBtn.Enabled = true;
                ISupdateBtn.Enabled = false;
                interpersonalSkillsDateTime.Enabled = true;
            }
            catch (Exception ex) {
                MessageBox.Show("Something went wrong! + " + ex + "", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroGrid1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ISaddBtn.Enabled = false;
            ISupdateBtn.Enabled = true;
            interpersonalSkillsDateTime.Enabled = false;
            interpersonalSkillsDateTime.Text = metroGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
            interactionWithCoworkersTxtbox.Text = metroGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
            interactionWithSupervisorsTxtbox.Text = metroGrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
            interactionWithClientsTxtbox.Text = metroGrid1.Rows[e.RowIndex].Cells[4].Value.ToString();
            motivationalSkillsTxtbox.Text = metroGrid1.Rows[e.RowIndex].Cells[5].Value.ToString();
            LeadershipTxtbox.Text = metroGrid1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            ISaddBtn.Enabled = true;
            ISupdateBtn.Enabled = false;
            interpersonalSkillsDateTime.Enabled = true;
            interpersonalSkillsDateTime.Text = DateTime.Now.ToString("h:mm:ss tt");


            interactionWithCoworkersTxtbox.Text = null;
            interactionWithSupervisorsTxtbox.Text = null;
            interactionWithClientsTxtbox.Text = null;
            motivationalSkillsTxtbox.Text = null;
            LeadershipTxtbox.Text = null;
           
        }
    }
}
