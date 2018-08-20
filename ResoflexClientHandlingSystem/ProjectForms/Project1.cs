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

            projectGrid.Columns[0].Visible = false;
        }


        //tile

        private void fillTiles(int projectID)
        {
            try
            {
                MySqlDataReader reader = DBConnection.getData("count =" + projectID);

                while (reader.Read())
                {
                    projIdTile.Text = reader.GetInt32("count").ToString();
                }

                reader.Close();

                reader = DBConnection.getData("select proj_id from project where proj_id=" + projectID);

                while (reader.Read())
                {
                    warrantyTile.Text = reader.GetInt32("count").ToString();
                }

                reader.Close();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Client Retreive", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //noOfVisitsTile.Text = "" + 15;
            totExpenceTile.Text = "Rs." + 13000.00;
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

            MySqlDataReader reader = DBConnection.getData("select proj_id, proj_name as Name, description as Description, proj_sub_cat_id as Category, first_init_date as First_Install, training_comp_first_end_date as 1st_Traning_Complete, training_comp_second_end_date, warranty_start_date as Warranty_from, warranty_terms as Warranty_terms, support_terms as Support_terms, visit_terms as Visit_terms from project");

            table.Load(reader);

            return table;
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

     
        //tiles






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
       

            qry = "SELECT p.proj_id, " +
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





        //
    }
}

