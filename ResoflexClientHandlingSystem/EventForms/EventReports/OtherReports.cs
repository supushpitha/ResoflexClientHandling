using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;
using ResoflexClientHandlingSystem.Role;
using System;
using System.Collections;
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
    public partial class OtherReports : MetroFramework.Forms.MetroForm
    {
        public OtherReports()
        {
            InitializeComponent();
        }

        private void btnWorst_Click(object sender, EventArgs e)
        {
            DataTable worstTable = new DataTable();
            worstTable.Columns.Add("staff_id", typeof(int));
            worstTable.Columns.Add("name", typeof(string));
            worstTable.Columns.Add("feedback", typeof(double));

            string qry = "select staff_id from staff";
            DateTime date = Convert.ToDateTime(reportTime.Text.ToString());

            MySqlDataReader rdr = DBConnection.getData(qry);

            ArrayList staff = new ArrayList();
            ArrayList worst = new ArrayList();

            while (rdr.Read())
            {
                staff.Add(rdr.GetInt16("staff_id"));
            }

            rdr.Close();

            foreach (var item in staff)
            {
                int i = int.Parse(item.ToString());

                MySqlDataReader reader = DBConnection.getData("select et.feedback, s.first_name, s.last_name from event_technicians et, event e, staff s where (et.event_id = e.event_id and et.sch_no = e.sch_no and et.proj_id = e.proj_id and s.staff_id = et.staff_id) and et.staff_id = " + i +" and (e.from_date_time like '"+ date.ToString("yyyy-MM") +"-%')");

                int count = 0;
                double grade = 0;
                string name = "";

                while (reader.Read())
                {
                    string value = reader.GetString("feedback");
                    name = reader.GetString("first_name") + " " + reader.GetString("last_name");

                    switch (value)
                    {
                        case "A":
                            {
                                grade += 5;
                                count++;
                                break;
                            }

                        case "B":
                            {
                                grade += 4;
                                count++;
                                break;
                            }

                        case "C":
                            {
                                grade += 3;
                                count++;
                                break;
                            }

                        case "D":
                            {
                                grade += 2;
                                count++;
                                break;
                            }

                        case "E":
                            {
                                grade += 1;
                                count++;
                                break;
                            }

                        case "None":
                            {
                                grade += 0;
                                break;
                            }

                        default: break;
                    }
                }

                reader.Close();

                double feed = grade / count;

                if(feed <= 2)
                {
                    worst.Add(new Cal(i, name, feed));
                }
            }

            foreach (var item in worst)
            {
                Cal c = (Cal)item;

                worstTable.Rows.Add(c.Staff_id, c.Name, c.Feedback);
            }

            WorstPerformance wp = new WorstPerformance();

            wp.Database.Tables["Engineers"].SetDataSource(worstTable);

            crystalReport.ReportSource = null;
            crystalReport.ReportSource = wp;

            worstTable = null;
        }

        private void btnBest_Click(object sender, EventArgs e)
        {
            DataTable bestTable = new DataTable();
            bestTable.Columns.Add("staff_id", typeof(int));
            bestTable.Columns.Add("name", typeof(string));
            bestTable.Columns.Add("feedback", typeof(double));

            string qry = "select staff_id from staff";
            DateTime date = Convert.ToDateTime(reportTime.Text.ToString());

            MySqlDataReader rdr = DBConnection.getData(qry);

            ArrayList staff = new ArrayList();
            ArrayList best = new ArrayList();

            while (rdr.Read())
            {
                staff.Add(rdr.GetInt16("staff_id"));
            }

            rdr.Close();

            foreach (var item in staff)
            {
                int i = int.Parse(item.ToString());

                MySqlDataReader reader = DBConnection.getData("select et.feedback, s.first_name, s.last_name from event_technicians et, event e, staff s where (et.event_id = e.event_id and et.sch_no = e.sch_no and et.proj_id = e.proj_id and s.staff_id = et.staff_id) and et.staff_id = " + i + " and (e.from_date_time like '" + date.ToString("yyyy-MM") + "-%')");

                int count = 0;
                double grade = 0;
                string name = "";

                while (reader.Read())
                {
                    string value = reader.GetString("feedback");
                    name = reader.GetString("first_name") + " " + reader.GetString("last_name");

                    switch (value)
                    {
                        case "A":
                            {
                                grade += 5;
                                count++;
                                break;
                            }

                        case "B":
                            {
                                grade += 4;
                                count++;
                                break;
                            }

                        case "C":
                            {
                                grade += 3;
                                count++;
                                break;
                            }

                        case "D":
                            {
                                grade += 2;
                                count++;
                                break;
                            }

                        case "E":
                            {
                                grade += 1;
                                count++;
                                break;
                            }

                        case "None":
                            {
                                grade += 0;
                                break;
                            }

                        default: break;
                    }
                }

                reader.Close();

                double feed = grade / count;

                if (feed > 2)
                {
                    best.Add(new Cal(i, name, feed));
                }
            }

            foreach (var item in best)
            {
                Cal c = (Cal)item;

                bestTable.Rows.Add(c.Staff_id, c.Name, c.Feedback);
            }

            BestPerformance bp = new BestPerformance();

            bp.Database.Tables["Engineers"].SetDataSource(bestTable);

            crystalReport.ReportSource = null;
            crystalReport.ReportSource = bp;
        }

        public class Cal
        {
            private int staff_id;
            private string name;
            private double feedback;

            public int Staff_id { get => staff_id; set => staff_id = value; }
            public string Name { get => name; set => name = value; }
            public double Feedback { get => feedback; set => feedback = value; }

            public Cal()
            {
            }

            public Cal(int staff_id, string name, double feedback)
            {
                this.staff_id = staff_id;
                this.name = name;
                this.feedback = feedback;
            }
        }
    }
}
