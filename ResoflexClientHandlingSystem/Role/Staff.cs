using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class Staff: User
    {
        private int staffId;
        private List<Attendance> attendance;

        public Staff()
        {
        }

        public Staff(int staffId,int userId, string userType, string firstName, string lastName, string NIC, string address, string[] telNumber, string email): base(userId, userType, firstName, lastName, NIC, address, telNumber, email)
        {
            this.staffId = staffId;
        } 
    }
}
