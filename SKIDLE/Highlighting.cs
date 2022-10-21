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
        private Style BlueStyleCorect = new TextStyle(Brushes.Blue, null, FontStyle.Regular);
        private Style LightGreenStyle = new TextStyle(Brushes.LightGreen, null, FontStyle.Regular);
        private Style AddStyle = new TextStyle(Brushes.Orange, null, FontStyle.Regular);
        private Style GoldenRodStyle = new TextStyle(Brushes.Goldenrod, null, FontStyle.Italic);
        private Style TurquoiseStyle = new TextStyle(Brushes.Turquoise, null, FontStyle.Regular);
        private Style MediumPurpleStyle = new TextStyle(Brushes.Fuchsia, null, FontStyle.Regular);

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

            e.ChangedRange.SetStyle(CommentStyle, @"#.*$");

            e.ChangedRange.SetStyle(TealStyle, @"var");

            e.ChangedRange.SetStyle(GoldenRodStyle, @"fun");
            e.ChangedRange.SetStyle(GoldenRodStyle, @"class");
            e.ChangedRange.SetStyle(GoldenRodStyle, @"if");
            e.ChangedRange.SetStyle(GoldenRodStyle, @"for");
            e.ChangedRange.SetStyle(GoldenRodStyle, @"while");
            e.ChangedRange.SetStyle(GoldenRodStyle, @"do");
            e.ChangedRange.SetStyle(GoldenRodStyle, @"else");
            e.ChangedRange.SetStyle(GoldenRodStyle, @"stop");
            e.ChangedRange.SetStyle(GoldenRodStyle, @"continue");
            e.ChangedRange.SetStyle(GoldenRodStyle, @"switch");
            e.ChangedRange.SetStyle(GoldenRodStyle, @"case");
            e.ChangedRange.SetStyle(GoldenRodStyle, @"enum");

            e.ChangedRange.SetStyle(TurquoiseStyle, @"toStr");
            e.ChangedRange.SetStyle(TurquoiseStyle, @"toInt");
            e.ChangedRange.SetStyle(TurquoiseStyle, @"toFloat");
            e.ChangedRange.SetStyle(TurquoiseStyle, @"toByte");
            e.ChangedRange.SetStyle(TurquoiseStyle, @"toShort");
            e.ChangedRange.SetStyle(TurquoiseStyle, @"toLong");
            e.ChangedRange.SetStyle(TurquoiseStyle, @"toDouble");
            e.ChangedRange.SetStyle(TurquoiseStyle, @"ref");

            e.ChangedRange.SetStyle(BlueStyleCorect, @"length");

            e.ChangedRange.SetStyle(LightBlueStyle, @"Null");
            e.ChangedRange.SetStyle(LightBlueStyle, @"True");
            e.ChangedRange.SetStyle(LightBlueStyle, @"False");
            e.ChangedRange.SetStyle(LightGreenStyle, @"protected:");
            e.ChangedRange.SetStyle(LightGreenStyle, @"private:");

            e.ChangedRange.SetStyle(MediumPurpleStyle, @"input");
            e.ChangedRange.SetStyle(MediumPurpleStyle, @"out");

            e.ChangedRange.SetStyle(AddStyle, @"Add");




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
                            if (LinesFromFile[i].Contains("fun") || LinesFromFile[i].Contains("enum"))
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