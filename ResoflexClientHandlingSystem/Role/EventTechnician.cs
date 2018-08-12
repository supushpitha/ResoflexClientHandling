using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class EventTechnician
    {
        private Event eventOfTechnician;
        private Staff technician;
        private int feedback;

        public EventTechnician(Event eventOfTechnician, Staff technician, int feedback)
        {
            this.eventOfTechnician = eventOfTechnician;
            this.technician = technician;
            this.feedback = feedback;
        }
    }
}
