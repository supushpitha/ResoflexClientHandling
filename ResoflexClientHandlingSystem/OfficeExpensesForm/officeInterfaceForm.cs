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

namespace ResoflexClientHandlingSystem.OfficeExpenses
{
    public partial class OfficeInterfaceForm : MetroFramework.Forms.MetroForm
    {
        public OfficeInterfaceForm()
        {
            InitializeComponent();
        }

        private void addexpenses_Load(object sender, EventArgs e)
        {
            getOfficeExpenses();
        }

        private void getOfficeExpenses()
        {
            MySqlDataReader reader = DBConnection.getData("select s.first_name, o.type, o.date, o.category, o.amount from office_expenses o " +
                "inner join staff s on o.staff_id=s.staff_id");

            DataTable table = new DataTable();

            table.Load(reader);

            metroGrid1.DataSource = table;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            IOUForm iOUForm = new IOUForm();
            iOUForm.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            CashPaymentForm cash= new CashPaymentForm();
            cash.Show();
        }
    }
}
