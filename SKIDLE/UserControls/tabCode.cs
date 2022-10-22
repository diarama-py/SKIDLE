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
        HighLighting highLighting = new HighLighting();
        public FastCTBox code;
        public AutoForce ACmenu;
        public ContextMenuStrip cms;
        public int linesForDocMap = 150;
        FastColoredTextBoxNS.DocumentMap documentMap;
        private System.ComponentModel.IContainer components;
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
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.documentMap = new FastColoredTextBoxNS.DocumentMap();
            this.split = new System.Windows.Forms.SplitContainer();
            this.ACmenu = new AutoForce(code);
            ((System.ComponentModel.ISupportInitialize)(this.code)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
            this.split.Panel1.SuspendLayout();
            this.split.Panel2.SuspendLayout();
            this.split.SuspendLayout();
            this.SuspendLayout();
            // 
            // code
            // 
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
            this.ACmenu.SetAutocompleteMenu(this.code, null);
            this.code.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
    "(?<range>:)\\s*(?<range>[^;]+);";
            this.code.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.code.BackBrush = null;
            this.code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.code.CharHeight = 14;
            this.code.CharWidth = 8;
            this.code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.code.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.code.Font = new System.Drawing.Font("Courier New", 9.75F);
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
            this.documentMap.Size = new System.Drawing.Size(96, 100);
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
            // ACmenu
            // 
            this.ACmenu.Colors = ((AutocompleteMenuNS.Colors)(resources.GetObject("ACmenu.Colors")));
            this.ACmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ACmenu.ImageList = null;
            this.ACmenu.Items = new string[0];
            this.ACmenu.TargetControlWrapper = null;
            this.ACmenu.AllowsTabKey = true;
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
            this.ResumeLayout(false);

        }

        private void Code_Load(object sender, EventArgs e)
        {
            code.TextChanged += new EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(highLighting._HighLighting);
            ACmenu.SetAutocompleteMenu(code, ACmenu);
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
            // ACmenu.Items = File.ReadAllLines(Globals.SpecialKey + "spk-reserv.dict");
            ACmenu.autoForce();
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