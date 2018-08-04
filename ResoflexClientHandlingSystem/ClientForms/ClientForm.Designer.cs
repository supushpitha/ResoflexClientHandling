namespace ResoflexClientHandlingSystem
{
    partial class ClientForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.clientGrid = new MetroFramework.Controls.MetroGrid();
            this.addNewClientBtn = new MetroFramework.Controls.MetroButton();
            this.searchClientTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.showAllClientBtn = new MetroFramework.Controls.MetroButton();
            this.noOfProjTile = new MetroFramework.Controls.MetroTile();
            this.noOfVisitsTile = new MetroFramework.Controls.MetroTile();
            this.totalExpTile = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.gridViewUsageLbl = new MetroFramework.Controls.MetroLabel();
            this.updateClientBtn = new MetroFramework.Controls.MetroButton();
            this.ShowMoreBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.clientGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // clientGrid
            // 
            this.clientGrid.AllowUserToAddRows = false;
            this.clientGrid.AllowUserToDeleteRows = false;
            this.clientGrid.AllowUserToResizeRows = false;
            this.clientGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clientGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.clientGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.clientGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clientGrid.DefaultCellStyle = dataGridViewCellStyle14;
            this.clientGrid.EnableHeadersVisualStyles = false;
            this.clientGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.clientGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clientGrid.Location = new System.Drawing.Point(23, 280);
            this.clientGrid.Name = "clientGrid";
            this.clientGrid.ReadOnly = true;
            this.clientGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.clientGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.clientGrid.RowTemplate.Height = 24;
            this.clientGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientGrid.Size = new System.Drawing.Size(754, 297);
            this.clientGrid.TabIndex = 0;
            this.clientGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientGrid_CellClick);
            this.clientGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientGrid_CellContentClick);
            this.clientGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.clientGrid_RowHeaderMouseClick);
            this.clientGrid.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.clientGrid_RowHeaderMouseDoubleClick);
            // 
            // addNewClientBtn
            // 
            this.addNewClientBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addNewClientBtn.Location = new System.Drawing.Point(650, 234);
            this.addNewClientBtn.Name = "addNewClientBtn";
            this.addNewClientBtn.Size = new System.Drawing.Size(127, 29);
            this.addNewClientBtn.TabIndex = 1;
            this.addNewClientBtn.Text = "Add New Client";
            this.addNewClientBtn.UseSelectable = true;
            this.addNewClientBtn.Click += new System.EventHandler(this.addNewClientBtn_Click);
            // 
            // searchClientTxtBox
            // 
            // 
            // 
            // 
            this.searchClientTxtBox.CustomButton.Image = null;
            this.searchClientTxtBox.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.searchClientTxtBox.CustomButton.Name = "";
            this.searchClientTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchClientTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchClientTxtBox.CustomButton.TabIndex = 1;
            this.searchClientTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchClientTxtBox.CustomButton.UseSelectable = true;
            this.searchClientTxtBox.CustomButton.Visible = false;
            this.searchClientTxtBox.Lines = new string[0];
            this.searchClientTxtBox.Location = new System.Drawing.Point(23, 240);
            this.searchClientTxtBox.MaxLength = 32767;
            this.searchClientTxtBox.Name = "searchClientTxtBox";
            this.searchClientTxtBox.PasswordChar = '\0';
            this.searchClientTxtBox.PromptText = "Search by Client Name";
            this.searchClientTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchClientTxtBox.SelectedText = "";
            this.searchClientTxtBox.SelectionLength = 0;
            this.searchClientTxtBox.SelectionStart = 0;
            this.searchClientTxtBox.ShortcutsEnabled = true;
            this.searchClientTxtBox.Size = new System.Drawing.Size(212, 23);
            this.searchClientTxtBox.TabIndex = 2;
            this.searchClientTxtBox.UseSelectable = true;
            this.searchClientTxtBox.WaterMark = "Search by Client Name";
            this.searchClientTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchClientTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchClientTxtBox.TextChanged += new System.EventHandler(this.searchClientTxtBox_TextChanged);
            // 
            // showAllClientBtn
            // 
            this.showAllClientBtn.Location = new System.Drawing.Point(255, 240);
            this.showAllClientBtn.Name = "showAllClientBtn";
            this.showAllClientBtn.Size = new System.Drawing.Size(100, 23);
            this.showAllClientBtn.TabIndex = 3;
            this.showAllClientBtn.Text = "Show All";
            this.showAllClientBtn.UseSelectable = true;
            this.showAllClientBtn.Click += new System.EventHandler(this.showAllClientBtn_Click);
            // 
            // noOfProjTile
            // 
            this.noOfProjTile.ActiveControl = null;
            this.noOfProjTile.Location = new System.Drawing.Point(23, 99);
            this.noOfProjTile.Name = "noOfProjTile";
            this.noOfProjTile.Size = new System.Drawing.Size(146, 73);
            this.noOfProjTile.TabIndex = 4;
            this.noOfProjTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.noOfProjTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.noOfProjTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.noOfProjTile.UseCustomBackColor = true;
            this.noOfProjTile.UseSelectable = true;
            // 
            // noOfVisitsTile
            // 
            this.noOfVisitsTile.ActiveControl = null;
            this.noOfVisitsTile.Location = new System.Drawing.Point(241, 99);
            this.noOfVisitsTile.Name = "noOfVisitsTile";
            this.noOfVisitsTile.Size = new System.Drawing.Size(114, 73);
            this.noOfVisitsTile.TabIndex = 5;
            this.noOfVisitsTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.noOfVisitsTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.noOfVisitsTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.noOfVisitsTile.UseCustomBackColor = true;
            this.noOfVisitsTile.UseSelectable = true;
            // 
            // totalExpTile
            // 
            this.totalExpTile.ActiveControl = null;
            this.totalExpTile.Location = new System.Drawing.Point(457, 99);
            this.totalExpTile.Name = "totalExpTile";
            this.totalExpTile.Size = new System.Drawing.Size(187, 73);
            this.totalExpTile.TabIndex = 6;
            this.totalExpTile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.totalExpTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.totalExpTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.totalExpTile.UseCustomBackColor = true;
            this.totalExpTile.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(24, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(103, 20);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "No of Projects";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(241, 73);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(85, 20);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "No of Visits";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(457, 73);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(100, 20);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Total Expense";
            // 
            // gridViewUsageLbl
            // 
            this.gridViewUsageLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gridViewUsageLbl.AutoSize = true;
            this.gridViewUsageLbl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.gridViewUsageLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.gridViewUsageLbl.Location = new System.Drawing.Point(33, 580);
            this.gridViewUsageLbl.Name = "gridViewUsageLbl";
            this.gridViewUsageLbl.Size = new System.Drawing.Size(621, 17);
            this.gridViewUsageLbl.TabIndex = 10;
            this.gridViewUsageLbl.Text = "*Click row to view details      *Click row header to goto projects      *Click on" +
    " a email cell to send an email";
            this.gridViewUsageLbl.UseCustomForeColor = true;
            // 
            // updateClientBtn
            // 
            this.updateClientBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateClientBtn.Location = new System.Drawing.Point(517, 234);
            this.updateClientBtn.Name = "updateClientBtn";
            this.updateClientBtn.Size = new System.Drawing.Size(127, 29);
            this.updateClientBtn.TabIndex = 11;
            this.updateClientBtn.Text = "Update Client";
            this.updateClientBtn.UseSelectable = true;
            this.updateClientBtn.Click += new System.EventHandler(this.updateClientBtn_Click);
            // 
            // ShowMoreBtn
            // 
            this.ShowMoreBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowMoreBtn.Location = new System.Drawing.Point(701, 148);
            this.ShowMoreBtn.Name = "ShowMoreBtn";
            this.ShowMoreBtn.Size = new System.Drawing.Size(75, 23);
            this.ShowMoreBtn.Style = MetroFramework.MetroColorStyle.Brown;
            this.ShowMoreBtn.TabIndex = 12;
            this.ShowMoreBtn.Text = "More";
            this.ShowMoreBtn.UseSelectable = true;
            this.ShowMoreBtn.UseStyleColors = true;
            this.ShowMoreBtn.Click += new System.EventHandler(this.ShowMoreBtn_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.ShowMoreBtn);
            this.Controls.Add(this.updateClientBtn);
            this.Controls.Add(this.gridViewUsageLbl);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.totalExpTile);
            this.Controls.Add(this.noOfVisitsTile);
            this.Controls.Add(this.noOfProjTile);
            this.Controls.Add(this.showAllClientBtn);
            this.Controls.Add(this.searchClientTxtBox);
            this.Controls.Add(this.addNewClientBtn);
            this.Controls.Add(this.clientGrid);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ClientForm";
            this.Text = "Client";
            this.MinimumSizeChanged += new System.EventHandler(this.ClientForm_MinimumSizeChanged);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.ClientForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.clientGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid clientGrid;
        private MetroFramework.Controls.MetroButton addNewClientBtn;
        private MetroFramework.Controls.MetroTextBox searchClientTxtBox;
        private MetroFramework.Controls.MetroButton showAllClientBtn;
        private MetroFramework.Controls.MetroTile noOfProjTile;
        private MetroFramework.Controls.MetroTile noOfVisitsTile;
        private MetroFramework.Controls.MetroTile totalExpTile;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel gridViewUsageLbl;
        private MetroFramework.Controls.MetroButton updateClientBtn;
        private MetroFramework.Controls.MetroButton ShowMoreBtn;
    }
}

