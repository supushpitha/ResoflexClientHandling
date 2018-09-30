using ResoflexClientHandlingSystem.TaskForms;
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
    public partial class ProjectManager : MetroFramework.Forms.MetroForm
    {
        public ProjectManager()
        {
            InitializeComponent();

        }

        private void ProjectManager_Load(object sender, EventArgs e)
        {

        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            ProjectForm frm = new ProjectForm();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            ScheduleForm sf = new ScheduleForm();
            this.Hide();
            sf.ShowDialog();
            this.Close();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            EventForm ef = new EventForm();
            this.Hide();
            ef.ShowDialog();
            this.Close();
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            TaskForm tf = new TaskForm();
            this.Hide();
            tf.ShowDialog();
            this.Close();
        }

        private void schHome_Click(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
