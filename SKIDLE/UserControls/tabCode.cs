using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKIDLE.UserControls
{
    public class codeTab : Manina.Windows.Forms.Tab
    {
        public FastColoredTextBoxNS.FastColoredTextBox code = new FastColoredTextBoxNS.FastColoredTextBox();
        public AutoForce ACmenu;
        public ContextMenuStrip cms = new ContextMenuStrip();
        public int linesForDocMap = 150;
        FastColoredTextBoxNS.DocumentMap documentMap = new FastColoredTextBoxNS.DocumentMap();
        SplitContainer split = new SplitContainer();
        public codeTab()
        {
            ini();

        }

        private void ini()
        {
            this.ForeColor = Color.White;
            this.Controls.Add(split);
            this.BackColor = Color.FromArgb(63, 0, 115);

            split.Panel2Collapsed = true;
            split.Dock = DockStyle.Fill;
            split.Panel1.Controls.Add(code);
            split.Panel2.Controls.Add(documentMap);

            code.BackColor = Color.FromArgb(30, 30, 30);
            documentMap.BackColor = Color.FromArgb(30, 30, 30);
            code.ForeColor = Color.WhiteSmoke;
            code.TextChanging += Code_TextChanging;
            code.Load += Code_Load;
            code.Dock = DockStyle.Fill;


            ACmenu = new AutoForce(code);
            ACmenu.SetAutocompleteMenu(code, ACmenu);
            ACmenu.MinFragmentLength = 1;


            cms.Dock = DockStyle.Bottom;
            cms.BackColor = Color.FromArgb(63, 0, 135);
            cms.ForeColor = Color.WhiteSmoke;
        }

        private void Code_Load(object sender, EventArgs e)
        {
            RefreshCode();
            if (code.Lines.Count > linesForDocMap)
            {
                split.Panel2Collapsed = false;
            }
        }

        private void Code_TextChanging(object sender, FastColoredTextBoxNS.TextChangingEventArgs e)
        {
            if (code.Lines.Count > linesForDocMap)
            {
                split.Panel2Collapsed = false;
            }
        }

        public void RefreshCode()
        {
            // ACmenu.Items = File.ReadAllLines(Globals.SpecialKey + "spk-reserv.dict");
            ACmenu.autoForce();
        }
    }
}