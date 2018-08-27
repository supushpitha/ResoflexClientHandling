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
    public partial class ClientReportForm : MetroFramework.Forms.MetroForm
    {
        public ClientReportForm()
        {
            InitializeComponent();
        }

        private void ClientReportForm_Load(object sender, EventArgs e)
        {
            verticalLineLbl.AutoSize = false;
            verticalLineLbl.Width = 2;
            verticalLineLbl.Height = 630;
            verticalLineLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }
    }
}
