using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class Project_Income
    {
        private int projectID;
        
        public Project_Income(){ }
        

        public Project_Income(int projectID)
        {
            projectID = ProjectID;
        }


        public int ProjectID { get => projectID; set => projectID = value; }


    }
}