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
        private string clientName = "";
        private int clientId = 0;
        private int oldCount = 0;
        private List<Int32> projIds = new List<int>();
        private List<Int32> reqIds = new List<int>();

        public RequestForm()
        {
            InitializeComponent();
        }

        public RequestForm(string projectName)
        {
            InitializeComponent();

            this.projName = projectName;
        }

        public RequestForm(string clientName, int clientId)
        {
            InitializeComponent();

            this.clientName = clientName;
            this.clientId = clientId;
        }

        private void RequestForm_Load(object sender, EventArgs e)
        {
            fillClientCmbBoxes();
            fillProjectCmbBox();

            if (!projName.Equals(""))
            {
                searchTypeCmbBox.SelectedIndex = 0;
                SearchNameCmbBox.SelectedItem = projName;

                clientReqGrid.DataSource = getClientRequests();
                searchClientNameCmbBox.SelectedItem = null;
            }
            else if (!clientName.Equals(""))
            {
                searchTypeCmbBox.SelectedIndex = 1;
                SearchNameCmbBox.SelectedItem = clientName;

                searchClientNameCmbBox.SelectedItem = clientName;
            }
            else
            {
                changeReqGrid.DataSource = getChangeRequests();
                clientReqGrid.DataSource = getClientRequests();

                searchTypeCmbBox.SelectedItem = null;
                SearchNameCmbBox.SelectedItem = null;
                searchClientNameCmbBox.SelectedItem = null;
            }

            changeReqGrid.Columns[0].Visible = false;
            changeReqGrid.Columns[1].Visible = false;
        }
        
        private void fillProjectCmbBox()
        {
            MySqlDataReader reader = DBConnection.getData("SELECT proj_name as name FROM project");

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    addChangeReqProjCmbBox.Items.Add(reader.GetString(0));
                }
            }

            reader.Close();
        }

        private void fillClientCmbBoxes()
        {
            MySqlDataReader reader = DBConnection.getData("SELECT name as name FROM client");

            searchClientNameCmbBox.Items.Clear();
            addClientReqClientNameCmbBox.Items.Clear();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    searchClientNameCmbBox.Items.Add(reader.GetString(0));
                    addClientReqClientNameCmbBox.Items.Add(reader.GetString(0));
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
            MySqlDataReader reader = DBConnection.getData("SELECT p.proj_id, r.req_id, p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, r.started_dateTime as Started, r.ended_dateTime as Ended, r.urgent as Urgent, s.first_name as Dev " +
                "FROM proj_request r INNER JOIN project p ON r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id WHERE c.name='" + clientName + "' order by r.state asc, r.urgent desc;");

            DataTable table = new DataTable();

            table.Load(reader);

            return table;
        }

        private DataTable getChangeRequests()
        {
            MySqlDataReader reader = DBConnection.getData("SELECT p.proj_id, r.req_id, p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                "r.started_dateTime as Started, r.ended_dateTime as Ended, r.urgent as Urgent, s.first_name as Dev FROM proj_request r INNER JOIN project p ON " +
                "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id order by r.state asc, r.urgent desc limit 10;");
            
            DataTable table = new DataTable();

            table.Load(reader);

            return table;
        }

        private DataTable getChangeRequestsByProject(string project)
        {
            MySqlDataReader reader = DBConnection.getData("SELECT p.proj_id, r.req_id, p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, r.started_dateTime as Started, r.ended_dateTime as Ended, r.urgent as Urgent, s.first_name as Dev " +
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

                changeReqGrid.Columns[0].Visible = false;
                changeReqGrid.Columns[1].Visible = false;
                changeGridRowColors("Change");
                markSeen();
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
                        SearchNameCmbBox.Items.Add(reader.GetString(0));
                    }
                }

                reader.Close();
            }
        }

        private void showAllProjReqBtn_Click(object sender, EventArgs e)
        {
            searchTypeCmbBox.SelectedItem = null;
            SearchNameCmbBox.SelectedItem = null;

            changeReqGrid.DataSource = getChangeRequests();
            allRadioBtn.Checked = true;

            changeReqGrid.Columns[0].Visible = false;
            changeReqGrid.Columns[1].Visible = false;
            changeGridRowColors("Change");
            markSeen();
        }

        private void showAllClientReqBtn_Click(object sender, EventArgs e)
        {
            searchClientNameCmbBox.SelectedItem = null;

            clientReqGrid.DataSource = getClientRequests();
            clientAllRadioBtn.Checked = true;

            changeGridRowColors("Client");
        }

        private void searchClientNameCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchClientNameCmbBox.SelectedItem != null)
            {
                clientAllRadioBtn.Checked = true;
                clientReqGrid.DataSource = getClientRequestsByClient(searchClientNameCmbBox.SelectedItem.ToString());

                changeGridRowColors("Client");
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

                    changeReqGrid.Columns[0].Visible = false;
                    changeReqGrid.Columns[1].Visible = false;
                    changeGridRowColors("Change");
                    markSeen();

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

                    changeGridRowColors("Client");

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

            if (!projName.Equals(""))
            {
                allRadioBtn.Checked = true;
            }
            else if (!clientName.Equals(""))
            {
                clientAllRadioBtn.Checked = true;
            }
            else
            {
                allRadioBtn.Checked = true;
            }

            changeGridRowColors("Change");
            changeGridRowColors("Client");
            markSeen();

            checkNewChangeRequests();
        }

        private void checkNewChangeRequests()
        {
            if (!Userglobals.uname.Equals(""))
            {
                MySqlDataReader reader = DBConnection.getData("select p.proj_id, p.req_id from proj_request p where row(p.proj_id, p.req_id) not in " +
                                                                                    "(select s.proj_id, s.req_id from proj_req_seen s where s.staff_id=" + Userglobals.uid + ")");

                if (!reader.HasRows)
                {
                    newReqTile.Visible = false;
                }
                else
                {
                    int existingCount = 0;
                    int realCount = 0;

                    while (reader.Read())
                    {
                        realCount++;
                        int pId = reader.GetInt32(0);
                        int rId = reader.GetInt32(1);

                        foreach (DataGridViewRow row in changeReqGrid.Rows)
                        {
                            int projId = Int32.Parse(row.Cells[0].Value.ToString());
                            int reqId = Int32.Parse(row.Cells[1].Value.ToString());

                            if ((projId == pId) && (reqId == rId))
                            {
                                existingCount++;
                                break;
                            }
                        }
                    }

                    if (realCount == existingCount)
                    {
                        newReqTile.Visible = false;
                    }
                }

                reader.Close();
            }
            else
            {
                newReqTile.Visible = false;
            }
        }

        private void markSeen()
        {
            if (!Userglobals.uname.Equals(""))
            {
                if ((projIds.Count == 0) && (reqIds.Count == 0))
                {
                    MySqlDataReader reader = DBConnection.getData("select proj_id, req_id from proj_req_seen where staff_id=" + Userglobals.uid);

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            projIds.Add(reader.GetInt32(0));
                            reqIds.Add(reader.GetInt32(1));

                            oldCount++;
                        }
                    }

                    reader.Close();
                }

                foreach (DataGridViewRow row in changeReqGrid.Rows)
                {
                    int projId = Int32.Parse(row.Cells[0].Value.ToString());
                    int reqId = Int32.Parse(row.Cells[1].Value.ToString());
                    bool exists = false;

                    for (int i = 0; i < projIds.Count; i++)
                    {
                        if ((projIds[i] == projId) && (reqIds[i] == reqId))
                        {
                            exists = true;
                            break;
                        }
                    }

                    if (!exists)
                    {
                        projIds.Add(projId);
                        reqIds.Add(reqId);
                    }
                }
            }
        }

        public void changeGridRowColors(string gridName)
        {
            if (gridName.Equals("Change"))
            {
                foreach (DataGridViewRow row in changeReqGrid.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[5].Value))
                    {
                        row.DefaultCellStyle.ForeColor = Color.Green;
                        row.DefaultCellStyle.SelectionForeColor = Color.Green;
                    }
                    else if (Convert.ToBoolean(row.Cells[9].Value))
                    {
                        row.DefaultCellStyle.ForeColor = Color.Red;
                        row.DefaultCellStyle.SelectionForeColor = Color.Red;
                    }
                }
            }
            else if (gridName.Equals("Client"))
            {
                foreach (DataGridViewRow row in clientReqGrid.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[2].Value))
                    {
                        row.DefaultCellStyle.ForeColor = Color.Red;
                        row.DefaultCellStyle.SelectionForeColor = Color.Red;
                    }
                }
            }
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
                            qry = "SELECT p.proj_id, r.req_id, p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                        "IFNULL(r.started_dateTime, '') as Started, IFNULL(r.ended_dateTime, '') as Ended, r.urgent as Urgent, IFNULL(s.first_name, '') as Dev FROM proj_request r INNER JOIN project p ON " +
                        "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id where r.started_dateTime is not null and " +
                        "r.ended_dateTime is null and c.name='" + tmpName.ToString() + "' order by r.state asc, r.urgent desc;";
                        }
                        else if (tmpType.ToString().Equals("Project"))
                        {
                            qry = "SELECT p.proj_id, r.req_id, p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                        "IFNULL(r.started_dateTime, '') as Started, IFNULL(r.ended_dateTime, '') as Ended, r.urgent as Urgent, IFNULL(s.first_name, '') as Dev FROM proj_request r INNER JOIN project p ON " +
                        "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id where r.started_dateTime is not null and " +
                        "r.ended_dateTime is null and p.proj_name='" + tmpName.ToString() + "' order by r.state asc, r.urgent desc;";
                        }
                    }
                    else
                    {
                        qry = "SELECT p.proj_id, r.req_id, p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                        "IFNULL(r.started_dateTime, '') as Started, IFNULL(r.ended_dateTime, '') as Ended, r.urgent as Urgent, IFNULL(s.first_name, '') as Dev FROM proj_request r INNER JOIN project p ON " +
                        "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id where r.started_dateTime is not null and " +
                        "r.ended_dateTime is null and (c.name='" + tmpName.ToString() + "' or p.proj_name='" + tmpName.ToString() + "') order by r.state asc, r.urgent desc;";
                    }
                }
                else
                {
                    qry = "SELECT p.proj_id, r.req_id, p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                        "IFNULL(r.started_dateTime, '') as Started, IFNULL(r.ended_dateTime, '') as Ended, r.urgent as Urgent, IFNULL(s.first_name, '') as Dev FROM proj_request r INNER JOIN project p ON " +
                        "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id where r.started_dateTime is not null and " +
                        "r.ended_dateTime is null order by r.state asc, r.urgent desc;";
                }

                MySqlDataReader reader = DBConnection.getData(qry);
                DataTable table = new DataTable();

                table.Load(reader);

                changeReqGrid.DataSource = table;

                changeReqGrid.Columns[0].Visible = false;
                changeReqGrid.Columns[1].Visible = false;
                changeGridRowColors("Change");
                markSeen();
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
                            qry = "SELECT p.proj_id, r.req_id, p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                        "IFNULL(r.started_dateTime, '') as Started, IFNULL(r.ended_dateTime, '') as Ended, r.urgent as Urgent, IFNULL(s.first_name, '') as Dev FROM proj_request r INNER JOIN project p ON " +
                        "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id where c.name='" + tmpName.ToString() + "' " +
                        "order by r.state asc, r.urgent desc;";
                        }
                        else if (tmpType.ToString().Equals("Project"))
                        {
                            qry = "SELECT p.proj_id, r.req_id, p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                        "IFNULL(r.started_dateTime, '') as Started, IFNULL(r.ended_dateTime, '') as Ended, r.urgent as Urgent, IFNULL(s.first_name, '') as Dev FROM proj_request r INNER JOIN project p ON " +
                        "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id where p.proj_name='" + tmpName.ToString() + "' " +
                        "order by r.state asc, r.urgent desc;";
                        }
                    }
                    else
                    {
                        qry = "SELECT p.proj_id, r.req_id, p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                        "IFNULL(r.started_dateTime, '') as Started, IFNULL(r.ended_dateTime, '') as Ended, r.urgent as Urgent, IFNULL(s.first_name, '') as Dev FROM proj_request r INNER JOIN project p ON " +
                        "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id where (c.name='" + tmpName.ToString() + "' or p.proj_name='" + tmpName.ToString() + "') " +
                        "order by r.state asc, r.urgent desc;";
                    }
                }
                else
                {
                    qry = "SELECT p.proj_id, r.req_id, p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                        "IFNULL(r.started_dateTime, '') as Started, IFNULL(r.ended_dateTime, '') as Ended, r.urgent as Urgent, IFNULL(s.first_name, '') as Dev FROM proj_request r INNER JOIN project p ON " +
                        "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id order by r.state asc, r.urgent desc limit 10;";
                }

                MySqlDataReader reader = DBConnection.getData(qry);
                DataTable table = new DataTable();

                table.Load(reader);

                changeReqGrid.DataSource = table;

                changeReqGrid.Columns[0].Visible = false;
                changeReqGrid.Columns[1].Visible = false;
                changeGridRowColors("Change");
                markSeen();
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
                            qry = "SELECT p.proj_id, r.req_id, p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                        "IFNULL(r.started_dateTime, '') as Started, IFNULL(r.ended_dateTime, '') as Ended, r.urgent as Urgent, IFNULL(s.first_name, '') as Dev FROM proj_request r INNER JOIN project p ON " +
                        "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id where r.urgent=1 and c.name='" + tmpName.ToString() + "' order by r.state asc, r.urgent desc;";
                        }
                        else if (tmpType.ToString().Equals("Project"))
                        {
                            qry = "SELECT p.proj_id, r.req_id, p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                        "IFNULL(r.started_dateTime, '') as Started, IFNULL(r.ended_dateTime, '') as Ended, r.urgent as Urgent, IFNULL(s.first_name, '') as Dev FROM proj_request r INNER JOIN project p ON " +
                        "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id where r.urgent=1 and p.proj_name='" + tmpName.ToString() + "' order by r.state asc, r.urgent desc;";
                        }
                    }
                    else
                    {
                        qry = "SELECT p.proj_id, r.req_id, p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                        "IFNULL(r.started_dateTime, '') as Started, IFNULL(r.ended_dateTime, '') as Ended, r.urgent as Urgent, IFNULL(s.first_name, '') as Dev FROM proj_request r INNER JOIN project p ON " +
                        "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id where r.urgent=1 and (c.name='" + tmpName.ToString() + "' or p.proj_name='" + tmpName.ToString() + "') " +
                        "order by r.state asc, r.urgent desc;";
                    }
                }
                else
                {
                    qry = "SELECT p.proj_id, r.req_id, p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                        "IFNULL(r.started_dateTime, '') as Started, IFNULL(r.ended_dateTime, '') as Ended, r.urgent as Urgent, IFNULL(s.first_name, '') as Dev FROM proj_request r INNER JOIN project p ON " +
                        "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id where r.urgent=1 order by r.state asc, r.urgent desc;";
                }

                MySqlDataReader reader = DBConnection.getData(qry);
                DataTable table = new DataTable();

                table.Load(reader);

                changeReqGrid.DataSource = table;

                changeReqGrid.Columns[0].Visible = false;
                changeReqGrid.Columns[1].Visible = false;
                changeGridRowColors("Change");
                markSeen();
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
                            qry = "SELECT p.proj_id, r.req_id, p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                        "IFNULL(r.started_dateTime, '') as Started, IFNULL(r.ended_dateTime, '') as Ended, r.urgent as Urgent, IFNULL(s.first_name, '') as Dev FROM proj_request r INNER JOIN project p ON " +
                        "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id where r.state=1 and c.name='" + tmpName.ToString() + "' order by r.state asc, r.urgent desc;";
                        }
                        else if (tmpType.ToString().Equals("Project"))
                        {
                            qry = "SELECT p.proj_id, r.req_id, p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                        "IFNULL(r.started_dateTime, '') as Started, IFNULL(r.ended_dateTime, '') as Ended, r.urgent as Urgent, IFNULL(s.first_name, '') as Dev FROM proj_request r INNER JOIN project p ON " +
                        "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id where r.state=1 and p.proj_name='" + tmpName.ToString() + "' order by r.state asc, r.urgent desc;";
                        }
                    }
                    else
                    {
                        qry = "SELECT p.proj_id, r.req_id, p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                        "IFNULL(r.started_dateTime, '') as Started, IFNULL(r.ended_dateTime, '') as Ended, r.urgent as Urgent, IFNULL(s.first_name, '') as Dev FROM proj_request r INNER JOIN project p ON " +
                        "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id where r.state=1 and (c.name='" + tmpName.ToString() + "' or p.proj_name='" + tmpName.ToString() + "') " +
                        "order by r.state asc, r.urgent desc;";
                    }
                }
                else
                {
                    qry = "SELECT p.proj_id, r.req_id, p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, " +
                        "IFNULL(r.started_dateTime, '') as Started, IFNULL(r.ended_dateTime, '') as Ended, r.urgent as Urgent, IFNULL(s.first_name, '') as Dev FROM proj_request r INNER JOIN project p ON " +
                        "r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON r.staff_id=s.staff_id where r.state=1 order by r.state asc, r.urgent desc;";
                }

                MySqlDataReader reader = DBConnection.getData(qry);
                DataTable table = new DataTable();

                table.Load(reader);

                changeReqGrid.DataSource = table;

                changeReqGrid.Columns[0].Visible = false;
                changeReqGrid.Columns[1].Visible = false;
                changeGridRowColors("Change");
                markSeen();
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

                changeGridRowColors("Client");
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

                changeGridRowColors("Client");
            }
        }

        private void changeReqGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (dgv.CurrentRow.Selected)
            {
                if (Userglobals.uname.Equals(""))
                {
                    MessageBox.Show("You must Login first!", "Develop change requests", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    if (Userglobals.uid > 0)
                    {
                        int uid = Userglobals.uid;
                        Object startedDT = changeReqGrid.Rows[e.RowIndex].Cells[7].Value;
                        Object endedDT = changeReqGrid.Rows[e.RowIndex].Cells[8].Value;
                        DateTime dt;
                        int projId = Int32.Parse(changeReqGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                        int reqId = Int32.Parse(changeReqGrid.Rows[e.RowIndex].Cells[1].Value.ToString());

                        if (!DateTime.TryParse(startedDT.ToString(), out dt))
                        {
                            DialogResult result = MessageBox.Show("Start coding this change request NOW?\n" + uid, "Start Developing Change Requests", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            switch (result)
                            {
                                case DialogResult.Yes:

                                    ProjectRequest startReq = new ProjectRequest(new Project(projId), reqId, new Staff(uid));

                                    Database.startCodingChangeRequest(startReq);

                                    changeReqGrid.DataSource = getChangeRequests();

                                    changeReqGrid.Columns[0].Visible = false;
                                    changeReqGrid.Columns[1].Visible = false;
                                    markSeen();

                                    addReqNotify.Icon = SystemIcons.Application;
                                    addReqNotify.BalloonTipText = "Change Request Development Started!";
                                    addReqNotify.ShowBalloonTip(1000);

                                    break;

                                case DialogResult.No:
                                    break;
                                default:
                                    break;
                            }
                        }
                        else if (!DateTime.TryParse(endedDT.ToString(), out dt))
                        {
                            DialogResult result = MessageBox.Show("End coding this change request NOW?\n" + uid, "End Developing Change Requests", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            switch (result)
                            {
                                case DialogResult.Yes:

                                    ProjectRequest endReq = new ProjectRequest(new Project(projId), reqId, new Staff(uid));

                                    Database.endCodingChangeRequest(endReq);

                                    changeReqGrid.DataSource = getChangeRequests();

                                    changeReqGrid.Columns[0].Visible = false;
                                    changeReqGrid.Columns[1].Visible = false;
                                    changeGridRowColors("Change");
                                    markSeen();

                                    addReqNotify.Icon = SystemIcons.Application;
                                    addReqNotify.BalloonTipText = "Change Request Development Ended!";
                                    addReqNotify.ShowBalloonTip(1000);

                                    break;

                                case DialogResult.No:
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("This Change Request is already Developed!\n" + uid, "Developing Change Requests", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                }
            }
        }

        private void RequestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((projIds.Count > 0) && (projIds.Count == reqIds.Count) && Userglobals.uid > 0)
            {
                if (oldCount != 0)
                {
                    projIds.RemoveRange(0, oldCount);
                    reqIds.RemoveRange(0, oldCount);
                }

                Database.markSeenReq(projIds, reqIds, Userglobals.uid);
            }
        }

        private void newReqTile_Click(object sender, EventArgs e)
        {
            if ((projIds.Count > 0) && (projIds.Count == reqIds.Count) && Userglobals.uid > 0)
            {
                if (oldCount != 0)
                {
                    projIds.RemoveRange(0, oldCount);
                    reqIds.RemoveRange(0, oldCount);

                    oldCount = 0;
                }

                Database.markSeenReq(projIds, reqIds, Userglobals.uid);

                projIds.RemoveRange(0, projIds.Count);
                reqIds.RemoveRange(0, reqIds.Count);
            }

            MySqlDataReader reader = DBConnection.getData("SELECT p.proj_id, r.req_id, p.proj_name as Project, c.name as Client, r.request as Request, r.state as State, r.added_date as Added, r.started_dateTime as Started, " +
                "r.ended_dateTime as Ended, r.urgent as Urgent, s.first_name as Dev FROM proj_request r INNER JOIN project p ON r.proj_id=p.proj_id INNER JOIN client c ON p.client_id=c.client_id LEFT JOIN staff s ON " +
                "r.staff_id=s.staff_id where row(r.proj_id, r.req_id) not in (select s.proj_id, s.req_id from proj_req_seen s where s.staff_id=" + Userglobals.uid + ") order by r.state asc, r.urgent desc;");

            DataTable table = new DataTable();

            table.Load(reader);

            changeReqGrid.DataSource = table;

            changeReqGrid.Columns[0].Visible = false;
            changeReqGrid.Columns[1].Visible = false;
            changeGridRowColors("Change");
            newReqTile.Visible = false;
            markSeen();
        }
    }
}
