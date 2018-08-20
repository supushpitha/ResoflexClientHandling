using ResoflexClientHandlingSystem.Role;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResoflexClientHandlingSystem
{
    public partial class resourceForm : MetroFramework.Forms.MetroForm
    {
        public resourceForm()
        {
            InitializeComponent();
        }

        private void resourceForm_Load(object sender, EventArgs e)
        {

        }

        void clear()
        {
            nameResTxtBox.Clear();
            valueResTxtBox.Clear();
            qtyResTxtBox.Clear();
        }

        private void resClearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {

        }

        private void resAddBtn_Click(object sender, EventArgs e)
        {
            string name = nameResTxtBox.Text;
            float value = float.Parse(valueResTxtBox.Text);
            int totalQty = Int32.Parse(qtyResTxtBox.Text);
            int availableQty = Int32.Parse(qtyResTxtBox.Text);

            Resource reso = new Resource(name, value, totalQty, availableQty);

        }
    }
}
