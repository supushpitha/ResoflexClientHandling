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

        public CommunicationSkillsAddEntryForm()
        {
            InitializeComponent();

        }

        public CommunicationSkillsAddEntryForm(int employeeNo, string employeeName)
        {
            InitializeComponent();
            this.employeeNo = employeeNo;
            metroLabel9.Text = employeeName;
            metroLabel8.Text = employeeNo.ToString();
        }
        
        private void CommunicationSkillsAddEntryForm_Load(object sender, EventArgs e)
        {

            CSAprilRadioBtn.Checked = true;          
            CSUpdateBtn.Enabled = false;
            metroGrid1.DataSource = CommunicationSkillsRecords();

            int currentYear = DateTime.Now.Year;
            int gap = 5;
            int tempYear = currentYear - (gap - 1);
            metroComboBox1.DataSource = Enumerable.Range(tempYear, gap).ToList();
            metroComboBox1.SelectedIndex = metroComboBox1.Items.IndexOf(DateTime.Now.Year);

        }

        private DataTable getEmployees()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("select concat(first_name, ' ', last_name) as fullname, staff_id from staff order by first_name");
            table.Load(reader);
            return table;
        }
     
        private DataTable CommunicationSkillsRecords()
        {
            string expression = "%M %Y";
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("SELECT date_format(comm_year,'" + expression + "') as EvaluationDate, Influence, Presentation,Relationship, Listening, Negotiation FROM communication_skills where staff_id = '" + employeeNo + "' order by comm_year desc");
            table.Load(reader);
            return table;
        }

        private DataTable getEmpFromGrid()
        {
            string expression = "%M %Y";
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("select concat(employess.firstname, ' ', employess.lastname) as Name, employess.staff_id,date_format(grades.yearmonth,'" + expression + "') as EvaluationDoneOn,grades.grade from employess inner join grades on employess.staff_id = grades.staff_id order by employess.staff_id");
            table.Load(reader);
            return table;
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

        public DateTime getDate()
        {
            DateTime madeDate;
            if (CSAprilRadioBtn.Checked == true)
            {
                madeDate = Convert.ToDateTime("4" + "/" + "1" + "/" + metroComboBox1.Text.ToString());
                return madeDate;
            }
            else if (CSAugustRadioBtn.Checked == true)
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
            try
            {
                
                int staffId = employeeNo;
                int influence = Int32.Parse(influenceTxtbox.Text);
                int presentation = int.Parse(presentationTxtbox.Text);
                int relationships = Int32.Parse(relationshipTxtbox.Text);
                int listening = int.Parse(listeningTxtbox.Text);
                int negotiation = int.Parse(negotiationTxtbox.Text);

                CommunicationSkills cS = new CommunicationSkills(staffId, getDate(), influence, presentation, relationships, listening, negotiation);

                string msg =  Database.addCommunicationSkills(cS);

                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipText = msg;
                notifyIcon1.ShowBalloonTip(1000);
                // Notification.showNotification();
            }
            catch (Exception) {

                MessageBox.Show("Integers Only", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            try
            {

                int staffId = employeeNo;
                int influence = Int32.Parse(influenceTxtbox.Text);
                int presentation = Int32.Parse(presentationTxtbox.Text);
                int relationships = Int32.Parse(relationshipTxtbox.Text);
                int listening = Int32.Parse(listeningTxtbox.Text);
                int negotiation = Int32.Parse(negotiationTxtbox.Text);



                CommunicationSkills cS = new CommunicationSkills(staffId, getDate(), influence, presentation, relationships, listening, negotiation);
                Database.updateCommunicationSkills(cS);
                //Notification.showNotification();
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipText = "Record Updated!";
                notifyIcon1.ShowBalloonTip(1000);
                CSAddBtn.Enabled = true;
                CSUpdateBtn.Enabled = false;
              
               
            }
            catch (Exception) {

                MessageBox.Show("Integers Only", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void metroGrid1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CSAddBtn.Enabled = false;
            CSUpdateBtn.Enabled = true;
            
            influenceTxtbox.Text = metroGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
            presentationTxtbox.Text = metroGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
            relationshipTxtbox.Text = metroGrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
            listeningTxtbox.Text = metroGrid1.Rows[e.RowIndex].Cells[4].Value.ToString();
            negotiationTxtbox.Text = metroGrid1.Rows[e.RowIndex].Cells[5].Value.ToString();

            DateTime fetchedDate = Convert.ToDateTime(metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString());
            string dateCut1 = fetchedDate.ToString("MMMM");
            string dateCut2 = fetchedDate.ToString("yyyy");
            if (dateCut1.Equals("April"))
            {
                CSAprilRadioBtn.Checked = true;
                CSAprilRadioBtn.Enabled = false;
                CSAugustRadioBtn.Enabled = false;
                CSDecemberRadioBtn.Enabled = false;
            }
            else if (dateCut1.Equals("August"))
            {
                CSAugustRadioBtn.Checked = true;
                CSAugustRadioBtn.Enabled = false;
                CSAprilRadioBtn.Enabled = false;
                CSDecemberRadioBtn.Enabled = false;
            }
            else
            {
                CSDecemberRadioBtn.Checked = true;
                CSDecemberRadioBtn.Enabled = false;
                CSAprilRadioBtn.Enabled = false;
                CSAugustRadioBtn.Enabled = false;
            }
            metroComboBox1.Text = dateCut2;
            metroComboBox1.Enabled = false;
            CSAddBtn.Enabled = false;
            CSUpdateBtn.Enabled = true;

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

            CSAddBtn.Enabled = true;
            CSUpdateBtn.Enabled = false;
            metroComboBox1.Enabled = true;
            CSAprilRadioBtn.Enabled = true;
            CSAugustRadioBtn.Enabled = true;
            CSDecemberRadioBtn.Enabled = true;

            influenceTxtbox.Text = null;
            presentationTxtbox.Text = null;
            relationshipTxtbox.Text = null;
            listeningTxtbox.Text = null;
            negotiationTxtbox.Text = null;
            
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void onlyNumbers(object sender, KeyPressEventArgs e){

            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void influenceTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
            influenceTxtbox.MaxLength = 2;
        }

        private void presentationTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
            presentationTxtbox.MaxLength = 2;
        }

        private void relationshipTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
            relationshipTxtbox.MaxLength = 2;
        }

        private void listeningTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
            listeningTxtbox.MaxLength = 2;
        }

        private void negotiationTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
            negotiationTxtbox.MaxLength = 2;
        }
    }
}
