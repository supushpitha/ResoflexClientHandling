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

namespace ResoflexClientHandlingSystem.ProjectForms
{
    public partial class Maintenance : MetroFramework.Forms.MetroForm
    {
        public Maintenance()
        {
            InitializeComponent();
        }

        private void Maintenance_Load(object sender, EventArgs e)
        {
            metroGrid1.DataSource = getmain();
            fillCountTile();
            fillCountTile1();
        }


        private DataTable getmain()
        {
            DataTable table = new DataTable();


            MySqlDataReader reader = DBConnection.getData("select p.proj_name as Project,p.description as Description ,e.from_date_time as Date from project p, event e where p.proj_id=e.proj_id");

            table.Load(reader);
            

            return table;


        }


        private void fillCountTile()
        {
            try
            {
                MySqlDataReader reader = DBConnection.getData("select count(event_id) as Maintenence_Count from event where event_id=2");

                while (reader.Read())
                {
                    metroTile2.Text = (reader.GetValue(0).ToString());
                }

                reader.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }


        }


        private void fillCountTile1()
        {
            try
            {
                MySqlDataReader reader = DBConnection.getData("select p.proj_name from event e, project p where  p.proj_id=e.proj_id and e.event_id=2");

                while (reader.Read())
                {
                    metroTile1.Text = (reader.GetValue(0).ToString());
                }

                reader.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }


        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
