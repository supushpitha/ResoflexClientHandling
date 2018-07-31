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
    public partial class ScheduleForm : MetroFramework.Forms.MetroForm
    {
        public ScheduleForm()
        {
            InitializeComponent();
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {

        }

        private void deleteSchedule_Click(object sender, EventArgs e)
        {

        }

        private void updateSchedule_Click(object sender, EventArgs e)
        {
            AddScheduleForm asf = new AddScheduleForm();

        }

        private void addSchedule_Click(object sender, EventArgs e)
        {
            AddScheduleForm asf = new AddScheduleForm();
            asf.ShowDialog();
        }

        private void schHome_Click(object sender, EventArgs e)
        {
            ProjectManager pm = new ProjectManager();
            this.Close();
            pm.Show();
        }
    }
}
