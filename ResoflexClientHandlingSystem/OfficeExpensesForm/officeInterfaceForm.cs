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
    public partial class addexpenses : MetroFramework.Forms.MetroForm
    {
        public addexpenses()
        {
            InitializeComponent();
        }

        private void addexpenses_Load(object sender, EventArgs e)
        {

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
