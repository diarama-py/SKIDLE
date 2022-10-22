using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKIDLE.UserControls
{
    public class codeTab : Manina.Windows.Forms.Tab
    {
        HighLighting highLighting = new HighLighting();
        public FastCTBox code;
        public AutoForce ACmenu;
        public ContextMenuStrip cms;
        public int linesForDocMap = 150;
        FastColoredTextBoxNS.DocumentMap documentMap;
        private System.ComponentModel.IContainer components;
        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem cut;
        private ToolStripMenuItem copy;
        private ToolStripMenuItem paste;
        private ToolStripMenuItem find;
        private ToolStripMenuItem Igoto;
        private ToolStripMenuItem replace;
        SplitContainer split;
        public codeTab()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(codeTab));
            this.code = new SKIDLE.UserControls.FastCTBox();
            this.ACmenu = new AutoForce(code);
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.documentMap = new FastColoredTextBoxNS.DocumentMap();
            this.split = new System.Windows.Forms.SplitContainer();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cut = new System.Windows.Forms.ToolStripMenuItem();
            this.copy = new System.Windows.Forms.ToolStripMenuItem();
            this.paste = new System.Windows.Forms.ToolStripMenuItem();
            this.find = new System.Windows.Forms.ToolStripMenuItem();
            this.Igoto = new System.Windows.Forms.ToolStripMenuItem();
            this.replace = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.code)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
            this.split.Panel1.SuspendLayout();
            this.split.Panel2.SuspendLayout();
            this.split.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // code
            // 
            this.code.AutoCompleteBrackets = true;
            this.code.AutoCompleteBracketsList = new char[] {
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
            this.ACmenu.SetAutocompleteMenu(this.code, this.ACmenu);
            this.code.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
    "(?<range>:)\\s*(?<range>[^;]+);";
            this.code.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.code.BackBrush = null;
            this.code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.code.CharHeight = 14;
            this.code.CharWidth = 8;
            this.code.ContextMenuStrip = this.contextMenu;
            this.code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.code.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.code.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.code.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.code.IsReplaceMode = false;
            this.code.LineNumberColor = System.Drawing.Color.WhiteSmoke;
            this.code.Location = new System.Drawing.Point(0, 0);
            this.code.Name = "code";
            this.code.Paddings = new System.Windows.Forms.Padding(0);
            this.code.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.code.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("code.ServiceColors")));
            this.code.Size = new System.Drawing.Size(25, 0);
            this.code.TabIndex = 0;
            this.code.Zoom = 100;
            this.code.TextChanging += new System.EventHandler<FastColoredTextBoxNS.TextChangingEventArgs>(this.Code_TextChanging);
            this.code.Load += new System.EventHandler(this.Code_Load);
            // 
            // ACmenu
            // 
            this.ACmenu.AllowsTabKey = true;
            this.ACmenu.Colors = ((AutocompleteMenuNS.Colors)(resources.GetObject("ACmenu.Colors")));
            this.ACmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ACmenu.ImageList = null;
            this.ACmenu.Items = new string[0];
            this.ACmenu.TargetControlWrapper = null;
            // 
            // cms
            // 
            this.cms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(135)))));
            this.cms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cms.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(61, 4);
            // 
            // documentMap
            // 
            this.documentMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.documentMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentMap.ForeColor = System.Drawing.Color.Maroon;
            this.documentMap.Location = new System.Drawing.Point(0, 0);
            this.documentMap.Name = "documentMap";
            this.documentMap.Scale = 0.8F;
            this.documentMap.Size = new System.Drawing.Size(25, 0);
            this.documentMap.TabIndex = 0;
            this.documentMap.Target = this.code;
            // 
            // split
            // 
            this.split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split.Location = new System.Drawing.Point(0, 0);
            this.split.Name = "split";
            // 
            // split.Panel1
            // 
            this.split.Panel1.Controls.Add(this.code);
            // 
            // split.Panel2
            // 
            this.split.Panel2.Controls.Add(this.documentMap);
            this.split.Size = new System.Drawing.Size(0, 0);
            this.split.SplitterDistance = 25;
            this.split.TabIndex = 1;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cut,
            this.copy,
            this.paste,
            this.find,
            this.Igoto,
            this.replace});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(116, 136);
            // 
            // cut
            // 
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(115, 22);
            this.cut.Text = "Cut";
            this.cut.Click += Cut_Click;
            // 
            // copy
            // 
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(115, 22);
            this.copy.Text = "Copy";
            this.copy.Click += Copy_Click;
            // 
            // paste
            // 
            this.paste.Name = "paste";
            this.paste.Size = new System.Drawing.Size(115, 22);
            this.paste.Text = "Paste";
            this.paste.Click += Paste_Click;
            // 
            // find
            // 
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(115, 22);
            this.find.Text = "Find";
            this.find.Click += Find_Click;
            // 
            // Igoto
            // 
            this.Igoto.Name = "Igoto";
            this.Igoto.Size = new System.Drawing.Size(115, 22);
            this.Igoto.Text = "GoTo";
            this.Igoto.Click += Igoto_Click;
            // 
            // replace
            // 
            this.replace.Name = "replace";
            this.replace.Size = new System.Drawing.Size(115, 22);
            this.replace.Text = "Replace";
            this.replace.Click += Replace_Click;
            // 
            // codeTab
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.Controls.Add(this.split);
            this.ForeColor = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.code)).EndInit();
            this.split.Panel1.ResumeLayout(false);
            this.split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split)).EndInit();
            this.split.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void Igoto_Click(object sender, EventArgs e)
        {
            code.ShowGoToDialog();
        }

        private void Replace_Click(object sender, EventArgs e)
        {
            code.ShowReplaceDialog();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            code.ShowFindDialog();
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            code.Paste();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            code.Copy();
        }

        private void Cut_Click(object sender, EventArgs e)
        {
            code.Cut();
        }

        private void Code_Load(object sender, EventArgs e)
        {
            code.TextChanged += new EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(highLighting._HighLighting);
            
            RefreshCode();
            if (code.Lines.Count > linesForDocMap)
            {
                split.Panel2Collapsed = false;
            }
            else
            {
                split.Panel2Collapsed = true;
            }
        }

        private void Code_TextChanging(object sender, FastColoredTextBoxNS.TextChangingEventArgs e)
        {
            if (code.Lines.Count > linesForDocMap)
            {
                split.Panel2Collapsed = false;
            }
            else
            {
                split.Panel2Collapsed = true;
            }
        }

        public void RefreshCode()
        {
            Thread thread = new Thread(ACmenu.autoForce);
            thread.Start();
            code.TextChanged += new EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(highLighting._HighLighting);
        }
    }
    public class FastCTBox : FastColoredTextBoxNS.FastColoredTextBox
    {
        public FastCTBox()
        {
        }
        private Color linehighlightColor = Color.FromArgb(80, 80, 80);

        int lineh = 15;
        const int wm_paint = 15;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == wm_paint)
            {
                var selectlength = this.SelectionLength;
                var selectstart = this.SelectionStart;
                this.Invalidate();
                base.WndProc(ref m);
                if (selectlength > 0)
                {
                    return;
                }
                using (Graphics g = Graphics.FromHwnd(this.Handle))
                {
                    OnSelectionChanged();
                    Brush b = new SolidBrush(Color.FromArgb(50, linehighlightColor));
                    int fntsize = (int)this.Font.Size;
                    var line = this.PositionToPlace(selectstart);
                    var loc = this.PositionToPoint(this.PlaceToPosition(line));
                    g.FillRectangle(b, new Rectangle(loc, new Size(this.Width, lineh + fntsize - 6)));
                }
            }
            else
            {
                base.WndProc(ref m);
            }
        }
    }
}