namespace ResoflexClientHandlingSystem
{
    partial class AddCatagory
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
            this.CatTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.notifySuccessProjectAdding = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // CatTxt
            // 
            // 
            // 
            // 
            this.CatTxt.CustomButton.Image = null;
            this.CatTxt.CustomButton.Location = new System.Drawing.Point(207, 2);
            this.CatTxt.CustomButton.Name = "";
            this.CatTxt.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.CatTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CatTxt.CustomButton.TabIndex = 1;
            this.CatTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CatTxt.CustomButton.UseSelectable = true;
            this.CatTxt.CustomButton.Visible = false;
            this.CatTxt.Lines = new string[0];
            this.CatTxt.Location = new System.Drawing.Point(183, 115);
            this.CatTxt.MaxLength = 32767;
            this.CatTxt.Multiline = true;
            this.CatTxt.Name = "CatTxt";
            this.CatTxt.PasswordChar = '\0';
            this.CatTxt.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.CatTxt.SelectedText = "";
            this.CatTxt.SelectionLength = 0;
            this.CatTxt.SelectionStart = 0;
            this.CatTxt.ShortcutsEnabled = true;
            this.CatTxt.Size = new System.Drawing.Size(237, 32);
            this.CatTxt.TabIndex = 31;
            this.CatTxt.UseSelectable = true;
            this.CatTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CatTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(43, 115);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 20);
            this.metroLabel1.TabIndex = 32;
            this.metroLabel1.Text = "New Catagory";
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroButton1.Location = new System.Drawing.Point(207, 181);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(98, 33);
            this.metroButton1.TabIndex = 33;
            this.metroButton1.Text = "Save";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            this.metroButton1.Enter += new System.EventHandler(this.metroButton1_Click);
            // 
            // notifySuccessProjectAdding
            // 
            this.notifySuccessProjectAdding.Text = "Client Successfully added!";
            this.notifySuccessProjectAdding.Visible = true;
            // 
            // AddCatagory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.CatTxt);
            this.Name = "AddCatagory";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Add Project Catagory";
            this.Load += new System.EventHandler(this.AddCatagory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox CatTxt;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.NotifyIcon notifySuccessProjectAdding;
    }
}