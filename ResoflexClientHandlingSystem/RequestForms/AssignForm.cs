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

namespace ResoflexClientHandlingSystem.RequestForms
{
    public partial class AssignForm : MetroFramework.Forms.MetroForm
    {
        public static int dev_id = -1;

        public AssignForm()
        {
            InitializeComponent();
        }

        private void AssignForm_Load(object sender, EventArgs e)
        {
            fillDevCmbBox();
        }

        private void fillDevCmbBox()
        {
            devCmbBox.Items.Clear();

            DataTable table = new DataTable();

            MySqlDataReader reader = DBConnection.getData("select u.user_id as dev_id, CONCAT(s.first_name, ' ', s.last_name) as name from user u inner join staff s on u.user_id=s.staff_id where u.permission='TCH'");

            table.Load(reader);

            devCmbBox.DataSource = table;
            devCmbBox.ValueMember = "dev_id";
            devCmbBox.DisplayMember = "name";
        }

        private void assignBtn_Click(object sender, EventArgs e)
        {
            object tmpDevId = devCmbBox.SelectedItem;

            if (tmpDevId != null)
            {
                dev_id = Int32.Parse(devCmbBox.SelectedValue.ToString());

                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a developer!", "Assign Developments", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
