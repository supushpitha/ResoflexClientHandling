using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;
using ResoflexClientHandlingSystem.OfficeExpensesForm;
using ResoflexClientHandlingSystem.Role;
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
    public partial class OfficeReportForm : MetroFramework.Forms.MetroForm
    {
        public OfficeReportForm()
        {
            InitializeComponent();
        }

        private void officeReportForm_Load(object sender, EventArgs e)
        {


            grid.DataSource = getSalary();
        }

        private DataTable getSalary()
        {
            MySqlDataReader reader = DBConnection.getData("select type, off_exp_id,Category,Amount from office_expenses");


            DataTable table = new DataTable();

            table.Load(reader);

            return table;
        }



        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}