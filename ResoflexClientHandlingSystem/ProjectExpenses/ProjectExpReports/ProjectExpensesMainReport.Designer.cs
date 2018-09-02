namespace ResoflexClientHandlingSystem.ProjectExpenses.ProjectExpReports
{
    partial class ProjectExpensesMainReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crvProjExpMainViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvProjExpMainViewer
            // 
            this.crvProjExpMainViewer.ActiveViewIndex = -1;
            this.crvProjExpMainViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvProjExpMainViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvProjExpMainViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvProjExpMainViewer.Location = new System.Drawing.Point(0, 0);
            this.crvProjExpMainViewer.Name = "crvProjExpMainViewer";
            this.crvProjExpMainViewer.Size = new System.Drawing.Size(1101, 658);
            this.crvProjExpMainViewer.TabIndex = 0;
            this.crvProjExpMainViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ProjectExpensesMainReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 658);
            this.Controls.Add(this.crvProjExpMainViewer);
            this.Name = "ProjectExpensesMainReport";
            this.Text = "ProjectExpensesMainReport";
            this.Load += new System.EventHandler(this.ProjectExpensesMainReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvProjExpMainViewer;
    }
}