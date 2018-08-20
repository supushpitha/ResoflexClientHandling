using ResoflexClientHandlingSystem.Core;
using ResoflexClientHandlingSystem.Role;
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
    public partial class JobPerformanceAddEntryForm : MetroFramework.Forms.MetroForm
    {
        public JobPerformanceAddEntryForm()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            int date = Int32.Parse(metroTextBox1.Text);
            int emp_no = Int32.Parse(metroTextBox2.Text);
            int knowledge = Int32.Parse(metroTextBox3.Text);
            int saftey = Int32.Parse(metroTextBox4.Text);
            int quality = Int32.Parse(metroTextBox5.Text);
            int adaptability = Int32.Parse(metroTextBox6.Text);
            int productivity = Int32.Parse(metroTextBox7.Text);
            int initiative = Int32.Parse(metroTextBox8.Text);
            int total = Int32.Parse(metroTextBox9.Text);

            int jobPerformanceNo = 0;
           

            JobPerformance JPObj = new JobPerformance(jobPerformanceNo,emp_no,date,knowledge,saftey,quality,adaptability,productivity,initiative,total);

            Database.addJobPerformance(JPObj);
        }
    }
}
