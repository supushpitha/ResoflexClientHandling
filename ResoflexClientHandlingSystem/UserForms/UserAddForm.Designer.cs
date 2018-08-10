namespace ResoflexClientHandlingSystem
{
    partial class UserAddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.add = new MetroFramework.Controls.MetroButton();
            this.clr = new MetroFramework.Controls.MetroButton();
            this.uname = new MetroFramework.Controls.MetroTextBox();
            this.pwd = new MetroFramework.Controls.MetroTextBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.perm = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lname = new MetroFramework.Controls.MetroTextBox();
            this.fname = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Users";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(91, 92);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 44);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "User ID";
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(91, 384);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(103, 44);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Permission";
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(91, 325);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(103, 44);
            this.metroLabel7.TabIndex = 7;
            this.metroLabel7.Text = "Password";
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(91, 265);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(103, 44);
            this.metroLabel8.TabIndex = 8;
            this.metroLabel8.Text = "Username";
            // 
            // add
            // 
            this.add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.add.Location = new System.Drawing.Point(104, 466);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 9;
            this.add.Text = "Add";
            this.add.UseSelectable = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // clr
            // 
            this.clr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clr.Location = new System.Drawing.Point(219, 466);
            this.clr.Name = "clr";
            this.clr.Size = new System.Drawing.Size(75, 23);
            this.clr.TabIndex = 10;
            this.clr.Text = "Clear";
            this.clr.UseSelectable = true;
            this.clr.Click += new System.EventHandler(this.clr_Click);
            // 
            // uname
            // 
            this.uname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.uname.CustomButton.Image = null;
            this.uname.CustomButton.Location = new System.Drawing.Point(207, 1);
            this.uname.CustomButton.Name = "";
            this.uname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.uname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uname.CustomButton.TabIndex = 1;
            this.uname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uname.CustomButton.UseSelectable = true;
            this.uname.CustomButton.Visible = false;
            this.uname.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.uname.Lines = new string[0];
            this.uname.Location = new System.Drawing.Point(219, 265);
            this.uname.MaxLength = 32767;
            this.uname.Name = "uname";
            this.uname.PasswordChar = '\0';
            this.uname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uname.SelectedText = "";
            this.uname.SelectionLength = 0;
            this.uname.SelectionStart = 0;
            this.uname.ShortcutsEnabled = true;
            this.uname.Size = new System.Drawing.Size(229, 23);
            this.uname.TabIndex = 12;
            this.uname.UseSelectable = true;
            this.uname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pwd
            // 
            this.pwd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.pwd.CustomButton.Image = null;
            this.pwd.CustomButton.Location = new System.Drawing.Point(207, 1);
            this.pwd.CustomButton.Name = "";
            this.pwd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.pwd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pwd.CustomButton.TabIndex = 1;
            this.pwd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pwd.CustomButton.UseSelectable = true;
            this.pwd.CustomButton.Visible = false;
            this.pwd.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.pwd.Lines = new string[0];
            this.pwd.Location = new System.Drawing.Point(219, 325);
            this.pwd.MaxLength = 32767;
            this.pwd.Name = "pwd";
            this.pwd.PasswordChar = '*';
            this.pwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pwd.SelectedText = "";
            this.pwd.SelectionLength = 0;
            this.pwd.SelectionStart = 0;
            this.pwd.ShortcutsEnabled = true;
            this.pwd.Size = new System.Drawing.Size(229, 23);
            this.pwd.TabIndex = 13;
            this.pwd.UseSelectable = true;
            this.pwd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pwd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(484, 92);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(309, 497);
            this.metroGrid1.TabIndex = 0;
            // 
            // perm
            // 
            this.perm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.perm.FormattingEnabled = true;
            this.perm.ItemHeight = 23;
            this.perm.Items.AddRange(new object[] {
            "TCH",
            "HRM",
            "ACC",
            "ADM",
            "PM"});
            this.perm.Location = new System.Drawing.Point(219, 384);
            this.perm.Name = "perm";
            this.perm.Size = new System.Drawing.Size(229, 29);
            this.perm.TabIndex = 16;
            this.perm.UseSelectable = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(219, 92);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(229, 29);
            this.metroComboBox1.TabIndex = 17;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(91, 206);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(103, 44);
            this.metroLabel3.TabIndex = 19;
            this.metroLabel3.Text = "Last Name";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(91, 147);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(103, 44);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "First Name";
            // 
            // lname
            // 
            this.lname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.lname.CustomButton.Image = null;
            this.lname.CustomButton.Location = new System.Drawing.Point(207, 1);
            this.lname.CustomButton.Name = "";
            this.lname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lname.CustomButton.TabIndex = 1;
            this.lname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lname.CustomButton.UseSelectable = true;
            this.lname.CustomButton.Visible = false;
            this.lname.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.lname.Lines = new string[0];
            this.lname.Location = new System.Drawing.Point(219, 206);
            this.lname.MaxLength = 32767;
            this.lname.Name = "lname";
            this.lname.PasswordChar = '\0';
            this.lname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lname.SelectedText = "";
            this.lname.SelectionLength = 0;
            this.lname.SelectionStart = 0;
            this.lname.ShortcutsEnabled = true;
            this.lname.Size = new System.Drawing.Size(229, 23);
            this.lname.TabIndex = 21;
            this.lname.UseSelectable = true;
            this.lname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // fname
            // 
            this.fname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.fname.CustomButton.Image = null;
            this.fname.CustomButton.Location = new System.Drawing.Point(207, 1);
            this.fname.CustomButton.Name = "";
            this.fname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.fname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.fname.CustomButton.TabIndex = 1;
            this.fname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fname.CustomButton.UseSelectable = true;
            this.fname.CustomButton.Visible = false;
            this.fname.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.fname.Lines = new string[0];
            this.fname.Location = new System.Drawing.Point(219, 147);
            this.fname.MaxLength = 32767;
            this.fname.Name = "fname";
            this.fname.PasswordChar = '\0';
            this.fname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fname.SelectedText = "";
            this.fname.SelectionLength = 0;
            this.fname.SelectionStart = 0;
            this.fname.ShortcutsEnabled = true;
            this.fname.Size = new System.Drawing.Size(229, 23);
            this.fname.TabIndex = 22;
            this.fname.UseSelectable = true;
            this.fname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.fname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UserAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.perm);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.clr);
            this.Controls.Add(this.add);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "UserAddForm";
            this.Load += new System.EventHandler(this.UserAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton add;
        private MetroFramework.Controls.MetroButton clr;
        private MetroFramework.Controls.MetroTextBox uname;
        private MetroFramework.Controls.MetroTextBox pwd;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroComboBox perm;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox lname;
        private MetroFramework.Controls.MetroTextBox fname;
    }
}