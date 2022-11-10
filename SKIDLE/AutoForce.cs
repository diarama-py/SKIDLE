using FastColoredTextBoxNS;
using SKIDLE.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;

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

            string file = Globals.SpecialKey + "spk-reserv.dict";
            string stl = Globals.SpecialKey + "stl-base.dict";
            string zip = Globals.SpecialKey + "zip-base.dict";
            string json = Globals.SpecialKey + "json-base.dict";
            string spkunit = Globals.SpecialKey + "spkunit-base.dict";
            string canvasAPI = Globals.SpecialKey + "canvasAPI.dict";
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

            foreach(var item in Directory.GetFiles(Globals.SpecialKey + "modules\\", "*spk"))
            {
                FileInfo fi = new FileInfo(item);
                string name = fi.Name.Split(".spk"[0])[0];
                keywords.Add(name);
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
            if (code.Text.Contains("Add stl"))
            {
                foreach (var Ikey in File.ReadAllLines(stl))
                {
                    string line = Ikey.Trim(' ');
                    this.AddItem(line);
                }
            }
            if (code.Text.Contains("Add zip"))
            {
                foreach (var Ikey in File.ReadAllLines(zip))
                {
                    string line = Ikey.Trim(' ');
                    this.AddItem(line);
                }
            }
            if (code.Text.Contains("Add json"))
            {
                foreach (var Ikey in File.ReadAllLines(json))
                {
                    string line = Ikey.Trim(' ');
                    this.AddItem(line);
                }
            }
            if(code.Text.Contains("Add spkunit"))
            {
                foreach (var Ikey in File.ReadAllLines(spkunit))
                {
                    string line = Ikey.Trim(' ');
                    this.AddItem(line);
                }
            }
            if (code.Text.Contains("Add CanvasAPI"))
            {
                foreach (var Ikey in File.ReadAllLines(canvasAPI))
                {
                    string line = Ikey.Trim(' ');
                    this.AddItem(line);
                }
            }

            for (int i = 0; i < keywords.Count; i++)
            {
                this.AddItem(keywords[i]);
            }
        }
    }
}