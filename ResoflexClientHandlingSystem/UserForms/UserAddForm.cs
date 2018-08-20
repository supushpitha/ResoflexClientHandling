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

namespace ResoflexClientHandlingSystem
{
    public partial class UserAddForm : MetroFramework.Forms.MetroForm
    {
        public UserAddForm()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void UserAddForm_Load(object sender, EventArgs e)
        {

            try
            {
                MySqlDataReader reader = DBConnection.getData("SELECT staff_id FROM staff where staff_id not in( select user_id from user)");

                while (reader.Read())
                {
                    metroComboBox1.Items.Add(reader.GetValue(0).ToString());

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
                MySqlDataReader reader = DBConnection.getData("SELECT user_id, u_name, permission FROM user");

                dt.Load(reader);

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return dt;
        }

        public void setName(String uid)
        {
            try
            {
                MySqlDataReader reader = DBConnection.getData("SELECT first_name, last_name from staff where staff_id = " + uid + ";");

                while (reader.Read())
                {
                    fname.Text = (reader.GetValue(0).ToString());
                    lname.Text = (reader.GetValue(1).ToString());

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }


        }


        public void setPriv(String uid)
        {
            try
            {
                MySqlDataReader reader = DBConnection.getData("SELECT designation from designation where desig_id =(select desig_id from staff where staff_id=" + uid + ")");

                while (reader.Read())
                {
                    perm.SelectedIndex = perm.FindStringExact(reader.GetValue(0).ToString());

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
            setName(metroComboBox1.Text.ToString());
            setPriv(metroComboBox1.Text.ToString());
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
            int staffId = Int32.Parse(metroComboBox1.SelectedItem.ToString());
            
            User us = new User(staffId, username, pass, per);

            try
            {
                Database.addUsers(us);

                clearTextBoxes();

            }
            catch (Exception)
            {
                MessageBox.Show("Every detail must be added!", "User adding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("User added successfully", "User Adding", MessageBoxButtons.OK);

            metroGrid1.DataSource = getUserList();

        }

        public void clearTextBoxes()
        {
            fname.Text = "";
            lname.Text="";
            pwd.Text = "";
            uname.Text = "";
        }
    }
}
    