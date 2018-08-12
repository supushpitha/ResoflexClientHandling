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
    public partial class Project : MetroFramework.Forms.MetroForm
    {
        string clientName = "";

        public Project()
        {
            InitializeComponent();
        }

        public Project(string clientName)
        {
            InitializeComponent();

            this.clientName = clientName;
        }

        private void Project_Load(object sender, EventArgs e)
        {
            projectGrid.DataSource = getProjects();

            if (clientName != "")
                searchProjectByClientTxtBox.Text = clientName;

            projectGrid.Columns[0].Visible = false;
        }


        private DataTable getProjects()
        {
            DataTable table = new DataTable();

            MySqlDataReader reader = DBConnection.getData("select * from project");

            table.Load(reader);

            return table;
        }



        private void searchProjectTxtBox_TextChanged(object sender, EventArgs e)
        {
            string qry = "";
            string projectNameTxt = searchProjectTxtBox.Text;

            qry = "SELECT * FROM project WHERE name LIKE '%" + projectNameTxt + "%'";

            try
            {
                MySqlDataReader reader = DBConnection.getData(qry);

                if (reader.HasRows)
                {
                    System.Data.DataTable table = new System.Data.DataTable();

                    table.Load(reader);

                    projectGrid.DataSource = table;
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


        private void projectGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addProjectBtn_Click(object sender, EventArgs e)
        {
            UpdateProjectForm frm = new UpdateProjectForm();

            frm.ShowDialog();

            projectGrid.DataSource = getProjects();
        }

        private void updateProjectBtn_Click(object sender, EventArgs e)
        {
            ProjectUpdate frm = new ProjectUpdate();

            frm.ShowDialog();

            projectGrid.DataSource = getProjects();
        }

        private void searchProjectByClientTxtBox_TextChanged(object sender, EventArgs e)
        {
            string qry = "";
            string clientNameTxt = searchProjectByClientTxtBox.Text;

            qry = "SELECT * FROM project p inner join client c on p.client_id=c.client_id" +
                  " WHERE c.name LIKE '%" + clientNameTxt + "%'";

            try
            {
                MySqlDataReader reader = DBConnection.getData(qry);

                if (reader.HasRows)
                {
                    System.Data.DataTable table = new System.Data.DataTable();

                    table.Load(reader);

                    projectGrid.DataSource = table;
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
    }
}
