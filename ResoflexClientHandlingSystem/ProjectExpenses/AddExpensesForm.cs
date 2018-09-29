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
            this.from = DateTime.Today.AddDays(-3);
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

            eventExpensesGrid.DataSource = dt;
            iouRadioBtn.Checked = true;
        }

        private void fillDataGrid(string expType, string iouDirect, double amount, DateTime date, string comment)
        {
            bool duplicate = false;

            foreach (DataGridViewRow row in eventExpensesGrid.Rows)
            {
                if (expType.Equals(row.Cells[0].Value.ToString()))
                    if (iouDirect.Equals(row.Cells[1].Value.ToString()))
                        if (Convert.ToDateTime(row.Cells[3].Value.ToString()).ToString("yyyy/MM/d").Equals(date.ToString("yyyy/MM/d")))
                        {
                            duplicate = true;

                            MessageBox.Show("Duplicate Data cannot be added!", "Add Expense", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            break;
                        }
            }

            if (!duplicate)
            {
                dt.Rows.Add(expType, iouDirect, amount, date.ToShortDateString(), comment);

                eventExpensesGrid.DataSource = dt;

                double tot = 0.0;

                foreach (DataGridViewRow row in eventExpensesGrid.Rows)
                {
                    tot += Double.Parse(row.Cells[2].Value.ToString());
                }

                totalExpLbl.Text = "Rs. " + tot;
            }
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

        private void eventExpensesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (dgv.CurrentRow.Selected)
            {
                string expType = eventExpensesGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                double amount = Double.Parse(eventExpensesGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
                DateTime date = Convert.ToDateTime(eventExpensesGrid.Rows[e.RowIndex].Cells[3].Value.ToString());
                String iouDir = eventExpensesGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                string comment = eventExpensesGrid.Rows[e.RowIndex].Cells[4].Value.ToString();

                expTypeCmbBox.SelectedText = expType;
                amountTxtBox.Text = "" + amount;
                datePicker.Value = date;
                commentTxtBox.Text = comment;

                if (iouDir.Equals("Direct"))
                    directRadioBtn.Checked = true;
                else
                    iouRadioBtn.Checked = true;

                dt.Rows.RemoveAt(e.RowIndex);

                eventExpensesGrid.DataSource = dt;

                double tot = 0.0;

                foreach (DataGridViewRow row in eventExpensesGrid.Rows)
                {
                    tot += Double.Parse(row.Cells[2].Value.ToString());
                }

                totalExpLbl.Text = "Rs. " + tot;
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
            string errorMsg;

            if (!Validation.isDouble(amountTxtBox.Text))
            {
                e.Cancel = true;
                errorMsg = "Invalid amount!";

                amountTxtBox.Select(0, amountTxtBox.Text.Length);

                this.addEventExpErrorProvider.SetError(amountTxtBox, errorMsg);
            }
        }

        private void amountTxtBox_Validated(object sender, EventArgs e)
        {
            addEventExpErrorProvider.SetError(amountTxtBox, "");
            addEventExpErrorProvider.Clear();
        }

        private void datePicker_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            DateTime testingDate = datePicker.Value;

            if ((testingDate < from) || (testingDate > to))
            {
                e.Cancel = true;
                errorMsg = "Invalid Date!";
                
                this.addEventExpErrorProvider.SetError(datePicker, errorMsg);
            }
        }

        private void datePicker_Validated(object sender, EventArgs e)
        {
            addEventExpErrorProvider.SetError(datePicker, "");
            addEventExpErrorProvider.Clear();
        }

        private void addExpBtn_Click(object sender, EventArgs e)
        {
            string expType = "";
            string comment = "";
            double amount;

            if (expTypeCmbBox.SelectedItem != null)
            {
                expType = expTypeCmbBox.GetItemText(expTypeCmbBox.SelectedItem);

                if (Double.TryParse(amountTxtBox.Text, out amount))
                {
                    if (iouRadioBtn.Checked)
                    {
                        double totIou = amount;

                        foreach (DataGridViewRow row in eventExpensesGrid.Rows)
                        {
                            if (row.Cells[1].Value.ToString().Equals("IOU"))
                                totIou += Double.Parse(row.Cells[2].Value.ToString());
                        }

                        if (givenAmount < totIou)
                        {
                            MessageBox.Show("IOU total amount can't exceed the given amount above!", "Add Expense", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            DateTime expDate = datePicker.Value;
                            bool iou = iouRadioBtn.Checked;
                            bool direct = directRadioBtn.Checked;

                            if (!commentTxtBox.Text.Equals("") && (commentTxtBox.Text != null))
                            {
                                comment = commentTxtBox.Text;
                            }

                            fillDataGrid(expType, "IOU", amount, expDate, comment);
                        }
                    }
                    else
                    {
                        DateTime expDate = datePicker.Value;
                        bool iou = iouRadioBtn.Checked;
                        bool direct = directRadioBtn.Checked;

                        if (!commentTxtBox.Text.Equals("") && (commentTxtBox.Text != null))
                        {
                            comment = commentTxtBox.Text;
                        }

                        fillDataGrid(expType, "Direct", amount, expDate, comment);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the amount!", "Add Expense", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please choose the expense type!", "Add Expense", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void submitExpBtn_Click(object sender, EventArgs e)
        {
            ExpenseDetailEvent exp = null;

            foreach (DataGridViewRow row in eventExpensesGrid.Rows)
            {
                int expTypeId = 0;
                string expType = row.Cells[0].Value.ToString();
                double amount = Double.Parse(row.Cells[2].Value.ToString());
                DateTime date = Convert.ToDateTime(row.Cells[3].Value.ToString());
                String iouDir = row.Cells[1].Value.ToString();
                string comment = row.Cells[4].Value.ToString();

                DataTable tmp = (DataTable)expTypeCmbBox.DataSource;
                
                foreach (DataRow r in tmp.Rows)
                {
                    if (r[1].ToString() == expType)
                        expTypeId = Int32.Parse(r[0].ToString());
                }

                exp = new ExpenseDetailEvent(new ExpenseType(expTypeId), new Event(eventId), new Project(projId), amount, date, comment, iouDir);

                Database.addEventExpense(exp);
            }



            notifyIcon.Icon = SystemIcons.Application;
            notifyIcon.BalloonTipText = "Event Expenses Successfully added!";
            notifyIcon.ShowBalloonTip(200);

            expTypeCmbBox.SelectedIndex = 0;
            amountTxtBox.Text = "";
            datePicker.Value = DateTime.Today;
            commentTxtBox.Text = "";

            iouRadioBtn.Checked = true;

            dt.Rows.Clear();
            eventExpensesGrid.DataSource = dt;

            double tot = 0.0;

            foreach (DataGridViewRow row in eventExpensesGrid.Rows)
            {
                tot += Double.Parse(row.Cells[2].Value.ToString());
            }

            totalExpLbl.Text = "Rs. " + tot;
        }
    }
}
