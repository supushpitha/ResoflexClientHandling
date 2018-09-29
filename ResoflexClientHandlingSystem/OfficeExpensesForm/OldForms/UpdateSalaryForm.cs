using System;
using ResoflexClientHandlingSystem.Core;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResoflexClientHandlingSystem.Role;
using MySql.Data.MySqlClient;

namespace ResoflexClientHandlingSystem.OfficeExpensesForm
{
    public partial class UpdateSalaryForm : MetroFramework.Forms.MetroForm
    {
        private Role.Salary sal;

        public UpdateSalaryForm()
        {
            InitializeComponent();

            empid.DataSource= display();
            empid.ValueMember = "staff_id";
            empid.DisplayMember = "staff_id";
        }

        public UpdateSalaryForm(Role.Salary sal)
        {
            InitializeComponent();

            this.sal = sal;

            

            empid.DataSource = display();
            empid.ValueMember = "staff_id";
            empid.DisplayMember = "staff_id";

            
            
            empid.SelectedValue = sal.StaffOfSalary.StaffId;
            basicsal.Text = sal.BasicSalAmount.ToString();
            rate.Text = sal.Rate.ToString();
            hours.Text = sal.Hours.HoursWorked.ToString();
            allowance.Text = sal.Allowance.ToString();
            Gsal.Text = sal.Gross.ToString();
            metroTextBox12.Text = sal.Gross.ToString();
            metroTextBox13.Text = sal.EtfEpf.ToString();
            netSal.Text = sal.Net.ToString();
            
        }

        public DataTable display()
        {

            MySqlDataReader reader = DBConnection.getData("select staff_id from staff");

            DataTable dt = new DataTable();
            dt.Load(reader);
            
            reader.Close();

            return dt;
        }

        private void UpdateSalaryForm_Load(object sender, EventArgs e)
        {
           // empid.DataSource = display();
        }

        private void add_Click(object sender, EventArgs e)
        {
            ResoflexClientHandlingSystem.Role.Salary sal = new ResoflexClientHandlingSystem.Role.Salary();

            sal.Empid = int.Parse(empid.SelectedValue.ToString());
            sal.BasicSalAmount = double.Parse(basicsal.Text.ToString());
            sal.Rate = int.Parse(rate.Text.ToString());

            int hrs = int.Parse(hours.Text.ToString());

            if (hrs > 240)
            {
                double temp = hrs - 240;

                temp = temp * sal.Rate;

                temp = temp + int.Parse(allowance.Text.ToString());

                temp = sal.BasicSalAmount + temp;

                sal.Gross = temp;

                sal.Net = temp - double.Parse(etf.Text.ToString());
            }
            else
            {
                sal.Gross = sal.BasicSalAmount + int.Parse(allowance.Text.ToString());

                sal.Net = sal.BasicSalAmount - double.Parse(etf.Text.ToString());
            }


            sal.Hours = new Attendance(hrs);
            sal.Allowance = float.Parse(allowance.Text.ToString());
            sal.EtfEpf = double.Parse(etf.Text.ToString());

            Database.updateSalary(sal);
        }
        
        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                double basicSal = Double.Parse(basicsal.Text.ToString());
                int Rate = Int32.Parse(rate.Text.ToString());
                int Hours = Int32.Parse(hours.Text.ToString());
                double Allowance = Double.Parse(allowance.Text.ToString());
                double etfepf = Double.Parse(etf.Text.ToString());
                int otHrs = 0;

                if (Hours > 240)
                    otHrs = Hours % 240;

                double gross_sal = basicSal + ((double)Rate * otHrs) + Allowance;

                double net_sal = gross_sal - etfepf;

                Gsal.Text = "" + gross_sal;
                netSal.Text = "" + net_sal;
                metroTextBox12.Text = "" + gross_sal;
                metroTextBox13.Text = "" + etfepf;
            }
            catch (Exception)
            {
                throw;
            }


        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
