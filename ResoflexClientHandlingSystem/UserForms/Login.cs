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
                    while(dataReader1.Read()){

                        Userglobals.uid = int.Parse(dataReader1["user_id"].ToString());
                        Userglobals.uname = dataReader1["u_name"].ToString();
                        Userglobals.priv = dataReader1["permission"].ToString();
                        Logglobals.ip = GetIPAddress().ToString();
                        Logglobals.login = DateTime.Now;
                    }
                    

                    if (dataReader1["permission"].ToString() != "NA")
                    {
                        dataReader1.Close();
                        loginFunction();

                        Console.WriteLine(Logglobals.id);

                        this.Hide();
                        
                        Dashboard pf = new Dashboard();
                        
                        pf.ShowDialog();
                        this.Close();
                    }
                    else
                    {
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

        private void loginFunction()
        {
            User user = new User(Userglobals.uid);

            Role.UserLog log = new Role.UserLog(user, Logglobals.login.ToString("yyyy-MM-dd HH:mm:ss"), Logglobals.ip);

            Database.addLog(log);

            MySqlDataReader dataReader = DBConnection.getData("SELECT log_id FROM user_log WHERE user_id='" + user.UserId + "' and logged_in_dateTime='" + Logglobals.login.ToString("yyyy-MM-dd HH:mm:ss") + "'and ip ='" + Logglobals.ip + "'; ");

            while (dataReader.Read())
            {
                Logglobals.id = int.Parse(dataReader["log_id"].ToString());
            }
            dataReader.Close();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            //unameTextBox.
        }
    }
}
