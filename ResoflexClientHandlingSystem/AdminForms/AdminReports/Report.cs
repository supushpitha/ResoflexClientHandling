using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResoflexClientHandlingSystem.AdminForms.AdminReports
{
    public partial class Report : MetroFramework.Forms.MetroForm
    {
        public Report()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void View_Click(object sender, EventArgs e)
        {
            string query = "SELECT distinct u_name, operation, logged_in_dateTime, logged_out_dateTime  FROM user_operations o, user u, user_log l where l.user_id = u.user_id and l.log_id = o.log_id and u.u_name= '" + usercombo.SelectedItem.ToString()+"';";

            runquery(query);
        }

        private void runquery(string query)
        {
            MySqlDataReader reader;
            DataTable table = new DataTable();
            table.Columns.Add("u_name", typeof(string));
            table.Columns.Add("operation", typeof(string));
            table.Columns.Add("logged_in_dateTime", typeof(DateTime));
            table.Columns.Add("logged_out_dateTime", typeof(DateTime));

            try
            {
                reader = Core.DBConnection.getData(query);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        table.Rows.Add(reader["u_name"].ToString(), reader["operation"].ToString(), reader["logged_in_dateTime"].ToString(), reader["logged_out_dateTime"].ToString());
                    }
                }
                reader.Close();

                Sample sample = new Sample();

                sample.Database.Tables["UserDSet"].SetDataSource(table);

                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.ReportSource = sample;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            

        }

        private void Report_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlDataReader reader = DBConnection.getData("SELECT u_name from  user;");

                while (reader.Read())
                {
                    usercombo.Items.Add(reader.GetValue(0).ToString());

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

        }

        private void viewmonthly_Click(object sender, EventArgs e)
        {
            string query = "select u.u_name, l.logged_in_dateTime,  l.logged_out_dateTime, timestampdiff(MINUTE, (l.logged_in_dateTime), (l.logged_out_dateTime)) as diff from user_log l, user u, user_operations o where u.user_id = l.user_id and " +
                "l.logged_out_dateTime IS NOT NULL;";

            runquery1(query);
        }

        private void runquery1(string query)
        {
            MySqlDataReader reader;
            DataTable table = new DataTable();
            table.Columns.Add("u_name", typeof(string));
            table.Columns.Add("logged_in_dateTime", typeof(DateTime));
            table.Columns.Add("logged_out_dateTime", typeof(DateTime));
            table.Columns.Add("diff", typeof(int));

            try
            {
                reader = Core.DBConnection.getData(query);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        table.Rows.Add(reader["u_name"].ToString(), reader["logged_in_dateTime"].ToString(), reader["logged_out_dateTime"].ToString(), int.Parse(reader.GetValue(3).ToString()));
                    }
                }
                reader.Close();

                MonthlyUsageReport sample = new MonthlyUsageReport();

                sample.Database.Tables["LogTable"].SetDataSource(table);

                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.ReportSource = sample;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

        }
    }
}
