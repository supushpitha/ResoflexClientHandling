using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class Attendance
    {
        private int staffId;
        private DateTime date;
        private DateTime inTime;
        private DateTime outTime;
        private int hoursWorked;

        public Attendance()
        {
        }

        public Attendance(int staffId, DateTime date, DateTime inTime, DateTime outTime, int hoursWorked)
        {
            this.staffId = staffId;
            this.date = date;
            this.inTime = inTime;
            this.outTime = outTime;
            this.hoursWorked = hoursWorked;
        }
    }
}
