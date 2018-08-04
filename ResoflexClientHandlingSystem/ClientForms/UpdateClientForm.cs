using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using ResoflexClientHandlingSystem.Core;
using ResoflexClientHandlingSystem.Role;

namespace ResoflexClientHandlingSystem
{
    public partial class UpdateClientForm : MetroFramework.Forms.MetroForm
    {
        int clientId;
        string name;
        string address;
        string mobile;
        string office;
        string fax;
        string email;

        public UpdateClientForm(int clientId, string name, string address, string mobile, string office, string fax, string email)
        {
            this.clientId = clientId;
            this.name = name;
            this.address = address;
            this.mobile = mobile;
            this.office = office;
            this.fax = fax;
            this.email = email;

            InitializeComponent();
        }

        public UpdateClientForm()
        {
            InitializeComponent();
        }

        private void UpdateClientForm_Load(object sender, EventArgs e)
        {
            clientNameTxtBox.Text = name;
            clientAddressTxtBox.Text = address;
            mobilePhoneTxtBox.Text = mobile;
            officePhoneTxtBox.Text = office;
            faxTxtBox.Text = fax;
            emailTxtBox.Text = email;
        }

        private void updateClientBtn_Click(object sender, EventArgs e)
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

                Client client = new Client(clientId, name, "", address, phone, fax, email);

                Database.updateClient(client);

                notifySuccessClientUpdating.Icon = SystemIcons.Application;
                notifySuccessClientUpdating.BalloonTipText = "Client Successfully updated!";
                notifySuccessClientUpdating.ShowBalloonTip(1000);

                closeForm();
            }
            catch (Exception)
            {
                MessageBox.Show("Every detail must be there!", "Client Updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeForm()
        {
            this.Close();
        }
    }
}
