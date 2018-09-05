namespace ResoflexClientHandlingSystem
{
    partial class ProjectExpensesMainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.viewEventBtn = new MetroFramework.Controls.MetroButton();
            this.viewIouBtn = new MetroFramework.Controls.MetroButton();
            this.getReportBtn = new MetroFramework.Controls.MetroButton();
            this.viewBalanceBtn = new MetroFramework.Controls.MetroButton();
            this.projExpMonthTile = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.balTile = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.MaxSpentEventTile = new MetroFramework.Controls.MetroTile();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.monthCompProgressSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.progLbl = new MetroFramework.Controls.MetroLabel();
            this.projExpMonthTile.SuspendLayout();
            this.balTile.SuspendLayout();
            this.MaxSpentEventTile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // viewEventBtn
            // 
            this.viewEventBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.viewEventBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.viewEventBtn.Location = new System.Drawing.Point(821, 435);
            this.viewEventBtn.Name = "viewEventBtn";
            this.viewEventBtn.Size = new System.Drawing.Size(246, 45);
            this.viewEventBtn.TabIndex = 9;
            this.viewEventBtn.Text = "View Event Expenses";
            this.viewEventBtn.UseCustomBackColor = true;
            this.viewEventBtn.UseSelectable = true;
            this.viewEventBtn.Click += new System.EventHandler(this.viewEventBtn_Click);
            // 
            // viewIouBtn
            // 
            this.viewIouBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.viewIouBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.viewIouBtn.Location = new System.Drawing.Point(821, 500);
            this.viewIouBtn.Name = "viewIouBtn";
            this.viewIouBtn.Size = new System.Drawing.Size(246, 45);
            this.viewIouBtn.TabIndex = 11;
            this.viewIouBtn.Text = "View IOU Expenses";
            this.viewIouBtn.UseCustomBackColor = true;
            this.viewIouBtn.UseSelectable = true;
            this.viewIouBtn.Click += new System.EventHandler(this.viewIouBtn_Click);
            // 
            // getReportBtn
            // 
            this.getReportBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.getReportBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.getReportBtn.Location = new System.Drawing.Point(821, 565);
            this.getReportBtn.Name = "getReportBtn";
            this.getReportBtn.Size = new System.Drawing.Size(246, 45);
            this.getReportBtn.TabIndex = 14;
            this.getReportBtn.Text = "Get Reports";
            this.getReportBtn.UseCustomBackColor = true;
            this.getReportBtn.UseSelectable = true;
            this.getReportBtn.Click += new System.EventHandler(this.getReportBtn_Click);
            // 
            // viewBalanceBtn
            // 
            this.viewBalanceBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.viewBalanceBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.viewBalanceBtn.Location = new System.Drawing.Point(821, 630);
            this.viewBalanceBtn.Name = "viewBalanceBtn";
            this.viewBalanceBtn.Size = new System.Drawing.Size(246, 45);
            this.viewBalanceBtn.TabIndex = 15;
            this.viewBalanceBtn.Text = "Balance";
            this.viewBalanceBtn.UseCustomBackColor = true;
            this.viewBalanceBtn.UseSelectable = true;
            this.viewBalanceBtn.Click += new System.EventHandler(this.viewBalanceBtn_Click);
            // 
            // projExpMonthTile
            // 
            this.projExpMonthTile.ActiveControl = null;
            this.projExpMonthTile.Controls.Add(this.metroLabel1);
            this.projExpMonthTile.Location = new System.Drawing.Point(24, 75);
            this.projExpMonthTile.Name = "projExpMonthTile";
            this.projExpMonthTile.Size = new System.Drawing.Size(212, 127);
            this.projExpMonthTile.TabIndex = 16;
            this.projExpMonthTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.projExpMonthTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.projExpMonthTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.projExpMonthTile.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(4, 105);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(165, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Proj. Exp. of this Month";
            // 
            // balTile
            // 
            this.balTile.ActiveControl = null;
            this.balTile.Controls.Add(this.metroLabel2);
            this.balTile.Location = new System.Drawing.Point(296, 75);
            this.balTile.Name = "balTile";
            this.balTile.Size = new System.Drawing.Size(212, 127);
            this.balTile.TabIndex = 17;
            this.balTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.balTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.balTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.balTile.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(3, 105);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Balance";
            // 
            // MaxSpentEventTile
            // 
            this.MaxSpentEventTile.ActiveControl = null;
            this.MaxSpentEventTile.Controls.Add(this.metroLabel3);
            this.MaxSpentEventTile.Location = new System.Drawing.Point(568, 75);
            this.MaxSpentEventTile.Name = "MaxSpentEventTile";
            this.MaxSpentEventTile.Size = new System.Drawing.Size(212, 127);
            this.MaxSpentEventTile.TabIndex = 18;
            this.MaxSpentEventTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MaxSpentEventTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.MaxSpentEventTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.MaxSpentEventTile.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(3, 105);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(120, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Max Spent Event";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(24, 280);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "EventExpenseSeries";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(756, 394);
            this.chart1.TabIndex = 19;
            this.chart1.Text = "chart1";
            // 
            // monthCompProgressSpinner
            // 
            this.monthCompProgressSpinner.Location = new System.Drawing.Point(892, 75);
            this.monthCompProgressSpinner.Maximum = 100;
            this.monthCompProgressSpinner.Name = "monthCompProgressSpinner";
            this.monthCompProgressSpinner.Size = new System.Drawing.Size(175, 175);
            this.monthCompProgressSpinner.Spinning = false;
            this.monthCompProgressSpinner.Style = MetroFramework.MetroColorStyle.Green;
            this.monthCompProgressSpinner.TabIndex = 20;
            this.monthCompProgressSpinner.UseSelectable = true;
            this.monthCompProgressSpinner.UseStyleColors = true;
            this.monthCompProgressSpinner.Value = 75;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(890, 253);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(177, 19);
            this.metroLabel4.TabIndex = 21;
            this.metroLabel4.Text = "Last Month vs This Month";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progLbl
            // 
            this.progLbl.AutoSize = true;
            this.progLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.progLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.progLbl.Location = new System.Drawing.Point(957, 151);
            this.progLbl.Name = "progLbl";
            this.progLbl.Size = new System.Drawing.Size(48, 25);
            this.progLbl.TabIndex = 22;
            this.progLbl.Text = "75%";
            // 
            // ProjectExpensesMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 700);
            this.Controls.Add(this.progLbl);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.monthCompProgressSpinner);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.MaxSpentEventTile);
            this.Controls.Add(this.balTile);
            this.Controls.Add(this.projExpMonthTile);
            this.Controls.Add(this.viewBalanceBtn);
            this.Controls.Add(this.getReportBtn);
            this.Controls.Add(this.viewIouBtn);
            this.Controls.Add(this.viewEventBtn);
            this.MinimumSize = new System.Drawing.Size(1080, 700);
            this.Name = "ProjectExpensesMainForm";
            this.Text = "Project Expenses";
            this.Load += new System.EventHandler(this.ProjectExpensesMainForm_Load);
            this.Shown += new System.EventHandler(this.ProjectExpensesMainForm_Shown);
            this.projExpMonthTile.ResumeLayout(false);
            this.projExpMonthTile.PerformLayout();
            this.balTile.ResumeLayout(false);
            this.balTile.PerformLayout();
            this.MaxSpentEventTile.ResumeLayout(false);
            this.MaxSpentEventTile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton viewEventBtn;
        private MetroFramework.Controls.MetroButton viewIouBtn;
        private MetroFramework.Controls.MetroButton getReportBtn;
        private MetroFramework.Controls.MetroButton viewBalanceBtn;
        private MetroFramework.Controls.MetroTile projExpMonthTile;
        private MetroFramework.Controls.MetroTile balTile;
        private MetroFramework.Controls.MetroTile MaxSpentEventTile;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroProgressSpinner monthCompProgressSpinner;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel progLbl;
    }
}