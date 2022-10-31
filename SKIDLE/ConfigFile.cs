using System.Collections.Generic;
using System.IO;

namespace SKIDLE
{
    public class ConfigFile
    {
        string file;
        public ConfigFile(string file) // получаем файл
        {
            this.file = file;
        }

        public string GetComment(string title)
        {
            if (File.Exists(file))
            {
                foreach(var line in File.ReadAllLines(file))
                {
                    if (line.Contains("[" + title + ":"))
                    {
                        return line.Split(':')[1].TrimEnd(']');
                    }
                }
            }
            return title;
        }
        public string GetProperty(string property)
        {
            if (File.Exists(file))
            {
                foreach (var line in File.ReadAllLines(file))
                {
                    if (line.Contains(property))
                        return line.Split(':')[1].Trim(' ','"');
                }
            }
            else return "file not found";
            return property;
        }

        public string GetListProperty(string tagname, int value)
        {
            string prop = "";
            if (File.Exists(file))
            {             
                foreach (var line in File.ReadAllLines(file))
                {
                    if (line.Contains(tagname + ":" + value.ToString()) && value > 0)
                    {
                        prop = line.Split(':')[3].Trim(' ', '"');
                    }
                }
            }
            return prop;
        }

        public void SetProperty(string property,string name)
        {
            if (File.Exists(file))
            {
                string check = property + ":" + "\"" + name + "\"";
                string content = File.ReadAllText(file);

                if (content.Contains(check))
                {
                    ReProperty(property, name);
                }
                else
                {
                    string newcontent = content + "\n" + check;
                    File.WriteAllText(file, newcontent);
                }
            }
        }   
        public void ReProperty(string property,string newname)
        {
            if (File.Exists(file))
            {
                foreach(var line in File.ReadAllLines(file))
                {
                    if (line.Contains(property))
                    {
                        string content = File.ReadAllText(file);
                        string propname = line.Split(':')[1].Trim(' ', '"');
                        string reline = property + ":" +"\""+ propname.Replace(propname, newname) + "\"";
                        string newcontent = content.Replace(line,reline);
                        File.WriteAllText(file, newcontent);
                    }
                    else { }
                }
            }
        }
    }
}
