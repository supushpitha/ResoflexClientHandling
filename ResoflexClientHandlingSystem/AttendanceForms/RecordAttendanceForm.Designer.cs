namespace ResoflexClientHandlingSystem
{
    partial class RecordAttendanceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.employeeNumberTxtbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.firstNameTxtbox = new MetroFramework.Controls.MetroTextBox();
            this.lastNameTxtbox = new MetroFramework.Controls.MetroTextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.todaysAttendanceDataGrid = new MetroFramework.Controls.MetroGrid();
            this.totalHoursTxtbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime3 = new MetroFramework.Controls.MetroDateTime();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.staffDataGrid = new MetroFramework.Controls.MetroGrid();
            this.searchEmployeeTxtbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.pastAttendanceDataGrid = new MetroFramework.Controls.MetroGrid();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.checkPresenceTxtbox = new MetroFramework.Controls.MetroTextBox();
            this.todaysAttendanceTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.todaysAttendanceDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pastAttendanceDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(469, 354);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Employee No";
            // 
            // employeeNumberTxtbox
            // 
            // 
            // 
            // 
            this.employeeNumberTxtbox.CustomButton.Image = null;
            this.employeeNumberTxtbox.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.employeeNumberTxtbox.CustomButton.Name = "";
            this.employeeNumberTxtbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.employeeNumberTxtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.employeeNumberTxtbox.CustomButton.TabIndex = 1;
            this.employeeNumberTxtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.employeeNumberTxtbox.CustomButton.UseSelectable = true;
            this.employeeNumberTxtbox.CustomButton.Visible = false;
            this.employeeNumberTxtbox.Lines = new string[0];
            this.employeeNumberTxtbox.Location = new System.Drawing.Point(603, 350);
            this.employeeNumberTxtbox.MaxLength = 32767;
            this.employeeNumberTxtbox.Name = "employeeNumberTxtbox";
            this.employeeNumberTxtbox.PasswordChar = '\0';
            this.employeeNumberTxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.employeeNumberTxtbox.SelectedText = "";
            this.employeeNumberTxtbox.SelectionLength = 0;
            this.employeeNumberTxtbox.SelectionStart = 0;
            this.employeeNumberTxtbox.ShortcutsEnabled = true;
            this.employeeNumberTxtbox.Size = new System.Drawing.Size(183, 23);
            this.employeeNumberTxtbox.TabIndex = 2;
            this.employeeNumberTxtbox.UseSelectable = true;
            this.employeeNumberTxtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.employeeNumberTxtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.employeeNumberTxtbox.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            this.employeeNumberTxtbox.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(469, 383);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "First Name";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(471, 446);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(19, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "In";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(469, 480);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(31, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Out";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(471, 511);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(74, 19);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "Total Hours";
            // 
            // firstNameTxtbox
            // 
            // 
            // 
            // 
            this.firstNameTxtbox.CustomButton.Image = null;
            this.firstNameTxtbox.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.firstNameTxtbox.CustomButton.Name = "";
            this.firstNameTxtbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.firstNameTxtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.firstNameTxtbox.CustomButton.TabIndex = 1;
            this.firstNameTxtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.firstNameTxtbox.CustomButton.UseSelectable = true;
            this.firstNameTxtbox.CustomButton.Visible = false;
            this.firstNameTxtbox.Lines = new string[0];
            this.firstNameTxtbox.Location = new System.Drawing.Point(603, 379);
            this.firstNameTxtbox.MaxLength = 32767;
            this.firstNameTxtbox.Name = "firstNameTxtbox";
            this.firstNameTxtbox.PasswordChar = '\0';
            this.firstNameTxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.firstNameTxtbox.SelectedText = "";
            this.firstNameTxtbox.SelectionLength = 0;
            this.firstNameTxtbox.SelectionStart = 0;
            this.firstNameTxtbox.ShortcutsEnabled = true;
            this.firstNameTxtbox.Size = new System.Drawing.Size(183, 23);
            this.firstNameTxtbox.TabIndex = 8;
            this.firstNameTxtbox.UseSelectable = true;
            this.firstNameTxtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.firstNameTxtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.firstNameTxtbox.TextChanged += new System.EventHandler(this.metroTextBox2_TextChanged);
            this.firstNameTxtbox.Click += new System.EventHandler(this.metroTextBox2_Click);
            // 
            // lastNameTxtbox
            // 
            // 
            // 
            // 
            this.lastNameTxtbox.CustomButton.Image = null;
            this.lastNameTxtbox.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.lastNameTxtbox.CustomButton.Name = "";
            this.lastNameTxtbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lastNameTxtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lastNameTxtbox.CustomButton.TabIndex = 1;
            this.lastNameTxtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lastNameTxtbox.CustomButton.UseSelectable = true;
            this.lastNameTxtbox.CustomButton.Visible = false;
            this.lastNameTxtbox.Lines = new string[0];
            this.lastNameTxtbox.Location = new System.Drawing.Point(603, 408);
            this.lastNameTxtbox.MaxLength = 32767;
            this.lastNameTxtbox.Name = "lastNameTxtbox";
            this.lastNameTxtbox.PasswordChar = '\0';
            this.lastNameTxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lastNameTxtbox.SelectedText = "";
            this.lastNameTxtbox.SelectionLength = 0;
            this.lastNameTxtbox.SelectionStart = 0;
            this.lastNameTxtbox.ShortcutsEnabled = true;
            this.lastNameTxtbox.Size = new System.Drawing.Size(183, 23);
            this.lastNameTxtbox.TabIndex = 12;
            this.lastNameTxtbox.UseSelectable = true;
            this.lastNameTxtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lastNameTxtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.lastNameTxtbox.Click += new System.EventHandler(this.metroTextBox6_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(473, 540);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(80, 37);
            this.metroTile1.TabIndex = 13;
            this.metroTile1.Text = "Insert";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(597, 540);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(80, 37);
            this.metroTile2.TabIndex = 14;
            this.metroTile2.Text = "Update";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // todaysAttendanceDataGrid
            // 
            this.todaysAttendanceDataGrid.AllowUserToResizeRows = false;
            this.todaysAttendanceDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.todaysAttendanceDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.todaysAttendanceDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.todaysAttendanceDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.todaysAttendanceDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.todaysAttendanceDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.todaysAttendanceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.todaysAttendanceDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.todaysAttendanceDataGrid.EnableHeadersVisualStyles = false;
            this.todaysAttendanceDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.todaysAttendanceDataGrid.GridColor = System.Drawing.Color.White;
            this.todaysAttendanceDataGrid.Location = new System.Drawing.Point(469, 105);
            this.todaysAttendanceDataGrid.Name = "todaysAttendanceDataGrid";
            this.todaysAttendanceDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.todaysAttendanceDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.todaysAttendanceDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.todaysAttendanceDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.todaysAttendanceDataGrid.Size = new System.Drawing.Size(317, 214);
            this.todaysAttendanceDataGrid.TabIndex = 16;
            this.todaysAttendanceDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            this.todaysAttendanceDataGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.metroGrid1_RowHeaderMouseClick);
            // 
            // totalHoursTxtbox
            // 
            // 
            // 
            // 
            this.totalHoursTxtbox.CustomButton.Image = null;
            this.totalHoursTxtbox.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.totalHoursTxtbox.CustomButton.Name = "";
            this.totalHoursTxtbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.totalHoursTxtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.totalHoursTxtbox.CustomButton.TabIndex = 1;
            this.totalHoursTxtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.totalHoursTxtbox.CustomButton.UseSelectable = true;
            this.totalHoursTxtbox.CustomButton.Visible = false;
            this.totalHoursTxtbox.Lines = new string[0];
            this.totalHoursTxtbox.Location = new System.Drawing.Point(603, 507);
            this.totalHoursTxtbox.MaxLength = 32767;
            this.totalHoursTxtbox.Name = "totalHoursTxtbox";
            this.totalHoursTxtbox.PasswordChar = '\0';
            this.totalHoursTxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.totalHoursTxtbox.SelectedText = "";
            this.totalHoursTxtbox.SelectionLength = 0;
            this.totalHoursTxtbox.SelectionStart = 0;
            this.totalHoursTxtbox.ShortcutsEnabled = true;
            this.totalHoursTxtbox.Size = new System.Drawing.Size(183, 23);
            this.totalHoursTxtbox.TabIndex = 18;
            this.totalHoursTxtbox.UseSelectable = true;
            this.totalHoursTxtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.totalHoursTxtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.totalHoursTxtbox.TextChanged += new System.EventHandler(this.metroTextBox7_TextChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(469, 412);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(71, 19);
            this.metroLabel7.TabIndex = 17;
            this.metroLabel7.Text = "Last Name";
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.CustomFormat = "";
            this.metroDateTime2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime2.Location = new System.Drawing.Point(603, 437);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(183, 29);
            this.metroDateTime2.TabIndex = 19;
            // 
            // metroDateTime3
            // 
            this.metroDateTime3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime3.Location = new System.Drawing.Point(603, 472);
            this.metroDateTime3.MinimumSize = new System.Drawing.Size(4, 29);
            this.metroDateTime3.Name = "metroDateTime3";
            this.metroDateTime3.Size = new System.Drawing.Size(183, 29);
            this.metroDateTime3.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(512, 446);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(89, 20);
            this.dateTimePicker1.TabIndex = 23;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(512, 481);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(89, 20);
            this.dateTimePicker2.TabIndex = 24;
            // 
            // staffDataGrid
            // 
            this.staffDataGrid.AllowUserToResizeRows = false;
            this.staffDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.staffDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.staffDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.staffDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.staffDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.staffDataGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.staffDataGrid.EnableHeadersVisualStyles = false;
            this.staffDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.staffDataGrid.GridColor = System.Drawing.Color.White;
            this.staffDataGrid.Location = new System.Drawing.Point(12, 105);
            this.staffDataGrid.Name = "staffDataGrid";
            this.staffDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.staffDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.staffDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.staffDataGrid.Size = new System.Drawing.Size(446, 214);
            this.staffDataGrid.TabIndex = 25;
            this.staffDataGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.metroGrid2_RowHeaderMouseClick);
            // 
            // searchEmployeeTxtbox
            // 
            // 
            // 
            // 
            this.searchEmployeeTxtbox.CustomButton.Image = null;
            this.searchEmployeeTxtbox.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.searchEmployeeTxtbox.CustomButton.Name = "";
            this.searchEmployeeTxtbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchEmployeeTxtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchEmployeeTxtbox.CustomButton.TabIndex = 1;
            this.searchEmployeeTxtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchEmployeeTxtbox.CustomButton.UseSelectable = true;
            this.searchEmployeeTxtbox.CustomButton.Visible = false;
            this.searchEmployeeTxtbox.Lines = new string[0];
            this.searchEmployeeTxtbox.Location = new System.Drawing.Point(66, 76);
            this.searchEmployeeTxtbox.MaxLength = 32767;
            this.searchEmployeeTxtbox.Name = "searchEmployeeTxtbox";
            this.searchEmployeeTxtbox.PasswordChar = '\0';
            this.searchEmployeeTxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchEmployeeTxtbox.SelectedText = "";
            this.searchEmployeeTxtbox.SelectionLength = 0;
            this.searchEmployeeTxtbox.SelectionStart = 0;
            this.searchEmployeeTxtbox.ShortcutsEnabled = true;
            this.searchEmployeeTxtbox.Size = new System.Drawing.Size(157, 23);
            this.searchEmployeeTxtbox.TabIndex = 26;
            this.searchEmployeeTxtbox.UseSelectable = true;
            this.searchEmployeeTxtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchEmployeeTxtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchEmployeeTxtbox.TextChanged += new System.EventHandler(this.metroTextBox3_TextChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(12, 80);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(48, 19);
            this.metroLabel8.TabIndex = 27;
            this.metroLabel8.Text = "Search";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(473, 80);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(118, 19);
            this.metroLabel5.TabIndex = 29;
            this.metroLabel5.Text = "Today\'s attendance";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(171, 322);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(211, 29);
            this.metroDateTime1.TabIndex = 30;
            this.metroDateTime1.ValueChanged += new System.EventHandler(this.metroDateTime1_ValueChanged);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(714, 540);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(74, 37);
            this.metroTile4.TabIndex = 31;
            this.metroTile4.Text = "Clear";
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // pastAttendanceDataGrid
            // 
            this.pastAttendanceDataGrid.AllowUserToResizeRows = false;
            this.pastAttendanceDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pastAttendanceDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.pastAttendanceDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pastAttendanceDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.pastAttendanceDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pastAttendanceDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.pastAttendanceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pastAttendanceDataGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.pastAttendanceDataGrid.EnableHeadersVisualStyles = false;
            this.pastAttendanceDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pastAttendanceDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pastAttendanceDataGrid.Location = new System.Drawing.Point(12, 354);
            this.pastAttendanceDataGrid.Name = "pastAttendanceDataGrid";
            this.pastAttendanceDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pastAttendanceDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.pastAttendanceDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.pastAttendanceDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pastAttendanceDataGrid.Size = new System.Drawing.Size(446, 223);
            this.pastAttendanceDataGrid.TabIndex = 32;
            this.pastAttendanceDataGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.pastAttendanceDataGrid_RowHeaderMouseClick);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(12, 332);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(153, 19);
            this.metroLabel9.TabIndex = 33;
            this.metroLabel9.Text = "Past Attendance Records";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(597, 80);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(48, 19);
            this.metroLabel10.TabIndex = 34;
            this.metroLabel10.Text = "Search";
            // 
            // checkPresenceTxtbox
            // 
            // 
            // 
            // 
            this.checkPresenceTxtbox.CustomButton.Image = null;
            this.checkPresenceTxtbox.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.checkPresenceTxtbox.CustomButton.Name = "";
            this.checkPresenceTxtbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.checkPresenceTxtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.checkPresenceTxtbox.CustomButton.TabIndex = 1;
            this.checkPresenceTxtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.checkPresenceTxtbox.CustomButton.UseSelectable = true;
            this.checkPresenceTxtbox.CustomButton.Visible = false;
            this.checkPresenceTxtbox.Lines = new string[0];
            this.checkPresenceTxtbox.Location = new System.Drawing.Point(645, 73);
            this.checkPresenceTxtbox.MaxLength = 32767;
            this.checkPresenceTxtbox.Name = "checkPresenceTxtbox";
            this.checkPresenceTxtbox.PasswordChar = '\0';
            this.checkPresenceTxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.checkPresenceTxtbox.SelectedText = "";
            this.checkPresenceTxtbox.SelectionLength = 0;
            this.checkPresenceTxtbox.SelectionStart = 0;
            this.checkPresenceTxtbox.ShortcutsEnabled = true;
            this.checkPresenceTxtbox.Size = new System.Drawing.Size(132, 23);
            this.checkPresenceTxtbox.TabIndex = 35;
            this.checkPresenceTxtbox.UseSelectable = true;
            this.checkPresenceTxtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.checkPresenceTxtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.checkPresenceTxtbox.TextChanged += new System.EventHandler(this.checkPresenceTxtbox_TextChanged);
            // 
            // todaysAttendanceTimer
            // 
            this.todaysAttendanceTimer.Enabled = true;
            this.todaysAttendanceTimer.Interval = 2000;
            this.todaysAttendanceTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RecordAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.checkPresenceTxtbox);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.pastAttendanceDataGrid);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.searchEmployeeTxtbox);
            this.Controls.Add(this.staffDataGrid);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.metroDateTime3);
            this.Controls.Add(this.metroDateTime2);
            this.Controls.Add(this.totalHoursTxtbox);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.todaysAttendanceDataGrid);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.lastNameTxtbox);
            this.Controls.Add(this.firstNameTxtbox);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.employeeNumberTxtbox);
            this.Controls.Add(this.metroLabel1);
            this.Name = "RecordAttendanceForm";
            this.Text = "Record Attendance";
            this.Load += new System.EventHandler(this.RecordAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.todaysAttendanceDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pastAttendanceDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox employeeNumberTxtbox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox firstNameTxtbox;
        private MetroFramework.Controls.MetroTextBox lastNameTxtbox;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroGrid todaysAttendanceDataGrid;
        private MetroFramework.Controls.MetroTextBox totalHoursTxtbox;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private MetroFramework.Controls.MetroDateTime metroDateTime3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private MetroFramework.Controls.MetroGrid staffDataGrid;
        private MetroFramework.Controls.MetroTextBox searchEmployeeTxtbox;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroGrid pastAttendanceDataGrid;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox checkPresenceTxtbox;
        private System.Windows.Forms.Timer todaysAttendanceTimer;
    }
}