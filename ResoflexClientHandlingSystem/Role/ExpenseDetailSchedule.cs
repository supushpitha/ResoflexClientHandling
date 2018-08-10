using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class ExpenseDetailSchedule
    {
        private int expTypeId;
        private int schNo;
        private Int64 projectId;
        private double amount;
        private String comment;

        public ExpenseDetailSchedule(int expTypeId, int schNo, long projectId, double amount, string comment)
        {
            this.expTypeId = expTypeId;
            this.schNo = schNo;
            this.projectId = projectId;
            this.amount = amount;
            this.comment = comment;
        }
    }
}
