using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKIDLE.CrossFormsDesigner
{
    public partial class Demo : UserControl
    {
        public Demo()
        {
            InitializeComponent();
            TitleForm.Text = this.Text;
        }

        private void titleBorder_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
