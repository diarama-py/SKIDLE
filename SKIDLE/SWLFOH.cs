using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKIDLE
{
    public partial class SWLFOH : Form
    {
        private string path = "";
        public SWLFOH()
        {
            InitializeComponent();
        }
        private void SWLFOH_Load(object sender, EventArgs e)
        {
            ConfigFile config = new ConfigFile(Globals.User + "configure.conf");
            Lang(config.GetProperty("language"));
            ConsoleOpen();
            HighLighting h = new HighLighting();
            splitContainer1.Panel2Collapsed = true;
            code.TextChangedDelayed += new EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(h._HighLighting);
        }
        private void consoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2Collapsed == true)
                splitContainer1.Panel2Collapsed = false;
            else
                splitContainer1.Panel2Collapsed = true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                code.OpenFile(path);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path != "")
                File.WriteAllText(path, code.Text);
            else
                saveAsToolStripMenuItem_Click(sender, e);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                path = sfd.FileName;
                File.WriteAllText(path,code.Text);
            }
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            code.Text = "";
            path = "";
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            code.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            code.Redo();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            code.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            code.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            code.Cut();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            code.ShowFindDialog();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            code.ShowReplaceDialog();
        }

        private void goToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            code.ShowGoToDialog();
        }

        private void copyPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path != "")
                Clipboard.SetText(path);
        }

        public void LFFP(String file)
        {
            path = file;
            code.OpenFile(file, Encoding.UTF8);
        }
        private async void ConsoleOpen()
        {
            await Task.Run(() => {
                bool stop = false;
                string text = "";
                do
                {
                    console.WriteLine("&> ");
                    text = console.ReadLine();
                    console.Command(text);
                } while (stop != true);

            });
        }

        private void Lang(string file)
        {
            ConfigFile conf = new ConfigFile(Globals.Main + "Languages\\" + file + ".conf");
            fileToolStripMenuItem.Text = conf.GetProperty("file");
            saveToolStripMenuItem.Text = conf.GetProperty("save");
            saveAsToolStripMenuItem.Text = conf.GetProperty("saveAs");
            newFileToolStripMenuItem.Text = conf.GetProperty("create");
            openToolStripMenuItem.Text = conf.GetProperty("open");
            editToolStripMenuItem.Text = conf.GetProperty("edit");
            findToolStripMenuItem.Text = conf.GetProperty("find");
            replaceToolStripMenuItem.Text = conf.GetProperty("replace");
            copyToolStripMenuItem.Text = conf.GetProperty("copy");
            pasteToolStripMenuItem.Text = conf.GetProperty("paste");
            cutToolStripMenuItem.Text = conf.GetProperty("cut");
            goToToolStripMenuItem.Text = conf.GetProperty("goto");
            consoleToolStripMenuItem.Text = conf.GetProperty("subterminal");
        }
    }
}
