using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    public class EventTask
    {
        private string task;
        private string fb;
        private string usedTime;
        private string appTime;

        public EventTask(string task, string fb, string usedTime, string appTime)
        {
            Task = task;
            Fb = fb;
            UsedTime = usedTime;
            AppTime = appTime;
        }

        public string Task { get => task; set => task = value; }
        public string Fb { get => fb; set => fb = value; }
        public string UsedTime { get => usedTime; set => usedTime = value; }
        public string AppTime { get => appTime; set => appTime = value; }
    }
}
