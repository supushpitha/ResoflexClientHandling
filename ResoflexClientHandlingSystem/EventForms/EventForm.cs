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
    public partial class EventForm : MetroFramework.Forms.MetroForm
    {
        public EventForm()
        {
            InitializeComponent();

            eventGrid.DataSource = getEvents();

            //Autocompelete data source
            projectName.AutoCompleteCustomSource = projectNameAutoComplete();
            clientName.AutoCompleteCustomSource = clientNameAutoComplete();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {

        }

        private void schHome_Click(object sender, EventArgs e)
        {
            ProjectManager pm = new ProjectManager();
            this.Close();
            pm.Show();
        }

        private void addEvent_Click(object sender, EventArgs e)
        {
            AddEventForm ef = new AddEventForm();
            ef.ShowDialog();
        }

        //Data for grid
        private DataTable getEvents()
        {
            DataTable dt = new DataTable();

            MySqlDataReader reader = DBConnection.getData("select * from event");

            dt.Load(reader);

            reader.Close();

            return dt;
        }

        //for autocomplete project names
        private AutoCompleteStringCollection projectNameAutoComplete()
        {
            DataTable dt = new DataTable();

            MySqlDataReader reader = DBConnection.getData("select proj_name from project");
            dt.Load(reader);

            AutoCompleteStringCollection colString = new AutoCompleteStringCollection();

            foreach (DataRow item in dt.Rows)
            {
                colString.Add(Convert.ToString(item[0]));
            }

            reader.Close();

            return colString;
        }

        //for autocomplete client names
        private AutoCompleteStringCollection clientNameAutoComplete()
        {
            DataTable dt = new DataTable();

            MySqlDataReader reader = DBConnection.getData("select name from client");
            dt.Load(reader);

            AutoCompleteStringCollection colString = new AutoCompleteStringCollection();

            foreach (DataRow item in dt.Rows)
            {
                colString.Add(Convert.ToString(item[0]));
            }

            reader.Close();

            return colString;
        }
    }
}
