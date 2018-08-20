using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    public class EventType
    {
        private int eventTypeId;
        private string eventName;
        
        public EventType(int eventTypeId)
        {
            this.EventTypeId = eventTypeId;
        }

        public EventType(int eventTypeId, string eventName)
        {
            this.EventTypeId = eventTypeId;
            this.EventName = eventName;
        }

        public EventType(string eventName)
        {
            this.EventName = eventName;
        }

        public int EventTypeId { get => eventTypeId; set => eventTypeId = value; }
        public string EventName { get => eventName; set => eventName = value; }
    }
}
