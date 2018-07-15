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
        protected String nIC;
        protected String address;
        protected String[] teleNumber;
        protected String email;

        public User()
        {
        }

        public User(int userId, string userType, string firstName, string lastName, string nIC, string address, string[] teleNumber, string email)
        {
            this.userId = userId;
            this.userType = userType;
            this.firstName = firstName;
            this.lastName = lastName;
            this.nIC = nIC;
            this.address = address;
            this.teleNumber = teleNumber;
            this.email = email;
        }
    }
}
