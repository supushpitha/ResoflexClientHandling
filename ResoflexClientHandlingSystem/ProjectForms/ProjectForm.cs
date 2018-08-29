using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;
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
    public partial class Project1 : MetroFramework.Forms.MetroForm
    {
        string clientName = "";

        public Project1()
        {
            InitializeComponent();
        }

        public Project1(string clientName)
        {
            InitializeComponent();

            this.clientName = clientName;
        }

        private void Project1_Load(object sender, EventArgs e)
        {
            projectGrid.DataSource = getProjects();
            projIdTile.BackColor = Color.LightSkyBlue;
            totExpenceTile.BackColor = Color.LightGreen;
            warrantyTile.BackColor = Color.LightCoral;

            if (clientName != "")
                searchProjectTxtBox.Text = clientName;

            projectGrid.Columns[0].Visible = true;
        }


        //tile

        private void fillTiles(int projectID)
        {
            try
            {
                MySqlDataReader reader = DBConnection.getData("select count(proj_id) from project ");

                while (reader.Read())
                {
                    projIdTile.Text = (reader.GetValue(0).ToString());
                }

                reader.Close();

                reader = DBConnection.getData("select warranty_start_date from project where proj_id=" + projectID);

                while (reader.Read())
                {
                    totExpenceTile.Text = (reader.GetValue(0).ToString());
                }

                reader.Close();

                reader = DBConnection.getData("select count(proj_id) from proj_request where proj_id=" + projectID);

                while (reader.Read())
                {
                    warrantyTile.Text = (reader.GetValue(0).ToString());
                }

                reader.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            } 

          
        }

        private void projectGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (dgv.CurrentRow.Selected)
            {
                int projectID = Int32.Parse(projectGrid.Rows[e.RowIndex].Cells[0].Value.ToString());

                fillTiles(projectID);
            }
        }

        //

        private DataTable getProjects()
        {
            DataTable table = new DataTable();

            MySqlDataReader reader = DBConnection.getData("select p.proj_id as ID,p.proj_name as Project_Name,p.description as Description ,c.name as Client,a.sub_cat_name as Category from project p, client c, proj_sub_category a where p.client_id=c.client_id and p.proj_sub_cat_id=a.proj_sub_cat_id group by p.proj_id desc");

            table.Load(reader);

            return table;
        }

        private void projectGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < projectGrid.Rows.Count; i++)
            {
                int val = Int32.Parse(projectGrid.Rows[i].Cells[3].Value.ToString());
                if (val >= 7000)
                {
                    projectGrid.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                }

            }
        }




        private void projectGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (dgv.CurrentRow.Selected)
            {
                int projectID = Int32.Parse(projectGrid.Rows[e.RowIndex].Cells[0].Value.ToString());

                fillTiles(projectID);
            }
        }

        private void addProjectBtn_Click(object sender, EventArgs e)
        {
            UpdateProjectForm upPrj = new UpdateProjectForm();

            upPrj.Show();
        }

        private void updateProjectBtn_Click(object sender, EventArgs e)
        {
            ProjectUpdate prjUp = new ProjectUpdate();

            prjUp.Show();


        }

     






        private void addProjectBtn_Click_1(object sender, EventArgs e)
        {
            UpdateProjectForm frm = new UpdateProjectForm();

            frm.ShowDialog();

            projectGrid.DataSource = getProjects();
        }

        private void progressBtn_Click(object sender, EventArgs e)
        {
            ProjectRanks frm = new ProjectRanks();

            frm.ShowDialog();

            projectGrid.DataSource = getProjects();
        }

        private void updateProjectBtn_Click_1(object sender, EventArgs e)
        {
            ProjectUpdate frm = new ProjectUpdate();
            frm.ShowDialog();
            projectGrid.DataSource = getProjects();
        }

        //search
        private void searchProjectTxtBox_TextChanged(object sender, EventArgs e)
        {

            string qry = "";
            string projectNameTxt = searchProjectTxtBox.Text;
       

            qry = "SELECT p.proj_id as ID, " +
                "p.proj_name, " +
                "p.description, " +
                "p.proj_sub_cat_id, " +
                "p.first_init_date, " +
                "p.training_comp_first_end_date, " +
                "p.training_comp_second_end_date, " +
                "p.warranty_start_date, " +
                "p.warranty_terms, " +
                "p.support_terms, " +
                "p.visit_terms " +
                "from project p inner join client c on c.client_id=p.client_id where p.proj_name like '%" + projectNameTxt + "%' or c.name like '%" + projectNameTxt+ "%'";

            try
            {
                MySqlDataReader reader = DBConnection.getData(qry);

                if (reader.HasRows)
                {
                    System.Data.DataTable table1 = new System.Data.DataTable();

                    table1.Load(reader);

                    projectGrid.DataSource = table1;
                }
                else
                {
                    reader.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Invalid data!\n" + exc.StackTrace, "Project finder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchProjectTxtBox.Text = "";

            projectGrid.DataSource = getProjects();
        }

        private void projIdTile_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            AddCatagory frm = new AddCatagory();
            frm.ShowDialog();
           
        }

      

        private void projectGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            int proid = Int32.Parse(projectGrid.Rows[e.RowIndex].Cells[0].Value.ToString());

            ProjectForms.ProjectProgress frm = new ProjectForms.ProjectProgress(proid);
            frm.ShowDialog();
        }

        private void incomeBtn_Click(object sender, EventArgs e)
        {
            ProjectForms.ProjectProgress frm = new ProjectForms.ProjectProgress();
            frm.ShowDialog();
        }

        private void maintenanceBtn_Click(object sender, EventArgs e)
        {
            ProjectForms.Maintenance frm = new ProjectForms.Maintenance();
            frm.ShowDialog();
        }


        private void closeForm()
        {
            this.closeForm();
        }

        private void schHome_Click(object sender, EventArgs e)
        {
            
            Dashboard frm = new Dashboard();
            frm.ShowDialog();
            
        }





        //
    }
}

