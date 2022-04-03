
namespace FishFactoryView
{
    partial class FormMain
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
            this.Main_dataGridView = new System.Windows.Forms.DataGridView();
            this.MakeOrder_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.компонентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изделияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.КонсервыПоКомпанентамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЗаказовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокКонсервовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Main_dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_dataGridView
            // 
            this.Main_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Main_dataGridView.Location = new System.Drawing.Point(0, 36);
            this.Main_dataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Main_dataGridView.Name = "Main_dataGridView";
            this.Main_dataGridView.RowHeadersWidth = 51;
            this.Main_dataGridView.RowTemplate.Height = 25;
            this.Main_dataGridView.Size = new System.Drawing.Size(766, 548);
            this.Main_dataGridView.TabIndex = 0;
            // 
            // MakeOrder_button
            // 
            this.MakeOrder_button.Location = new System.Drawing.Point(851, 51);
            this.MakeOrder_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MakeOrder_button.Name = "MakeOrder_button";
            this.MakeOrder_button.Size = new System.Drawing.Size(166, 31);
            this.MakeOrder_button.TabIndex = 1;
            this.MakeOrder_button.Text = "Создать заказ";
            this.MakeOrder_button.UseVisualStyleBackColor = true;
            this.MakeOrder_button.Click += new System.EventHandler(this.ButtonCreateOrder_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(851, 104);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Отдать на выполнение";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonTakeOrderInWork_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(851, 161);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "Заказ готов";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ButtonOrderReady_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(851, 221);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 31);
            this.button4.TabIndex = 4;
            this.button4.Text = "Заказ выдан";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ButtonIssuedOrder_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(851, 280);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(166, 31);
            this.button5.TabIndex = 5;
            this.button5.Text = "Обновить список";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ButtonRef_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1062, 30);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "Справочники";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.компонентыToolStripMenuItem,
            this.изделияToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // компонентыToolStripMenuItem
            // 
            this.компонентыToolStripMenuItem.Name = "компонентыToolStripMenuItem";
            this.компонентыToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.компонентыToolStripMenuItem.Text = "Компоненты";
            this.компонентыToolStripMenuItem.Click += new System.EventHandler(this.компонентыToolStripMenuItem_Click);
            // 
            // изделияToolStripMenuItem
            // 
            this.изделияToolStripMenuItem.Name = "изделияToolStripMenuItem";
            this.изделияToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.изделияToolStripMenuItem.Text = "Изделия";
            this.изделияToolStripMenuItem.Click += new System.EventHandler(this.изделияToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.КонсервыПоКомпанентамToolStripMenuItem,
            this.списокЗаказовToolStripMenuItem,
            this.списокКонсервовToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // КонсервыПоКомпанентамToolStripMenuItem
            // 
            this.КонсервыПоКомпанентамToolStripMenuItem.Name = "КонсервыПоКомпанентамToolStripMenuItem";
            this.КонсервыПоКомпанентамToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.КонсервыПоКомпанентамToolStripMenuItem.Text = "Консервы по изделиям";
            this.КонсервыПоКомпанентамToolStripMenuItem.Click += new System.EventHandler(this.КонсервыПоКомпанентамToolStripMenuItem_Click);
            // 
            // списокЗаказовToolStripMenuItem
            // 
            this.списокЗаказовToolStripMenuItem.Name = "списокЗаказовToolStripMenuItem";
            this.списокЗаказовToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.списокЗаказовToolStripMenuItem.Text = "Список заказов";
            this.списокЗаказовToolStripMenuItem.Click += new System.EventHandler(this.списокЗаказовToolStripMenuItem_Click);
            // 
            // списокКонсервовToolStripMenuItem
            // 
            this.списокКонсервовToolStripMenuItem.Name = "списокКонсервовToolStripMenuItem";
            this.списокКонсервовToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.списокКонсервовToolStripMenuItem.Text = "Список консервов";
            this.списокКонсервовToolStripMenuItem.Click += new System.EventHandler(this.списокКонсервовToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 600);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MakeOrder_button);
            this.Controls.Add(this.Main_dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "Завод рыбы";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Main_dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Main_dataGridView;
        private System.Windows.Forms.Button MakeOrder_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem компонентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изделияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem КонсервыПоКомпанентамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокЗаказовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокКонсервовToolStripMenuItem;
    }
}