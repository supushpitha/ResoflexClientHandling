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

namespace ResoflexClientHandlingSystem
{
    public partial class resourceForm : MetroFramework.Forms.MetroForm
    {
        public resourceForm()
        {
            InitializeComponent();
        }

        private void resourceForm_Load(object sender, EventArgs e)
        {

            loadResourceToGrid();

            ResGrid.Columns[0].Visible = false;

        }

        void clear()
        {
            nameResTxtBox.Clear();
            valueResTxtBox.Clear();
            qtyResTxtBox.Clear();
        }

        private void resClearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
           
        }

        private void resAddBtn_Click(object sender, EventArgs e)
        {
            string name = nameResTxtBox.Text;
            float value = float.Parse(valueResTxtBox.Text);
            int totalQty = Int32.Parse(qtyResTxtBox.Text);
            int availableQty = Int32.Parse(qtyResTxtBox.Text);

            Resource reso = new Resource(name, value, totalQty, availableQty);

            try
            {

                Core.Database.addResource(reso);

                try
                {
                    clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Every detail must be added!", "New resource adding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("New resource added successfully.", "New resource Adding", MessageBoxButtons.OK);

            // metroGrid1.DataSource = getUserList();

        }


        public void loadResourceToGrid()
        {
            MySqlDataReader reader = DBConnection.getData("select resource_id, name as Name, value as Value, total_qty as Total_Quantity, available_qty from resource");

            DataTable table = new DataTable();

            table.Load(reader);

            ResGrid.DataSource = table;
        }

        private void resourceForm_Shown(object sender, EventArgs e)
        {
          //  loadResourceToGrid();

          //  ResGrid.Columns[0].Visible = false;
        }

        private void DelResBtn_Click(object sender, EventArgs e)
        {
            int rowIndex = ResGrid.CurrentCell.RowIndex;
            ResGrid.Rows.RemoveAt(rowIndex);

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
            this.Close();
        }
    }
}
