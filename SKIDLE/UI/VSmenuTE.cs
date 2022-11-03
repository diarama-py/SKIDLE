using System;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SKIDLE.UI.VS
{
    public class VSContextMenuStripTE : ContextMenuStrip
    {
        [Browsable(true)]
        public int gWidth;
        public int gHeight;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
          (
              int nLeftRect,     // x-coordinate of upper-left corner
              int nTopRect,      // y-coordinate of upper-left corner
              int nRightRect,    // x-coordinate of lower-right corner
              int nBottomRect,   // y-coordinate of lower-right corner
              int nWidthEllipse, // width of ellipse
              int nHeightEllipse // height of ellipse
          );


        public VSContextMenuStripTE()
        {
            this.RenderMode = ToolStripRenderMode.Professional;
            gWidth = 110;
            gHeight = 135;
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, gWidth, gHeight, 12, 12));
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // VSContextMenuStrip
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.VSContextMenu_Paint);
            this.ResumeLayout(false);

        }

        private void VSContextMenu_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);
        }
    }
}
