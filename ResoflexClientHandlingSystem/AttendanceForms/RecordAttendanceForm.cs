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

        int staffId = 0;
        DateTime checkOutDate;
        DateTime checkInDate;
        double validateHours = 0;

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
                int total_hours = Int32.Parse(EffectiveHoursTxtbox.Text);
                
                DateTime inDateFinal = in_Day.Date + in_time.TimeOfDay;
                DateTime outDateFinal = out_Day.Date + out_time.TimeOfDay;

                string sqlFormattedDateValueStart = inDateFinal.ToString("yyyy-MM-dd HH:mm:ss");
                string sqlFormattedDateValueEnd = outDateFinal.ToString("yyyy-MM-dd HH:mm:ss");

                // outDateFinal = DateTime.Now.AddDays(-1);

                //if (checkOutDate < inDateFinal && checkInDate > outDateFinal)
                // {             
                MySqlDataReader reader = DBConnection.getData("select * from attendanceView where staffID = " + empNo + " and Date(InTime) = '"+ DateTime.Now.ToString("y/M/d") +"'");
                if (reader.HasRows)
                {
                    reader.Close();
                    MessageBox.Show("There is a record for specified Date and Id.Try an Update", "Record Attendance", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    
                }
                else {
                    reader.Close();
                    Attendance a = new Attendance(empNo, name, sqlFormattedDateValueStart, sqlFormattedDateValueEnd, total_hours);

                    Database.addRecord(a);
                    Notification.showNotification();
                    clearFunctionForAttendance();
                }
                
                //  }
            }
            catch (Exception ex) {
                
                MessageBox.Show("Something went wrong!\n" + ex, "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }
        
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

            metroDateTime3.Value = DateTime.Now.AddDays(1);
            metroTextBox2.Enabled = false;
            TotalHoursTxtBox.Enabled = false;
            
        }

        private DataTable getAttendance() {
            DataTable table = new DataTable();
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
            double value = 0;
            try
            {
                value = Convert.ToInt32(EffectiveHoursTxtbox.Text);
                
            }
            catch
            {

            }
            if (value >= validateHours)
            {
                MessageBox.Show("Please enter a lower value than total hours", "Record Attendance", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EffectiveHoursTxtbox.Text = null;
                metroTextBox2.Text = null;
            }
            else
            {

                metroTextBox2.Text = (validateHours - value).ToString();
            }
        }

       

        private void metroGrid1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                
                metroTile2.Enabled = true;
                metroTile1.Enabled = false;
                dateTimePicker1.Enabled = true;
                metroDateTime2.Enabled = true;
             
                employeeNumberTxtbox.Text = todaysAttendanceDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                firstNameTxtbox.Text = todaysAttendanceDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                lastNameTxtbox.Text = todaysAttendanceDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                metroDateTime2.Text = todaysAttendanceDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                dateTimePicker1.Text = todaysAttendanceDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                metroDateTime3.Text = todaysAttendanceDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                dateTimePicker2.Text = todaysAttendanceDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                EffectiveHoursTxtbox.Text = todaysAttendanceDataGrid.Rows[e.RowIndex].Cells[5].Value.ToString();

                employeeNumberTxtbox.Enabled = false;
                firstNameTxtbox.Enabled = false;
                lastNameTxtbox.Enabled = false;
                staffId = Int32.Parse(todaysAttendanceDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
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

            staffId = Int32.Parse(staffDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
     
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

                int total_hours = Int32.Parse(EffectiveHoursTxtbox.Text);

                DateTime inDateFinal = in_Day.Date + in_time.TimeOfDay;
                DateTime outDateFinal = out_Day.Date + out_time.TimeOfDay;

                string sqlFormattedDateValueStart = inDateFinal.ToString("yyyy-MM-dd HH:mm:ss");
                string sqlFormattedDateValueEnd = outDateFinal.ToString("yyyy-MM-dd HH:mm:ss");



                if ((checkOutDate < inDateFinal && checkInDate > outDateFinal) || (inDateFinal.Date == DateTime.Now.Date))
                {
                    Attendance a = new Attendance(empNo, name, sqlFormattedDateValueStart, sqlFormattedDateValueEnd, total_hours);
                    Database.updateRecord(a);
                    Notification.showNotification();
                    metroTile1.Enabled = true;
                    metroTile2.Enabled = false;
                    clearFunctionForAttendance();
                }
                else {

                    MessageBox.Show("Conflicting dates!", "Record attendance", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    

                    metroDateTime3.Value = DateTime.Now.AddDays(1);
                    metroDateTime2.Value = DateTime.Now;
                }
            
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
            EffectiveHoursTxtbox.Text = null;

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
               
                metroTile2.Enabled = true;
                metroTile1.Enabled = false;
                employeeNumberTxtbox.Text = pastAttendanceDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                firstNameTxtbox.Text = pastAttendanceDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                lastNameTxtbox.Text = pastAttendanceDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                metroDateTime2.Text = pastAttendanceDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                dateTimePicker1.Text = pastAttendanceDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                metroDateTime3.Text = pastAttendanceDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                dateTimePicker2.Text = pastAttendanceDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                EffectiveHoursTxtbox.Text = pastAttendanceDataGrid.Rows[e.RowIndex].Cells[5].Value.ToString();

                string empNo = pastAttendanceDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                string date2 = pastAttendanceDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                string time1 = pastAttendanceDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                string date3 = pastAttendanceDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                string time2 = pastAttendanceDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();

                staffId = Int32.Parse(empNo);

                

                string inDateFinal = Convert.ToDateTime(date2).ToString("y/M/d");
                string outDateFinal = Convert.ToDateTime(date3).ToString("y/M/d");

                employeeNumberTxtbox.Enabled = false;
                firstNameTxtbox.Enabled = false;
                lastNameTxtbox.Enabled = false;
               
                 checkOutDate = DateTime.Now;
                 checkInDate = DateTime.Now;
                
                MySqlDataReader reader = DBConnection.getData("select * from attendanceView where staffID = " + empNo + " and OutTime < '" + inDateFinal + "' order by OutTime desc limit 1");
                while (reader.Read())
                {
                    checkOutDate = reader.GetDateTime("OutTime");
                    
                }
                reader.Close();
                
                MySqlDataReader reader1 = DBConnection.getData("select * from attendanceView where staffID = " + empNo + " and InTime > '" + outDateFinal + "' order by InTime asc limit 1");
                while (reader1.Read())
                {
                    checkInDate = reader1.GetDateTime("InTime");
                   
                }
                reader1.Close();
                
               

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
            metroTextBox2.Text = null;
           
            DateTime dtValue = DateTime.Now;  // load your date & time into this variable
            DateTime dtValue1 = DateTime.Now.AddDays(1);
            metroDateTime3.Text = dtValue1.ToString("yyyy-MM-dd");
            dateTimePicker2.Text = dtValue1.ToString("HH:mm:ss");
            metroDateTime2.Text = dtValue.ToString("yyyy-MM-dd");
            dateTimePicker1.Text = dtValue.ToString("HH:mm:ss");
            EffectiveHoursTxtbox.Text = null;

            metroDateTime2.Enabled = true;
            dateTimePicker1.Enabled = true;

            staffDataGrid.Enabled = true;

            metroTile2.Enabled = false;
            metroTile1.Enabled = true;
            staffDataGrid.Enabled = true;

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
            this.Close();
        }

        private void metroDateTime2_ValueChanged(object sender, EventArgs e)
        {
           
            DateTime inDate = DateTime.Parse(metroDateTime2.Text).Date + DateTime.Parse(dateTimePicker1.Text).TimeOfDay;
            DateTime outDate = DateTime.Parse(metroDateTime3.Text).Date + DateTime.Parse(dateTimePicker2.Text).TimeOfDay;


        //    MySqlDataReader reader = DBConnection.getData("select * from attendanceView where staffID = " + staffId + " and Date(OutTime) > '" + inDate + "' order by OutTime");
         //   if (reader.HasRows)
           // {
             //   reader.Close();
             //   MessageBox.Show("Conflicting dates", "Record Attendance", MessageBoxButtons.OK, MessageBoxIcon.Information);
               // metroDateTime2.Value = DateTime.Now;
           // }
            //else
            //{
              //  reader.Close();
                if (outDate <= inDate)
                {
                    MessageBox.Show("Out date should be higher than the In date", "Record Attendance", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    metroDateTime2.Value = DateTime.Now;
                }
                else
                {
                    TotalHoursTxtBox.Text = (outDate - inDate).TotalHours.ToString("N2");
                    validateHours = (outDate - inDate).TotalHours;
                }
            //}
            
         }

        private void metroDateTime3_ValueChanged(object sender, EventArgs e)
        {

            DateTime inDate = DateTime.Parse(metroDateTime2.Text).Date + DateTime.Parse(dateTimePicker1.Text).TimeOfDay;
            DateTime outDate = DateTime.Parse(metroDateTime3.Text).Date + DateTime.Parse(dateTimePicker2.Text).TimeOfDay;



            if (outDate <= inDate)
            {
                MessageBox.Show("Out date should have higher than the In date", "Record Attendance", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metroDateTime3.Value = DateTime.Now.AddDays(1);
            }
            else
            {
                TotalHoursTxtBox.Text = (outDate - inDate).TotalHours.ToString("N2");
                validateHours = (outDate - inDate).TotalHours;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime inDate = DateTime.Parse(metroDateTime2.Text).Date + DateTime.Parse(dateTimePicker1.Text).TimeOfDay;
            DateTime outDate = DateTime.Parse(metroDateTime3.Text).Date + DateTime.Parse(dateTimePicker2.Text).TimeOfDay;
            TotalHoursTxtBox.Text = (outDate - inDate).TotalHours.ToString("N2");
            validateHours = (outDate - inDate).TotalHours;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime inDate = DateTime.Parse(metroDateTime2.Text).Date + DateTime.Parse(dateTimePicker1.Text).TimeOfDay;
            DateTime outDate = DateTime.Parse(metroDateTime3.Text).Date + DateTime.Parse(dateTimePicker2.Text).TimeOfDay;
            TotalHoursTxtBox.Text = (outDate - inDate).TotalHours.ToString("N2");
            validateHours = (outDate - inDate).TotalHours;
        }

        private void metroDateTime2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void EffectiveHoursTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
        }

        private void metroTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void EffectiveHoursTxtbox_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void EffectiveHoursTxtbox_Click(object sender, EventArgs e)
        {

        }
    }
}
