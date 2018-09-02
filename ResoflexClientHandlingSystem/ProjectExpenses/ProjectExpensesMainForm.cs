using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;
using ResoflexClientHandlingSystem.ProjectExpenses.ProjectExpReports;
using System;
using System.Windows.Forms;

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
            createChart();
            spinProgress();
        }

        private void spinProgress()
        {
            double lastMonthExp = 0.0;
            double thisMonthExp = 0.0;

            MySqlDataReader reader = DBConnection.getData("select dateOfExp ym, IFNULL(SUM(amount), 0) as sum from exp_detail_event " +
                "group by MONTH(dateOfExp) order by MONTH(dateOfExp)");

            try
            {
                while (reader.Read())
                {
                    if ((reader.GetDateTime(0).Year == DateTime.Now.Year) && (reader.GetDateTime(0).Month == DateTime.Now.Month))
                    {
                        thisMonthExp = reader.GetDouble(1);
                    }
                    else if ((reader.GetDateTime(0).Year == DateTime.Now.Year) && (reader.GetDateTime(0).Month == DateTime.Now.Month - 1))
                    {
                        lastMonthExp = reader.GetDouble(1);
                    }
                }

                reader.Close();

                double progress = (thisMonthExp / lastMonthExp) * 100;

                if (progress > 100)
                {
                    monthCompProgressSpinner.Style = MetroFramework.MetroColorStyle.Green;
                    progress = progress % 100;
                }
                else if (progress < 100)
                    monthCompProgressSpinner.Style = MetroFramework.MetroColorStyle.Red;
                else
                    monthCompProgressSpinner.Style = MetroFramework.MetroColorStyle.Yellow;

                progLbl.Text = "" + (int) progress + "%";
                monthCompProgressSpinner.Value = (int) progress;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error in creating chart!\n" + exc, "Chart drawer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reader.Close();
            }
        }

        private void createChart()
        {
            System.Windows.Forms.DataVisualization.Charting.Series series = chart1.Series[0];
            
            MySqlDataReader reader = DBConnection.getData("select MONTH(dateOfExp) month, IFNULL(SUM(amount), 0) as sum from exp_detail_event " +
                "group by MONTH(dateOfExp)");

            try
            {
                while (reader.Read())
                {
                    series.Points.AddXY(getMonthName(reader.GetInt16(0)), reader.GetDouble(1));
                }

                reader.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error in creating chart!\n" + exc, "Chart drawer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reader.Close();
            }
        }

        private string getMonthName(int monthNo)
        {
            switch (monthNo)
            {
                case 1:
                    return "Jan";
                case 2:
                    return "Feb";
                case 3:
                    return "Mar";
                case 4:
                    return "Apr";
                case 5:
                    return "May";
                case 6:
                    return "Jun";
                case 7:
                    return "Jul";
                case 8:
                    return "Aug";
                case 9:
                    return "Sep";
                case 10:
                    return "Oct";
                case 11:
                    return "Nov";
                case 12:
                    return "Dec";
                default:
                    return "Non";
            }
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
            chart1.Focus();
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
            reader = DBConnection.getData("SELECT * FROM ((SELECT IFNULL(SUM(ev.amount), 0) as outExp FROM exp_detail_event ev) " +
                "UNION (SELECT IFNULL(SUM(ip.amount), 0) inExp FROM project_exp_in_amount ip)) tmp");

            if (reader.HasRows)
            {
                double balance = 0.0;
                double inExp = 0.0, outExp = 0.0;
                int count = 0;

                while (reader.Read())
                {
                    if (count == 0)
                        outExp = reader.GetDouble(0);
                    else if (count == 1)
                        inExp = reader.GetDouble(0);

                    count++;
                }

                balance = inExp - outExp;

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
