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
        private Event eventOfExp;
        private Project projectOfEvent;
        private double amount;
        private string comment;

        public ExpenseDetailEvent(ExpenseType expType, Event eventOfExp, Project projectOfEvent, double amount, string comment)
        {
            this.expType = expType;
            this.eventOfExp = eventOfExp;
            this.projectOfEvent = projectOfEvent;
            this.amount = amount;
            this.comment = comment;
        }
    }
}
