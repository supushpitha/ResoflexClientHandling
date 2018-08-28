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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.id = new MetroFramework.Controls.MetroTextBox();
            this.notifySuccessUserAdding = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifySendSuccess = new System.Windows.Forms.NotifyIcon(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.notifySuccessUserDeleting = new System.Windows.Forms.NotifyIcon(this.components);
            this.usernameerrorprovider = new System.Windows.Forms.ErrorProvider(this.components);
            this.passworderrorprovider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameerrorprovider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passworderrorprovider)).BeginInit();
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
            this.metroLabel1.Text = "Name";
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(91, 370);
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
            this.metroLabel7.Location = new System.Drawing.Point(91, 284);
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
            this.metroLabel8.Location = new System.Drawing.Point(91, 185);
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
            this.uname.Location = new System.Drawing.Point(219, 185);
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
            this.uname.Validating += new System.ComponentModel.CancelEventHandler(this.uname_Validating);
            this.uname.Validated += new System.EventHandler(this.uname_Validated);
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
            this.pwd.Location = new System.Drawing.Point(219, 284);
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
            this.pwd.Validating += new System.ComponentModel.CancelEventHandler(this.pwd_Validating);
            this.pwd.Validated += new System.EventHandler(this.pwd_Validated);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(484, 92);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(309, 454);
            this.metroGrid1.TabIndex = 0;
            this.metroGrid1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.metroGrid1_RowHeaderMouseDoubleClick);
            // 
            // perm
            // 
            this.perm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.perm.FormattingEnabled = true;
            this.perm.ItemHeight = 23;
            this.perm.Items.AddRange(new object[] {
            "TCH",
            "HR",
            "ACC",
            "ADM",
            "PM"});
            this.perm.Location = new System.Drawing.Point(219, 370);
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
            // id
            // 
            // 
            // 
            // 
            this.id.CustomButton.Image = null;
            this.id.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.id.CustomButton.Name = "";
            this.id.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.id.CustomButton.TabIndex = 1;
            this.id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.id.CustomButton.UseSelectable = true;
            this.id.CustomButton.Visible = false;
            this.id.Lines = new string[0];
            this.id.Location = new System.Drawing.Point(250, 141);
            this.id.MaxLength = 32767;
            this.id.Name = "id";
            this.id.PasswordChar = '\0';
            this.id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.id.SelectedText = "";
            this.id.SelectionLength = 0;
            this.id.SelectionStart = 0;
            this.id.ShortcutsEnabled = true;
            this.id.Size = new System.Drawing.Size(75, 23);
            this.id.TabIndex = 18;
            this.id.UseSelectable = true;
            this.id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // notifySuccessUserAdding
            // 
            this.notifySuccessUserAdding.Visible = true;
            // 
            // notifySendSuccess
            // 
            this.notifySendSuccess.Visible = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(484, 575);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "**Double click on the row header to delete the user**";
            // 
            // notifySuccessUserDeleting
            // 
            this.notifySuccessUserDeleting.Text = "notifyIcon1";
            this.notifySuccessUserDeleting.Visible = true;
            // 
            // usernameerrorprovider
            // 
            this.usernameerrorprovider.ContainerControl = this;
            // 
            // passworderrorprovider
            // 
            this.passworderrorprovider.ContainerControl = this;
            // 
            // UserAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id);
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
            ((System.ComponentModel.ISupportInitialize)(this.usernameerrorprovider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passworderrorprovider)).EndInit();
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
        private MetroFramework.Controls.MetroTextBox id;
        private System.Windows.Forms.NotifyIcon notifySuccessUserAdding;
        private System.Windows.Forms.NotifyIcon notifySendSuccess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon notifySuccessUserDeleting;
        private System.Windows.Forms.ErrorProvider usernameerrorprovider;
        private System.Windows.Forms.ErrorProvider passworderrorprovider;
    }
}