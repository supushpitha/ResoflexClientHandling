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
        private int staffId;
        private DateTime date;
        private string task;

        public OfficeExpenses(int offExpenseId, int staffId, DateTime date, string task)
        {
            this.offExpenseId = offExpenseId;
            this.staffId = staffId;
            this.date = date;
            this.task = task;
        }
    }
}
