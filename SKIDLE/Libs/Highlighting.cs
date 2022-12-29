using FastColoredTextBoxNS;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SKIDLE
{
    public class HighLighting
    {
        public string local = "";
        protected Regex AttributeRegex,
                      ClassNameRegex;

        protected Regex CommentRegex1,
                      CommentRegex2,
                      CommentRegex3;

        protected Regex KeywordRegex;

        protected Regex baseRegex;

        protected Regex NumberRegex;
        protected Regex StringRegex;
        protected Regex FunRegex;
        protected Regex ClassRegex;

        protected static readonly Platform platformType = PlatformType.GetOperationSystemPlatform();
        public static RegexOptions RegexCompiledOption
        {
            get
            {
                if (platformType == Platform.X86)
                    return RegexOptions.Compiled;
                else
                    return RegexOptions.None;
            }
        }

        private Style CommentStyle = new TextStyle(Brushes.Gray, null, FontStyle.Regular);
        private Style LightBlueStyle = new TextStyle(Brushes.LightBlue, null, FontStyle.Regular);
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

            e.ChangedRange.tb.AutoIndentCharsPatterns = @"{|}|[|]|""|""|(|)";

            e.ChangedRange.ClearStyle(MediumPurpleStyle, CommentStyle, TurquoiseStyle, VSfc, LightBlueStyle, CharStyle);
            if (StringRegex == null)
                InitSPKRegex();

            e.ChangedRange.SetStyle(CharStyle, StringRegex);

            e.ChangedRange.SetStyle(CommentStyle, CommentRegex1);
            e.ChangedRange.SetStyle(CommentStyle, CommentRegex2);
            e.ChangedRange.SetStyle(CommentStyle, CommentRegex3);

            e.ChangedRange.SetStyle(CharStyle, @"{|}|[|]|""|""|\'|\'|:|;|(|)|!|@|#|$|%|^|&");
            e.ChangedRange.SetStyle(CharStyle, NumberRegex);
           
            //clear folding markers
            e.ChangedRange.ClearFoldingMarkers();
            //set folding markers
            e.ChangedRange.SetFoldingMarkers("{", "}"); //allow to collapse brackets block
            //e.ChangedRange.SetFoldingMarkers(@"#region\b", @"#endregion\b"); //allow to collapse #region blocks

            IList<string> line = e.ChangedRange.tb.Lines;
        }

        protected void AutoIndentNeeded(object sender, AutoIndentEventArgs args)
        {
            //block {}
            if (Regex.IsMatch(args.LineText, @"^[^""']*\{.*\}[^""']*$"))
                return;
            //start of block {}
            if (Regex.IsMatch(args.LineText, @"^[^""']*\{"))
            {
                args.ShiftNextLines = args.TabLength;
                return;
            }
            //end of block {}
            if (Regex.IsMatch(args.LineText, @"}[^""']*$"))
            {
                args.Shift = -args.TabLength;
                args.ShiftNextLines = -args.TabLength;
                return;
            }
            //label
            if (Regex.IsMatch(args.LineText, @"^\s*\w+\s*:\s*($|//)") &&
                !Regex.IsMatch(args.LineText, @"^\s*default\s*:"))
            {
                args.Shift = -args.TabLength;
                return;
            }
            if (Regex.IsMatch(args.LineText, @"^\s*(case|default)\b.*:\s*($|//)"))
            {
                args.Shift = -args.TabLength / 2;
                return;
            }
            if (Regex.IsMatch(args.PrevLineText, @"^\s*(if|do|for|foreach|while|[\}\s]*else)\b[^{]*$"))
                if (!Regex.IsMatch(args.PrevLineText, @"(;\s*$)|(;\s*//)"))
                {
                    args.Shift = args.TabLength;
                    return;
                }
        }
        protected void InitSPKRegex()
        {

            StringRegex =
                new Regex(
                    @"
                            # Character definitions:
                            '
                            (?> # disable backtracking
                              (?:
                                \\[^\r\n]|    # escaped meta char
                                [^'\r\n]      # any character except '
                              )*
                            )
                            '?
                            |
                            # Normal string & verbatim strings definitions:
                            (?<verbatimIdentifier>@)?         # this group matches if it is an verbatim string
                            ""
                            (?> # disable backtracking
                              (?:
                                # match and consume an escaped character including escaped double quote ("") char
                                (?(verbatimIdentifier)        # if it is a verbatim string ...
                                  """"|                         #   then: only match an escaped double quote ("") char
                                  \\.                         #   else: match an escaped sequence
                                )
                                | # OR
            
                                # match any char except double quote char ("")
                                [^""]
                              )*
                            )
                            ""
                        ",
                    RegexOptions.ExplicitCapture | RegexOptions.Singleline | RegexOptions.IgnorePatternWhitespace |
                    RegexCompiledOption
                    );

            CommentRegex1 = new Regex(@"#.*$", RegexOptions.Multiline | RegexCompiledOption);
            CommentRegex2 = new Regex(@"(/#*.*?\*/)|(/\*.*)", RegexOptions.Singleline | RegexCompiledOption);
            CommentRegex3 = new Regex(@"(/#*.*?\*/)|(.*\*/)",
                                            RegexOptions.Singleline | RegexOptions.RightToLeft | RegexCompiledOption);
            NumberRegex = new Regex(@"\b\d+[\.]?\d*([eE]\-?\d+)?[lLdDfF]?\b|\b0x[a-fA-F\d]+\b",
                                          RegexCompiledOption);
            AttributeRegex = new Regex(@"^\s*(?<range>\[.+?\])\s*$", RegexOptions.Multiline | RegexCompiledOption);            
        }
    }
}