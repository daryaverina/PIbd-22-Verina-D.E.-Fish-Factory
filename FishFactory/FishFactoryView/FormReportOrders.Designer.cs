namespace FishFactoryView
{
    partial class FormReportOrders
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
            this.panel = new System.Windows.Forms.Panel();
            this.forming_button = new System.Windows.Forms.Button();
            this.toPdf_button = new System.Windows.Forms.Button();
            this.to_label = new System.Windows.Forms.Label();
            this.label_from = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.forming_button);
            this.panel.Controls.Add(this.toPdf_button);
            this.panel.Controls.Add(this.to_label);
            this.panel.Controls.Add(this.label_from);
            this.panel.Controls.Add(this.dateTimePickerTo);
            this.panel.Controls.Add(this.dateTimePickerFrom);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1032, 61);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // forming_button
            // 
            this.forming_button.Location = new System.Drawing.Point(535, 12);
            this.forming_button.Name = "forming_button";
            this.forming_button.Size = new System.Drawing.Size(145, 29);
            this.forming_button.TabIndex = 2;
            this.forming_button.Text = "Сформировать";
            this.forming_button.UseVisualStyleBackColor = true;
            this.forming_button.Click += new System.EventHandler(this.forming_button_Click);
            // 
            // toPdf_button
            // 
            this.toPdf_button.Location = new System.Drawing.Point(761, 13);
            this.toPdf_button.Name = "toPdf_button";
            this.toPdf_button.Size = new System.Drawing.Size(94, 29);
            this.toPdf_button.TabIndex = 3;
            this.toPdf_button.Text = "В Pdf";
            this.toPdf_button.UseVisualStyleBackColor = true;
            this.toPdf_button.Click += new System.EventHandler(this.toPdf_button_Click);
            // 
            // to_label
            // 
            this.to_label.AutoSize = true;
            this.to_label.Location = new System.Drawing.Point(228, 15);
            this.to_label.Name = "to_label";
            this.to_label.Size = new System.Drawing.Size(27, 20);
            this.to_label.TabIndex = 1;
            this.to_label.Text = "по";
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.Location = new System.Drawing.Point(12, 15);
            this.label_from.Name = "label_from";
            this.label_from.Size = new System.Drawing.Size(16, 20);
            this.label_from.TabIndex = 2;
            this.label_from.Text = "с";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(261, 12);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(166, 27);
            this.dateTimePickerTo.TabIndex = 1;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(40, 12);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(166, 27);
            this.dateTimePickerFrom.TabIndex = 0;
            // 
            // FormReportOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 450);
            this.Controls.Add(this.panel);
            this.Name = "FormReportOrders";
            this.Text = "FormReportOrders";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button forming_button;
        private System.Windows.Forms.Button toPdf_button;
        private System.Windows.Forms.Label to_label;
        private System.Windows.Forms.Label label_from;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
    }
}