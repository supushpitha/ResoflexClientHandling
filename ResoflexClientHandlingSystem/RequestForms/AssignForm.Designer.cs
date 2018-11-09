namespace ResoflexClientHandlingSystem.RequestForms
{
    partial class AssignForm
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
            this.devCmbBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.assignBtn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // devCmbBox
            // 
            this.devCmbBox.FormattingEnabled = true;
            this.devCmbBox.ItemHeight = 23;
            this.devCmbBox.Location = new System.Drawing.Point(23, 115);
            this.devCmbBox.Name = "devCmbBox";
            this.devCmbBox.Size = new System.Drawing.Size(305, 29);
            this.devCmbBox.TabIndex = 0;
            this.devCmbBox.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 93);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(110, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Select Developer";
            // 
            // assignBtn
            // 
            this.assignBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.assignBtn.Location = new System.Drawing.Point(240, 151);
            this.assignBtn.Name = "assignBtn";
            this.assignBtn.Size = new System.Drawing.Size(87, 27);
            this.assignBtn.TabIndex = 2;
            this.assignBtn.Text = "Assign";
            this.assignBtn.UseSelectable = true;
            this.assignBtn.Click += new System.EventHandler(this.assignBtn_Click);
            // 
            // AssignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 238);
            this.Controls.Add(this.assignBtn);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.devCmbBox);
            this.Name = "AssignForm";
            this.Text = "AssignForm";
            this.Load += new System.EventHandler(this.AssignForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox devCmbBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton assignBtn;
    }
}