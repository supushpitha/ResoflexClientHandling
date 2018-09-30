using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    public class EventTechnician
    {
        private Event eventOfTechnician;
        private Staff technician;
        private string feedback;
        private string task;
        private double manHours;

        public EventTechnician()
        {

        }

        public EventTechnician(Event eventOfTechnician, Staff technician, string feedback, string task)
        {
            this.EventOfTechnician = eventOfTechnician;
            this.Technician = technician;
            this.Feedback = feedback;
            this.Task = task;
        }

        public EventTechnician(Event eventOfTechnician, Staff technician, string feedback, string task, double manHours) : this(eventOfTechnician, technician, feedback, task)
        {
            this.ManHours = manHours;
        }

        public Staff Technician { get => technician; set => technician = value; }
        public string Feedback { get => feedback; set => feedback = value; }
        internal Event EventOfTechnician { get => eventOfTechnician; set => eventOfTechnician = value; }
        public string Task { get => task; set => task = value; }
        public double ManHours { get => manHours; set => manHours = value; }
    }
}
