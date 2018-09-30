namespace ResoflexClientHandlingSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.unameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.pwdTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.demo = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(86, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(86, 170);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // unameTextBox
            // 
            this.unameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.unameTextBox.CustomButton.Image = null;
            this.unameTextBox.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.unameTextBox.CustomButton.Name = "";
            this.unameTextBox.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.unameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.unameTextBox.CustomButton.TabIndex = 1;
            this.unameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.unameTextBox.CustomButton.UseSelectable = true;
            this.unameTextBox.CustomButton.Visible = false;
            this.unameTextBox.Lines = new string[0];
            this.unameTextBox.Location = new System.Drawing.Point(132, 103);
            this.unameTextBox.MaxLength = 32767;
            this.unameTextBox.Name = "unameTextBox";
            this.unameTextBox.PasswordChar = '\0';
            this.unameTextBox.PromptText = "Username";
            this.unameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.unameTextBox.SelectedText = "";
            this.unameTextBox.SelectionLength = 0;
            this.unameTextBox.SelectionStart = 0;
            this.unameTextBox.ShortcutsEnabled = true;
            this.unameTextBox.Size = new System.Drawing.Size(212, 31);
            this.unameTextBox.TabIndex = 2;
            this.unameTextBox.UseSelectable = true;
            this.unameTextBox.WaterMark = "Username";
            this.unameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.unameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.unameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.unameTextBox_Validating);
            // 
            // pwdTextBox
            // 
            this.pwdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.pwdTextBox.CustomButton.Image = null;
            this.pwdTextBox.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.pwdTextBox.CustomButton.Name = "";
            this.pwdTextBox.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.pwdTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pwdTextBox.CustomButton.TabIndex = 1;
            this.pwdTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pwdTextBox.CustomButton.UseSelectable = true;
            this.pwdTextBox.CustomButton.Visible = false;
            this.pwdTextBox.Lines = new string[0];
            this.pwdTextBox.Location = new System.Drawing.Point(132, 179);
            this.pwdTextBox.MaxLength = 32767;
            this.pwdTextBox.Name = "pwdTextBox";
            this.pwdTextBox.PasswordChar = '*';
            this.pwdTextBox.PromptText = "Password";
            this.pwdTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pwdTextBox.SelectedText = "";
            this.pwdTextBox.SelectionLength = 0;
            this.pwdTextBox.SelectionStart = 0;
            this.pwdTextBox.ShortcutsEnabled = true;
            this.pwdTextBox.Size = new System.Drawing.Size(212, 31);
            this.pwdTextBox.TabIndex = 3;
            this.pwdTextBox.UseSelectable = true;
            this.pwdTextBox.WaterMark = "Password";
            this.pwdTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pwdTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.pwdTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pwdTextBox_KeyDown);
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.Location = new System.Drawing.Point(167, 234);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(108, 31);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Login";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLink1.Location = new System.Drawing.Point(167, 287);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(121, 23);
            this.metroLink1.TabIndex = 5;
            this.metroLink1.Text = "Forgot password?";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // demo
            // 
            this.demo.Location = new System.Drawing.Point(369, 320);
            this.demo.Name = "demo";
            this.demo.Size = new System.Drawing.Size(58, 25);
            this.demo.TabIndex = 6;
            this.demo.Text = "Demo";
            this.demo.UseSelectable = true;
            this.demo.Click += new System.EventHandler(this.demo_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.demo);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.pwdTextBox);
            this.Controls.Add(this.unameTextBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(450, 350);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTextBox unameTextBox;
        private MetroFramework.Controls.MetroTextBox pwdTextBox;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroButton demo;
    }
}