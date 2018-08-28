using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class JobPerformance
    {
        
        private int staffId;
        private DateTime perfYear;
        private int knowledge;
        private int safety;
        private int quality;
        private int adaptability;
        private int productivity;
        private int initiative;

        public JobPerformance(int staffId, DateTime perfYear, int knowledge, int safety, int quality, int adaptability, int productivity, int initiative)
        {
            this.staffId = staffId;
            this.perfYear = perfYear;
            this.knowledge = knowledge;
            this.safety = safety;
            this.quality = quality;
            this.adaptability = adaptability;
            this.productivity = productivity;
            this.initiative = initiative;
        }

        public int StaffId { get => staffId; set => staffId = value; }
        public DateTime PerfYear { get => perfYear; set => perfYear = value; }
        public int Knowledge { get => knowledge; set => knowledge = value; }
        public int Safety { get => safety; set => safety = value; }
        public int Quality { get => quality; set => quality = value; }
        public int Adaptability { get => adaptability; set => adaptability = value; }
        public int Productivity { get => productivity; set => productivity = value; }
        public int Initiative { get => initiative; set => initiative = value; }
    }
}
