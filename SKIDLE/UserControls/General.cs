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
        ConfigFile config;
        public General()
        {
            InitializeComponent();
            pathToSPK.CustomButton.Click += OkPathSPK;
            config = new ConfigFile("configure.conf");
            pathToSPK.Text = config.GetProperty("compilerPK");
        }

        private void OkPathSPK(object sender, EventArgs e)
        {
            config.SetProperty("compilerSPK", pathToSPK.Text);
        }

        private void themeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (themeComboBox.SelectedItem.ToString() == "Dark")
                config.ReProperty("theme", "dark");
            else
                config.ReProperty("theme", "light");
        }
    }
}
