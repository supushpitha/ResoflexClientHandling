namespace ResoflexClientHandlingSystem
{
    partial class MemberListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberListForm));
            this.MembersGrid = new MetroFramework.Controls.MetroGrid();
            this.UpdateMemBtn = new MetroFramework.Controls.MetroButton();
            this.GotoAddmemBtn = new MetroFramework.Controls.MetroButton();
            this.DelMemBtn = new MetroFramework.Controls.MetroButton();
            this.TotalProjectsTile = new MetroFramework.Controls.MetroTile();
            this.TotalEventsTile = new MetroFramework.Controls.MetroTile();
            this.TotalAtteTile = new MetroFramework.Controls.MetroTile();
            this.StaffEvaBtn = new MetroFramework.Controls.MetroButton();
            this.RecordAtteBtn = new MetroFramework.Controls.MetroButton();
            this.homeBtn = new MetroFramework.Controls.MetroButton();
            this.selectMemberTxtbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.MembersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MembersGrid
            // 
            this.MembersGrid.AllowUserToResizeRows = false;
            this.MembersGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MembersGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MembersGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MembersGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MembersGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MembersGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MembersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MembersGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.MembersGrid.EnableHeadersVisualStyles = false;
            this.MembersGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MembersGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MembersGrid.Location = new System.Drawing.Point(48, 99);
            this.MembersGrid.Name = "MembersGrid";
            this.MembersGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MembersGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MembersGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MembersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MembersGrid.Size = new System.Drawing.Size(713, 309);
            this.MembersGrid.TabIndex = 0;
            this.MembersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MembersGrid_CellContentClick);
            // 
            // UpdateMemBtn
            // 
            this.UpdateMemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateMemBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.UpdateMemBtn.Location = new System.Drawing.Point(623, 48);
            this.UpdateMemBtn.Name = "UpdateMemBtn";
            this.UpdateMemBtn.Size = new System.Drawing.Size(138, 35);
            this.UpdateMemBtn.TabIndex = 1;
            this.UpdateMemBtn.Text = "Update";
            this.UpdateMemBtn.UseSelectable = true;
            this.UpdateMemBtn.Click += new System.EventHandler(this.UpdateMemBtn_Click);
            // 
            // GotoAddmemBtn
            // 
            this.GotoAddmemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GotoAddmemBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.GotoAddmemBtn.Location = new System.Drawing.Point(276, 48);
            this.GotoAddmemBtn.Name = "GotoAddmemBtn";
            this.GotoAddmemBtn.Size = new System.Drawing.Size(163, 35);
            this.GotoAddmemBtn.TabIndex = 2;
            this.GotoAddmemBtn.Text = "Add new member";
            this.GotoAddmemBtn.UseSelectable = true;
            this.GotoAddmemBtn.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // DelMemBtn
            // 
            this.DelMemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DelMemBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.DelMemBtn.Location = new System.Drawing.Point(463, 48);
            this.DelMemBtn.Name = "DelMemBtn";
            this.DelMemBtn.Size = new System.Drawing.Size(138, 35);
            this.DelMemBtn.TabIndex = 3;
            this.DelMemBtn.Text = "Delete";
            this.DelMemBtn.UseSelectable = true;
            this.DelMemBtn.Click += new System.EventHandler(this.DelMemBtn_Click);
            // 
            // TotalProjectsTile
            // 
            this.TotalProjectsTile.ActiveControl = null;
            this.TotalProjectsTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalProjectsTile.Location = new System.Drawing.Point(48, 424);
            this.TotalProjectsTile.Name = "TotalProjectsTile";
            this.TotalProjectsTile.Size = new System.Drawing.Size(157, 104);
            this.TotalProjectsTile.TabIndex = 4;
            this.TotalProjectsTile.Text = "Total Projrects";
            this.TotalProjectsTile.UseSelectable = true;
            // 
            // TotalEventsTile
            // 
            this.TotalEventsTile.ActiveControl = null;
            this.TotalEventsTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalEventsTile.Location = new System.Drawing.Point(235, 424);
            this.TotalEventsTile.Name = "TotalEventsTile";
            this.TotalEventsTile.Size = new System.Drawing.Size(157, 104);
            this.TotalEventsTile.TabIndex = 4;
            this.TotalEventsTile.Text = "Total Events";
            this.TotalEventsTile.UseSelectable = true;
            // 
            // TotalAtteTile
            // 
            this.TotalAtteTile.ActiveControl = null;
            this.TotalAtteTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalAtteTile.Location = new System.Drawing.Point(423, 424);
            this.TotalAtteTile.Name = "TotalAtteTile";
            this.TotalAtteTile.Size = new System.Drawing.Size(157, 104);
            this.TotalAtteTile.TabIndex = 4;
            this.TotalAtteTile.Text = "Total Attendance";
            this.TotalAtteTile.UseSelectable = true;
            // 
            // StaffEvaBtn
            // 
            this.StaffEvaBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StaffEvaBtn.Location = new System.Drawing.Point(641, 424);
            this.StaffEvaBtn.Name = "StaffEvaBtn";
            this.StaffEvaBtn.Size = new System.Drawing.Size(120, 40);
            this.StaffEvaBtn.TabIndex = 5;
            this.StaffEvaBtn.Text = "Staff Evalution";
            this.StaffEvaBtn.UseSelectable = true;
            this.StaffEvaBtn.Click += new System.EventHandler(this.StaffEvaBtn_Click);
            // 
            // RecordAtteBtn
            // 
            this.RecordAtteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RecordAtteBtn.Location = new System.Drawing.Point(641, 488);
            this.RecordAtteBtn.Name = "RecordAtteBtn";
            this.RecordAtteBtn.Size = new System.Drawing.Size(120, 40);
            this.RecordAtteBtn.TabIndex = 6;
            this.RecordAtteBtn.Text = "Record Attendance";
            this.RecordAtteBtn.UseSelectable = true;
            this.RecordAtteBtn.Click += new System.EventHandler(this.RecordAtteBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.homeBtn.BackColor = System.Drawing.Color.Transparent;
            this.homeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeBtn.BackgroundImage")));
            this.homeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeBtn.Location = new System.Drawing.Point(379, 7);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(30, 24);
            this.homeBtn.TabIndex = 22;
            this.homeBtn.UseSelectable = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // selectMemberTxtbox
            // 
            // 
            // 
            // 
            this.selectMemberTxtbox.CustomButton.Image = null;
            this.selectMemberTxtbox.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.selectMemberTxtbox.CustomButton.Name = "";
            this.selectMemberTxtbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.selectMemberTxtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.selectMemberTxtbox.CustomButton.TabIndex = 1;
            this.selectMemberTxtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.selectMemberTxtbox.CustomButton.UseSelectable = true;
            this.selectMemberTxtbox.CustomButton.Visible = false;
            this.selectMemberTxtbox.Lines = new string[0];
            this.selectMemberTxtbox.Location = new System.Drawing.Point(101, 60);
            this.selectMemberTxtbox.MaxLength = 32767;
            this.selectMemberTxtbox.Name = "selectMemberTxtbox";
            this.selectMemberTxtbox.PasswordChar = '\0';
            this.selectMemberTxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.selectMemberTxtbox.SelectedText = "";
            this.selectMemberTxtbox.SelectionLength = 0;
            this.selectMemberTxtbox.SelectionStart = 0;
            this.selectMemberTxtbox.ShortcutsEnabled = true;
            this.selectMemberTxtbox.Size = new System.Drawing.Size(145, 23);
            this.selectMemberTxtbox.TabIndex = 24;
            this.selectMemberTxtbox.UseSelectable = true;
            this.selectMemberTxtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.selectMemberTxtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.selectMemberTxtbox.TextChanged += new System.EventHandler(this.selectEmployeeTxtbox_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(47, 64);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 23;
            this.metroLabel2.Text = "Search";
            // 
            // MemberListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 551);
            this.Controls.Add(this.selectMemberTxtbox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.RecordAtteBtn);
            this.Controls.Add(this.StaffEvaBtn);
            this.Controls.Add(this.TotalAtteTile);
            this.Controls.Add(this.TotalEventsTile);
            this.Controls.Add(this.TotalProjectsTile);
            this.Controls.Add(this.DelMemBtn);
            this.Controls.Add(this.GotoAddmemBtn);
            this.Controls.Add(this.UpdateMemBtn);
            this.Controls.Add(this.MembersGrid);
            this.Name = "MemberListForm";
            this.Text = "Member List";
            this.Load += new System.EventHandler(this.MemberListForm_Load);
            this.Shown += new System.EventHandler(this.MemberListForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.MembersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid MembersGrid;
        private MetroFramework.Controls.MetroButton UpdateMemBtn;
        public MetroFramework.Controls.MetroButton GotoAddmemBtn;
        private MetroFramework.Controls.MetroButton DelMemBtn;
        private MetroFramework.Controls.MetroTile TotalProjectsTile;
        private MetroFramework.Controls.MetroTile TotalEventsTile;
        private MetroFramework.Controls.MetroTile TotalAtteTile;
        private MetroFramework.Controls.MetroButton StaffEvaBtn;
        private MetroFramework.Controls.MetroButton RecordAtteBtn;
        private MetroFramework.Controls.MetroButton homeBtn;
        private MetroFramework.Controls.MetroTextBox selectMemberTxtbox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}