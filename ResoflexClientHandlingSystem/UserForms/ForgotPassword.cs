using ResoflexClientHandlingSystem.Common;
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

namespace ResoflexClientHandlingSystem.UserForms
{
    public partial class ForgotPassword : MetroFramework.Forms.MetroForm { 
        
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void email_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!Validation.isValidEmail(emailTxt.Text, out errorMsg))
            {
                e.Cancel = true;

                emailTxt.Select(0, emailTxt.Text.Length);

                this.emailerrorprovider.SetError(emailTxt, errorMsg);
            }
        }

        private void email_Validated(object sender, EventArgs e)
        {
            emailerrorprovider.SetError(emailTxt, "");
            emailerrorprovider.Clear();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string email = emailTxt.Text.ToString();
            int uid = 0;
            MySql.Data.MySqlClient.MySqlDataReader reader = DBConnection.getData("SELECT u.user_id FROM user u, staff s WHERE u.user_id = s.staff_id and s.email = '"+email+"';");

            while (reader.Read())
            {
                uid = int.Parse(reader["user_id"].ToString());
            }
            reader.Close();

            UserNotification notification = new UserNotification();
            notification.UserId = uid;
            notification.FuctionId = 2;
            notification.MainId = 0;
            notification.Status = false;

            Database.addNotification(notification);

            MessageBox.Show("Request made", "Password reset request", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
