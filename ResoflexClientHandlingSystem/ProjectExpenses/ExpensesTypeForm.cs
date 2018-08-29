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
    public partial class ExpensesTypeForm : MetroFramework.Forms.MetroForm
    {
        public ExpensesTypeForm()
        {
            InitializeComponent();
        }

        private void ExpensesTypeForm_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            CashIssuingForm c = new CashIssuingForm();

            c.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            BalanceSheetForm b = new BalanceSheetForm();

            b.Show();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            EventDetailsForm ee= new EventDetailsForm();

            ee.Show();
        }
    }
}
