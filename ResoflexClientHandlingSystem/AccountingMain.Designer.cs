namespace ResoflexClientHandlingSystem
{
    partial class AccountingMain
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
            this.profilebtn = new MetroFramework.Controls.MetroButton();
            this.Project = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // profilebtn
            // 
            this.profilebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.profilebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.profilebtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.profilebtn.Location = new System.Drawing.Point(431, 34);
            this.profilebtn.Name = "profilebtn";
            this.profilebtn.Size = new System.Drawing.Size(105, 29);
            this.profilebtn.TabIndex = 20;
            this.profilebtn.UseCustomBackColor = true;
            this.profilebtn.UseSelectable = true;
            this.profilebtn.Click += new System.EventHandler(this.profilebtn_Click);
            // 
            // Project
            // 
            this.Project.ActiveControl = null;
            this.Project.Location = new System.Drawing.Point(56, 129);
            this.Project.Name = "Project";
            this.Project.Size = new System.Drawing.Size(420, 108);
            this.Project.Style = MetroFramework.MetroColorStyle.Blue;
            this.Project.TabIndex = 21;
            this.Project.Text = "Project/Event Expenses";
            this.Project.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Project.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Project.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.Project.UseSelectable = true;
            this.Project.Click += new System.EventHandler(this.Project_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(56, 259);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(420, 108);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile2.TabIndex = 22;
            this.metroTile2.Text = "Office Expenses";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(56, 394);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(420, 108);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile3.TabIndex = 23;
            this.metroTile3.Text = "Salary Expenses";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // AccountingMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 544);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.Project);
            this.Controls.Add(this.profilebtn);
            this.MaximumSize = new System.Drawing.Size(559, 544);
            this.MinimumSize = new System.Drawing.Size(559, 544);
            this.Name = "AccountingMain";
            this.Text = "Accounting";
            this.Load += new System.EventHandler(this.AccountingMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton profilebtn;
        private MetroFramework.Controls.MetroTile Project;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
    }
}