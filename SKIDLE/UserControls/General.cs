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
            pathToSPK.CustomButton.Click += OkPathSPK;
            ConfigFile config = new ConfigFile("configure.conf");
            pathToSPK.Text = config.GetProperty("pathtoSPK");
        }

        private void OkPathSPK(object sender, EventArgs e)
        {
            ConfigFile config = new ConfigFile("configure.conf");
            config.SetProperty("pathtoSPK", pathToSPK.Text);
        }
    }
}
