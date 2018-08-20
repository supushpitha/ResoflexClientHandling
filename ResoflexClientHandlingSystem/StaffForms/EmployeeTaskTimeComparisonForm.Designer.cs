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
            this.SuspendLayout();
            // 
            // EmployeeTaskTimeComparisonForm
            // 
            this.ClientSize = new System.Drawing.Size(841, 528);
            this.Name = "EmployeeTaskTimeComparisonForm";
            this.Text = "Employee Task Time Comparison";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid ResGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn resID;
        private System.Windows.Forms.DataGridViewTextBoxColumn resName;
        private System.Windows.Forms.DataGridViewTextBoxColumn resValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn resQty;
    }
}