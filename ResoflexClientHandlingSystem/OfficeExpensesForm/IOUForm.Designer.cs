namespace ResoflexClientHandlingSystem.OfficeExpenses
{
    partial class IOUForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.iou = new MetroFramework.Controls.MetroTextBox();
            this.Date = new MetroFramework.Controls.MetroDateTime();
            this.add = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.comment = new MetroFramework.Controls.MetroTextBox();
            this.amt = new MetroFramework.Controls.MetroTextBox();
            this.staffNameBox = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(42, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "IOU No";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(42, 117);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Name";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(51, 181);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(36, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Date";
            // 
            // iou
            // 
            // 
            // 
            // 
            this.iou.CustomButton.Image = null;
            this.iou.CustomButton.Location = new System.Drawing.Point(208, 1);
            this.iou.CustomButton.Name = "";
            this.iou.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.iou.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.iou.CustomButton.TabIndex = 1;
            this.iou.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.iou.CustomButton.UseSelectable = true;
            this.iou.CustomButton.Visible = false;
            this.iou.Lines = new string[0];
            this.iou.Location = new System.Drawing.Point(154, 60);
            this.iou.MaxLength = 32767;
            this.iou.Name = "iou";
            this.iou.PasswordChar = '\0';
            this.iou.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.iou.SelectedText = "";
            this.iou.SelectionLength = 0;
            this.iou.SelectionStart = 0;
            this.iou.ShortcutsEnabled = true;
            this.iou.Size = new System.Drawing.Size(230, 23);
            this.iou.TabIndex = 3;
            this.iou.UseSelectable = true;
            this.iou.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.iou.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(154, 181);
            this.Date.MinimumSize = new System.Drawing.Size(0, 29);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(230, 29);
            this.Date.TabIndex = 5;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.add.Location = new System.Drawing.Point(40, 422);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(100, 32);
            this.add.TabIndex = 9;
            this.add.Text = "Add";
            this.add.UseCustomBackColor = true;
            this.add.UseSelectable = true;
            this.add.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(30, 250);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(68, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Comment";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(40, 329);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(56, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Amount";
            // 
            // comment
            // 
            // 
            // 
            // 
            this.comment.CustomButton.Image = null;
            this.comment.CustomButton.Location = new System.Drawing.Point(208, 1);
            this.comment.CustomButton.Name = "";
            this.comment.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.comment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.comment.CustomButton.TabIndex = 1;
            this.comment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.comment.CustomButton.UseSelectable = true;
            this.comment.CustomButton.Visible = false;
            this.comment.Lines = new string[0];
            this.comment.Location = new System.Drawing.Point(154, 250);
            this.comment.MaxLength = 32767;
            this.comment.Name = "comment";
            this.comment.PasswordChar = '\0';
            this.comment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.comment.SelectedText = "";
            this.comment.SelectionLength = 0;
            this.comment.SelectionStart = 0;
            this.comment.ShortcutsEnabled = true;
            this.comment.Size = new System.Drawing.Size(230, 23);
            this.comment.TabIndex = 12;
            this.comment.UseSelectable = true;
            this.comment.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.comment.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // amt
            // 
            // 
            // 
            // 
            this.amt.CustomButton.Image = null;
            this.amt.CustomButton.Location = new System.Drawing.Point(208, 1);
            this.amt.CustomButton.Name = "";
            this.amt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.amt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.amt.CustomButton.TabIndex = 1;
            this.amt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.amt.CustomButton.UseSelectable = true;
            this.amt.CustomButton.Visible = false;
            this.amt.Lines = new string[0];
            this.amt.Location = new System.Drawing.Point(154, 325);
            this.amt.MaxLength = 32767;
            this.amt.Name = "amt";
            this.amt.PasswordChar = '\0';
            this.amt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.amt.SelectedText = "";
            this.amt.SelectionLength = 0;
            this.amt.SelectionStart = 0;
            this.amt.ShortcutsEnabled = true;
            this.amt.Size = new System.Drawing.Size(230, 23);
            this.amt.TabIndex = 13;
            this.amt.UseSelectable = true;
            this.amt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.amt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // staffNameBox
            // 
            this.staffNameBox.FormattingEnabled = true;
            this.staffNameBox.ItemHeight = 23;
            this.staffNameBox.Location = new System.Drawing.Point(154, 117);
            this.staffNameBox.Name = "staffNameBox";
            this.staffNameBox.Size = new System.Drawing.Size(230, 29);
            this.staffNameBox.TabIndex = 14;
            this.staffNameBox.UseSelectable = true;
            // 
            // IOUForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.staffNameBox);
            this.Controls.Add(this.amt);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.add);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.iou);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "IOUForm";
            this.Text = "IOUForm";
            this.Load += new System.EventHandler(this.IOUForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox iou;
        private MetroFramework.Controls.MetroDateTime Date;
        private MetroFramework.Controls.MetroButton add;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox comment;
        private MetroFramework.Controls.MetroTextBox amt;
        private MetroFramework.Controls.MetroComboBox staffNameBox;
    }
}