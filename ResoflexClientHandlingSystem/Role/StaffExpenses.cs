using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class Staff_expenses
    {
        private int staffID;
        private List<Attendance> attendnceList;
        private string staffExpType;

        public Staff_expenses()
        {
        }

        public Staff_expenses(int StaffID, String staffExpType, int expID, string type, double amount)
        {
            this.staffExpType = staffExpType;
            staffID = StaffID;
        }

        public int StaffId { get => staffID; set => staffID = value; }
        //public string[] Attendance { get => attendance; set => attendance = value; }
    }


}
