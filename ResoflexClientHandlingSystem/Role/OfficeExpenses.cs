using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class Office_Expenses:Expenses
    {
        private int offExpenseId;
        private int staffId;
        private DateTime date;
        private String task;

        public Office_Expenses(int offExpenseId, int staffId, DateTime date, string task)
        {
            this.offExpenseId = offExpenseId;
            this.staffId = staffId;
            this.date = date;
            this.task = task;
        }
    }
}
