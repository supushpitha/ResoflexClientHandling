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
        private string type;

        public ExpenseType(int expTypeId)
        {
            ExpTypeId = expTypeId;
        }

        public ExpenseType(int expTypeId, string type)
        {
            this.ExpTypeId = expTypeId;
            this.Type = type;
        }

        public int ExpTypeId { get => expTypeId; set => expTypeId = value; }
        public string Type { get => type; set => type = value; }
    }
}
