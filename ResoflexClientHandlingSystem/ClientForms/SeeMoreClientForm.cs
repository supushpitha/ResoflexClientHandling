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
            fillClientCmbBox();
            clientsCmbBox.SelectedIndex = 1;

            projectOfClientGrid.DataSource = getProjectsOfClient();

            projectOfClientGrid.Columns[0].Visible = false;
        }

        private DataTable getProjectsOfClient()
        {
            DataTable table = new DataTable();

            MySqlDataReader reader = DBConnection.getData("select p.proj_id, p.proj_name as Project, " +
                "p.description as Description, c.sub_cat_name as Subcategory, p.first_init_date " +
                "from project p inner join proj_sub_category c on p.proj_sub_cat_id=c.proj_sub_cat_id and " +
                "p.proj_cat_id=c.proj_cat_id inner join client l on p.client_id=l.client_id " +
                "where l.name='" + clientsCmbBox.SelectedItem.ToString() + "'");

            table.Load(reader);

            return table;
        }

        private void fillClientCmbBox()
        {
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

                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in filling the client comboBox!", "clients Filler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clientsCmbBox_SelectedValueChanged(object sender, EventArgs e)
        {
            projectOfClientGrid.DataSource = getProjectsOfClient();
        }
    }
}
