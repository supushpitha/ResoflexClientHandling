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
        private ProjectCategory projectCat;
        private string subCatName;

        public ProjectSubCategory(int projectSubCatId, ProjectCategory projectCat, string subCatName)
        {
            this.projectSubCatId = projectSubCatId;
            this.projectCat = projectCat;
            this.subCatName = subCatName;
        }
    }
}
