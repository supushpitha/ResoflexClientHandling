using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class Iou
    {
        private int iouID;
        private Project projectOfIou;
        private Schedule scheduleOfIou;
        private DateTime date;
        private double amount;
        private string detail;

        public Iou()
        {
        }

        public Iou(int iouID, Project projectOfIou, Schedule scheduleOfIou, DateTime date, double amount, string detail)
        {
            IouID = iouID;
            ProjectOfIou = projectOfIou;
            ScheduleOfIou = scheduleOfIou;
            Date = date;
            Amount = amount;
            Detail = detail;
        }

        public int IouID { get => iouID; set => iouID = value; }
        public Project ProjectOfIou { get => projectOfIou; set => projectOfIou = value; }
        public Schedule ScheduleOfIou { get => scheduleOfIou; set => scheduleOfIou = value; }
        public DateTime Date { get => date; set => date = value; }
        public double Amount { get => amount; set => amount = value; }
        public string Detail { get => detail; set => detail = value; }
    }
}
