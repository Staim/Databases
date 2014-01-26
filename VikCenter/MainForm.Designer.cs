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
            this.components = new System.ComponentModel.Container();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИзУчетнойЗаписиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистраторыСДоговорамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистраторыУдалениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяРедактированияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менеджерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.своднаяТаблицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сводныеДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.окнаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каскадомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вертикальноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.горизонтальноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MainMenu.SuspendLayout();
            this.statusStrip.SuspendLayout();
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
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // выходИзУчетнойЗаписиToolStripMenuItem
            // 
            this.выходИзУчетнойЗаписиToolStripMenuItem.Name = "выходИзУчетнойЗаписиToolStripMenuItem";
            this.выходИзУчетнойЗаписиToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.выходИзУчетнойЗаписиToolStripMenuItem.Text = "Выход из учетной записи";
            // 
            // данныеToolStripMenuItem
            // 
            this.данныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.регистраторыСДоговорамиToolStripMenuItem,
            this.регистраторыУдалениеToolStripMenuItem,
            this.историяРедактированияToolStripMenuItem,
            this.менеджерыToolStripMenuItem});
            this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
            this.данныеToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.данныеToolStripMenuItem.Text = "Данные";
            // 
            // регистраторыСДоговорамиToolStripMenuItem
            // 
            this.регистраторыСДоговорамиToolStripMenuItem.Image = global::VikCenter.Properties.Resources._12;
            this.регистраторыСДоговорамиToolStripMenuItem.Name = "регистраторыСДоговорамиToolStripMenuItem";
            this.регистраторыСДоговорамиToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.регистраторыСДоговорамиToolStripMenuItem.Text = "Регистраторы -> Работа с данными";
            this.регистраторыСДоговорамиToolStripMenuItem.Click += new System.EventHandler(this.регистраторыСДоговорамиToolStripMenuItem_Click);
            // 
            // регистраторыУдалениеToolStripMenuItem
            // 
            this.регистраторыУдалениеToolStripMenuItem.Image = global::VikCenter.Properties.Resources._11;
            this.регистраторыУдалениеToolStripMenuItem.Name = "регистраторыУдалениеToolStripMenuItem";
            this.регистраторыУдалениеToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.регистраторыУдалениеToolStripMenuItem.Text = "Регистраторы - > Удаление";
            // 
            // историяРедактированияToolStripMenuItem
            // 
            this.историяРедактированияToolStripMenuItem.Image = global::VikCenter.Properties.Resources._14;
            this.историяРедактированияToolStripMenuItem.Name = "историяРедактированияToolStripMenuItem";
            this.историяРедактированияToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.историяРедактированияToolStripMenuItem.Text = "История редактирования";
            // 
            // менеджерыToolStripMenuItem
            // 
            this.менеджерыToolStripMenuItem.Name = "менеджерыToolStripMenuItem";
            this.менеджерыToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.менеджерыToolStripMenuItem.Text = "Менеджеры";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.своднаяТаблицаToolStripMenuItem,
            this.excelToolStripMenuItem,
            this.сводныеДанныеToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // своднаяТаблицаToolStripMenuItem
            // 
            this.своднаяТаблицаToolStripMenuItem.Name = "своднаяТаблицаToolStripMenuItem";
            this.своднаяТаблицаToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.своднаяТаблицаToolStripMenuItem.Text = "Word";
            this.своднаяТаблицаToolStripMenuItem.Click += new System.EventHandler(this.своднаяТаблицаToolStripMenuItem_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            // 
            // сводныеДанныеToolStripMenuItem
            // 
            this.сводныеДанныеToolStripMenuItem.Image = global::VikCenter.Properties.Resources._13;
            this.сводныеДанныеToolStripMenuItem.Name = "сводныеДанныеToolStripMenuItem";
            this.сводныеДанныеToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.сводныеДанныеToolStripMenuItem.Text = "Сводные данные";
            this.сводныеДанныеToolStripMenuItem.Click += new System.EventHandler(this.сводныеДанныеToolStripMenuItem_Click);
            // 
            // окнаToolStripMenuItem
            // 
            this.окнаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.каскадомToolStripMenuItem,
            this.вертикальноToolStripMenuItem,
            this.горизонтальноToolStripMenuItem});
            this.окнаToolStripMenuItem.Name = "окнаToolStripMenuItem";
            this.окнаToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.окнаToolStripMenuItem.Text = "Окна";
            // 
            // каскадомToolStripMenuItem
            // 
            this.каскадомToolStripMenuItem.Name = "каскадомToolStripMenuItem";
            this.каскадомToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.каскадомToolStripMenuItem.Text = "Каскадом";
            this.каскадомToolStripMenuItem.Click += new System.EventHandler(this.каскадомToolStripMenuItem_Click);
            // 
            // вертикальноToolStripMenuItem
            // 
            this.вертикальноToolStripMenuItem.Image = global::VikCenter.Properties.Resources._8;
            this.вертикальноToolStripMenuItem.Name = "вертикальноToolStripMenuItem";
            this.вертикальноToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.вертикальноToolStripMenuItem.Text = "Вертикально";
            this.вертикальноToolStripMenuItem.Click += new System.EventHandler(this.вертикальноToolStripMenuItem_Click);
            // 
            // горизонтальноToolStripMenuItem
            // 
            this.горизонтальноToolStripMenuItem.Image = global::VikCenter.Properties.Resources._9;
            this.горизонтальноToolStripMenuItem.Name = "горизонтальноToolStripMenuItem";
            this.горизонтальноToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.горизонтальноToolStripMenuItem.Text = "Горизонтально";
            this.горизонтальноToolStripMenuItem.Click += new System.EventHandler(this.горизонтальноToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 329);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(698, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(95, 17);
            this.toolStripStatusLabel1.Text = "Текущее время:";
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 351);
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
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem выходИзУчетнойЗаписиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менеджерыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem каскадомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вертикальноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem горизонтальноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem своднаяТаблицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистраторыСДоговорамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистраторыУдалениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem историяРедактированияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сводныеДанныеToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

