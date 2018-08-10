using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class User : Staff
    {
        private string uName;
        private string pword;
        private string permission;

        public string UName { get => uName; set => uName = value; }
        public string Pword { get => pword; set => pword = value; }
        public string Permission { get => permission; set => permission = value; }

        public User(string uName, string pword, string permission, int staffId) : base (staffId)
        {
            this.UName = uName;
            this.Pword = pword;
            this.Permission = permission;
        }

        public User(string uName, string pword, string permission, string[] telNumber) : base(telNumber)
        {
            this.UName = uName;
            this.Pword = pword;
            this.Permission = permission;
        }

        public User(string uName, string pword, string permission)
        {
            this.UName = uName;
            this.Pword = pword;
            this.Permission = permission;
        }

        
    }
}
