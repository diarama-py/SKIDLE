using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SKIDLE
{
    public class AutoForce : AutocompleteMenuNS.AutocompleteMenu
    {
        public AutoForce()
        { 
        }

        public void autoForce(FastColoredTextBoxNS.FastColoredTextBox code)
        {
            this.MinFragmentLength = 1;
            List<String> keywords = new List<string>();
            List<String> key = new List<string>();

            string file = Globals.SpecialKey + "spk-reserv.dict";
            string dict = Globals.SpecialKey + "autoforce.dict";
            foreach (var Ikey in File.ReadAllLines(file))
            {
                string line = Ikey.Trim(' ');
                this.AddItem(line);
            }
            foreach (var Ikey in File.ReadAllLines(dict))
            {
                string line = Ikey.Trim(' ');
                key.Add(line);
            }
            foreach (var line in code.Lines)
            {
                try
                {
                    foreach (var Ikey in key)
                    {                   
                        if (line.Contains(Ikey))
                        {
                            string q = line.Trim(' ', '(', ')');
                            q = q.Split(' ')[1];
                            q = q.Split('=', '(', ')', ' ', '{', '}')[0];
                            keywords.Add(q);
                        }
                    }
                }
                catch{}
            }

            foreach (var item in Directory.GetFiles(Globals.SpecialKey + "modules\\", "*.spk"))
            {
                FileInfo fi = new FileInfo(item);
                string dfName = fi.Name.Split(".spk"[0])[0];

                if (code.Text.Contains("Add " + dfName))
                {
                    List<string> LinesFromFile = new List<string>(File.ReadAllLines(item));

                    for (int i = 0; i < LinesFromFile.Count; i++)
                    {
                        try
                        {
                            for (int z = 0; z < key.Count; z++)
                            {
                                if (LinesFromFile[i].Contains(key[z]))
                                {
                                    string q = LinesFromFile[i].Trim(' ', '(', ')');
                                    q = q.Split(' ')[1];
                                    q = q.Split('=', '(', ')', ' ', '{', '}')[0];
                                    keywords.Add(q);
                                }

                            }
                        }
                        catch { }
                    }
                }
            }

            foreach(var item in keywords)
            {
                this.AddItem(item);
            }
        }
    }
}
