using System;
using ResoflexClientHandlingSystem.Core;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResoflexClientHandlingSystem.Common;

namespace ResoflexClientHandlingSystem
{ 
    public partial class BalanceSheetForm : MetroFramework.Forms.MetroForm
    {
        DataTable bSheet = new DataTable();

        public BalanceSheetForm()
        {
            InitializeComponent();

            bSheet.Columns.Add("In_Date", typeof(DateTime));
            bSheet.Columns.Add("In_Amount", typeof(double));
            bSheet.Columns.Add("Out_Type", typeof(string));
            bSheet.Columns.Add("Out_Date", typeof(DateTime));
            bSheet.Columns.Add("Out_PaymentType", typeof(string));
            bSheet.Columns.Add("Out_Amount", typeof(double));
            bSheet.Columns.Add("Balance", typeof(double));
        }

        public void getGridData()
        {
            MySqlDataReader reader = DBConnection.getData("select in_date, amount from project_exp_in_amount order by in_date");

            DataTable inTable = new DataTable();
            inTable.Load(reader);

            reader.Close();

            MySqlDataReader rdr = DBConnection.getData("select e.type, ede.dateOfExp, ede.paymentType, ede.amount from exp_detail_event ede, expense_type e where ede.exp_type_id = e.exp_type_id order by ede.dateOfExp;");

            DataTable edEvent = new DataTable();
            edEvent.Load(rdr);

            rdr.Close();
            double tot = 0;

            foreach (DataRow item1 in inTable.Rows)
            {
                DataRow row;

                row = bSheet.NewRow();
                row["In_Date"] = item1["in_date"];
                row["In_Amount"] = item1["amount"];

                double totIn = 0;

                foreach (DataRow r in inTable.Rows)
                {
                    double ans;

                    if (Double.TryParse(r[1].ToString(), out ans))
                    {
                        totIn += ans;
                    }
                }

                foreach (DataRow item2 in edEvent.Rows)
                {
                    DateTime inDate = Convert.ToDateTime(item1["in_date"].ToString());
                    DateTime outDate = Convert.ToDateTime(item2["dateOfExp"].ToString());

                    if ((inDate.Year == outDate.Year) && (inDate.Month == outDate.Month))
                    {
                        row["Out_Type"] = item2["type"];
                        row["Out_Date"] = item2["dateOfExp"];
                        row["Out_PaymentType"] = item2["paymentType"];
                        row["Out_Amount"] = item2["amount"];
                        tot += double.Parse(item2["amount"].ToString());
                        
                        double bal = totIn - tot;

                        row["Balance"] = bal;
                        
                        bSheet.Rows.Add(row);
                        row = bSheet.NewRow();
                    }
                }
            }

            exp_grid_box.DataSource = bSheet;
        }

        private void BalanceSheetForm_Load(object sender, EventArgs e)
        {
            getGridData();
            fillTiles();
        }

        private void fillTiles()
        {
            double totIn = 0.0, totOut = 0.0, curBal = 0.0;

            MySqlDataReader reader = DBConnection.getData("select IFNULL(SUM(amount), 0) from project_exp_in_amount");

            while(reader.Read())
            {
                totInTile.Text = "Rs." + reader.GetDouble(0);
                totIn = reader.GetDouble(0);
            }

            reader.Close();

            reader = DBConnection.getData("select IFNULL(SUM(amount), 0) from exp_detail_event");

            while(reader.Read())
            {
                totOutTile.Text = "Rs." + reader.GetDouble(0);
                totOut = reader.GetDouble(0);
            }

            curBal = totIn - totOut;

            curBalTile.Text = "Rs." + curBal;
        }

        private void headInTxtBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!Validation.isDouble(headInTxtBox.Text))
            {
                e.Cancel = true;

                errorMsg = "In value must be a number!";

                headInTxtBox.Select(0, headInTxtBox.Text.Length);

                this.errorProviderBalance.SetError(headInTxtBox, errorMsg);
            }
        }

        private void headInTxtBox_Validated(object sender, EventArgs e)
        {
            errorProviderBalance.SetError(headInTxtBox, "");
            errorProviderBalance.Clear();
        }
    }
}
