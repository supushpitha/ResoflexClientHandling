using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class OfficeExpenses
    {
        private int offExpenseId;
        private Staff staffIssued;
        private DateTime date;
        private string task;

        public OfficeExpenses(int offExpenseId, Staff staffIssued, DateTime date, string task)
        {
            this.offExpenseId = offExpenseId;
            this.staffIssued = staffIssued;
            this.date = date;
            this.task = task;
        }
    }
}
