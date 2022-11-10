using System;
using System.IO;

namespace SKIDLE.Libs
{
    internal class SpKeyLib
    {
        internal static string Run(string path)
        {
            try
            {
                FileInfo fi = new FileInfo(path);
                string[] code = File.ReadAllLines(path);
                if (code[0].Contains("#Add internal"))
                {
                    foreach(var line in code)
                    {
                        if (line.Contains("#"))
                        {
                            if (line.Contains("#out") && line.Contains(":") && line.Contains("\""))
                            {
                                return line.Split('"')[1] + "\n";
                            }
                            else if (line.Contains("#authors"))
                            {
                                return line.Split(' ')[1] + "\n";
                            }
                            else if (line.Contains("#err"))
                                return line + "\n";
                        }
                    }
                    return "\n0\n";
                }
            }
            catch
            {
                return "\nErrrrrorrrrr!!!!! Incorrect file or code\n";
            }
            return "";
        }
    }
}