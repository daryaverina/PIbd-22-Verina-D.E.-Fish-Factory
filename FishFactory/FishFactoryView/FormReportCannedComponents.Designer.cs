namespace FishFactoryView
{
    partial class FormReportCannedComponents
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ComponentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CannedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComponentColumn,
            this.CannedColumn,
            this.AmountColumn});
            this.dataGridView.Location = new System.Drawing.Point(12, 62);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(776, 386);
            this.dataGridView.TabIndex = 0;
            // 
            // ComponentColumn
            // 
            this.ComponentColumn.HeaderText = "Компонент";
            this.ComponentColumn.MinimumWidth = 6;
            this.ComponentColumn.Name = "ComponentColumn";
            this.ComponentColumn.Width = 125;
            // 
            // CannedColumn
            // 
            this.CannedColumn.HeaderText = "Изделие";
            this.CannedColumn.MinimumWidth = 6;
            this.CannedColumn.Name = "CannedColumn";
            this.CannedColumn.Width = 125;
            // 
            // AmountColumn
            // 
            this.AmountColumn.HeaderText = "Количество";
            this.AmountColumn.MinimumWidth = 6;
            this.AmountColumn.Name = "AmountColumn";
            this.AmountColumn.Width = 125;
            // 
            // FormReportCannedComponents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormReportCannedComponents";
            this.Text = "FormReportCannedComponents";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CannedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
    }
}