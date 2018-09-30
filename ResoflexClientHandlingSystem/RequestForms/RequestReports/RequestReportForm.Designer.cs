namespace ResoflexClientHandlingSystem.RequestForms.RequestReports
{
    partial class RequestReportForm
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
            this.requestReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.horizontalLineLblTwo = new MetroFramework.Controls.MetroLabel();
            this.horizontalLineLbl = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.devCmbBox = new MetroFramework.Controls.MetroComboBox();
            this.fullReportBtn = new MetroFramework.Controls.MetroButton();
            this.reqRepBtn = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.requestReportViewer);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(302, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(955, 634);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // requestReportViewer
            // 
            this.requestReportViewer.ActiveViewIndex = -1;
            this.requestReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.requestReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.requestReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestReportViewer.Location = new System.Drawing.Point(0, 0);
            this.requestReportViewer.Name = "requestReportViewer";
            this.requestReportViewer.Size = new System.Drawing.Size(955, 634);
            this.requestReportViewer.TabIndex = 2;
            this.requestReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(23, 293);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(106, 25);
            this.metroLabel4.TabIndex = 24;
            this.metroLabel4.Text = "Full Report";
            // 
            // horizontalLineLblTwo
            // 
            this.horizontalLineLblTwo.AutoSize = true;
            this.horizontalLineLblTwo.Location = new System.Drawing.Point(10, 400);
            this.horizontalLineLblTwo.Name = "horizontalLineLblTwo";
            this.horizontalLineLblTwo.Size = new System.Drawing.Size(0, 0);
            this.horizontalLineLblTwo.TabIndex = 23;
            // 
            // horizontalLineLbl
            // 
            this.horizontalLineLbl.AutoSize = true;
            this.horizontalLineLbl.Location = new System.Drawing.Point(10, 272);
            this.horizontalLineLbl.Name = "horizontalLineLbl";
            this.horizontalLineLbl.Size = new System.Drawing.Size(0, 0);
            this.horizontalLineLbl.TabIndex = 18;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(23, 104);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(126, 25);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "By Developer";
            // 
            // devCmbBox
            // 
            this.devCmbBox.FormattingEnabled = true;
            this.devCmbBox.ItemHeight = 23;
            this.devCmbBox.Location = new System.Drawing.Point(23, 153);
            this.devCmbBox.Name = "devCmbBox";
            this.devCmbBox.PromptText = "Select a Developer";
            this.devCmbBox.Size = new System.Drawing.Size(262, 29);
            this.devCmbBox.TabIndex = 16;
            this.devCmbBox.UseSelectable = true;
            // 
            // fullReportBtn
            // 
            this.fullReportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.fullReportBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.fullReportBtn.Location = new System.Drawing.Point(23, 335);
            this.fullReportBtn.Name = "fullReportBtn";
            this.fullReportBtn.Size = new System.Drawing.Size(173, 32);
            this.fullReportBtn.TabIndex = 15;
            this.fullReportBtn.Text = "Full Report";
            this.fullReportBtn.UseCustomBackColor = true;
            this.fullReportBtn.UseSelectable = true;
            this.fullReportBtn.Click += new System.EventHandler(this.fullReportBtn_Click);
            // 
            // reqRepBtn
            // 
            this.reqRepBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.reqRepBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.reqRepBtn.Location = new System.Drawing.Point(23, 202);
            this.reqRepBtn.Name = "reqRepBtn";
            this.reqRepBtn.Size = new System.Drawing.Size(173, 30);
            this.reqRepBtn.TabIndex = 14;
            this.reqRepBtn.Text = "Change Request Report";
            this.reqRepBtn.UseCustomBackColor = true;
            this.reqRepBtn.UseSelectable = true;
            this.reqRepBtn.Click += new System.EventHandler(this.reqRepBtn_Click);
            // 
            // RequestReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.horizontalLineLblTwo);
            this.Controls.Add(this.horizontalLineLbl);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.devCmbBox);
            this.Controls.Add(this.fullReportBtn);
            this.Controls.Add(this.reqRepBtn);
            this.Controls.Add(this.metroPanel1);
            this.Name = "RequestReportForm";
            this.Text = "Request Reports";
            this.Load += new System.EventHandler(this.RequestReportForm_Load);
            this.Shown += new System.EventHandler(this.RequestReportForm_Shown);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer requestReportViewer;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel horizontalLineLblTwo;
        private MetroFramework.Controls.MetroLabel horizontalLineLbl;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox devCmbBox;
        private MetroFramework.Controls.MetroButton fullReportBtn;
        private MetroFramework.Controls.MetroButton reqRepBtn;
    }
}