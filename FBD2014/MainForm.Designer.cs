namespace FBD2014
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьПрогораммуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЭлементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стандартныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.логикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.основныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.иToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.сохранитьПрограммуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьПрограммуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.добавитьЭлементToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьПрогораммуToolStripMenuItem,
            this.сохранитьПрограммуToolStripMenuItem,
            this.загрузитьПрограммуToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьПрогораммуToolStripMenuItem
            // 
            this.создатьПрогораммуToolStripMenuItem.Name = "создатьПрогораммуToolStripMenuItem";
            this.создатьПрогораммуToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.создатьПрогораммуToolStripMenuItem.Text = "Создать прогорамму";
            // 
            // добавитьЭлементToolStripMenuItem
            // 
            this.добавитьЭлементToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стандартныеToolStripMenuItem});
            this.добавитьЭлементToolStripMenuItem.Name = "добавитьЭлементToolStripMenuItem";
            this.добавитьЭлементToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.добавитьЭлементToolStripMenuItem.Text = "Добавить элемент";
            // 
            // стандартныеToolStripMenuItem
            // 
            this.стандартныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.логикаToolStripMenuItem});
            this.стандартныеToolStripMenuItem.Name = "стандартныеToolStripMenuItem";
            this.стандартныеToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.стандартныеToolStripMenuItem.Text = "Стандартные";
            // 
            // логикаToolStripMenuItem
            // 
            this.логикаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.основныеToolStripMenuItem});
            this.логикаToolStripMenuItem.Name = "логикаToolStripMenuItem";
            this.логикаToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.логикаToolStripMenuItem.Text = "Логика";
            // 
            // основныеToolStripMenuItem
            // 
            this.основныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.иToolStripMenuItem});
            this.основныеToolStripMenuItem.Name = "основныеToolStripMenuItem";
            this.основныеToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.основныеToolStripMenuItem.Text = "Основные";
            // 
            // иToolStripMenuItem
            // 
            this.иToolStripMenuItem.Name = "иToolStripMenuItem";
            this.иToolStripMenuItem.Size = new System.Drawing.Size(83, 22);
            this.иToolStripMenuItem.Text = "И";
            this.иToolStripMenuItem.Click += new System.EventHandler(this.иToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // сохранитьПрограммуToolStripMenuItem
            // 
            this.сохранитьПрограммуToolStripMenuItem.Name = "сохранитьПрограммуToolStripMenuItem";
            this.сохранитьПрограммуToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.сохранитьПрограммуToolStripMenuItem.Text = "Сохранить программу";
            // 
            // загрузитьПрограммуToolStripMenuItem
            // 
            this.загрузитьПрограммуToolStripMenuItem.Name = "загрузитьПрограммуToolStripMenuItem";
            this.загрузитьПрограммуToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.загрузитьПрограммуToolStripMenuItem.Text = "Загрузить программу";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьПрогораммуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЭлементToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стандартныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem логикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem основныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem иToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьПрограммуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьПрограммуToolStripMenuItem;
    }
}

