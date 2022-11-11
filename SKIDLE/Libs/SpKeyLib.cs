using System;
using SKIDLE.UserControls;
using System.IO;

namespace SKIDLE.Libs
{
    internal class SpKeyLib
    {
        internal static void Run(string path, SKIDLE.UserControls.Console console)
        {
            try
            {
                FileInfo fi = new FileInfo(path);
                string[] code = File.ReadAllLines(path);
                foreach (var line in code)
                {
                    if (File.ReadAllLines(path)[0].Contains("#Add internal"))
                    {
                        if (line.Contains("#"))
                        {
                            if (line.Contains("#out") && line.Contains(":") && line.Contains("\""))
                            {
                                console.WriteLine("@"+line.Split('"')[1] + "\n");
                            }
                            else if (line.Contains("#authors"))
                            {
                                console.WriteLine("@"+line.Split(' ')[1] + "\n");
                            }
                            else if (line.Contains("#err"))
                                console.WriteLine("@"+line + "\n");
                        }
                    }
                }
                console.WriteLine("\n0\n");
               
            }
            catch
            {
                console.WriteLine("\nErrrrrorrrrr!!!!! Incorrect file or code\n");
            }
        }
    }
}