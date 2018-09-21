using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;
using ResoflexClientHandlingSystem.RequestForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResoflexClientHandlingSystem.Properties;
using ResoflexClientHandlingSystem.Role;
namespace ResoflexClientHandlingSystem.ProjectForms
{
    public partial class GetPermission : MetroFramework.Forms.MetroForm
    {
        public GetPermission()
        {
            InitializeComponent();
        }

        private void GetPermission_Load(object sender, EventArgs e)
        {
            metroTextBox1.Text = Userglobals.uid.ToString();
            metroTextBox4.Text = Userglobals.uname;
           

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
            //try
            //{
            //    int userID = Int32.Parse(metroTextBox1.Text);
            //    int functionID =Int32.Parse( metroTextBox3.Text);
            //    bool statues = checkBox1.Checked;


            //    UserNotification notification = new UserNotification(userID, functionID, statues);

            //    Database.addNotification(notification);

            //    MessageBox.Show("Your request successfully sent to Management!", "Request Sent", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            //    this.Close();

            //}
            //catch (Exception exp)
            //{
            //    MessageBox.Show(exp.ToString());
            //}
        }
    }
}
