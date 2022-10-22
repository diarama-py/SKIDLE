namespace SKIDLE
{
    partial class skidle
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(skidle));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьПапкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выполнитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запуститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.терминалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьТерминалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new Manina.Windows.Forms.TabControl();
            this.leftMenu = new System.Windows.Forms.Panel();
            this.ExplorerMenu = new System.Windows.Forms.Button();
            this.split = new System.Windows.Forms.SplitContainer();
            this.explorer = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.leftMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
            this.split.Panel1.SuspendLayout();
            this.split.Panel2.SuspendLayout();
            this.split.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.выполнитьToolStripMenuItem,
            this.терминалToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(782, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.открытьПапкуToolStripMenuItem,
            this.открытьФайлToolStripMenuItem,
            this.создатьToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.сохранитьToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.сохранитьКакToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // открытьПапкуToolStripMenuItem
            // 
            this.открытьПапкуToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.открытьПапкуToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.открытьПапкуToolStripMenuItem.Name = "открытьПапкуToolStripMenuItem";
            this.открытьПапкуToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.открытьПапкуToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.открытьПапкуToolStripMenuItem.Text = "Открыть папку";
            this.открытьПапкуToolStripMenuItem.Click += new System.EventHandler(this.открытьПапкуToolStripMenuItem_Click);
            // 
            // открытьФайлToolStripMenuItem
            // 
            this.открытьФайлToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.открытьФайлToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            this.открытьФайлToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьФайлToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.открытьФайлToolStripMenuItem.Text = "Открыть файл";
            this.открытьФайлToolStripMenuItem.Click += new System.EventHandler(this.открытьФайлToolStripMenuItem_Click);
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.создатьToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.создатьToolStripMenuItem.Text = "Создать новый файл ";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem1});
            this.настройкиToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.настройкиToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(86, 21);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // настройкиToolStripMenuItem1
            // 
            this.настройкиToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.настройкиToolStripMenuItem1.ForeColor = System.Drawing.Color.Silver;
            this.настройкиToolStripMenuItem1.Name = "настройкиToolStripMenuItem1";
            this.настройкиToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.настройкиToolStripMenuItem1.Text = "Настройки";
            // 
            // выполнитьToolStripMenuItem
            // 
            this.выполнитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запуститьToolStripMenuItem});
            this.выполнитьToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.выполнитьToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.выполнитьToolStripMenuItem.Name = "выполнитьToolStripMenuItem";
            this.выполнитьToolStripMenuItem.Size = new System.Drawing.Size(88, 21);
            this.выполнитьToolStripMenuItem.Text = "Выполнить";
            // 
            // запуститьToolStripMenuItem
            // 
            this.запуститьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.запуститьToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.запуститьToolStripMenuItem.Name = "запуститьToolStripMenuItem";
            this.запуститьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.запуститьToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.запуститьToolStripMenuItem.Text = "Запустить отладку";
            this.запуститьToolStripMenuItem.Click += new System.EventHandler(this.запуститьToolStripMenuItem_Click);
            // 
            // терминалToolStripMenuItem
            // 
            this.терминалToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьТерминалToolStripMenuItem});
            this.терминалToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.терминалToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.терминалToolStripMenuItem.Name = "терминалToolStripMenuItem";
            this.терминалToolStripMenuItem.Size = new System.Drawing.Size(81, 21);
            this.терминалToolStripMenuItem.Text = "Терминал";
            // 
            // открытьТерминалToolStripMenuItem
            // 
            this.открытьТерминалToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.открытьТерминалToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.открытьТерминалToolStripMenuItem.Name = "открытьТерминалToolStripMenuItem";
            this.открытьТерминалToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.открытьТерминалToolStripMenuItem.Text = "Открыть Терминал";
            this.открытьТерминалToolStripMenuItem.Click += new System.EventHandler(this.открытьТерминалToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.CloseTabImage = ((System.Drawing.Image)(resources.GetObject("tabControl.CloseTabImage")));
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = -1;
            this.tabControl.ShowCloseTabButtons = true;
            this.tabControl.Size = new System.Drawing.Size(637, 384);
            this.tabControl.TabIndex = 1;
            // 
            // leftMenu
            // 
            this.leftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.leftMenu.Controls.Add(this.ExplorerMenu);
            this.leftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftMenu.Location = new System.Drawing.Point(0, 27);
            this.leftMenu.Name = "leftMenu";
            this.leftMenu.Size = new System.Drawing.Size(36, 384);
            this.leftMenu.TabIndex = 2;
            // 
            // ExplorerMenu
            // 
            this.ExplorerMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ExplorerMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExplorerMenu.FlatAppearance.BorderSize = 0;
            this.ExplorerMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExplorerMenu.Location = new System.Drawing.Point(0, 0);
            this.ExplorerMenu.Name = "ExplorerMenu";
            this.ExplorerMenu.Size = new System.Drawing.Size(36, 33);
            this.ExplorerMenu.TabIndex = 2;
            this.ExplorerMenu.Text = "Fs";
            this.ExplorerMenu.UseVisualStyleBackColor = false;
            this.ExplorerMenu.Click += new System.EventHandler(this.ExplorerMenu_Click);
            // 
            // split
            // 
            this.split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split.Location = new System.Drawing.Point(36, 27);
            this.split.Name = "split";
            // 
            // split.Panel1
            // 
            this.split.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.split.Panel1.Controls.Add(this.explorer);
            // 
            // split.Panel2
            // 
            this.split.Panel2.Controls.Add(this.tabControl);
            this.split.Size = new System.Drawing.Size(746, 384);
            this.split.SplitterDistance = 105;
            this.split.TabIndex = 3;
            // 
            // explorer
            // 
            this.explorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.explorer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.explorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explorer.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.explorer.FullRowSelect = true;
            this.explorer.ItemHeight = 22;
            this.explorer.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.explorer.Location = new System.Drawing.Point(0, 0);
            this.explorer.Name = "explorer";
            this.explorer.ShowRootLines = false;
            this.explorer.Size = new System.Drawing.Size(105, 384);
            this.explorer.TabIndex = 0;
            this.explorer.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.explorer_NodeMouseClick);
            // 
            // skidle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(782, 411);
            this.Controls.Add(this.split);
            this.Controls.Add(this.leftMenu);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "skidle";
            this.Text = "SKIDLE";
            this.Load += new System.EventHandler(this.skidle_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.leftMenu.ResumeLayout(false);
            this.split.Panel1.ResumeLayout(false);
            this.split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split)).EndInit();
            this.split.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выполнитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запуститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem терминалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьТерминалToolStripMenuItem;
        private Manina.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Panel leftMenu;
        private System.Windows.Forms.SplitContainer split;
        private System.Windows.Forms.Button ExplorerMenu;
        private System.Windows.Forms.ToolStripMenuItem открытьПапкуToolStripMenuItem;
        private System.Windows.Forms.TreeView explorer;
    }
}

