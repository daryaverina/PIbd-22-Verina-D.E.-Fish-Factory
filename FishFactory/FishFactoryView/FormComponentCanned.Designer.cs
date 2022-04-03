namespace FishFactoryView
{
    partial class FormComponentCanned
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
            this.button_SaveToExcel = new System.Windows.Forms.Button();
            this.dataGridViewComponents = new System.Windows.Forms.DataGridView();
            this.ComponentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CannedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComponents)).BeginInit();
            this.SuspendLayout();
            // 
            // button_SaveToExcel
            // 
            this.button_SaveToExcel.Location = new System.Drawing.Point(61, 9);
            this.button_SaveToExcel.Name = "button_SaveToExcel";
            this.button_SaveToExcel.Size = new System.Drawing.Size(188, 29);
            this.button_SaveToExcel.TabIndex = 0;
            this.button_SaveToExcel.Text = "Сохранить в Excel";
            this.button_SaveToExcel.UseVisualStyleBackColor = true;
            this.button_SaveToExcel.Click += new System.EventHandler(this.button_SaveToExcel_Click);
            // 
            // dataGridViewComponents
            // 
            this.dataGridViewComponents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComponents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComponentColumn,
            this.CannedColumn,
            this.AmountColumn});
            this.dataGridViewComponents.Location = new System.Drawing.Point(4, 56);
            this.dataGridViewComponents.Name = "dataGridViewComponents";
            this.dataGridViewComponents.RowHeadersWidth = 51;
            this.dataGridViewComponents.RowTemplate.Height = 29;
            this.dataGridViewComponents.Size = new System.Drawing.Size(793, 382);
            this.dataGridViewComponents.TabIndex = 1;
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
            // FormComponentCanned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewComponents);
            this.Controls.Add(this.button_SaveToExcel);
            this.Name = "FormComponentCanned";
            this.Text = "FormComponentCanned";
            this.Load += new System.EventHandler(this.FormComponentCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComponents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_SaveToExcel;
        private System.Windows.Forms.DataGridView dataGridViewComponents;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CannedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
    }
}