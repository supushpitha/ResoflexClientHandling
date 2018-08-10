using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class ProjectRequest
    {
        private int projectId;
        private int reqId;
        private string request;
        private bool state;
        private DateTime addedDate;
        private DateTime startedDate;
        private DateTime endedDate;
        private bool urgent;
        private int staff_id;
        
        public ProjectRequest(int projectId, int reqId, string request, bool state, DateTime addedDate, DateTime startedDate, DateTime endedDate, bool urgent, int staff_id)
        {
            this.ProjectId = projectId;
            this.ReqId = reqId;
            this.Request = request;
            this.State = state;
            this.AddedDate = addedDate;
            this.StartedDate = startedDate;
            this.EndedDate = endedDate;
            this.Urgent = urgent;
            this.Staff_id = staff_id;
        }

        public ProjectRequest(int projectId, int reqId)
        {
            this.ProjectId = projectId;
            this.ReqId = reqId;
        }

        public ProjectRequest(int projectId, string request, bool state, DateTime addedDate, DateTime startedDate, DateTime endedDate, bool urgent, int staff_id)
        {
            this.ProjectId = projectId;
            this.Request = request;
            this.State = state;
            this.AddedDate = addedDate;
            this.StartedDate = startedDate;
            this.EndedDate = endedDate;
            this.Urgent = urgent;
            this.Staff_id = staff_id;
        }

        public int ProjectId { get => projectId; set => projectId = value; }
        public int ReqId { get => reqId; set => reqId = value; }
        public string Request { get => request; set => request = value; }
        public bool State { get => state; set => state = value; }
        public DateTime AddedDate { get => addedDate; set => addedDate = value; }
        public DateTime StartedDate { get => startedDate; set => startedDate = value; }
        public DateTime EndedDate { get => endedDate; set => endedDate = value; }
        public bool Urgent { get => urgent; set => urgent = value; }
        public int Staff_id { get => staff_id; set => staff_id = value; }
    }
}
