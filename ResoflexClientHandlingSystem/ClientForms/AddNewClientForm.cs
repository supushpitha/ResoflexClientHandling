using ResoflexClientHandlingSystem.Common;
using ResoflexClientHandlingSystem.Core;
using ResoflexClientHandlingSystem.Role;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResoflexClientHandlingSystem
{
    public partial class AddNewClientForm : MetroFramework.Forms.MetroForm
    {
        public AddNewClientForm()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = clientNameTxtBox.Text;
                string address = clientAddressTxtBox.Text;
                string mobilePhone = mobilePhoneTxtBox.Text;
                string officePhone = officePhoneTxtBox.Text;
                string fax = faxTxtBox.Text;
                string email = emailTxtBox.Text;
                string[] phone = new string[2];
                phone[0] = mobilePhone;
                phone[1] = officePhone;

                Client client = new Client(name, "", address, phone, fax, email);

                Database.saveClient(client);

                notifySuccessClientAdding.Icon = SystemIcons.Application;
                notifySuccessClientAdding.BalloonTipText = "Client Successfully added!";
                notifySuccessClientAdding.ShowBalloonTip(1000);

                clearTxtBoxes();
            }
            catch (Exception)
            {
                MessageBox.Show("Every detail must be added!", "Client Adding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearTxtBoxes()
        {
            clientNameTxtBox.Text = "";
            clientAddressTxtBox.Text = "";
            mobilePhoneTxtBox.Text = "";
            officePhoneTxtBox.Text = "";
            faxTxtBox.Text = "";
            emailTxtBox.Text = "";
        }

        private void AddNewClientForm_Load(object sender, EventArgs e)
        {
            clearTxtBoxes();
        }

        private void closeForm()
        {
            this.Close();
        }

        private void clientNameTxtBox_Validating(object sender, CancelEventArgs e)
        {

        }

        private void emailTxtBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "";

            if (!Validation.isValidEmail(emailTxtBox.Text, out errorMsg))
            {
                e.Cancel = true;

                emailTxtBox.Select(0, emailTxtBox.Text.Length);

                this.addClientErrorProvider.SetError(emailTxtBox, errorMsg);
            }
        }

        private void emailTxtBox_Validated(object sender, EventArgs e)
        {
            addClientErrorProvider.SetError(emailTxtBox, "");
        }

        private void officePhoneTxtBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!Validation.isValidPhoneNumber(officePhoneTxtBox.Text, out errorMsg))
            {
                e.Cancel = true;

                officePhoneTxtBox.Select(0, officePhoneTxtBox.Text.Length);

                this.addClientErrorProvider.SetError(officePhoneTxtBox, errorMsg);
            }
        }

        private void officePhoneTxtBox_Validated(object sender, EventArgs e)
        {
            addClientErrorProvider.SetError(officePhoneTxtBox, "");
        }

        private void mobilePhoneTxtBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!Validation.isValidPhoneNumber(mobilePhoneTxtBox.Text, out errorMsg))
            {
                e.Cancel = true;

                mobilePhoneTxtBox.Select(0, mobilePhoneTxtBox.Text.Length);

                this.addClientErrorProvider.SetError(mobilePhoneTxtBox, errorMsg);
            }
        }

        private void mobilePhoneTxtBox_Validated(object sender, EventArgs e)
        {
            addClientErrorProvider.SetError(mobilePhoneTxtBox, "");
        }
    }
}
