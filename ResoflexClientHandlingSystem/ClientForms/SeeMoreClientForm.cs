using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;
using System;
using System.Collections;
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
    public partial class SeeMoreClientForm : MetroFramework.Forms.MetroForm
    {
        public SeeMoreClientForm()
        {
            InitializeComponent();
        }

        private void SeeMoreClientForm_Load(object sender, EventArgs e)
        {
            //fillClientCmbBox();
            //clientsCmbBox.SelectedIndex = 1;
            setClientSearch();

            projectOfClientGrid.DataSource = getProjectsOfClient();
            requestOfClientGrid.DataSource = getRequestsOfClient();
            visitToClientGrid.DataSource = getVisitsOfClient();
            visitedTechOfClientGrid.DataSource = getVisitedTechniciansOfClient();
            fillTiles();

            projectOfClientGrid.Columns[0].Visible = false;
            /*
            foreach (DataGridViewRow row in requestOfClientGrid.Rows)
            {
                if (Convert.ToBoolean(row.Cells[2]))
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }*/
        }

        private void fillTiles()
        {
            try
            {
                MySqlDataReader reader = DBConnection.getData("SELECT IFNULL(SUM(HOUR(TIMEDIFF(e.to_date_time, e.from_date_time))), 0) as Diff " +
                    "FROM client c LEFT JOIN project p ON c.client_id=p.client_id LEFT JOIN event e ON p.proj_id=e.proj_id WHERE c.name='" + searchClientTxtBox.Text + "'");

                while (reader.Read())
                {
                    totalTimeTile.Text = reader.GetInt32("diff").ToString();
                }

                reader.Close();

                reader = DBConnection.getData("select IFNULL(SUM(e.amount), 0) as sum FROM client c INNER JOIN project p ON c.client_id=p.client_id " +
                                              "INNER JOIN exp_detail_event e ON e.proj_id=p.proj_id WHERE c.name='" + searchClientTxtBox.Text + "'");

                while (reader.Read())
                {
                    totalExpTile.Text = "Rs." + reader.GetDouble("sum");
                }

                reader.Close();

                reader = DBConnection.getData("select c.name as name, SUM(e.amount) as sum_amount " +
                                              "FROM client c INNER JOIN project p ON c.client_id = p.client_id INNER JOIN exp_detail_event e ON e.proj_id = p.proj_id GROUP BY c.name " +
                                              "ORDER BY sum_amount DESC");

                rankTile.Text = "0";
                int rank = 0;

                while (reader.Read())
                {
                    rank++;

                    if (reader.GetString("name").ToLower().Equals(searchClientTxtBox.Text.ToLower()))
                    {
                        rankTile.Text = "" + rank;
                        break;
                    }
                }

                reader.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Something went wrong!\n" + exc, "Client Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable getVisitedTechniciansOfClient()
        {
            DataTable table = new DataTable();

            MySqlDataReader reader = DBConnection.getData("SELECT s.first_name as Tech, p.proj_name as Project, e.from_date_time as From_Date, e.to_date_time as To_Date, et.feedback as Feedback " +
                "FROM event_technicians et INNER JOIN event e ON et.event_id=e.event_id AND et.proj_id=e.proj_id INNER JOIN project p ON p.proj_id=e.proj_id " +
                "INNER JOIN staff s ON s.staff_id=et.staff_id INNER JOIN client c ON c.client_id=p.client_id WHERE c.name = '" + searchClientTxtBox.Text + "'");

            table.Load(reader);

            return table;
        }

        private DataTable getVisitsOfClient()
        {
            DataTable table = new DataTable();

            MySqlDataReader reader = DBConnection.getData("SELECT c.name as Client, p.proj_name as Project, t.type as Type, e.from_date_time as " +
                "From_Date, e.to_date_time as To_Date FROM event e INNER JOIN project p ON e.proj_id=p.proj_id " +
                "INNER JOIN visit_type t ON t.visit_type_id=e.visit_type_id INNER JOIN client c ON c.client_id=p.client_id WHERE c.name = '" + searchClientTxtBox.Text + "'");

            table.Load(reader);

            return table;
        }

        private DataTable getRequestsOfClient()
        {
            DataTable table = new DataTable();

            MySqlDataReader reader = DBConnection.getData("SELECT p.proj_name as Project, r.request as Request, " +
                "r.state as State, r.added_date as Added_On, r.urgent as Urgent " +
                "FROM proj_request r INNER JOIN project p on r.proj_id = p.proj_id INNER JOIN client c on p.client_id = c.client_id " +
                "WHERE c.name = '" + searchClientTxtBox.Text + "'");

            table.Load(reader);

            return table;
        }

        private void setClientSearch()
        {
            AutoCompleteStringCollection clients = new AutoCompleteStringCollection();

            try
            {
                MySqlDataReader reader = DBConnection.getData("select name from client");

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        clients.Add(reader.GetString("name"));
                    }
                }

                searchClientTxtBox.AutoCompleteCustomSource = clients;
                searchClientTxtBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                searchClientTxtBox.AutoCompleteMode = AutoCompleteMode.Suggest;

                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in filling the client comboBox!", "clients Filler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable getProjectsOfClient()
        {
            DataTable table = new DataTable();

            MySqlDataReader reader = DBConnection.getData("select p.proj_id, p.proj_name as Project, " +
                "p.description as Description, c.sub_cat_name as Subcategory, p.first_init_date " +
                "from project p inner join proj_sub_category c on p.proj_sub_cat_id=c.proj_sub_cat_id and " +
                "p.proj_cat_id=c.proj_cat_id inner join client l on p.client_id=l.client_id " +
                "where l.name='" + searchClientTxtBox.Text + "'");

            table.Load(reader);

            return table;
        }

        private void fillClientCmbBox()
        {/*
            clientsCmbBox.Items.Clear();

            try
            {
                MySqlDataReader reader = DBConnection.getData("select client_id, name from client");

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        clientsCmbBox.Items.Add(reader.GetString("name"));
                    }
                }

                //clientsCmbBox.AutoCompleteCustomSource = reader.GetString("name").ToArray;
                clientsCmbBox.AutoCompleteSource = AutoCompleteSource.ListItems;
                clientsCmbBox.AutoCompleteMode = AutoCompleteMode.Suggest;

                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in filling the client comboBox!", "clients Filler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void clientsCmbBox_SelectedValueChanged(object sender, EventArgs e)
        {
            projectOfClientGrid.DataSource = getProjectsOfClient();
        }

        private void searchClientTxtBox_TextChanged(object sender, EventArgs e)
        {
            projectOfClientGrid.DataSource = getProjectsOfClient();
            requestOfClientGrid.DataSource = getRequestsOfClient();
            visitToClientGrid.DataSource = getVisitsOfClient();
            visitedTechOfClientGrid.DataSource = getVisitedTechniciansOfClient();
            fillTiles();

            foreach (DataGridViewRow row in requestOfClientGrid.Rows)
            {
                if (Convert.ToBoolean(row.Cells[4].Value) && !Convert.ToBoolean(row.Cells[2].Value))
                {
                    row.DefaultCellStyle.ForeColor = Color.Red;
                    row.DefaultCellStyle.SelectionForeColor = Color.Red;
                }
                else if (Convert.ToBoolean(row.Cells[2].Value))
                {
                    row.DefaultCellStyle.ForeColor = Color.Green;
                    row.DefaultCellStyle.SelectionForeColor = Color.Green;
                }
            }

            foreach (DataGridViewRow row in visitToClientGrid.Rows)
            {
                if ((Convert.ToDateTime(row.Cells[3].Value) <= DateTime.Now) && (Convert.ToDateTime(row.Cells[4].Value) > DateTime.Now))
                {
                    row.DefaultCellStyle.ForeColor = Color.Green;
                    row.DefaultCellStyle.SelectionForeColor = Color.Green;
                }
            }

            foreach (DataGridViewRow row in visitedTechOfClientGrid.Rows)
            {
                if (Convert.ToInt32(row.Cells[4].Value) > 6)
                {
                    row.DefaultCellStyle.ForeColor = Color.Green;
                    row.DefaultCellStyle.SelectionForeColor = Color.Green;
                }
                else if (Convert.ToInt32(row.Cells[4].Value) < 4)
                {
                    row.DefaultCellStyle.ForeColor = Color.Red;
                    row.DefaultCellStyle.SelectionForeColor = Color.Red;
                }
            }
        }

        private void SeeMoreClientForm_Shown(object sender, EventArgs e)
        {
            searchClientTxtBox.Focus();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            ClientReportForm frm = new ClientReportForm();

            frm.Show();
        }
    }
}
