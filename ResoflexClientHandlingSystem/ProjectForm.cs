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
    public partial class ProjectForm : MetroFramework.Forms.MetroForm
    {
        int clientId;

        public ProjectForm()
        {
            InitializeComponent();
        }

        public ProjectForm(int clientId)
        {
            this.clientId = clientId;
            InitializeComponent();
        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {
            metroTextBox1.Text = "" + clientId;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
