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
            int empNo = Int32.Parse(employeeNumberTxtbox.Text);
            string name = firstNameTxtbox.Text;
            DateTime in_Day = DateTime.Parse(metroDateTime2.Text);
            DateTime in_time = DateTime.Parse(dateTimePicker1.Text);
            DateTime out_Day = DateTime.Parse(metroDateTime3.Text);
            DateTime out_time = DateTime.Parse(dateTimePicker2.Text);
            // DateTime in_time = DateTime.Parse(metroDateTime3.Text);
            // DateTime out_time = DateTime.Parse(metroDateTime4.Text);
            int total_hours = Int32.Parse(totalHoursTxtbox.Text);

            // DateTime myDateTime = DateTime.Now;
            DateTime inDateFinal = in_Day.Date + in_time.TimeOfDay;
            DateTime outDateFinal = out_Day.Date + out_time.TimeOfDay;

            string sqlFormattedDateValueStart = inDateFinal.ToString("yyyy-MM-dd HH:mm:ss");
            string sqlFormattedDateValueEnd = outDateFinal.ToString("yyyy-MM-dd HH:mm:ss");


            // string sqlFormattedDateInDay = in_Day.ToString("yyyy-MM-dd");

            //   string sqlFormattedDateOutTime = out_time.ToString("HH:mm:ss.fff");
            //  string sqlFormattedDateOutDay = out_Day.ToString("yyyy-MM-dd");


            int att;

            Attendance a = new Attendance(empNo, name, sqlFormattedDateValueStart, sqlFormattedDateValueEnd, total_hours);

            // MySqlDataReader reader1021 = DBConnection.getData("select * from attendanceview where DATE(in_time) = '" + in_Day+ "%' and staff_id = '" + empNo + "'");
            
            
           // if (reader1021.HasRows == false) {
              
           // MessageBox.Show("There is another record with the same date!", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
           //  reader1021.Close();
          //  }



           Database.addRecord(a);
          //  reader1021.Close();
            //MySqlDataReader reader = DBConnection.getData("select a.staff_id, s.first_name, s.last_name, a.in_time, a.out_time, a.total_hours from attendance as a inner join staff as s on a.staff_id = s.staff_id");
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void RecordAttendance_Load(object sender, EventArgs e)
        {
            metroGrid2.DataSource = getStaff();
            metroGrid1.DataSource = getAttendance();
            
           
        }

        private DataTable getAttendance() {
            DataTable table = new DataTable();
            //MySqlDataReader reader = DBConnection.getData("select a.staff_id, s.first_name, s.last_name, a.in_time, a.out_time, a.total_hours from attendance as a inner join staff as s on a.staff_id = s.staff_id");
            //DateTime now = DateTime.Now;
            //string today = now.GetDateTimeFormats('d')[0];
            //DateTime today1 = DateTime.Parse(today);
            //DateTime today3 = metroDateTime1.Value;
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd");
            MySqlDataReader reader = DBConnection.getData("SELECT * FROM attendanceview WHERE DATE(in_time) = '"+ sqlFormattedDate + "'");
            table.Load(reader);
            return table;
        }

        private DataTable getStaff()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("SELECT * FROM staff");
            table.Load(reader);
            return table;
        }

        private DataTable searchEmployees()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("SELECT * FROM staff WHERE first_name LIKE '%" + metroTextBox3.Text + "%' OR last_name LIKE '%" + metroTextBox3.Text + "%' OR  staff_id LIKE '%" + metroTextBox3.Text + "%'");
            table.Load(reader);
            return table;

        }


        

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
          //  metroGrid1.DataSource = searchEmployees();
        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
          //  metroGrid1.DataSource = searchEmployees();
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox7_TextChanged(object sender, EventArgs e)
        {
         //   metroGrid1.DataSource = searchEmployees();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroGrid1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            // DataGridViewRow 
            //try{

            //    foreach (DataGridViewRow dr in metroGrid1.SelectedRows) {
            //        //this.Hide();
            //        metroTextBox1.Text = dr.Cells[0].Value.ToString();
            //        metroTextBox2.Text = dr.Cells[1].Value.ToString();
            //        metroTextBox7.Text = dr.Cells[2].Value.ToString();
            //        metroDateTime2.Text = dr.Cells[3].Value.ToString();
            //        dateTimePicker1.Text = dr.Cells[3].Value.ToString();
            //        metroDateTime3.Text = dr.Cells[4].Value.ToString();
            //        dateTimePicker2.Text = dr.Cells[4].Value.ToString();
            //        metroTextBox6.Text = dr.Cells[5].Value.ToString();
            //    }
            //}catch(Exception) {
            //   MessageBox.Show("Something went wrong!", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //-------------------------------------------------------------------------------------------------
            try
            {
                employeeNumberTxtbox.Text = metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
                firstNameTxtbox.Text = metroGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
                totalHoursTxtbox.Text = metroGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
                metroDateTime2.Text = metroGrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
                dateTimePicker1.Text = metroGrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
                metroDateTime3.Text = metroGrid1.Rows[e.RowIndex].Cells[4].Value.ToString();
                dateTimePicker2.Text = metroGrid1.Rows[e.RowIndex].Cells[4].Value.ToString();
                lastNameTxtbox.Text = metroGrid1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception ex) {
                MessageBox.Show("Something went wrong!\n" + ex, "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


          



        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTextBox3_TextChanged(object sender, EventArgs e)
        {
            metroGrid2.DataSource = searchEmployees();
        }

        private void metroGrid2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            employeeNumberTxtbox.Text = metroGrid2.Rows[e.RowIndex].Cells[0].Value.ToString();
            firstNameTxtbox.Text = metroGrid2.Rows[e.RowIndex].Cells[1].Value.ToString();
            lastNameTxtbox.Text = metroGrid2.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            int empNo = Int32.Parse(employeeNumberTxtbox.Text);
            string name = firstNameTxtbox.Text;
            DateTime in_Day = DateTime.Parse(metroDateTime2.Text);
            DateTime in_time = DateTime.Parse(dateTimePicker1.Text);
            DateTime out_Day = DateTime.Parse(metroDateTime3.Text);
            DateTime out_time = DateTime.Parse(dateTimePicker2.Text);
       
            int total_hours = Int32.Parse(totalHoursTxtbox.Text);

            DateTime inDateFinal = in_Day.Date + in_time.TimeOfDay;
            DateTime outDateFinal = out_Day.Date + out_time.TimeOfDay;

            string sqlFormattedDateValueStart = inDateFinal.ToString("yyyy-MM-dd HH:mm:ss");
            string sqlFormattedDateValueEnd = outDateFinal.ToString("yyyy-MM-dd HH:mm:ss");


            int att;

            Attendance a = new Attendance(empNo, name, sqlFormattedDateValueStart, sqlFormattedDateValueEnd, total_hours);
            Database.updateRecord(a);
        }
    }
}
