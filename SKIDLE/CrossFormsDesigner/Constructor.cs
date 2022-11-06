using SKIDLE.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace SKIDLE.CrossFormsDesigner
{
    public partial class Constructor : UserControl
    {
        /// <summary>
        /// Controls for properties
        /// </summary>
        List<Control> controls = new List<Control>();
        int num = 0; //number for new added control
        public Constructor()
        {
            InitializeComponent();
        }
        private void Constructor_Load(object sender, EventArgs e)
        {
           
        }

        public void LoadCFML(string file)
        {
            if(file != "")
            {
                using (XmlTextReader reader = new XmlTextReader(file))
                {
                    while (reader.Read())
                    {
                        if (reader.IsStartElement())
                        {
                            try
                            {
                                switch (reader.Name.ToString())
                                {
                                    //settings
                                    case "title":
                                        demo1.TitleForm.Text = reader.ReadString();
                                        break;
                                    case "width":
                                        demo1.Width = int.Parse(reader.ReadString());
                                        break;
                                    case "height":
                                        demo1.Height = int.Parse(reader.ReadString());
                                        break;
                                    // controls
                                    //label
                                    case "label":
                                        Label label = new Label();
                                        label.ForeColor = Color.Black;
                                        if (reader.HasAttributes)
                                        {
                                            while (reader.MoveToNextAttribute())
                                            {
                                                label.Location = new Point(int.Parse(reader.GetAttribute("x")), int.Parse(reader.GetAttribute("y")));
                                                label.Size = new Size(int.Parse(reader.GetAttribute("width")), int.Parse(reader.GetAttribute("height")));
                                                label.Name = reader.GetAttribute("id") + ";;Label";
                                                label.Text = reader.ReadString();
                                                ControlDAD(label);
                                                controls.Add(label);
                                            }
                                        }
                                        demo1.window.Controls.Add(label);
                                        break;
                                    //button
                                    case "button":
                                        Button button = new Button();
                                        button.ForeColor = Color.Black;
                                        if (reader.HasAttributes)
                                        {
                                            while (reader.MoveToNextAttribute())
                                            {
                                                button.Location = new Point(int.Parse(reader.GetAttribute("x")), int.Parse(reader.GetAttribute("y")));
                                                button.Size = new Size(int.Parse(reader.GetAttribute("width")), int.Parse(reader.GetAttribute("height")));
                                                button.Name = reader.GetAttribute("id") + ";" + reader.GetAttribute("click") + ";Button";
                                                button.Text = reader.ReadString();
                                                ControlDAD(button);
                                                controls.Add(button);
                                            }
                                        }
                                        demo1.window.Controls.Add(button);
                                        break;
                                    //combobox
                                    case "combobox":
                                        ComboBox combobox = new ComboBox();
                                        combobox.ForeColor = Color.Black;
                                        if (reader.HasAttributes)
                                        {
                                            while (reader.MoveToNextAttribute())
                                            {
                                                //combobox.SelectedIndex = int.Parse(reader.GetAttribute("base"));
                                                combobox.Location = new Point(int.Parse(reader.GetAttribute("x")), int.Parse(reader.GetAttribute("y")));
                                                combobox.Size = new Size(int.Parse(reader.GetAttribute("width")), int.Parse(reader.GetAttribute("height")));
                                                combobox.Name = reader.GetAttribute("id") + ";;ComboBox";
                                                combobox.Items.Clear();
                                                ControlDAD(combobox);
                                                controls.Add(combobox);
                                                combobox.Items.AddRange(reader.GetAttribute("list").Split(';'));
                                            }
                                        }
                                        demo1.window.Controls.Add(combobox);
                                        break;
                                }
                            }
                            catch { }
                        }
                    }
                }
                ini();
                all.Controls.Clear();
                controls.Add(demo1);
            }
        }

        private void ini()
        {
            demo1.Text = demo1.TitleForm.Text;
            LabelWidht.Text = demo1.Width.ToString();
            LabelHeight.Text = demo1.Height.ToString();
            demo1.Name = demo1.Name + ";;CrossForm";
        }
        private void Controlini(Control control)
        {
            TextLabel.Text = control.Text;
            LabelID.Text = control.Name.Split(';')[0];
            LabelWidht.Text = control.Width.ToString();
            LabelHeight.Text = control.Height.ToString();
            LabelPosX.Text = control.Location.X.ToString();
            LabelPosY.Text = control.Location.Y.ToString();
            OnClickProp.Text = control.Name.Split(';')[1];
            Type.Text = "Type: " + control.Name.Split(';')[2];
        }
        private void ControlDAD(Control control)
        {
            demo1.window.AllowDrop = true;
            demo1.window.DragDrop += Control_DragDrop;
            demo1.window.DragOver += Control_DragOver;
            control.MouseDown += c_MouseDown;

            void c_MouseDown(object sender, MouseEventArgs e)
            {
                Control c = sender as Control;
                c.DoDragDrop(c, DragDropEffects.Move);
            }

            void Control_DragDrop(object sender, DragEventArgs e)
            {
                Control c = e.Data.GetData(e.Data.GetFormats()[0]) as Control;
                if (c != null)
                {
                    c.Location = this.demo1.window.PointToClient(new Point(e.X, e.Y));
                    this.demo1.window.Controls.Add(c);
                }
            }
            void Control_DragOver(object sender, DragEventArgs e)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void ControlsBox_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (var item in controls)
            {
                if(item.Name.Contains(";"))
                {
                    if(ControlsBox.SelectedItem.ToString() == item.Name.Split(';')[0])
                    {
                        all.Controls.Clear();
                        LabelProp.Dock = DockStyle.Fill;
                        all.Controls.Add(properties);
                        all.Controls.Add(LabelProp);
                        Controlini(item);
                    }
                }
            }
        }


        private void elements_SelectedValueChanged(object sender, EventArgs e)
        {
            if (elements.SelectedItem.ToString() == "Label")
            {
                ControlsBox.Items.Clear();
                num++;
                Label l = new Label();
                l.Name = "test" + num + ";;"+ "Label";
                l.Text = "label" + num;
                l.ForeColor = Color.Black;
                l.Location = new Point(67, 67);
                ControlDAD(l);
                controls.Add(l);
                demo1.window.Controls.Add(l);
            }
            else if (elements.SelectedItem.ToString() == "Button")
            {
                ControlsBox.Items.Clear();
                num++;
                Button b = new Button();
                b.Name = "Button" + num + ";;" + "Button";
                b.Text = "Button" + num;
                b.ForeColor = Color.Black;
                b.Location = new Point(67, 67);
                ControlDAD(b);
                controls.Add(b);
                demo1.window.Controls.Add(b);
            }
            else if (elements.SelectedItem.ToString() == "ComboBox")
            {
                ControlsBox.Items.Clear();
                num++;
                ComboBox combo = new ComboBox();
                combo.Name = "ComboBox" + num + ";;" + "ComboBox";
                combo.Text = "ComboBox" + num;
                combo.ForeColor = Color.Black;
                combo.Location = new Point(67, 67);
                ControlDAD(combo);
                controls.Add(combo);
                demo1.window.Controls.Add(combo);
            }
        }

        private void ControlsBox_DropDown(object sender, EventArgs e)
        {
            ControlsBox.Items.Clear();
            foreach (var item in controls)
                if (item.Name.Contains(";"))
                    ControlsBox.Items.Add(item.Name.Split(';')[0]);
                else
                    ControlsBox.Items.Add(item.Name);
        }

        private void TextLabel_TextChanged(object sender, EventArgs e)
        {
            foreach (Control item in controls)
            {
                if (ControlsBox.SelectedItem.ToString() == item.Name.Split(';')[0])
                {
                    item.Text = TextLabel.Text;
                    if (Type.Text.Contains("CrossForm"))
                    {
                        XDocument xml = XDocument.Load(Application.StartupPath + "\\explame.cfml");
                        foreach (XElement el in xml.Element("window").Elements("settings"))
                        {
                            try
                            {
                                XAttribute xa = el.Attribute("title");
                                xa.SetValue(TextLabel.Text);
                            }
                            catch { }
                        }
                    }
                }
            }
            demo1.Invalidate();
        }

        private void LabelWidht_TextChanged(object sender, EventArgs e)
        {
            foreach (Control item in controls)
            {
                try
                {
                    if (ControlsBox.SelectedItem.ToString() == item.Name.Split(';')[0])
                    {
                        item.Width = int.Parse(LabelWidht.Text);
                    }
                }
                catch { }
            }
            demo1.Invalidate();
        }

        private void LabelHeight_TextChanged(object sender, EventArgs e)
        {
            foreach (Control item in controls)
            {
                try
                {
                    if (ControlsBox.SelectedItem.ToString() == item.Name.Split(';')[0])
                    {
                        item.Height = int.Parse(LabelHeight.Text);
                    }
                }
                catch { }
            }
            demo1.Invalidate();
        }

        private void LabelPosX_TextChanged(object sender, EventArgs e)
        {
            foreach (Control item in controls)
            {
                try
                {
                    if (ControlsBox.SelectedItem.ToString() == item.Name.Split(';')[0])
                    {
                        item.Location = new Point(int.Parse(LabelPosX.Text), item.Location.Y);
                    }
                }
                catch { }
            }
            demo1.Invalidate();
        }

        private void LabelPosY_TextChanged(object sender, EventArgs e)
        {
            foreach (Control item in controls)
            {
                try
                {
                    if (ControlsBox.SelectedItem.ToString() == item.Name.Split(';')[0])
                    {
                        item.Location = new Point(item.Location.X, int.Parse(LabelPosX.Text));
                    }
                }
                catch { }
            }
            demo1.Invalidate();
        }

        private void LabelID_TextChanged(object sender, EventArgs e)
        {
            foreach (Control item in controls)
            {
                if (ControlsBox.SelectedItem.ToString() == item.Name.Split(';')[0])
                {
                    item.Name = LabelID.Text;
                }
            }
            demo1.Invalidate();
        }

        private void OnClickProp_TextChanged(object sender, EventArgs e)
        {
            foreach (Control item in controls)
            {
                if (ControlsBox.SelectedItem.ToString() == item.Name.Split(';')[0])
                {
                    item.Name = LabelID.Text + ";"+ OnClickProp.Text;
                }
            }
            demo1.Invalidate();
        }
    }

    public class TabConstructor : Manina.Windows.Forms.Tab
    {
        public Constructor con = new Constructor();
        public TabConstructor()
        {            
            this.BackColor = Color.FromArgb(63,0,123);
            con.Dock = DockStyle.Fill;
            this.Controls.Add(con);
        }
    }
}
