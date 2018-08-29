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
            try
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
                Notification.showNotification();
                clearFunctionForAttendance();

            }
            catch (Exception ex) {
                MessageBox.Show("Something went wrong!\n" + ex, "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            staffDataGrid.DataSource = getStaff();
            todaysAttendanceDataGrid.DataSource = getAttendance();
            pastAttendanceDataGrid.DataSource = getAttendance();
            metroTile2.Enabled = false;

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
            MySqlDataReader reader = DBConnection.getData("SELECT * FROM attendanceView WHERE DATE(InTime) = '"+ sqlFormattedDate + "'");
            table.Load(reader);
            return table;
        }

        private DataTable getStaff()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("SELECT * FROM staffViewForAttendance");
            table.Load(reader);
            return table;
        }

        private DataTable searchEmployees()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("SELECT * FROM staffViewForAttendance WHERE FirstName LIKE '%" + searchEmployeeTxtbox.Text + "%' OR LastName LIKE '%" + searchEmployeeTxtbox.Text + "%' OR  StaffID LIKE '%" + searchEmployeeTxtbox.Text + "%'");
            table.Load(reader);
            return table;

        }

        private DataTable searchTodaysAttendance()
        {
            DateTime today = DateTime.Now;
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("SELECT * FROM attendanceView WHERE FirstName LIKE '%" + checkPresenceTxtbox.Text + "%' OR LastName LIKE '%" + checkPresenceTxtbox.Text + "%' OR  StaffID LIKE '%" + checkPresenceTxtbox.Text + "%' and InTime = '"+ today.ToString("yyyy/M/d") +"'");
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
            try
            {
                //-------------------Grey out code------------------------------------------
               // staffDataGrid.Enabled = false;
                metroTile2.Enabled = true;
                metroTile1.Enabled = false;
                dateTimePicker1.Enabled = true;
                metroDateTime2.Enabled = true;
                //---------------------------------End of grey out code-----------------------
                employeeNumberTxtbox.Text = todaysAttendanceDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                firstNameTxtbox.Text = todaysAttendanceDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                lastNameTxtbox.Text = todaysAttendanceDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                metroDateTime2.Text = todaysAttendanceDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                dateTimePicker1.Text = todaysAttendanceDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                metroDateTime3.Text = todaysAttendanceDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                dateTimePicker2.Text = todaysAttendanceDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                totalHoursTxtbox.Text = todaysAttendanceDataGrid.Rows[e.RowIndex].Cells[5].Value.ToString();

                employeeNumberTxtbox.Enabled = false;
                firstNameTxtbox.Enabled = false;
                lastNameTxtbox.Enabled = false;

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
            staffDataGrid.DataSource = searchEmployees();
        }

        private void metroGrid2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            metroTile2.Enabled = false;
            metroTile1.Enabled = true;
            dateTimePicker1.Enabled = true;
            metroDateTime2.Enabled = true;
            employeeNumberTxtbox.Text = staffDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            firstNameTxtbox.Text = staffDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            lastNameTxtbox.Text = staffDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
           
     
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            try
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
                Notification.showNotification();
                metroTile1.Enabled = true;
                metroTile2.Enabled = false;
                clearFunctionForAttendance();
            }
            catch (Exception ex) {

                MessageBox.Show("Something went wrong!\n" + ex, "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = metroDateTime1.Value;
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("SELECT * FROM attendanceview WHERE DATE(OutTime) = '"+selectedDate.ToString("yyyy/M/d")+"' ");
            table.Load(reader);

            pastAttendanceDataGrid.DataSource = table;
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            employeeNumberTxtbox.Enabled = true;
            firstNameTxtbox.Enabled = true;
            lastNameTxtbox.Enabled = true;

            employeeNumberTxtbox.Text = null;
            firstNameTxtbox.Text = null;
            lastNameTxtbox.Text = null;

            DateTime dtValue = DateTime.Now;  // load your date & time into this variable
            metroDateTime2.Text = dtValue.ToString("yyyy-MM-dd");
            dateTimePicker1.Text = dtValue.ToString("HH:mm:ss");
            metroDateTime3.Text = dtValue.ToString("yyyy-MM-dd");
            dateTimePicker2.Text = dtValue.ToString("HH:mm:ss");
            totalHoursTxtbox.Text = null;

            metroDateTime2.Enabled = true;
            dateTimePicker1.Enabled = true;

            staffDataGrid.Enabled = true;

            metroTile2.Enabled = false;
            metroTile1.Enabled = true;
            staffDataGrid.Enabled = true;
            
        }

        private void pastAttendanceDataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                //-------------------Grey out code------------------------------------------
              //  staffDataGrid.Enabled = false;
                metroTile2.Enabled = true;
                metroTile1.Enabled = false;
                //---------------------------------End of grey out code-----------------------
                employeeNumberTxtbox.Text = pastAttendanceDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                firstNameTxtbox.Text = pastAttendanceDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                lastNameTxtbox.Text = pastAttendanceDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                metroDateTime2.Text = pastAttendanceDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                dateTimePicker1.Text = pastAttendanceDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                metroDateTime3.Text = pastAttendanceDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                dateTimePicker2.Text = pastAttendanceDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                totalHoursTxtbox.Text = pastAttendanceDataGrid.Rows[e.RowIndex].Cells[5].Value.ToString();

                employeeNumberTxtbox.Enabled = false;
                firstNameTxtbox.Enabled = false;
                lastNameTxtbox.Enabled = false;
                metroDateTime2.Enabled = false;
                dateTimePicker1.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!\n" + ex, "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void checkPresenceTxtbox_TextChanged(object sender, EventArgs e)
        {
            todaysAttendanceDataGrid.DataSource = searchTodaysAttendance();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            todaysAttendanceDataGrid.DataSource = getAttendance();
            
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {

        }

        public void clearFunctionForAttendance() {

            employeeNumberTxtbox.Enabled = true;
            firstNameTxtbox.Enabled = true;
            lastNameTxtbox.Enabled = true;

            employeeNumberTxtbox.Text = null;
            firstNameTxtbox.Text = null;
            lastNameTxtbox.Text = null;

            DateTime dtValue = DateTime.Now;  // load your date & time into this variable
            metroDateTime2.Text = dtValue.ToString("yyyy-MM-dd");
            dateTimePicker1.Text = dtValue.ToString("HH:mm:ss");
            metroDateTime3.Text = dtValue.ToString("yyyy-MM-dd");
            dateTimePicker2.Text = dtValue.ToString("HH:mm:ss");
            totalHoursTxtbox.Text = null;

            metroDateTime2.Enabled = true;
            dateTimePicker1.Enabled = true;

            staffDataGrid.Enabled = true;

            metroTile2.Enabled = false;
            metroTile1.Enabled = true;
            staffDataGrid.Enabled = true;

        }
    }
}
