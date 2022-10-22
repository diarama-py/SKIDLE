using System.IO;

namespace SKIDLE
{
    public class ConfigFile
    {
        string file;
        public ConfigFile(string file)
        {
            this.file = file;
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

        public void SetProperty(string property,string name)
        {
            if (File.Exists(file))
            {
                string content = File.ReadAllText(file);
                string newcontent = content + "\n" + property + ":" +"\""+ name+"\"";
                File.WriteAllText(file, newcontent);
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
