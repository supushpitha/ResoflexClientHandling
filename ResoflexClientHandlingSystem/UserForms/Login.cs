using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;
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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {

            string uname = unameTextBox.Text.ToString();
            string pwd = Eramake.eCryptography.Encrypt(pwdTextBox.Text.ToString());

            try
            {

                MySqlDataReader dataReader1 = DBConnection.getData("SELECT COUNT(user_id),permission FROM user WHERE u_name='" + uname + "' and password='" + pwd+"';");

                if (dataReader1.HasRows)
                {

                    if (dataReader1.Read() && dataReader1["permission"].ToString() == "TCH")
                    {
                        dataReader1.Close();
                        this.Hide();

                        ClientForm pf = new ClientForm();
                        pf.Show();

                    }
                    else if(dataReader1.Read() && dataReader1["permission"].ToString() == "HRM")
                    {
                        dataReader1.Close();
                        this.Hide();

                        //Member_list ml = new Member_list();
                        //ml.Show();

                    }

                }
                else
                {
                    MessageBox.Show("Credentials are incorrect");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.StackTrace);
            }
        }

        private void unameTextBox_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
