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
    public partial class StructureControl : UserControl
    {
        public FastCTBox code  { get; set; }
        public StructureControl()
        {
            InitializeComponent();           
        }

        private void StructureControl_Load(object sender, EventArgs e)
        {
            treeView.ImageList = icons;
        }

        public void LoadStructure()
        {
            treeView.Nodes.Clear();
            string name = null;
            int index = 0;
            foreach (var line in code.Lines)
            {
                try
                {
                    if (line.Contains("var") | line.Contains("class") | line.Contains("fun") | line.Contains("enum"))
                    {
                        name = line.Split(' ')[1].Split('=', '(', '[', '{')[0].Trim(' ');
                        if (line.Contains("var"))
                        {
                            index = 1;
                        }
                        else
                       if (line.Contains("class"))
                        {
                            index = 0;
                        }
                        else
                        if (line.Contains("fun"))
                        {
                            index = 2;
                        }
                        else
                        if (line.Contains("enum"))
                        {
                            index = 4;
                        }
                        var nody = treeView.Nodes.Add(name, name, index, index);
                        nody.Tag = name;
                    }
                }
                catch { }
            }        
        }

        public async void AsyncLoadStructure()
        {
            await Task.Run(() =>
            {
               
                foreach (var line in code.Lines)
                {
                    try
                    {
                        treeView.Nodes.Clear();
                        string name = null;
                        int index = 0;
                        if (line.Contains("var") | line.Contains("class") | line.Contains("fun") | line.Contains("enum"))
                        {
                            name = line.Split(' ')[1].Split('=', '(', '[', '{')[0].Trim(' ');
                            if (line.Contains("var"))
                            {
                                index = 1;
                            }
                            else
                           if (line.Contains("class"))
                            {
                                index = 0;
                            }
                            else
                            if (line.Contains("fun"))
                            {
                                index = 2;
                            }
                            else
                            if (line.Contains("enum"))
                            {
                                index = 4;
                            }
                            var nody = treeView.Nodes.Add(name, name, index, index);
                            nody.Tag = name;
                        }
                    }
                    catch { }
                }             
            });
        }
    }
}
