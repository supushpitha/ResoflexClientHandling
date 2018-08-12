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
        private float amount;
        private string detail;

        public Iou(int iouID, Project projectOfIou, Schedule scheduleOfIou, DateTime date, float amount, string detail)
        {
            this.iouID = iouID;
            this.projectOfIou = projectOfIou;
            this.scheduleOfIou = scheduleOfIou;
            this.date = date;
            this.amount = amount;
            this.detail = detail;
        }
    }
}
