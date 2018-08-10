using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class EventTechnician
    {
        private int eventId;
        private int techId;
        private int feedback;

        public EventTechnician(int eventId, int techId, int feedback)
        {
            this.eventId = eventId;
            this.techId = techId;
            this.feedback = feedback;
        }
    }
}
