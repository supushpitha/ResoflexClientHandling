using System;
using System.Collections;
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
        private ArrayList task;

        public EventTechnician()
        {
            Task = new ArrayList();
        }

        public EventTechnician(Event eventOfTechnician, Staff technician, ArrayList task)
        {
            this.EventOfTechnician = eventOfTechnician;
            this.Technician = technician;
            this.Task = task;
        }
        
        public EventTechnician(Event eventOfTechnician, Staff technician, string feedback, string t, string appTime, string usedTime)
        {
            Task = new ArrayList();

            EventTask et = new EventTask(t, feedback, usedTime, appTime);

            Task.Add(et);
            this.EventOfTechnician = eventOfTechnician;
            this.Technician = technician;
        }

        public void addTask(string fb, string task, string app, string used)
        {
            Task.Add(new EventTask(task, fb, used, app));
        }

        public Staff Technician { get => technician; set => technician = value; }
        internal Event EventOfTechnician { get => eventOfTechnician; set => eventOfTechnician = value; }
        public ArrayList Task { get => task; set => task = value; }
    }
}
