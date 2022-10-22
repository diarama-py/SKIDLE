using FastColoredTextBoxNS;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace SKIDLE
{
    public class HighLighting
    {
        private Style BlueSlateStyle = new TextStyle(Brushes.DarkSlateBlue, null, FontStyle.Regular);
        private Style BlueStyle = new TextStyle(Brushes.Aqua, null, FontStyle.Regular);
        private Style TealStyle = new TextStyle(Brushes.Teal, null, FontStyle.Regular);
        private Style IGreenStyle = new TextStyle(Brushes.Green, null, FontStyle.Italic);
        private Style MagentaStyle = new TextStyle(Brushes.Magenta, null, FontStyle.Regular);
        private Style MaroonStyle = new TextStyle(Brushes.Maroon, null, FontStyle.Regular);
        private Style CommentStyle = new TextStyle(Brushes.Gray, null, FontStyle.Bold);
        private Style LightCoralStyle = new TextStyle(Brushes.LightCoral, null, FontStyle.Bold);
        private Style LightBlueStyle = new TextStyle(Brushes.LightBlue, null, FontStyle.Bold);
        private Style BlueStyleCorect = new TextStyle(Brushes.BlueViolet, null, FontStyle.Regular);
        private Style LightGreenStyle = new TextStyle(Brushes.LightGreen, null, FontStyle.Regular);
        private Style AddStyle = new TextStyle(Brushes.Orange, null, FontStyle.Regular);
        private Style VSfc = new TextStyle(new SolidBrush(Color.FromArgb(155,77,220)), null, FontStyle.Italic);
        private Style TurquoiseStyle = new TextStyle(Brushes.Turquoise, null, FontStyle.Regular);
        private Style MediumPurpleStyle = new TextStyle(Brushes.Fuchsia, null, FontStyle.Regular);
        private Style CharStyle = new TextStyle(Brushes.DarkOrange, null, FontStyle.Regular);

        public void _HighLighting(object sender, TextChangedEventArgs e)
        {
            e.ChangedRange.BeginUpdate();
            e.ChangedRange.tb.SelectionColor = Color.Gray;
            e.ChangedRange.ClearFoldingMarkers();
            e.ChangedRange.tb.CommentPrefix = "#";
            e.ChangedRange.tb.LeftBracket = '(';
            e.ChangedRange.tb.RightBracket = ')';
            e.ChangedRange.tb.LeftBracket2 = '{';
            e.ChangedRange.tb.RightBracket2 = '}';
            e.ChangedRange.tb.BracketsHighlightStrategy = BracketsHighlightStrategy.Strategy2;

            e.ChangedRange.tb.AutoIndentCharsPatterns = @"{|}|""|""|(|)";

            e.ChangedRange.SetStyle(TealStyle, @"var");
            e.ChangedRange.SetStyle(VSfc, @"fun|class|if|for|while|do|else|stop|continue|switch|case|enum");
            e.ChangedRange.SetStyle(TurquoiseStyle, @"toStr|toInt|toFloat|toByte|toShort|toLong|toDouble|ref|length|Array|strReplace|strSplit");
            e.ChangedRange.SetStyle(LightBlueStyle, @"Null|True|False|protected:|private:");
            e.ChangedRange.SetStyle(MediumPurpleStyle, @"input|out");
            e.ChangedRange.SetStyle(AddStyle, @"Add");
            e.ChangedRange.SetStyle(CharStyle, @"{|}|""|""|\'|\'|:|;|(|)|!|@|#|$|%|^|&");

            IList<string> line = e.ChangedRange.tb.Lines;
            for (int i = 0; i < line.Count; i++)
            {
                try
                {
                    if (line[i].Contains("var") || line[i].Contains("fun") || line[i].Contains("enum"))
                    {
                        string q = line[i].Trim(' ');
                        q = q.Split(' ')[1];
                        q = q.Split('=', ' ', '(', ')', '{', '}')[0];
                        e.ChangedRange.SetStyle(BlueSlateStyle, q);
                    }
                    else if (line[i].Contains("#"))
                    {
                        string q = line[i];
                        e.ChangedRange.SetStyle(CommentStyle, q);
                    }
                    else if (line[i].Contains("\""))
                    {
                        if (line[i].EndsWith("\"") || line[i].EndsWith(" ") || line[i].EndsWith(")") || line[i].StartsWith("("))
                        {
                            string q = line[i].Trim(' ', '=', ':', '(', ')');
                            q = q.Split('\"', '(', ')')[1];
                            while (line[i].EndsWith("\"") || line[i].EndsWith(" ") || line[i].EndsWith(")") || line[i].StartsWith("("))
                            {
                                q = q.TrimEnd(' ');
                                Range range;
                                switch (HighlightingRangeType.ChangedRange)
                                {
                                    default:
                                        range = e.ChangedRange;
                                        break;
                                }
                                e.ChangedRange.SetStyle(CommentStyle, q);
                                break;
                            }
                        }
                        else
                        {
                        }
                    }
                    else
                    {
                    }
                }
                catch { }
            }

            foreach (var item in Directory.GetFiles(Globals.SpecialKey + "modules\\", "*.spk"))
            {
                FileInfo fi = new FileInfo(item);
                string dfName = fi.Name.Split(".spk"[0])[0];
                if (e.ChangedRange.tb.Text.Contains("Add " + dfName))
                {
                    List<string> LinesFromFile = new List<string>(File.ReadAllLines(item));

                    for (int i = 0; i < LinesFromFile.Count; i++)
                    {
                        try
                        {
                            if (LinesFromFile[i].Contains("fun") || LinesFromFile[i].Contains("enum")|| LinesFromFile[i].Contains("class"))
                            {
                                string q = LinesFromFile[i].Trim(' ');
                                q = q.Split(' ')[1];
                                q = q.Split('=', ' ', '(', ')', '{', '}')[0];
                                e.ChangedRange.SetStyle(BlueSlateStyle, q);
                            }
                        }
                        catch { }
                    }
                }
                else { }
            }
        }
    }
}