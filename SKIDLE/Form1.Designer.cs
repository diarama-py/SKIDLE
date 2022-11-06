using SKIDLE.UI.VS;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(skidle));
            this.tabControl = new Manina.Windows.Forms.TabControl();
            this.leftMenu = new System.Windows.Forms.Panel();
            this.run = new System.Windows.Forms.Button();
            this.structureBTN = new System.Windows.Forms.Button();
            this.ExplorerMenu = new System.Windows.Forms.Button();
            this.split = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.explorer = new SKIDLE.BufferedTreeView();
            this.explorerPanelTitle = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.structure = new SKIDLE.UserControls.StructureControl();
            this.panelStructureTitle = new System.Windows.Forms.Panel();
            this.structureTitle = new MetroFramework.Controls.MetroLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.DinRun = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.RunPath = new MetroFramework.Controls.MetroTextBox();
            this.StatRun = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RunLabel = new MetroFramework.Controls.MetroLabel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.console = new SKIDLE.UserControls.Console();
            this.tabMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.переместитьModuleInModulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьПапкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перейтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выполнитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запуститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.терминалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьТерминалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.модулиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explorerContMenu = new SKIDLE.UI.VS.VSContextMenuStrip();
            this.createFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openInExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.rename = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.leftMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
            this.split.Panel1.SuspendLayout();
            this.split.Panel2.SuspendLayout();
            this.split.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.explorerPanelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panelStructureTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.console)).BeginInit();
            this.tabMenu.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.explorerContMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabControl.CloseTabImage = ((System.Drawing.Image)(resources.GetObject("tabControl.CloseTabImage")));
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = -1;
            this.tabControl.ShowCloseTabButtons = true;
            this.tabControl.Size = new System.Drawing.Size(617, 286);
            this.tabControl.TabIndex = 1;
            // 
            // leftMenu
            // 
            this.leftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.leftMenu.Controls.Add(this.run);
            this.leftMenu.Controls.Add(this.structureBTN);
            this.leftMenu.Controls.Add(this.ExplorerMenu);
            this.leftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftMenu.Location = new System.Drawing.Point(0, 27);
            this.leftMenu.Name = "leftMenu";
            this.leftMenu.Size = new System.Drawing.Size(30, 384);
            this.leftMenu.TabIndex = 2;
            // 
            // run
            // 
            this.run.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.run.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("run.BackgroundImage")));
            this.run.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.run.Dock = System.Windows.Forms.DockStyle.Top;
            this.run.FlatAppearance.BorderSize = 0;
            this.run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.run.Location = new System.Drawing.Point(0, 50);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(30, 25);
            this.run.TabIndex = 3;
            this.run.UseVisualStyleBackColor = false;
            this.run.Click += new System.EventHandler(this.RunMenu_Click);
            // 
            // structureBTN
            // 
            this.structureBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.structureBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("structureBTN.BackgroundImage")));
            this.structureBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.structureBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.structureBTN.FlatAppearance.BorderSize = 0;
            this.structureBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.structureBTN.Location = new System.Drawing.Point(0, 25);
            this.structureBTN.Name = "structureBTN";
            this.structureBTN.Size = new System.Drawing.Size(30, 25);
            this.structureBTN.TabIndex = 4;
            this.structureBTN.UseVisualStyleBackColor = false;
            this.structureBTN.Click += new System.EventHandler(this.structureBTN_Click);
            // 
            // ExplorerMenu
            // 
            this.ExplorerMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ExplorerMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExplorerMenu.BackgroundImage")));
            this.ExplorerMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExplorerMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExplorerMenu.FlatAppearance.BorderSize = 0;
            this.ExplorerMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExplorerMenu.Location = new System.Drawing.Point(0, 0);
            this.ExplorerMenu.Name = "ExplorerMenu";
            this.ExplorerMenu.Size = new System.Drawing.Size(30, 25);
            this.ExplorerMenu.TabIndex = 2;
            this.ExplorerMenu.UseVisualStyleBackColor = false;
            this.ExplorerMenu.Click += new System.EventHandler(this.ExplorerMenu_Click);
            // 
            // split
            // 
            this.split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split.Location = new System.Drawing.Point(30, 27);
            this.split.Name = "split";
            // 
            // split.Panel1
            // 
            this.split.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.split.Panel1.Controls.Add(this.splitContainer1);
            // 
            // split.Panel2
            // 
            this.split.Panel2.Controls.Add(this.splitContainer2);
            this.split.Size = new System.Drawing.Size(752, 384);
            this.split.SplitterDistance = 131;
            this.split.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.explorer);
            this.splitContainer1.Panel1.Controls.Add(this.explorerPanelTitle);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(131, 384);
            this.splitContainer1.SplitterDistance = 47;
            this.splitContainer1.TabIndex = 0;
            // 
            // explorer
            // 
            this.explorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.explorer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.explorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explorer.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.explorer.FullRowSelect = true;
            this.explorer.imageList = null;
            this.explorer.ItemHeight = 22;
            this.explorer.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.explorer.Location = new System.Drawing.Point(0, 33);
            this.explorer.Name = "explorer";
            this.explorer.ShowNodeToolTips = true;
            this.explorer.ShowPlusMinus = false;
            this.explorer.ShowRootLines = false;
            this.explorer.Size = new System.Drawing.Size(131, 14);
            this.explorer.TabIndex = 0;
            this.explorer.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.explorer_NodeMouseClick);
            this.explorer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.explorer_MouseClick);
            // 
            // explorerPanelTitle
            // 
            this.explorerPanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.explorerPanelTitle.Controls.Add(this.metroLabel1);
            this.explorerPanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.explorerPanelTitle.Location = new System.Drawing.Point(0, 0);
            this.explorerPanelTitle.Name = "explorerPanelTitle";
            this.explorerPanelTitle.Size = new System.Drawing.Size(131, 33);
            this.explorerPanelTitle.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(2, 4);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(112, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Проводник";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.structure);
            this.splitContainer3.Panel1.Controls.Add(this.panelStructureTitle);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.label2);
            this.splitContainer3.Panel2.Controls.Add(this.DinRun);
            this.splitContainer3.Panel2.Controls.Add(this.label1);
            this.splitContainer3.Panel2.Controls.Add(this.RunPath);
            this.splitContainer3.Panel2.Controls.Add(this.StatRun);
            this.splitContainer3.Panel2.Controls.Add(this.panel1);
            this.splitContainer3.Size = new System.Drawing.Size(131, 333);
            this.splitContainer3.SplitterDistance = 47;
            this.splitContainer3.TabIndex = 0;
            // 
            // structure
            // 
            this.structure.BackColor = System.Drawing.SystemColors.Control;
            this.structure.code = null;
            this.structure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.structure.Location = new System.Drawing.Point(0, 34);
            this.structure.Margin = new System.Windows.Forms.Padding(2);
            this.structure.Name = "structure";
            this.structure.Size = new System.Drawing.Size(131, 13);
            this.structure.TabIndex = 0;
            // 
            // panelStructureTitle
            // 
            this.panelStructureTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelStructureTitle.Controls.Add(this.structureTitle);
            this.panelStructureTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStructureTitle.Location = new System.Drawing.Point(0, 0);
            this.panelStructureTitle.Name = "panelStructureTitle";
            this.panelStructureTitle.Size = new System.Drawing.Size(131, 34);
            this.panelStructureTitle.TabIndex = 3;
            // 
            // structureTitle
            // 
            this.structureTitle.AutoSize = true;
            this.structureTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.structureTitle.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.structureTitle.Location = new System.Drawing.Point(2, 4);
            this.structureTitle.Name = "structureTitle";
            this.structureTitle.Size = new System.Drawing.Size(101, 25);
            this.structureTitle.TabIndex = 1;
            this.structureTitle.Text = "Структура";
            this.structureTitle.UseCustomBackColor = true;
            this.structureTitle.UseCustomForeColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Запуск файла в\r\nвыбранной вкладке";
            // 
            // DinRun
            // 
            this.DinRun.AutoSize = true;
            this.DinRun.Dock = System.Windows.Forms.DockStyle.Top;
            this.DinRun.Location = new System.Drawing.Point(0, 109);
            this.DinRun.Name = "DinRun";
            this.DinRun.Size = new System.Drawing.Size(131, 24);
            this.DinRun.TabIndex = 6;
            this.DinRun.TabStop = true;
            this.DinRun.Text = "Дин.Запуск";
            this.DinRun.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Запуск только одного\r\nопр. файла";
            // 
            // RunPath
            // 
            this.RunPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            // 
            // 
            // 
            this.RunPath.CustomButton.Image = null;
            this.RunPath.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.RunPath.CustomButton.Name = "";
            this.RunPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.RunPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RunPath.CustomButton.TabIndex = 1;
            this.RunPath.CustomButton.Text = "...";
            this.RunPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RunPath.CustomButton.UseSelectable = true;
            this.RunPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.RunPath.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RunPath.Lines = new string[0];
            this.RunPath.Location = new System.Drawing.Point(0, 58);
            this.RunPath.MaxLength = 32767;
            this.RunPath.Name = "RunPath";
            this.RunPath.PasswordChar = '\0';
            this.RunPath.PromptText = "Path to file";
            this.RunPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RunPath.SelectedText = "";
            this.RunPath.SelectionLength = 0;
            this.RunPath.SelectionStart = 0;
            this.RunPath.ShortcutsEnabled = true;
            this.RunPath.ShowButton = true;
            this.RunPath.Size = new System.Drawing.Size(131, 23);
            this.RunPath.TabIndex = 7;
            this.RunPath.UseCustomBackColor = true;
            this.RunPath.UseCustomForeColor = true;
            this.RunPath.UseSelectable = true;
            this.RunPath.WaterMark = "Path to file";
            this.RunPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RunPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // StatRun
            // 
            this.StatRun.AutoSize = true;
            this.StatRun.Dock = System.Windows.Forms.DockStyle.Top;
            this.StatRun.Location = new System.Drawing.Point(0, 34);
            this.StatRun.Name = "StatRun";
            this.StatRun.Size = new System.Drawing.Size(131, 24);
            this.StatRun.TabIndex = 5;
            this.StatRun.TabStop = true;
            this.StatRun.Text = "Стат. запуск";
            this.StatRun.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.RunLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 34);
            this.panel1.TabIndex = 4;
            // 
            // RunLabel
            // 
            this.RunLabel.AutoSize = true;
            this.RunLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.RunLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.RunLabel.Location = new System.Drawing.Point(2, 4);
            this.RunLabel.Name = "RunLabel";
            this.RunLabel.Size = new System.Drawing.Size(72, 25);
            this.RunLabel.TabIndex = 1;
            this.RunLabel.Text = "Запуск";
            this.RunLabel.UseCustomBackColor = true;
            this.RunLabel.UseCustomForeColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabControl);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.console);
            this.splitContainer2.Size = new System.Drawing.Size(617, 384);
            this.splitContainer2.SplitterDistance = 286;
            this.splitContainer2.TabIndex = 2;
            // 
            // console
            // 
            this.console.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.console.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
    "(?<range>:)\\s*(?<range>[^;]+);";
            this.console.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.console.BackBrush = null;
            this.console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.console.CharHeight = 14;
            this.console.CharWidth = 8;
            this.console.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.console.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.console.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.console.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.console.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.console.IsReadLineMode = false;
            this.console.IsReplaceMode = false;
            this.console.LineNumberColor = System.Drawing.Color.Azure;
            this.console.Location = new System.Drawing.Point(0, 0);
            this.console.Name = "console";
            this.console.Paddings = new System.Windows.Forms.Padding(0);
            this.console.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.console.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("console.ServiceColors")));
            this.console.ServiceLinesColor = System.Drawing.Color.Black;
            this.console.ShowLineNumbers = false;
            this.console.Size = new System.Drawing.Size(617, 94);
            this.console.TabIndex = 0;
            this.console.Zoom = 100;
            // 
            // tabMenu
            // 
            this.tabMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переместитьModuleInModulesToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Size = new System.Drawing.Size(253, 48);
            // 
            // переместитьModuleInModulesToolStripMenuItem
            // 
            this.переместитьModuleInModulesToolStripMenuItem.Name = "переместитьModuleInModulesToolStripMenuItem";
            this.переместитьModuleInModulesToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.переместитьModuleInModulesToolStripMenuItem.Text = "Переместить module in modules";
            this.переместитьModuleInModulesToolStripMenuItem.Click += new System.EventHandler(this.переместитьModuleInModulesToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.menuStrip.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.выполнитьToolStripMenuItem,
            this.терминалToolStripMenuItem,
            this.отчетToolStripMenuItem,
            this.модулиToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(782, 27);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.открытьПапкуToolStripMenuItem,
            this.открытьФайлToolStripMenuItem,
            this.создатьToolStripMenuItem,
            this.закрытьВсеToolStripMenuItem,
            this.закрытьToolStripMenuItem,
            this.выйтиToolStripMenuItem});
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
            this.создатьToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.создатьToolStripMenuItem.Text = "Создать новый файл ";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // закрытьВсеToolStripMenuItem
            // 
            this.закрытьВсеToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.закрытьВсеToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.закрытьВсеToolStripMenuItem.Name = "закрытьВсеToolStripMenuItem";
            this.закрытьВсеToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.закрытьВсеToolStripMenuItem.Text = "Закрыть все";
            this.закрытьВсеToolStripMenuItem.Click += new System.EventHandler(this.закрытьВсеToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.закрытьToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.выйтиToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.найтиToolStripMenuItem,
            this.перейтиToolStripMenuItem,
            this.заменитьToolStripMenuItem});
            this.правкаToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.вырезатьToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.вырезатьToolStripMenuItem_Click);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.копироватьToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.вставитьToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // найтиToolStripMenuItem
            // 
            this.найтиToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.найтиToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
            this.найтиToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.найтиToolStripMenuItem.Text = "Найти";
            this.найтиToolStripMenuItem.Click += new System.EventHandler(this.найтиToolStripMenuItem_Click);
            // 
            // перейтиToolStripMenuItem
            // 
            this.перейтиToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.перейтиToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.перейтиToolStripMenuItem.Name = "перейтиToolStripMenuItem";
            this.перейтиToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.перейтиToolStripMenuItem.Text = "Перейти";
            this.перейтиToolStripMenuItem.Click += new System.EventHandler(this.перейтиToolStripMenuItem_Click);
            // 
            // заменитьToolStripMenuItem
            // 
            this.заменитьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.заменитьToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.заменитьToolStripMenuItem.Name = "заменитьToolStripMenuItem";
            this.заменитьToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.заменитьToolStripMenuItem.Text = "Заменить";
            this.заменитьToolStripMenuItem.Click += new System.EventHandler(this.заменитьToolStripMenuItem_Click);
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
            this.настройкиToolStripMenuItem1.Click += new System.EventHandler(this.настройкиToolStripMenuItem1_Click);
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
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(54, 21);
            this.отчетToolStripMenuItem.Text = "Отчет";
            this.отчетToolStripMenuItem.Click += new System.EventHandler(this.отчетToolStripMenuItem_Click);
            // 
            // модулиToolStripMenuItem
            // 
            this.модулиToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.модулиToolStripMenuItem.Name = "модулиToolStripMenuItem";
            this.модулиToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.модулиToolStripMenuItem.Text = "Модули";
            this.модулиToolStripMenuItem.Click += new System.EventHandler(this.модулиToolStripMenuItem_Click);
            // 
            // explorerContMenu
            // 
            this.explorerContMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.explorerContMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createFile,
            this.openInExplorer,
            this.rename,
            this.delete});
            this.explorerContMenu.Name = "explorerContMenu";
            this.explorerContMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.explorerContMenu.Size = new System.Drawing.Size(200, 92);
            // 
            // createFile
            // 
            this.createFile.Name = "createFile";
            this.createFile.Size = new System.Drawing.Size(199, 22);
            this.createFile.Text = "Создать";
            this.createFile.Click += new System.EventHandler(this.createFile_Click);
            // 
            // openInExplorer
            // 
            this.openInExplorer.Name = "openInExplorer";
            this.openInExplorer.Size = new System.Drawing.Size(199, 22);
            this.openInExplorer.Text = "Открыть в проводнике";
            this.openInExplorer.Click += new System.EventHandler(this.openInExplorer_Click);
            // 
            // rename
            // 
            this.rename.Name = "rename";
            this.rename.Size = new System.Drawing.Size(199, 22);
            this.rename.Text = "Переименовать";
            this.rename.Click += new System.EventHandler(this.rename_Click);
            // 
            // delete
            // 
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(199, 22);
            this.delete.Text = "Удалить";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // skidle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(782, 411);
            this.Controls.Add(this.split);
            this.Controls.Add(this.leftMenu);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "skidle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SKIDLE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.skidle_FormClosing);
            this.Load += new System.EventHandler(this.skidle_Load);
            this.leftMenu.ResumeLayout(false);
            this.split.Panel1.ResumeLayout(false);
            this.split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split)).EndInit();
            this.split.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.explorerPanelTitle.ResumeLayout(false);
            this.explorerPanelTitle.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panelStructureTitle.ResumeLayout(false);
            this.panelStructureTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.console)).EndInit();
            this.tabMenu.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.explorerContMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
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
        private BufferedTreeView explorer;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перейтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.Button run;
        private VSContextMenuStrip explorerContMenu;
        private System.Windows.Forms.ToolStripMenuItem createFile;
        private System.Windows.Forms.ToolStripMenuItem openInExplorer;
        private System.Windows.Forms.ToolStripMenuItem rename;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.Panel explorerPanelTitle;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private UserControls.StructureControl structure;
        private System.Windows.Forms.Panel panelStructureTitle;
        private MetroFramework.Controls.MetroLabel structureTitle;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button structureBTN;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private UserControls.Console console;
        private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip tabMenu;
        private System.Windows.Forms.ToolStripMenuItem переместитьModuleInModulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem модулиToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton DinRun;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox RunPath;
        private System.Windows.Forms.RadioButton StatRun;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel RunLabel;
    }
}

