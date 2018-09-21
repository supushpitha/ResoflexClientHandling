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
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.reportPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 142);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(154, 23);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Test Btn 1";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // reportPanel
            // 
            this.reportPanel.Controls.Add(this.crvProjExpMainViewer);
            this.reportPanel.HorizontalScrollbarBarColor = true;
            this.reportPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.reportPanel.HorizontalScrollbarSize = 10;
            this.reportPanel.Location = new System.Drawing.Point(289, 28);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(959, 687);
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
            this.crvProjExpMainViewer.Size = new System.Drawing.Size(959, 687);
            this.crvProjExpMainViewer.TabIndex = 2;
            this.crvProjExpMainViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(24, 172);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(153, 23);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "Test Btn 2";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // GenarateReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 738);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.reportPanel);
            this.Controls.Add(this.metroButton1);
            this.Name = "GenarateReportForm";
            this.Text = "Get Reports";
            this.Load += new System.EventHandler(this.GenarateReportForm_Load);
            this.reportPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroPanel reportPanel;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvProjExpMainViewer;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}