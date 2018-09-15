using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;
using ResoflexClientHandlingSystem.ProjectExpenses.ProjectExpReports;
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
    public partial class GenarateReportForm : MetroFramework.Forms.MetroForm
    {
        public GenarateReportForm()
        {
            InitializeComponent();
        }

        private void GenarateReportForm_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string qry = "select p.proj_name, c.name, IFNULL(COUNT(e.proj_id), 0) as nos, IFNULL(SUM(ex.amount),0) as exp from project p inner join client c on " +
                         "p.client_id=c.client_id LEFT join event e on e.proj_id=p.proj_id LEFT join exp_detail_event ex on ex.proj_id=.p.proj_id GROUP BY p.proj_id;";
            
            testReport(qry);
        }

        public void testReport(string qry)
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = null;

            table.Columns.Add("Project_Name", typeof(string));
            table.Columns.Add("Client_Name", typeof(string));
            table.Columns.Add("No_of_Events", typeof(int));
            table.Columns.Add("Expense", typeof(double));

            try
            {
                reader = DBConnection.getData(qry);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        table.Rows.Add(reader.GetString("proj_name"), reader.GetString("name"), reader.GetInt32("nos"), reader.GetDouble("exp"));
                    }

                    if (reader != null)
                        if (!reader.IsClosed)
                            reader.Close();

                    MonthlyProjectExpReport rpt = new MonthlyProjectExpReport();

                    rpt.Database.Tables["ProjExp"].SetDataSource(table);

                    crvProjExpMainViewer.ReportSource = null;
                    crvProjExpMainViewer.ReportSource = rpt;
                }
                else
                {
                    if (reader != null)
                        if (!reader.IsClosed)
                            reader.Close();

                    MessageBox.Show("No records yet!", "Project Expense Reporting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exc)
            {
                if (reader != null)
                    if (!reader.IsClosed)
                        reader.Close();

                MessageBox.Show("No records yet!\n" + exc, "Project Expense Reporting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            string qry = "select p.proj_name, c.name, IFNULL(COUNT(e.proj_id), 0) as nos, IFNULL(SUM(ex.amount),0) as exp from project p inner join client c on " +
                         "p.client_id=c.client_id LEFT join event e on e.proj_id=p.proj_id LEFT join exp_detail_event ex on ex.proj_id=.p.proj_id where c.client_id=2 GROUP BY p.proj_id;";
            
            testReport(qry);
        }
    }
}
