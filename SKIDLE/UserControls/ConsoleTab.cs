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
    public partial class ConsoleTab : Manina.Windows.Forms.Tab
    {
        public ConsoleTab()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(16,16,16);
            CreateConsole();
        }
        private async void CreateConsole()
        {
            await Task.Run(() => {
                bool stop = false;
                string text = "";
                do
                {
                    console.WriteLine("&> ");
                    text = console.ReadLine();
                    console.Command(text);
                    this.Text = text;
                } while (text != "" && stop != true);

            });
        }
    }
}
