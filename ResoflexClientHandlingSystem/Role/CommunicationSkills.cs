using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class CommunicationSkills
    {

        private int staffId;
        private DateTime commYear;
        private int influence;
        private int presentation;
        private int relationships;
        private int listening;
        private int negotiation;

        public CommunicationSkills(int staffId, DateTime commYear, int influence, int presentation, int relationships, int listening, int negotiation)
        {
            this.staffId = staffId;
            this.commYear = commYear;
            this.influence = influence;
            this.presentation = presentation;
            this.relationships = relationships;
            this.listening = listening;
            this.negotiation = negotiation;
        }

        public int StaffId { get => staffId; set => staffId = value; }
        public DateTime CommYear { get => commYear; set => commYear = value; }
        public int Influence { get => influence; set => influence = value; }
        public int Presentation { get => presentation; set => presentation = value; }
        public int Relationships { get => relationships; set => relationships = value; }
        public int Listening { get => listening; set => listening = value; }
        public int Negotiation { get => negotiation; set => negotiation = value; }
    }
}
