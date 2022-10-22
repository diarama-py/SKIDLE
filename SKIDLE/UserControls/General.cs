using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKIDLE.UserControls
{
    public partial class General : UserControl
    {
        public General()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfigFile cf = new ConfigFile("configure.conf");
            button1.Text = cf.GetProperty("general");
            cf.SetProperty("hi","Derpy");
            button1.Text = cf.GetProperty("hi");
        }
    }
}
