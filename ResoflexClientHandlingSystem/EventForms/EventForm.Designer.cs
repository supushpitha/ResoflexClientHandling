namespace ResoflexClientHandlingSystem
{
    partial class EventForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventForm));
            this.addEvent = new MetroFramework.Controls.MetroButton();
            this.updateEvent = new MetroFramework.Controls.MetroButton();
            this.deleteEvent = new MetroFramework.Controls.MetroButton();
            this.eventGrid = new MetroFramework.Controls.MetroGrid();
            this.clientName = new MetroFramework.Controls.MetroTextBox();
            this.projectName = new MetroFramework.Controls.MetroTextBox();
            this.schCltName = new MetroFramework.Controls.MetroLabel();
            this.schPrjName = new MetroFramework.Controls.MetroLabel();
            this.schHome = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.incompleteEvents = new MetroFramework.Controls.MetroTile();
            this.totalEvents = new MetroFramework.Controls.MetroTile();
            this.btnExp = new MetroFramework.Controls.MetroButton();
            this.btnOtherReports = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.eventGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addEvent
            // 
            this.addEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addEvent.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.addEvent.Location = new System.Drawing.Point(681, 554);
            this.addEvent.Name = "addEvent";
            this.addEvent.Size = new System.Drawing.Size(96, 23);
            this.addEvent.TabIndex = 24;
            this.addEvent.Text = "Add Event";
            this.addEvent.UseSelectable = true;
            this.addEvent.Click += new System.EventHandler(this.addEvent_Click);
            // 
            // updateEvent
            // 
            this.updateEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateEvent.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.updateEvent.Location = new System.Drawing.Point(463, 554);
            this.updateEvent.Name = "updateEvent";
            this.updateEvent.Size = new System.Drawing.Size(90, 23);
            this.updateEvent.TabIndex = 23;
            this.updateEvent.Text = "View Event";
            this.updateEvent.UseSelectable = true;
            this.updateEvent.Click += new System.EventHandler(this.updateEvent_Click);
            // 
            // deleteEvent
            // 
            this.deleteEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteEvent.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.deleteEvent.Location = new System.Drawing.Point(234, 554);
            this.deleteEvent.Name = "deleteEvent";
            this.deleteEvent.Size = new System.Drawing.Size(96, 23);
            this.deleteEvent.TabIndex = 22;
            this.deleteEvent.Text = "Delete Event";
            this.deleteEvent.UseSelectable = true;
            this.deleteEvent.Click += new System.EventHandler(this.deleteEvent_Click);
            // 
            // eventGrid
            // 
            this.eventGrid.AllowUserToAddRows = false;
            this.eventGrid.AllowUserToDeleteRows = false;
            this.eventGrid.AllowUserToResizeRows = false;
            this.eventGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.eventGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.eventGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eventGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.eventGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.eventGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.eventGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.eventGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.eventGrid.EnableHeadersVisualStyles = false;
            this.eventGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.eventGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.eventGrid.Location = new System.Drawing.Point(234, 154);
            this.eventGrid.Name = "eventGrid";
            this.eventGrid.ReadOnly = true;
            this.eventGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.eventGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.eventGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.eventGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eventGrid.Size = new System.Drawing.Size(543, 374);
            this.eventGrid.TabIndex = 19;
            // 
            // clientName
            // 
            this.clientName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clientName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.clientName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.clientName.CustomButton.Image = null;
            this.clientName.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.clientName.CustomButton.Name = "";
            this.clientName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.clientName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.clientName.CustomButton.TabIndex = 1;
            this.clientName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.clientName.CustomButton.UseSelectable = true;
            this.clientName.CustomButton.Visible = false;
            this.clientName.Lines = new string[0];
            this.clientName.Location = new System.Drawing.Point(612, 116);
            this.clientName.MaxLength = 32767;
            this.clientName.Name = "clientName";
            this.clientName.PasswordChar = '\0';
            this.clientName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.clientName.SelectedText = "";
            this.clientName.SelectionLength = 0;
            this.clientName.SelectionStart = 0;
            this.clientName.ShortcutsEnabled = true;
            this.clientName.Size = new System.Drawing.Size(165, 23);
            this.clientName.TabIndex = 18;
            this.clientName.UseSelectable = true;
            this.clientName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.clientName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.clientName.TextChanged += new System.EventHandler(this.searchScheduleByClientName_TextChanged);
            // 
            // projectName
            // 
            this.projectName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.projectName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.projectName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.projectName.CustomButton.Image = null;
            this.projectName.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.projectName.CustomButton.Name = "";
            this.projectName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.projectName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.projectName.CustomButton.TabIndex = 1;
            this.projectName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.projectName.CustomButton.UseSelectable = true;
            this.projectName.CustomButton.Visible = false;
            this.projectName.Lines = new string[0];
            this.projectName.Location = new System.Drawing.Point(341, 116);
            this.projectName.MaxLength = 32767;
            this.projectName.Name = "projectName";
            this.projectName.PasswordChar = '\0';
            this.projectName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.projectName.SelectedText = "";
            this.projectName.SelectionLength = 0;
            this.projectName.SelectionStart = 0;
            this.projectName.ShortcutsEnabled = true;
            this.projectName.Size = new System.Drawing.Size(165, 23);
            this.projectName.TabIndex = 17;
            this.projectName.UseSelectable = true;
            this.projectName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.projectName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.projectName.TextChanged += new System.EventHandler(this.searchScheduleByProjectName_TextChanged);
            // 
            // schCltName
            // 
            this.schCltName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.schCltName.AutoSize = true;
            this.schCltName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.schCltName.Location = new System.Drawing.Point(515, 116);
            this.schCltName.Name = "schCltName";
            this.schCltName.Size = new System.Drawing.Size(91, 19);
            this.schCltName.TabIndex = 16;
            this.schCltName.Text = "Client Name";
            // 
            // schPrjName
            // 
            this.schPrjName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.schPrjName.AutoSize = true;
            this.schPrjName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.schPrjName.Location = new System.Drawing.Point(234, 116);
            this.schPrjName.Name = "schPrjName";
            this.schPrjName.Size = new System.Drawing.Size(101, 19);
            this.schPrjName.TabIndex = 15;
            this.schPrjName.Text = "Project Name";
            // 
            // schHome
            // 
            this.schHome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.schHome.BackColor = System.Drawing.Color.Transparent;
            this.schHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("schHome.BackgroundImage")));
            this.schHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.schHome.Location = new System.Drawing.Point(380, 40);
            this.schHome.Margin = new System.Windows.Forms.Padding(2);
            this.schHome.Name = "schHome";
            this.schHome.Size = new System.Drawing.Size(30, 24);
            this.schHome.TabIndex = 14;
            this.schHome.UseSelectable = true;
            this.schHome.Click += new System.EventHandler(this.schHome_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(23, 275);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(88, 19);
            this.metroLabel3.TabIndex = 30;
            this.metroLabel3.Text = "Total Events";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(23, 154);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(130, 19);
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "Incomplete Events";
            // 
            // incompleteEvents
            // 
            this.incompleteEvents.ActiveControl = null;
            this.incompleteEvents.Location = new System.Drawing.Point(23, 176);
            this.incompleteEvents.Name = "incompleteEvents";
            this.incompleteEvents.Size = new System.Drawing.Size(187, 87);
            this.incompleteEvents.TabIndex = 27;
            this.incompleteEvents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.incompleteEvents.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.incompleteEvents.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.incompleteEvents.UseSelectable = true;
            // 
            // totalEvents
            // 
            this.totalEvents.ActiveControl = null;
            this.totalEvents.Location = new System.Drawing.Point(23, 297);
            this.totalEvents.Name = "totalEvents";
            this.totalEvents.Size = new System.Drawing.Size(187, 87);
            this.totalEvents.TabIndex = 25;
            this.totalEvents.Tag = "";
            this.totalEvents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalEvents.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.totalEvents.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.totalEvents.UseSelectable = true;
            // 
            // btnExp
            // 
            this.btnExp.Location = new System.Drawing.Point(62, 467);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(102, 37);
            this.btnExp.TabIndex = 32;
            this.btnExp.Text = "Add Expences";
            this.btnExp.UseSelectable = true;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // btnOtherReports
            // 
            this.btnOtherReports.Location = new System.Drawing.Point(62, 419);
            this.btnOtherReports.Name = "btnOtherReports";
            this.btnOtherReports.Size = new System.Drawing.Size(102, 37);
            this.btnOtherReports.TabIndex = 33;
            this.btnOtherReports.Text = "Reports";
            this.btnOtherReports.UseSelectable = true;
            this.btnOtherReports.Click += new System.EventHandler(this.btnOtherReports_Click);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnOtherReports);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.incompleteEvents);
            this.Controls.Add(this.totalEvents);
            this.Controls.Add(this.addEvent);
            this.Controls.Add(this.updateEvent);
            this.Controls.Add(this.deleteEvent);
            this.Controls.Add(this.eventGrid);
            this.Controls.Add(this.clientName);
            this.Controls.Add(this.projectName);
            this.Controls.Add(this.schCltName);
            this.Controls.Add(this.schPrjName);
            this.Controls.Add(this.schHome);
            this.Name = "EventForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Event";
            this.Load += new System.EventHandler(this.EventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton addEvent;
        private MetroFramework.Controls.MetroButton updateEvent;
        private MetroFramework.Controls.MetroButton deleteEvent;
        private MetroFramework.Controls.MetroGrid eventGrid;
        private MetroFramework.Controls.MetroTextBox clientName;
        private MetroFramework.Controls.MetroTextBox projectName;
        private MetroFramework.Controls.MetroLabel schCltName;
        private MetroFramework.Controls.MetroLabel schPrjName;
        private MetroFramework.Controls.MetroButton schHome;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile incompleteEvents;
        private MetroFramework.Controls.MetroTile totalEvents;
        private MetroFramework.Controls.MetroButton btnExp;
        private MetroFramework.Controls.MetroButton btnOtherReports;
    }
}