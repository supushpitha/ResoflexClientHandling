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
    public partial class CashIssuingForm : MetroFramework.Forms.MetroForm
    {
        private int projId, schNo;
        private string projectName, clientName, travelling, accom, visitType;
        private DateTime from, to;
        
        public CashIssuingForm()
        {
            InitializeComponent();

            this.projId = 1;
            this.schNo = 2;
            this.projectName = "Testing project name";
            this.clientName = "Testing client name";
            this.travelling = "testing travel";
            this.accom = "testing accomm";
            this.visitType = "Maintenance";
            this.from = DateTime.Today.AddDays(-3);
            this.to = DateTime.Today;
        }


        public CashIssuingForm(int projId, int schNo, string projectName, string clientName, DateTime from, DateTime to, string travelling, string accom, string visitType)
        {
            InitializeComponent();

            this.projId = projId;
            this.schNo = schNo;
            this.projectName = projectName;
            this.clientName = clientName;
            this.travelling = travelling;
            this.accom = accom;
            this.visitType = visitType;
            this.from = from;
            this.to = to;
        }

        private void CashIssuingForm_Load(object sender, EventArgs e)
        {

        }

        private void CashIssuingForm_Shown(object sender, EventArgs e)
        {
            verticalLineDetailsLbl.AutoSize = false;
            verticalLineDetailsLbl.Width = 2;
            verticalLineDetailsLbl.Height = 130;
            verticalLineDetailsLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            horizontalLineDetailLbl.AutoSize = false;
            horizontalLineDetailLbl.Height = 2;
            horizontalLineDetailLbl.Width = 790;
            horizontalLineDetailLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            projectNameLbl.Text = projectName;
            clientNameLbl.Text = clientName;
            fromDateLbl.Text = from.ToString("yyyy/MM/d");
            toDateLbl.Text = to.ToString("yyyy/MM/d");
            travellingLbl.Text = travelling;
            accLbl.Text = accom;

            fillCalculatableLables();
        }

        private void fillCalculatableLables()
        {
            try
            {
                MySqlDataReader reader = DBConnection.getData("SELECT IFNULL(COUNT(et.staff_id), 0) as noOfTech FROM schedule_technicians et WHERE et.proj_id=" + projId + " AND et.sch_no=" + schNo + " GROUP BY et.proj_id, et.sch_no;");

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
        }
        
        private void amountTxtBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!Validation.isDouble(amountTxtBox.Text))
            {
                e.Cancel = true;
                errorMsg = "Invalid amount!";

                amountTxtBox.Select(0, amountTxtBox.Text.Length);

                this.errorProviderIssueCash.SetError(amountTxtBox, errorMsg);
            }
        }

        private void amountTxtBox_Validated(object sender, EventArgs e)
        {
            errorProviderIssueCash.SetError(amountTxtBox, "");
            errorProviderIssueCash.Clear();
        }

        private void cashIssueBtn_Click(object sender, EventArgs e)
        {
            double amount;

            if (Double.TryParse(amountTxtBox.Text, out amount))
            {
                Iou iou = new Iou();

                iou.Amount = Double.Parse(amountTxtBox.Text);
                iou.ProjectOfIou = new Project(projId);
                iou.ScheduleOfIou = new Schedule(schNo);
                iou.Date = DateTime.Today;

                if (!commentTxtBox.Text.Equals("") && (commentTxtBox.Text != null))
                {
                    iou.Detail = commentTxtBox.Text;
                }
                else
                {
                    iou.Detail = "";
                }

                try
                {
                    Database.IssueCash(iou);

                    notifyIconIssueCash.Icon = SystemIcons.Application;
                    notifyIconIssueCash.BalloonTipText = "Cash Successfully Issued!";
                    notifyIconIssueCash.ShowBalloonTip(200);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Please enter the amount!", "Add Expense", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
