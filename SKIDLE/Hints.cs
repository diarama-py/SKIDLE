using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKIDLE
{
    public class Hints
    {
        public UserControls.FastCTBox code { get; set; }
        public Hints()
        {
            code = new UserControls.FastCTBox();
        }

        public void AddHint(string source,string hint)
        {
           
        }
    }
}
