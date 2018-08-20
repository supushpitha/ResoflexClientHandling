using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class UserOperation
    {
        private int logId;
        private int opId;
        private string operation;

        public UserOperation(int logId, int opId, string operation)
        {
            this.logId = logId;
            this.opId = opId;
            this.operation = operation;
        }

        public int LogId { get => logId; set => logId = value; }
        public int OpId { get => opId; set => opId = value; }
        public string Operation { get => operation; set => operation = value; }
    }
}
