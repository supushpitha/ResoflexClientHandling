using ResoflexClientHandlingSystem.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResoflexClientHandlingSystem.UserForms
{
    public partial class ForgotPassword : MetroFramework.Forms.MetroForm { 
        
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void email_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!Validation.isValidEmail(email.Text, out errorMsg))
            {
                e.Cancel = true;

                email.Select(0, email.Text.Length);

                this.emailerrorprovider.SetError(email, errorMsg);
            }
        }

        private void email_Validated(object sender, EventArgs e)
        {
            emailerrorprovider.SetError(email, "");
            emailerrorprovider.Clear();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
