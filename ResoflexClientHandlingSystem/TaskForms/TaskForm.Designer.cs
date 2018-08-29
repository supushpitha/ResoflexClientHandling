namespace ResoflexClientHandlingSystem.TaskForms
{
    partial class TaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskForm));
            this.taskGrid = new MetroFramework.Controls.MetroGrid();
            this.schHome = new MetroFramework.Controls.MetroButton();
            this.firstName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lastName = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.taskGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // taskGrid
            // 
            this.taskGrid.AllowUserToResizeRows = false;
            this.taskGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.taskGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.taskGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.taskGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.taskGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.taskGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.taskGrid.EnableHeadersVisualStyles = false;
            this.taskGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.taskGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.taskGrid.Location = new System.Drawing.Point(23, 163);
            this.taskGrid.Name = "taskGrid";
            this.taskGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.taskGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.taskGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.taskGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.taskGrid.Size = new System.Drawing.Size(754, 354);
            this.taskGrid.TabIndex = 0;
            // 
            // schHome
            // 
            this.schHome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.schHome.BackColor = System.Drawing.Color.Transparent;
            this.schHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("schHome.BackgroundImage")));
            this.schHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.schHome.Location = new System.Drawing.Point(380, 40);
            this.schHome.Margin = new System.Windows.Forms.Padding(2);
            this.schHome.Name = "schHome";
            this.schHome.Size = new System.Drawing.Size(30, 24);
            this.schHome.TabIndex = 4;
            this.schHome.UseSelectable = true;
            this.schHome.Click += new System.EventHandler(this.schHome_Click);
            // 
            // firstName
            // 
            this.firstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.firstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.firstName.CustomButton.Image = null;
            this.firstName.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.firstName.CustomButton.Name = "";
            this.firstName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.firstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.firstName.CustomButton.TabIndex = 1;
            this.firstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.firstName.CustomButton.UseSelectable = true;
            this.firstName.CustomButton.Visible = false;
            this.firstName.Lines = new string[0];
            this.firstName.Location = new System.Drawing.Point(102, 130);
            this.firstName.MaxLength = 32767;
            this.firstName.Name = "firstName";
            this.firstName.PasswordChar = '\0';
            this.firstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.firstName.SelectedText = "";
            this.firstName.SelectionLength = 0;
            this.firstName.SelectionStart = 0;
            this.firstName.ShortcutsEnabled = true;
            this.firstName.Size = new System.Drawing.Size(208, 23);
            this.firstName.TabIndex = 6;
            this.firstName.UseSelectable = true;
            this.firstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.firstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.firstName.TextChanged += new System.EventHandler(this.searchTaskSearchByStaffName_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 130);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "First Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(350, 130);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Last Name";
            // 
            // lastName
            // 
            this.lastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.lastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.lastName.CustomButton.Image = null;
            this.lastName.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.lastName.CustomButton.Name = "";
            this.lastName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lastName.CustomButton.TabIndex = 1;
            this.lastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lastName.CustomButton.UseSelectable = true;
            this.lastName.CustomButton.Visible = false;
            this.lastName.Lines = new string[0];
            this.lastName.Location = new System.Drawing.Point(429, 130);
            this.lastName.MaxLength = 32767;
            this.lastName.Name = "lastName";
            this.lastName.PasswordChar = '\0';
            this.lastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lastName.SelectedText = "";
            this.lastName.SelectionLength = 0;
            this.lastName.SelectionStart = 0;
            this.lastName.ShortcutsEnabled = true;
            this.lastName.Size = new System.Drawing.Size(208, 23);
            this.lastName.TabIndex = 8;
            this.lastName.UseSelectable = true;
            this.lastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.lastName.TextChanged += new System.EventHandler(this.searchTaskSearchByStaffName_TextChanged);
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.schHome);
            this.Controls.Add(this.taskGrid);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "TaskForm";
            this.Text = "Tasks";
            ((System.ComponentModel.ISupportInitialize)(this.taskGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid taskGrid;
        private MetroFramework.Controls.MetroButton schHome;
        private MetroFramework.Controls.MetroTextBox firstName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox lastName;
    }
}