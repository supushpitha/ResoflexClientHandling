namespace ResoflexClientHandlingSystem
{
    partial class UpdateClientForm
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
            this.components = new System.ComponentModel.Container();
            this.updateClientBtn = new MetroFramework.Controls.MetroButton();
            this.emailTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.faxTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.officePhoneTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.mobilePhoneTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.clientAddressTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.clientNameTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.notifySuccessClientUpdating = new System.Windows.Forms.NotifyIcon(this.components);
            this.updateClientErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.updateClientCancelBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.updateClientErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // updateClientBtn
            // 
            this.updateClientBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.updateClientBtn.Location = new System.Drawing.Point(81, 327);
            this.updateClientBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateClientBtn.Name = "updateClientBtn";
            this.updateClientBtn.Size = new System.Drawing.Size(126, 32);
            this.updateClientBtn.Style = MetroFramework.MetroColorStyle.Green;
            this.updateClientBtn.TabIndex = 25;
            this.updateClientBtn.Text = "Update Client";
            this.updateClientBtn.UseSelectable = true;
            this.updateClientBtn.UseStyleColors = true;
            this.updateClientBtn.Click += new System.EventHandler(this.updateClientBtn_Click);
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.emailTxtBox.CustomButton.Image = null;
            this.emailTxtBox.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.emailTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailTxtBox.CustomButton.Name = "";
            this.emailTxtBox.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.emailTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailTxtBox.CustomButton.TabIndex = 1;
            this.emailTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emailTxtBox.CustomButton.UseSelectable = true;
            this.emailTxtBox.CustomButton.Visible = false;
            this.emailTxtBox.Lines = new string[0];
            this.emailTxtBox.Location = new System.Drawing.Point(137, 271);
            this.emailTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailTxtBox.MaxLength = 32767;
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.PasswordChar = '\0';
            this.emailTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailTxtBox.SelectedText = "";
            this.emailTxtBox.SelectionLength = 0;
            this.emailTxtBox.SelectionStart = 0;
            this.emailTxtBox.ShortcutsEnabled = true;
            this.emailTxtBox.Size = new System.Drawing.Size(210, 19);
            this.emailTxtBox.TabIndex = 24;
            this.emailTxtBox.UseSelectable = true;
            this.emailTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emailTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.emailTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.emailTxtBox_Validating);
            this.emailTxtBox.Validated += new System.EventHandler(this.emailTxtBox_Validated);
            // 
            // faxTxtBox
            // 
            this.faxTxtBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.faxTxtBox.CustomButton.Image = null;
            this.faxTxtBox.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.faxTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.faxTxtBox.CustomButton.Name = "";
            this.faxTxtBox.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.faxTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.faxTxtBox.CustomButton.TabIndex = 1;
            this.faxTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.faxTxtBox.CustomButton.UseSelectable = true;
            this.faxTxtBox.CustomButton.Visible = false;
            this.faxTxtBox.Lines = new string[0];
            this.faxTxtBox.Location = new System.Drawing.Point(137, 233);
            this.faxTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.faxTxtBox.MaxLength = 32767;
            this.faxTxtBox.Name = "faxTxtBox";
            this.faxTxtBox.PasswordChar = '\0';
            this.faxTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.faxTxtBox.SelectedText = "";
            this.faxTxtBox.SelectionLength = 0;
            this.faxTxtBox.SelectionStart = 0;
            this.faxTxtBox.ShortcutsEnabled = true;
            this.faxTxtBox.Size = new System.Drawing.Size(210, 19);
            this.faxTxtBox.TabIndex = 23;
            this.faxTxtBox.UseSelectable = true;
            this.faxTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.faxTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // officePhoneTxtBox
            // 
            this.officePhoneTxtBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.officePhoneTxtBox.CustomButton.Image = null;
            this.officePhoneTxtBox.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.officePhoneTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.officePhoneTxtBox.CustomButton.Name = "";
            this.officePhoneTxtBox.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.officePhoneTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.officePhoneTxtBox.CustomButton.TabIndex = 1;
            this.officePhoneTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.officePhoneTxtBox.CustomButton.UseSelectable = true;
            this.officePhoneTxtBox.CustomButton.Visible = false;
            this.officePhoneTxtBox.Lines = new string[0];
            this.officePhoneTxtBox.Location = new System.Drawing.Point(137, 195);
            this.officePhoneTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.officePhoneTxtBox.MaxLength = 32767;
            this.officePhoneTxtBox.Name = "officePhoneTxtBox";
            this.officePhoneTxtBox.PasswordChar = '\0';
            this.officePhoneTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.officePhoneTxtBox.SelectedText = "";
            this.officePhoneTxtBox.SelectionLength = 0;
            this.officePhoneTxtBox.SelectionStart = 0;
            this.officePhoneTxtBox.ShortcutsEnabled = true;
            this.officePhoneTxtBox.Size = new System.Drawing.Size(210, 19);
            this.officePhoneTxtBox.TabIndex = 22;
            this.officePhoneTxtBox.UseSelectable = true;
            this.officePhoneTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.officePhoneTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.officePhoneTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.officePhoneTxtBox_Validating);
            this.officePhoneTxtBox.Validated += new System.EventHandler(this.officePhoneTxtBox_Validated);
            // 
            // mobilePhoneTxtBox
            // 
            this.mobilePhoneTxtBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.mobilePhoneTxtBox.CustomButton.Image = null;
            this.mobilePhoneTxtBox.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.mobilePhoneTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mobilePhoneTxtBox.CustomButton.Name = "";
            this.mobilePhoneTxtBox.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.mobilePhoneTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mobilePhoneTxtBox.CustomButton.TabIndex = 1;
            this.mobilePhoneTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mobilePhoneTxtBox.CustomButton.UseSelectable = true;
            this.mobilePhoneTxtBox.CustomButton.Visible = false;
            this.mobilePhoneTxtBox.Lines = new string[0];
            this.mobilePhoneTxtBox.Location = new System.Drawing.Point(137, 154);
            this.mobilePhoneTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mobilePhoneTxtBox.MaxLength = 32767;
            this.mobilePhoneTxtBox.Name = "mobilePhoneTxtBox";
            this.mobilePhoneTxtBox.PasswordChar = '\0';
            this.mobilePhoneTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mobilePhoneTxtBox.SelectedText = "";
            this.mobilePhoneTxtBox.SelectionLength = 0;
            this.mobilePhoneTxtBox.SelectionStart = 0;
            this.mobilePhoneTxtBox.ShortcutsEnabled = true;
            this.mobilePhoneTxtBox.Size = new System.Drawing.Size(210, 19);
            this.mobilePhoneTxtBox.TabIndex = 21;
            this.mobilePhoneTxtBox.UseSelectable = true;
            this.mobilePhoneTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mobilePhoneTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mobilePhoneTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.mobilePhoneTxtBox_Validating);
            this.mobilePhoneTxtBox.Validated += new System.EventHandler(this.mobilePhoneTxtBox_Validated);
            // 
            // clientAddressTxtBox
            // 
            this.clientAddressTxtBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.clientAddressTxtBox.CustomButton.Image = null;
            this.clientAddressTxtBox.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.clientAddressTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clientAddressTxtBox.CustomButton.Name = "";
            this.clientAddressTxtBox.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.clientAddressTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.clientAddressTxtBox.CustomButton.TabIndex = 1;
            this.clientAddressTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.clientAddressTxtBox.CustomButton.UseSelectable = true;
            this.clientAddressTxtBox.CustomButton.Visible = false;
            this.clientAddressTxtBox.Lines = new string[0];
            this.clientAddressTxtBox.Location = new System.Drawing.Point(137, 117);
            this.clientAddressTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clientAddressTxtBox.MaxLength = 32767;
            this.clientAddressTxtBox.Name = "clientAddressTxtBox";
            this.clientAddressTxtBox.PasswordChar = '\0';
            this.clientAddressTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.clientAddressTxtBox.SelectedText = "";
            this.clientAddressTxtBox.SelectionLength = 0;
            this.clientAddressTxtBox.SelectionStart = 0;
            this.clientAddressTxtBox.ShortcutsEnabled = true;
            this.clientAddressTxtBox.Size = new System.Drawing.Size(210, 19);
            this.clientAddressTxtBox.TabIndex = 20;
            this.clientAddressTxtBox.UseSelectable = true;
            this.clientAddressTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.clientAddressTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // clientNameTxtBox
            // 
            this.clientNameTxtBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.clientNameTxtBox.CustomButton.Image = null;
            this.clientNameTxtBox.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.clientNameTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clientNameTxtBox.CustomButton.Name = "";
            this.clientNameTxtBox.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.clientNameTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.clientNameTxtBox.CustomButton.TabIndex = 1;
            this.clientNameTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.clientNameTxtBox.CustomButton.UseSelectable = true;
            this.clientNameTxtBox.CustomButton.Visible = false;
            this.clientNameTxtBox.Lines = new string[0];
            this.clientNameTxtBox.Location = new System.Drawing.Point(137, 84);
            this.clientNameTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clientNameTxtBox.MaxLength = 32767;
            this.clientNameTxtBox.Name = "clientNameTxtBox";
            this.clientNameTxtBox.PasswordChar = '\0';
            this.clientNameTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.clientNameTxtBox.SelectedText = "";
            this.clientNameTxtBox.SelectionLength = 0;
            this.clientNameTxtBox.SelectionStart = 0;
            this.clientNameTxtBox.ShortcutsEnabled = true;
            this.clientNameTxtBox.Size = new System.Drawing.Size(210, 19);
            this.clientNameTxtBox.TabIndex = 19;
            this.clientNameTxtBox.UseSelectable = true;
            this.clientNameTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.clientNameTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.White;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(16, 274);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(45, 19);
            this.metroLabel6.TabIndex = 18;
            this.metroLabel6.Text = "Email";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.White;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(16, 236);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(32, 19);
            this.metroLabel5.TabIndex = 17;
            this.metroLabel5.Text = "Fax";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.White;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(16, 198);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(95, 19);
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "Office Phone";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.White;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(16, 157);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(102, 19);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Mobile Phone";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.White;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(16, 120);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Address";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.White;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(16, 87);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(91, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Client Name";
            // 
            // notifySuccessClientUpdating
            // 
            this.notifySuccessClientUpdating.Text = "Client successfully updated!";
            this.notifySuccessClientUpdating.Visible = true;
            // 
            // updateClientErrorProvider
            // 
            this.updateClientErrorProvider.ContainerControl = this;
            // 
            // updateClientCancelBtn
            // 
            this.updateClientCancelBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.updateClientCancelBtn.Location = new System.Drawing.Point(221, 327);
            this.updateClientCancelBtn.Name = "updateClientCancelBtn";
            this.updateClientCancelBtn.Size = new System.Drawing.Size(126, 32);
            this.updateClientCancelBtn.Style = MetroFramework.MetroColorStyle.Red;
            this.updateClientCancelBtn.TabIndex = 26;
            this.updateClientCancelBtn.Text = "Cancel";
            this.updateClientCancelBtn.UseSelectable = true;
            this.updateClientCancelBtn.UseStyleColors = true;
            this.updateClientCancelBtn.Click += new System.EventHandler(this.updateClientCancelBtn_Click);
            // 
            // UpdateClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 388);
            this.Controls.Add(this.updateClientCancelBtn);
            this.Controls.Add(this.updateClientBtn);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.faxTxtBox);
            this.Controls.Add(this.officePhoneTxtBox);
            this.Controls.Add(this.mobilePhoneTxtBox);
            this.Controls.Add(this.clientAddressTxtBox);
            this.Controls.Add(this.clientNameTxtBox);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(382, 388);
            this.Name = "UpdateClientForm";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Update Client";
            this.Load += new System.EventHandler(this.UpdateClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updateClientErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton updateClientBtn;
        private MetroFramework.Controls.MetroTextBox emailTxtBox;
        private MetroFramework.Controls.MetroTextBox faxTxtBox;
        private MetroFramework.Controls.MetroTextBox officePhoneTxtBox;
        private MetroFramework.Controls.MetroTextBox mobilePhoneTxtBox;
        private MetroFramework.Controls.MetroTextBox clientAddressTxtBox;
        private MetroFramework.Controls.MetroTextBox clientNameTxtBox;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.NotifyIcon notifySuccessClientUpdating;
        private System.Windows.Forms.ErrorProvider updateClientErrorProvider;
        private MetroFramework.Controls.MetroButton updateClientCancelBtn;
    }
}