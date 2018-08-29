using MySql.Data.MySqlClient;
using System;
using ResoflexClientHandlingSystem.Core;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResoflexClientHandlingSystem.Role;
using ResoflexClientHandlingSystem.Common;

namespace ResoflexClientHandlingSystem
{
    public partial class UserAddForm : MetroFramework.Forms.MetroForm
    {
        private string staffname;
        private string uname1;
        private string pass;
        private string permission;

        public UserAddForm()
        {
            InitializeComponent();

        }

        public UserAddForm(string name, string uname1, string pass, string permission)
        {
           
            this.uname1 = uname1;
            this.pass = pass;
            this.permission = permission;

            InitializeComponent();

            metroComboBox1.SelectedItem = name;
            metroComboBox1.Enabled = false;

            uname.ReadOnly = true;
            uname.Text = uname1;

            pwd.ReadOnly = true;
            pwd.Text = pass;

            perm.SelectedItem = permission;
            perm.Enabled = false;

            add.Visible = false;
            clr.Visible = false;

            metroGrid1.Enabled = false;
            label2.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void UserAddForm_Load(object sender, EventArgs e)
        {
            id.Visible = false;

            try
            {
                MySqlDataReader reader = DBConnection.getData("SELECT first_name, last_name, staff_id FROM staff where staff_id not in( select user_id from user)");

                while (reader.Read())
                {
                    metroComboBox1.Items.Add(reader.GetValue(0).ToString() + " " + reader.GetValue(1).ToString());
                    id.Text = (reader.GetValue(2).ToString());

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            metroGrid1.DataSource = getUserList();


        }

        private DataTable getUserList()
        {
            DataTable dt = new DataTable();

            try
            {
                MySqlDataReader reader = DBConnection.getData("SELECT user_id as UserID, u_name as Username, permission as Permission FROM user where permission <> 'NA'");

                dt.Load(reader);

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return dt;
        }


        public void setPriv(String uid)
        {
            try
            {
                MySqlDataReader reader = DBConnection.getData("SELECT designation from designation where desig_id =(select desig_id from staff where staff_id=" + uid + ")");

                while (reader.Read())
                {
                    perm.SelectedItem = reader["designation"].ToString();

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

        }


        /* private void metroComboBox1_TextUpdate(object sender, EventArgs e)
         {
             setNamePriv(metroComboBox1.Text.ToString());
         }*/

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                setPriv(id.Text);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

        }

        private void clr_Click(object sender, EventArgs e)
        {
            clearTextBoxes();

        }

        private void add_Click(object sender, EventArgs e)
        {

            string username = uname.Text.ToString();
            string pass = Eramake.eCryptography.Encrypt(pwd.Text);
            String per = perm.SelectedItem.ToString();
            int uid = int.Parse(id.Text);
            String email;
            User us = new User(uid,username, pass, per);

            try
            {
                Database.addUsers(us);
                UserOperation operation = new UserOperation(new Role.UserLog(Logglobals.id), "Added a new User", uid);

                try
                {
                    Database.addOp(operation);

                    try
                    {
                        MySqlDataReader reader = DBConnection.getData("SELECT email FROM staff where staff_id ='" + uid + "';");

                        while (reader.Read())
                        {
                            email = reader["email"].ToString();
                            emailUser(username, Eramake.eCryptography.Decrypt(pass), email);
                        }
                        reader.Close();

                        clearTextBoxes();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
                


            }
            catch (Exception)
            {
                MessageBox.Show("Every detail must be added!", "User adding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            notifySuccessUserAdding.Icon = SystemIcons.Application;
            notifySuccessUserAdding.BalloonTipText = "User Successfully added!";
            notifySuccessUserAdding.ShowBalloonTip(1000);

            metroGrid1.DataSource = getUserList();

        }

        public void clearTextBoxes()
        {
            pwd.Text = "";
            uname.Text = "";
        }

        public void emailUser(string username, string pass, string email)
        {

            string subject = "Successful User Registration";
            string message = "You are successfully added as a User. Your username: " + username + " and your password: " + pass + " are now in use. Be mindful of changing the password at your first login.";

            try
            {
                bool isSuccess = Internet.sendMail(email, subject, message);

                if (isSuccess)
                {
                    notifySendSuccess.Icon = SystemIcons.Application;
                    notifySendSuccess.BalloonTipText = "Email sent successfully!";
                    notifySendSuccess.ShowBalloonTip(1000);
                }
                else
                {
                    MessageBox.Show("Something went wrong!\nPlease check your internet connection and email address", "Mail Sender", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!\nPlease check your internet connection and email address", "Mail Sender", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void metroGrid1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DialogResult dr= MessageBox.Show("Delete user?", "Delete Users", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dr == DialogResult.Yes)
            {
                int userID = int.Parse(metroGrid1.Rows[e.RowIndex].Cells["UserID"].Value.ToString());

                User user = new User(userID);

                try
                {
                    Database.deleteUser(user);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Can not delete user", "Delete Users", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                notifySuccessUserDeleting.Icon = SystemIcons.Application;
                notifySuccessUserDeleting.BalloonTipText = "User Successfully deleted!";
                notifySuccessUserDeleting.ShowBalloonTip(1000);

                metroGrid1.DataSource = getUserList();

            }
           
        }

        private void uname_Validated(object sender, EventArgs e)
        {
            usernameerrorprovider.SetError(uname, "");
            usernameerrorprovider.Clear();
        }

        private void uname_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!Validation.isValidUsername(uname.Text, out errorMsg))
            {
                e.Cancel = true;

                uname.Select(0, uname.Text.Length);

                this.usernameerrorprovider.SetError(uname, errorMsg);
            }

        }

        private void pwd_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!Validation.isValidPassword(pwd.Text, out errorMsg))
            {
                e.Cancel = true;

                pwd.Select(0, pwd.Text.Length);

                this.passworderrorprovider.SetError(pwd, errorMsg);
            }
        }

        private void pwd_Validated(object sender, EventArgs e)
        {
            passworderrorprovider.SetError(pwd, "");
            passworderrorprovider.Clear();
        }
    }
}
    