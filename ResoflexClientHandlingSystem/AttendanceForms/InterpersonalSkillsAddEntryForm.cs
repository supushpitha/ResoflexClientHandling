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
            
           

            AprilBtn.Checked = true;
            ISupdateBtn.Enabled = false;
            metroGrid1.DataSource = interPersonalSkillsRecords();

            int currentYear = DateTime.Now.Year;
            int gap = 5;
            int tempYear = currentYear - (gap - 1);
            metroComboBox1.DataSource = Enumerable.Range(tempYear, gap).ToList();
            metroComboBox1.SelectedIndex = metroComboBox1.Items.IndexOf(DateTime.Now.Year);

        }

        private DataTable interPersonalSkillsRecords()
        {


            string expression = "%M %Y";
            //DataTable table = new DataTable();
            //MySqlDataReader reader = DBConnection.getData("SELECT date_format(comm_year,'" + expression + "') as EvaluationDate, Influence, Presentation,Relationship, Listening, Negotiation FROM communication_skills where staff_id = '" + employeeNo + "' order by comm_year desc");
            //table.Load(reader);
            //return table;

            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("SELECT date_format(inter_year, '"+expression+"') as EvaluationDate, interaction_with_customers as interaction_with_coworker, interaction_with_supervisors, interaction_with_clients, motivational_skills, leadership FROM interpersonal_skills where staff_id = '" + employeeNo + "'order by inter_year desc");
            table.Load(reader);
            return table;
        }

        private void CommunicationSkillsAddEntryForm_Load(object sender, EventArgs e)
        {
            
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
                int interactionWithCoworkers = Int32.Parse(interactionWithCoworkersTxtbox.Text);
                int interactionWithSupervisors = Int32.Parse(interactionWithSupervisorsTxtbox.Text);
                int interactionWithClients = Int32.Parse(interactionWithClientsTxtbox.Text);
                int motivationalSkills = Int32.Parse(motivationalSkillsTxtbox.Text);
                int leadership = Int32.Parse(LeadershipTxtbox.Text);
               
                InterpersonalSkills iPS = new InterpersonalSkills(staffId, getDate(), interactionWithCoworkers, interactionWithSupervisors, interactionWithClients, motivationalSkills, leadership);
                string msg = Database.addInterpersonalSkills(iPS);
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipText = msg;
                notifyIcon1.ShowBalloonTip(1000);

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
                int interactionWithCoworkers = Int32.Parse(interactionWithCoworkersTxtbox.Text);
                int interactionWithSupervisors = Int32.Parse(interactionWithSupervisorsTxtbox.Text);
                int interactionWithClients = Int32.Parse(interactionWithClientsTxtbox.Text);
                int motivationalSkills = Int32.Parse(motivationalSkillsTxtbox.Text);
                int leadership = Int32.Parse(LeadershipTxtbox.Text);

                InterpersonalSkills iPS = new InterpersonalSkills(staffId, getDate(), interactionWithCoworkers, interactionWithSupervisors, interactionWithClients, motivationalSkills, leadership);
                Database.updateInterpersonalSkills(iPS);
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipText = "Record Updated!";
                notifyIcon1.ShowBalloonTip(1000);
                ISaddBtn.Enabled = true;
                ISupdateBtn.Enabled = false;
            }
            catch (Exception ex) {
                MessageBox.Show("Something went wrong! + " + ex + "", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroGrid1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ISaddBtn.Enabled = false;
            ISupdateBtn.Enabled = true;

            DateTime fetchedDate = Convert.ToDateTime(metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString());
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

            interactionWithCoworkersTxtbox.Text = metroGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
            interactionWithSupervisorsTxtbox.Text = metroGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
            interactionWithClientsTxtbox.Text = metroGrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
            motivationalSkillsTxtbox.Text = metroGrid1.Rows[e.RowIndex].Cells[4].Value.ToString();
            LeadershipTxtbox.Text = metroGrid1.Rows[e.RowIndex].Cells[5].Value.ToString();
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

            ISaddBtn.Enabled = true;
            ISupdateBtn.Enabled = false;
            metroComboBox1.Enabled = true;
            AprilBtn.Enabled = true;
            AugustBtn.Enabled = Enabled = true;
            DecemberBtn.Enabled = true;


            interactionWithCoworkersTxtbox.Text = null;
            interactionWithSupervisorsTxtbox.Text = null;
            interactionWithClientsTxtbox.Text = null;
            motivationalSkillsTxtbox.Text = null;
            LeadershipTxtbox.Text = null;
           
        }

        public void onlyNumbers(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void interactionWithCoworkersTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
            interactionWithCoworkersTxtbox.MaxLength = 2;
        }

        private void interactionWithSupervisorsTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
           interactionWithSupervisorsTxtbox.MaxLength = 2;
        }

        private void interactionWithClientsTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
            interactionWithClientsTxtbox.MaxLength = 2;
        }

        private void motivationalSkillsTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
            motivationalSkillsTxtbox.MaxLength = 2;
        }

        private void LeadershipTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
            LeadershipTxtbox.MaxLength = 2;
        }
    }
}
