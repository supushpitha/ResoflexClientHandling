namespace ResoflexClientHandlingSystem.EventForms.EventReports
{
    partial class OtherReports
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.crystalReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reportTime = new MetroFramework.Controls.MetroDateTime();
            this.btnWorst = new MetroFramework.Controls.MetroButton();
            this.btnBest = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.crystalReport);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(181, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(596, 514);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // crystalReport
            // 
            this.crystalReport.ActiveViewIndex = -1;
            this.crystalReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReport.Location = new System.Drawing.Point(0, 0);
            this.crystalReport.Name = "crystalReport";
            this.crystalReport.Size = new System.Drawing.Size(596, 514);
            this.crystalReport.TabIndex = 2;
            this.crystalReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // reportTime
            // 
            this.reportTime.CustomFormat = "yyyy-MM";
            this.reportTime.DisplayFocus = true;
            this.reportTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.reportTime.Location = new System.Drawing.Point(23, 154);
            this.reportTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.reportTime.Name = "reportTime";
            this.reportTime.Size = new System.Drawing.Size(133, 29);
            this.reportTime.TabIndex = 1;
            // 
            // btnWorst
            // 
            this.btnWorst.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnWorst.Location = new System.Drawing.Point(23, 220);
            this.btnWorst.Name = "btnWorst";
            this.btnWorst.Size = new System.Drawing.Size(133, 63);
            this.btnWorst.TabIndex = 2;
            this.btnWorst.Text = "Worst Performance";
            this.btnWorst.UseSelectable = true;
            this.btnWorst.Click += new System.EventHandler(this.btnWorst_Click);
            // 
            // btnBest
            // 
            this.btnBest.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBest.Location = new System.Drawing.Point(23, 307);
            this.btnBest.Name = "btnBest";
            this.btnBest.Size = new System.Drawing.Size(133, 63);
            this.btnBest.TabIndex = 3;
            this.btnBest.Text = "Best Performance";
            this.btnBest.UseSelectable = true;
            this.btnBest.Click += new System.EventHandler(this.btnBest_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(13, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(162, 25);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Service Engineers";
            // 
            // OtherReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnBest);
            this.Controls.Add(this.btnWorst);
            this.Controls.Add(this.reportTime);
            this.Controls.Add(this.metroPanel1);
            this.Name = "OtherReports";
            this.Text = "Other Reports";
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReport;
        private MetroFramework.Controls.MetroDateTime reportTime;
        private MetroFramework.Controls.MetroButton btnWorst;
        private MetroFramework.Controls.MetroButton btnBest;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}