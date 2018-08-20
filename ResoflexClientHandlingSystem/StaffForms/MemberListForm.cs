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
    public partial class MemberListForm : MetroFramework.Forms.MetroForm
    {
        public MemberListForm()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            StaffForm frm = new StaffForm();
            //staff.Owner = this;
            frm.Show();
        }
    }
}
