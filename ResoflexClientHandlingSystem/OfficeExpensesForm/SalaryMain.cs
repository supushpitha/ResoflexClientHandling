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
    public partial class SalaryMain : MetroFramework.Forms.MetroForm
    {
        public SalaryMain()
        {
            InitializeComponent();
        }

        private void SalaryMain_Load(object sender, EventArgs e)
        {
            metroGrid1.DataSource = grid1();
            fillTiles();
            metroGrid1.Columns[0].Visible = false;
        }


        private DataTable grid1()
        {
            DataTable table = new DataTable();

            MySqlDataReader reader = DBConnection.getData("select s.sal_id , t.first_name as Employee, s.basic_sal_amount as Basic, s.allowance as Allowance, s.etf_epf_amount as EPF, s.rate as Rate,s.hours as Hours,s.gross_sal as Gross, s.net_sal as Net  from salary s , staff t where s.staff_id=t.staff_id");

            table.Load(reader);

            return table;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SalaryForm frm = new SalaryForm();
            frm.Show();
        }


        private void fillTiles()
        {

            DateTime curdate = DateTime.Now;
            curdate = curdate.AddDays(-30);
            string a = DateTime.Now.ToString("yyyy-MM-dd");
            string b = curdate.ToString("yyyy-MM-dd");
            try
            {

                MySqlDataReader reader = DBConnection.getData("select sum(net_sal) from salary where sal_date between '" + b + "'  and '" + a + "' ");

                while (reader.Read())
                {
                    metroTile1.Text = "Rs." + reader.GetDouble(0);
                }

                reader.Close();


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

            SalaryForm frm = new SalaryForm();
            frm.Show();
        }
    }

}
