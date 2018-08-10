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
        private int projectID;
        private int schNo;
        private DateTime date;
        private float amount;
        private string detail;

        public Iou(int iouID, int projectID, int schNo, DateTime date, float amount, string detail)
        {
            this.iouID = iouID;
            this.projectID = projectID;
            this.schNo = schNo;
            this.date = date;
            this.amount = amount;
            this.detail = detail;
        }
    }
}
