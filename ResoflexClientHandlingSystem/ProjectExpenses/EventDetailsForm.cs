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
    public partial class EventDetailsForm : MetroFramework.Forms.MetroForm
    {
        public EventDetailsForm()
        {
            InitializeComponent();
        }

        private void EventDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void EventDetailsForm_Shown(object sender, EventArgs e)
        {
            eventExpGrid.DataSource = getEventExp();

            eventExpGrid.Columns[0].Visible = false;
            eventExpGrid.Columns[1].Visible = false;
            eventExpGrid.Columns[2].Visible = false;

            if (eventExpGrid.Rows.Count >= 1)
            {
                int projId = Int32.Parse(eventExpGrid.Rows[0].Cells[0].Value.ToString());
                int clientId = Int32.Parse(eventExpGrid.Rows[0].Cells[1].Value.ToString());
                int eventId = Int32.Parse(eventExpGrid.Rows[0].Cells[2].Value.ToString());

                fillExpTypeTiles(projId, eventId);
                fillBriefDetailTiles(projId, eventId, clientId);
            }
        }

        private void fillBriefDetailTiles(int projId, int eventId, int clientId)
        {
            maxExpProjTile.Text = "Rs.0.00";
            totalExpProjTile.Text = "Rs.0.00";
            noTechTile.Text = "0";

            MySqlDataReader reader = DBConnection.getData("select MAX(amount) as max, SUM(amount) as sum from exp_detail_event where " +
                                                          "proj_id=" + projId + " group by proj_id;");

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    maxExpProjTile.Text = "Rs." + reader.GetDouble(0);
                    totalExpProjTile.Text = "Rs." + reader.GetDouble(1);
                }
            }
            else
            {
                maxExpProjTile.Text = "Rs.0.00";
                totalExpProjTile.Text = "Rs.0.00";
                noTechTile.Text = "0";
            }

            reader.Close();
        }

        private DataTable getEventExp()
        {
            DataTable table = new DataTable();

            MySqlDataReader reader = DBConnection.getData("select p.proj_id, c.client_id, v.event_id, p.proj_name as Project, c.name as Client, " +
                "v.from_date_time as From_Date, v.to_date_time as To_Date, v.travelling_mode as Travel, " +
                "v.accommodation_mode as Accom, v.meals as Meals, SUM(e.amount) as Expense from exp_detail_event e INNER JOIN event v " +
                "ON e.event_id=v.event_id AND e.proj_id=v.proj_id LEFT JOIN project p ON v.proj_id=p.proj_id INNER JOIN client c " +
                "ON p.client_id=c.client_id GROUP BY e.proj_id, e.event_id;");

            table.Load(reader);

            return table;
        }

        private void fillExpTypeTiles(int projId, int eventId)
        {
            mealExpTile.Text = "Rs.0.00";
            accTile.Text = "Rs.0.00";
            travelExpTile.Text = "Rs.0.00";
            otherExpTile.Text = "Rs.0.00";

            double other = 0.0;

            MySqlDataReader reader = DBConnection.getData("SELECT t.type as type, IFNULL(SUM(e.amount), 0) amount FROM expense_type t LEFT JOIN " +
                "exp_detail_event e ON e.exp_type_id=t.exp_type_id WHERE e.event_id=" + eventId + " AND e.proj_id=" + projId + " GROUP BY e.exp_type_id;");

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (reader.GetString(0).Equals("Meals"))
                        mealExpTile.Text = "Rs." + reader.GetDouble(1);
                    else if (reader.GetString(0).Equals("Accommodation"))
                        accTile.Text = "Rs." + reader.GetDouble(1);
                    else if (reader.GetString(0).Equals("Travel"))
                        travelExpTile.Text = "Rs." + reader.GetDouble(1);
                    else
                        other += reader.GetDouble(1);
                }

                otherExpTile.Text = "Rs." + other;
            }
            else
            {
                mealExpTile.Text = "Rs.0.00";
                accTile.Text = "Rs.0.00";
                travelExpTile.Text = "Rs.0.00";
                otherExpTile.Text = "Rs.0.00";
            }

            reader.Close();
        }
        
        private void eventExpGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            
            if (dgv.CurrentRow.Selected)
            {
                int projId = Int32.Parse(eventExpGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                int clientId = Int32.Parse(eventExpGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
                int eventId = Int32.Parse(eventExpGrid.Rows[e.RowIndex].Cells[2].Value.ToString());

                fillExpTypeTiles(projId, eventId);
                fillBriefDetailTiles(projId, eventId, clientId);
            }
        }
    }
}
