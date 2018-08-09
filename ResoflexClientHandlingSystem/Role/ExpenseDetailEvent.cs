using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class ExpenseDetailEvent
    {
        private ExpenseType expType;
        private int eventId;
        private Int64 projectId;
        private double amount;
        private string comment;

        public ExpenseDetailEvent(ExpenseType expType, int eventId, long projectId, double amount, string comment)
        {
            this.expType = expType;
            this.eventId = eventId;
            this.projectId = projectId;
            this.amount = amount;
            this.comment = comment;
        }
    }
}
