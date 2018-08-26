using ResoflexClientHandlingSystem.Core;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResoflexClientHandlingSystem.Role;

namespace ResoflexClientHandlingSystem
{
    public partial class RecordAttendanceForm : MetroFramework.Forms.MetroForm
    {
        public RecordAttendanceForm()
        {
            InitializeComponent();
        }

        private void metroTextBox6_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            int empNo = Int32.Parse(metroTextBox1.Text);
            string name = metroTextBox2.Text;
            string in_time = metroTextBox3.Text;
            string out_time = metroTextBox4.Text;
            int total_hours = Int32.Parse(metroTextBox6.Text);

            int att;

            Attendance a = new Attendance(empNo, name, in_time, out_time, total_hours);

            Database.addRecord(a);
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void RecordAttendance_Load(object sender, EventArgs e)
        {
            metroGrid1.DataSource = getAttendance();
        }

        private DataTable getAttendance() {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("select employee_no, name, in_time, out_time, hours_worked from attendance");
            table.Load(reader);
            return table;
        }

    }
}
