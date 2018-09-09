using MySql.Data.MySqlClient;
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
    public partial class Notification : MetroFramework.Forms.MetroForm
    {
        public Notification()
        {
            InitializeComponent();
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            metroGrid1.DataSource = getNotifi();
            metroGrid1.Columns[0].Visible = false;

          


            if (!Userglobals.priv.ToLower().Equals("adm") && !Userglobals.priv.ToLower().Equals("admin"))
            {
                metroCheckBox2.Visible = false;
                metroButton2.Visible = false;
                metroTextBox1.Visible = false;

            }
            else
            {
                metroCheckBox2.Visible = true;
                metroButton2.Visible = true;
                metroTextBox1.Visible = true;

            }



        }

        
        private DataTable getNotifi()
        {
            if (Userglobals.priv.ToLower().Equals("adm") && !Userglobals.priv.ToLower().Equals("admin"))
            {
                DataTable table = new DataTable();

               
          


                MySqlDataReader reader2 = DBConnection.getData("select n.noti_ID, n.noti_Date, f.function, u.u_name, n.user_id from notification n, fucntion f, user u where n.function_id=f.fucntion_id and u.user_id=n.user_id and admin_view=0");

              

                table.Load(reader2);
                metroGrid1.ClearSelection();

                return table;
            }
            else
            {

                DataTable table = new DataTable();


                MySqlDataReader reader = DBConnection.getData("select n.noti_ID, n.noti_Date, f.function, s.description from notification n, fucntion f, notifi_status s where n.function_id=f.fucntion_id and s.id=n.statues and user_id="+Userglobals.uid+" and view=0");

                table.Load(reader);
                metroGrid1.ClearSelection();

                return table;

            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                int NotiID = Int32.Parse(metroTextBox1.Text);
                bool statues = metroCheckBox2.Checked;


                UserNotification notifi = new UserNotification(NotiID,statues);

                Database.grantPermission(notifi);

                MessageBox.Show("Permission successfully granted", "Permission Granted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           if (Userglobals.priv.ToLower().Equals("adm") )
            {
                try
                {
                    int notiID = Int32.Parse(metroTextBox1.Text);
                    int clear = metroCheckBox1.Checked ? 1 : 0;
                    int view =3;

                    UserNotification notifi = new UserNotification(notiID,clear,view);
                    Database.markReadedAdmin(notifi);

                    MessageBox.Show("Marked selected user's all notifications as readed", "Marked as Readed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    


                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.ToString());
                }
            }
            else
            {
                try
                {
                   
                    int userID = Userglobals.uid;
                    int clear = metroCheckBox1.Checked ? 1 : 0;

                    UserNotification notifi = new UserNotification(clear ,userID);
                    Database.markReaded(notifi);

                    MessageBox.Show("Marked all notifications as readed", "Marked as Readed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.ToString());
                }
            }
        }

        private void metroGrid1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int notiid = Int32.Parse(metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString());
            metroTextBox1.Text = notiid.ToString();
        }
    }
}
