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
            metroButton2.Enabled = false;
            metroGrid1.DataSource = ClientRelationsRecords();
            
        }

        private DataTable ClientRelationsRecords()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("SELECT * FROM client_relations where staff_id = '"+employeeNo+"' order by rel_year desc");
            table.Load(reader);
            return table;
        }

        

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime relYear = clientRelationsDateTime.Value;
            int staffId = employeeNo;
            int telephoneSkills = int.Parse(this.telephoneSkills.Text);
            int problemResolution = int.Parse(this.problemResolution.Text);
            int salesmanship = int.Parse(this.salesmanship.Text);
            int proActiveness = Int32.Parse(proactiveness.Text);
            int politeness = int.Parse(this.politeness.Text);
            int jobPerformanceNo = 0;
            ClientRelations CRObj = new ClientRelations(staffId, relYear, telephoneSkills, problemResolution, salesmanship, proActiveness, politeness);
                 Database.addClientRelations(CRObj);
                Notification.showNotification();
            }
            catch (Exception ex) {
                MessageBox.Show("Something went wrong! + " + ex + "", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

       

        private void metroButton2_Click(object sender, EventArgs e)
        {
            metroLabel8.Text = count.ToString();
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {

            try
            {

                // DateTime temp = clientRelationsDateTime.Value;
                DateTime relYear = clientRelationsDateTime.Value;
                int staffId = employeeNo;
                int telephoneSkills = int.Parse(this.telephoneSkills.Text);
                int problemResolution = int.Parse(this.problemResolution.Text);
                int salesmanship = int.Parse(this.salesmanship.Text);
                int proActiveness = Int32.Parse(proactiveness.Text);
                int politeness = int.Parse(this.politeness.Text);

                ClientRelations CRObj = new ClientRelations(staffId, relYear, telephoneSkills, problemResolution, salesmanship, proActiveness, politeness);

                Database.updateClientRelations(CRObj);
                Notification.showNotification();
                metroButton1.Enabled = true;
                metroButton2.Enabled = false;
                clientRelationsDateTime.Enabled = false;
            }
            catch (Exception ex) {
                MessageBox.Show("Something went wrong! + " + ex + "", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void metroGrid1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            metroButton1.Enabled = false;
            metroButton2.Enabled = true;
            clientRelationsDateTime.Enabled = false;
            clientRelationsDateTime.Text = metroGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
            telephoneSkills.Text = metroGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
            problemResolution.Text = metroGrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
            salesmanship.Text = metroGrid1.Rows[e.RowIndex].Cells[4].Value.ToString();
            proactiveness.Text = metroGrid1.Rows[e.RowIndex].Cells[5].Value.ToString();
            politeness.Text = metroGrid1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            metroButton1.Enabled = true;
            metroButton2.Enabled = false;
            clientRelationsDateTime.Enabled = true;
            clientRelationsDateTime.Text = DateTime.Now.ToString("h:mm:ss tt");

        
            telephoneSkills.Text = null;
            problemResolution.Text = null;
            salesmanship.Text = null;
            proactiveness.Text = null;
            politeness.Text = null;
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
