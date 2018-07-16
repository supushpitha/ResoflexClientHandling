using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class Staff
    {
        private int staffId;
        private String firstName;
        private String lastName;
        private String nic;
        private String address;
        private String[] telNumber;
        private String email;
        private Designation designation;

        private List<Attendance> attendance;

        public Staff()
        {
        }

        public Staff(int staffId)
        {
            this.staffId = staffId;
        }

        public Staff(string[] telNumber)
        {
            this.telNumber = telNumber;
        }

        public Staff(int staffId, Designation designation, string firstName, string lastName, string nic, string address, string[] telNumber, string email)
        {
            this.staffId = staffId;
            this.designation = designation;
            this.firstName = firstName;
            this.lastName = lastName;
            this.nic = nic;
            this.address = address;
            this.telNumber = telNumber;
            this.email = email;
        }

        internal List<Attendance> Attendance { get => attendance; set => attendance = value; }
    }
}
