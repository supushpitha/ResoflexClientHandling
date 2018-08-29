using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;
using ResoflexClientHandlingSystem.OfficeExpensesForm;
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

namespace ResoflexClientHandlingSystem.OfficeExpenses
{
    public partial class Paid : MetroFramework.Forms.MetroForm
    {
        public Paid()
        {
            InitializeComponent();
        }

        private void ExpenceReport_Load(object sender, EventArgs e)
        {
            fillStaffNameCmb();
            fillPositionCmb();
            salaryGrid.DataSource = getSalary();
        }

        private DataTable getSalary()
        {
            MySqlDataReader reader = DBConnection.getData("select s.staff_id, s.first_name as Employee, l.basic_sal_amount as Basic, l.rate as Rate, l.allowance as Allowance, " +
                "l.etf_epf_amount as ETF_EPF " +
                "from salary l inner join staff s on l.staff_id=s.staff_id");

            DataTable table = new DataTable();

            table.Load(reader);

            reader.Close();

            return table;
        }

        private void fillPositionCmb()
        {
            MySqlDataReader reader = DBConnection.getData("SELECT designation_name as dn from designation");

            positionCmbBox.Items.Clear();

            while (reader.Read())
            {
                positionCmbBox.Items.Add(reader.GetString("dn"));
            }

            reader.Close();
        }

        private void fillStaffNameCmb()
        {
            MySqlDataReader reader = DBConnection.getData("SELECT first_name as fn, last_name as ln from staff");

            staffNameCmbBox.Items.Clear();

            while (reader.Read())
            {
                string name = reader.GetString("fn") + " " + reader.GetString("ln");

                staffNameCmbBox.Items.Add(name);
            }

            reader.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = salaryGrid.CurrentRow;

            int staff_id = int.Parse(row.Cells[0].Value.ToString());

            MySqlDataReader reader = DBConnection.getData("SELECT * from Salary where staff_id= " + staff_id + ";");

            reader.Read();

            Role.Salary sal = new Role.Salary(new Staff(int.Parse(reader["staff_id"].ToString())), Double.Parse(reader["basic_sal_amount"].ToString()), float.Parse(reader["rate"].ToString()),
                    new Attendance(int.Parse(reader["hours"].ToString())), float.Parse(reader["allowance"].ToString()), Double.Parse(reader["etf_epf_amount"].ToString()));

            reader.Close();

            UpdateSalaryForm salaryfrm = new UpdateSalaryForm(sal);

            salaryfrm.Show();

            /*while (reader.Read())
            {
                Role.Salary sal = new Role.Salary(new Staff(int.Parse(reader["staff_id"].ToString())), Double.Parse(reader["basic_sal_amount"].ToString()), float.Parse(reader["rate"].ToString()),
                    new Attendance(int.Parse(reader["hours"].ToString())), float.Parse(reader["allowance"].ToString()), Double.Parse(reader["etf_epf_amount"].ToString()));

                reader.Close();

                UpdateSalaryForm salaryfrm = new UpdateSalaryForm(sal);

            }
            reader.Close();
            */
        }

        private void salaryGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
