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
            fillCmbBoxes();
        }

        private void IOUDetailsForm_Shown(object sender, EventArgs e)
        {
            iouGrid.DataSource = getIou();

            iouGrid.Columns[0].Visible = false;
            iouGrid.Columns[1].Visible = false;
            iouGrid.Columns[2].Visible = false;
            iouGrid.Columns[3].Visible = false;

            byProjectCmbBox.SelectedItem = null;
            byStaffCmbBox.SelectedItem = null;
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

        private void fillCmbBoxes()
        {
            byStaffCmbBox.Items.Clear();
            byProjectCmbBox.Items.Clear();

            DataTable tableProject = new DataTable();

            MySqlDataReader readerProject = DBConnection.getData("select proj_id, proj_name from project");

            tableProject.Load(readerProject);

            byProjectCmbBox.DataSource = tableProject;
            byProjectCmbBox.ValueMember = "proj_id";
            byProjectCmbBox.DisplayMember = "proj_name";

            //byProjectCmbBox.SelectedItem = null;

            Object tmp = byProjectCmbBox.SelectedValue;
            string qry = "";

            if (tmp == null)
            {
                qry = "select staff_id, first_name from staff";
            }
            else
            {
                qry = "select s.staff_id as staff_id, s.first_name as first_name from staff s inner join schedule_technicians t on s.staff_id=t.staff_id where t.proj_id=" + Int32.Parse(tmp.ToString());
            }

            MySqlDataReader readerClient = DBConnection.getData(qry);

            DataTable tableClient = new DataTable();

            tableClient.Load(readerClient);

            byStaffCmbBox.DataSource = tableClient;
            byStaffCmbBox.ValueMember = "staff_id";
            byStaffCmbBox.DisplayMember = "first_name";
        }

        private void byProjectCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillTechnicianCmbBox();
            byStaffCmbBox.SelectedItem = null;


        }

        private void fillTechnicianCmbBox()
        {
            Object tmp = byProjectCmbBox.SelectedValue;
            string qry = "";

            if (tmp == null)
            {
                qry = "select staff_id, first_name from staff";
            }
            else
            {
                int result = 0;

                if (Int32.TryParse(tmp.ToString(), out result))
                {
                    int projId = result;
                    qry = "select s.staff_id as staff_id, s.first_name as first_name from staff s inner join schedule_technicians t on s.staff_id=t.staff_id where t.proj_id=" + projId;
                }
                else
                {
                    qry = "select staff_id, first_name from staff";
                }
            }

            MySqlDataReader readerClient = DBConnection.getData(qry);

            DataTable tableClient = new DataTable();

            tableClient.Load(readerClient);

            byStaffCmbBox.DataSource = tableClient;
            byStaffCmbBox.ValueMember = "staff_id";
            byStaffCmbBox.DisplayMember = "first_name";
        }
    }
}
