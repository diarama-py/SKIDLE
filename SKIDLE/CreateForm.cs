using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKIDLE
{
    public partial class CreateForm : Form
    {
        string pathto;
        public bool Rename { get; set; }
        public CreateForm(string pathto)
        {
            InitializeComponent();
            this.pathto = pathto;
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {
           
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            try
            {
                if (Rename)
                {
                    RenameFileFolder();
                }
                else
                if (path.Text.Contains("."))
                {
                    File.Create(pathto + "\\" + path.Text).Close();
                    Cancel_Click(sender, e);
                }
                else
                {
                    Directory.CreateDirectory(pathto + "\\" + path.Text);
                    Cancel_Click(sender, e);
                }
            }
            catch
            {
                Cancel_Click(sender, e);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RenameFileFolder()
        {
            try
            {                
                if (pathto.Contains("."))
                {
                    FileInfo fi = new FileInfo(pathto);
                    File.Move(fi.FullName, fi.DirectoryName + "\\" +path.Text);
                    this.Close();
                }
                else
                {
                    FileInfo di = new FileInfo(pathto);
                    Directory.Move(di.FullName, di.FullName + "\\"  + path.Text);
                    this.Close();
                }
            }
            catch
            {
                this.Close();
            }
        }
    }
}
