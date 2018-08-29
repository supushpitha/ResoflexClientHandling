using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResoflexClientHandlingSystem.ProjectExpenses.ProjectExpReports
{
    public partial class ProjectExpensesMainReport : Form
    {
        string qry = "";

        public ProjectExpensesMainReport()
        {
            InitializeComponent();
        }

        public ProjectExpensesMainReport(string qry)
        {
            InitializeComponent();

            this.qry = qry;
        }

        private void ProjectExpensesMainReport_Load(object sender, EventArgs e)
        {
            MonthlyProjectExpReport rpt = new MonthlyProjectExpReport();
            
            crvProjExpMainViewer.ReportSource = null;
            crvProjExpMainViewer.ReportSource = rpt;
        }
    }
}
