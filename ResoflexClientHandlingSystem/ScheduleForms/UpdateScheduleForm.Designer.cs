namespace ResoflexClientHandlingSystem.ScheduleForms
{
    partial class UpdateScheduleForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.removeSerEng = new MetroFramework.Controls.MetroButton();
            this.serviceEngGrid = new MetroFramework.Controls.MetroGrid();
            this.schEndTime = new System.Windows.Forms.DateTimePicker();
            this.schStartTime = new System.Windows.Forms.DateTimePicker();
            this.schEndDate = new System.Windows.Forms.DateTimePicker();
            this.schStartDate = new System.Windows.Forms.DateTimePicker();
            this.scheduleType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.accomodation = new MetroFramework.Controls.MetroComboBox();
            this.travelingMode = new MetroFramework.Controls.MetroComboBox();
            this.prevSchedulesGrid = new MetroFramework.Controls.MetroGrid();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.schLogs = new MetroFramework.Controls.MetroTextBox();
            this.schClientName = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.schCancel = new MetroFramework.Controls.MetroButton();
            this.schReset = new MetroFramework.Controls.MetroButton();
            this.schSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.checkList = new MetroFramework.Controls.MetroTextBox();
            this.notifyIconSch = new System.Windows.Forms.NotifyIcon(this.components);
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.resoQty = new MetroFramework.Controls.MetroTextBox();
            this.removeReso = new MetroFramework.Controls.MetroButton();
            this.resoGrid = new MetroFramework.Controls.MetroGrid();
            this.schResoCombo = new MetroFramework.Controls.MetroComboBox();
            this.addReso = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.meals = new MetroFramework.Controls.MetroTextBox();
            this.schSendMail = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.addEng = new MetroFramework.Controls.MetroButton();
            this.serviceEngCombo = new MetroFramework.Controls.MetroComboBox();
            this.todoList = new MetroFramework.Controls.MetroTextBox();
            this.schNo = new MetroFramework.Controls.MetroTextBox();
            this.projectName = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.serviceEngGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevSchedulesGrid)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // removeSerEng
            // 
            this.removeSerEng.Location = new System.Drawing.Point(270, 360);
            this.removeSerEng.Name = "removeSerEng";
            this.removeSerEng.Size = new System.Drawing.Size(69, 23);
            this.removeSerEng.TabIndex = 52;
            this.removeSerEng.Text = "Remove";
            this.removeSerEng.UseSelectable = true;
            this.removeSerEng.Click += new System.EventHandler(this.removeSerEng_Click);
            // 
            // serviceEngGrid
            // 
            this.serviceEngGrid.AllowUserToAddRows = false;
            this.serviceEngGrid.AllowUserToDeleteRows = false;
            this.serviceEngGrid.AllowUserToResizeRows = false;
            this.serviceEngGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.serviceEngGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.serviceEngGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serviceEngGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.serviceEngGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serviceEngGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.serviceEngGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.serviceEngGrid.DefaultCellStyle = dataGridViewCellStyle11;
            this.serviceEngGrid.EnableHeadersVisualStyles = false;
            this.serviceEngGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.serviceEngGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.serviceEngGrid.Location = new System.Drawing.Point(139, 251);
            this.serviceEngGrid.Name = "serviceEngGrid";
            this.serviceEngGrid.ReadOnly = true;
            this.serviceEngGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serviceEngGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.serviceEngGrid.RowHeadersWidth = 20;
            this.serviceEngGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.serviceEngGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.serviceEngGrid.Size = new System.Drawing.Size(199, 103);
            this.serviceEngGrid.TabIndex = 51;
            // 
            // schEndTime
            // 
            this.schEndTime.CustomFormat = "HH:mm:ss";
            this.schEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.schEndTime.Location = new System.Drawing.Point(613, 98);
            this.schEndTime.Name = "schEndTime";
            this.schEndTime.ShowUpDown = true;
            this.schEndTime.Size = new System.Drawing.Size(95, 20);
            this.schEndTime.TabIndex = 50;
            // 
            // schStartTime
            // 
            this.schStartTime.CustomFormat = "HH:mm:ss";
            this.schStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.schStartTime.Location = new System.Drawing.Point(613, 58);
            this.schStartTime.Name = "schStartTime";
            this.schStartTime.ShowUpDown = true;
            this.schStartTime.Size = new System.Drawing.Size(95, 20);
            this.schStartTime.TabIndex = 49;
            // 
            // schEndDate
            // 
            this.schEndDate.CustomFormat = "yyyy-MM-dd";
            this.schEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.schEndDate.Location = new System.Drawing.Point(508, 99);
            this.schEndDate.Name = "schEndDate";
            this.schEndDate.Size = new System.Drawing.Size(99, 20);
            this.schEndDate.TabIndex = 48;
            // 
            // schStartDate
            // 
            this.schStartDate.CustomFormat = "yyyy-MM-dd";
            this.schStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.schStartDate.Location = new System.Drawing.Point(508, 58);
            this.schStartDate.Name = "schStartDate";
            this.schStartDate.Size = new System.Drawing.Size(99, 20);
            this.schStartDate.TabIndex = 47;
            // 
            // scheduleType
            // 
            this.scheduleType.FormattingEnabled = true;
            this.scheduleType.ItemHeight = 23;
            this.scheduleType.Location = new System.Drawing.Point(139, 80);
            this.scheduleType.Name = "scheduleType";
            this.scheduleType.Size = new System.Drawing.Size(199, 29);
            this.scheduleType.TabIndex = 46;
            this.scheduleType.UseSelectable = true;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel17.Location = new System.Drawing.Point(3, 85);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(105, 19);
            this.metroLabel17.TabIndex = 45;
            this.metroLabel17.Text = "Schedule Type";
            // 
            // accomodation
            // 
            this.accomodation.FormattingEnabled = true;
            this.accomodation.ItemHeight = 23;
            this.accomodation.Location = new System.Drawing.Point(508, 171);
            this.accomodation.Name = "accomodation";
            this.accomodation.Size = new System.Drawing.Size(200, 29);
            this.accomodation.TabIndex = 44;
            this.accomodation.UseSelectable = true;
            // 
            // travelingMode
            // 
            this.travelingMode.FormattingEnabled = true;
            this.travelingMode.ItemHeight = 23;
            this.travelingMode.Location = new System.Drawing.Point(508, 132);
            this.travelingMode.Name = "travelingMode";
            this.travelingMode.Size = new System.Drawing.Size(200, 29);
            this.travelingMode.TabIndex = 43;
            this.travelingMode.UseSelectable = true;
            // 
            // prevSchedulesGrid
            // 
            this.prevSchedulesGrid.AllowUserToAddRows = false;
            this.prevSchedulesGrid.AllowUserToDeleteRows = false;
            this.prevSchedulesGrid.AllowUserToResizeRows = false;
            this.prevSchedulesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prevSchedulesGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.prevSchedulesGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prevSchedulesGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.prevSchedulesGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prevSchedulesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.prevSchedulesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prevSchedulesGrid.DefaultCellStyle = dataGridViewCellStyle14;
            this.prevSchedulesGrid.EnableHeadersVisualStyles = false;
            this.prevSchedulesGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.prevSchedulesGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.prevSchedulesGrid.Location = new System.Drawing.Point(736, 49);
            this.prevSchedulesGrid.Name = "prevSchedulesGrid";
            this.prevSchedulesGrid.ReadOnly = true;
            this.prevSchedulesGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prevSchedulesGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.prevSchedulesGrid.RowHeadersWidth = 20;
            this.prevSchedulesGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.prevSchedulesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prevSchedulesGrid.Size = new System.Drawing.Size(333, 444);
            this.prevSchedulesGrid.TabIndex = 42;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel16.Location = new System.Drawing.Point(736, 19);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(137, 19);
            this.metroLabel16.TabIndex = 41;
            this.metroLabel16.Text = "Previous Schedules";
            // 
            // schLogs
            // 
            // 
            // 
            // 
            this.schLogs.CustomButton.Image = null;
            this.schLogs.CustomButton.Location = new System.Drawing.Point(110, 2);
            this.schLogs.CustomButton.Name = "";
            this.schLogs.CustomButton.Size = new System.Drawing.Size(87, 87);
            this.schLogs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.schLogs.CustomButton.TabIndex = 1;
            this.schLogs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.schLogs.CustomButton.UseSelectable = true;
            this.schLogs.CustomButton.Visible = false;
            this.schLogs.Lines = new string[0];
            this.schLogs.Location = new System.Drawing.Point(139, 401);
            this.schLogs.MaxLength = 32767;
            this.schLogs.Multiline = true;
            this.schLogs.Name = "schLogs";
            this.schLogs.PasswordChar = '\0';
            this.schLogs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.schLogs.SelectedText = "";
            this.schLogs.SelectionLength = 0;
            this.schLogs.SelectionStart = 0;
            this.schLogs.ShortcutsEnabled = true;
            this.schLogs.Size = new System.Drawing.Size(200, 92);
            this.schLogs.TabIndex = 40;
            this.schLogs.UseSelectable = true;
            this.schLogs.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.schLogs.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // schClientName
            // 
            this.schClientName.FormattingEnabled = true;
            this.schClientName.ItemHeight = 23;
            this.schClientName.Location = new System.Drawing.Point(508, 12);
            this.schClientName.Name = "schClientName";
            this.schClientName.Size = new System.Drawing.Size(200, 29);
            this.schClientName.TabIndex = 37;
            this.schClientName.UseSelectable = true;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel15.Location = new System.Drawing.Point(5, 401);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(40, 19);
            this.metroLabel15.TabIndex = 36;
            this.metroLabel15.Text = "Logs";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel14.Location = new System.Drawing.Point(366, 99);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(134, 19);
            this.metroLabel14.TabIndex = 35;
            this.metroLabel14.Text = "End Date and Time";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel13.Location = new System.Drawing.Point(366, 59);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(142, 19);
            this.metroLabel13.TabIndex = 34;
            this.metroLabel13.Text = "Start Date and Time";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.Location = new System.Drawing.Point(366, 19);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(91, 19);
            this.metroLabel12.TabIndex = 33;
            this.metroLabel12.Text = "Client Name";
            // 
            // schCancel
            // 
            this.schCancel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.schCancel.Location = new System.Drawing.Point(963, 544);
            this.schCancel.Name = "schCancel";
            this.schCancel.Size = new System.Drawing.Size(115, 23);
            this.schCancel.TabIndex = 32;
            this.schCancel.Text = "Cancel";
            this.schCancel.UseSelectable = true;
            this.schCancel.Click += new System.EventHandler(this.schCancel_Click);
            // 
            // schReset
            // 
            this.schReset.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.schReset.Location = new System.Drawing.Point(230, 547);
            this.schReset.Name = "schReset";
            this.schReset.Size = new System.Drawing.Size(115, 23);
            this.schReset.TabIndex = 30;
            this.schReset.Text = "Clear";
            this.schReset.UseSelectable = true;
            // 
            // schSave
            // 
            this.schSave.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.schSave.Location = new System.Drawing.Point(5, 547);
            this.schSave.Name = "schSave";
            this.schSave.Size = new System.Drawing.Size(115, 23);
            this.schSave.TabIndex = 29;
            this.schSave.Text = "Save Updates";
            this.schSave.UseSelectable = true;
            this.schSave.Click += new System.EventHandler(this.validation);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(486, 18);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(135, 25);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "View Schedule";
            // 
            // checkList
            // 
            // 
            // 
            // 
            this.checkList.CustomButton.Image = null;
            this.checkList.CustomButton.Location = new System.Drawing.Point(116, 2);
            this.checkList.CustomButton.Name = "";
            this.checkList.CustomButton.Size = new System.Drawing.Size(81, 81);
            this.checkList.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.checkList.CustomButton.TabIndex = 1;
            this.checkList.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.checkList.CustomButton.UseSelectable = true;
            this.checkList.CustomButton.Visible = false;
            this.checkList.Lines = new string[0];
            this.checkList.Location = new System.Drawing.Point(508, 247);
            this.checkList.MaxLength = 32767;
            this.checkList.Multiline = true;
            this.checkList.Name = "checkList";
            this.checkList.PasswordChar = '\0';
            this.checkList.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.checkList.SelectedText = "";
            this.checkList.SelectionLength = 0;
            this.checkList.SelectionStart = 0;
            this.checkList.ShortcutsEnabled = true;
            this.checkList.Size = new System.Drawing.Size(200, 86);
            this.checkList.TabIndex = 28;
            this.checkList.UseSelectable = true;
            this.checkList.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.checkList.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // notifyIconSch
            // 
            this.notifyIconSch.Text = "notifyIcon1";
            this.notifyIconSch.Visible = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.AutoScroll = true;
            this.metroPanel1.Controls.Add(this.resoQty);
            this.metroPanel1.Controls.Add(this.removeReso);
            this.metroPanel1.Controls.Add(this.resoGrid);
            this.metroPanel1.Controls.Add(this.schResoCombo);
            this.metroPanel1.Controls.Add(this.addReso);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.removeSerEng);
            this.metroPanel1.Controls.Add(this.serviceEngGrid);
            this.metroPanel1.Controls.Add(this.schEndTime);
            this.metroPanel1.Controls.Add(this.schStartTime);
            this.metroPanel1.Controls.Add(this.schEndDate);
            this.metroPanel1.Controls.Add(this.schStartDate);
            this.metroPanel1.Controls.Add(this.scheduleType);
            this.metroPanel1.Controls.Add(this.metroLabel17);
            this.metroPanel1.Controls.Add(this.accomodation);
            this.metroPanel1.Controls.Add(this.travelingMode);
            this.metroPanel1.Controls.Add(this.prevSchedulesGrid);
            this.metroPanel1.Controls.Add(this.metroLabel16);
            this.metroPanel1.Controls.Add(this.schLogs);
            this.metroPanel1.Controls.Add(this.schClientName);
            this.metroPanel1.Controls.Add(this.metroLabel15);
            this.metroPanel1.Controls.Add(this.metroLabel14);
            this.metroPanel1.Controls.Add(this.metroLabel13);
            this.metroPanel1.Controls.Add(this.metroLabel12);
            this.metroPanel1.Controls.Add(this.schCancel);
            this.metroPanel1.Controls.Add(this.schReset);
            this.metroPanel1.Controls.Add(this.schSave);
            this.metroPanel1.Controls.Add(this.checkList);
            this.metroPanel1.Controls.Add(this.meals);
            this.metroPanel1.Controls.Add(this.schSendMail);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.addEng);
            this.metroPanel1.Controls.Add(this.serviceEngCombo);
            this.metroPanel1.Controls.Add(this.todoList);
            this.metroPanel1.Controls.Add(this.schNo);
            this.metroPanel1.Controls.Add(this.projectName);
            this.metroPanel1.Controls.Add(this.metroLabel11);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbar = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1080, 570);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbar = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // resoQty
            // 
            // 
            // 
            // 
            this.resoQty.CustomButton.Image = null;
            this.resoQty.CustomButton.Location = new System.Drawing.Point(19, 1);
            this.resoQty.CustomButton.Name = "";
            this.resoQty.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.resoQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.resoQty.CustomButton.TabIndex = 1;
            this.resoQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.resoQty.CustomButton.UseSelectable = true;
            this.resoQty.CustomButton.Visible = false;
            this.resoQty.Lines = new string[] {
        "0"};
            this.resoQty.Location = new System.Drawing.Point(660, 342);
            this.resoQty.MaxLength = 32767;
            this.resoQty.Name = "resoQty";
            this.resoQty.PasswordChar = '\0';
            this.resoQty.PromptText = "qty";
            this.resoQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.resoQty.SelectedText = "";
            this.resoQty.SelectionLength = 0;
            this.resoQty.SelectionStart = 0;
            this.resoQty.ShortcutsEnabled = true;
            this.resoQty.Size = new System.Drawing.Size(47, 29);
            this.resoQty.TabIndex = 62;
            this.resoQty.Text = "0";
            this.resoQty.UseSelectable = true;
            this.resoQty.WaterMark = "qty";
            this.resoQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.resoQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // removeReso
            // 
            this.removeReso.Location = new System.Drawing.Point(638, 470);
            this.removeReso.Name = "removeReso";
            this.removeReso.Size = new System.Drawing.Size(69, 23);
            this.removeReso.TabIndex = 61;
            this.removeReso.Text = "Remove";
            this.removeReso.UseSelectable = true;
            this.removeReso.Click += new System.EventHandler(this.removeResource_Click);
            // 
            // resoGrid
            // 
            this.resoGrid.AllowUserToAddRows = false;
            this.resoGrid.AllowUserToDeleteRows = false;
            this.resoGrid.AllowUserToResizeRows = false;
            this.resoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resoGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.resoGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resoGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.resoGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resoGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.resoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.resoGrid.DefaultCellStyle = dataGridViewCellStyle17;
            this.resoGrid.EnableHeadersVisualStyles = false;
            this.resoGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.resoGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.resoGrid.Location = new System.Drawing.Point(509, 380);
            this.resoGrid.Name = "resoGrid";
            this.resoGrid.ReadOnly = true;
            this.resoGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resoGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.resoGrid.RowHeadersWidth = 20;
            this.resoGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.resoGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resoGrid.Size = new System.Drawing.Size(199, 87);
            this.resoGrid.TabIndex = 60;
            // 
            // schResoCombo
            // 
            this.schResoCombo.FormattingEnabled = true;
            this.schResoCombo.ItemHeight = 23;
            this.schResoCombo.Location = new System.Drawing.Point(508, 342);
            this.schResoCombo.Name = "schResoCombo";
            this.schResoCombo.Size = new System.Drawing.Size(146, 29);
            this.schResoCombo.TabIndex = 59;
            this.schResoCombo.UseSelectable = true;
            // 
            // addReso
            // 
            this.addReso.Location = new System.Drawing.Point(508, 470);
            this.addReso.Name = "addReso";
            this.addReso.Size = new System.Drawing.Size(69, 23);
            this.addReso.TabIndex = 58;
            this.addReso.Text = "Add";
            this.addReso.UseSelectable = true;
            this.addReso.Click += new System.EventHandler(this.addResource_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(367, 342);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(76, 19);
            this.metroLabel7.TabIndex = 57;
            this.metroLabel7.Text = "Resources";
            // 
            // meals
            // 
            // 
            // 
            // 
            this.meals.CustomButton.Image = null;
            this.meals.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.meals.CustomButton.Name = "";
            this.meals.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.meals.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.meals.CustomButton.TabIndex = 1;
            this.meals.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.meals.CustomButton.UseSelectable = true;
            this.meals.CustomButton.Visible = false;
            this.meals.Lines = new string[0];
            this.meals.Location = new System.Drawing.Point(508, 212);
            this.meals.MaxLength = 32767;
            this.meals.Name = "meals";
            this.meals.PasswordChar = '\0';
            this.meals.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.meals.SelectedText = "";
            this.meals.SelectionLength = 0;
            this.meals.SelectionStart = 0;
            this.meals.ShortcutsEnabled = true;
            this.meals.Size = new System.Drawing.Size(200, 23);
            this.meals.TabIndex = 27;
            this.meals.UseSelectable = true;
            this.meals.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.meals.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // schSendMail
            // 
            this.schSendMail.AutoSize = true;
            this.schSendMail.Location = new System.Drawing.Point(239, 367);
            this.schSendMail.Name = "schSendMail";
            this.schSendMail.Size = new System.Drawing.Size(26, 15);
            this.schSendMail.TabIndex = 22;
            this.schSendMail.Text = " ";
            this.schSendMail.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(366, 132);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(114, 19);
            this.metroLabel8.TabIndex = 9;
            this.metroLabel8.Text = "Traveling Mode";
            // 
            // addEng
            // 
            this.addEng.Location = new System.Drawing.Point(299, 217);
            this.addEng.Name = "addEng";
            this.addEng.Size = new System.Drawing.Size(39, 23);
            this.addEng.TabIndex = 19;
            this.addEng.Text = "Add";
            this.addEng.UseSelectable = true;
            this.addEng.Click += new System.EventHandler(this.addEng_Click);
            // 
            // serviceEngCombo
            // 
            this.serviceEngCombo.FormattingEnabled = true;
            this.serviceEngCombo.ItemHeight = 23;
            this.serviceEngCombo.Location = new System.Drawing.Point(139, 216);
            this.serviceEngCombo.Name = "serviceEngCombo";
            this.serviceEngCombo.Size = new System.Drawing.Size(155, 29);
            this.serviceEngCombo.TabIndex = 18;
            this.serviceEngCombo.UseSelectable = true;
            // 
            // todoList
            // 
            // 
            // 
            // 
            this.todoList.CustomButton.Image = null;
            this.todoList.CustomButton.Location = new System.Drawing.Point(116, 2);
            this.todoList.CustomButton.Name = "";
            this.todoList.CustomButton.Size = new System.Drawing.Size(81, 81);
            this.todoList.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.todoList.CustomButton.TabIndex = 1;
            this.todoList.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.todoList.CustomButton.UseSelectable = true;
            this.todoList.CustomButton.Visible = false;
            this.todoList.Lines = new string[0];
            this.todoList.Location = new System.Drawing.Point(139, 119);
            this.todoList.MaxLength = 32767;
            this.todoList.Multiline = true;
            this.todoList.Name = "todoList";
            this.todoList.PasswordChar = '\0';
            this.todoList.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.todoList.SelectedText = "";
            this.todoList.SelectionLength = 0;
            this.todoList.SelectionStart = 0;
            this.todoList.ShortcutsEnabled = true;
            this.todoList.Size = new System.Drawing.Size(200, 86);
            this.todoList.TabIndex = 16;
            this.todoList.UseSelectable = true;
            this.todoList.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.todoList.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // schNo
            // 
            // 
            // 
            // 
            this.schNo.CustomButton.Image = null;
            this.schNo.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.schNo.CustomButton.Name = "";
            this.schNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.schNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.schNo.CustomButton.TabIndex = 1;
            this.schNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.schNo.CustomButton.UseSelectable = true;
            this.schNo.CustomButton.Visible = false;
            this.schNo.Lines = new string[0];
            this.schNo.Location = new System.Drawing.Point(139, 49);
            this.schNo.MaxLength = 32767;
            this.schNo.Name = "schNo";
            this.schNo.PasswordChar = '\0';
            this.schNo.ReadOnly = true;
            this.schNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.schNo.SelectedText = "";
            this.schNo.SelectionLength = 0;
            this.schNo.SelectionStart = 0;
            this.schNo.ShortcutsEnabled = true;
            this.schNo.Size = new System.Drawing.Size(75, 23);
            this.schNo.TabIndex = 14;
            this.schNo.UseSelectable = true;
            this.schNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.schNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // projectName
            // 
            this.projectName.FormattingEnabled = true;
            this.projectName.ItemHeight = 23;
            this.projectName.Location = new System.Drawing.Point(139, 12);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(200, 29);
            this.projectName.TabIndex = 13;
            this.projectName.UseSelectable = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.Location = new System.Drawing.Point(367, 247);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(75, 19);
            this.metroLabel11.TabIndex = 12;
            this.metroLabel11.Text = "Check List";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(366, 212);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(48, 19);
            this.metroLabel10.TabIndex = 11;
            this.metroLabel10.Text = "Meals";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(366, 174);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(107, 19);
            this.metroLabel9.TabIndex = 10;
            this.metroLabel9.Text = "Accomodation";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(139, 364);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(95, 19);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "Send e-mails";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(3, 216);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(121, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Service Engineer";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(3, 119);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(69, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Todo List";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(3, 52);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(81, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Schedule #";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(3, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(101, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Project Name";
            // 
            // UpdateScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 650);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1120, 650);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1120, 650);
            this.Name = "UpdateScheduleForm";
            ((System.ComponentModel.ISupportInitialize)(this.serviceEngGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevSchedulesGrid)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton removeSerEng;
        private MetroFramework.Controls.MetroGrid serviceEngGrid;
        private System.Windows.Forms.DateTimePicker schEndTime;
        private System.Windows.Forms.DateTimePicker schStartTime;
        private System.Windows.Forms.DateTimePicker schEndDate;
        private System.Windows.Forms.DateTimePicker schStartDate;
        private MetroFramework.Controls.MetroComboBox scheduleType;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroComboBox accomodation;
        private MetroFramework.Controls.MetroComboBox travelingMode;
        private MetroFramework.Controls.MetroGrid prevSchedulesGrid;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox schLogs;
        private MetroFramework.Controls.MetroComboBox schClientName;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroButton schCancel;
        private MetroFramework.Controls.MetroButton schReset;
        private MetroFramework.Controls.MetroButton schSave;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox checkList;
        private System.Windows.Forms.NotifyIcon notifyIconSch;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox meals;
        private MetroFramework.Controls.MetroCheckBox schSendMail;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton addEng;
        private MetroFramework.Controls.MetroComboBox serviceEngCombo;
        private MetroFramework.Controls.MetroTextBox todoList;
        private MetroFramework.Controls.MetroTextBox schNo;
        private MetroFramework.Controls.MetroComboBox projectName;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox resoQty;
        private MetroFramework.Controls.MetroButton removeReso;
        private MetroFramework.Controls.MetroGrid resoGrid;
        private MetroFramework.Controls.MetroComboBox schResoCombo;
        private MetroFramework.Controls.MetroButton addReso;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}