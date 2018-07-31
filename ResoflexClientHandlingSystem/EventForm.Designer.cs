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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventForm));
            this.addEvent = new MetroFramework.Controls.MetroButton();
            this.updateEvent = new MetroFramework.Controls.MetroButton();
            this.deleteEvent = new MetroFramework.Controls.MetroButton();
            this.dailyEventTile = new MetroFramework.Controls.MetroTile();
            this.totalEventTile = new MetroFramework.Controls.MetroTile();
            this.eventGrid = new MetroFramework.Controls.MetroGrid();
            this.clientName = new MetroFramework.Controls.MetroTextBox();
            this.projectName = new MetroFramework.Controls.MetroTextBox();
            this.schCltName = new MetroFramework.Controls.MetroLabel();
            this.schPrjName = new MetroFramework.Controls.MetroLabel();
            this.schHome = new MetroFramework.Controls.MetroButton();
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
            // 
            // updateEvent
            // 
            this.updateEvent.Location = new System.Drawing.Point(533, 543);
            this.updateEvent.Name = "updateEvent";
            this.updateEvent.Size = new System.Drawing.Size(96, 23);
            this.updateEvent.TabIndex = 23;
            this.updateEvent.Text = "Update Event";
            this.updateEvent.UseSelectable = true;
            // 
            // deleteEvent
            // 
            this.deleteEvent.Location = new System.Drawing.Point(382, 543);
            this.deleteEvent.Name = "deleteEvent";
            this.deleteEvent.Size = new System.Drawing.Size(96, 23);
            this.deleteEvent.TabIndex = 22;
            this.deleteEvent.Text = "Delete Event";
            this.deleteEvent.UseSelectable = true;
            // 
            // dailyEventTile
            // 
            this.dailyEventTile.ActiveControl = null;
            this.dailyEventTile.Location = new System.Drawing.Point(175, 436);
            this.dailyEventTile.Name = "dailyEventTile";
            this.dailyEventTile.Size = new System.Drawing.Size(142, 87);
            this.dailyEventTile.TabIndex = 21;
            this.dailyEventTile.Text = "Daily Events";
            this.dailyEventTile.UseSelectable = true;
            // 
            // totalEventTile
            // 
            this.totalEventTile.ActiveControl = null;
            this.totalEventTile.Location = new System.Drawing.Point(25, 436);
            this.totalEventTile.Name = "totalEventTile";
            this.totalEventTile.Size = new System.Drawing.Size(142, 87);
            this.totalEventTile.TabIndex = 20;
            this.totalEventTile.Text = "Total Event";
            this.totalEventTile.UseSelectable = true;
            // 
            // eventGrid
            // 
            this.eventGrid.AllowUserToResizeRows = false;
            this.eventGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.eventGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eventGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.eventGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.eventGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.eventGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.eventGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.eventGrid.EnableHeadersVisualStyles = false;
            this.eventGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.eventGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.eventGrid.Location = new System.Drawing.Point(382, 149);
            this.eventGrid.Name = "eventGrid";
            this.eventGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.eventGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.eventGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.eventGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eventGrid.Size = new System.Drawing.Size(394, 374);
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
            this.clientName.Location = new System.Drawing.Point(679, 109);
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
            this.projectName.Location = new System.Drawing.Point(478, 109);
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
            this.schCltName.Location = new System.Drawing.Point(591, 109);
            this.schCltName.Name = "schCltName";
            this.schCltName.Size = new System.Drawing.Size(82, 19);
            this.schCltName.TabIndex = 16;
            this.schCltName.Text = "Client Name";
            // 
            // schPrjName
            // 
            this.schPrjName.AutoSize = true;
            this.schPrjName.Location = new System.Drawing.Point(382, 109);
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
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.addEvent);
            this.Controls.Add(this.updateEvent);
            this.Controls.Add(this.deleteEvent);
            this.Controls.Add(this.dailyEventTile);
            this.Controls.Add(this.totalEventTile);
            this.Controls.Add(this.eventGrid);
            this.Controls.Add(this.clientName);
            this.Controls.Add(this.projectName);
            this.Controls.Add(this.schCltName);
            this.Controls.Add(this.schPrjName);
            this.Controls.Add(this.schHome);
            this.Name = "EventForm";
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
        private MetroFramework.Controls.MetroTile dailyEventTile;
        private MetroFramework.Controls.MetroTile totalEventTile;
        private MetroFramework.Controls.MetroGrid eventGrid;
        private MetroFramework.Controls.MetroTextBox clientName;
        private MetroFramework.Controls.MetroTextBox projectName;
        private MetroFramework.Controls.MetroLabel schCltName;
        private MetroFramework.Controls.MetroLabel schPrjName;
        private MetroFramework.Controls.MetroButton schHome;
    }
}