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

namespace ResoflexClientHandlingSystem.ScheduleForms.Reports
{
    public partial class ScheduleReportsForm : MetroFramework.Forms.MetroForm
    {
        public ScheduleReportsForm()
        {
            InitializeComponent();
        }

        public ScheduleReportsForm(int proj_id, int sch_no)
        {
            InitializeComponent();

            DataTable schedule = new DataTable();
            DataTable reso = new DataTable();
            DataTable serviceEng = new DataTable();

            schedule.Columns.Add("sch_no", typeof(int));
            schedule.Columns.Add("proj_id", typeof(int));
            schedule.Columns.Add("visit_type_id", typeof(int));
            schedule.Columns.Add("to_date_time", typeof(string));
            schedule.Columns.Add("from_date_time", typeof(string));
            schedule.Columns.Add("to_do_list", typeof(string));
            schedule.Columns.Add("check_list", typeof(string));
            schedule.Columns.Add("travelling_mode", typeof(string));
            schedule.Columns.Add("accomodation", typeof(string));
            schedule.Columns.Add("meals", typeof(string));
            schedule.Columns.Add("logs", typeof(string));
            schedule.Columns.Add("client_name", typeof(string));
            schedule.Columns.Add("proj_name", typeof(string));
            schedule.Columns.Add("visit_type", typeof(string));

            reso.Columns.Add("sch_no", typeof(string));
            reso.Columns.Add("proj_id", typeof(string));
            reso.Columns.Add("name", typeof(string));
            reso.Columns.Add("qty", typeof(int));

            serviceEng.Columns.Add("proj_id", typeof(int));
            serviceEng.Columns.Add("sch_no", typeof(int));
            serviceEng.Columns.Add("name", typeof(string));
            serviceEng.Columns.Add("staff_id", typeof(int));

            string qry = "select s.sch_no, s.proj_id, s.visit_type_id, s.to_date_time, s.from_date_time, " +
                "s.to_do_list, s.check_list, s.travelling_mode, s.accommodation, s.meals, s.logs, p.proj_name, " +
                "c.name, v.type " +
                "from schedule s, project p, client c, visit_type v  " +
                "where (s.sch_no = " + sch_no + " and s.proj_id = " + proj_id + ") and (p.proj_id = s.proj_id) and (p.client_id = c.client_id) and (s.visit_type_id = v.visit_type_id);";
    
            try
            {
                MySqlDataReader reader = DBConnection.getData(qry);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        schedule.Rows.Add(reader.GetInt16("sch_no"), reader.GetInt16("proj_id"), reader.GetInt16("visit_type_id")
                            ,reader.GetString("to_date_time"), reader.GetString("from_date_time"), reader.GetString("to_do_list"), reader.GetString("check_list")
                            , reader.GetString("travelling_mode"), reader.GetString("accommodation"), reader.GetString("meals"), reader.GetString("logs")
                            , reader.GetString("name"), reader.GetString("proj_name"), reader.GetString("type"));
                    }
                }

                reader.Close();

                string qry1 = "select st.staff_id, s.first_name, s.last_name from schedule_technicians st, staff s where (st.proj_id = "+ proj_id + " and st.sch_no = " + sch_no + ") and (st.staff_id = s.staff_id);";

                MySqlDataReader reader1 = DBConnection.getData(qry1);

                if (reader1.HasRows)
                {
                    while (reader1.Read())
                    {
                        serviceEng.Rows.Add(proj_id, sch_no, reader1.GetString("first_name") +" "+reader1.GetString("last_name"), reader1.GetInt16("staff_id"));
                    }
                }

                reader1.Close();

                string qry2 = "select sr.sch_no, sr.proj_id, r.name, sr.qty from resource r, schedule_resources sr where (sr.proj_id = " + proj_id + " and sch_no = " + sch_no + ") and (sr.resource_id = r.resource_id)";

                MySqlDataReader reader2 = DBConnection.getData(qry2);

                if (reader2.HasRows)
                {
                    while (reader2.Read())
                    {
                        reso.Rows.Add(reader2.GetInt16("sch_no"), reader2.GetInt16("proj_id"), reader2.GetString("name"), reader2.GetInt16("qty"));
                    }
                }

                reader2.Close();

                ScheduleReport sr = new ScheduleReport();

                sr.Database.Tables["schedule"].SetDataSource(schedule);
                sr.Database.Tables["scheduleReso"].SetDataSource(reso);
                sr.Database.Tables["engineers"].SetDataSource(serviceEng);

                crystalReportViewer.ReportSource = sr;

            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
