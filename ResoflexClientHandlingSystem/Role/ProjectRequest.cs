using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class ProjectRequest
    {
        private Project projectOfRequest;
        private int reqId;
        private string request;
        private bool state;
        private DateTime addedDate;
        private DateTime startedDate;
        private DateTime endedDate;
        private bool urgent;
        private Staff staffOfRequest;
        
        public ProjectRequest(Project projectOfRequest, int reqId, string request, bool state, DateTime addedDate, DateTime startedDate, DateTime endedDate, bool urgent, Staff staffOfRequest)
        {
            this.ProjectOfRequest = projectOfRequest;
            this.ReqId = reqId;
            this.Request = request;
            this.State = state;
            this.AddedDate = addedDate;
            this.StartedDate = startedDate;
            this.EndedDate = endedDate;
            this.Urgent = urgent;
            this.StaffOfRequest = staffOfRequest;
        }

        public ProjectRequest(Project projectOfRequest, string request, bool urgent)
        {
            this.ProjectOfRequest = projectOfRequest;
            this.Request = request;
            this.AddedDate = DateTime.Now;
            this.Urgent = urgent;
        }

        public ProjectRequest(Project projectOfRequest, int reqId)
        {
            this.ProjectOfRequest = projectOfRequest;
            this.ReqId = reqId;
        }

        public ProjectRequest(Project projectOfRequest, string request, bool state, DateTime addedDate, DateTime startedDate, DateTime endedDate, bool urgent, Staff staffOfRequest)
        {
            this.ProjectOfRequest = projectOfRequest;
            this.Request = request;
            this.State = state;
            this.AddedDate = addedDate;
            this.StartedDate = startedDate;
            this.EndedDate = endedDate;
            this.Urgent = urgent;
            this.StaffOfRequest = staffOfRequest;
        }

        public Project ProjectOfRequest { get => projectOfRequest; set => projectOfRequest = value; }
        public int ReqId { get => reqId; set => reqId = value; }
        public string Request { get => request; set => request = value; }
        public bool State { get => state; set => state = value; }
        public DateTime AddedDate { get => addedDate; set => addedDate = value; }
        public DateTime StartedDate { get => startedDate; set => startedDate = value; }
        public DateTime EndedDate { get => endedDate; set => endedDate = value; }
        public bool Urgent { get => urgent; set => urgent = value; }
        public Staff StaffOfRequest { get => staffOfRequest; set => staffOfRequest = value; }
    }
}
