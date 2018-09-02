namespace ResoflexClientHandlingSystem
{
    partial class CashIssuingForm
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
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.confirmBtn = new MetroFramework.Controls.MetroButton();
            this.amountTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.cashDateTimeTxtBox = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.details = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.scheduleId = new MetroFramework.Controls.MetroTextBox();
            this.projectIdBox = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(80, 255);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(75, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Issued Date";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(80, 336);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(60, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Amount ";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(379, 375);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(100, 55);
            this.confirmBtn.TabIndex = 6;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseSelectable = true;
            this.confirmBtn.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // amountTxtBox
            // 
            // 
            // 
            // 
            this.amountTxtBox.CustomButton.Image = null;
            this.amountTxtBox.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.amountTxtBox.CustomButton.Name = "";
            this.amountTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.amountTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.amountTxtBox.CustomButton.TabIndex = 1;
            this.amountTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.amountTxtBox.CustomButton.UseSelectable = true;
            this.amountTxtBox.CustomButton.Visible = false;
            this.amountTxtBox.Lines = new string[0];
            this.amountTxtBox.Location = new System.Drawing.Point(242, 332);
            this.amountTxtBox.MaxLength = 32767;
            this.amountTxtBox.Name = "amountTxtBox";
            this.amountTxtBox.PasswordChar = '\0';
            this.amountTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.amountTxtBox.SelectedText = "";
            this.amountTxtBox.SelectionLength = 0;
            this.amountTxtBox.SelectionStart = 0;
            this.amountTxtBox.ShortcutsEnabled = true;
            this.amountTxtBox.Size = new System.Drawing.Size(75, 23);
            this.amountTxtBox.TabIndex = 11;
            this.amountTxtBox.UseSelectable = true;
            this.amountTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.amountTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cashDateTimeTxtBox
            // 
            this.cashDateTimeTxtBox.Location = new System.Drawing.Point(242, 255);
            this.cashDateTimeTxtBox.MinimumSize = new System.Drawing.Size(0, 29);
            this.cashDateTimeTxtBox.Name = "cashDateTimeTxtBox";
            this.cashDateTimeTxtBox.Size = new System.Drawing.Size(200, 29);
            this.cashDateTimeTxtBox.TabIndex = 12;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(80, 111);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(90, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Project Name";
            // 
            // details
            // 
            // 
            // 
            // 
            this.details.CustomButton.Image = null;
            this.details.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.details.CustomButton.Name = "";
            this.details.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.details.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.details.CustomButton.TabIndex = 1;
            this.details.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.details.CustomButton.UseSelectable = true;
            this.details.CustomButton.Visible = false;
            this.details.Lines = new string[0];
            this.details.Location = new System.Drawing.Point(242, 175);
            this.details.MaxLength = 32767;
            this.details.Name = "details";
            this.details.PasswordChar = '\0';
            this.details.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.details.SelectedText = "";
            this.details.SelectionLength = 0;
            this.details.SelectionStart = 0;
            this.details.ShortcutsEnabled = true;
            this.details.Size = new System.Drawing.Size(75, 23);
            this.details.TabIndex = 19;
            this.details.UseSelectable = true;
            this.details.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.details.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(80, 175);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(42, 19);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Detail";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(80, 146);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 21;
            this.metroLabel1.Text = "ScheduleId";
            // 
            // scheduleId
            // 
            // 
            // 
            // 
            this.scheduleId.CustomButton.Image = null;
            this.scheduleId.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.scheduleId.CustomButton.Name = "";
            this.scheduleId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.scheduleId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.scheduleId.CustomButton.TabIndex = 1;
            this.scheduleId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.scheduleId.CustomButton.UseSelectable = true;
            this.scheduleId.CustomButton.Visible = false;
            this.scheduleId.Lines = new string[0];
            this.scheduleId.Location = new System.Drawing.Point(242, 146);
            this.scheduleId.MaxLength = 32767;
            this.scheduleId.Name = "scheduleId";
            this.scheduleId.PasswordChar = '\0';
            this.scheduleId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.scheduleId.SelectedText = "";
            this.scheduleId.SelectionLength = 0;
            this.scheduleId.SelectionStart = 0;
            this.scheduleId.ShortcutsEnabled = true;
            this.scheduleId.Size = new System.Drawing.Size(75, 23);
            this.scheduleId.TabIndex = 22;
            this.scheduleId.UseSelectable = true;
            this.scheduleId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.scheduleId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // projectIdBox
            // 
            this.projectIdBox.FormattingEnabled = true;
            this.projectIdBox.ItemHeight = 23;
            this.projectIdBox.Location = new System.Drawing.Point(242, 111);
            this.projectIdBox.Name = "projectIdBox";
            this.projectIdBox.Size = new System.Drawing.Size(121, 29);
            this.projectIdBox.TabIndex = 23;
            this.projectIdBox.UseSelectable = true;
            // 
            // CashIssuingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 488);
            this.Controls.Add(this.projectIdBox);
            this.Controls.Add(this.scheduleId);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.details);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cashDateTimeTxtBox);
            this.Controls.Add(this.amountTxtBox);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Name = "CashIssuingForm";
            this.Text = "Cash Issuing";
            this.Load += new System.EventHandler(this.CashIssuingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton confirmBtn;
        private MetroFramework.Controls.MetroTextBox amountTxtBox;
        private MetroFramework.Controls.MetroDateTime cashDateTimeTxtBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox details;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox scheduleId;
        private MetroFramework.Controls.MetroComboBox projectIdBox;
    }
}