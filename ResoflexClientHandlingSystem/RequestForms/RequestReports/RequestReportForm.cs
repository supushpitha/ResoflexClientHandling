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

namespace ResoflexClientHandlingSystem.RequestForms.RequestReports
{
    public partial class RequestReportForm : MetroFramework.Forms.MetroForm
    {
        public RequestReportForm()
        {
            InitializeComponent();
        }

        private void RequestReportForm_Load(object sender, EventArgs e)
        {
            horizontalLineLbl.AutoSize = false;
            horizontalLineLbl.Width = 280;
            horizontalLineLbl.Height = 2;
            horizontalLineLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            horizontalLineLblTwo.AutoSize = false;
            horizontalLineLblTwo.Width = 280;
            horizontalLineLblTwo.Height = 2;
            horizontalLineLblTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            fillDevCmbBox();

            devCmbBox.SelectedItem = null;
        }

        private void fillDevCmbBox()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("SELECT staff_id, CONCAT(first_name, ' ', last_name) as name FROM staff s inner join designation d on s.desig_id=d.desig_id where d.designation_name='TCH';");

            table.Load(reader);

            devCmbBox.DataSource = table;
            devCmbBox.ValueMember = "staff_id";
            devCmbBox.DisplayMember = "name";
        }

        private void RequestReportForm_Shown(object sender, EventArgs e)
        {
            requestReportViewer.Focus();
        }

        private void reqRepBtn_Click(object sender, EventArgs e)
        {
            int staffId = Int32.Parse(devCmbBox.SelectedValue.ToString());

            string qry = "SELECT pr.request, pr.added_date, pr.started_dateTime, pr.ended_dateTime, p.proj_name, c.name, concat(s.first_name, ' ', s.last_name) as dev_name, IFNULL(n.perm_by_id, 0) as perm_by_id FROM proj_request pr LEFT JOIN staff s ON pr.staff_id=s.staff_id LEFT JOIN notification n ON pr.proj_id=n.main_id AND pr.req_id=n.sub_id LEFT JOIN project p ON pr.proj_id=p.proj_id LEFT JOIN client c ON p.client_id=c.client_id WHERE pr.staff_id=" + staffId + ";";

            generateReport(qry, true);
        }

        private void generateReport(string qry, bool from)
        {
            MySqlDataReader reqReader = null;
            MySqlDataReader permReader = null;

            DataTable reqTable = new DataTable();

            reqTable.Columns.Add("Project", typeof(string));
            reqTable.Columns.Add("Client", typeof(string));
            reqTable.Columns.Add("Request", typeof(string));
            reqTable.Columns.Add("Added", typeof(DateTime));
            reqTable.Columns.Add("Started", typeof(DateTime));
            reqTable.Columns.Add("Ended", typeof(DateTime));
            reqTable.Columns.Add("Developer", typeof(string));
            reqTable.Columns.Add("Dev_Time", typeof(TimeSpan));
            reqTable.Columns.Add("Perm_Granted_By", typeof(string));
            
            try
            {
                reqReader = DBConnection.getData(qry);

                if (reqReader.HasRows)
                {
                    while (reqReader.Read())
                    {
                        permReader = DBConnection.getDataViaTmpConnection("select IFNULL(concat(first_name, ' ', last_name), ' ') as permName from staff where staff_id=" + reqReader.GetInt32("perm_by_id"));
                        string permName = "";

                        if (permReader.HasRows)
                        {
                            while (permReader.Read())
                            {
                                permName = permReader.GetString(0);
                            }
                        }

                        permReader.Close();
                        DBConnection.closeTmpConnection();

                        Object obj;

                        try
                        {
                            obj = reqReader.GetString(3);
                        }
                        catch (Exception)
                        {
                            obj = null;
                        }

                        if (obj == null)
                        {
                            Object obj2;

                            try
                            {
                                obj2 = reqReader.GetString(2);
                            }
                            catch (Exception)
                            {
                                obj2 = null;
                            }

                            if (obj2 == null)
                            {
                                reqTable.Rows.Add(reqReader.GetString(4), reqReader.GetString(5), reqReader.GetString(0), reqReader.GetDateTime(1), null, null, null, null, permName);
                            }
                            else
                            {
                                reqTable.Rows.Add(reqReader.GetString(4), reqReader.GetString(5), reqReader.GetString(0), reqReader.GetDateTime(1), reqReader.GetDateTime(2), null, reqReader.GetString(6), null, permName);
                            }
                        }
                        else
                        {
                            reqTable.Rows.Add(reqReader.GetString(4), reqReader.GetString(5), reqReader.GetString(0), reqReader.GetDateTime(1), reqReader.GetDateTime(2), reqReader.GetDateTime(3), reqReader.GetString(6), (reqReader.GetDateTime(3) - reqReader.GetDateTime(2)), permName);
                        }
                    }

                    if (reqReader != null)
                        if (!reqReader.IsClosed)
                            reqReader.Close();

                    if (permReader != null)
                        if (!permReader.IsClosed)
                            permReader.Close();

                    if (from)
                    {
                        ChangeRequestReport rpt = new ChangeRequestReport();

                        rpt.Database.Tables["ChangeReqTable"].SetDataSource(reqTable);

                        requestReportViewer.ReportSource = null;
                        requestReportViewer.ReportSource = rpt;
                    }
                    else
                    {
                        FullRequestReport rpt = new FullRequestReport();

                        rpt.Database.Tables["ChangeReqTable"].SetDataSource(reqTable);

                        requestReportViewer.ReportSource = null;
                        requestReportViewer.ReportSource = rpt;
                    }
                }
                else
                {
                    if (reqReader != null)
                        if (!reqReader.IsClosed)
                            reqReader.Close();

                    if (permReader != null)
                        if (!permReader.IsClosed)
                            permReader.Close();

                    MessageBox.Show("No Records for this Developer!", "Change Request Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    devCmbBox.SelectedItem = null;
                    requestReportViewer.Focus();
                    requestReportViewer.ReportSource = null;
                }
            }
            catch (Exception exc)
            {
                if (reqReader != null)
                    if (!reqReader.IsClosed)
                        reqReader.Close();

                if (permReader != null)
                    if (!permReader.IsClosed)
                        permReader.Close();
                
                MessageBox.Show("Something went wrong!\n" + exc, "Change Request Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                devCmbBox.SelectedItem = null;
                requestReportViewer.Focus();
                requestReportViewer.ReportSource = null;
            }
        }

        private void fullReportBtn_Click(object sender, EventArgs e)
        {
            string qry = "SELECT pr.request, pr.added_date, pr.started_dateTime, pr.ended_dateTime, p.proj_name, c.name, concat(s.first_name, ' ', s.last_name) as dev_name, IFNULL(n.perm_by_id, 0) as perm_by_id FROM proj_request pr LEFT JOIN staff s ON pr.staff_id=s.staff_id LEFT JOIN notification n ON pr.proj_id=n.main_id AND pr.req_id=n.sub_id LEFT JOIN project p ON pr.proj_id=p.proj_id LEFT JOIN client c ON p.client_id=c.client_id;";

            generateReport(qry, false);
        }
    }
}
