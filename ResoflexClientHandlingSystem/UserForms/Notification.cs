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
            metroGrid1.Columns[7].Visible = false;
            changeGridRowColors();


            if (!Userglobals.priv.ToLower().Equals("adm") && !Userglobals.priv.ToLower().Equals("admin"))
            {
                allowCheckBox.Visible = false;
                declinedCheckBox.Visible = false;
                saveDecisionBtn.Visible = false;
                passreset.Visible = false;
            }
        }

        private DataTable getNotifi()
        {
            if (Userglobals.priv.ToLower().Equals("adm") && !Userglobals.priv.ToLower().Equals("admin"))
            {
                DataTable table = new DataTable();

                MySqlDataReader reader2 = DBConnection.getData("select n.noti_ID, n.noti_Date, s.first_name, f.function, n.statues, r.request, r.urgent, n.admin_view from " +
                    "notification n, fucntion f, proj_request r, staff s where n.function_id=f.fucntion_id and n.user_id=s.staff_id and n.main_id=r.proj_id and " +
                    "n.sub_id=r.req_id order by admin_view asc;");

                table.Load(reader2);
                metroGrid1.ClearSelection();
                reader2.Close();
                return table;
            }
            else if (!Userglobals.uname.Equals(""))
            {
                DataTable table = new DataTable();

                MySqlDataReader reader = DBConnection.getData("select n.noti_ID, n.noti_Date, s.first_name, f.function, n.statues, r.request, r.urgent, n.admin_view from " +
                    "notification n, fucntion f, proj_request r, staff s where n.function_id=f.fucntion_id and n.user_id=s.staff_id and n.main_id=r.proj_id and " +
                    "n.sub_id=r.req_id and s.staff_id=" + Userglobals.uid + " order by view desc;");

                table.Load(reader);
                metroGrid1.ClearSelection();
                reader.Close();
                return table;
            }

            return null;
        }

        public void changeGridRowColors()
        {
            foreach (DataGridViewRow row in metroGrid1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[7].Value))
                {
                    row.DefaultCellStyle.ForeColor = Color.Green;
                    row.DefaultCellStyle.SelectionForeColor = Color.Green;
                }
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                int NotiID = Int32.Parse(metroTextBox1.Text);
                bool status = false;

                if (allowCheckBox.Checked)
                    status = true;

                UserNotification notifi = new UserNotification(NotiID, status);

                Database.grantPermission(notifi);

                metroTextBox1.Text = "";
                reqDevTxtBox.Text = "";
                changeReqTxtBox.Text = "";

                allowCheckBox.Checked = false;
                declinedCheckBox.Checked = false;

                metroGrid1.DataSource = getNotifi();
                metroGrid1.Columns[0].Visible = false;
                metroGrid1.Columns[7].Visible = false;
                changeGridRowColors();

                Dashboard db = new Dashboard();

                db.notify();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void metroGrid1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int notiid = Int32.Parse(metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString());
            metroTextBox1.Text = notiid.ToString();
            reqDevTxtBox.Text = metroGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
            changeReqTxtBox.Text = metroGrid1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = "";
            reqDevTxtBox.Text = "";
            changeReqTxtBox.Text = "";

            allowCheckBox.Checked = false;
            declinedCheckBox.Checked = false;
            metroRadioButton1.Checked = false;
            metroRadioButton2.Checked = false;

            metroGrid1.DataSource = getNotifi();
            metroGrid1.Columns[0].Visible = false;
            metroGrid1.Columns[7].Visible = false;
            changeGridRowColors();
        }

        private void metroRadioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            if (Userglobals.priv.ToLower().Equals("adm") && !Userglobals.priv.ToLower().Equals("admin"))
            {
                DataTable table = new DataTable();

                MySqlDataReader reader = DBConnection.getData("select n.noti_ID, n.noti_Date, s.first_name, f.function, n.statues, r.request, r.urgent, n.admin_view from " +
                    "notification n, fucntion f, proj_request r, staff s where n.function_id=f.fucntion_id and n.user_id=s.staff_id and n.main_id=r.proj_id and " +
                    "n.sub_id=r.req_id and admin_view=1 order by view desc;");

                table.Load(reader);
                metroGrid1.ClearSelection();

                metroGrid1.DataSource = table;

                metroGrid1.Columns[0].Visible = false;
                metroGrid1.Columns[7].Visible = false;
                changeGridRowColors();

                reader.Close();
            }
            else if (!Userglobals.uname.Equals(""))
            {
                DataTable table = new DataTable();

                MySqlDataReader reader = DBConnection.getData("select n.noti_ID, n.noti_Date, s.first_name, f.function, n.statues, r.request, r.urgent, n.admin_view from " +
                    "notification n, fucntion f, proj_request r, staff s where n.function_id=f.fucntion_id and n.user_id=s.staff_id and n.main_id=r.proj_id and " +
                    "n.sub_id=r.req_id and s.staff_id=" + Userglobals.uid + " and admin_view=1 order by view desc;");

                table.Load(reader);
                metroGrid1.ClearSelection();

                metroGrid1.DataSource = table;

                metroGrid1.Columns[0].Visible = false;
                metroGrid1.Columns[7].Visible = false;
                changeGridRowColors();
                reader.Close();
            }
        }

        private void metroRadioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            if (Userglobals.priv.ToLower().Equals("adm") && !Userglobals.priv.ToLower().Equals("admin"))
            {
                DataTable table = new DataTable();

                MySqlDataReader reader = DBConnection.getData("select n.noti_ID, n.noti_Date, s.first_name, f.function, n.statues, r.request, r.urgent, n.admin_view from " +
                    "notification n, fucntion f, proj_request r, staff s where n.function_id=f.fucntion_id and n.user_id=s.staff_id and n.main_id=r.proj_id and " +
                    "n.sub_id=r.req_id and admin_view=0 order by view desc;");

                table.Load(reader);
                metroGrid1.ClearSelection();

                metroGrid1.DataSource = table;

                metroGrid1.Columns[0].Visible = false;
                metroGrid1.Columns[7].Visible = false;
                changeGridRowColors();
                reader.Close();
            }
            else if (!Userglobals.uname.Equals(""))
            {
                DataTable table = new DataTable();

                MySqlDataReader reader = DBConnection.getData("select n.noti_ID, n.noti_Date, s.first_name, f.function, n.statues, r.request, r.urgent, n.admin_view from " +
                    "notification n, fucntion f, proj_request r, staff s where n.function_id=f.fucntion_id and n.user_id=s.staff_id and n.main_id=r.proj_id and " +
                    "n.sub_id=r.req_id and s.staff_id=" + Userglobals.uid + " and admin_view=0 order by view desc;");

                table.Load(reader);
                metroGrid1.ClearSelection();

                metroGrid1.DataSource = table;

                metroGrid1.Columns[0].Visible = false;
                metroGrid1.Columns[7].Visible = false;
                changeGridRowColors();
                reader.Close();
            }
        }

        private void passreset_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable table = new DataTable();

            MySqlDataReader reader = DBConnection.getData("select n.noti_ID,n.noti_Date,u.u_name, f.function from user u, notification n, fucntion f where f.fucntion_id=n.function_id and n.user_id=u.user_id and function_id=2" +
                " and n.noti_ID = 0");
            table.Load(reader);
            metroGrid1.ClearSelection();

            metroGrid1.DataSource = table;

            //metroGrid1.Columns[0].Visible = false;
            //metroGrid1.Columns[7].Visible = false;
            reader.Close();
        }

        private void metroGrid1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView g = sender as DataGridView;

            if (g.CurrentRow.Selected)
            {
                string s = g.CurrentRow.Cells[3].Value.ToString();
                

                if (s.Equals("request password reset"))
                {
                    UserNotification notification = new UserNotification();
                    notification.NotiId = int.Parse(g.CurrentRow.Cells[0].Value.ToString());

                    //Database.acceptResetPass(notification);

                    MessageBox.Show("Notification cleared.");
                }


            }
        }
    }
}

