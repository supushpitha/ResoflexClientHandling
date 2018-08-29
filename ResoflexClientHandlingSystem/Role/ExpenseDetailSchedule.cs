using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class ExpenseDetailSchedule
    {
        private ExpenseType expType;
        private Schedule scheduleOfExp;
        private Project projectOfSchedule;
        private double amount;
        private string comment;

        public ExpenseDetailSchedule()
        {
        }

        public ExpenseDetailSchedule(ExpenseType expType, Schedule scheduleOfExp, Project projectOfSchedule, double amount, string comment)
        {
            this.ExpType = expType;
            this.ScheduleOfExp = scheduleOfExp;
            this.ProjectOfSchedule = projectOfSchedule;
            this.Amount = amount;
            this.Comment = comment;
        }

        public Schedule ScheduleOfExp { get => scheduleOfExp; set => scheduleOfExp = value; }
        public Project ProjectOfSchedule { get => projectOfSchedule; set => projectOfSchedule = value; }
        public double Amount { get => amount; set => amount = value; }
        public string Comment { get => comment; set => comment = value; }
        internal ExpenseType ExpType { get => expType; set => expType = value; }
    }
}
