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
        private double usedTime;
        private double appTime;

        public EventTask(string task, string fb, double usedTime, double appTime)
        {
            Task = task;
            Fb = fb;
            UsedTime = usedTime;
            AppTime = appTime;
        }

        public string Task { get => task; set => task = value; }
        public string Fb { get => fb; set => fb = value; }
        public double UsedTime { get => usedTime; set => usedTime = value; }
        public double AppTime { get => appTime; set => appTime = value; }
    }
}
