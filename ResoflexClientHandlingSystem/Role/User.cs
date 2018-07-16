using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class User
    {
        protected int userId;
        protected String userType;
        protected String firstName;
        protected String lastName;
        protected String nic;
        protected String address;
        protected String[] telNumber;
        protected String email;

        public User()
        {
        }

        public User(int userId, string userType, string firstName, string lastName, string nic, string address, string[] telNumber, string email)
        {
            this.userId = userId;
            this.userType = userType;
            this.firstName = firstName;
            this.lastName = lastName;
            this.nic = nic;
            this.address = address;
            this.telNumber = telNumber;
            this.email = email;
        }
    }
}
