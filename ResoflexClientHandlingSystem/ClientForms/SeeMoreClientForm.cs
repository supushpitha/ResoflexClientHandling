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

            projectOfClientGrid.Columns[0].Visible = false;

            foreach (DataGridViewRow row in requestOfClientGrid.Rows)
            {
                if (Convert.ToBoolean(row.Cells[2]))
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private DataTable getVisitedTechniciansOfClient()
        {
            DataTable table = new DataTable();

            MySqlDataReader reader = DBConnection.getData("");

            table.Load(reader);

            return table;
        }

        private DataTable getVisitsOfClient()
        {
            DataTable table = new DataTable();

            MySqlDataReader reader = DBConnection.getData("");

            table.Load(reader);

            return table;
        }

        private DataTable getRequestsOfClient()
        {
            DataTable table = new DataTable();

            MySqlDataReader reader = DBConnection.getData("SELECT p.proj_name as Project_Name, r.request as Request, " +
                "r.state as State, r.added_date as Added_Date_Time, r.urgent " +
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
        }
    }
}
