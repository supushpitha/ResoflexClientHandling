using MySql.Data.MySqlClient;
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

namespace ResoflexClientHandlingSystem.AdminForms
{
    public partial class UserUpdateForm : MetroFramework.Forms.MetroForm
    {
        private string v;

        public UserUpdateForm()
        {
            InitializeComponent();
        }

        private void UserUpdateForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            try
            {
                MySqlDataReader reader = DBConnection.getData("SELECT u_name from user where permission <> 'NA';");

                dt.Load(reader);
           
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            unameComboBox.DataSource = dt;
            unameComboBox.ValueMember = "u_name";
            unameComboBox.DisplayMember = "u_name";
        }

        private void unameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlDataReader reader = DBConnection.getData("SELECT s.first_name, s.last_name, d.designation_name FROM staff s, designation d where s.staff_id =(SELECT user_id from user where u_name='" + unameComboBox.SelectedValue.ToString() + "') and " +
                        "s.desig_id = d.desig_id;");

                while (reader.Read())
                {
                    string name = reader["first_name"].ToString() + " " + reader["last_name"].ToString();
                    Linkname.Text = name;
                    permComboBox.SelectedItem = reader["designation_name"].ToString();
                }
                reader.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            
        }

        private void updtbtn_Click(object sender, EventArgs e)
        {
            String pass, perm, email;
            int uid;

            try
            {
                MySqlDataReader reader = DBConnection.getData("SELECT password, permission, user_id from user where" +
                    " user_id =(SELECT user_id from user where u_name='" + unameComboBox.SelectedValue.ToString() + "');");

                if (reader.Read())
                {
                    uid = int.Parse(reader["user_id"].ToString());
                    pass = reader["password"].ToString();
                    perm = reader["permission"].ToString();
                    reader.Close();

                    if (Eramake.eCryptography.Encrypt(passTxtBox.Text).Equals(pass) && permComboBox.SelectedItem.ToString() == perm)
                    {
                        MessageBox.Show("There is no update to be made");
                    }
                    else if(string.IsNullOrWhiteSpace(passTxtBox.Text))
                    {
                        User user = new User(uid, perm);
                        
                        try
                        {
                            Database.updateUserPerm(user);
                            UserOperation operation = new UserOperation(new Role.UserLog(Logglobals.id), "Updated User data", uid);

                            try
                            {
                                Database.addOp(operation);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.StackTrace);
                            }
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.StackTrace);
                        }

                        notifyUpdate.Icon = SystemIcons.Application;
                        notifyUpdate.BalloonTipText = "User Successfully updated!";
                        notifyUpdate.ShowBalloonTip(1000);
                    }
                    else
                    {
                        User user = new User("", Eramake.eCryptography.Encrypt(passTxtBox.Text), perm,uid);
                        string i= Eramake.eCryptography.Encrypt(passTxtBox.Text);
                        try
                        {
                            Database.updateUserPassPerm(user);
                            UserOperation operation = new UserOperation(new Role.UserLog(Logglobals.id), "Updated User data", uid);

                            try
                            {
                                Database.addOp(operation);
                                MySqlDataReader reader1 = DBConnection.getData("SELECT email FROM staff where staff_id ='" + uid + "';");

                                while (reader1.Read())
                                {
                                    email = reader1["email"].ToString();
                                    emailUser(unameComboBox.SelectedValue.ToString(), Eramake.eCryptography.Decrypt(pass), email);
                                }
                                reader1.Close();

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

                        notifyUpdate.Icon = SystemIcons.Application;
                        notifyUpdate.BalloonTipText = "User Successfully updated!";
                        notifyUpdate.ShowBalloonTip(1000);
                    }
                }

            }
            catch(Exception)
            {
                MessageBox.Show("Invalid User", "User Update");
            }

                        
        }
        public void emailUser(string username, string pass, string email)
        {

            string subject = "User Password updation";
            string message = "Your password has been changed, and your password is: " + pass + " . Be mindful of changing the password at your first login.";

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

        private void passTxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(passTxtBox.Text)))
            {
                string errorMsg;

                if (!Validation.isValidPassword(passTxtBox.Text, out errorMsg))
                {
                    e.Cancel = true;

                    passTxtBox.Select(0, passTxtBox.Text.Length);

                    this.errorpassword.SetError(passTxtBox, errorMsg);
                }
            }
        }

        private void passTxtBox_Validated(object sender, EventArgs e)
        {
            errorpassword.SetError(passTxtBox, "");
            errorpassword.Clear();
        }

        
    }
}
