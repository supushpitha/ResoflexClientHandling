using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class UserOperation
    {
        private UserLog log;
        private int opId;
        private string operation;

        public UserOperation(UserLog log, int opId, string operation)
        {
            this.log = log;
            this.opId = opId;
            this.operation = operation;
        }

        public UserOperation(UserLog log, string operation)
        {
            this.log = log;
            this.operation = operation;
        }

        public UserLog LogId { get => log; set => log = value; }
        public int OpId { get => opId; set => opId = value; }
        public string Operation { get => operation; set => operation = value; }
    }
}
