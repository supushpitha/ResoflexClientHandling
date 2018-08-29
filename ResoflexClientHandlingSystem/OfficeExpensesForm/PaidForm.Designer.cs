namespace ResoflexClientHandlingSystem.OfficeExpenses
{
    partial class Paid
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.salaryGrid = new MetroFramework.Controls.MetroGrid();
            this.salUpdateBtn = new MetroFramework.Controls.MetroButton();
            this.positionCmbBox = new MetroFramework.Controls.MetroComboBox();
            this.staffNameCmbBox = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.salaryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(167, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "EMPLOYEE INFORMATION";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(355, 115);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Position";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 115);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Name";
            // 
            // salaryGrid
            // 
            this.salaryGrid.AllowUserToAddRows = false;
            this.salaryGrid.AllowUserToDeleteRows = false;
            this.salaryGrid.AllowUserToResizeRows = false;
            this.salaryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salaryGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.salaryGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salaryGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.salaryGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salaryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.salaryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salaryGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.salaryGrid.EnableHeadersVisualStyles = false;
            this.salaryGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.salaryGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.salaryGrid.Location = new System.Drawing.Point(23, 167);
            this.salaryGrid.Name = "salaryGrid";
            this.salaryGrid.ReadOnly = true;
            this.salaryGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salaryGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.salaryGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.salaryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salaryGrid.Size = new System.Drawing.Size(655, 330);
            this.salaryGrid.TabIndex = 7;
            this.salaryGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salaryGrid_CellContentClick);
            // 
            // salUpdateBtn
            // 
            this.salUpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.salUpdateBtn.Location = new System.Drawing.Point(684, 463);
            this.salUpdateBtn.Name = "salUpdateBtn";
            this.salUpdateBtn.Size = new System.Drawing.Size(93, 34);
            this.salUpdateBtn.TabIndex = 8;
            this.salUpdateBtn.Text = "Update";
            this.salUpdateBtn.UseCustomBackColor = true;
            this.salUpdateBtn.UseSelectable = true;
            this.salUpdateBtn.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // positionCmbBox
            // 
            this.positionCmbBox.FormattingEnabled = true;
            this.positionCmbBox.ItemHeight = 23;
            this.positionCmbBox.Location = new System.Drawing.Point(416, 115);
            this.positionCmbBox.Name = "positionCmbBox";
            this.positionCmbBox.Size = new System.Drawing.Size(186, 29);
            this.positionCmbBox.TabIndex = 9;
            this.positionCmbBox.UseSelectable = true;
            // 
            // staffNameCmbBox
            // 
            this.staffNameCmbBox.FormattingEnabled = true;
            this.staffNameCmbBox.ItemHeight = 23;
            this.staffNameCmbBox.Location = new System.Drawing.Point(74, 115);
            this.staffNameCmbBox.Name = "staffNameCmbBox";
            this.staffNameCmbBox.Size = new System.Drawing.Size(255, 29);
            this.staffNameCmbBox.TabIndex = 10;
            this.staffNameCmbBox.UseSelectable = true;
            // 
            // Paid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.staffNameCmbBox);
            this.Controls.Add(this.positionCmbBox);
            this.Controls.Add(this.salUpdateBtn);
            this.Controls.Add(this.salaryGrid);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Paid";
            this.Text = "Paid";
            this.Load += new System.EventHandler(this.ExpenceReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salaryGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroGrid salaryGrid;
        private MetroFramework.Controls.MetroButton salUpdateBtn;
        private MetroFramework.Controls.MetroComboBox positionCmbBox;
        private MetroFramework.Controls.MetroComboBox staffNameCmbBox;
    }
}