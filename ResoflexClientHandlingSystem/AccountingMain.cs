using ResoflexClientHandlingSystem.Role;
using ResoflexClientHandlingSystem.UserForms;
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
    public partial class AccountingMain : MetroFramework.Forms.MetroForm
    {
        public AccountingMain()
        {
            InitializeComponent();
        }

        private void AccountingMain_Load(object sender, EventArgs e)
        {
            if (Userglobals.uname == "")
            {
                profilebtn.Visible = false;

            }
            else
            {
                profilebtn.Visible = true;
                profilebtn.Text = Userglobals.uname;

            }
        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            ProfileForm prffrm = new ProfileForm();
            this.Hide();
            prffrm.ShowDialog();
            this.Close();
        }

        private void Project_Click(object sender, EventArgs e)
        {
            ExpensesTypeForm frm = new ExpensesTypeForm();

            frm.Show();
        }
    }
}
