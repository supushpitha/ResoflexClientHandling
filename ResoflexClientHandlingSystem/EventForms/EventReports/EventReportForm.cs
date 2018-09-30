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

namespace ResoflexClientHandlingSystem.EventForms.EventReports
{
    public partial class EventReportForm : MetroFramework.Forms.MetroForm
    {
        public EventReportForm()
        {
            InitializeComponent();
        }

        public EventReportForm(int proj_id, int sch_no, int event_id)
        {
            InitializeComponent();

            DataTable evnt = new DataTable();
            DataTable reso = new DataTable();
            DataTable serviceEng = new DataTable();

            evnt.Columns.Add("event_id", typeof(int));
            evnt.Columns.Add("proj_id", typeof(int));
            evnt.Columns.Add("visit_type_id", typeof(int));
            evnt.Columns.Add("to_date_time", typeof(string));
            evnt.Columns.Add("from_date_time", typeof(string));
            evnt.Columns.Add("sch_no", typeof(int));
            evnt.Columns.Add("feedback", typeof(string));
            evnt.Columns.Add("Other", typeof(string));
            evnt.Columns.Add("to_do_list", typeof(string));
            evnt.Columns.Add("check_list", typeof(string));
            evnt.Columns.Add("travelling_mode", typeof(string));
            evnt.Columns.Add("accommodation_mode", typeof(string));
            evnt.Columns.Add("meals", typeof(string));
            evnt.Columns.Add("client_name", typeof(string));
            evnt.Columns.Add("proj_name", typeof(string));
            evnt.Columns.Add("visit_type", typeof(string));

            reso.Columns.Add("name", typeof(string));
            reso.Columns.Add("qty", typeof(int));

            serviceEng.Columns.Add("staff_id", typeof(int));
            serviceEng.Columns.Add("name", typeof(string));
            serviceEng.Columns.Add("task", typeof(string));
            serviceEng.Columns.Add("feedback", typeof(string));
            serviceEng.Columns.Add("man_hours", typeof(double));

            string qry = "select s.visit_type_id, s.to_date_time, s.from_date_time, s.feedback," +
                "s.to_do_list, s.check_list, s.travelling_mode, s.accommodation_mode, s.meals, s.Other, p.proj_name, " +
                "c.name, v.type " +
                "from event s, project p, client c, visit_type v  " +
                "where (s.sch_no = " + sch_no + " and s.proj_id = " + proj_id + " and s.event_id = " + event_id + ") and (p.proj_id = s.proj_id) and (p.client_id = c.client_id) and (s.visit_type_id = v.visit_type_id);";


            try
            {
                MySqlDataReader reader = DBConnection.getData(qry);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        evnt.Rows.Add(event_id, proj_id, reader.GetInt16("visit_type_id"), reader.GetString("from_date_time"), reader.GetString("to_do_list")
                            , sch_no, reader.GetString("feedback"), reader.GetString("Other"), reader.GetString("to_do_list"), reader.GetString("check_list"), reader.GetString("travelling_mode")
                            , reader.GetString("accommodation_mode"), reader.GetString("meals"), reader.GetString("name"), reader.GetString("proj_name"), reader.GetString("type"));
                    }
                }

                reader.Close();

                string qry1 = "select st.staff_id, s.first_name, s.last_name from schedule_technicians st, staff s where (st.proj_id = " + proj_id + " and st.sch_no = " + sch_no + ") and (st.staff_id = s.staff_id);";


            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
