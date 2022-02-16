
namespace FishFactoryView
{
    partial class FormCannedComponent
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
            this.Amount_textBox = new System.Windows.Forms.TextBox();
            this.Component_label = new System.Windows.Forms.Label();
            this.Amount_label = new System.Windows.Forms.Label();
            this.Save_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Component_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Amount_textBox
            // 
            this.Amount_textBox.Location = new System.Drawing.Point(117, 70);
            this.Amount_textBox.Name = "Amount_textBox";
            this.Amount_textBox.Size = new System.Drawing.Size(190, 23);
            this.Amount_textBox.TabIndex = 0;
            // 
            // Component_label
            // 
            this.Component_label.AutoSize = true;
            this.Component_label.Location = new System.Drawing.Point(28, 28);
            this.Component_label.Name = "Component_label";
            this.Component_label.Size = new System.Drawing.Size(72, 15);
            this.Component_label.TabIndex = 1;
            this.Component_label.Text = "Компонент:";
            // 
            // Amount_label
            // 
            this.Amount_label.AutoSize = true;
            this.Amount_label.Location = new System.Drawing.Point(28, 73);
            this.Amount_label.Name = "Amount_label";
            this.Amount_label.Size = new System.Drawing.Size(75, 15);
            this.Amount_label.TabIndex = 2;
            this.Amount_label.Text = "Количество:";
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(140, 119);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(75, 23);
            this.Save_button.TabIndex = 3;
            this.Save_button.Text = "Сохранить";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(232, 119);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_button.TabIndex = 4;
            this.Cancel_button.Text = "Отменить";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // Component_comboBox
            // 
            this.Component_comboBox.FormattingEnabled = true;
            this.Component_comboBox.Location = new System.Drawing.Point(117, 25);
            this.Component_comboBox.Name = "Component_comboBox";
            this.Component_comboBox.Size = new System.Drawing.Size(190, 23);
            this.Component_comboBox.TabIndex = 5;
            // 
            // FormCannedComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 166);
            this.Controls.Add(this.Component_comboBox);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Amount_label);
            this.Controls.Add(this.Component_label);
            this.Controls.Add(this.Amount_textBox);
            this.Name = "FormCannedComponent";
            this.Text = "Компонент изделия";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Amount_textBox;
        private System.Windows.Forms.Label Component_label;
        private System.Windows.Forms.Label Amount_label;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.ComboBox Component_comboBox;
    }
}