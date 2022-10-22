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
            }
        }

        private void открытьТерминалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Globals.SpecialKey + "SpecialKey.exe");
        }

        private void запуститьToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myCode = (codeTab)tabControl.Tabs[tabControl.SelectedIndex];
            if(File.Exists(tabControl.SelectedTab.Name))
            {
                File.WriteAllText(tabControl.SelectedTab.Name, myCode.code.Text);
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
            }
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeTab tab = new codeTab();
            tabControl.Tabs.Add(tab);
            tabControl.SelectedTab = tab;
            tab.Text = "untitled";
        }

        bool onClick = false;
        private void skidle_Load(object sender, EventArgs e)
        {
            onClick = false;
            split.Panel1Collapsed = true;
        }
        private void ExplorerMenu_Click(object sender, EventArgs e)
        {
            if(onClick == false)
            {
                split.Panel1Collapsed = true;
                onClick = true;
            }
            else
            {
                split.Panel1Collapsed = false;
                onClick = false;
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
            }
        }

        private void открытьПапкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbr = new FolderBrowserDialog();
            if(fbr.ShowDialog() != DialogResult.Cancel)
            {
                explorer.Nodes.Clear();
                split.Panel1Collapsed = false;

                foreach (var item in Directory.GetDirectories(fbr.SelectedPath))
                {
                    DirectoryInfo di = new DirectoryInfo(item);
                    var node = explorer.Nodes.Add(di.Name, di.Name);
                    node.Tag = di;
                }

                foreach (var item in Directory.GetFiles(fbr.SelectedPath))
                {
                    FileInfo fi = new FileInfo(item);                
                    var node = explorer.Nodes.Add(fi.Name, fi.Name);
                    node.Tag = fi;
                }
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
            }
        }
    }
}
