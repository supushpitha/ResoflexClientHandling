using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class Salary
    {
        private Staff staffOfSalary;
        private int salaryID;
        private DateTime salaryDate;
        private double basicSalAmount;
        private double otAmount;
        private float allowance;
        private double etfEpf;

        public Salary(Staff staffOfSalary, int salaryID, DateTime salaryDate, double basicSalAmount, double otAmount, float allowance, double etfEpf)
        {
            this.staffOfSalary = staffOfSalary;
            this.salaryID = salaryID;
            this.salaryDate = salaryDate;
            this.basicSalAmount = basicSalAmount;
            this.otAmount = otAmount;
            this.allowance = allowance;
            this.etfEpf = etfEpf;
        }
    }
}
