namespace ResoflexClientHandlingSystem
{
    partial class EmployeeTaskTimeComparisonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeTaskTimeComparisonForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SelectMemComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.veiwGridBtn = new MetroFramework.Controls.MetroButton();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel4 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel5 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.homeBtn = new MetroFramework.Controls.MetroButton();
            this.comparisonChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.htmlLabel1.SuspendLayout();
            this.htmlLabel2.SuspendLayout();
            this.htmlLabel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comparisonChart)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectMemComboBox
            // 
            this.SelectMemComboBox.FormattingEnabled = true;
            this.SelectMemComboBox.ItemHeight = 23;
            this.SelectMemComboBox.Location = new System.Drawing.Point(86, 0);
            this.SelectMemComboBox.Name = "SelectMemComboBox";
            this.SelectMemComboBox.Size = new System.Drawing.Size(182, 29);
            this.SelectMemComboBox.TabIndex = 0;
            this.SelectMemComboBox.UseSelectable = true;
            this.SelectMemComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectMemComboBox_SelectedIndexChanged);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(90, 0);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(286, 29);
            this.metroComboBox1.TabIndex = 1;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(90, 3);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(286, 29);
            this.metroComboBox2.TabIndex = 2;
            this.metroComboBox2.UseSelectable = true;
            this.metroComboBox2.SelectedIndexChanged += new System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
            // 
            // veiwGridBtn
            // 
            this.veiwGridBtn.Location = new System.Drawing.Point(588, 254);
            this.veiwGridBtn.Name = "veiwGridBtn";
            this.veiwGridBtn.Size = new System.Drawing.Size(119, 47);
            this.veiwGridBtn.TabIndex = 4;
            this.veiwGridBtn.Text = "View Report";
            this.veiwGridBtn.UseSelectable = true;
            this.veiwGridBtn.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(75, 23);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Controls.Add(this.SelectMemComboBox);
            this.htmlLabel1.Location = new System.Drawing.Point(39, 78);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(272, 34);
            this.htmlLabel1.TabIndex = 5;
            this.htmlLabel1.Text = "Staff Member";
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(69, 23);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Controls.Add(this.metroComboBox1);
            this.htmlLabel2.Location = new System.Drawing.Point(434, 58);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(384, 34);
            this.htmlLabel2.TabIndex = 6;
            this.htmlLabel2.Text = "Project task";
            // 
            // htmlLabel4
            // 
            this.htmlLabel4.AutoScroll = true;
            this.htmlLabel4.AutoScrollMinSize = new System.Drawing.Size(64, 23);
            this.htmlLabel4.AutoSize = false;
            this.htmlLabel4.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel4.Location = new System.Drawing.Point(-15, -15);
            this.htmlLabel4.Name = "htmlLabel4";
            this.htmlLabel4.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel4.TabIndex = 8;
            this.htmlLabel4.Text = "htmlLabel4";
            // 
            // htmlLabel5
            // 
            this.htmlLabel5.AutoScroll = true;
            this.htmlLabel5.AutoScrollMinSize = new System.Drawing.Size(62, 23);
            this.htmlLabel5.AutoSize = false;
            this.htmlLabel5.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel5.Controls.Add(this.metroComboBox2);
            this.htmlLabel5.Location = new System.Drawing.Point(434, 98);
            this.htmlLabel5.Name = "htmlLabel5";
            this.htmlLabel5.Size = new System.Drawing.Size(376, 39);
            this.htmlLabel5.TabIndex = 2;
            this.htmlLabel5.Text = "Event date";
            this.htmlLabel5.Click += new System.EventHandler(this.htmlLabel5_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.homeBtn.BackColor = System.Drawing.Color.Transparent;
            this.homeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeBtn.BackgroundImage")));
            this.homeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeBtn.Location = new System.Drawing.Point(408, 6);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(30, 24);
            this.homeBtn.TabIndex = 17;
            this.homeBtn.UseSelectable = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // comparisonChart
            // 
            this.comparisonChart.BackColor = System.Drawing.Color.LightSteelBlue;
            this.comparisonChart.BorderlineColor = System.Drawing.Color.LightSteelBlue;
            chartArea1.Name = "ChartArea1";
            this.comparisonChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.comparisonChart.Legends.Add(legend1);
            this.comparisonChart.Location = new System.Drawing.Point(80, 158);
            this.comparisonChart.Name = "comparisonChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Expected time";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Committed time";
            this.comparisonChart.Series.Add(series1);
            this.comparisonChart.Series.Add(series2);
            this.comparisonChart.Size = new System.Drawing.Size(652, 337);
            this.comparisonChart.TabIndex = 3;
            this.comparisonChart.Text = "Task Chart";
            this.comparisonChart.Click += new System.EventHandler(this.comparisonChart_Click);
            // 
            // EmployeeTaskTimeComparisonForm
            // 
            this.ClientSize = new System.Drawing.Size(841, 528);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.htmlLabel5);
            this.Controls.Add(this.htmlLabel4);
            this.Controls.Add(this.htmlLabel2);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.veiwGridBtn);
            this.Controls.Add(this.comparisonChart);
            this.Name = "EmployeeTaskTimeComparisonForm";
            this.Text = "Task Time Comparison";
            this.htmlLabel1.ResumeLayout(false);
            this.htmlLabel2.ResumeLayout(false);
            this.htmlLabel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comparisonChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid ResGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn resID;
        private System.Windows.Forms.DataGridViewTextBoxColumn resName;
        private System.Windows.Forms.DataGridViewTextBoxColumn resValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn resQty;
        private MetroFramework.Controls.MetroComboBox SelectMemComboBox;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroButton veiwGridBtn;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel4;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel5;
        private MetroFramework.Controls.MetroButton homeBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart comparisonChart;
    }
}