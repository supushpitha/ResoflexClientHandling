using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    public class Staff
    {
        private int staffId;
        private string firstName;
        private string lastName;
        private string nic;
        private string pAddress;
        private string sAddress;
        private string[] telNumber;
        private string email;
        private string facebook;
        private string linkedIn;
        private float basicSalary;
        private float otRate;
        private Designation designation;

        private List<Attendance> attendance;

        public Staff()
        {
        }

        public Staff(int staffId)
        {
            this.StaffId = staffId;
        }

        public Staff(int staffId, string firstName, string lastName) : this(staffId)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Staff(string[] telNumber)
        {
            this.TelNumber = telNumber;
        }

        public Staff(int staffId, Designation designation, string firstName, string lastName, string nic, string pAddress, string sAddress, string[] telNumber, string email, string facebook, string linkedIn, float basicSalary, float otRate)
        {
            this.StaffId = staffId;
            this.Designation = designation;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Nic = nic;
            this.PAddress = pAddress;
            this.SAddress = sAddress;
            this.TelNumber = telNumber;
            this.Email = email;
            this.Facebook = facebook;
            this.LinkedIn = linkedIn;
            this.BasicSalary = basicSalary;
            this.OtRate = otRate;
        }

        public Staff(string firstName, string lastName, string nic, string pAddress, string sAddress, string[] telNumber, string email, string facebook, string linkedIn, float basicSal, float otRate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Nic = nic;
            this.PAddress = pAddress;
            this.SAddress = sAddress;
            this.TelNumber = telNumber;
            this.Email = email;
            this.Facebook = facebook;
            this.LinkedIn = linkedIn;
            this.BasicSalary = basicSal;
            this.OtRate = otRate;
        }

        public int StaffId { get => staffId; set => staffId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Nic { get => nic; set => nic = value; }
        public string[] TelNumber { get => telNumber; set => telNumber = value; }
        public string Email { get => email; set => email = value; }
        public float BasicSalary { get => basicSalary; set => basicSalary = value; }
        public float OtRate { get => otRate; set => otRate = value; }
        public string Facebook { get => facebook; set => facebook = value; }
        public string LinkedIn { get => linkedIn; set => linkedIn = value; }
        internal List<Attendance> Attendance { get => attendance; set => attendance = value; }
        internal Designation Designation { get => designation; set => designation = value; }
        public string PAddress { get => pAddress; set => pAddress = value; }
        public string SAddress { get => sAddress; set => sAddress = value; }
    }
}
