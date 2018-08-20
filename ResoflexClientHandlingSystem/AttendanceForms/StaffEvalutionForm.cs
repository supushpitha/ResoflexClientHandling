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

namespace ResoflexClientHandlingSystem
{
    public partial class StaffEvalutionForm : MetroFramework.Forms.MetroForm
    {
        public StaffEvalutionForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            metroGrid3.DataSource = getStaff();
            metroGrid2.DataSource = getStaff();
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
            MySqlDataReader reader = DBConnection.getData("SELECT * FROM staff WHERE name LIKE '%"+ metroTextBox2.Text+ "%' OR  employee_no LIKE '%" + metroTextBox2.Text + "%'");
            table.Load(reader);
            return table;
            
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void metroGrid3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int emp_no = Int32.Parse(metroGrid3.Rows[e.RowIndex].Cells[0].Value.ToString());
            string emp_name = metroGrid3.Rows[e.RowIndex].Cells[1].Value.ToString();

            EvaluateEmployeeForm eEf = new EvaluateEmployeeForm(emp_no, emp_name);
            eEf.Show();

        }

        private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {

            metroGrid2.DataSource = searchEmployees();
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
