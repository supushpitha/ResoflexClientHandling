namespace ResoflexClientHandlingSystem
{
    partial class Project
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.addProjectBtn = new MetroFramework.Controls.MetroButton();
            this.updateProjectBtn = new MetroFramework.Controls.MetroButton();
            this.viewProgressBtn = new MetroFramework.Controls.MetroButton();
            this.projectincomeExBtn = new MetroFramework.Controls.MetroButton();
            this.searchProjectTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.showAllProjectBtn = new MetroFramework.Controls.MetroButton();
            this.projectGrid = new MetroFramework.Controls.MetroGrid();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.searchProjectByClientTxtBox = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.projectGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addProjectBtn
            // 
            this.addProjectBtn.Location = new System.Drawing.Point(38, 218);
            this.addProjectBtn.Name = "addProjectBtn";
            this.addProjectBtn.Size = new System.Drawing.Size(113, 31);
            this.addProjectBtn.TabIndex = 0;
            this.addProjectBtn.Text = "Add Project";
            this.addProjectBtn.UseSelectable = true;
            this.addProjectBtn.Click += new System.EventHandler(this.addProjectBtn_Click);
            // 
            // updateProjectBtn
            // 
            this.updateProjectBtn.Location = new System.Drawing.Point(185, 218);
            this.updateProjectBtn.Name = "updateProjectBtn";
            this.updateProjectBtn.Size = new System.Drawing.Size(113, 31);
            this.updateProjectBtn.TabIndex = 1;
            this.updateProjectBtn.Text = "Update Project";
            this.updateProjectBtn.UseSelectable = true;
            this.updateProjectBtn.Click += new System.EventHandler(this.updateProjectBtn_Click);
            // 
            // viewProgressBtn
            // 
            this.viewProgressBtn.Location = new System.Drawing.Point(333, 218);
            this.viewProgressBtn.Name = "viewProgressBtn";
            this.viewProgressBtn.Size = new System.Drawing.Size(113, 31);
            this.viewProgressBtn.TabIndex = 2;
            this.viewProgressBtn.Text = "View Progress";
            this.viewProgressBtn.UseSelectable = true;
            // 
            // projectincomeExBtn
            // 
            this.projectincomeExBtn.Location = new System.Drawing.Point(483, 218);
            this.projectincomeExBtn.Name = "projectincomeExBtn";
            this.projectincomeExBtn.Size = new System.Drawing.Size(123, 31);
            this.projectincomeExBtn.TabIndex = 3;
            this.projectincomeExBtn.Text = "Incomes/Expenses";
            this.projectincomeExBtn.UseSelectable = true;
            // 
            // searchProjectTxtBox
            // 
            // 
            // 
            // 
            this.searchProjectTxtBox.CustomButton.Image = null;
            this.searchProjectTxtBox.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.searchProjectTxtBox.CustomButton.Name = "";
            this.searchProjectTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchProjectTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchProjectTxtBox.CustomButton.TabIndex = 1;
            this.searchProjectTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchProjectTxtBox.CustomButton.UseSelectable = true;
            this.searchProjectTxtBox.CustomButton.Visible = false;
            this.searchProjectTxtBox.Lines = new string[0];
            this.searchProjectTxtBox.Location = new System.Drawing.Point(42, 294);
            this.searchProjectTxtBox.MaxLength = 32767;
            this.searchProjectTxtBox.Name = "searchProjectTxtBox";
            this.searchProjectTxtBox.PasswordChar = '\0';
            this.searchProjectTxtBox.PromptText = "Search by Project Name";
            this.searchProjectTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchProjectTxtBox.SelectedText = "";
            this.searchProjectTxtBox.SelectionLength = 0;
            this.searchProjectTxtBox.SelectionStart = 0;
            this.searchProjectTxtBox.ShortcutsEnabled = true;
            this.searchProjectTxtBox.Size = new System.Drawing.Size(212, 23);
            this.searchProjectTxtBox.TabIndex = 4;
            this.searchProjectTxtBox.UseSelectable = true;
            this.searchProjectTxtBox.WaterMark = "Search by Project Name";
            this.searchProjectTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchProjectTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // showAllProjectBtn
            // 
            this.showAllProjectBtn.Location = new System.Drawing.Point(506, 294);
            this.showAllProjectBtn.Name = "showAllProjectBtn";
            this.showAllProjectBtn.Size = new System.Drawing.Size(100, 23);
            this.showAllProjectBtn.TabIndex = 5;
            this.showAllProjectBtn.Text = "Show All";
            this.showAllProjectBtn.UseSelectable = true;
            // 
            // projectGrid
            // 
            this.projectGrid.AllowUserToAddRows = false;
            this.projectGrid.AllowUserToDeleteRows = false;
            this.projectGrid.AllowUserToResizeRows = false;
            this.projectGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projectGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.projectGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.projectGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.projectGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.projectGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.projectGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.projectGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.projectGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.projectGrid.EnableHeadersVisualStyles = false;
            this.projectGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.projectGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.projectGrid.Location = new System.Drawing.Point(42, 345);
            this.projectGrid.Name = "projectGrid";
            this.projectGrid.ReadOnly = true;
            this.projectGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.projectGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.projectGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.projectGrid.RowTemplate.Height = 24;
            this.projectGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.projectGrid.Size = new System.Drawing.Size(712, 231);
            this.projectGrid.TabIndex = 6;
            this.projectGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectGrid_CellContentClick);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(38, 76);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(216, 109);
            this.metroTile1.TabIndex = 7;
            this.metroTile1.Text = "Total Projects";
            this.metroTile1.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(261, 76);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(110, 109);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTile2.TabIndex = 8;
            this.metroTile2.Text = "Ongoing";
            this.metroTile2.UseSelectable = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(378, 76);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(112, 109);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile3.TabIndex = 9;
            this.metroTile3.Text = "Requests";
            this.metroTile3.UseSelectable = true;
            // 
            // searchProjectByClientTxtBox
            // 
            // 
            // 
            // 
            this.searchProjectByClientTxtBox.CustomButton.Image = null;
            this.searchProjectByClientTxtBox.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.searchProjectByClientTxtBox.CustomButton.Name = "";
            this.searchProjectByClientTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchProjectByClientTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchProjectByClientTxtBox.CustomButton.TabIndex = 1;
            this.searchProjectByClientTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchProjectByClientTxtBox.CustomButton.UseSelectable = true;
            this.searchProjectByClientTxtBox.CustomButton.Visible = false;
            this.searchProjectByClientTxtBox.Lines = new string[0];
            this.searchProjectByClientTxtBox.Location = new System.Drawing.Point(263, 294);
            this.searchProjectByClientTxtBox.MaxLength = 32767;
            this.searchProjectByClientTxtBox.Name = "searchProjectByClientTxtBox";
            this.searchProjectByClientTxtBox.PasswordChar = '\0';
            this.searchProjectByClientTxtBox.PromptText = "Search by Client Name";
            this.searchProjectByClientTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchProjectByClientTxtBox.SelectedText = "";
            this.searchProjectByClientTxtBox.SelectionLength = 0;
            this.searchProjectByClientTxtBox.SelectionStart = 0;
            this.searchProjectByClientTxtBox.ShortcutsEnabled = true;
            this.searchProjectByClientTxtBox.Size = new System.Drawing.Size(210, 23);
            this.searchProjectByClientTxtBox.TabIndex = 10;
            this.searchProjectByClientTxtBox.UseSelectable = true;
            this.searchProjectByClientTxtBox.WaterMark = "Search by Client Name";
            this.searchProjectByClientTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchProjectByClientTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchProjectByClientTxtBox.TextChanged += new System.EventHandler(this.searchProjectByClientTxtBox_TextChanged);
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 599);
            this.Controls.Add(this.searchProjectByClientTxtBox);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.projectGrid);
            this.Controls.Add(this.showAllProjectBtn);
            this.Controls.Add(this.searchProjectTxtBox);
            this.Controls.Add(this.projectincomeExBtn);
            this.Controls.Add(this.viewProgressBtn);
            this.Controls.Add(this.updateProjectBtn);
            this.Controls.Add(this.addProjectBtn);
            this.Name = "Project";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Project";
            this.Load += new System.EventHandler(this.Project_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton addProjectBtn;
        private MetroFramework.Controls.MetroButton updateProjectBtn;
        private MetroFramework.Controls.MetroButton viewProgressBtn;
        private MetroFramework.Controls.MetroButton projectincomeExBtn;
        private MetroFramework.Controls.MetroTextBox searchProjectTxtBox;
        private MetroFramework.Controls.MetroButton showAllProjectBtn;
        private MetroFramework.Controls.MetroGrid projectGrid;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTextBox searchProjectByClientTxtBox;
    }
}