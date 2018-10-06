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

namespace ResoflexClientHandlingSystem.AttendanceForms.Reports
{
    public partial class AttendanceReportViewerForm : MetroFramework.Forms.MetroForm
    {
        DataTable dt = new DataTable();

        public AttendanceReportViewerForm()
        {
            InitializeComponent();
        }

        public AttendanceReportViewerForm(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
            
        }

        private void AttendanceReportViewerForm_Load(object sender, EventArgs e)
        {
            metroComboBox1.ValueMember = "staff_id";
            metroComboBox1.DisplayMember = "fullname";
            metroComboBox1.DataSource = getEmployees();

            fromDT.Value = DateTime.Now.AddDays(-30);
        }

        public void setReport(string qry)
        {
            MySqlDataReader reader = null;
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("StaffID",typeof(int));
            dataTable.Columns.Add("FirstName",typeof(string));
            dataTable.Columns.Add("LastName",typeof(string));
            dataTable.Columns.Add("InTime",typeof(DateTime));
            dataTable.Columns.Add("OutTime",typeof(DateTime));
            dataTable.Columns.Add("TotalHours",typeof(TimeSpan));
            dataTable.Columns.Add("EffectiveHours",typeof(int));

            try
            {
                reader = DBConnection.getData(qry);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataTable.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),  reader.GetDateTime(3), reader.GetDateTime(4), reader.GetTimeSpan(5), reader.GetInt32(6));
                        
                    }
                }

                reader.Close();

                AttendanceReport rpt = new AttendanceReport();

                rpt.Database.Tables["DataTable1"].SetDataSource(dataTable);

                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.ReportSource = rpt;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Something went wrong!\n" + exc, "Report generator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable getEmployees()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("select first_name as fullname, staff_id from staff order by first_name");
            table.Load(reader);
            return table;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            int staffID = Int32.Parse(metroComboBox1.SelectedValue.ToString());
            DateTime from = fromDT.Value;
            DateTime to = ToDT.Value;
            setReport("SELECT staffID, FirstName, LastName, InTime as InTime, OutTime as OutTime, TIMEDIFF(OutTime, InTime) as TotalHours, TotalHours as EffectiveHours FROM attendanceview where staffID = " +staffID+ " AND (DATE(InTime) >= '" + from.ToString("y/M/d") + "' AND DATE(InTime) <= '" + to.ToString("y/M/d") + "')");

        }
    }
}
