namespace ResoflexClientHandlingSystem
{
    partial class ScheduleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.schHome = new MetroFramework.Controls.MetroButton();
            this.schPrjName = new MetroFramework.Controls.MetroLabel();
            this.schCltName = new MetroFramework.Controls.MetroLabel();
            this.projectName = new MetroFramework.Controls.MetroTextBox();
            this.clientName = new MetroFramework.Controls.MetroTextBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.deleteSchedule = new MetroFramework.Controls.MetroButton();
            this.updateSchedule = new MetroFramework.Controls.MetroButton();
            this.addSchedule = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // schHome
            // 
            this.schHome.BackColor = System.Drawing.Color.Transparent;
            this.schHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("schHome.BackgroundImage")));
            this.schHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.schHome.Location = new System.Drawing.Point(380, 40);
            this.schHome.Margin = new System.Windows.Forms.Padding(2);
            this.schHome.Name = "schHome";
            this.schHome.Size = new System.Drawing.Size(30, 24);
            this.schHome.TabIndex = 3;
            this.schHome.UseSelectable = true;
            this.schHome.Click += new System.EventHandler(this.schHome_Click);
            // 
            // schPrjName
            // 
            this.schPrjName.AutoSize = true;
            this.schPrjName.Location = new System.Drawing.Point(380, 114);
            this.schPrjName.Name = "schPrjName";
            this.schPrjName.Size = new System.Drawing.Size(90, 19);
            this.schPrjName.TabIndex = 4;
            this.schPrjName.Text = "Project Name";
            // 
            // schCltName
            // 
            this.schCltName.AutoSize = true;
            this.schCltName.Location = new System.Drawing.Point(589, 114);
            this.schCltName.Name = "schCltName";
            this.schCltName.Size = new System.Drawing.Size(82, 19);
            this.schCltName.TabIndex = 5;
            this.schCltName.Text = "Client Name";
            // 
            // projectName
            // 
            // 
            // 
            // 
            this.projectName.CustomButton.Image = null;
            this.projectName.CustomButton.Location = new System.Drawing.Point(75, 1);
            this.projectName.CustomButton.Name = "";
            this.projectName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.projectName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.projectName.CustomButton.TabIndex = 1;
            this.projectName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.projectName.CustomButton.UseSelectable = true;
            this.projectName.CustomButton.Visible = false;
            this.projectName.Lines = new string[0];
            this.projectName.Location = new System.Drawing.Point(476, 114);
            this.projectName.MaxLength = 32767;
            this.projectName.Name = "projectName";
            this.projectName.PasswordChar = '\0';
            this.projectName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.projectName.SelectedText = "";
            this.projectName.SelectionLength = 0;
            this.projectName.SelectionStart = 0;
            this.projectName.ShortcutsEnabled = true;
            this.projectName.Size = new System.Drawing.Size(97, 23);
            this.projectName.TabIndex = 6;
            this.projectName.UseSelectable = true;
            this.projectName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.projectName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // clientName
            // 
            // 
            // 
            // 
            this.clientName.CustomButton.Image = null;
            this.clientName.CustomButton.Location = new System.Drawing.Point(75, 1);
            this.clientName.CustomButton.Name = "";
            this.clientName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.clientName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.clientName.CustomButton.TabIndex = 1;
            this.clientName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.clientName.CustomButton.UseSelectable = true;
            this.clientName.CustomButton.Visible = false;
            this.clientName.Lines = new string[0];
            this.clientName.Location = new System.Drawing.Point(677, 114);
            this.clientName.MaxLength = 32767;
            this.clientName.Name = "clientName";
            this.clientName.PasswordChar = '\0';
            this.clientName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.clientName.SelectedText = "";
            this.clientName.SelectionLength = 0;
            this.clientName.SelectionStart = 0;
            this.clientName.ShortcutsEnabled = true;
            this.clientName.Size = new System.Drawing.Size(97, 23);
            this.clientName.TabIndex = 7;
            this.clientName.UseSelectable = true;
            this.clientName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.clientName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.metroGrid1.Location = new System.Drawing.Point(380, 154);
            this.metroGrid1.Name = "metroGrid1";
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
            this.metroGrid1.Size = new System.Drawing.Size(394, 374);
            this.metroGrid1.TabIndex = 8;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(23, 441);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(142, 87);
            this.metroTile1.TabIndex = 9;
            this.metroTile1.Text = "Total Schedules";
            this.metroTile1.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(173, 441);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(142, 87);
            this.metroTile2.TabIndex = 10;
            this.metroTile2.Text = "Daily Schedules";
            this.metroTile2.UseSelectable = true;
            // 
            // deleteSchedule
            // 
            this.deleteSchedule.Location = new System.Drawing.Point(380, 548);
            this.deleteSchedule.Name = "deleteSchedule";
            this.deleteSchedule.Size = new System.Drawing.Size(96, 23);
            this.deleteSchedule.TabIndex = 11;
            this.deleteSchedule.Text = "Delete Schedule";
            this.deleteSchedule.UseSelectable = true;
            this.deleteSchedule.Click += new System.EventHandler(this.deleteSchedule_Click);
            // 
            // updateSchedule
            // 
            this.updateSchedule.Location = new System.Drawing.Point(531, 548);
            this.updateSchedule.Name = "updateSchedule";
            this.updateSchedule.Size = new System.Drawing.Size(96, 23);
            this.updateSchedule.TabIndex = 12;
            this.updateSchedule.Text = "Update Schedule";
            this.updateSchedule.UseSelectable = true;
            this.updateSchedule.Click += new System.EventHandler(this.updateSchedule_Click);
            // 
            // addSchedule
            // 
            this.addSchedule.Location = new System.Drawing.Point(677, 548);
            this.addSchedule.Name = "addSchedule";
            this.addSchedule.Size = new System.Drawing.Size(96, 23);
            this.addSchedule.TabIndex = 13;
            this.addSchedule.Text = "Add Schedule";
            this.addSchedule.UseSelectable = true;
            this.addSchedule.Click += new System.EventHandler(this.addSchedule_Click);
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.addSchedule);
            this.Controls.Add(this.updateSchedule);
            this.Controls.Add(this.deleteSchedule);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.clientName);
            this.Controls.Add(this.projectName);
            this.Controls.Add(this.schCltName);
            this.Controls.Add(this.schPrjName);
            this.Controls.Add(this.schHome);
            this.Name = "ScheduleForm";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.ScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton schHome;
        private MetroFramework.Controls.MetroLabel schPrjName;
        private MetroFramework.Controls.MetroLabel schCltName;
        private MetroFramework.Controls.MetroTextBox projectName;
        private MetroFramework.Controls.MetroTextBox clientName;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroButton deleteSchedule;
        private MetroFramework.Controls.MetroButton updateSchedule;
        private MetroFramework.Controls.MetroButton addSchedule;
    }
}