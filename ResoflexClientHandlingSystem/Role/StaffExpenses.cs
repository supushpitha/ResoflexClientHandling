using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class Staff_expenses
    {
        private Staff staffOfExpenses;
        private List<Attendance> attendnceList;
        private string staffExpType;

        public Staff_expenses()
        {
        }

        public Staff_expenses(Staff staffOfExpenses, String staffExpType, int expID, string type, double amount)
        {
            this.staffExpType = staffExpType;
            StaffOfExpenses = staffOfExpenses;
        }

        public Staff StaffOfExpenses { get => staffOfExpenses; set => staffOfExpenses = value; }
    }


}
