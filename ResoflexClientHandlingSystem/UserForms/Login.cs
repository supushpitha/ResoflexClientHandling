using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;
using ResoflexClientHandlingSystem.Role;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
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

                MySqlDataReader dataReader1 = DBConnection.getData("SELECT COUNT(user_id) as count,permission, u_name, user_id FROM user WHERE u_name='" + uname + "' and password='" + pwd+"';");

                if (dataReader1.HasRows)
                { 

                    if (dataReader1.Read() && dataReader1["permission"].ToString() == "TCH")
                    {
                        Userglobals.uid = int.Parse(dataReader1["user_id"].ToString());
                        Userglobals.uname = dataReader1["u_name"].ToString();
                        Userglobals.priv = dataReader1["permission"].ToString();
                        Logglobals.ip = GetIPAddress().ToString();
                        Logglobals.login = DateTime.Now;


                        dataReader1.Close();
                        this.Hide();
                        Console.WriteLine(Logglobals.login);
                        Dashboard pf = new Dashboard();
                        
                        pf.Show();

                    }
                    else if(dataReader1["permission"].ToString() == "HRM")
                    {
                        Userglobals.uid = int.Parse(dataReader1["user_id"].ToString());
                        Userglobals.uname = dataReader1["u_name"].ToString();
                        Userglobals.priv = dataReader1["permission"].ToString();
                        Logglobals.ip = GetIPAddress().ToString();
                        Logglobals.login = DateTime.Now;


                        dataReader1.Close();
                        this.Hide();

                        Dashboard pf = new Dashboard();
                        pf.Show();

                    }
                    else if (dataReader1["permission"].ToString() == "ADM")
                    {
                        Userglobals.uid = int.Parse(dataReader1["user_id"].ToString());
                        Userglobals.uname = dataReader1["u_name"].ToString();
                        Userglobals.priv = dataReader1["permission"].ToString();
                        Logglobals.ip = GetIPAddress().ToString();
                        Logglobals.login = DateTime.Now;

                        dataReader1.Close();
                        this.Hide();

                        Dashboard pf = new Dashboard();
                        pf.Show();

                    }
                    else if (dataReader1["permission"].ToString() == "ACC")
                    {
                        Userglobals.uid = int.Parse(dataReader1["user_id"].ToString());
                        Userglobals.uname = dataReader1["u_name"].ToString();
                        Userglobals.priv = dataReader1["permission"].ToString();
                        Logglobals.ip = GetIPAddress().ToString();
                        Logglobals.login = DateTime.Now;

                        dataReader1.Close();
                        this.Hide();

                        Dashboard pf = new Dashboard();
                        pf.Show();

                    }
                    else if (dataReader1["permission"].ToString() == "PM")
                    {
                        Userglobals.uid = int.Parse(dataReader1["user_id"].ToString());
                        Userglobals.uname = dataReader1["u_name"].ToString();
                        Userglobals.priv = dataReader1["permission"].ToString();
                        Logglobals.ip = GetIPAddress().ToString();
                        Logglobals.login = DateTime.Now;

                        dataReader1.Close();
                        this.Hide();

                        Dashboard pf = new Dashboard();
                        pf.Show();
                    }
                    else
                    {
                        dataReader1.Close();
                        MessageBox.Show("You are not authorized to log in..");

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

        public static IPAddress GetIPAddress()
        {
            IPAddress ip = Dns.GetHostAddresses(Dns.GetHostName()).Where(address =>
            address.AddressFamily == AddressFamily.InterNetwork).First();
            return ip;
        }
    }
}
