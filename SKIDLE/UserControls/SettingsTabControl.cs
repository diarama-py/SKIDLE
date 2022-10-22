using System;
using System.Windows.Forms;

namespace SKIDLE.UserControls
{
    public partial class SettingsTabControl : UserControl
    {
        General Igeneral = new General();
        TextEditor ItextEditor = new TextEditor();
        About Iabout = new About();
        public SettingsTabControl()
        {
            InitializeComponent();
        }

        private void general_Click(object sender, EventArgs e)
        {
            if (main.Controls.Count == 0 || main.Controls.Contains(Iabout) || main.Controls.Contains(ItextEditor))
            {
                Igeneral.Dock = DockStyle.Fill;
                main.Controls.Add(Igeneral);
                main.Controls.Remove(Iabout);
                main.Controls.Remove(ItextEditor);
            }
            else
            {
                main.Controls.Remove(Igeneral);
            }
        }

        private void txteditor_Click(object sender, EventArgs e)
        {
            if (main.Controls.Count == 0 || main.Controls.Contains(Iabout) || main.Controls.Contains(Igeneral))
            {
                ItextEditor.Dock = DockStyle.Fill;
                main.Controls.Add(ItextEditor);
                main.Controls.Remove(Iabout);
                main.Controls.Remove(Igeneral);
            }
            else
            {
                main.Controls.Remove(ItextEditor);
            }
        }

        private void about_Click(object sender, EventArgs e)
        {
            if (main.Controls.Count == 0 || main.Controls.Contains(ItextEditor) || main.Controls.Contains(Igeneral))
            {
                Iabout.Dock = DockStyle.Fill;
                main.Controls.Add(Iabout);
                main.Controls.Remove(ItextEditor);
                main.Controls.Remove(Igeneral);
            }
            else
            {
                main.Controls.Remove(Iabout);
            }
        }

        private void SettingsTabControl_Load(object sender, EventArgs e)
        {
            Iabout.Dock = DockStyle.Fill;
            main.Controls.Add(Iabout);
        }
    }
}
