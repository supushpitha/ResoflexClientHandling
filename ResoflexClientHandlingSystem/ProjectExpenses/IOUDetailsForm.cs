using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Common;
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
    public partial class IOUDetailsForm : MetroFramework.Forms.MetroForm
    {
        public IOUDetailsForm()
        {
            InitializeComponent();
        }

        private void IOUDetailsForm_Load(object sender, EventArgs e)
        {
            fillCmbBox();
        }

        private void IOUDetailsForm_Shown(object sender, EventArgs e)
        {
            iouGrid.DataSource = getIou();

            iouGrid.Columns[0].Visible = false;
            iouGrid.Columns[1].Visible = false;
            iouGrid.Columns[2].Visible = false;
            iouGrid.Columns[3].Visible = false;

            byProjectCmbBox.SelectedItem = null;

            if (iouGrid.Rows.Count >= 1)
            {
                int projId = Int32.Parse(iouGrid.Rows[0].Cells[1].Value.ToString());
                int schId = Int32.Parse(iouGrid.Rows[0].Cells[2].Value.ToString());
                double realExp = Double.Parse(iouGrid.Rows[0].Cells[11].Value.ToString());

                fillTiles(projId, schId, realExp);
            }
        }

        private void fillTiles(int projId, int scheduleId, double realExp)
        {
            realExpTile.Text = "Rs." + realExp;

            MySqlDataReader reader = DBConnection.getData("select IFNULL(count(staff_id), 0) from schedule_technicians where sch_no=" + scheduleId + " and proj_id=" + projId);

            while (reader.Read())
            {
                noTechTile.Text = "" + reader.GetInt16(0);
            }

            reader.Close();
        }

        private DataTable getIou()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = null;

            try
            {
                reader = DBConnection.getData("select i.iou_id, i.proj_id, i.sch_no, IFNULL(e.event_id, 0)as event_id, p.proj_name as Project, s.from_date_time as Sch_From, " +
                    "s.to_date_time as Sch_To, IFNULL(e.from_date_time, '') as Event_From, IFNULL(e.to_date_time, '') as Event_To, v.type as Schedule_Type, IFNULL(SUM(i.amount), 0) as IOU_Exp, " +
                    "IFNULL(SUM(x.amount), 0) as Real_Exp from iou i left join schedule s on i.proj_id=s.proj_id and i.sch_no=s.sch_no left join project p on " +
                    "i.proj_id=p.proj_id left join event e on e.sch_no=i.sch_no and e.proj_id=i.proj_id left join exp_detail_event x on x.proj_id=e.proj_id and " +
                    "x.event_id=e.event_id inner join visit_type v on v.visit_type_id=s.visit_type_id group by i.proj_id, i.sch_no, x.proj_id, x.event_id;");

                table.Load(reader);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error!\n" + exc, "IOU getter", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (reader != null)
                    if (!reader.IsClosed)
                        reader.Close();
            }

            return table;
        }

        private void fillCmbBox()
        {
            byProjectCmbBox.Items.Clear();

            DataTable tableProject = new DataTable();

            MySqlDataReader readerProject = DBConnection.getData("select proj_id, proj_name from project");

            tableProject.Load(readerProject);

            byProjectCmbBox.DataSource = tableProject;
            byProjectCmbBox.ValueMember = "proj_id";
            byProjectCmbBox.DisplayMember = "proj_name";
        }

        private void byProjectCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object tmpProj = byProjectCmbBox.SelectedValue;
            string qry = "";

            if (tmpProj != null)
            {
                int result = 0;

                if (Int32.TryParse(tmpProj.ToString(), out result))
                {
                    int projId = result;

                    qry = "select i.iou_id, i.proj_id, i.sch_no, IFNULL(e.event_id, 0)as event_id, p.proj_name as Project, s.from_date_time as Sch_From, " +
                    "s.to_date_time as Sch_To, IFNULL(e.from_date_time, '') as Event_From, IFNULL(e.to_date_time, '') as Event_To, v.type as Schedule_Type, IFNULL(SUM(i.amount), 0) as IOU_Exp, " +
                    "IFNULL(SUM(x.amount), 0) as Real_Exp from iou i left join schedule s on i.proj_id=s.proj_id and i.sch_no=s.sch_no left join project p on " +
                    "i.proj_id=p.proj_id left join event e on e.sch_no=i.sch_no and e.proj_id=i.proj_id left join exp_detail_event x on x.proj_id=e.proj_id and " +
                    "x.event_id=e.event_id inner join visit_type v on v.visit_type_id=s.visit_type_id where i.proj_id=" + projId + " group by i.proj_id, " +
                    "i.sch_no, x.proj_id, x.event_id;";
                }
                else
                {
                    qry = "select i.iou_id, i.proj_id, i.sch_no, IFNULL(e.event_id, 0)as event_id, p.proj_name as Project, s.from_date_time as Sch_From, " +
                    "s.to_date_time as Sch_To, IFNULL(e.from_date_time, '') as Event_From, IFNULL(e.to_date_time, '') as Event_To, v.type as Schedule_Type, IFNULL(SUM(i.amount), 0) as IOU_Exp, " +
                    "IFNULL(SUM(x.amount), 0) as Real_Exp from iou i left join schedule s on i.proj_id=s.proj_id and i.sch_no=s.sch_no left join project p on " +
                    "i.proj_id=p.proj_id left join event e on e.sch_no=i.sch_no and e.proj_id=i.proj_id left join exp_detail_event x on x.proj_id=e.proj_id and " +
                    "x.event_id=e.event_id inner join visit_type v on v.visit_type_id=s.visit_type_id group by i.proj_id, i.sch_no, x.proj_id, x.event_id;";
                }
            }
            else
            {
                qry = "select i.iou_id, i.proj_id, i.sch_no, IFNULL(e.event_id, 0)as event_id, p.proj_name as Project, s.from_date_time as Sch_From, " +
                    "s.to_date_time as Sch_To, IFNULL(e.from_date_time, '') as Event_From, IFNULL(e.to_date_time, '') as Event_To, v.type as Schedule_Type, IFNULL(SUM(i.amount), 0) as IOU_Exp, " +
                    "IFNULL(SUM(x.amount), 0) as Real_Exp from iou i left join schedule s on i.proj_id=s.proj_id and i.sch_no=s.sch_no left join project p on " +
                    "i.proj_id=p.proj_id left join event e on e.sch_no=i.sch_no and e.proj_id=i.proj_id left join exp_detail_event x on x.proj_id=e.proj_id and " +
                    "x.event_id=e.event_id inner join visit_type v on v.visit_type_id=s.visit_type_id group by i.proj_id, i.sch_no, x.proj_id, x.event_id;";
            }

            MySqlDataReader reader = DBConnection.getData(qry);

            if (reader.HasRows)
            {
                DataTable table = new DataTable();

                table.Load(reader);
                iouGrid.DataSource = table;

                iouGrid.Columns[0].Visible = false;
                iouGrid.Columns[1].Visible = false;
                iouGrid.Columns[2].Visible = false;
                iouGrid.Columns[3].Visible = false;

                if (iouGrid.Rows.Count >= 1)
                {
                    int projId = Int32.Parse(iouGrid.Rows[0].Cells[1].Value.ToString());
                    int schId = Int32.Parse(iouGrid.Rows[0].Cells[2].Value.ToString());
                    double realExp = Double.Parse(iouGrid.Rows[0].Cells[11].Value.ToString());

                    fillTiles(projId, schId, realExp);
                }
            }
            else
            {
                reader.Close();
                iouGrid.DataSource = null;
            }
        }
        
        private void iouGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (dgv.CurrentRow.Selected)
            {
                int projId = Int32.Parse(iouGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
                int schId = Int32.Parse(iouGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
                double realExp = Double.Parse(iouGrid.Rows[e.RowIndex].Cells[11].Value.ToString());

                fillTiles(projId, schId, realExp);
            }
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            iouGrid.DataSource = getIou();

            iouGrid.Columns[0].Visible = false;
            iouGrid.Columns[1].Visible = false;
            iouGrid.Columns[2].Visible = false;
            iouGrid.Columns[3].Visible = false;

            byProjectCmbBox.SelectedItem = null;

            if (iouGrid.Rows.Count >= 1)
            {
                int projId = Int32.Parse(iouGrid.Rows[0].Cells[1].Value.ToString());
                int schId = Int32.Parse(iouGrid.Rows[0].Cells[2].Value.ToString());
                double realExp = Double.Parse(iouGrid.Rows[0].Cells[11].Value.ToString());

                fillTiles(projId, schId, realExp);
            }
        }

        private void byDatePicker_ValueChanged(object sender, EventArgs e)
        {
            Object tmpProj = byProjectCmbBox.SelectedValue;
            DateTime date = byDatePicker.Value;
            string qry = "";

            if (tmpProj != null)
            {
                int result = 0;

                if (Int32.TryParse(tmpProj.ToString(), out result))
                {
                    int projId = result;

                    qry = "select i.iou_id, i.proj_id, i.sch_no, IFNULL(e.event_id, 0)as event_id, p.proj_name as Project, s.from_date_time as Sch_From, " +
                    "s.to_date_time as Sch_To, IFNULL(e.from_date_time, '') as Event_From, IFNULL(e.to_date_time, '') as Event_To, v.type as Schedule_Type, IFNULL(SUM(i.amount), 0) as IOU_Exp, " +
                    "IFNULL(SUM(x.amount), 0) as Real_Exp from iou i left join schedule s on i.proj_id=s.proj_id and i.sch_no=s.sch_no left join project p on " +
                    "i.proj_id=p.proj_id left join event e on e.sch_no=i.sch_no and e.proj_id=i.proj_id left join exp_detail_event x on x.proj_id=e.proj_id and " +
                    "x.event_id=e.event_id inner join visit_type v on v.visit_type_id=s.visit_type_id where i.proj_id=" + projId + " and i.date='" + date.ToString("yyyy/MM/d") + "' " +
                    "group by i.proj_id, i.sch_no, x.proj_id, x.event_id;";
                }
                else
                {
                    qry = "select i.iou_id, i.proj_id, i.sch_no, IFNULL(e.event_id, 0)as event_id, p.proj_name as Project, s.from_date_time as Sch_From, " +
                    "s.to_date_time as Sch_To, IFNULL(e.from_date_time, '') as Event_From, IFNULL(e.to_date_time, '') as Event_To, v.type as Schedule_Type, IFNULL(SUM(i.amount), 0) as IOU_Exp, " +
                    "IFNULL(SUM(x.amount), 0) as Real_Exp from iou i left join schedule s on i.proj_id=s.proj_id and i.sch_no=s.sch_no left join project p on " +
                    "i.proj_id=p.proj_id left join event e on e.sch_no=i.sch_no and e.proj_id=i.proj_id left join exp_detail_event x on x.proj_id=e.proj_id and " +
                    "x.event_id=e.event_id inner join visit_type v on v.visit_type_id=s.visit_type_id where i.date='" + date.ToString("yyyy/MM/d") + "' " +
                    "group by i.proj_id, i.sch_no, x.proj_id, x.event_id;";
                }
            }
            else
            {
                qry = "select i.iou_id, i.proj_id, i.sch_no, IFNULL(e.event_id, 0)as event_id, p.proj_name as Project, s.from_date_time as Sch_From, " +
                    "s.to_date_time as Sch_To, IFNULL(e.from_date_time, '') as Event_From, IFNULL(e.to_date_time, '') as Event_To, v.type as Schedule_Type, IFNULL(SUM(i.amount), 0) as IOU_Exp, " +
                    "IFNULL(SUM(x.amount), 0) as Real_Exp from iou i left join schedule s on i.proj_id=s.proj_id and i.sch_no=s.sch_no left join project p on " +
                    "i.proj_id=p.proj_id left join event e on e.sch_no=i.sch_no and e.proj_id=i.proj_id left join exp_detail_event x on x.proj_id=e.proj_id and " +
                    "x.event_id=e.event_id inner join visit_type v on v.visit_type_id=s.visit_type_id where i.date='" + date.ToString("yyyy/MM/d") + "'" +
                    " group by i.proj_id, i.sch_no, x.proj_id, x.event_id;";
            }

            MySqlDataReader reader = DBConnection.getData(qry);

            if (reader.HasRows)
            {
                DataTable table = new DataTable();

                table.Load(reader);
                iouGrid.DataSource = table;

                iouGrid.Columns[0].Visible = false;
                iouGrid.Columns[1].Visible = false;
                iouGrid.Columns[2].Visible = false;
                iouGrid.Columns[3].Visible = false;

                if (iouGrid.Rows.Count >= 1)
                {
                    int projId = Int32.Parse(iouGrid.Rows[0].Cells[1].Value.ToString());
                    int schId = Int32.Parse(iouGrid.Rows[0].Cells[2].Value.ToString());
                    double realExp = Double.Parse(iouGrid.Rows[0].Cells[11].Value.ToString());

                    fillTiles(projId, schId, realExp);
                }
            }
            else
            {
                reader.Close();
                iouGrid.DataSource = null;
            }
        }
    }
}
