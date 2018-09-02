using System;
using ResoflexClientHandlingSystem.Role;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResoflexClientHandlingSystem.Core;
namespace ResoflexClientHandlingSystem.OfficeExpensesForm
{
    public partial class IouBalanceForm : MetroFramework.Forms.MetroForm
    {
        DataTable bsheet = new DataTable();


        public IouBalanceForm()
        {
            InitializeComponent();


            bsheet.Columns.Add("In_Date", typeof(DateTime));
            bsheet.Columns.Add("In_amount", typeof(double));
            bsheet.Columns.Add("Out_Type", typeof(String));
            bsheet.Columns.Add("Out_Date", typeof(DateTime));
            bsheet.Columns.Add("Out_amount", typeof(double));

        }

        private void IouBalanceForm_Load(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int iouId=int.Parse()

            MySqlDataReader reader = DBConnection.getData("select in_date ,amount from office_exp_in_amount");

            DataTable inTable = new DataTable();
            inTable.Load(reader);
            reader.Close();

            MySqlDataReader rdr = DBConnection.getData("select type,off_exp_id,date,Category,amount from office_expenses");
            DataTable ed = new DataTable();
            ed.Load(rdr);

            rdr.Close();



            foreach(DataRow item1 in inTable.Rows)
            {
                DataRow row;

                row = bsheet.NewRow();
                row["In_Date"] = item1["in_date"];
                row["In_Amount"] = item1["amount"];

                foreach(DataRow item2 in ed.Rows)
                {
                    if (item1["in_date"].ToString().Equals(item2["dateOfExp"].ToString()))
                    {

                        row["Out_Date"] = item2["dateOExp"];
                        row["Ount_Amount"] = item2["amount"];

                        bsheet.Rows.Add(row);
                        row = bsheet.NewRow();
                    }

                    else
                    {
                        bsheet.Rows.Add(row);
                        row = bsheet.NewRow();
                        break;

                    }
                }

            }
            grid.DataSource = bsheet;
           

        }
    }
}
