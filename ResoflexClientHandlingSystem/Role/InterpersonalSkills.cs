using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class InterpersonalSkills
    {
        private int staffId;
        private DateTime interYear;
        private int interactionWithCoworkers;
        private int interactionWithSupervisors;
        private int interactionWithClients;
        private int motivationalSkills;
        private int leadership;

        public InterpersonalSkills(int staffId, DateTime interYear, int interactionWithCustomers, int interactionWithSupervisors, int interactionWithClients, int motivationalSkills, int leadership)
        {
            this.staffId = staffId;
            this.interYear = interYear;
            this.interactionWithCoworkers = interactionWithCustomers;
            this.interactionWithSupervisors = interactionWithSupervisors;
            this.interactionWithClients = interactionWithClients;
            this.motivationalSkills = motivationalSkills;
            this.leadership = leadership;
        }

        public int StaffId { get => staffId; set => staffId = value; }
        public DateTime InterYear { get => interYear; set => interYear = value; }
        public int InteractionWithCoworkers { get => interactionWithCoworkers; set => interactionWithCoworkers = value; }
        public int InteractionWithSupervisors { get => interactionWithSupervisors; set => interactionWithSupervisors = value; }
        public int InteractionWithClients { get => interactionWithClients; set => interactionWithClients = value; }
        public int MotivationalSkills { get => motivationalSkills; set => motivationalSkills = value; }
        public int Leadership { get => leadership; set => leadership = value; }
    }
}
