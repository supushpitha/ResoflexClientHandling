namespace ResoflexClientHandlingSystem.UserForms
{
    partial class ForgotPassword
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.email = new MetroFramework.Controls.MetroTextBox();
            this.emailerrorprovider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.emailerrorprovider)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(34, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(460, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Enter your email address to request for a password reset";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(398, 140);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(107, 46);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Reset Password";
            this.metroButton1.UseSelectable = true;
            // 
            // email
            // 
            // 
            // 
            // 
            this.email.CustomButton.Image = null;
            this.email.CustomButton.Location = new System.Drawing.Point(281, 2);
            this.email.CustomButton.Name = "";
            this.email.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.email.CustomButton.TabIndex = 1;
            this.email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.email.CustomButton.UseSelectable = true;
            this.email.CustomButton.Visible = false;
            this.email.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.email.Lines = new string[0];
            this.email.Location = new System.Drawing.Point(56, 140);
            this.email.MaxLength = 32767;
            this.email.Name = "email";
            this.email.PasswordChar = '\0';
            this.email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.email.SelectedText = "";
            this.email.SelectionLength = 0;
            this.email.SelectionStart = 0;
            this.email.ShortcutsEnabled = true;
            this.email.Size = new System.Drawing.Size(325, 46);
            this.email.TabIndex = 2;
            this.email.UseSelectable = true;
            this.email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.email.Validating += new System.ComponentModel.CancelEventHandler(this.email_Validating);
            this.email.Validated += new System.EventHandler(this.email_Validated);
            // 
            // emailerrorprovider
            // 
            this.emailerrorprovider.ContainerControl = this;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 279);
            this.Controls.Add(this.email);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel1);
            this.MaximumSize = new System.Drawing.Size(554, 279);
            this.MinimumSize = new System.Drawing.Size(554, 279);
            this.Name = "ForgotPassword";
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emailerrorprovider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox email;
        private System.Windows.Forms.ErrorProvider emailerrorprovider;
    }
}