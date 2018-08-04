namespace ResoflexClientHandlingSystem
{
    partial class EventForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventForm));
            this.addEvent = new MetroFramework.Controls.MetroButton();
            this.updateEvent = new MetroFramework.Controls.MetroButton();
            this.deleteEvent = new MetroFramework.Controls.MetroButton();
            this.eventGrid = new MetroFramework.Controls.MetroGrid();
            this.clientName = new MetroFramework.Controls.MetroTextBox();
            this.projectName = new MetroFramework.Controls.MetroTextBox();
            this.schCltName = new MetroFramework.Controls.MetroLabel();
            this.schPrjName = new MetroFramework.Controls.MetroLabel();
            this.schHome = new MetroFramework.Controls.MetroButton();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.eventGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addEvent
            // 
            this.addEvent.Location = new System.Drawing.Point(679, 543);
            this.addEvent.Name = "addEvent";
            this.addEvent.Size = new System.Drawing.Size(96, 23);
            this.addEvent.TabIndex = 24;
            this.addEvent.Text = "Add Event";
            this.addEvent.UseSelectable = true;
            this.addEvent.Click += new System.EventHandler(this.addEvent_Click);
            // 
            // updateEvent
            // 
            this.updateEvent.Location = new System.Drawing.Point(502, 543);
            this.updateEvent.Name = "updateEvent";
            this.updateEvent.Size = new System.Drawing.Size(90, 23);
            this.updateEvent.TabIndex = 23;
            this.updateEvent.Text = "Update Event";
            this.updateEvent.UseSelectable = true;
            // 
            // deleteEvent
            // 
            this.deleteEvent.Location = new System.Drawing.Point(307, 543);
            this.deleteEvent.Name = "deleteEvent";
            this.deleteEvent.Size = new System.Drawing.Size(96, 23);
            this.deleteEvent.TabIndex = 22;
            this.deleteEvent.Text = "Delete Event";
            this.deleteEvent.UseSelectable = true;
            // 
            // eventGrid
            // 
            this.eventGrid.AllowUserToResizeRows = false;
            this.eventGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.eventGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eventGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.eventGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.eventGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.eventGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.eventGrid.DefaultCellStyle = dataGridViewCellStyle11;
            this.eventGrid.EnableHeadersVisualStyles = false;
            this.eventGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.eventGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.eventGrid.Location = new System.Drawing.Point(307, 149);
            this.eventGrid.Name = "eventGrid";
            this.eventGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.eventGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.eventGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.eventGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eventGrid.Size = new System.Drawing.Size(470, 374);
            this.eventGrid.TabIndex = 19;
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
            this.clientName.Location = new System.Drawing.Point(604, 106);
            this.clientName.MaxLength = 32767;
            this.clientName.Name = "clientName";
            this.clientName.PasswordChar = '\0';
            this.clientName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.clientName.SelectedText = "";
            this.clientName.SelectionLength = 0;
            this.clientName.SelectionStart = 0;
            this.clientName.ShortcutsEnabled = true;
            this.clientName.Size = new System.Drawing.Size(97, 23);
            this.clientName.TabIndex = 18;
            this.clientName.UseSelectable = true;
            this.clientName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.clientName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.projectName.Location = new System.Drawing.Point(403, 106);
            this.projectName.MaxLength = 32767;
            this.projectName.Name = "projectName";
            this.projectName.PasswordChar = '\0';
            this.projectName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.projectName.SelectedText = "";
            this.projectName.SelectionLength = 0;
            this.projectName.SelectionStart = 0;
            this.projectName.ShortcutsEnabled = true;
            this.projectName.Size = new System.Drawing.Size(97, 23);
            this.projectName.TabIndex = 17;
            this.projectName.UseSelectable = true;
            this.projectName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.projectName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // schCltName
            // 
            this.schCltName.AutoSize = true;
            this.schCltName.Location = new System.Drawing.Point(516, 106);
            this.schCltName.Name = "schCltName";
            this.schCltName.Size = new System.Drawing.Size(82, 19);
            this.schCltName.TabIndex = 16;
            this.schCltName.Text = "Client Name";
            // 
            // schPrjName
            // 
            this.schPrjName.AutoSize = true;
            this.schPrjName.Location = new System.Drawing.Point(307, 106);
            this.schPrjName.Name = "schPrjName";
            this.schPrjName.Size = new System.Drawing.Size(90, 19);
            this.schPrjName.TabIndex = 15;
            this.schPrjName.Text = "Project Name";
            // 
            // schHome
            // 
            this.schHome.BackColor = System.Drawing.Color.Transparent;
            this.schHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("schHome.BackgroundImage")));
            this.schHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.schHome.Location = new System.Drawing.Point(382, 35);
            this.schHome.Margin = new System.Windows.Forms.Padding(2);
            this.schHome.Name = "schHome";
            this.schHome.Size = new System.Drawing.Size(30, 24);
            this.schHome.TabIndex = 14;
            this.schHome.UseSelectable = true;
            this.schHome.Click += new System.EventHandler(this.schHome_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(23, 149);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(248, 87);
            this.metroTile3.TabIndex = 27;
            this.metroTile3.Text = "Incomplete Events";
            this.metroTile3.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(23, 262);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(248, 87);
            this.metroTile2.TabIndex = 26;
            this.metroTile2.Text = "Daily Events";
            this.metroTile2.UseSelectable = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(23, 374);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(248, 87);
            this.metroTile1.TabIndex = 25;
            this.metroTile1.Text = "Total Events";
            this.metroTile1.UseSelectable = true;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.addEvent);
            this.Controls.Add(this.updateEvent);
            this.Controls.Add(this.deleteEvent);
            this.Controls.Add(this.eventGrid);
            this.Controls.Add(this.clientName);
            this.Controls.Add(this.projectName);
            this.Controls.Add(this.schCltName);
            this.Controls.Add(this.schPrjName);
            this.Controls.Add(this.schHome);
            this.Name = "EventForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Event";
            this.Load += new System.EventHandler(this.EventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton addEvent;
        private MetroFramework.Controls.MetroButton updateEvent;
        private MetroFramework.Controls.MetroButton deleteEvent;
        private MetroFramework.Controls.MetroGrid eventGrid;
        private MetroFramework.Controls.MetroTextBox clientName;
        private MetroFramework.Controls.MetroTextBox projectName;
        private MetroFramework.Controls.MetroLabel schCltName;
        private MetroFramework.Controls.MetroLabel schPrjName;
        private MetroFramework.Controls.MetroButton schHome;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}