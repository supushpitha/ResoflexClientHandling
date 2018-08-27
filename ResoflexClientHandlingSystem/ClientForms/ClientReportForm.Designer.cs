namespace ResoflexClientHandlingSystem.ClientForms
{
    partial class ClientReportForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.verticalLineLbl = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.searchClientCmbBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(24, 226);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(828, 471);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // verticalLineLbl
            // 
            this.verticalLineLbl.AutoSize = true;
            this.verticalLineLbl.Location = new System.Drawing.Point(888, 60);
            this.verticalLineLbl.Name = "verticalLineLbl";
            this.verticalLineLbl.Size = new System.Drawing.Size(0, 0);
            this.verticalLineLbl.TabIndex = 1;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.metroButton1.Location = new System.Drawing.Point(1007, 127);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(204, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Client-Events-Expenses Report";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.metroButton2.Location = new System.Drawing.Point(1008, 169);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(203, 23);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "Full Report on Clients";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            // 
            // searchClientCmbBox
            // 
            this.searchClientCmbBox.FormattingEnabled = true;
            this.searchClientCmbBox.ItemHeight = 23;
            this.searchClientCmbBox.Location = new System.Drawing.Point(259, 127);
            this.searchClientCmbBox.Name = "searchClientCmbBox";
            this.searchClientCmbBox.PromptText = "Client names";
            this.searchClientCmbBox.Size = new System.Drawing.Size(279, 29);
            this.searchClientCmbBox.TabIndex = 4;
            this.searchClientCmbBox.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(138, 127);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(115, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Select a Client : ";
            // 
            // ClientReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.searchClientCmbBox);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.verticalLineLbl);
            this.Controls.Add(this.chart1);
            this.Name = "ClientReportForm";
            this.Text = "Client Reports";
            this.Load += new System.EventHandler(this.ClientReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroLabel verticalLineLbl;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroComboBox searchClientCmbBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}