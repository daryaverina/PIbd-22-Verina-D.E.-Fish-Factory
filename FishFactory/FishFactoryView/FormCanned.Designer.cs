
namespace FishFactoryView
{
    partial class FormCanned
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
            this.Components_dataGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComonentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_label = new System.Windows.Forms.Label();
            this.Name_label = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Price_textBox = new System.Windows.Forms.TextBox();
            this.Components_groupBox = new System.Windows.Forms.GroupBox();
            this.Update_button = new System.Windows.Forms.Button();
            this.Change_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Components_dataGridView)).BeginInit();
            this.Components_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Components_dataGridView
            // 
            this.Components_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Components_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.ComonentName,
            this.AmountColumn});
            this.Components_dataGridView.Location = new System.Drawing.Point(6, 22);
            this.Components_dataGridView.Name = "Components_dataGridView";
            this.Components_dataGridView.RowTemplate.Height = 25;
            this.Components_dataGridView.Size = new System.Drawing.Size(378, 325);
            this.Components_dataGridView.TabIndex = 0;
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.Visible = false;
            // 
            // ComonentName
            // 
            this.ComonentName.HeaderText = "Компонент";
            this.ComonentName.Name = "ComonentName";
            // 
            // AmountColumn
            // 
            this.AmountColumn.HeaderText = "Количество";
            this.AmountColumn.Name = "AmountColumn";
            // 
            // Price_label
            // 
            this.Price_label.AutoSize = true;
            this.Price_label.Location = new System.Drawing.Point(32, 48);
            this.Price_label.Name = "Price_label";
            this.Price_label.Size = new System.Drawing.Size(38, 15);
            this.Price_label.TabIndex = 2;
            this.Price_label.Text = "Цена:";
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Location = new System.Drawing.Point(32, 13);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(62, 15);
            this.Name_label.TabIndex = 3;
            this.Name_label.Text = "Название:";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(112, 12);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(150, 23);
            this.Name_textBox.TabIndex = 4;
            // 
            // Price_textBox
            // 
            this.Price_textBox.Location = new System.Drawing.Point(112, 48);
            this.Price_textBox.Name = "Price_textBox";
            this.Price_textBox.Size = new System.Drawing.Size(150, 23);
            this.Price_textBox.TabIndex = 5;
            // 
            // Components_groupBox
            // 
            this.Components_groupBox.Controls.Add(this.Update_button);
            this.Components_groupBox.Controls.Add(this.Change_button);
            this.Components_groupBox.Controls.Add(this.Add_button);
            this.Components_groupBox.Controls.Add(this.Delete_button);
            this.Components_groupBox.Controls.Add(this.Components_dataGridView);
            this.Components_groupBox.Location = new System.Drawing.Point(32, 101);
            this.Components_groupBox.Name = "Components_groupBox";
            this.Components_groupBox.Size = new System.Drawing.Size(579, 353);
            this.Components_groupBox.TabIndex = 6;
            this.Components_groupBox.TabStop = false;
            this.Components_groupBox.Text = "Компоненты";
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(444, 179);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(101, 35);
            this.Update_button.TabIndex = 4;
            this.Update_button.Text = "Обновить";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.ButtonRef_Click);
            // 
            // Change_button
            // 
            this.Change_button.Location = new System.Drawing.Point(444, 74);
            this.Change_button.Name = "Change_button";
            this.Change_button.Size = new System.Drawing.Size(101, 35);
            this.Change_button.TabIndex = 2;
            this.Change_button.Text = "Изменить";
            this.Change_button.UseVisualStyleBackColor = true;
            this.Change_button.Click += new System.EventHandler(this.ButtonUpd_Click);
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(444, 22);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(101, 35);
            this.Add_button.TabIndex = 1;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(444, 125);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(101, 35);
            this.Delete_button.TabIndex = 3;
            this.Delete_button.Text = "Удалить";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(368, 478);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(102, 32);
            this.Save_button.TabIndex = 7;
            this.Save_button.Text = "Сохранить";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(509, 478);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(102, 32);
            this.Cancel_button.TabIndex = 8;
            this.Cancel_button.Text = "Отменить";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // FormCanned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 544);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Components_groupBox);
            this.Controls.Add(this.Price_textBox);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.Price_label);
            this.Name = "FormCanned";
            this.Text = "FormCanned";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Components_dataGridView)).EndInit();
            this.Components_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Components_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComonentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.Label Price_label;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.TextBox Price_textBox;
        private System.Windows.Forms.GroupBox Components_groupBox;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Change_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Cancel_button;
    }
}