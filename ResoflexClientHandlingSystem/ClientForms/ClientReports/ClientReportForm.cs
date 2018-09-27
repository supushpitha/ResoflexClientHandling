using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.ClientForms.ClientReports;
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

namespace ResoflexClientHandlingSystem.ClientForms
{
    public partial class ClientReportForm : MetroFramework.Forms.MetroForm
    {
        public ClientReportForm()
        {
            InitializeComponent();
        }

        private void ClientReportForm_Load(object sender, EventArgs e)
        {
            horizontalLineLbl.AutoSize = false;
            horizontalLineLbl.Width = 280;
            horizontalLineLbl.Height = 2;
            horizontalLineLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            horizontalLineLblTwo.AutoSize = false;
            horizontalLineLblTwo.Width = 280;
            horizontalLineLblTwo.Height = 2;
            horizontalLineLblTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            fillClientCmbBox();

            clientCmbBox.SelectedItem = null;
        }

        private void fillClientCmbBox()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("SELECT client_id, name as name FROM client");

            table.Load(reader);

            clientCmbBox.DataSource = table;
            clientCmbBox.ValueMember = "client_id";
            clientCmbBox.DisplayMember = "name";
        }

        private void ClientReportForm_Shown(object sender, EventArgs e)
        {
            clientReportViewer.Focus();
        }

        private void projectProfileBtn_Click(object sender, EventArgs e)
        {
            int clientId = Int32.Parse(clientCmbBox.SelectedValue.ToString());

            string qry = "SELECT p.proj_id, p.proj_name, c.sub_cat_name, p.first_init_date, IFNULL(p.training_comp_first_end_date, '') as ftd, IFNULL(p.training_comp_second_end_date, '') as std, IFNULL(p.warranty_start_date, '') as wsd," +
                " IFNULL(DATE_ADD(p.warranty_start_date, INTERVAL p.warranty_period MONTH), '') as wed FROM project p LEFT JOIN proj_sub_category c ON " +
                "p.proj_sub_cat_id=c.proj_sub_cat_id AND p.proj_cat_id=c.proj_cat_id where p.client_id=" + clientId + ";";

            generateReport(qry);
        }

        private void generateReport(string qry)
        {
            MySqlDataReader projectReader = null;
            MySqlDataReader eventReader = null;
            MySqlDataReader techReader = null;

            DataTable projectTable = new DataTable();
            DataTable eventTable = new DataTable();
            DataTable technicianTable = new DataTable();

            projectTable.Columns.Add("Project_ID", typeof(Int32));
            projectTable.Columns.Add("Project", typeof(string));
            projectTable.Columns.Add("Category", typeof(string));
            projectTable.Columns.Add("Initialized_In", typeof(DateTime));
            projectTable.Columns.Add("First_Training_Ended", typeof(DateTime));
            projectTable.Columns.Add("Second_Training_Ended", typeof(DateTime));
            projectTable.Columns.Add("Warranty_Start_On", typeof(DateTime));
            projectTable.Columns.Add("Warranty_End_On", typeof(DateTime));

            eventTable.Columns.Add("Project_ID", typeof(Int32));
            eventTable.Columns.Add("Event_ID", typeof(Int32));
            eventTable.Columns.Add("Event_Started", typeof(DateTime));
            eventTable.Columns.Add("Event_Ended", typeof(DateTime));
            eventTable.Columns.Add("Event_Type", typeof(string));

            technicianTable.Columns.Add("Staff_ID", typeof(Int32));
            technicianTable.Columns.Add("Technician", typeof(string));
            technicianTable.Columns.Add("Feedback", typeof(string));

            try
            {
                projectReader = DBConnection.getData(qry);

                if (projectReader.HasRows)
                {
                    while (projectReader.Read())
                    {
                        projectTable.Rows.Add(projectReader.GetInt32(0), projectReader.GetString(1), projectReader.GetString(2), projectReader.GetDateTime(3), projectReader.GetDateTime(4), projectReader.GetDateTime(5), projectReader.GetDateTime(6), projectReader.GetDateTime(7));

                        int projectId = projectReader.GetInt32(0);

                        eventReader = DBConnection.getDataViaTmpConnection("SELECT e.proj_id, e.event_id, e.from_date_time, e.to_date_time, v.type FROM event e INNER JOIN visit_type v on e.visit_type_id=v.visit_type_id " +
                            "WHERE e.proj_id=" + projectId + ";");

                        if (eventReader.HasRows)
                        {
                            while (eventReader.Read())
                            {
                                eventTable.Rows.Add(eventReader.GetInt32(0), eventReader.GetInt32(1), eventReader.GetDateTime(2), eventReader.GetDateTime(3), eventReader.GetString(4));

                                int eventId = eventReader.GetInt32(1);

                                techReader = DBConnection.getDataViaThirdConnection("");

                                if (techReader.HasRows)
                                {
                                    while (techReader.Read())
                                    {
                                        technicianTable.Rows.Add(techReader.GetInt32(0), techReader.GetString(1), techReader.GetString(2));
                                    }
                                }

                                techReader.Close();
                                DBConnection.closeThirdConnection();
                            }
                        }

                        eventReader.Close();
                        DBConnection.closeTmpConnection();
                    }

                    projectReader.Close();

                    if (eventReader != null)
                        if (!eventReader.IsClosed)
                            eventReader.Close();

                    if (techReader != null)
                        if (!techReader.IsClosed)
                            techReader.Close();

                    ProjectProfileReport rpt = new ProjectProfileReport();

                    rpt.Database.Tables["projectDataSet"].SetDataSource(projectTable);
                    rpt.Database.Tables["eventDataSet"].SetDataSource(eventTable);
                    rpt.Database.Tables["technicianDataSet"].SetDataSource(eventTable);

                    clientReportViewer.ReportSource = null;
                    clientReportViewer.ReportSource = rpt;
                }
                else
                {
                    projectReader.Close();

                    if (eventReader != null)
                        if (!eventReader.IsClosed)
                            eventReader.Close();

                    if (techReader != null)
                        if (!techReader.IsClosed)
                            techReader.Close();

                    MessageBox.Show("No Projects for selected client!", "Project Profile Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    clientCmbBox.SelectedItem = null;
                    clientReportViewer.Focus();
                    clientReportViewer.ReportSource = null;
                }
            }
            catch (Exception ex)
            {
                if (projectReader != null)
                    if (!projectReader.IsClosed)
                        projectReader.Close();

                if (eventReader != null)
                    if (!eventReader.IsClosed)
                        eventReader.Close();

                if (techReader != null)
                    if (!techReader.IsClosed)
                        techReader.Close();

                MessageBox.Show("Something went wrong!\n" + ex.Message + "\n" + ex.StackTrace, "Project Profile Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                clientCmbBox.SelectedItem = null;
                clientReportViewer.Focus();
                clientReportViewer.ReportSource = null;
            }
        }
    }
}
