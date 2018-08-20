using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    public class Designation
    {
        private int desigId;
        private string designationName;

        public Designation(int desigId, string designation)
        {
            this.desigId = desigId;
            this.designationName = designation;
        }

        public Designation(string designation)
        {
            this.DesignationName = designation;
        }

        public int DesigId { get => desigId; set => desigId = value; }
        public string DesignationName { get => designationName; set => designationName = value; }
    }
}
