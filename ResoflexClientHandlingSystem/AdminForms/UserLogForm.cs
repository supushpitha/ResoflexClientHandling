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
    public partial class UserLog : MetroFramework.Forms.MetroForm
    {
        public UserLog()
        {
            InitializeComponent();
        }

        private void UserLog_Load(object sender, EventArgs e)
        {
            LogGrid.DataSource = getLogList();

            if (Userglobals.uname == "")
            {
                profilebtn.Visible = false;

            }
            else
            {
                if (Userglobals.priv != "ADM")
                {
                    addUsers.Visible = false;
                    updateUsers.Visible = false;
                }

                profilebtn.Visible = true;
                profilebtn.Text = Userglobals.uname;

                
            }


        }

        private void addUsers_Click(object sender, EventArgs e)
        {
            UserAddForm uaf = new UserAddForm();
            this.Hide();
            uaf.ShowDialog();
            this.Close();
        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            ProfileForm prffrm = new ProfileForm();
            this.Hide();
            prffrm.ShowDialog();
            this.Close();
        }

        private DataTable getLogList()
        {
            DataTable dt = new DataTable();

            try
            {
                MySqlDataReader reader = DBConnection.getData("SELECT u.log_id as LogID, s.u_name as Username, u.logged_in_dateTime as LoginTime, u.logged_out_datetime as LogoutTime, " +
                    " u.detail as Detail, u.ip as IP FROM user_log u, user s where s.user_id = u.user_id");

                dt.Load(reader);

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return dt;
        }

        private void userComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            try
            {
                MySqlDataReader reader = DBConnection.getData("SELECT u.log_id as LogID, s.u_name as Username, u.logged_in_dateTime as LoginTime, u.logged_out_datetime as LogoutTime, " +
                    " u.detail as Detail, u.ip as IP FROM user_log u, user s where s.user_id = u.user_id and s.u_name LIKE'%" + metroTextBox1.Text.ToString()+"%'");

                if (reader.HasRows)
                {
                    System.Data.DataTable table = new System.Data.DataTable();

                    table.Load(reader);

                    LogGrid.DataSource = table;
                }
                else
                {
                    reader.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Invalid data!\n" + exc.StackTrace, "User Log finder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimeto_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimeTo.Value;


            if (dateTime.Equals(dateTimefrom.Value) || dateTime < dateTimefrom.Value)
            {
                MessageBox.Show("Invalid 'from' date");
            }
            else
            {
                DataTable dt = new DataTable();

                try
                {
                    MySqlDataReader reader = DBConnection.getData("SELECT u.log_id as LogID, s.u_name as Username, u.logged_in_dateTime as LoginTime, u.logged_out_datetime as LogoutTime,"
                       +" u.detail as Detail, u.ip as IP FROM user_log u, user s where s.user_id = u.user_id and date(u.logged_in_dateTime) <= '"+ dateTimefrom.Value +"' and  date(u.logged_out_dateTime) <= '" + dateTimeTo.Value + "';");

                    if (reader.HasRows)
                    {
                        System.Data.DataTable table = new System.Data.DataTable();

                        table.Load(reader);
                        LogGrid.DataSource = table;
                    }
                    else
                    {
                        reader.Close();
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Invalid data!\n" + exc.StackTrace, "User Log finder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
