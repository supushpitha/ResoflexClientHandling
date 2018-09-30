namespace ResoflexClientHandlingSystem
{
    partial class GenarateReportForm
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.reportPanel = new MetroFramework.Controls.MetroPanel();
            this.crvProjExpMainViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reportPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Location = new System.Drawing.Point(23, 111);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(182, 34);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Event Expense Full Report";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // reportPanel
            // 
            this.reportPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportPanel.Controls.Add(this.crvProjExpMainViewer);
            this.reportPanel.HorizontalScrollbarBarColor = true;
            this.reportPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.reportPanel.HorizontalScrollbarSize = 10;
            this.reportPanel.Location = new System.Drawing.Point(224, 63);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(1024, 652);
            this.reportPanel.TabIndex = 1;
            this.reportPanel.VerticalScrollbarBarColor = true;
            this.reportPanel.VerticalScrollbarHighlightOnWheel = false;
            this.reportPanel.VerticalScrollbarSize = 10;
            // 
            // crvProjExpMainViewer
            // 
            this.crvProjExpMainViewer.ActiveViewIndex = -1;
            this.crvProjExpMainViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvProjExpMainViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvProjExpMainViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvProjExpMainViewer.Location = new System.Drawing.Point(0, 0);
            this.crvProjExpMainViewer.Name = "crvProjExpMainViewer";
            this.crvProjExpMainViewer.Size = new System.Drawing.Size(1024, 652);
            this.crvProjExpMainViewer.TabIndex = 2;
            this.crvProjExpMainViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // GenarateReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 738);
            this.Controls.Add(this.reportPanel);
            this.Controls.Add(this.metroButton1);
            this.Name = "GenarateReportForm";
            this.Text = "Get Reports";
            this.Load += new System.EventHandler(this.GenarateReportForm_Load);
            this.Shown += new System.EventHandler(this.GenarateReportForm_Shown);
            this.reportPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroPanel reportPanel;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvProjExpMainViewer;
    }
}