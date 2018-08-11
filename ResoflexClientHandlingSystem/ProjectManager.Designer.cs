namespace ResoflexClientHandlingSystem
{
    partial class ProjectManager
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
            this.home = new MetroFramework.Controls.MetroPanel();
            this.projectBtn = new MetroFramework.Controls.MetroButton();
            this.scheduleBtn = new MetroFramework.Controls.MetroButton();
            this.eventBtn = new MetroFramework.Controls.MetroButton();
            this.home.SuspendLayout();
            this.SuspendLayout();
            //
            // home
            // 
            this.home.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.home.Controls.Add(this.projectBtn);
            this.home.Controls.Add(this.scheduleBtn);
            this.home.Controls.Add(this.eventBtn);
            this.home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home.HorizontalScrollbarBarColor = true;
            this.home.HorizontalScrollbarHighlightOnWheel = false;
            this.home.HorizontalScrollbarSize = 10;
            this.home.Location = new System.Drawing.Point(20, 60);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(760, 520);
            this.home.TabIndex = 0;
            this.home.VerticalScrollbarBarColor = true;
            this.home.VerticalScrollbarHighlightOnWheel = false;
            this.home.VerticalScrollbarSize = 10;
            //
            // projectBtn
            //
            this.projectBtn.Location = new System.Drawing.Point(3, 3);
            this.projectBtn.Name = "projectBtn";
            this.projectBtn.Size = new System.Drawing.Size(75, 23);
            this.projectBtn.TabIndex = 2;
            this.projectBtn.Text = "Projects";
            this.projectBtn.UseSelectable = true;
            //
            // scheduleBtn
            //
            this.scheduleBtn.Location = new System.Drawing.Point(84, 3);
            this.scheduleBtn.Name = "scheduleBtn";
            this.scheduleBtn.Size = new System.Drawing.Size(75, 23);
            this.scheduleBtn.TabIndex = 3;
            this.scheduleBtn.Text = "Schedules";
            this.scheduleBtn.UseSelectable = true;
            this.scheduleBtn.Click += new System.EventHandler(this.scheduleBtn_Click);
            //
            // eventBtn
            //
            this.eventBtn.Location = new System.Drawing.Point(165, 3);
            this.eventBtn.Name = "eventBtn";
            this.eventBtn.Size = new System.Drawing.Size(75, 23);
            this.eventBtn.TabIndex = 4;
            this.eventBtn.Text = "Events";
            this.eventBtn.UseSelectable = true;
            this.eventBtn.Click += new System.EventHandler(this.eventBtn_Click);
            //
            // ProjectManager
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.home);
            this.Name = "ProjectManager";
            this.Text = "Project Manager";
            this.Load += new System.EventHandler(this.ProjectManager_Load);
            this.home.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel home;
        private MetroFramework.Controls.MetroButton eventBtn;
        private MetroFramework.Controls.MetroButton scheduleBtn;
        private MetroFramework.Controls.MetroButton projectBtn;
    }
}
