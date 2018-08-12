using ResoflexClientHandlingSystem.Core;
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

namespace ResoflexClientHandlingSystem
{
    public partial class CashIssuingForm : MetroFramework.Forms.MetroForm
    {
        public CashIssuingForm()
        {
            InitializeComponent();
        }

        private void CashIssuingForm_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string iouId = iouIdTxtBox.Text;
            string scheduleId = scheduleIdTxtBox.Text;
            string staffId = staffIdTxtBox.Text;
            string projectId = projectIdTxtBox.Text;
            string amount = amountTxtBox.Text;


         }
    }
}
