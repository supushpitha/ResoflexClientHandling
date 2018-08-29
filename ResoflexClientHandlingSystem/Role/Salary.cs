using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    public class Salary
    {
        private int empid;
        private Staff staffOfSalary;
        private int salaryID;
        private DateTime salaryDate;
        private double basicSalAmount;
        private double otAmount;
        private float allowance;
        private double etfEpf;
        private Attendance hours;
        private int rate;
        private double gross;
        private double net;

        public Salary()
        {

        }

        public Salary(Staff staffOfSalary, int salaryID, DateTime salaryDate, double basicSalAmount, double otAmount, float allowance, double etfEpf, Attendance hours)
        {
            this.StaffOfSalary = staffOfSalary;
            this.SalaryID = salaryID;
            this.SalaryDate = salaryDate;
            this.BasicSalAmount = basicSalAmount;
            this.OtAmount = otAmount;
            this.Allowance = allowance;
            this.EtfEpf = etfEpf;
            this.Hours = hours;
        }

        public Salary(Staff staffOfSalary, double basicSalAmount, float rate, Attendance hours, float allowance, double etfEpf)
        {
            this.StaffOfSalary = staffOfSalary;
            this.BasicSalAmount = basicSalAmount;
            this.Rate = (int)rate;
            this.Hours = hours;
            this.Allowance = allowance;
            this.EtfEpf = etfEpf;
        }

        public int Empid { get => empid; set => empid = value; }
        public Staff StaffOfSalary { get => staffOfSalary; set => staffOfSalary = value; }
        public int SalaryID { get => salaryID; set => salaryID = value; }
        public DateTime SalaryDate { get => salaryDate; set => salaryDate = value; }
        public double BasicSalAmount { get => basicSalAmount; set => basicSalAmount = value; }
        public double OtAmount { get => otAmount; set => otAmount = value; }
        public float Allowance { get => allowance; set => allowance = value; }
        public double EtfEpf { get => etfEpf; set => etfEpf = value; }
        public int Rate { get => rate; set => rate = value; }
        public double Gross { get => gross; set => gross = value; }
        public double Net { get => net; set => net = value; }
        internal Attendance Hours { get => hours; set => hours = value; }
    }
}
