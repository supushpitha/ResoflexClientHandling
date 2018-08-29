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
           /* {
                this.chart1.Series["Grading"].Points.Clear();
                this.chart1.Series["Grading"].Points.Clear();

                MySqlDataReader reader3 = DBConnection.getData("SELECT * FROM job_performance WHERE year(perf_year) = " + Int32.Parse(metroComboBox1.SelectedItem.ToString()) + " and staff_id = " + employeeNo + ";");
                while (reader3.Read())
                {
                    this.chart1.Series["Grading"].Points.AddXY("knowledge", reader3.GetInt32("knowledge"));
                    this.chart1.Series["Grading"].Points.AddXY("Safety", reader3.GetInt32("saftey"));
                    this.chart1.Series["Grading"].Points.AddXY("Quality", reader3.GetInt32("quality"));
                    this.chart1.Series["Grading"].Points.AddXY("Adaptability", reader3.GetInt32("adaptability"));
                    this.chart1.Series["Grading"].Points.AddXY("Productivity", reader3.GetInt32("productivity"));
                    this.chart1.Series["Grading"].Points.AddXY("Initiative", reader3.GetInt32("Initiative"));
                }
                reader3.Close();
            }*/
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
