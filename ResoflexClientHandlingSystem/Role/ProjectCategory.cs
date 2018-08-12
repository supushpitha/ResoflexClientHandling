using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class ProjectCategory
    {
        private int projectCatId;
        private string categoryNAme;

        public ProjectCategory(int projectCatId, string categoryNAme)
        {
            this.projectCatId = projectCatId;
            this.categoryNAme = categoryNAme;
        }
    }
}
