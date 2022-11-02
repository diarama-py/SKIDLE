using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SKIDLE.UserControls;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace SKIDLE
{
    public partial class skidle : Form
    {
        public skidle()
        {
            InitializeComponent();
        }

        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Special Key source code (*.spk) | *.spk";
            if (openFile.ShowDialog() != DialogResult.Cancel)
            {
                FileInfo fi = new FileInfo(openFile.FileName);
                codeTab tab = new codeTab();
                tabControl.Tabs.Add(tab);
                tabControl.SelectedTab = tab;
                tab.code.OpenFile(fi.FullName);
                tab.Text = fi.Name;
                tab.Name = fi.FullName;
                tab.LoadTopMenuLabel();
                loadStruct();
            }
        }

        private void открытьТерминалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Globals.SpecialKey + "SpecialKey.exe");
        }

        private void запуститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl.SelectedTab.Name.Contains(".spk"))
                {
                    сохранитьToolStripMenuItem_Click(sender, e);
                    Process.Start(Globals.SpecialKey + "SpecialKey.exe", tabControl.SelectedTab.Name);
                }
                else
                {
                    сохранитьКакToolStripMenuItem_Click(sender, e);
                }
            }
            catch { }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myCode = (codeTab)tabControl.Tabs[tabControl.SelectedIndex];
            if(File.Exists(tabControl.SelectedTab.Name))
            {
                File.WriteAllText(tabControl.SelectedTab.Name, myCode.code.Text);
                loadStruct();
            }
            else
            {
                сохранитьКакToolStripMenuItem_Click(sender, e);
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myCode = (codeTab)tabControl.Tabs[tabControl.SelectedIndex];
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Special Key source code (*.spk) | *.spk";
            if (save.ShowDialog() != DialogResult.Cancel)
            {
                FileInfo fi = new FileInfo(save.FileName);
                File.WriteAllText(fi.FullName, myCode.code.Text);
                myCode.Text = fi.Name;
                myCode.Name = fi.FullName;
                myCode.LoadTopMenuLabel();
                loadStruct();
            }
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeTab tab = new codeTab();
            tabControl.Tabs.Add(tab);
            tabControl.SelectedTab = tab;
            tab.Text = "untitled";
        }

        private void skidle_Load(object sender, EventArgs e)
        {
            split.Panel1Collapsed = true;
            ConfigFile config = new ConfigFile(Application.StartupPath + "\\configure.conf");
            if (config.GetProperty("theme") == "dark")
                DarkTheme();
            else
                LightTheme();
            if (config.GetProperty("language") == "ru")
                RuLang();
            else
                EnLang();
        }
        private void ExplorerMenu_Click(object sender, EventArgs e)
        {
            if(split.Panel1Collapsed == false)
            {
                split.Panel1Collapsed = true;
            }
            else
            {
                split.Panel1Collapsed = false;
            }
        }

        public void LoadCFA(string file)
        {
            FileInfo fi = new FileInfo(file);
            codeTab tab = new codeTab();
            tabControl.Tabs.Add(tab);
            tabControl.SelectedTab = tab;
            tab.code.OpenFile(fi.FullName);
            tab.Text = fi.Name;
            tab.Name = fi.FullName;
            tab.LoadTopMenuLabel();
            loadStruct();
        }

        public void LoadFCMD(string[] files)
        {
            foreach(var file in files)
            {
                FileInfo fi = new FileInfo(file);
                codeTab tab = new codeTab();
                tabControl.Tabs.Add(tab);
                tabControl.SelectedTab = tab;
                tab.code.OpenFile(fi.FullName);
                tab.Text = fi.Name;
                tab.Name = fi.FullName;
                tab.LoadTopMenuLabel();
                loadStruct();
            }
        }

        private void открытьПапкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbr = new FolderBrowserDialog();
            if(fbr.ShowDialog() != DialogResult.Cancel)
            {
                explorer.Nodes.Clear();
                split.Panel1Collapsed = false;
                DirectoryInfo dfo = new DirectoryInfo(fbr.SelectedPath);
                var nody = explorer.Nodes.Add(dfo.Name, dfo.Name);
                nody.Tag = dfo;
            }
        }

        private void explorer_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag == null)
            {

            }
            else if (e.Node.Tag.GetType() == typeof(DirectoryInfo))
            {
                e.Node.Nodes.Clear();

                foreach (var item in Directory.GetDirectories(((DirectoryInfo)e.Node.Tag).FullName))
                {
                    DirectoryInfo di = new DirectoryInfo(item);
                    var node = e.Node.Nodes.Add(di.Name, di.Name);
                    node.Tag = di;
                }
                foreach (var item in Directory.GetFiles(((DirectoryInfo)e.Node.Tag).FullName))
                {
                    FileInfo fi = new FileInfo(item);                  
                    var node = e.Node.Nodes.Add(fi.Name, fi.Name);
                    node.Tag = fi;
                }
                e.Node.Expand();
            }
            else
            {
                FileInfo fi = new FileInfo(((FileInfo)e.Node.Tag).FullName);
                codeTab tab = new codeTab();
                tabControl.Tabs.Add(tab);
                tabControl.SelectedTab = tab;
                tab.code.OpenFile(fi.FullName);
                tab.Text = fi.Name;
                tab.Name = fi.FullName;
                tab.LoadTopMenuLabel();
                loadStruct();
            }
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myCode = (codeTab)tabControl.Tabs[tabControl.SelectedIndex];
            myCode.code.Cut();
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myCode = (codeTab)tabControl.Tabs[tabControl.SelectedIndex];
            myCode.code.Copy();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myCode = (codeTab)tabControl.Tabs[tabControl.SelectedIndex];
            myCode.code.Paste();
        }

        private void найтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myCode = (codeTab)tabControl.Tabs[tabControl.SelectedIndex];
            myCode.code.ShowFindDialog();
        }

        private void перейтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myCode = (codeTab)tabControl.Tabs[tabControl.SelectedIndex];
            myCode.code.ShowGoToDialog();
        }

        private void заменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myCode = (codeTab)tabControl.Tabs[tabControl.SelectedIndex];
            myCode.code.ShowReplaceDialog();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.Tabs.Remove(tabControl.SelectedTab);
        }

        private void закрытьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            explorer.Nodes.Clear();
            tabControl.Tabs.Clear();
            split.Panel1Collapsed = true;
        }

        private void настройкиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Manina.Windows.Forms.Tab tab = new Manina.Windows.Forms.Tab();
            tab.BackColor = Color.FromArgb(63, 0, 123);
            tab.Text = "Settings";
            tabControl.Tabs.Add(tab);
            tabControl.SelectedTab = tab;
            SettingsTabControl settings = new SettingsTabControl();
            settings.Dock = DockStyle.Fill;
            tab.Controls.Add(settings);
        }

        private void createFile_Click(object sender, EventArgs e)
        {
            CreateForm create = new CreateForm(explorer.SelectedNode.Tag.ToString());
            create.Show();
        }

        private void openInExplorer_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", explorer.SelectedNode.Tag.ToString());
        }

        private void rename_Click(object sender, EventArgs e)
        {
            CreateForm create = new CreateForm(explorer.SelectedNode.Tag.ToString());
            create.Show();
            create.Rename = true;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (explorer.SelectedNode.Tag.ToString().Contains("."))
                {
                    FileInfo fi = new FileInfo(explorer.SelectedNode.Tag.ToString());
                    File.Delete(explorer.SelectedNode.Tag.ToString());
                }
                else
                {
                    FileInfo di = new FileInfo(explorer.SelectedNode.Tag.ToString());
                    Directory.Delete(explorer.SelectedNode.Tag.ToString());
                }
            }
            catch
            {

            }
        }
        private void переместитьModuleInModulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (explorer.SelectedNode.Tag.ToString().Contains("."))
                Process.Start("CaU.exe", "mm " + explorer.SelectedNode.Tag.ToString());
        }
        private void explorer_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                explorerContMenu.Show(explorer, e.Location);
        }

        private void loadStruct()
        {
            var myCode = (codeTab)tabControl.Tabs[tabControl.SelectedIndex];
            structure.code = myCode.code;
            structure.LoadStructure();
        }

        //
        //themes
        //
        #region themes
        //
        //Dark
        //
        #region dark
        private void DarkTheme()
        {
            menuStrip.BackColor = Color.FromArgb(63, 0, 113);
            menuStrip.ForeColor = SystemColors.HighlightText;
            this.файлToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)(224))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.leftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.сохранитьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.сохранитьКакToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.открытьПапкуToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.открытьФайлToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.создатьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.закрытьВсеToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.закрытьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.выйтиToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.правкаToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.вырезатьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.копироватьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.вставитьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.найтиToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.перейтиToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.заменитьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.настройкиToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.настройкиToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.выполнитьToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.запуститьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.терминалToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.открытьТерминалToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.run.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ExplorerMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.split.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.explorerPanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelStructureTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.explorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.explorer.ForeColor = System.Drawing.Color.White;
            this.structure.treeView.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            this.structure.treeView.ForeColor = System.Drawing.Color.White;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.ForeColor = SystemColors.HighlightText;
            explorerContMenu.ForeColor = Color.White;
            explorerContMenu.BackColor = Color.FromArgb(25, 25, 25);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        }
        #endregion
        //
        //Light
        //
        #region light
        private void LightTheme()
        {
            menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(226)))));
            menuStrip.ForeColor = Color.Black;
            this.файлToolStripMenuItem.ForeColor = Color.Black;
            this.leftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.сохранитьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(226)))));
            this.сохранитьКакToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(226)))));
            this.открытьПапкуToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(226)))));
            this.открытьФайлToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(226)))));
            this.создатьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(226)))));
            this.закрытьВсеToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(226)))));
            this.закрытьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(226)))));
            this.выйтиToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(226)))));
            this.правкаToolStripMenuItem.ForeColor = Color.Black;
            this.вырезатьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(226)))));
            this.копироватьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(226)))));
            this.вставитьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(226)))));
            this.найтиToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(226)))));
            this.перейтиToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(226)))));
            this.заменитьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(226)))));
            this.настройкиToolStripMenuItem.ForeColor = Color.Black;
            this.настройкиToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(226)))));
            this.выполнитьToolStripMenuItem.ForeColor = Color.Black;
            this.запуститьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(226)))));
            this.терминалToolStripMenuItem.ForeColor = Color.Black;
            this.открытьТерминалToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(63)))), ((int)(((byte)(226)))));
            this.run.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.ExplorerMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.split.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.explorerPanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelStructureTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.explorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.explorer.ForeColor = System.Drawing.Color.Black;
            this.structure.treeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.structure.treeView.ForeColor = System.Drawing.Color.Black;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.ForeColor = Color.Black;
            explorerContMenu.ForeColor = Color.Black;
            explorerContMenu.BackColor = Color.FromArgb(220,220,220);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        }
        #endregion

        #endregion

        //
        //Languages
        //
        #region languages
        private void EnLang()
        {
            ConfigFile config = new ConfigFile(Application.StartupPath + "\\Languages\\en.conf");
            this.файлToolStripMenuItem.Text = config.GetProperty("file");
            this.сохранитьToolStripMenuItem.Text = config.GetProperty("save");
            this.сохранитьКакToolStripMenuItem.Text = config.GetProperty("saveAs");
            this.открытьПапкуToolStripMenuItem.Text = config.GetProperty("openFolder");
            this.открытьФайлToolStripMenuItem.Text = config.GetProperty("open");
            this.создатьToolStripMenuItem.Text = config.GetProperty("create");
            this.закрытьВсеToolStripMenuItem.Text = config.GetProperty("closeAll");
            this.закрытьToolStripMenuItem.Text = config.GetProperty("close");
            this.выйтиToolStripMenuItem.Text = config.GetProperty("exit");
            this.правкаToolStripMenuItem.Text = config.GetProperty("edit");
            this.вырезатьToolStripMenuItem.Text = config.GetProperty("cut");
            this.копироватьToolStripMenuItem.Text = config.GetProperty("copy");
            this.вставитьToolStripMenuItem.Text = config.GetProperty("paste");
            this.найтиToolStripMenuItem.Text = config.GetProperty("find");
            this.перейтиToolStripMenuItem.Text = config.GetProperty("goto");
            this.заменитьToolStripMenuItem.Text = config.GetProperty("replace");
            this.настройкиToolStripMenuItem.Text = config.GetProperty("settings");
            this.настройкиToolStripMenuItem1.Text = config.GetProperty("subsettings");
            this.выполнитьToolStripMenuItem.Text = config.GetProperty("run");
            this.запуститьToolStripMenuItem.Text = config.GetProperty("subrun");
            this.терминалToolStripMenuItem.Text = config.GetProperty("terminal");
            this.открытьТерминалToolStripMenuItem.Text = config.GetProperty("subterminal");
            this.metroLabel1.Text = config.GetProperty("explorer");
            this.structureTitle.Text = config.GetProperty("structure");
            this.createFile.Text = config.GetProperty("eCreate");
            this.openInExplorer.Text = config.GetProperty("eOpenInExplorer");
            this.переместитьModuleInModulesToolStripMenuItem.Text = config.GetProperty("eCopyInModules");
            this.rename.Text = config.GetProperty("eRename");
            this.delete.Text = config.GetProperty("eDelete");
            this.Text = config.GetProperty("title");
        }

        private void RuLang()
        {
            ConfigFile config = new ConfigFile(Application.StartupPath + "\\Languages\\ru.conf");
            this.файлToolStripMenuItem.Text = config.GetProperty("file");
            this.сохранитьToolStripMenuItem.Text = config.GetProperty("save");
            this.сохранитьКакToolStripMenuItem.Text = config.GetProperty("saveAs");
            this.открытьПапкуToolStripMenuItem.Text = config.GetProperty("openFolder");
            this.открытьФайлToolStripMenuItem.Text = config.GetProperty("open");
            this.создатьToolStripMenuItem.Text = config.GetProperty("create");
            this.закрытьВсеToolStripMenuItem.Text = config.GetProperty("closeAll");
            this.закрытьToolStripMenuItem.Text = config.GetProperty("close");
            this.выйтиToolStripMenuItem.Text = config.GetProperty("exit");
            this.правкаToolStripMenuItem.Text = config.GetProperty("edit");
            this.вырезатьToolStripMenuItem.Text = config.GetProperty("cut");
            this.копироватьToolStripMenuItem.Text = config.GetProperty("copy");
            this.вставитьToolStripMenuItem.Text = config.GetProperty("paste");
            this.найтиToolStripMenuItem.Text = config.GetProperty("find");
            this.перейтиToolStripMenuItem.Text = config.GetProperty("goto");
            this.заменитьToolStripMenuItem.Text = config.GetProperty("replace");
            this.настройкиToolStripMenuItem.Text = config.GetProperty("settings");
            this.настройкиToolStripMenuItem1.Text = config.GetProperty("subsettings");
            this.выполнитьToolStripMenuItem.Text = config.GetProperty("run");
            this.запуститьToolStripMenuItem.Text = config.GetProperty("subrun");
            this.терминалToolStripMenuItem.Text = config.GetProperty("terminal");
            this.открытьТерминалToolStripMenuItem.Text = config.GetProperty("subterminal");
            this.metroLabel1.Text = config.GetProperty("explorer");
            this.structureTitle.Text = config.GetProperty("structure");
            this.createFile.Text = config.GetProperty("eCreate");
            this.openInExplorer.Text = config.GetProperty("eOpenInExplorer");
            this.переместитьModuleInModulesToolStripMenuItem.Text = config.GetProperty("eCopyInModules");
            this.rename.Text = config.GetProperty("eRename");
            this.delete.Text = config.GetProperty("eDelete");
            this.Text = config.GetProperty("title");
        }
        #endregion
    }
}
