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
    public partial class UserLog : MetroFramework.Forms.MetroForm
    {
        public UserLog()
        {
            InitializeComponent();
        }

        private void UserLog_Load(object sender, EventArgs e)
        {

        }

        private void addUsers_Click(object sender, EventArgs e)
        {
            UserAddForm uaf = new UserAddForm();
            uaf.Show();
        }
    }
}
