namespace ResoflexClientHandlingSystem
{
    partial class Project1
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
            this.addProjectBtn = new MetroFramework.Controls.MetroButton();
            this.updateProjectBtn = new MetroFramework.Controls.MetroButton();
            this.progressBtn = new MetroFramework.Controls.MetroButton();
            this.incomeBtn = new MetroFramework.Controls.MetroButton();
            this.searchProjectTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.searchBtn = new MetroFramework.Controls.MetroButton();
            this.projIdTile = new MetroFramework.Controls.MetroTile();
            this.totExpenceTile = new MetroFramework.Controls.MetroTile();
            this.warrantyTile = new MetroFramework.Controls.MetroTile();
            this.projectGrid = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.projectGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addProjectBtn
            // 
            this.addProjectBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.addProjectBtn.Location = new System.Drawing.Point(46, 226);
            this.addProjectBtn.Name = "addProjectBtn";
            this.addProjectBtn.Size = new System.Drawing.Size(137, 32);
            this.addProjectBtn.TabIndex = 0;
            this.addProjectBtn.Text = "Add Project";
            this.addProjectBtn.UseSelectable = true;
            this.addProjectBtn.Click += new System.EventHandler(this.addProjectBtn_Click_1);
            // 
            // updateProjectBtn
            // 
            this.updateProjectBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.updateProjectBtn.Location = new System.Drawing.Point(229, 226);
            this.updateProjectBtn.Name = "updateProjectBtn";
            this.updateProjectBtn.Size = new System.Drawing.Size(137, 32);
            this.updateProjectBtn.TabIndex = 1;
            this.updateProjectBtn.Text = "Update Project";
            this.updateProjectBtn.UseSelectable = true;
            this.updateProjectBtn.Click += new System.EventHandler(this.updateProjectBtn_Click_1);
            // 
            // progressBtn
            // 
            this.progressBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.progressBtn.Location = new System.Drawing.Point(594, 226);
            this.progressBtn.Name = "progressBtn";
            this.progressBtn.Size = new System.Drawing.Size(137, 32);
            this.progressBtn.TabIndex = 2;
            this.progressBtn.Text = "View Ranks";
            this.progressBtn.UseSelectable = true;
            this.progressBtn.Click += new System.EventHandler(this.progressBtn_Click);
            // 
            // incomeBtn
            // 
            this.incomeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.incomeBtn.Location = new System.Drawing.Point(467, 297);
            this.incomeBtn.Name = "incomeBtn";
            this.incomeBtn.Size = new System.Drawing.Size(87, 30);
            this.incomeBtn.TabIndex = 3;
            this.incomeBtn.Text = "More Info";
            this.incomeBtn.UseCustomBackColor = true;
            this.incomeBtn.UseCustomForeColor = true;
            this.incomeBtn.UseSelectable = true;
            this.incomeBtn.UseStyleColors = true;
            // 
            // searchProjectTxtBox
            // 
            // 
            // 
            // 
            this.searchProjectTxtBox.CustomButton.Image = null;
            this.searchProjectTxtBox.CustomButton.Location = new System.Drawing.Point(249, 2);
            this.searchProjectTxtBox.CustomButton.Name = "";
            this.searchProjectTxtBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.searchProjectTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchProjectTxtBox.CustomButton.TabIndex = 1;
            this.searchProjectTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchProjectTxtBox.CustomButton.UseSelectable = true;
            this.searchProjectTxtBox.CustomButton.Visible = false;
            this.searchProjectTxtBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.searchProjectTxtBox.Lines = new string[0];
            this.searchProjectTxtBox.Location = new System.Drawing.Point(47, 297);
            this.searchProjectTxtBox.MaxLength = 32767;
            this.searchProjectTxtBox.Multiline = true;
            this.searchProjectTxtBox.Name = "searchProjectTxtBox";
            this.searchProjectTxtBox.PasswordChar = '\0';
            this.searchProjectTxtBox.PromptText = "Search by Project/Client Name";
            this.searchProjectTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchProjectTxtBox.SelectedText = "";
            this.searchProjectTxtBox.SelectionLength = 0;
            this.searchProjectTxtBox.SelectionStart = 0;
            this.searchProjectTxtBox.ShortcutsEnabled = true;
            this.searchProjectTxtBox.Size = new System.Drawing.Size(277, 30);
            this.searchProjectTxtBox.TabIndex = 4;
            this.searchProjectTxtBox.UseSelectable = true;
            this.searchProjectTxtBox.WaterMark = "Search by Project/Client Name";
            this.searchProjectTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchProjectTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchProjectTxtBox.TextChanged += new System.EventHandler(this.searchProjectTxtBox_TextChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(330, 297);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(119, 30);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseSelectable = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // projIdTile
            // 
            this.projIdTile.ActiveControl = null;
            this.projIdTile.Location = new System.Drawing.Point(48, 106);
            this.projIdTile.Name = "projIdTile";
            this.projIdTile.Size = new System.Drawing.Size(101, 87);
            this.projIdTile.TabIndex = 7;
            this.projIdTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.projIdTile.UseCustomBackColor = true;
            this.projIdTile.UseSelectable = true;
            this.projIdTile.Click += new System.EventHandler(this.projIdTile_Click);
            // 
            // totExpenceTile
            // 
            this.totExpenceTile.ActiveControl = null;
            this.totExpenceTile.Location = new System.Drawing.Point(206, 106);
            this.totExpenceTile.Name = "totExpenceTile";
            this.totExpenceTile.Size = new System.Drawing.Size(190, 87);
            this.totExpenceTile.TabIndex = 8;
            this.totExpenceTile.UseCustomBackColor = true;
            this.totExpenceTile.UseSelectable = true;
            // 
            // warrantyTile
            // 
            this.warrantyTile.ActiveControl = null;
            this.warrantyTile.BackColor = System.Drawing.Color.White;
            this.warrantyTile.Location = new System.Drawing.Point(469, 106);
            this.warrantyTile.Name = "warrantyTile";
            this.warrantyTile.Size = new System.Drawing.Size(101, 87);
            this.warrantyTile.TabIndex = 9;
            this.warrantyTile.UseCustomBackColor = true;
            this.warrantyTile.UseSelectable = true;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.projectGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.projectGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.projectGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.projectGrid.EnableHeadersVisualStyles = false;
            this.projectGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.projectGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.projectGrid.Location = new System.Drawing.Point(23, 352);
            this.projectGrid.Name = "projectGrid";
            this.projectGrid.ReadOnly = true;
            this.projectGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.projectGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.projectGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.projectGrid.RowTemplate.Height = 24;
            this.projectGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.projectGrid.Size = new System.Drawing.Size(754, 225);
            this.projectGrid.Style = MetroFramework.MetroColorStyle.Yellow;
            this.projectGrid.TabIndex = 10;
            this.projectGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectGrid_CellContentClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(46, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(103, 20);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "No of Projects";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(206, 74);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 20);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Total Expense";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(467, 74);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 20);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Warranty";
            // 
            // metroButton1
            // 
            this.metroButton1.ForeColor = System.Drawing.Color.OrangeRed;
            this.metroButton1.Location = new System.Drawing.Point(560, 297);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(117, 30);
            this.metroButton1.TabIndex = 14;
            this.metroButton1.Text = "Add Catagory";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Project1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.projectGrid);
            this.Controls.Add(this.warrantyTile);
            this.Controls.Add(this.totExpenceTile);
            this.Controls.Add(this.projIdTile);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchProjectTxtBox);
            this.Controls.Add(this.incomeBtn);
            this.Controls.Add(this.progressBtn);
            this.Controls.Add(this.updateProjectBtn);
            this.Controls.Add(this.addProjectBtn);
            this.Name = "Project1";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Project";
            this.Load += new System.EventHandler(this.Project1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton addProjectBtn;
        private MetroFramework.Controls.MetroButton updateProjectBtn;
        private MetroFramework.Controls.MetroButton progressBtn;
        private MetroFramework.Controls.MetroButton incomeBtn;
        private MetroFramework.Controls.MetroTextBox searchProjectTxtBox;
        private MetroFramework.Controls.MetroButton searchBtn;
        private MetroFramework.Controls.MetroTile projIdTile;
        private MetroFramework.Controls.MetroTile totExpenceTile;
        private MetroFramework.Controls.MetroTile warrantyTile;
        private MetroFramework.Controls.MetroGrid projectGrid;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}