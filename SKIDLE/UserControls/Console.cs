using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKIDLE.UserControls
{
    public class Console : FastColoredTextBox
    {
        private volatile bool isReadLineMode;
        private volatile bool isUpdating;

        public Console()
        {
        }

        private Place StartReadPlace { get; set; }

        /// <summary>
        /// Control is waiting for line entering. 
        /// </summary>
        public bool IsReadLineMode
        {
            get { return isReadLineMode; }
            set { isReadLineMode = value; }
        }

        /// <summary>
        /// Append line to end of text.
        /// </summary>
        /// <param name="text"></param>
        public void WriteLine(string text)
        {
            IsReadLineMode = false;
            isUpdating = true;
            try
            {
                AppendText(text);
                GoEnd();
            }
            finally
            {
                isUpdating = false;
                ClearUndo();
            }
        }

        /// <summary>
        /// Wait for line entering.
        /// Set IsReadLineMode to false for break of waiting.
        /// </summary>
        /// <returns></returns>
        public string ReadLine()
        {
            GoEnd();
            StartReadPlace = Range.End;
            IsReadLineMode = true;
            try
            {
                while (IsReadLineMode)
                {
                    Application.DoEvents();
                    Thread.Sleep(5);
                }
            }
            finally
            {
                IsReadLineMode = false;
                ClearUndo();
            }

            return new Range(this, StartReadPlace, Range.End).Text.TrimEnd('\r', '\n');
        }

        public override void OnTextChanging(ref string text)
        {
            if (!IsReadLineMode && !isUpdating)
            {
                text = ""; //cancel changing
                return;
            }

            if (IsReadLineMode)
            {
                if (Selection.Start < StartReadPlace || Selection.End < StartReadPlace)
                    GoEnd();//move caret to entering position

                if (Selection.Start == StartReadPlace || Selection.End == StartReadPlace)
                    if (text == "\b") //backspace
                    {
                        text = ""; //cancel deleting of last char of readonly text
                        return;
                    }

                if (text != null && text.Contains('\n'))
                {
                    text = text.Substring(0, text.IndexOf('\n') + 1);
                    IsReadLineMode = false;
                }
            }

            base.OnTextChanging(ref text);
        }

        public override void Clear()
        {
            var oldIsReadMode = isReadLineMode;

            isReadLineMode = false;
            isUpdating = true;

            base.Clear();

            isUpdating = false;
            isReadLineMode = oldIsReadMode;

            StartReadPlace = Place.Empty;
        }

        public void Command(string text) {
            if (text == "clear")
                Clear();
            else if (text.Contains(".exe") && text.Contains(".bat"))
            {
                try
                {
                    Process.Start(text.Split(' ')[0], text.Split(' ')[1]);
                }
                catch { Process.Start(text.Split(' ')[0]); }
            }
            else if (text.Contains("echo"))
                this.WriteLine(text.Remove(0,4)+"\n");
            else if (text == "SpecialKey")
                spaceSPK();
            else if (text == "help")
                this.WriteLine("help  ,  clear  ,  SpecialKey\ndir , delete , \n");
            else if (text.StartsWith("delete") && File.Exists(text.Split(' ')[1]))
                File.Delete(text.Split(' ')[1]);
            else if (text.StartsWith("dir") && Directory.Exists(text.Split(' ')[1]))
            {
                foreach (string dir in Directory.GetDirectories(text.Split(' ')[1]))
                {
                    this.WriteLine(dir + "\n");
                }
                foreach (string dir in Directory.GetFiles(text.Split(' ')[1]))
                {
                    this.WriteLine(dir + "\n");
                }
            }
        }

        public void spaceSPK()
        {
            String getVer()
            {
                return "SPS3";
            }
            this.WriteLine("================\n");
            this.WriteLine("Special Key " + getVer()+"\n");
            this.WriteLine("================\n");

            String cmd = this.ReadLine();

            if (cmd.Contains("run "))
            {
                String path = cmd.Contains(".spk") ?
                        cmd.Split(' ')[1] :
                        cmd.Split(' ')[1] + ".spk";
                try
                {
                    Process.Start("java", " -jar " + Globals.SpecialKey + "SpecialKey.jar " + path);

                    Libs.SpKeyLib.Run(path,this);
                }
                catch (FileNotFoundException e)
                {
                    this.WriteLine("File is not found!\n");
                }
                catch (IOException e)
                {
                    this.WriteLine("File read error!\n");
                }
            }
            else if (cmd.Contains("special-pm"))
            {
                String[] objs = cmd.Split(' ');
                if (objs[1].Equals("install"))
                {
                    this.WriteLine("https://raw.githubusercontent.com/TiM-SyStEm/Special-Key-SPS/main/special-pm" + objs[2] + ".spk\n");
                }
            }
            else if (cmd.Contains("ver"))
            {
                this.WriteLine("============\n");
                this.WriteLine(getVer());
                this.WriteLine(" Patch 0\n");
                this.WriteLine("============\n");
            }
            else if (cmd.Contains("cls"))
            {
                Clear();
                this.WriteLine("================\n");
                this.WriteLine("Special Key " + getVer()+"\n");
                this.WriteLine("================\n");
            }
            else if (cmd.Contains("log"))
            {
                this.WriteLine(File.ReadAllText(Globals.SpecialKey + "log.txt")+"\n");
            }
            else if (cmd.Contains("clearLog"))
            {
                File.WriteAllText(Globals.SpecialKey + "log.txt", "");
            }
            else if (cmd.Contains("close"))
            {
                Clear();
                Command("");
            }
            else
            {
                this.WriteLine("Command not found!\n");
            }
        }
    }
}
