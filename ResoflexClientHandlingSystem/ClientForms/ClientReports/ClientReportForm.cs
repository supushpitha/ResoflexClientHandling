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

            string qry = "SELECT p.proj_id, p.proj_name, c.sub_cat_name, date(p.first_init_date), IFNULL(date(p.training_comp_first_end_date), '') as ftd, IFNULL(date(p.training_comp_second_end_date), '') as std, IFNULL(date(p.warranty_start_date), '') as wsd," +
                " IFNULL(date(DATE_ADD(p.warranty_start_date, INTERVAL p.warranty_period MONTH)), '') as wed FROM project p LEFT JOIN proj_sub_category c ON " +
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

            technicianTable.Columns.Add("Project_ID", typeof(Int32));
            technicianTable.Columns.Add("Event_ID", typeof(Int32));
            technicianTable.Columns.Add("Project", typeof(string));
            technicianTable.Columns.Add("Event_Started", typeof(DateTime));
            technicianTable.Columns.Add("Event_Ended", typeof(DateTime));
            technicianTable.Columns.Add("Staff_ID", typeof(Int32));
            technicianTable.Columns.Add("Technician", typeof(string));
            technicianTable.Columns.Add("Feedback", typeof(string));
            technicianTable.Columns.Add("Event_Type", typeof(string));

            try
            {
                projectReader = DBConnection.getData(qry);

                if (projectReader.HasRows)
                {
                    while (projectReader.Read())
                    {
                        projectTable.Rows.Add(projectReader.GetInt32(0), projectReader.GetString(1), projectReader.GetString(2), projectReader.GetDateTime(3), projectReader.GetDateTime(4), projectReader.GetDateTime(5), projectReader.GetDateTime(6), projectReader.GetDateTime(7));

                        int projectId = projectReader.GetInt32(0);

                        Console.WriteLine("\n\nCategory : " + projectReader.GetString(2));
                        Console.WriteLine("\n");

                        eventReader = DBConnection.getDataViaTmpConnection("SELECT e.proj_id, e.event_id, date(e.from_date_time), date(e.to_date_time), v.type FROM event e INNER JOIN visit_type v on e.visit_type_id=v.visit_type_id " +
                            "WHERE e.proj_id=" + projectId + " ORDER BY e.proj_id, e.event_id;");

                        if (eventReader.HasRows)
                        {
                            while (eventReader.Read())
                            {
                                eventTable.Rows.Add(eventReader.GetInt32(0), eventReader.GetInt32(1), eventReader.GetDateTime(2), eventReader.GetDateTime(3), eventReader.GetString(4));
                            }
                        }

                        eventReader.Close();
                        DBConnection.closeTmpConnection();

                        techReader = DBConnection.getDataViaTmpConnection("SELECT p.proj_id, e.event_id, p.proj_name, date(e.from_date_time), date(e.to_date_time), s.staff_id, s.first_name, t.feedback, v.type FROM project p INNER JOIN event e ON p.proj_id=e.proj_id INNER JOIN visit_type v ON e.visit_type_id=v.visit_type_id INNER JOIN event_technicians t ON e.proj_id=t.proj_id AND e.event_id=t.event_id INNER JOIN staff s ON t.staff_id=s.staff_id WHERE p.proj_id=" + projectId + " ORDER BY p.proj_id, e.event_id, s.staff_id;");

                        if (techReader.HasRows)
                        {
                            while (techReader.Read())
                            {
                                technicianTable.Rows.Add(techReader.GetInt32(0), techReader.GetInt32(1), techReader.GetString(2), techReader.GetDateTime(3), techReader.GetDateTime(4), techReader.GetInt32(5), techReader.GetString(6), techReader.GetString(7), techReader.GetString(8));
                            }
                        }

                        techReader.Close();
                        DBConnection.closeTmpConnection();
                    }

                    projectReader.Close();

                    if (eventReader != null)
                        if (!eventReader.IsClosed)
                            eventReader.Close();

                    if (techReader != null)
                        if (!techReader.IsClosed)
                            techReader.Close();
                    
                    ProjectProfileMainReport rpt = new ProjectProfileMainReport();
                    //ProjectProfileReport subRpt = new ProjectProfileReport();

                    rpt.Database.Tables["projectDataSet"].SetDataSource(projectTable);
                    //rpt.Database.Tables["eventDataSet"].SetDataSource(eventTable);
                    rpt.Database.Tables["technicianDataSet"].SetDataSource(technicianTable);

                    DataTable tmp = new DataTable();

                    tmp.Columns.Add("ClientName", typeof(string));
                    tmp.Rows.Add(clientCmbBox.GetItemText(clientCmbBox.SelectedItem));

                    rpt.Database.Tables["Client"].SetDataSource(tmp);

                    clientReportViewer.ReportSource = null;
                    clientReportViewer.ReportSource = rpt;

                    //ProjectProfileSubReport rpt = new ProjectProfileSubReport();

                    //rpt.Database.Tables["projectDataSet"].SetDataSource(projectTable);
                    //rpt.Database.Tables["eventDataSet"].SetDataSource(eventTable);
                    //rpt.Database.Tables["technicianDataSet"].SetDataSource(technicianTable);

                    //clientReportViewer.ReportSource = null;
                    //clientReportViewer.ReportSource = rpt;
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

                MessageBox.Show("Something went wrong!", "Project Profile Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                clientCmbBox.SelectedItem = null;
                clientReportViewer.Focus();
                clientReportViewer.ReportSource = null;
            }
        }
    }
}
