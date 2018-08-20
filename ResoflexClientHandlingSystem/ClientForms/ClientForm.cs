using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.ClientForms;
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
    public partial class ClientForm : MetroFramework.Forms.MetroForm
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clientGrid.DataSource = getClients();

            clientGrid.Columns[0].Visible = false;
            clientGrid.Columns[6].DefaultCellStyle.ForeColor = Color.SteelBlue;
            noOfProjTile.BackColor = Color.LightBlue;
            noOfVisitsTile.BackColor = Color.LightGreen;
            totalExpTile.BackColor = Color.LightSalmon;
            gridViewUsageLbl.ForeColor = Color.Red;
        }

        private void fillTiles(int clientId)
        {
            try
            {
                MySqlDataReader reader = DBConnection.getData("select IFNULL(COUNT(proj_id), 0) as count from project where client_id=" + clientId);

                while (reader.Read())
                {
                    noOfProjTile.Text = reader.GetInt32("count").ToString();
                }

                reader.Close();

                reader = DBConnection.getData("select IFNULL(COUNT(event_id), 0) as count from event e inner join project p on p.proj_id=e.proj_id where p.client_id=" + clientId);

                while (reader.Read())
                {
                    noOfVisitsTile.Text = reader.GetInt32("count").ToString();
                }

                reader.Close();
                /*
                reader = DBConnection.getData("select IFNULL(SUM(proj_id), 0) as count from project where client_id=" + clientId);

                while (reader.Read())
                {
                    totalExpTile.Text = reader.GetInt32("count").ToString();
                }

                reader.Close();*/
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Client Retreive", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            totalExpTile.Text = "Rs." + 130000.00;
        }

        private DataTable getClients()
        {
            DataTable table = new DataTable();

            MySqlDataReader reader = DBConnection.getData("select client_id, name as Name, address as Address, " +
                "phone_mobile as Mobile, phone_office as Office, fax as Fax, email as Email from client");

            table.Load(reader);

            return table;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }

        private void addNewClientBtn_Click(object sender, EventArgs e)
        {
            AddNewClientForm frm = new AddNewClientForm();
            
            frm.ShowDialog();

            clientGrid.DataSource = getClients();
        }

        private void clientGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int clientId = Int32.Parse(clientGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            string clientName = "";

            MySqlDataReader reader = DBConnection.getData("select * from client where client_id=" + clientId);

            while (reader.Read())
            {
                clientName = reader.GetString("name");
            }

            reader.Close();

            Project1 frm = new Project1(clientName);

            frm.Show();
        }

        private void searchClientTxtBox_TextChanged(object sender, EventArgs e)
        {
            string qry = "";
            string clientNameTxt = searchClientTxtBox.Text;

            qry = "SELECT client_id, name as Name, address as Address, " +
                "phone_mobile as Mobile, phone_office as Office, fax as Fax, email as Email FROM client WHERE name LIKE '%" + clientNameTxt + "%'";

            try
            {
                MySqlDataReader reader = DBConnection.getData(qry);

                if (reader.HasRows)
                {
                    System.Data.DataTable table = new System.Data.DataTable();

                    table.Load(reader);

                    clientGrid.DataSource = table;
                }
                else
                {
                    reader.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Invalid data!\n" + exc.StackTrace, "Client finder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showAllClientBtn_Click(object sender, EventArgs e)
        {
            searchClientTxtBox.Text = "";

            clientGrid.DataSource = getClients();
        }

        private void clientGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {/*
            int id = Int32.Parse(clientGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            string name = clientGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            string address = clientGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            string mobile = clientGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            string office = clientGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            string fax = clientGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            string email = clientGrid.Rows[e.RowIndex].Cells[6].Value.ToString();

            UpdateClientForm frm = new UpdateClientForm(id, name, address, mobile, office, fax, email);

            frm.ShowDialog();

            clientGrid.DataSource = getClients();*/
        }

        private void ClientForm_MinimumSizeChanged(object sender, EventArgs e)
        {/*
            if (this.Height == this.DefaultMaximumSize.Height)
            {
                int h = clientGrid.Height;
                // grid h = 297
                // form h = 600

                int newGridHeight = (int)(0.5 * this.Height);

                clientGrid.Height = newGridHeight;
            }*/
        }

        private void ClientForm_SizeChanged(object sender, EventArgs e)
        {/*
            int h = clientGrid.Height;
            // grid h = 297
            // form h = 600

            int newGridHeight = (int)(0.5 * this.Height);

            clientGrid.Height = newGridHeight;*/
        }

        private void clientGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (dgv.CurrentRow.Selected)
            {
                int clientId = Int32.Parse(clientGrid.Rows[e.RowIndex].Cells[0].Value.ToString());

                fillTiles(clientId);
            }
        }

        private void updateClientBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = clientGrid.CurrentRow;

            int id = Int32.Parse(row.Cells[0].Value.ToString());
            string name = row.Cells[1].Value.ToString();
            string address = row.Cells[2].Value.ToString();
            string mobile = row.Cells[3].Value.ToString();
            string office = row.Cells[4].Value.ToString();
            string fax = row.Cells[5].Value.ToString();
            string email = row.Cells[6].Value.ToString();

            UpdateClientForm frm = new UpdateClientForm(id, name, address, mobile, office, fax, email);

            frm.ShowDialog();

            clientGrid.DataSource = getClients();
        }

        private void clientGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex != -1)
            {
                EmailClientForm frm = new EmailClientForm(clientGrid.Rows[e.RowIndex].Cells[6].Value.ToString());

                frm.ShowDialog(this);
            }
        }

        private void ShowMoreBtn_Click(object sender, EventArgs e)
        {
            SeeMoreClientForm frm = new SeeMoreClientForm();

            frm.Show();
        }
    }
}
