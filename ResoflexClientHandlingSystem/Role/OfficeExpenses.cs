using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class OfficeExpenses
    {
        private String expType;
        private int offExpenseId;
        private Staff staffIssued;
        private DateTime date;
        private string category;
        private int amount;
        //private int exp_id;
        //private int staffIssued1;
        //private object date1;
        //private MetroTextBox category1;
        //private MetroLabel amount1;

        public String ExpType { get => expType; set => expType = value; }
        public int OffExpenseId { get => offExpenseId; set => offExpenseId = value; }
        public Staff StaffIssued { get => staffIssued; set => staffIssued = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Category { get => category; set => category = value; }
        public int Amount { get => amount; set => amount = value; }
        //public int Exp_id { get => exp_id; set => exp_id = value; }

        public OfficeExpenses(String expType, int offExpenseId, Staff staffIssued, DateTime date, string category, int amount)
        {
            this.ExpType = expType;
            this.OffExpenseId = offExpenseId;
            this.StaffIssued = staffIssued;
            this.Date = date;
            this.Category = category;
            this.Amount = amount;
        }

        /*  public OfficeExpenses(Staff staffIssued, DateTime date, string category, int amount)
          {
              this.StaffIssued = staffIssued;
              this.Date = date;
              this.Category = category;
              this.Amount = amount;
          }*/

        /* public OfficeExpenses(int offExpenseId, int staffIssued1, object date1, MetroTextBox category1, MetroLabel amount1)
         {
             this.offExpenseId = offExpenseId;
             this.staffIssued1 = staffIssued1;
             this.date1 = date1;
             this.category1 = category1;
             this.amount1 = amount1;
         }*/

        public OfficeExpenses()
        {
        }
    }
}
