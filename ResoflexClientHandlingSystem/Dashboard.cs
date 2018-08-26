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
    public partial class Dashboard : MetroFramework.Forms.MetroForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            dateTimeLbl.Text = DateTime.Now.ToString("MMMM dd, yyyy");

            setAttendance();
            Console.Write(Eramake.eCryptography.Encrypt("123"));
        }

        private void setAttendance()
        {
            metroLabel2.Text = "12";
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Project1 frm = new Project1();

            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            ClientForm frm = new ClientForm();

            frm.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            ProjectManager pm = new ProjectManager();

            pm.Show();
        }

        private void metroButton3_Click_1(object sender, EventArgs e)
        {
            OfficeExpensesForm frm = new OfficeExpensesForm();

            frm.Show();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            UserLog frm = new UserLog();

            frm.Show();
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            StaffEvalutionForm sEf = new StaffEvalutionForm();
            sEf.Show();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
