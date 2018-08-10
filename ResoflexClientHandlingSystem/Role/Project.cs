using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class Project
    {
        private int projectID;
        private string projectName;
        private string projectdesc;
        private int clientID;
        private int project_subID;
        private DateTime firstInitDate;
        private DateTime tEndDate1;
        private DateTime tEndDate2;
        private DateTime warrantyStart;
        private int warrantyPeriod;
        private string supportTerms;
        private string warrantyTerms;
        private string visitTerms;
        
        public Project()
        {

        }

        public Project(int projectID, string projectName, string projectdesc, int clientID, int project_subID, DateTime firstInitDate, DateTime tEndDate1, DateTime tEndDate2, DateTime warrantyStart, int warrantyPeriod, string supportTerms, string warrantyTerms, string visitTerms)
        {
            this.projectID = projectID;
            this.projectName = projectName;
            this.projectdesc = projectdesc;
            this.clientID = clientID;
            this.project_subID = project_subID;
            this.firstInitDate = firstInitDate;
            this.tEndDate1 = tEndDate1;
            this.tEndDate2 = tEndDate2;
            this.warrantyStart = warrantyStart;
            this.warrantyPeriod = warrantyPeriod;
            this.supportTerms = supportTerms;
            this.warrantyTerms = warrantyTerms;
            this.visitTerms = visitTerms;
        }
    }
}