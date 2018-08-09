using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class Salary
    {
        private int staffID;
        private int salaryID;
        private DateTime salaryDate;
        private double basicSalAmount;
        private double otAmount;
        private float allowance;
        private double etfEpf;

        public Salary(int staffID, int salaryID, DateTime salaryDate, double basicSalAmount, double otAmount, float allowance, double etfEpf)
        {
            this.staffID = staffID;
            this.salaryID = salaryID;
            this.salaryDate = salaryDate;
            this.basicSalAmount = basicSalAmount;
            this.otAmount = otAmount;
            this.allowance = allowance;
            this.etfEpf = etfEpf;
        }
    }
}
