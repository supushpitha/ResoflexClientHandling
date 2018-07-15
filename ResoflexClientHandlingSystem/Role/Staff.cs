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
        private List<Attendance> attndance;

        public Staff()
        {
        }

        public Staff(int staffId,int userId, string userType, string firstName, string lastName, string nIC, string address, string[] teleNumber, string email): base(userId, userType, firstName, lastName, nIC, address, teleNumber, email)
        {
            this.staffId = staffId;
        } 
    }
}
