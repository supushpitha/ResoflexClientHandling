using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class ExpenseDetailEvent
    {
        private int expTypeId;
        private int eventId;
        private Int64 projectId;
        private double amount;
        private String comment;

        public ExpenseDetailEvent(int expTypeId, int eventId, long projectId, double amount, string comment)
        {
            this.expTypeId = expTypeId;
            this.eventId = eventId;
            this.projectId = projectId;
            this.amount = amount;
            this.comment = comment;
        }
    }
}
