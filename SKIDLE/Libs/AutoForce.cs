using FastColoredTextBoxNS;
using SKIDLE.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SKIDLE
{
    public class AutoForce : AutocompleteMenuNS.AutocompleteMenu
    {
        FastCTBox code;
        public AutoForce(FastCTBox code)
        {
            this.code = code;
        }

        public void autoForce()
        {
            this.Items = null;
            this.MinFragmentLength = 1;
            List<String> keywords = new List<string>();
            List<String> key = new List<string>();
            IList<string> lines = code.Lines;

           
            for (int i = 0; i < keywords.Count; i++)
            {
                this.AddItem(keywords[i]);
            }
        }
    }
}