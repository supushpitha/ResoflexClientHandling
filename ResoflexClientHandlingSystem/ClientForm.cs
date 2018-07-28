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
        }

        private DataTable getClients()
        {
            DataTable table = new DataTable();

            MySqlDataReader reader = DBConnection.getData("select * from client");

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
            int id = Int32.Parse(clientGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            string name = clientGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            string address = clientGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            string mobile = clientGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            string office = clientGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            string fax = clientGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            string email = clientGrid.Rows[e.RowIndex].Cells[6].Value.ToString();

            UpdateClientForm frm = new UpdateClientForm(id, name, address, mobile, office, fax, email);

            frm.ShowDialog();

            clientGrid.DataSource = getClients();
        }

        private void searchClientTxtBox_TextChanged(object sender, EventArgs e)
        {
            string qry = "";
            string clientNameTxt = searchClientTxtBox.Text;

            qry = "SELECT * FROM client WHERE name LIKE '%" + clientNameTxt + "%'";

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

        private void clientGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
