namespace ResoflexClientHandlingSystem
{
    partial class ScheduleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.schHome = new MetroFramework.Controls.MetroButton();
            this.schPrjName = new MetroFramework.Controls.MetroLabel();
            this.schCltName = new MetroFramework.Controls.MetroLabel();
            this.projectName = new MetroFramework.Controls.MetroTextBox();
            this.clientName = new MetroFramework.Controls.MetroTextBox();
            this.scheduleGrid = new MetroFramework.Controls.MetroGrid();
            this.totalScheduels = new MetroFramework.Controls.MetroTile();
            this.deleteSchedule = new MetroFramework.Controls.MetroButton();
            this.updateSchedule = new MetroFramework.Controls.MetroButton();
            this.addSchedule = new MetroFramework.Controls.MetroButton();
            this.addEvent = new MetroFramework.Controls.MetroButton();
            this.incompleteSchedules = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.reports = new MetroFramework.Controls.MetroButton();
            this.btnIou = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleGrid)).BeginInit();
            this.SuspendLayout();
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
            this.schHome.TabIndex = 3;
            this.schHome.UseSelectable = true;
            this.schHome.Click += new System.EventHandler(this.schHome_Click);
            // 
            // schPrjName
            // 
            this.schPrjName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.schPrjName.AutoSize = true;
            this.schPrjName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.schPrjName.Location = new System.Drawing.Point(234, 116);
            this.schPrjName.Name = "schPrjName";
            this.schPrjName.Size = new System.Drawing.Size(101, 19);
            this.schPrjName.TabIndex = 4;
            this.schPrjName.Text = "Project Name";
            // 
            // schCltName
            // 
            this.schCltName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.schCltName.AutoSize = true;
            this.schCltName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.schCltName.Location = new System.Drawing.Point(515, 116);
            this.schCltName.Name = "schCltName";
            this.schCltName.Size = new System.Drawing.Size(91, 19);
            this.schCltName.TabIndex = 5;
            this.schCltName.Text = "Client Name";
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
            this.projectName.TabIndex = 6;
            this.projectName.UseSelectable = true;
            this.projectName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.projectName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.projectName.TextChanged += new System.EventHandler(this.searchScheduleByProjectName_TextChanged);
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
            this.clientName.TabIndex = 7;
            this.clientName.UseSelectable = true;
            this.clientName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.clientName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.clientName.TextChanged += new System.EventHandler(this.searchScheduleByClientName_TextChanged);
            // 
            // scheduleGrid
            // 
            this.scheduleGrid.AllowUserToAddRows = false;
            this.scheduleGrid.AllowUserToDeleteRows = false;
            this.scheduleGrid.AllowUserToResizeRows = false;
            this.scheduleGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scheduleGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.scheduleGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.scheduleGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scheduleGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.scheduleGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.scheduleGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.scheduleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.scheduleGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.scheduleGrid.EnableHeadersVisualStyles = false;
            this.scheduleGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.scheduleGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.scheduleGrid.Location = new System.Drawing.Point(234, 154);
            this.scheduleGrid.Name = "scheduleGrid";
            this.scheduleGrid.ReadOnly = true;
            this.scheduleGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.scheduleGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.scheduleGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.scheduleGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.scheduleGrid.Size = new System.Drawing.Size(543, 374);
            this.scheduleGrid.TabIndex = 8;
            this.scheduleGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // totalScheduels
            // 
            this.totalScheduels.ActiveControl = null;
            this.totalScheduels.Location = new System.Drawing.Point(23, 307);
            this.totalScheduels.Name = "totalScheduels";
            this.totalScheduels.Size = new System.Drawing.Size(187, 87);
            this.totalScheduels.TabIndex = 9;
            this.totalScheduels.Tag = "";
            this.totalScheduels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalScheduels.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.totalScheduels.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.totalScheduels.UseSelectable = true;
            // 
            // deleteSchedule
            // 
            this.deleteSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteSchedule.Location = new System.Drawing.Point(681, 554);
            this.deleteSchedule.Name = "deleteSchedule";
            this.deleteSchedule.Size = new System.Drawing.Size(96, 23);
            this.deleteSchedule.TabIndex = 11;
            this.deleteSchedule.Text = "Delete Schedule";
            this.deleteSchedule.UseSelectable = true;
            this.deleteSchedule.Click += new System.EventHandler(this.deleteSchedule_Click);
            // 
            // updateSchedule
            // 
            this.updateSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateSchedule.Location = new System.Drawing.Point(532, 554);
            this.updateSchedule.Name = "updateSchedule";
            this.updateSchedule.Size = new System.Drawing.Size(96, 23);
            this.updateSchedule.TabIndex = 12;
            this.updateSchedule.Text = "View Schedule";
            this.updateSchedule.UseSelectable = true;
            this.updateSchedule.Click += new System.EventHandler(this.updateSchedule_OnClick);
            // 
            // addSchedule
            // 
            this.addSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addSchedule.Location = new System.Drawing.Point(380, 554);
            this.addSchedule.Name = "addSchedule";
            this.addSchedule.Size = new System.Drawing.Size(96, 23);
            this.addSchedule.TabIndex = 13;
            this.addSchedule.Text = "Add Schedule";
            this.addSchedule.UseSelectable = true;
            this.addSchedule.Click += new System.EventHandler(this.addSchedule_Click);
            // 
            // addEvent
            // 
            this.addEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addEvent.Location = new System.Drawing.Point(234, 554);
            this.addEvent.Name = "addEvent";
            this.addEvent.Size = new System.Drawing.Size(96, 23);
            this.addEvent.TabIndex = 15;
            this.addEvent.Text = "Add Event";
            this.addEvent.UseSelectable = true;
            this.addEvent.Click += new System.EventHandler(this.addEvent_Click);
            // 
            // incompleteSchedules
            // 
            this.incompleteSchedules.ActiveControl = null;
            this.incompleteSchedules.Location = new System.Drawing.Point(23, 176);
            this.incompleteSchedules.Name = "incompleteSchedules";
            this.incompleteSchedules.Size = new System.Drawing.Size(187, 87);
            this.incompleteSchedules.TabIndex = 16;
            this.incompleteSchedules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.incompleteSchedules.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.incompleteSchedules.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.incompleteSchedules.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(23, 154);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(154, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Incomplete Schedules";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(23, 285);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(112, 19);
            this.metroLabel3.TabIndex = 19;
            this.metroLabel3.Text = "Total Schedules";
            // 
            // reports
            // 
            this.reports.Location = new System.Drawing.Point(62, 420);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(102, 37);
            this.reports.TabIndex = 20;
            this.reports.Text = "Schedule Report";
            this.reports.UseSelectable = true;
            this.reports.Click += new System.EventHandler(this.reports_Click);
            // 
            // btnIou
            // 
            this.btnIou.Location = new System.Drawing.Point(62, 486);
            this.btnIou.Name = "btnIou";
            this.btnIou.Size = new System.Drawing.Size(102, 37);
            this.btnIou.TabIndex = 21;
            this.btnIou.Text = "Add IOU";
            this.btnIou.UseSelectable = true;
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnIou);
            this.Controls.Add(this.reports);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.incompleteSchedules);
            this.Controls.Add(this.addEvent);
            this.Controls.Add(this.addSchedule);
            this.Controls.Add(this.updateSchedule);
            this.Controls.Add(this.deleteSchedule);
            this.Controls.Add(this.totalScheduels);
            this.Controls.Add(this.scheduleGrid);
            this.Controls.Add(this.clientName);
            this.Controls.Add(this.projectName);
            this.Controls.Add(this.schCltName);
            this.Controls.Add(this.schPrjName);
            this.Controls.Add(this.schHome);
            this.Name = "ScheduleForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.ScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scheduleGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton schHome;
        private MetroFramework.Controls.MetroLabel schPrjName;
        private MetroFramework.Controls.MetroLabel schCltName;
        private MetroFramework.Controls.MetroTextBox projectName;
        private MetroFramework.Controls.MetroTextBox clientName;
        private MetroFramework.Controls.MetroGrid scheduleGrid;
        private MetroFramework.Controls.MetroTile totalScheduels;
        private MetroFramework.Controls.MetroButton deleteSchedule;
        private MetroFramework.Controls.MetroButton updateSchedule;
        private MetroFramework.Controls.MetroButton addSchedule;
        private MetroFramework.Controls.MetroButton addEvent;
        private MetroFramework.Controls.MetroTile incompleteSchedules;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton reports;
        private MetroFramework.Controls.MetroButton btnIou;
    }
}