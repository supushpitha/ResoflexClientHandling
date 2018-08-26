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
            maintGrid.DataSource = getmain();
            chart1.Series["Salary"].Points.AddXY("Cow", 1000);
            chart1.Series["Salary"].Points.AddXY("Dog", 1076);
            chart1.Series["Salary"].Points.AddXY("Cat", 1800);
            chart1.Series["Salary"].Points.AddXY("Rat", 1100);
        }


        private DataTable getmain()
        {
            DataTable table = new DataTable();


            MySqlDataReader reader = DBConnection.getData("select p.proj_name,p.description,e.event_id,e.from_date_time from project p, event e where p.proj_id=e.proj_id and e.event_id=2");

            table.Load(reader);
            maintGrid.ClearSelection();

            return table;


        }

    }
}
