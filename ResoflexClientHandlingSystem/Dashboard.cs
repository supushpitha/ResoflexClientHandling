using ResoflexClientHandlingSystem.Role;
using ResoflexClientHandlingSystem.UserForms;
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
    public partial class Dashboard : MetroFramework.Forms.MetroForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            dateTimeLbl.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            
            if (Userglobals.uname == "")
            {
                profilebtn.Visible = false;

            }
            else
            {
                profilebtn.Visible = true;
                profilebtn.Text = Userglobals.uname;

            }

            setAttendance();
            
        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            ProfileForm prffrm = new ProfileForm();
            this.Hide();
            prffrm.ShowDialog();
            this.Close();
        }

        private void setAttendance()
        {
            //metroLabel2.Text = "12";
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Project1 frm = new Project1();

            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            resourceForm frm = new resourceForm();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            ClientForm frm = new ClientForm();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            ProjectManager pm = new ProjectManager();
           
            pm.Show();
        }

        private void metroButton3_Click_1(object sender, EventArgs e)
        {
            AccountingMain frm = new AccountingMain();

            frm.Show();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            UserLog frm = new UserLog();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            MemberListForm sEf = new MemberListForm();
            // this.Hide();
            sEf.ShowDialog();
            // this.Close();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
