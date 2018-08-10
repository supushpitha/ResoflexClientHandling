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

namespace ResoflexClientHandlingSystem.ClientForms
{
    public partial class EmailClientForm : MetroFramework.Forms.MetroForm
    {
        private string email;

        public EmailClientForm(string email)
        {
            this.email = email;

            InitializeComponent();
        }

        private void EmailClientForm_Load(object sender, EventArgs e)
        {
            emailTxtBox.Text = email;
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            string subject = mailSubjectTxtBox.Text;
            string message = messageTxtBox.Text;
            
            try
            {
                bool isSuccess = Internet.sendMail(email, subject, message);

                if (isSuccess)
                {
                    notifySendSuccess.Icon = SystemIcons.Application;
                    notifySendSuccess.BalloonTipText = "Email sent successfully!";
                    notifySendSuccess.ShowBalloonTip(1000);

                    this.closeForm();
                }
                else
                {
                    MessageBox.Show("Something went wrong!\nPlease check your internet connetion and email address", "Mail Sender", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!\nPlease check your internet connetion and email address", "Mail Sender", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeForm()
        {
            this.Close();
        }
    }
}
