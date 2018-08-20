using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class JobPerformance
    {
        private int jobPerformanceNo;
        private int employeeNo;
        private int date;
        private int knowledge;
        private int safety;
        private int quality;
        private int adaptability;
        private int productivity;
        private int initiative;
        private int total;

        public JobPerformance(int jobPerformanceNo, int employeeNo, int date, int knowledge, int safety, int quality, int adaptability, int productivity, int initiative, int total)
        {
            this.jobPerformanceNo = jobPerformanceNo;
            this.employeeNo = employeeNo;
            this.date = date;
            this.knowledge = knowledge;
            this.safety = safety;
            this.quality = quality;
            this.adaptability = adaptability;
            this.productivity = productivity;
            this.initiative = initiative;
            this.total = total;
        }

        public int JobPerformanceNo { get => jobPerformanceNo; set => jobPerformanceNo = value; }
        public int EmployeeNo { get => employeeNo; set => employeeNo = value; }
        public int Date { get => date; set => date = value; }
        public int Knowledge { get => knowledge; set => knowledge = value; }
        public int Safety { get => safety; set => safety = value; }
        public int Quality { get => quality; set => quality = value; }
        public int Adaptability { get => adaptability; set => adaptability = value; }
        public int Productivity { get => productivity; set => productivity = value; }
        public int Initiative { get => initiative; set => initiative = value; }
        public int Total { get => total; set => total = value; }
    }
}
