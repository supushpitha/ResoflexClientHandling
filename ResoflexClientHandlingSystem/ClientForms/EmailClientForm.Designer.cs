namespace ResoflexClientHandlingSystem.ClientForms
{
    partial class EmailClientForm
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
            this.mailSubjectTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.emailTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.messageTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.sendBtn = new MetroFramework.Controls.MetroButton();
            this.notifySendSuccess = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // mailSubjectTxtBox
            // 
            // 
            // 
            // 
            this.mailSubjectTxtBox.CustomButton.Image = null;
            this.mailSubjectTxtBox.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.mailSubjectTxtBox.CustomButton.Name = "";
            this.mailSubjectTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mailSubjectTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mailSubjectTxtBox.CustomButton.TabIndex = 1;
            this.mailSubjectTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mailSubjectTxtBox.CustomButton.UseSelectable = true;
            this.mailSubjectTxtBox.CustomButton.Visible = false;
            this.mailSubjectTxtBox.Lines = new string[0];
            this.mailSubjectTxtBox.Location = new System.Drawing.Point(123, 126);
            this.mailSubjectTxtBox.MaxLength = 32767;
            this.mailSubjectTxtBox.Name = "mailSubjectTxtBox";
            this.mailSubjectTxtBox.PasswordChar = '\0';
            this.mailSubjectTxtBox.PromptText = "subject";
            this.mailSubjectTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mailSubjectTxtBox.SelectedText = "";
            this.mailSubjectTxtBox.SelectionLength = 0;
            this.mailSubjectTxtBox.SelectionStart = 0;
            this.mailSubjectTxtBox.ShortcutsEnabled = true;
            this.mailSubjectTxtBox.Size = new System.Drawing.Size(261, 23);
            this.mailSubjectTxtBox.TabIndex = 0;
            this.mailSubjectTxtBox.UseSelectable = true;
            this.mailSubjectTxtBox.WaterMark = "subject";
            this.mailSubjectTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mailSubjectTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // emailTxtBox
            // 
            // 
            // 
            // 
            this.emailTxtBox.CustomButton.Image = null;
            this.emailTxtBox.CustomButton.Location = new System.Drawing.Point(238, 1);
            this.emailTxtBox.CustomButton.Name = "";
            this.emailTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.emailTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailTxtBox.CustomButton.TabIndex = 1;
            this.emailTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emailTxtBox.CustomButton.UseSelectable = true;
            this.emailTxtBox.CustomButton.Visible = false;
            this.emailTxtBox.Lines = new string[0];
            this.emailTxtBox.Location = new System.Drawing.Point(123, 74);
            this.emailTxtBox.MaxLength = 32767;
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.PasswordChar = '\0';
            this.emailTxtBox.ReadOnly = true;
            this.emailTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailTxtBox.SelectedText = "";
            this.emailTxtBox.SelectionLength = 0;
            this.emailTxtBox.SelectionStart = 0;
            this.emailTxtBox.ShortcutsEnabled = true;
            this.emailTxtBox.Size = new System.Drawing.Size(260, 23);
            this.emailTxtBox.TabIndex = 1;
            this.emailTxtBox.UseSelectable = true;
            this.emailTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emailTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(25, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "To";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(23, 128);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 20);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Subject";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(23, 192);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 20);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Message";
            // 
            // messageTxtBox
            // 
            // 
            // 
            // 
            this.messageTxtBox.CustomButton.Image = null;
            this.messageTxtBox.CustomButton.Location = new System.Drawing.Point(365, 1);
            this.messageTxtBox.CustomButton.Name = "";
            this.messageTxtBox.CustomButton.Size = new System.Drawing.Size(165, 165);
            this.messageTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.messageTxtBox.CustomButton.TabIndex = 1;
            this.messageTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.messageTxtBox.CustomButton.UseSelectable = true;
            this.messageTxtBox.CustomButton.Visible = false;
            this.messageTxtBox.Lines = new string[0];
            this.messageTxtBox.Location = new System.Drawing.Point(123, 192);
            this.messageTxtBox.MaxLength = 32767;
            this.messageTxtBox.Multiline = true;
            this.messageTxtBox.Name = "messageTxtBox";
            this.messageTxtBox.PasswordChar = '\0';
            this.messageTxtBox.PromptText = "Message";
            this.messageTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.messageTxtBox.SelectedText = "";
            this.messageTxtBox.SelectionLength = 0;
            this.messageTxtBox.SelectionStart = 0;
            this.messageTxtBox.ShortcutsEnabled = true;
            this.messageTxtBox.Size = new System.Drawing.Size(531, 167);
            this.messageTxtBox.TabIndex = 5;
            this.messageTxtBox.UseSelectable = true;
            this.messageTxtBox.WaterMark = "Message";
            this.messageTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.messageTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // sendBtn
            // 
            this.sendBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.sendBtn.Location = new System.Drawing.Point(539, 365);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(115, 36);
            this.sendBtn.TabIndex = 6;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseSelectable = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // notifySendSuccess
            // 
            this.notifySendSuccess.Text = "Email sent successfully!";
            this.notifySendSuccess.Visible = true;
            // 
            // EmailClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.messageTxtBox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.mailSubjectTxtBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmailClientForm";
            this.Text = "Email Client Form";
            this.Load += new System.EventHandler(this.EmailClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox mailSubjectTxtBox;
        private MetroFramework.Controls.MetroTextBox emailTxtBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox messageTxtBox;
        private MetroFramework.Controls.MetroButton sendBtn;
        private System.Windows.Forms.NotifyIcon notifySendSuccess;
    }
}