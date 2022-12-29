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
            Theme(Globals.themes+new ConfigFile(Globals.User+"configure.conf").GetProperty("theme"));
        }

        private void general_Click(object sender, EventArgs e)
        {
            if (main.Controls.Count == 1 || main.Controls.Contains(Iabout) || main.Controls.Contains(ItextEditor))
            {
                Igeneral.Dock = DockStyle.Fill;
                main.Controls.Add(Igeneral);
                main.Controls.Remove(Iabout);
                main.Controls.Remove(ItextEditor);
                main.Controls.Remove(title);
            }
            else
            {
                main.Controls.Remove(Igeneral);
                main.Controls.Add(title);
            }
            Theme(Globals.themes + new ConfigFile(Globals.User + "configure.conf").GetProperty("theme"));
        }

        private void txteditor_Click(object sender, EventArgs e)
        {
            Theme(Globals.themes + new ConfigFile(Globals.User + "configure.conf").GetProperty("theme"));
            if (main.Controls.Count == 1 || main.Controls.Contains(Iabout) || main.Controls.Contains(Igeneral))
            {
                ItextEditor.Dock = DockStyle.Fill;
                main.Controls.Add(ItextEditor);
                main.Controls.Remove(Iabout);
                main.Controls.Remove(Igeneral);
                main.Controls.Remove(title);
            }
            else
            {
                main.Controls.Remove(ItextEditor);
                main.Controls.Add(title);
            }
            Theme(Globals.themes + new ConfigFile(Globals.User + "configure.conf").GetProperty("theme"));
        }

        private void about_Click(object sender, EventArgs e)
        {
            Theme(Globals.themes + new ConfigFile(Globals.User + "configure.conf").GetProperty("theme"));
            if (main.Controls.Count == 1 || main.Controls.Contains(ItextEditor) || main.Controls.Contains(Igeneral))
            {
                Iabout.Dock = DockStyle.Fill;
                main.Controls.Add(Iabout);
                main.Controls.Remove(ItextEditor);
                main.Controls.Remove(Igeneral);
                main.Controls.Remove(title);

            }
            else
            {
                main.Controls.Remove(Iabout);
                main.Controls.Add(title);
            }
            Theme(Globals.themes + new ConfigFile(Globals.User + "configure.conf").GetProperty("theme"));
        }

        private void SettingsTabControl_Load(object sender, EventArgs e)
        {
            ver.Text = Application.ProductVersion + " " + Application.CompanyName;
            Iabout.Dock = DockStyle.Fill;
            main.Controls.Add(Iabout);
            main.Controls.Remove(title);
            Theme(Globals.themes + new ConfigFile(Globals.User + "configure.conf").GetProperty("theme"));
        }

        private void Theme(string data)
        {
            ConfigFile c = new ConfigFile(data);
            main.BackColor = c.GetColor("BackColor");
            main.ForeColor = c.GetColor("ForeColor");
            leftPanel.BackColor = c.GetColor("BackColor");
            leftPanel.ForeColor = c.GetColor("ForeColor");
            foreach(Control p in main.Controls)
            {
                p.BackColor = c.GetColor("BackColor");
                p.ForeColor = c.GetColor("ForeColor");
                foreach (Control r in p.Controls)
                {
                    r.BackColor = c.GetColor("BackColor");
                    r.ForeColor = c.GetColor("ForeColor");
                    foreach (Control t in p.Controls)
                    {
                        t.BackColor = c.GetColor("BackColor");
                        t.ForeColor = c.GetColor("ForeColor");
                    }
                }
            }
            foreach (Control p in leftPanel.Controls)
            {
                p.BackColor = c.GetColor("BackColor");
                p.ForeColor = c.GetColor("ForeColor");
                foreach (Control r in p.Controls)
                {
                    r.BackColor = c.GetColor("BackColor");
                    r.ForeColor = c.GetColor("ForeColor");
                }
            }
        }
    }
}
