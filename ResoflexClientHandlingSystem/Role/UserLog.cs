using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class UserLog
    {
        private int logId;
        private int userId;
        private string loggedInDateTime;
        private string loggedOutDateTime;
        private string detail;
        private string ip;

        public UserLog(int logId, int userId, string loggedInDateTime, string loggedOutDateTime, string detail, string ip)
        {
            this.logId = logId;
            this.userId = userId;
            this.loggedInDateTime = loggedInDateTime;
            this.loggedOutDateTime = loggedOutDateTime;
            this.detail = detail;
            this.ip = ip;
        }

        public UserLog(int userId, string loggedInDateTime, string loggedOutDateTime, string ip, string detail)
        {
            this.userId = userId;
            this.loggedInDateTime = loggedInDateTime;
            this.loggedOutDateTime = loggedOutDateTime;
            this.ip = ip;
            this.detail = detail;

        }

        public int LogId { get => logId; set => logId = value; }
        public int UserId { get => userId; set => userId = value; }
        public string LoggedInDateTime { get => loggedInDateTime; set => loggedInDateTime = value; }
        public string LoggedOutDateTime { get => loggedOutDateTime; set => loggedOutDateTime = value; }
        public string Detail { get => detail; set => detail = value; }
        public string Ip { get => ip; set => ip = value; }

    }
}
