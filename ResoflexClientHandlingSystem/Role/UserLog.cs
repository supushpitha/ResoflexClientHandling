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
        private User user;
        private string loggedInDateTime;
        private string loggedOutDateTime;
        private string detail;
        private string ip;

        public UserLog(int logId, User user, string loggedInDateTime, string loggedOutDateTime, string detail, string ip)
        {
            this.logId = logId;
            this.user = user;
            this.loggedInDateTime = loggedInDateTime;
            this.loggedOutDateTime = loggedOutDateTime;
            this.detail = detail;
            this.ip = ip;
        }

        public UserLog(int logId, string loggedOutDateTime, string detail)
        {
            this.logId = logId;
            this.loggedOutDateTime = loggedOutDateTime;
            this.detail = detail;

        }

        public UserLog(User user, string loggedInDateTime, string loggedOutDateTime, string ip, string detail)
        {
            this.user = user;
            this.loggedInDateTime = loggedInDateTime;
            this.loggedOutDateTime = loggedOutDateTime;
            this.ip = ip;
            this.detail = detail;

        }

        public UserLog(User user, string loggedInDateTime, string ip)
        {
            this.user = user;
            this.loggedInDateTime = loggedInDateTime;
            this.ip = ip;
        }

        public UserLog(int id)
        {

            this.LogId = id;        }

        public int LogId { get => logId; set => logId = value; }
        public User User { get => user; set => user = value; }
        public string LoggedInDateTime { get => loggedInDateTime; set => loggedInDateTime = value; }
        public string LoggedOutDateTime { get => loggedOutDateTime; set => loggedOutDateTime = value; }
        public string Detail { get => detail; set => detail = value; }
        public string Ip { get => ip; set => ip = value; }

    }
}
