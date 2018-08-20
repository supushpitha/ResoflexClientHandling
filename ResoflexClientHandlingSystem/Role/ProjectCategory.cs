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
        private string categoryName;

        public ProjectCategory(int projectCatId, string categoryName)
        {
            this.ProjectCatId = projectCatId;
            this.CategoryName = categoryName;
        }

        public int ProjectCatId { get => projectCatId; set => projectCatId = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }
    }
}
