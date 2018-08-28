using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;
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

namespace ResoflexClientHandlingSystem.RequestForms
{
    public partial class RequestForm : MetroFramework.Forms.MetroForm
    {
        private string projName = "";

        public RequestForm()
        {
            InitializeComponent();
        }

        public RequestForm(string projectName)
        {
            InitializeComponent();

            this.projName = projectName;
        }

        private void RequestForm_Load(object sender, EventArgs e)
        {
            verticalLineLbl.AutoSize = false;
            verticalLineLbl.Width = 2;
            verticalLineLbl.Height = 900;
            verticalLineLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            fillClientCmbBoxes();
            fillProjectCmbBox();
            
            clientReqGrid.DataSource = getClientRequests();

            searchTypeCmbBox.SelectedIndex = 0;

            if (!projName.Equals(""))
            {
                SearchNameCmbBox.SelectedItem = projName;
                changeReqGrid.DataSource = getChangeRequestsByProject(projName);
            }
            else
            {
                changeReqGrid.DataSource = getChangeRequests();
            }
        }

        private void fillProjectCmbBox()
        {
            MySqlDataReader reader = DBConnection.getData("SELECT proj_name as name FROM project");

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    addChangeReqProjCmbBox.Items.Add(reader.GetString("name"));
                }
            }

            reader.Close();
        }

        private void fillClientCmbBoxes()
        {
            MySqlDataReader reader = DBConnection.getData("SELECT name as name FROM client");

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    searchClientNameCmbBox.Items.Add(reader.GetString("name"));
                    addClientReqClientNameCmbBox.Items.Add(reader.GetString("name"));
                }
            }

            reader.Close();
        }

        private DataTable getClientRequests()
        {
            MySqlDataReader reader = DBConnection.getData("SELECT c.name as Name, cr.request as Request, cr.importance as Importance FROM client_request cr INNER JOIN client c " +
                "ON cr.client_id=c.client_id;");
            
            DataTable table = new DataTable();

            table.Load(reader);

            return table;
        }

        private DataTable getClientRequestsByClient(string clientName)
        {
            MySqlDataReader reader = DBConnection.getData("SELECT c.name as Name, cr.request as Request, cr.importance as Importance FROM client_request cr INNER JOIN client c " +
                "ON cr.client_id=c.client_id WHERE c.name='" + clientName + "'");

            DataTable table = new DataTable();

            table.Load(reader);

            return table;
        }

        private DataTable getChangeRequestsByClient(string clientName)
        {
            MySqlDataReader reader = DBConnection.getData("SELECT p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, r.started_dateTime as Started, r.ended_dateTime as Ended, r.urgent as Urgent, s.first_name as Dev " +
                "FROM proj_request r INNER JOIN project p ON r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id WHERE c.name='" + clientName + "';");

            DataTable table = new DataTable();

            table.Load(reader);

            return table;
        }

        private DataTable getChangeRequests()
        {
            MySqlDataReader reader = DBConnection.getData("SELECT p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, r.started_dateTime as Started, r.ended_dateTime as Ended, r.urgent as Urgent, s.first_name as Dev " +
                "FROM proj_request r INNER JOIN project p ON r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id;");
            
            DataTable table = new DataTable();

            table.Load(reader);

            return table;
        }

        private DataTable getChangeRequestsByProject(string project)
        {
            MySqlDataReader reader = DBConnection.getData("SELECT p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, r.started_dateTime as Started, r.ended_dateTime as Ended, r.urgent as Urgent, s.first_name as Dev " +
                "FROM proj_request r INNER JOIN project p ON r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id WHERE p.proj_name='" + project + "';");

            DataTable table = new DataTable();

            table.Load(reader);

            return table;
        }

        private void SearchNameCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = searchTypeCmbBox.SelectedItem.ToString();

            if (type.Equals("Client"))
            {
                changeReqGrid.DataSource = getChangeRequestsByClient(SearchNameCmbBox.SelectedItem.ToString());
            }
            else if (type.Equals("Project"))
            {
                changeReqGrid.DataSource = getChangeRequestsByProject(SearchNameCmbBox.SelectedItem.ToString());
            }
        }

        private void searchTypeCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = searchTypeCmbBox.SelectedItem.ToString();
            MySqlDataReader reader = null;

            if (type.Equals("Client"))
            {
                reader = DBConnection.getData("SELECT name as name FROM client");
            }
            else if (type.Equals("Project"))
            {
                reader = DBConnection.getData("SELECT proj_name as name FROM project");
            }

            SearchNameCmbBox.Items.Clear();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    SearchNameCmbBox.Items.Add(reader.GetString("name"));
                }
            }

            reader.Close();
        }

        private void showAllProjReqBtn_Click(object sender, EventArgs e)
        {
            changeReqGrid.DataSource = getChangeRequests();
        }

        private void showAllClientReqBtn_Click(object sender, EventArgs e)
        {
            clientReqGrid.DataSource = getClientRequests();
        }

        private void searchClientNameCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            clientReqGrid.DataSource = getClientRequestsByClient(searchClientNameCmbBox.SelectedItem.ToString());
        }

        private void addNewChangeReqBtn_Click(object sender, EventArgs e)
        {
            string projectName = addChangeReqProjCmbBox.SelectedItem.ToString();
            
            if (addReqTxtBox.Text == null || addReqTxtBox.Text == "")
            {
                MessageBox.Show("There must be a request!", "Save Change Request", MessageBoxButtons.OK, MessageBoxIcon.Error);

                addReqTxtBox.Focus();
            }
            else
            {
                string request = addReqTxtBox.Text;
                bool urgent = addReqUrgentCheckBox.Checked;
                int projId = 0;

                try
                {
                    MySqlDataReader reader = DBConnection.getData("Select * from project where proj_name='" + projectName + "'");

                    while (reader.Read())
                    {
                        projId = reader.GetInt32("proj_id");
                    }

                    reader.Close();

                    ProjectRequest req = new ProjectRequest(new Project(projId), request, urgent);

                    Database.saveChangerequest(req);

                    changeReqGrid.DataSource = getChangeRequests();

                    addReqNotify.Icon = SystemIcons.Application;
                    addReqNotify.BalloonTipText = "Change Request Successfully added!";
                    addReqNotify.ShowBalloonTip(1000);

                    addChangeReqProjCmbBox.SelectedIndex = 0;
                    addReqUrgentCheckBox.Checked = false;
                    addReqTxtBox.Text = "";
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Something went wrong!\n" + exc, "Save Change Request", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
