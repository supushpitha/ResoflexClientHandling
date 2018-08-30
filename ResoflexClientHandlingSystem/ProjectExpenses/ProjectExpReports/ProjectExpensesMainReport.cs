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

namespace ResoflexClientHandlingSystem.ProjectExpenses.ProjectExpReports
{
    public partial class ProjectExpensesMainReport : Form
    {
        string qry = "";

        public ProjectExpensesMainReport()
        {
            InitializeComponent();
        }

        public ProjectExpensesMainReport(string qry)
        {
            InitializeComponent();

            this.qry = qry;
        }

        private void ProjectExpensesMainReport_Load(object sender, EventArgs e)
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
    }
}
