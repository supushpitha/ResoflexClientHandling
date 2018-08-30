using ResoflexClientHandlingSystem.Core;
using ResoflexClientHandlingSystem.Role;
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResoflexClientHandlingSystem.OfficeExpenses;

namespace ResoflexClientHandlingSystem
{
    public partial class SalaryForm : MetroFramework.Forms.MetroForm
    {
        public SalaryForm()
        {
            InitializeComponent();


            empid.DataSource = display();
            empid.ValueMember = "staff_id";
            empid.DisplayMember = "staff_id";


            MySqlDataReader rdr1 = DBConnection.getData("select staff_id from staff");

            DataTable dt = new DataTable();
            dt.Load(rdr1);

            rdr1.Close();

            empid.DataSource = dt;
            //empid.ValueMember = "staff_id";
            empid.DisplayMember = "staff_id";

        }

        private void Sal_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }
        public DataTable display() {

            MySqlDataReader reader = DBConnection.getData("select staff_id from staff");

            DataTable dt = new DataTable();
            dt.Load(reader);

            reader.Close();

            return dt;
        }

        private void empid_SelectedIndexChanged(object sender, EventArgs e)
        {
            getdata();
        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {


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


        public void getdata()
        {
            MySqlDataReader reader = DBConnection.getData("select * from staff where staff_id = " + empid.SelectedValue + ";");

            if (reader.Read())
            {

                basicsal.Text = reader.GetDouble("basic_salary").ToString();
                rate.Text = reader.GetDouble("ot_rate").ToString();
                /*hours.Text = reader.GetDouble("hours").ToString();
                days.Text = reader.GetDouble("days").ToString();
                allowance.Text = reader.GetDouble("allowance").ToString();
                etf.Text = reader.GetDouble("etf_epf_amount").ToString();*/

            }


            reader.Close();

            //string stdt = start.Value.ToString("yyyy-MM-dd");
            //string eddt = end.Value.ToString("yyyy-MM-dd");


            MySqlDataReader reader1 = DBConnection.getData("SELECT SUM(total_hours) as total_hours FROM attendance WHERE (in_time = 2018 - 08 - 08 <= 2018 - 08 - 10) and staff_id = " + empid.SelectedValue);

            if (reader1.Read())
            {
                hours.Text = reader1.GetDouble("total_hours").ToString();
            }

            reader1.Close();

            //MySqlDataReader rdr = DBConnection.getData("select in_time, out_time attendance where staff_id = " + empid.SelectedValue + ";");


        }




/*
        private void metroButton2_Click(object sender, EventArgs e)
        /*{
            O= new PaidForm();
            p.Show();
        }*/

private void empid_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void EndDatetime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel11_Click_1(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            ResoflexClientHandlingSystem.Role.Salary sal = new ResoflexClientHandlingSystem.Role.Salary();

            sal.Empid = int.Parse(empid.SelectedValue.ToString());
            sal.BasicSalAmount = double.Parse(basicsal.Text.ToString());
            sal.Rate = int.Parse(rate.Text.ToString());

            int hrs = int.Parse(hours.Text.ToString());

            if(hrs > 240)
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

            Database.addSalary(sal);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            Paid pay = new Paid();
            this.Hide();
            pay.Show();
            
        }
    }


}

    