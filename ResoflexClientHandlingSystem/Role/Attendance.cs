using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class Attendance
    {
        private Staff staff;
        private DateTime date;
        private DateTime inTime;
        private DateTime outTime;
        private int hoursWorked;

        public Attendance()
        {
        }

        public Attendance(Staff staff, DateTime date, DateTime inTime, DateTime outTime, int hoursWorked)
        {
            this.Staff = staff;
            this.Date = date;
            this.InTime = inTime;
            this.OutTime = outTime;
            this.HoursWorked = hoursWorked;
        }

        public DateTime Date { get => date; set => date = value; }
        public DateTime InTime { get => inTime; set => inTime = value; }
        public DateTime OutTime { get => outTime; set => outTime = value; }
        public int HoursWorked { get => hoursWorked; set => hoursWorked = value; }
        internal Staff Staff { get => staff; set => staff = value; }
    }
}
