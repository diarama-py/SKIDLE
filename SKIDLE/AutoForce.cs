using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIDLE
{
    public class AutoForce : AutocompleteMenuNS.AutocompleteMenu
    {
        FastColoredTextBoxNS.FastColoredTextBox code = new FastColoredTextBoxNS.FastColoredTextBox();
        public AutoForce(FastColoredTextBoxNS.FastColoredTextBox code)
        {
            this.code = code;
        }

        public void autoForce()
        {
            List<String> keywords = new List<string>();
            List<String> key = new List<string>();
            IList<string> lines = code.Lines;

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
            for (int i = 0; i < lines.Count; i++)
            {
                try
                {
                    for (int z = 0; z < key.Count; z++)
                    {
                        if (lines[i].Contains(key[z]))
                        {
                            string q = lines[i].Trim(' ', '(', ')');
                            q = q.Split(' ')[1];
                            q = q.Split('=', '(', ')', ' ', '{', '}')[0];
                            keywords.Add(q);
                        }

                    }
                }
                catch { }
            }

            foreach (var item in Directory.GetFiles(Globals.SpecialKey + "modules\\", "*spk"))
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

            for (int i = 0; i < keywords.Count; i++)
            {
                this.AddItem(keywords[i]);
            }
        }
    }
}
