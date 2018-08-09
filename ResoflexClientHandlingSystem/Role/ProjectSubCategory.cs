using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class ProjectSubCategory
    {
        private int projectSubCatId;
        private int projectCatId;
        private string subCatName;

        public ProjectSubCategory(int projectSubCatId, int projectCatId, string subCatName)
        {
            this.projectSubCatId = projectSubCatId;
            this.projectCatId = projectCatId;
            this.subCatName = subCatName;
        }
    }
}
