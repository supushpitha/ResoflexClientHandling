using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;
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
                login.Visible = false;
            }
            
            //notifications

            try
            {
                if (Userglobals.priv.ToLower().Equals("adm") && !Userglobals.priv.ToLower().Equals("admin"))
                {
                    MySqlDataReader reader = DBConnection.getData("select count(noti_ID) from notification where admin_view=0");

                    while (reader.Read())
                    {
                        metroButton8.Text = (reader.GetValue(0).ToString());
                    }
                    reader.Close();
                }
                else if (!Userglobals.uname.Equals(""))
                {
                    MySqlDataReader reader2 = DBConnection.getData("select count(noti_ID) from notification where view=0 and user_id="+Userglobals.uid+"");

                    while (reader2.Read())
                    {
                        metroButton8.Text = (reader2.GetValue(0).ToString());
                    }
                    reader2.Close();
                }
                else
                {
                    metroButton6.Visible = false;
                    metroButton8.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            ProfileForm prffrm = new ProfileForm();
            this.Hide();
            prffrm.ShowDialog();
            this.Close();
        }
        
        private void metroTile2_Click(object sender, EventArgs e)
        {
            ProjectForm frm = new ProjectForm();

            frm.Show();
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
        
        private void metroButton2_Click(object sender, EventArgs e)
        {
            ProjectManager pm = new ProjectManager();
            this.Hide();
            pm.ShowDialog();
            this.Close();
        }

        private void metroButton3_Click_1(object sender, EventArgs e)
        {
            AccountingMain frm = new AccountingMain();
            this.Hide();
            frm.ShowDialog();
            this.Close();
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
            this.Hide();
            sEf.ShowDialog();
            this.Close();
        }
        
        private void metroButton6_Click(object sender, EventArgs e)
        {
            UserForms.Notification frm = new UserForms.Notification();
            frm.ShowDialog();
        }

        private void login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login linfrm = new Login();
            linfrm.ShowDialog();
            this.Close();
        }
    }
}
