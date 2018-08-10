using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class ExpenseType
    {
        private int expTypeId;
        private String type;

        public ExpenseType(int expTypeId, string type)
        {
            this.expTypeId = expTypeId;
            this.type = type;
        }
    }
}
