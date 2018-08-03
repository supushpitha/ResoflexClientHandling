using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResoflexClientHandlingSystem.Common
{
    class Internet
    {
        private static string email = "techninjas3.0v@gmail.com";
        private static string pw = "Techninjas@SLIIT";
        private string ip;
        private string hostName;

        public static bool sendMail(string to, string subject, string body)
        {
            try
            {
                var fromAddress = new MailAddress(email);
                var fromPassword = pw;
                var toAddress = new MailAddress(to);
                
                SmtpClient smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })

                    smtp.Send(message);
                /*
                notifyIconMailSuccessful.Icon = SystemIcons.Application;
                notifyIconMailSuccessful.BalloonTipText = "Email sent successfully!";
                notifyIconMailSuccessful.ShowBalloonTip(1000);
                */
                //msgTxtBox.Text = "";
                /*
                if (checkBoxTV.Checked)
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();

                    process.StartInfo.FileName = "C:\\Program Files (x86)\\TeamViewer\\TeamViewer.exe";
                    process.EnableRaisingEvents = true;

                    process.Start();

                    process.WaitForExit();

                    msgTxtBox.Text = "TeamViewer Exited";
                }*/

                return true;
            }
            catch (Exception exc)
            {
                return false;
            }
        }

        public static bool pingHost(string nameOrAddress)
        {
            bool pingable = false;
            Ping pinger = null;

            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(nameOrAddress);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                // Discard PingExceptions and return false;
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }

            return pingable;
        }
    }
}
