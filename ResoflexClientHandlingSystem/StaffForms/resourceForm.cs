using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;
using ResoflexClientHandlingSystem.Role;
using ResoflexClientHandlingSystem.UserForms;
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
            if (Userglobals.uname == "")
            {
                profilebtn.Visible = false;
                resAddBtn.Visible = false;
                DelResBtn.Visible = false;
                UpdateResBtn.Visible = false;

            }
            else
            {
                if (Userglobals.priv != "PM" || Userglobals.priv != "HR")
                {
                    resAddBtn.Visible = false;
                    DelResBtn.Visible = false;
                    UpdateResBtn.Visible = false;

                }

                profilebtn.Visible = true;
                profilebtn.Text = Userglobals.uname;


            }

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
                loadResourceToGrid();

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

        private DataTable searchFromResource()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("SELECT * FROM resource WHERE name LIKE '%"
                + selectResourceTxtbox.Text + "%'");
            table.Load(reader);
            return table;

        }

        private void selectResourceTxtbox_TextChanged(object sender, EventArgs e)
        {
            ResGrid.DataSource = searchFromResource();
        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            ProfileForm prffrm = new ProfileForm();
            this.Hide();
            prffrm.ShowDialog();
            this.Close();
        }
    }
}
