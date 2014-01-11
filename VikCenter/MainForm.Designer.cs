namespace VikCenter
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.окнаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистраторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.выходИзУчетнойЗаписиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.арендаАдресовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менеджерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.данныеToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.окнаToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(698, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 329);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(698, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.выходИзУчетнойЗаписиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // данныеToolStripMenuItem
            // 
            this.данныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.регистраторыToolStripMenuItem,
            this.арендаАдресовToolStripMenuItem,
            this.менеджерыToolStripMenuItem});
            this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
            this.данныеToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.данныеToolStripMenuItem.Text = "Данные";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // окнаToolStripMenuItem
            // 
            this.окнаToolStripMenuItem.Name = "окнаToolStripMenuItem";
            this.окнаToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.окнаToolStripMenuItem.Text = "Окна";
            // 
            // регистраторыToolStripMenuItem
            // 
            this.регистраторыToolStripMenuItem.Name = "регистраторыToolStripMenuItem";
            this.регистраторыToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.регистраторыToolStripMenuItem.Text = "Регистраторы";
            this.регистраторыToolStripMenuItem.Click += new System.EventHandler(this.регистраторыToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(698, 25);
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "toolStrip";
            // 
            // выходИзУчетнойЗаписиToolStripMenuItem
            // 
            this.выходИзУчетнойЗаписиToolStripMenuItem.Name = "выходИзУчетнойЗаписиToolStripMenuItem";
            this.выходИзУчетнойЗаписиToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.выходИзУчетнойЗаписиToolStripMenuItem.Text = "Выход из учетной записи";
            // 
            // арендаАдресовToolStripMenuItem
            // 
            this.арендаАдресовToolStripMenuItem.Name = "арендаАдресовToolStripMenuItem";
            this.арендаАдресовToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.арендаАдресовToolStripMenuItem.Text = "Аренда адресов";
            // 
            // менеджерыToolStripMenuItem
            // 
            this.менеджерыToolStripMenuItem.Name = "менеджерыToolStripMenuItem";
            this.менеджерыToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.менеджерыToolStripMenuItem.Text = "Менеджеры";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 351);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.MainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "База данных ООО \"ВикЦентр\"";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem данныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem окнаToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem регистраторыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходИзУчетнойЗаписиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem арендаАдресовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менеджерыToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
    }
}

