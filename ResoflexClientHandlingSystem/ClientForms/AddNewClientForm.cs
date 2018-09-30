using MySql.Data.MySqlClient;
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
        private string clientname;
        private string address;
        private string phone_mob;
        private string phone_office;
        private string fax;
        private string email;

        public AddNewClientForm()
        {
            InitializeComponent();
        }

        public AddNewClientForm(string name, string address, string phone_mob, string phone_office, string fax, string email)
        {
            this.clientname = name;
            this.address = address;
            this.phone_mob = phone_mob;
            this.phone_office = phone_office;
            this.fax = fax;
            this.email = email;

            clientNameTxtBox.ReadOnly = true;
            clientNameTxtBox.Text = clientname;

            clientAddressTxtBox.ReadOnly = true;
            clientAddressTxtBox.Text = address;

            mobilePhoneTxtBox.ReadOnly = true;
            mobilePhoneTxtBox.Text = phone_mob;

            officePhoneTxtBox.ReadOnly = true;
            officePhoneTxtBox.Text = phone_office;

            faxTxtBox.ReadOnly = true;
            faxTxtBox.Text = fax;

            emailTxtBox.ReadOnly = true;
            emailTxtBox.Text = email;

            addNewClientBtn.Visible = false;
            addNewClientCancelBtn.Visible = false;
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
                notifySuccessClientAdding.ShowBalloonTip(200);
                
                clearTxtBoxes();

                int id = 0;

                try
                {
                    MySqlDataReader reader = DBConnection.getData("SELECT client_id FROM client where email ='" + email + "';");
                    
                    while (reader.Read())
                    {
                        id = int.Parse(reader["client_id"].ToString());

                    }

                    reader.Close();

                    UserOperation operation = new UserOperation(new Role.UserLog(Logglobals.id), "Added a new Client", id);
                    Database.addOp(operation);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);   
                }
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
            addClientErrorProvider.Clear();
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
            addClientErrorProvider.Clear();
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
            addClientErrorProvider.Clear();
        }

        private void AddNewClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        private void addNewClientCancelBtn_Click(object sender, EventArgs e)
        {/*
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;

            this.ValidateChildren();
            
            /*
            CausesValidation = false;

            while (Controls.Count > 0)
            {
                Controls[0].Dispose();
            }
            */
            this.Close();
        }

        private void clientNameTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                clientAddressTxtBox.Focus();
            }
        }

        private void clientAddressTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                mobilePhoneTxtBox.Focus();
            }
        }

        private void mobilePhoneTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                officePhoneTxtBox.Focus();
            }
        }

        private void officePhoneTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                faxTxtBox.Focus();
            }
        }

        private void faxTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                emailTxtBox.Focus();
            }
        }

        private void emailTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clientNameTxtBox.Focus();
                addNewClientBtn.PerformClick();
            }
        }

        private void demoBtn_Click(object sender, EventArgs e)
        {
            clientNameTxtBox.Text = "Seetha Traders";
            clientAddressTxtBox.Text = "Kandy";
            mobilePhoneTxtBox.Text = "0781551232";
            officePhoneTxtBox.Text = "0812222222";
            faxTxtBox.Text = "0812222222";
            emailTxtBox.Text = "seetha@gmail.com";
        }
    }
}
