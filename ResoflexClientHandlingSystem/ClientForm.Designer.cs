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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.clientGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // clientGrid
            // 
            this.clientGrid.AllowUserToAddRows = false;
            this.clientGrid.AllowUserToDeleteRows = false;
            this.clientGrid.AllowUserToResizeRows = false;
            this.clientGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clientGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.clientGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.clientGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clientGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.clientGrid.EnableHeadersVisualStyles = false;
            this.clientGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.clientGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clientGrid.Location = new System.Drawing.Point(17, 228);
            this.clientGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clientGrid.Name = "clientGrid";
            this.clientGrid.ReadOnly = true;
            this.clientGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.clientGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.clientGrid.RowTemplate.Height = 24;
            this.clientGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientGrid.Size = new System.Drawing.Size(566, 241);
            this.clientGrid.TabIndex = 0;
            this.clientGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientGrid_CellClick);
            this.clientGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.clientGrid_RowHeaderMouseClick);
            this.clientGrid.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.clientGrid_RowHeaderMouseDoubleClick);
            // 
            // addNewClientBtn
            // 
            this.addNewClientBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addNewClientBtn.Location = new System.Drawing.Point(466, 190);
            this.addNewClientBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addNewClientBtn.Name = "addNewClientBtn";
            this.addNewClientBtn.Size = new System.Drawing.Size(116, 24);
            this.addNewClientBtn.TabIndex = 1;
            this.addNewClientBtn.Text = "Add New Client";
            this.addNewClientBtn.UseSelectable = true;
            this.addNewClientBtn.Click += new System.EventHandler(this.addNewClientBtn_Click);
            // 
            // searchClientTxtBox
            // 
            this.searchClientTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.searchClientTxtBox.CustomButton.Image = null;
            this.searchClientTxtBox.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.searchClientTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchClientTxtBox.CustomButton.Name = "";
            this.searchClientTxtBox.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.searchClientTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchClientTxtBox.CustomButton.TabIndex = 1;
            this.searchClientTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchClientTxtBox.CustomButton.UseSelectable = true;
            this.searchClientTxtBox.CustomButton.Visible = false;
            this.searchClientTxtBox.Lines = new string[0];
            this.searchClientTxtBox.Location = new System.Drawing.Point(17, 195);
            this.searchClientTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchClientTxtBox.MaxLength = 32767;
            this.searchClientTxtBox.Name = "searchClientTxtBox";
            this.searchClientTxtBox.PasswordChar = '\0';
            this.searchClientTxtBox.PromptText = "Search by Client Name";
            this.searchClientTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchClientTxtBox.SelectedText = "";
            this.searchClientTxtBox.SelectionLength = 0;
            this.searchClientTxtBox.SelectionStart = 0;
            this.searchClientTxtBox.ShortcutsEnabled = true;
            this.searchClientTxtBox.Size = new System.Drawing.Size(159, 19);
            this.searchClientTxtBox.TabIndex = 2;
            this.searchClientTxtBox.UseSelectable = true;
            this.searchClientTxtBox.WaterMark = "Search by Client Name";
            this.searchClientTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchClientTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchClientTxtBox.TextChanged += new System.EventHandler(this.searchClientTxtBox_TextChanged);
            // 
            // showAllClientBtn
            // 
            this.showAllClientBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.showAllClientBtn.Location = new System.Drawing.Point(191, 195);
            this.showAllClientBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showAllClientBtn.Name = "showAllClientBtn";
            this.showAllClientBtn.Size = new System.Drawing.Size(75, 19);
            this.showAllClientBtn.TabIndex = 3;
            this.showAllClientBtn.Text = "Show All";
            this.showAllClientBtn.UseSelectable = true;
            this.showAllClientBtn.Click += new System.EventHandler(this.showAllClientBtn_Click);
            // 
            // noOfProjTile
            // 
            this.noOfProjTile.ActiveControl = null;
            this.noOfProjTile.Location = new System.Drawing.Point(17, 80);
            this.noOfProjTile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.noOfProjTile.Name = "noOfProjTile";
            this.noOfProjTile.Size = new System.Drawing.Size(121, 84);
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
            this.noOfVisitsTile.Location = new System.Drawing.Point(181, 80);
            this.noOfVisitsTile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.noOfVisitsTile.Name = "noOfVisitsTile";
            this.noOfVisitsTile.Size = new System.Drawing.Size(121, 84);
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
            this.totalExpTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalExpTile.Location = new System.Drawing.Point(343, 80);
            this.totalExpTile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.totalExpTile.Name = "totalExpTile";
            this.totalExpTile.Size = new System.Drawing.Size(178, 84);
            this.totalExpTile.TabIndex = 6;
            this.totalExpTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalExpTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.totalExpTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.totalExpTile.UseCustomBackColor = true;
            this.totalExpTile.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(18, 59);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "No of Projects";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(181, 59);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "No of Visits";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(343, 59);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(91, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Total Expense";
            // 
            // gridViewUsageLbl
            // 
            this.gridViewUsageLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gridViewUsageLbl.AutoSize = true;
            this.gridViewUsageLbl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.gridViewUsageLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.gridViewUsageLbl.Location = new System.Drawing.Point(25, 471);
            this.gridViewUsageLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gridViewUsageLbl.Name = "gridViewUsageLbl";
            this.gridViewUsageLbl.Size = new System.Drawing.Size(535, 15);
            this.gridViewUsageLbl.TabIndex = 10;
            this.gridViewUsageLbl.Text = "*Click row to view details      *Double click row header to update    *Click row " +
    "header to goto projects";
            this.gridViewUsageLbl.UseCustomForeColor = true;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 488);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(600, 488);
            this.Name = "ClientForm";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
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
    }
}

