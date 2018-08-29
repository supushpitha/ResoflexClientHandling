namespace ResoflexClientHandlingSystem
{
    partial class MemberListForm
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
            this.MembersGrid = new MetroFramework.Controls.MetroGrid();
            this.staffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facebook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkedIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basicSal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateMemBtn = new MetroFramework.Controls.MetroButton();
            this.GotoAddmemBtn = new MetroFramework.Controls.MetroButton();
            this.DelMemBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.MembersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MembersGrid
            // 
            this.MembersGrid.AllowUserToResizeRows = false;
            this.MembersGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MembersGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MembersGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MembersGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MembersGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MembersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MembersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffID,
            this.fname,
            this.lname,
            this.nic,
            this.desg,
            this.pAddress,
            this.sAddress,
            this.tel1,
            this.tel2,
            this.email,
            this.facebook,
            this.linkedIn,
            this.basicSal,
            this.otRate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MembersGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.MembersGrid.EnableHeadersVisualStyles = false;
            this.MembersGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MembersGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MembersGrid.Location = new System.Drawing.Point(49, 113);
            this.MembersGrid.Name = "MembersGrid";
            this.MembersGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MembersGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MembersGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MembersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MembersGrid.Size = new System.Drawing.Size(694, 309);
            this.MembersGrid.TabIndex = 0;
            // 
            // staffID
            // 
            this.staffID.HeaderText = "ID";
            this.staffID.Name = "staffID";
            // 
            // fname
            // 
            this.fname.HeaderText = "First Name";
            this.fname.Name = "fname";
            // 
            // lname
            // 
            this.lname.HeaderText = "Last Name";
            this.lname.Name = "lname";
            // 
            // nic
            // 
            this.nic.HeaderText = "NIC";
            this.nic.Name = "nic";
            // 
            // desg
            // 
            this.desg.HeaderText = "Designation";
            this.desg.Name = "desg";
            // 
            // pAddress
            // 
            this.pAddress.HeaderText = "Primary Address";
            this.pAddress.Name = "pAddress";
            // 
            // sAddress
            // 
            this.sAddress.HeaderText = "Secondary Address";
            this.sAddress.Name = "sAddress";
            // 
            // tel1
            // 
            this.tel1.HeaderText = "Tel No 1";
            this.tel1.Name = "tel1";
            // 
            // tel2
            // 
            this.tel2.HeaderText = "Tel No 2";
            this.tel2.Name = "tel2";
            // 
            // email
            // 
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            // 
            // facebook
            // 
            this.facebook.HeaderText = "Facebook";
            this.facebook.Name = "facebook";
            // 
            // linkedIn
            // 
            this.linkedIn.HeaderText = "LinkedIn";
            this.linkedIn.Name = "linkedIn";
            // 
            // basicSal
            // 
            this.basicSal.HeaderText = "Basic salary";
            this.basicSal.Name = "basicSal";
            // 
            // otRate
            // 
            this.otRate.HeaderText = "OT rate";
            this.otRate.Name = "otRate";
            // 
            // UpdateMemBtn
            // 
            this.UpdateMemBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.UpdateMemBtn.Location = new System.Drawing.Point(604, 54);
            this.UpdateMemBtn.Name = "UpdateMemBtn";
            this.UpdateMemBtn.Size = new System.Drawing.Size(138, 35);
            this.UpdateMemBtn.TabIndex = 1;
            this.UpdateMemBtn.Text = "Update";
            this.UpdateMemBtn.UseSelectable = true;
            // 
            // GotoAddmemBtn
            // 
            this.GotoAddmemBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.GotoAddmemBtn.Location = new System.Drawing.Point(258, 54);
            this.GotoAddmemBtn.Name = "GotoAddmemBtn";
            this.GotoAddmemBtn.Size = new System.Drawing.Size(163, 35);
            this.GotoAddmemBtn.TabIndex = 2;
            this.GotoAddmemBtn.Text = "Add new member";
            this.GotoAddmemBtn.UseSelectable = true;
            this.GotoAddmemBtn.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // DelMemBtn
            // 
            this.DelMemBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.DelMemBtn.Location = new System.Drawing.Point(445, 54);
            this.DelMemBtn.Name = "DelMemBtn";
            this.DelMemBtn.Size = new System.Drawing.Size(138, 35);
            this.DelMemBtn.TabIndex = 3;
            this.DelMemBtn.Text = "Delete";
            this.DelMemBtn.UseSelectable = true;
            // 
            // MemberListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DelMemBtn);
            this.Controls.Add(this.GotoAddmemBtn);
            this.Controls.Add(this.UpdateMemBtn);
            this.Controls.Add(this.MembersGrid);
            this.Name = "MemberListForm";
            this.Text = "Member List";
            ((System.ComponentModel.ISupportInitialize)(this.MembersGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid MembersGrid;
        private MetroFramework.Controls.MetroButton UpdateMemBtn;
        public MetroFramework.Controls.MetroButton GotoAddmemBtn;
        private MetroFramework.Controls.MetroButton DelMemBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn nic;
        private System.Windows.Forms.DataGridViewTextBoxColumn desg;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn facebook;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkedIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basicSal;
        private System.Windows.Forms.DataGridViewTextBoxColumn otRate;
    }
}