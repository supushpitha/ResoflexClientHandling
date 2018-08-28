using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class ClientRelations
    {
        private int staffId;
        private DateTime relYear;
        private int telephoneSkills;
        private int problemResolution;
        private int salesmanship;
        private int proActiveness;
        private int politeness;

        public ClientRelations(int staffId, DateTime relYear, int telephoneSkills, int problemResolution, int salesmanship, int proActiveness, int politeness)
        {
            this.staffId = staffId;
            this.relYear = relYear;
            this.telephoneSkills = telephoneSkills;
            this.problemResolution = problemResolution;
            this.salesmanship = salesmanship;
            this.proActiveness = proActiveness;
            this.politeness = politeness;
        }

        public int StaffId { get => staffId; set => staffId = value; }
        public DateTime RelYear { get => relYear; set => relYear = value; }
        public int TelephoneSkills { get => telephoneSkills; set => telephoneSkills = value; }
        public int ProblemResolution { get => problemResolution; set => problemResolution = value; }
        public int Salesmanship { get => salesmanship; set => salesmanship = value; }
        public int ProActiveness { get => proActiveness; set => proActiveness = value; }
        public int Politeness { get => politeness; set => politeness = value; }
    }
}
