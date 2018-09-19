using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Common;
using ResoflexClientHandlingSystem.Core;
using ResoflexClientHandlingSystem.Role;
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
    public partial class AddExpensesForm : MetroFramework.Forms.MetroForm
    {
        private int projId, eventId, schNo;
        private string projectName, clientName, travelling, accom, meal;
        private double givenAmount = 0.0;
        private DateTime from, to;

        private DataTable dt = new DataTable();
        
        public AddExpensesForm()
        {
            InitializeComponent();

            this.projId = 1;
            this.eventId = 2;
            this.schNo = 2;
            this.projectName = "Testing project name";
            this.clientName = "Testing client name";
            this.travelling = "testing travel";
            this.accom = "testing accomm";
            this.meal = "testing meal";
            this.from = DateTime.Today;
            this.to = DateTime.Today;
        }
        
        public AddExpensesForm(int projId, int eventId, int schNo, string projectName, string clientName, DateTime from, DateTime to, string travelling, string accom, string meal)
        {
            InitializeComponent();

            this.projId = projId;
            this.eventId = eventId;
            this.schNo = schNo;
            this.projectName = projectName;
            this.clientName = clientName;
            this.travelling = travelling;
            this.accom = accom;
            this.meal = meal;
            this.from = from;
            this.to = to;
        }
        
        private void AddExpensesForm_Load(object sender, EventArgs e)
        {
            fillExpTypeCmbBox();

            dt.Columns.Add("Exp_Type", typeof(string));
            dt.Columns.Add("IOU/Direct", typeof(string));
            dt.Columns.Add("Amount", typeof(double));
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Comment", typeof(string));
        }
        
        private void AddExpensesForm_Shown(object sender, EventArgs e)
        {
            verticalLineDetailsLbl.AutoSize = false;
            verticalLineDetailsLbl.Width = 2;
            verticalLineDetailsLbl.Height = 165;
            verticalLineDetailsLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            horizontalLineDetailLbl.AutoSize = false;
            horizontalLineDetailLbl.Height = 2;
            horizontalLineDetailLbl.Width = 1050;
            horizontalLineDetailLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            projectNameLbl.Text = projectName;
            clientNameLbl.Text = clientName;
            fromDateLbl.Text = from.ToString("yyyy/MM/d");
            toDateLbl.Text = to.ToString("yyyy/MM/d");
            travellingLbl.Text = travelling;
            accLbl.Text = accom;
            mealLbl.Text = meal;

            fillCalculatableLables();
            fillDataGrid("testType", "IOU", 1220.00, DateTime.Today, "commentTest");

            iouRadioBtn.Checked = true;
        }

        private void fillDataGrid(string expType, string iouDirect, double amount, DateTime date, string comment)
        {
            dt.Rows.Add(expType, iouDirect, amount, date, comment);

            eventExpensesGrid.DataSource = dt;

            double tot = 0.0;

            foreach (DataGridViewRow row in eventExpensesGrid.Rows)
            {
                tot += Double.Parse(row.Cells[2].Value.ToString());
            }

            totalExpLbl.Text = "Rs. " + tot;
        }

        private void fillCalculatableLables()
        {
            try
            {
                MySqlDataReader reader = DBConnection.getData("SELECT IFNULL(COUNT(et.event_staff_id), 0) as noOfTech FROM event_technicians et WHERE et.proj_id=" + projId + " AND et.event_id=" + eventId + " GROUP BY et.proj_id, et.event_id;");

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        noOfTechLbl.Text = "" + reader.GetInt16(0);
                    }
                }
                else
                {
                    noOfTechLbl.Text = "0";
                }

                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in counting technicians!", "Count techs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                MySqlDataReader reader = DBConnection.getData("SELECT e.event_id, e.sch_no FROM event e WHERE e.proj_id=" + projId + " ORDER BY e.event_id ASC;");

                int count = 0;

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        count++;

                        if ((reader.GetInt32(0) == eventId) && (reader.GetInt32(1) == schNo))
                            eventNoLbl.Text = "" + count;
                    }
                }
                else
                {
                    eventNoLbl.Text = "";
                }

                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in taking event number!", "Event Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                MySqlDataReader reader = DBConnection.getData("SELECT SUM(amount) as givenAmount FROM iou WHERE proj_id=" + projId + " and sch_no=" + schNo + ";");
                
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        givenAmountLbl.Text = "Rs. " + reader.GetDouble(0);
                        givenAmount = reader.GetDouble(0);
                    }
                }
                else
                {
                    givenAmountLbl.Text = "Rs. 0.00";
                }

                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in taking given amount!", "IOU Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fillExpTypeCmbBox()
        {
            try
            {
                MySqlDataReader reader = DBConnection.getData("select exp_type_id, type from expense_type");

                DataTable dt = new DataTable();
                dt.Load(reader);

                expTypeCmbBox.DataSource = dt;
                expTypeCmbBox.ValueMember = "exp_type_id";
                expTypeCmbBox.DisplayMember = "type";
            }
            catch (Exception)
            {
                MessageBox.Show("Error in filling the Expense types!", "Expense Type Filler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void amountTxtBox_Validating(object sender, CancelEventArgs e)
        {

        }

        private void amountTxtBox_Validated(object sender, EventArgs e)
        {

        }

        private void datePicker_Validating(object sender, CancelEventArgs e)
        {

        }

        private void datePicker_Validated(object sender, EventArgs e)
        {

        }

        private void addExpBtn_Click(object sender, EventArgs e)
        {


            fillDataGrid("testType", "IOU", 1220.00, DateTime.Today, "commentTest");
        }

        private void submitExpBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
