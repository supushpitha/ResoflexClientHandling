namespace ResoflexClientHandlingSystem.ClientForms
{
    partial class ClientReportForm
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
            this.projectProfileBtn = new MetroFramework.Controls.MetroButton();
            this.fullReportBtn = new MetroFramework.Controls.MetroButton();
            this.reportPanel = new MetroFramework.Controls.MetroPanel();
            this.clientReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.clientCmbBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.horizontalLineLbl = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.fromDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.toDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.horizontalLineLblTwo = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.reportPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectProfileBtn
            // 
            this.projectProfileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.projectProfileBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.projectProfileBtn.Location = new System.Drawing.Point(23, 200);
            this.projectProfileBtn.Name = "projectProfileBtn";
            this.projectProfileBtn.Size = new System.Drawing.Size(163, 30);
            this.projectProfileBtn.TabIndex = 2;
            this.projectProfileBtn.Text = "Project Profile Report";
            this.projectProfileBtn.UseCustomBackColor = true;
            this.projectProfileBtn.UseSelectable = true;
            this.projectProfileBtn.Click += new System.EventHandler(this.projectProfileBtn_Click);
            // 
            // fullReportBtn
            // 
            this.fullReportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.fullReportBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.fullReportBtn.Location = new System.Drawing.Point(23, 440);
            this.fullReportBtn.Name = "fullReportBtn";
            this.fullReportBtn.Size = new System.Drawing.Size(163, 32);
            this.fullReportBtn.TabIndex = 3;
            this.fullReportBtn.Text = "Full Report";
            this.fullReportBtn.UseCustomBackColor = true;
            this.fullReportBtn.UseSelectable = true;
            // 
            // reportPanel
            // 
            this.reportPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportPanel.Controls.Add(this.clientReportViewer);
            this.reportPanel.HorizontalScrollbarBarColor = true;
            this.reportPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.reportPanel.HorizontalScrollbarSize = 10;
            this.reportPanel.Location = new System.Drawing.Point(304, 64);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(953, 633);
            this.reportPanel.TabIndex = 4;
            this.reportPanel.VerticalScrollbarBarColor = true;
            this.reportPanel.VerticalScrollbarHighlightOnWheel = false;
            this.reportPanel.VerticalScrollbarSize = 10;
            // 
            // clientReportViewer
            // 
            this.clientReportViewer.ActiveViewIndex = -1;
            this.clientReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.clientReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientReportViewer.Location = new System.Drawing.Point(0, 0);
            this.clientReportViewer.Name = "clientReportViewer";
            this.clientReportViewer.Size = new System.Drawing.Size(953, 633);
            this.clientReportViewer.TabIndex = 2;
            this.clientReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // clientCmbBox
            // 
            this.clientCmbBox.FormattingEnabled = true;
            this.clientCmbBox.ItemHeight = 23;
            this.clientCmbBox.Location = new System.Drawing.Point(23, 151);
            this.clientCmbBox.Name = "clientCmbBox";
            this.clientCmbBox.PromptText = "Select a Client";
            this.clientCmbBox.Size = new System.Drawing.Size(262, 29);
            this.clientCmbBox.TabIndex = 5;
            this.clientCmbBox.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(23, 102);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 25);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "By Client";
            // 
            // horizontalLineLbl
            // 
            this.horizontalLineLbl.AutoSize = true;
            this.horizontalLineLbl.Location = new System.Drawing.Point(10, 270);
            this.horizontalLineLbl.Name = "horizontalLineLbl";
            this.horizontalLineLbl.Size = new System.Drawing.Size(0, 0);
            this.horizontalLineLbl.TabIndex = 7;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(23, 346);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "From : ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(23, 393);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(57, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "To      : ";
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Location = new System.Drawing.Point(85, 346);
            this.fromDatePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(200, 29);
            this.fromDatePicker.TabIndex = 10;
            // 
            // toDatePicker
            // 
            this.toDatePicker.Location = new System.Drawing.Point(85, 393);
            this.toDatePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(200, 29);
            this.toDatePicker.TabIndex = 11;
            // 
            // horizontalLineLblTwo
            // 
            this.horizontalLineLblTwo.AutoSize = true;
            this.horizontalLineLblTwo.Location = new System.Drawing.Point(10, 490);
            this.horizontalLineLblTwo.Name = "horizontalLineLblTwo";
            this.horizontalLineLblTwo.Size = new System.Drawing.Size(0, 0);
            this.horizontalLineLblTwo.TabIndex = 12;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(23, 291);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(79, 25);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "By Date";
            // 
            // ClientReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.horizontalLineLblTwo);
            this.Controls.Add(this.toDatePicker);
            this.Controls.Add(this.fromDatePicker);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.horizontalLineLbl);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.clientCmbBox);
            this.Controls.Add(this.reportPanel);
            this.Controls.Add(this.fullReportBtn);
            this.Controls.Add(this.projectProfileBtn);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "ClientReportForm";
            this.Text = "Client Reports";
            this.Load += new System.EventHandler(this.ClientReportForm_Load);
            this.Shown += new System.EventHandler(this.ClientReportForm_Shown);
            this.reportPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton projectProfileBtn;
        private MetroFramework.Controls.MetroButton fullReportBtn;
        private MetroFramework.Controls.MetroPanel reportPanel;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer clientReportViewer;
        private MetroFramework.Controls.MetroComboBox clientCmbBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel horizontalLineLbl;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime fromDatePicker;
        private MetroFramework.Controls.MetroDateTime toDatePicker;
        private MetroFramework.Controls.MetroLabel horizontalLineLblTwo;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}