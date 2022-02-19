
namespace FishFactoryView
{
    partial class FormCreateOrder
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
            this.Canned_label = new System.Windows.Forms.Label();
            this.Amount_label = new System.Windows.Forms.Label();
            this.Summ_label = new System.Windows.Forms.Label();
            this.Canned_comboBox = new System.Windows.Forms.ComboBox();
            this.Amount_textBox = new System.Windows.Forms.TextBox();
            this.Summ_textBox = new System.Windows.Forms.TextBox();
            this.Save_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Canned_label
            // 
            this.Canned_label.AutoSize = true;
            this.Canned_label.Location = new System.Drawing.Point(37, 13);
            this.Canned_label.Name = "Canned_label";
            this.Canned_label.Size = new System.Drawing.Size(56, 15);
            this.Canned_label.TabIndex = 0;
            this.Canned_label.Text = "Изделие:";
            // 
            // Amount_label
            // 
            this.Amount_label.AutoSize = true;
            this.Amount_label.Location = new System.Drawing.Point(37, 49);
            this.Amount_label.Name = "Amount_label";
            this.Amount_label.Size = new System.Drawing.Size(75, 15);
            this.Amount_label.TabIndex = 1;
            this.Amount_label.Text = "Количество:";
            // 
            // Summ_label
            // 
            this.Summ_label.AutoSize = true;
            this.Summ_label.Location = new System.Drawing.Point(37, 87);
            this.Summ_label.Name = "Summ_label";
            this.Summ_label.Size = new System.Drawing.Size(48, 15);
            this.Summ_label.TabIndex = 2;
            this.Summ_label.Text = "Сумма:";
            // 
            // Canned_comboBox
            // 
            this.Canned_comboBox.FormattingEnabled = true;
            this.Canned_comboBox.Location = new System.Drawing.Point(124, 10);
            this.Canned_comboBox.Name = "Canned_comboBox";
            this.Canned_comboBox.Size = new System.Drawing.Size(188, 23);
            this.Canned_comboBox.TabIndex = 3;
            this.Canned_comboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCanned_SelectedIndexChanged);
            this.Canned_comboBox.TextChanged += new System.EventHandler(this.comboBoxCars_SelectedIndexChanged);
            // 
            // Amount_textBox
            // 
            this.Amount_textBox.Location = new System.Drawing.Point(124, 46);
            this.Amount_textBox.Name = "Amount_textBox";
            this.Amount_textBox.Size = new System.Drawing.Size(188, 23);
            this.Amount_textBox.TabIndex = 4;
            this.Amount_textBox.TextChanged += new System.EventHandler(this.textBoxCount_TextChanged);
            // 
            // Summ_textBox
            // 
            this.Summ_textBox.Location = new System.Drawing.Point(124, 84);
            this.Summ_textBox.Name = "Summ_textBox";
            this.Summ_textBox.Size = new System.Drawing.Size(188, 23);
            this.Summ_textBox.TabIndex = 5;
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(124, 129);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(75, 23);
            this.Save_button.TabIndex = 6;
            this.Save_button.Text = "Сохранить";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(237, 129);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_button.TabIndex = 7;
            this.Cancel_button.Text = "Отмена";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // FormCreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 176);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Summ_textBox);
            this.Controls.Add(this.Amount_textBox);
            this.Controls.Add(this.Canned_comboBox);
            this.Controls.Add(this.Summ_label);
            this.Controls.Add(this.Amount_label);
            this.Controls.Add(this.Canned_label);
            this.Name = "FormCreateOrder";
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.FormCreateOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Canned_label;
        private System.Windows.Forms.Label Amount_label;
        private System.Windows.Forms.Label Summ_label;
        private System.Windows.Forms.ComboBox Canned_comboBox;
        private System.Windows.Forms.TextBox Amount_textBox;
        private System.Windows.Forms.TextBox Summ_textBox;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Cancel_button;
    }
}