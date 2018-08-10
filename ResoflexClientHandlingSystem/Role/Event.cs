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
        private int projectId;
        private int visitTypeId;
        private String type;
        private String servEngineer;
        private DateTime from;
        private DateTime to;
        private String vehicleDetails;
        private float mileage;
        private String feedback;
        private String other;
        private String todoList;
        private String resource;
        private String checklist;
        private String travelMode;
        private String accomodationMode;
        private String meals;
        private int schNo;

        public Event(int eventId, int projectId, int visitTypeId, string type, string servEngineer, DateTime from, DateTime to, string vehicleDetails, float mileage, string feedback, string other, string todoList, string resource, string checklist, string travelMode, string accomodationMode, string meals, int schNo)
        {
            this.eventId = eventId;
            this.projectId = projectId;
            this.visitTypeId = visitTypeId;
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
            this.accomodationMode = accomodationMode;
            this.meals = meals;
            this.schNo = schNo;
        }
    }
}
