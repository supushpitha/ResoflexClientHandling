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
            clientReqGrid.DataSource = getClientRequests();
            
            if (!projName.Equals(""))
            {
                searchTypeCmbBox.SelectedIndex = 0;
                SearchNameCmbBox.SelectedItem = projName;
                changeReqGrid.DataSource = getChangeRequestsByProject(projName);
            }
            else
            {
                changeReqGrid.DataSource = getChangeRequests();

                searchTypeCmbBox.SelectedItem = null;
                SearchNameCmbBox.SelectedItem = null;
                searchClientNameCmbBox.SelectedItem = null;
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
                "ON cr.client_id=c.client_id order by cr.importance desc limit 10;");
            
            DataTable table = new DataTable();

            table.Load(reader);

            return table;
        }

        private DataTable getClientRequestsByClient(string clientName)
        {
            MySqlDataReader reader = DBConnection.getData("SELECT c.name as Name, cr.request as Request, cr.importance as Importance FROM client_request cr INNER JOIN client c " +
                "ON cr.client_id=c.client_id WHERE c.name='" + clientName + "' order by cr.importance desc");

            DataTable table = new DataTable();

            table.Load(reader);

            return table;
        }

        private DataTable getChangeRequestsByClient(string clientName)
        {
            MySqlDataReader reader = DBConnection.getData("SELECT p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, r.started_dateTime as Started, r.ended_dateTime as Ended, r.urgent as Urgent, s.first_name as Dev " +
                "FROM proj_request r INNER JOIN project p ON r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id WHERE c.name='" + clientName + "' order by r.state asc, r.urgent desc;");

            DataTable table = new DataTable();

            table.Load(reader);

            return table;
        }

        private DataTable getChangeRequests()
        {
            MySqlDataReader reader = DBConnection.getData("SELECT p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                "r.started_dateTime as Started, r.ended_dateTime as Ended, r.urgent as Urgent, s.first_name as Dev FROM proj_request r INNER JOIN project p ON " +
                "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id order by r.state asc, r.urgent desc limit 10;");
            
            DataTable table = new DataTable();

            table.Load(reader);

            return table;
        }

        private DataTable getChangeRequestsByProject(string project)
        {
            MySqlDataReader reader = DBConnection.getData("SELECT p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, r.started_dateTime as Started, r.ended_dateTime as Ended, r.urgent as Urgent, s.first_name as Dev " +
                "FROM proj_request r INNER JOIN project p ON r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id WHERE p.proj_name='" + project + "' order by r.state asc, r.urgent desc;");

            DataTable table = new DataTable();

            table.Load(reader);

            return table;
        }

        private void SearchNameCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((searchTypeCmbBox.SelectedItem != null) && (SearchNameCmbBox.SelectedItem != null))
            {
                string type = searchTypeCmbBox.SelectedItem.ToString();
                allRadioBtn.Checked = true;

                if (type.Equals("Client"))
                {
                    changeReqGrid.DataSource = getChangeRequestsByClient(SearchNameCmbBox.SelectedItem.ToString());
                }
                else if (type.Equals("Project"))
                {
                    changeReqGrid.DataSource = getChangeRequestsByProject(SearchNameCmbBox.SelectedItem.ToString());
                }
            }
        }

        private void searchTypeCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object tmp = searchTypeCmbBox.SelectedItem;

            if (tmp != null)
            {
                string type = tmp.ToString();
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
        }

        private void showAllProjReqBtn_Click(object sender, EventArgs e)
        {
            changeReqGrid.DataSource = getChangeRequests();
            allRadioBtn.Checked = true;

            searchTypeCmbBox.SelectedItem = null;
            SearchNameCmbBox.SelectedItem = null;
        }

        private void showAllClientReqBtn_Click(object sender, EventArgs e)
        {
            clientReqGrid.DataSource = getClientRequests();
            clientAllRadioBtn.Checked = true;

            searchClientNameCmbBox.SelectedItem = null;
        }

        private void searchClientNameCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchClientNameCmbBox.SelectedItem != null)
            {
                clientAllRadioBtn.Checked = true;
                clientReqGrid.DataSource = getClientRequestsByClient(searchClientNameCmbBox.SelectedItem.ToString());
            }
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

                    Database.saveChangeRequest(req);

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

        private void addNewClientReqBtn_Click(object sender, EventArgs e)
        {
            string clientName = addClientReqClientNameCmbBox.SelectedItem.ToString();

            if (addClientReqTxtBox.Text == null || addClientReqTxtBox.Text == "")
            {
                MessageBox.Show("There must be a request!", "Save Client Request", MessageBoxButtons.OK, MessageBoxIcon.Error);

                addReqTxtBox.Focus();
            }
            else
            {
                string request = addClientReqTxtBox.Text;
                bool urgent = addClientReqImportCheckBox.Checked;
                int clientId = 0;

                try
                {
                    MySqlDataReader reader = DBConnection.getData("Select * from client where name='" + clientName + "'");

                    while (reader.Read())
                    {
                        clientId = reader.GetInt32("client_id");
                    }

                    reader.Close();
                    
                    ClientRequest req = new ClientRequest(new Client(clientId), request, urgent);

                    Database.saveClientRequest(req);

                    clientReqGrid.DataSource = getClientRequests();

                    addReqNotify.Icon = SystemIcons.Application;
                    addReqNotify.BalloonTipText = "Client Request Successfully added!";
                    addReqNotify.ShowBalloonTip(1000);

                    addClientReqClientNameCmbBox.SelectedIndex = 0;
                    addClientReqImportCheckBox.Checked = false;
                    addClientReqTxtBox.Text = "";
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Something went wrong!\n" + exc, "Save Client Request", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addReqTxtBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (addReqTxtBox.Text.Equals(""))
            {
                e.Cancel = true;

                errorMsg = "There must be a request!";

                addReqTxtBox.Select(0, addReqTxtBox.Text.Length);

                this.errorProviderReq.SetError(addReqTxtBox, errorMsg);
            }
        }

        private void addReqTxtBox_Validated(object sender, EventArgs e)
        {
            errorProviderReq.SetError(addReqTxtBox, "");
            errorProviderReq.Clear();
        }

        private void addClientReqTxtBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (addClientReqTxtBox.Text.Equals(""))
            {
                e.Cancel = true;

                errorMsg = "There must be a request!";

                addClientReqTxtBox.Select(0, addClientReqTxtBox.Text.Length);

                this.errorProviderReq.SetError(addClientReqTxtBox, errorMsg);
            }
        }

        private void addClientReqTxtBox_Validated(object sender, EventArgs e)
        {
            errorProviderReq.SetError(addClientReqTxtBox, "");
            errorProviderReq.Clear();
        }

        private void RequestForm_Shown(object sender, EventArgs e)
        {
            verticalLineLbl.AutoSize = false;
            verticalLineLbl.Width = 2;
            verticalLineLbl.Height = 890;
            verticalLineLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            fillClientCmbBoxes();
            fillProjectCmbBox();

            allRadioBtn.Checked = true;
            //clientAllRadioBtn.Checked = true;
        }

        private void metroRadioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            if (onGoingRadioBtn.Checked)
            {
                string qry = "";
                Object tmpName = SearchNameCmbBox.SelectedItem;

                if (tmpName != null)
                {
                    Object tmpType = searchTypeCmbBox.SelectedItem;

                    if (tmpType != null)
                    {
                        if (tmpType.ToString().Equals("Client"))
                        {
                            qry = "SELECT p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                        "IFNULL(r.started_dateTime, '') as Started, IFNULL(r.ended_dateTime, '') as Ended, r.urgent as Urgent, IFNULL(s.first_name, '') as Dev FROM proj_request r INNER JOIN project p ON " +
                        "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id where r.started_dateTime is not null and " +
                        "r.ended_dateTime is null and c.name='" + tmpName.ToString() + "' order by r.state asc, r.urgent desc;";
                        }
                        else if (tmpType.ToString().Equals("Project"))
                        {
                            qry = "SELECT p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                        "IFNULL(r.started_dateTime, '') as Started, IFNULL(r.ended_dateTime, '') as Ended, r.urgent as Urgent, IFNULL(s.first_name, '') as Dev FROM proj_request r INNER JOIN project p ON " +
                        "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id where r.started_dateTime is not null and " +
                        "r.ended_dateTime is null and p.proj_name='" + tmpName.ToString() + "' order by r.state asc, r.urgent desc;";
                        }
                    }
                    else
                    {
                        qry = "SELECT p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                        "IFNULL(r.started_dateTime, '') as Started, IFNULL(r.ended_dateTime, '') as Ended, r.urgent as Urgent, IFNULL(s.first_name, '') as Dev FROM proj_request r INNER JOIN project p ON " +
                        "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id where r.started_dateTime is not null and " +
                        "r.ended_dateTime is null and (c.name='" + tmpName.ToString() + "' or p.proj_name='" + tmpName.ToString() + "') order by r.state asc, r.urgent desc;";
                    }
                }
                else
                {
                    qry = "SELECT p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                        "IFNULL(r.started_dateTime, '') as Started, IFNULL(r.ended_dateTime, '') as Ended, r.urgent as Urgent, IFNULL(s.first_name, '') as Dev FROM proj_request r INNER JOIN project p ON " +
                        "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id where r.started_dateTime is not null and " +
                        "r.ended_dateTime is null order by r.state asc, r.urgent desc;";
                }

                MySqlDataReader reader = DBConnection.getData(qry);
                DataTable table = new DataTable();

                table.Load(reader);

                changeReqGrid.DataSource = table;
            }
        }

        private void allRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (allRadioBtn.Checked)
            {
                string qry = "";
                Object tmpName = SearchNameCmbBox.SelectedItem;

                if (tmpName != null)
                {
                    Object tmpType = searchTypeCmbBox.SelectedItem;

                    if (tmpType != null)
                    {
                        if (tmpType.ToString().Equals("Client"))
                        {
                            qry = "SELECT p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                        "IFNULL(r.started_dateTime, '') as Started, IFNULL(r.ended_dateTime, '') as Ended, r.urgent as Urgent, IFNULL(s.first_name, '') as Dev FROM proj_request r INNER JOIN project p ON " +
                        "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id where c.name='" + tmpName.ToString() + "' " +
                        "order by r.state asc, r.urgent desc;";
                        }
                        else if (tmpType.ToString().Equals("Project"))
                        {
                            qry = "SELECT p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                        "IFNULL(r.started_dateTime, '') as Started, IFNULL(r.ended_dateTime, '') as Ended, r.urgent as Urgent, IFNULL(s.first_name, '') as Dev FROM proj_request r INNER JOIN project p ON " +
                        "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id where p.proj_name='" + tmpName.ToString() + "' " +
                        "order by r.state asc, r.urgent desc;";
                        }
                    }
                    else
                    {
                        qry = "SELECT p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                        "IFNULL(r.started_dateTime, '') as Started, IFNULL(r.ended_dateTime, '') as Ended, r.urgent as Urgent, IFNULL(s.first_name, '') as Dev FROM proj_request r INNER JOIN project p ON " +
                        "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id where (c.name='" + tmpName.ToString() + "' or p.proj_name='" + tmpName.ToString() + "') " +
                        "order by r.state asc, r.urgent desc;";
                    }
                }
                else
                {
                    qry = "SELECT p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                        "IFNULL(r.started_dateTime, '') as Started, IFNULL(r.ended_dateTime, '') as Ended, r.urgent as Urgent, IFNULL(s.first_name, '') as Dev FROM proj_request r INNER JOIN project p ON " +
                        "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id order by r.state asc, r.urgent desc limit 10;";
                }

                MySqlDataReader reader = DBConnection.getData(qry);
                DataTable table = new DataTable();

                table.Load(reader);

                changeReqGrid.DataSource = table;
            }
        }

        private void urgentRadioBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (urgentRadioBtn.Checked)
            {
                string qry = "";
                Object tmpName = SearchNameCmbBox.SelectedItem;

                if (tmpName != null)
                {
                    Object tmpType = searchTypeCmbBox.SelectedItem;

                    if (tmpType != null)
                    {
                        if (tmpType.ToString().Equals("Client"))
                        {
                            qry = "SELECT p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                        "IFNULL(r.started_dateTime, '') as Started, IFNULL(r.ended_dateTime, '') as Ended, r.urgent as Urgent, IFNULL(s.first_name, '') as Dev FROM proj_request r INNER JOIN project p ON " +
                        "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id where r.urgent=1 and c.name='" + tmpName.ToString() + "' order by r.state asc, r.urgent desc;";
                        }
                        else if (tmpType.ToString().Equals("Project"))
                        {
                            qry = "SELECT p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                        "IFNULL(r.started_dateTime, '') as Started, IFNULL(r.ended_dateTime, '') as Ended, r.urgent as Urgent, IFNULL(s.first_name, '') as Dev FROM proj_request r INNER JOIN project p ON " +
                        "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id where r.urgent=1 and p.proj_name='" + tmpName.ToString() + "' order by r.state asc, r.urgent desc;";
                        }
                    }
                    else
                    {
                        qry = "SELECT p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                        "IFNULL(r.started_dateTime, '') as Started, IFNULL(r.ended_dateTime, '') as Ended, r.urgent as Urgent, IFNULL(s.first_name, '') as Dev FROM proj_request r INNER JOIN project p ON " +
                        "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id where r.urgent=1 and (c.name='" + tmpName.ToString() + "' or p.proj_name='" + tmpName.ToString() + "') " +
                        "order by r.state asc, r.urgent desc;";
                    }
                }
                else
                {
                    qry = "SELECT p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                        "IFNULL(r.started_dateTime, '') as Started, IFNULL(r.ended_dateTime, '') as Ended, r.urgent as Urgent, IFNULL(s.first_name, '') as Dev FROM proj_request r INNER JOIN project p ON " +
                        "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id where r.urgent=1 order by r.state asc, r.urgent desc;";
                }

                MySqlDataReader reader = DBConnection.getData(qry);
                DataTable table = new DataTable();

                table.Load(reader);

                changeReqGrid.DataSource = table;
            }
        }

        private void completeRadioBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (completeRadioBtn.Checked)
            {
                string qry = "";
                Object tmpName = SearchNameCmbBox.SelectedItem;

                if (tmpName != null)
                {
                    Object tmpType = searchTypeCmbBox.SelectedItem;

                    if (tmpType != null)
                    {
                        if (tmpType.ToString().Equals("Client"))
                        {
                            qry = "SELECT p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                        "IFNULL(r.started_dateTime, '') as Started, IFNULL(r.ended_dateTime, '') as Ended, r.urgent as Urgent, IFNULL(s.first_name, '') as Dev FROM proj_request r INNER JOIN project p ON " +
                        "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id where r.state=1 and c.name='" + tmpName.ToString() + "' order by r.state asc, r.urgent desc;";
                        }
                        else if (tmpType.ToString().Equals("Project"))
                        {
                            qry = "SELECT p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                        "IFNULL(r.started_dateTime, '') as Started, IFNULL(r.ended_dateTime, '') as Ended, r.urgent as Urgent, IFNULL(s.first_name, '') as Dev FROM proj_request r INNER JOIN project p ON " +
                        "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id where r.state=1 and p.proj_name='" + tmpName.ToString() + "' order by r.state asc, r.urgent desc;";
                        }
                    }
                    else
                    {
                        qry = "SELECT p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                        "IFNULL(r.started_dateTime, '') as Started, IFNULL(r.ended_dateTime, '') as Ended, r.urgent as Urgent, IFNULL(s.first_name, '') as Dev FROM proj_request r INNER JOIN project p ON " +
                        "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id where r.state=1 and (c.name='" + tmpName.ToString() + "' or p.proj_name='" + tmpName.ToString() + "') " +
                        "order by r.state asc, r.urgent desc;";
                    }
                }
                else
                {
                    qry = "SELECT p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                        "IFNULL(r.started_dateTime, '') as Started, IFNULL(r.ended_dateTime, '') as Ended, r.urgent as Urgent, IFNULL(s.first_name, '') as Dev FROM proj_request r INNER JOIN project p ON " +
                        "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id where r.state=1 order by r.state asc, r.urgent desc;";
                }

                MySqlDataReader reader = DBConnection.getData(qry);
                DataTable table = new DataTable();

                table.Load(reader);

                changeReqGrid.DataSource = table;
            }
        }

        private void importanceRadioBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (importanceRadioBtn.Checked)
            {
                string qry = "";
                Object tmpName = searchClientNameCmbBox.SelectedItem;

                if (tmpName != null)
                {
                    string clientName = tmpName.ToString();

                    qry = "SELECT c.name as Name, cr.request as Request, cr.importance as Importance FROM client_request cr INNER JOIN client c " +
                            "ON cr.client_id=c.client_id WHERE cr.importance=1 and c.name='" + clientName + "' order by cr.importance desc;";
                }
                else
                {
                    qry = "SELECT c.name as Name, cr.request as Request, cr.importance as Importance FROM client_request cr INNER JOIN client c " +
                            "ON cr.client_id=c.client_id WHERE cr.importance=1 order by cr.importance desc limit 10;";
                }

                MySqlDataReader reader = DBConnection.getData(qry);
                DataTable table = new DataTable();

                table.Load(reader);

                clientReqGrid.DataSource = table;
            }
        }

        private void clientAllRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (clientAllRadioBtn.Checked)
            {
                string qry = "";
                Object tmpName = searchClientNameCmbBox.SelectedItem;

                if (tmpName != null)
                {
                    string clientName = tmpName.ToString();

                    qry = "SELECT c.name as Name, cr.request as Request, cr.importance as Importance FROM client_request cr INNER JOIN client c " +
                            "ON cr.client_id=c.client_id WHERE c.name='" + clientName + "' order by cr.importance desc;";
                }
                else
                {
                    qry = "SELECT c.name as Name, cr.request as Request, cr.importance as Importance FROM client_request cr INNER JOIN client c " +
                            "ON cr.client_id=c.client_id order by cr.importance desc limit 10;";
                }

                MySqlDataReader reader = DBConnection.getData(qry);
                DataTable table = new DataTable();

                table.Load(reader);

                clientReqGrid.DataSource = table;
            }
        }
    }
}
