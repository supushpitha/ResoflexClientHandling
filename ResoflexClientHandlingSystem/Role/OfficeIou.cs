using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class OfficeIou
    {
        private int iouNo;
        private Staff toStaff;
        private DateTime date;
        private String comment;
        private double amount;


        public int IouNo { get => iouNo; set => iouNo = value; }
        public Staff ToStaff { get => toStaff; set => toStaff = value; }
        public DateTime Date { get => date; set => date = value; }
        public String Comment { get => comment; set => comment = value; }
        public double Amount { get => amount; set => amount = value; }

        public OfficeIou(int iouNo, Staff toStaff, DateTime date, String comment, double amount)
        {

            this.IouNo = iouNo;
            this.toStaff = toStaff;
            this.Date = date;
            this.Comment = comment;
            this.Amount = amount;
        }


        public OfficeIou()
        {
        }
    }
}
