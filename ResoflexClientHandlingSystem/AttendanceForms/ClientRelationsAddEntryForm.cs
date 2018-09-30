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
    public partial class ClientPerformanceAddEntryForm : MetroFramework.Forms.MetroForm
    {
        int count = 0;
        int employeeNo = 0;
        string employeeName;

        public ClientPerformanceAddEntryForm(int employeeNo, string employeeName)
        {
            InitializeComponent();
             
            this.employeeNo = employeeNo;
            this.employeeName = employeeName;
            metroLabel9.Text = employeeName;
            metroLabel8.Text = employeeNo.ToString();
        }

        public ClientPerformanceAddEntryForm()
        {
            
        }

        private void ClientPerformanceAddEntryForm_Load(object sender, EventArgs e)
        {
            CRUpdateBtn.Enabled = false;
            metroGrid1.DataSource = ClientRelationsRecords();

            AprilBtn.Checked = true;
            CRUpdateBtn.Enabled = false;
            metroGrid1.DataSource = ClientRelationsRecords();

            int currentYear = DateTime.Now.Year;
            int gap = 5;
            int tempYear = currentYear - (gap - 1);
            metroComboBox1.DataSource = Enumerable.Range(tempYear, gap).ToList();
            metroComboBox1.SelectedIndex = metroComboBox1.Items.IndexOf(DateTime.Now.Year);

        }

        private DataTable ClientRelationsRecords()
        {

            string expression = "%M %Y";

            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("SELECT date_format(rel_year,'" + expression + "') as EvaluationDate, telephone_skills,problem_resolution,salesmanship,pro_activeness,politeness FROM client_relations where staff_id = " + employeeNo + " order by rel_year desc");
            table.Load(reader);
            return table;
            
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
            int telephoneSkills = int.Parse(this.telephoneSkills.Text);
            int problemResolution = int.Parse(this.problemResolution.Text);
            int salesmanship = int.Parse(this.salesmanship.Text);
            int proActiveness = Int32.Parse(proactiveness.Text);
            int politeness = int.Parse(this.politeness.Text);
            

            ClientRelations CRObj = new ClientRelations(staffId, getDate(), telephoneSkills, problemResolution, salesmanship, proActiveness, politeness);

            string msg = Database.addClientRelations(CRObj);

            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipText = msg;
            notifyIcon1.ShowBalloonTip(1000);

            }
            catch (Exception ex) {
                MessageBox.Show("Something went wrong! + " + ex + "", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

       

        private void metroButton2_Click(object sender, EventArgs e)
        {
            metroLabel8.Text = count.ToString();
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

        private void metroButton2_Click_1(object sender, EventArgs e)
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
                int telephoneSkills = int.Parse(this.telephoneSkills.Text);
                int problemResolution = int.Parse(this.problemResolution.Text);
                int salesmanship = int.Parse(this.salesmanship.Text);
                int proActiveness = Int32.Parse(proactiveness.Text);
                int politeness = int.Parse(this.politeness.Text);

                ClientRelations CRObj = new ClientRelations(staffId, getDate(), telephoneSkills, problemResolution, salesmanship, proActiveness, politeness);

                Database.updateClientRelations(CRObj);              
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipText = "Record Updated!";
                notifyIcon1.ShowBalloonTip(1000);
                CRAddBtn.Enabled = true;
                CRUpdateBtn.Enabled = false;
            }
            catch (Exception ex) {
                MessageBox.Show("Something went wrong! + " + ex + "", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void metroGrid1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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




            CRAddBtn.Enabled = false;
            CRUpdateBtn.Enabled = true;
                        
            telephoneSkills.Text = metroGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
            problemResolution.Text = metroGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
            salesmanship.Text = metroGrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
            proactiveness.Text = metroGrid1.Rows[e.RowIndex].Cells[4].Value.ToString();
            politeness.Text = metroGrid1.Rows[e.RowIndex].Cells[5].Value.ToString();

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
            CRAddBtn.Enabled = false;
            CRUpdateBtn.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //JPaddBtn.Enabled = true;
            //JPUpdateBtn.Enabled = false;
            //metroComboBox1.Enabled = true;
            //AprilBtn.Enabled = true;
            //AugustBtn.Enabled = true;
            //DecemberBtn.Enabled = true;


            //knowledgeTxtbox.Text = null;
            //safetyTexbox.Text = null;
            //qualityTxtbox.Text = null;
            //adaptabilityTxtbox.Text = null;
            //productivityTxtbox.Text = null;
            //initiativeTxtbox.Text = null;

            CRAddBtn.Enabled = true;
            CRUpdateBtn.Enabled = false;
            metroComboBox1.Enabled = true;
            AprilBtn.Enabled = true;
            AugustBtn.Enabled = true;
            DecemberBtn.Enabled = true;
        
            telephoneSkills.Text = null;
            problemResolution.Text = null;
            salesmanship.Text = null;
            proactiveness.Text = null;
            politeness.Text = null;
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void onlyNumbers(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void telephoneSkills_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
            telephoneSkills.MaxLength = 2;
        }

        private void problemResolution_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
            problemResolution.MaxLength = 2;
        }

        private void salesmanship_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
            salesmanship.MaxLength = 2;
        }

        private void proactiveness_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
            proactiveness.MaxLength = 2;
        }

        private void politeness_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
            politeness.MaxLength = 2;
        }

        private void clientRelationsDateTime_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
