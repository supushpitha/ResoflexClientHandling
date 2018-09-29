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

namespace ResoflexClientHandlingSystem.OfficeExpensesForm
{
    public partial class OfficeExpReports : MetroFramework.Forms.MetroForm
    {
        public OfficeExpReports()
        {
            InitializeComponent();
        }

        private void OfficeExpReports_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string dateFormat = "yyyy-MM-dd";
            string qry = "select e.date, s.first_name, e.Category,e.amount from office_expenses e, staff s where s.staff_id=e.staff_id and type='Direct' and date between '"+ metroDateTime1.Value.ToString(dateFormat) + "'  and '" + metroDateTime2.Value.ToString(dateFormat) + "';";
            DataSet(qry);
            
            Console.WriteLine("Hello '"+ metroDateTime2.Value.ToString(dateFormat) + "'");
        }


        //direct
        private void DataSet(string qry)
        {
            DataTable table = new DataTable();
            MySqlDataReader reader;

            table.Columns.Add("date", typeof(DateTime));
            table.Columns.Add("first_name", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("amount", typeof(double));


            try
            {
                reader = DBConnection.getData(qry);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        table.Rows.Add( reader.GetDateTime("date"), reader.GetString("first_name"), reader.GetString("Category"), reader.GetDouble("amount"));
                    }

                }
                reader.Close();

                OfficeExpensesForm.Reports.OfficeDirExp report = new Reports.OfficeDirExp();

                report.Database.Tables["OffDirect"].SetDataSource(table);
                

                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.ReportSource = report;


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());

            }

        }

        //IOU
        private void DataSet2(string qry)
        {
            DataTable table = new DataTable();
            MySqlDataReader reader;

            table.Columns.Add("date", typeof(DateTime));
            table.Columns.Add("first_name", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("amount", typeof(double));


            try
            {
                reader = DBConnection.getData(qry);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        table.Rows.Add(reader.GetDateTime("date"), reader.GetString("first_name"), reader.GetString("Category"), reader.GetDouble("amount"));
                    }

                }
                reader.Close();

                OfficeExpensesForm.Reports.OfficeIOUExp report = new Reports.OfficeIOUExp();

                report.Database.Tables["OffDirect"].SetDataSource(table);


                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.ReportSource = report;


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());

            }

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            string dateFormat = "yyyy-MM-dd";
            string qry = "select e.date, s.first_name, e.Category,e.amount from office_expenses e, staff s where s.staff_id=e.staff_id and type='IOU' and date between '" + metroDateTime1.Value.ToString(dateFormat) + "'  and '" + metroDateTime2.Value.ToString(dateFormat) + "';";
            DataSet2(qry);
        }
    }
}
