using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;
using ResoflexClientHandlingSystem.Role;

namespace ResoflexClientHandlingSystem
{
    public partial class AddCatagory : MetroFramework.Forms.MetroForm
    {
        int projectCatId;
        string categoryNAme;

     public AddCatagory(int projectCatId, string categoryNAme)
        {
            this.projectCatId = projectCatId;
            this.categoryNAme = categoryNAme;

            InitializeComponent();
        }

        public AddCatagory()
        {
            InitializeComponent();
        }

        private void AddCatagory_Load(object sender, EventArgs e)
        {
            CatTxt.Text= categoryNAme;

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string categoryNAme = CatTxt.Text;

                ResoflexClientHandlingSystem.Role.ProjectCategory projectCat = new Role.ProjectCategory(projectCatId,categoryNAme);

                Database.addProjectCat(projectCat);

               
                MessageBox.Show("Successfully saved", " Project Catagory Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                closeForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Project Catagory Updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeForm()
        {
            this.Close();
        }

        private void notifySuccessProjectAdding_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
