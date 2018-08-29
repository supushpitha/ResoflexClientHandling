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
        private String name;
        private DateTime date;
        private String comment;
        private double amount;


        public int IouNo { get => iouNo; set => iouNo = value; }
        public String Name { get => name; set => name = value; }
        public DateTime Date { get => date; set => date = value; }
        public String Comment { get => comment; set => comment = value; }
        public double Amount { get => amount; set => amount = value; }

        public OfficeIou(int iouNo, String name, DateTime date, String comment, double amount)
        {

            this.IouNo = iouNo;
            this.Name = name;
            this.Date = date;
            this.Comment = comment;
            this.Amount = amount;
        }


        public OfficeIou()
        {
        }
    }
}
