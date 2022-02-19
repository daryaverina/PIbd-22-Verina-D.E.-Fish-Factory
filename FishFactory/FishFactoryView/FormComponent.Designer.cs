namespace FishFactoryView
{
    partial class FormComponent
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
            this.ComponentName_textbox = new System.Windows.Forms.TextBox();
            this.NameComponent_label = new System.Windows.Forms.Label();
            this.Save_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComponentName_textbox
            // 
            this.ComponentName_textbox.Location = new System.Drawing.Point(140, 17);
            this.ComponentName_textbox.Name = "ComponentName_textbox";
            this.ComponentName_textbox.Size = new System.Drawing.Size(226, 23);
            this.ComponentName_textbox.TabIndex = 0;
            // 
            // NameComponent_label
            // 
            this.NameComponent_label.AutoSize = true;
            this.NameComponent_label.Location = new System.Drawing.Point(52, 20);
            this.NameComponent_label.Name = "NameComponent_label";
            this.NameComponent_label.Size = new System.Drawing.Size(62, 15);
            this.NameComponent_label.TabIndex = 1;
            this.NameComponent_label.Text = "Название:";
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(192, 68);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(75, 23);
            this.Save_button.TabIndex = 2;
            this.Save_button.Text = "Сохранить";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(291, 68);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_button.TabIndex = 3;
            this.Cancel_button.Text = "Отмена";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // FormComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 108);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.NameComponent_label);
            this.Controls.Add(this.ComponentName_textbox);
            this.Name = "FormComponent";
            this.Text = "text";
            this.Load += new System.EventHandler(this.FormComponent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ComponentName_textbox;
        private System.Windows.Forms.Label NameComponent_label;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Cancel_button;
    }
}