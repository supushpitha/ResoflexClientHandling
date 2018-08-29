using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    public class Attendance
    {
        private int staffAttendance;
        private int employeeNo;
        private string name;
        private string inTime;
        private string outTime;
        private int hoursWorked;

        //public Attendance(int attendance, int employeeNo, string name, DateTime inTime, DateTime outTime, int hoursWorked)
        //{
        //    this.StaffAttendance = attendance;
        //    this.EmployeeNo = employeeNo;
        //    this.Name = name;
        //    this.InTime = inTime;
        //    this.OutTime = outTime;
        //    this.HoursWorked = hoursWorked;
        //}

        public Attendance(int employeeNo, string name, string inTime, string outTime, int hoursWorked)
        {
            EmployeeNo = employeeNo;
            Name = name;
            InTime = inTime;
            OutTime = outTime;
            HoursWorked = hoursWorked;
        }

        public Attendance()
        {
        }

        public Attendance(int hw)
        {
            HoursWorked = hw;
        }

        public Attendance(Staff staff, string inTime, string outTime, int hoursWorked)
        {
            this.EmployeeNo = staff.StaffId;
            this.InTime = inTime;
            this.OutTime = outTime;
            this.HoursWorked = hoursWorked;
        }

        public int StaffAttendance { get => staffAttendance; set => staffAttendance = value; }
        public int EmployeeNo { get => employeeNo; set => employeeNo = value; }
        public string Name { get => name; set => name = value; }
        public string InTime { get => inTime; set => inTime = value; }
        public string OutTime { get => outTime; set => outTime = value; }
        public int HoursWorked { get => hoursWorked; set => hoursWorked = value; }
    }
}
