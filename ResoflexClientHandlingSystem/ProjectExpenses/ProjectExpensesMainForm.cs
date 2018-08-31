using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;
using ResoflexClientHandlingSystem.ProjectExpenses.ProjectExpReports;
using System;

namespace ResoflexClientHandlingSystem
{
    public partial class ProjectExpensesMainForm : MetroFramework.Forms.MetroForm
    {
        public ProjectExpensesMainForm()
        {
            InitializeComponent();
        }

        private void ProjectExpensesMainForm_Load(object sender, EventArgs e)
        {
            monthCompProgressSpinner.Value = 75;
        }

        private void viewBalanceBtn_Click(object sender, EventArgs e)
        {
            BalanceSheetForm frm = new BalanceSheetForm();

            frm.Show();
        }

        private void getReportBtn_Click(object sender, EventArgs e)
        {
            GenarateReportForm frm = new GenarateReportForm();

            frm.Show();
        }

        private void viewIouBtn_Click(object sender, EventArgs e)
        {
            IOUDetailsForm frm = new IOUDetailsForm();

            frm.Show();
        }

        private void viewEventBtn_Click(object sender, EventArgs e)
        {
            EventDetailsForm frm = new EventDetailsForm();

            frm.Show();
        }

        private void ProjectExpensesMainForm_Shown(object sender, EventArgs e)
        {
            fillTiles();
        }

        private void fillTiles()
        {
            // Filling the Project Exp. of this Month Tile
            MySqlDataReader reader = DBConnection.getData("select IFNULL(SUM(amount), 0) from exp_detail_event WHERE Year(dateOfExp)=" + DateTime.Now.Year + " AND " +
                "MONTH(dateOfExp)=" + 8/*DateTime.Now.Month*/);

            while (reader.Read())
            {
                projExpMonthTile.Text = "Rs." + reader.GetDouble(0);
            }

            reader.Close();

            // Filling the Balance Tile
            reader = DBConnection.getData("SELECT * FROM ((SELECT IFNULL(SUM(ev.amount), 0) as outExp FROM exp_detail_event ev) UNION (SELECT IFNULL(SUM(ip.amount), 0) inExp FROM project_exp_in_amount ip)) tmp");

            if (reader.HasRows)
            {
                double balance = 0.0;
                double inE = 0.0, outEx = 0.0;
                int count = 0;

                while (reader.Read())
                {
                    if (count == 0)
                        outEx = reader.GetDouble(0);
                    else if (count == 1)
                        inE = reader.GetDouble(0);

                    count++;
                }

                balance = inE - outEx;

                balTile.Text = "Rs." + balance;
            }
            else
            {
                balTile.Text = "Rs.0.00";
            }

            reader.Close();

            // Filling the Max Event Tile
            reader = DBConnection.getData("select IFNULL(MAX(amount), 0) from exp_detail_event");

            while (reader.Read())
            {
                MaxSpentEventTile.Text = "Rs." + reader.GetDouble(0);
            }

            reader.Close();
        }
    }
}
