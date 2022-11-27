using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKIDLE
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            ConfigFile config = new ConfigFile(Globals.User+"configure.conf");
            try { AssociationFile.SelfCreateAssociation(".spk", AssociationFile.KeyHiveSmall.ClassesRoot, "Special Key source code"); } catch { MessageBox.Show("RegNode not created", "error"); }
            if (config.GetProperty("SWLFOH") == "true")
            {
                if (args != null && args.Length > 0)
                {
                    if (args.Length == 1)
                    {
                        String file = args[0];
                        if (Path.GetExtension(file) == ".")
                        {
                            SWLFOH mf = new SWLFOH();
                            mf.LFFP(file);
                            Application.EnableVisualStyles();
                            Application.Run(mf);
                        }
                        else
                        {
                            SWLFOH mf = new SWLFOH();
                            mf.LFFP(args[0]);
                            Application.EnableVisualStyles();
                            Application.Run(mf);
                        }
                    }
                    else
                    {
                        SWLFOH mf = new SWLFOH();
                        mf.LFFP(args[0]);
                        Application.EnableVisualStyles();
                        Application.Run(mf);

                    }
                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new SWLFOH());
                }
            }
            else
            {
                if (args != null && args.Length > 0)
                {
                    if (args.Length == 1)
                    {
                        String file = args[0];
                        if (Path.GetExtension(file) == ".")
                        {
                            skidle mf = new skidle();
                            mf.LoadCFA(file);
                            Application.EnableVisualStyles();
                            Application.Run(mf);
                        }
                        else
                        {
                            skidle mf = new skidle();
                            mf.LoadFCMD(args);
                            Application.EnableVisualStyles();
                            Application.Run(mf);
                        }
                    }
                    else
                    {
                        skidle mf = new skidle();
                        mf.LoadFCMD(args);
                        Application.EnableVisualStyles();
                        Application.Run(mf);

                    }
                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new skidle());
                }
            }
        }
    }
}
