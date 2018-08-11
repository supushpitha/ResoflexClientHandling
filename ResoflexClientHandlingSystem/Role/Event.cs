using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class Event
    {
        private int eventId;
        private Project eventProject;
        private EventType type;
        private Staff servEngineer;
        private DateTime from;
        private DateTime to;
        private string vehicleDetails;
        private float mileage;
        private string feedback;
        private string other;
        private string todoList;
        private string resource;
        private string checklist;
        private string travelMode;
        private string accommodationMode;
        private string meals;
        private int schNo;

        public Event(int eventId, Project eventProject, EventType type, Staff servEngineer, DateTime from, DateTime to, string vehicleDetails, float mileage, string feedback, string other, string todoList, string resource, string checklist, string travelMode, string accommodationMode, string meals, int schNo)
        {
            this.eventId = eventId;
            this.eventProject = eventProject;
            this.type = type;
            this.servEngineer = servEngineer;
            this.from = from;
            this.to = to;
            this.vehicleDetails = vehicleDetails;
            this.mileage = mileage;
            this.feedback = feedback;
            this.other = other;
            this.todoList = todoList;
            this.resource = resource;
            this.checklist = checklist;
            this.travelMode = travelMode;
            this.accommodationMode = accommodationMode;
            this.meals = meals;
            this.schNo = schNo;
        }
    }
}
