using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class ProjectShortcomings
    {
        private int staffId;
        private int projectId;
        private int eventId;
        private string description;

        public ProjectShortcomings(int staffId, int projectId, int eventId, string description)
        {
            this.staffId = staffId;
            this.projectId = projectId;
            this.eventId = eventId;
            this.description = description;
        }

        public int StaffId { get => staffId; set => staffId = value; }
        public int ProjectId { get => projectId; set => projectId = value; }
        public int EventId { get => eventId; set => eventId = value; }
        public string Description { get => description; set => description = value; }
    }
}
