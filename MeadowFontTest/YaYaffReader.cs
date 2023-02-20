using Meadow.Foundation.Graphics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace YaffReader
{
    public static class YaffConst
    {
        public static char ink = '@';
        public static char paper = '.';
        public static char empty = '-';
        public static string glyphchars = new string(new char[] { ink, paper, empty });

        public static char separator = ':';
        public static readonly char comment = '#';

        public static char[] whitespace = { ' ', '\t' };
    }

    /// <summary>
    /// https://github.com/robhagemans/monobit/blob/master/YAFF.md - YAFF Font file format
    /// This Format's purpose is to preserve Bitmap fonts in a consistant human readable format
    /// Orignal Monobit python was converted to c# - just enough to parse the file
    /// </summary>
    public class YaYaffReader
    {
        private string filename { get; set; }

        // Properties of Font - Comments Props Glyphs
        public string Comment { get; private set; }
        public readonly Dictionary<string, string> FontProps = new Dictionary<string, string>();
        public readonly List<YaffGlyph> Glyphs = new List<YaffGlyph>();

        public YaYaffReader(string filename)
        {
            this.filename = filename;
        }

        /// <summary>
        /// Load the Font to use it
        /// </summary>
        public IYaffFont Load_Yaff()
        {
            string[] lines = File.ReadAllLines(filename);

            var globcomments = new StringBuilder();
            var currcomments = new StringBuilder();

            YaffGlyph currG = new YaffGlyph();

            var linenum = 0;
            var chunk = 0;
            var gindent = 0;
            var commenttext = "";
            var lastlineblank = false;

            // Go though the Yaff line by line
            // Comments Propertys Glyphs
            while (linenum < lines.Length)
            {
                string line = lines[linenum];

                // several line types are expected
                var isblank = line.All(c => YaffConst.whitespace.Contains(c));
                var iscomment = !isblank && line[0] == YaffConst.comment;
                if (iscomment)
                    commenttext = line[1..];

                // Hack to avoid misinterpretting label " ":  
                if (line == "\" \":")
                    line = "space:";

                // property has a value - label does not
                var ispropkey = !iscomment && line.Contains(YaffConst.separator);
                var isglyph = !isblank && line.All(c => YaffConst.glyphchars.Contains(c) || YaffConst.whitespace.Contains(c));
                var islabel = line.TrimEnd().EndsWith(YaffConst.separator) && (line.Length == 1 || !YaffConst.whitespace.Contains(line[1]));

                if (islabel)
                {
                    ispropkey = false;
                    // unless it is a multiline prop

                    var lookahead = lines[linenum + 1];
                    if (!lookahead.All(c => YaffConst.glyphchars.Contains(c) || YaffConst.whitespace.Contains(c)) &&
                        !lookahead.Trim().EndsWith(":"))
                    {
                        islabel = false;
                        ispropkey = true;
                    }
                }
                string key, val;
                // Global comments at the top
                if (chunk == 0 && iscomment)
                {
                    if (commenttext.Length > 0 && commenttext[0] == ' ')
                        commenttext = commenttext[1..];
                    globcomments.AppendLine(commenttext.TrimEnd());
                }

                // multiple blank lines do not cause new glyph
                else if (isblank)
                {
                    chunk++;
                    if (currG.props.Count > 0 ||
                        currG.glyphs.Count > 0 ||
                        currG.labels.Count > 0)
                    {
                        if (currG != null)
                        {
                            if (currcomments.Length > 0)
                                currG.comment = currcomments.ToString().TrimEnd();

                            if (Glyphs.Count == 0 && currG.props.Count > 0)
                            {
                                // global props
                                foreach (var p in currG.props)
                                    FontProps.Add(p.Key, p.Value);
                            }
                            else if (currG.glyphs.Count == 0 && currG.props.Count > 0)
                            {
                                // these props are for the previous glyph
                                foreach (var p in currG.props)
                                    Glyphs.Last().props.Add(p.Key.Trim(), p.Value);
                            }
                            else
                                Glyphs.Add(currG);
                        }

                        currG = new YaffGlyph();
                        currcomments = new StringBuilder();
                        gindent = 0;
                    }
                }

                // props - keys are not case sensitive
                else if (ispropkey)
                {
                    // multiline - indented value
                    if (line.TrimEnd().EndsWith(":"))
                    {
                        key = line.TrimEnd().TrimEnd(YaffConst.separator).Replace("_", "-").ToLowerInvariant();
                        linenum++;
                        line = lines[linenum].TrimEnd();

                        var indent = line.Length - line.TrimStart(YaffConst.whitespace).Length;
                        var valbuilder = new StringBuilder();

                        do
                        {
                            valbuilder.AppendLine(line[indent..]);
                            linenum++;
                            line = lines[linenum].TrimEnd();
                        }
                        while (line.Length > indent && string.IsNullOrWhiteSpace(line[..indent]));
                        linenum--;
                        val = valbuilder.ToString().TrimEnd();
                    }
                    else
                    {
                        // value is on the line
                        var s = line.Split(YaffConst.separator);
                        key = s[0].Replace("_", "-").ToLowerInvariant(); // keys are not case sensitive

                        string v = string.Empty;
                        for (var ii = 1; ii < s.Length; ii++)
                            v += s[ii] + YaffConst.separator;
                        val = v.TrimEnd(YaffConst.separator).Trim().Trim('"');
                    }

                    if (currG != null)
                        currG.props.Add(key, val);

                    // also props that are lables - x: and yon next line
                }

                if (currG != null)
                {
                    // Comments for this character Glyph
                    if (chunk > 0 && iscomment)
                    {
                        if (commenttext.Length > 0 && commenttext[0] == ' ')
                            commenttext = commenttext[1..];
                        currcomments.AppendLine(commenttext.TrimEnd());
                    }

                    if (islabel)
                    {
                        var label = line.TrimEnd().TrimEnd(YaffConst.separator);
                        // If a label element starts and ends with a single-quote character ', these quotes are stripped and the element consists of everything in between.
                        if (label.StartsWith("'") && label.EndsWith("'"))
                            label = label.Trim('\'');

                        // labels are tags - does it matter ?
                        if (!string.IsNullOrWhiteSpace(label))
                            currG.labels.Add(label);

                        if (FontProps.TryGetValue("default-char", out string dfc))
                        {
                            if (dfc == label && label != "default")
                                currG.labels.Add("default");
                        }
                    }

                    // Bitmap on and off as @ and .
                    if (isglyph)
                    {
                        if (gindent == 0)
                            gindent = line.Length - line.TrimStart(YaffConst.whitespace).Length;
                        currG.glyphs.Add(line[gindent..].TrimEnd());
                    }
                }
                linenum++;
                lastlineblank = isblank;
            }

            if (currG != null && currG.glyphs.Count > 0)
            {
                currG.comment = currcomments.ToString().TrimEnd();
                Glyphs.Add(currG);
            }

            Comment = globcomments.ToString().TrimEnd();

            // Yaff is parsed

            // Fixup
            //Deprecated synonyms are:
            //  average-advance: equal to average-width.
            //  max-advance: equal to max-width.
            //  cap-advance: equal to cap-width.
            //  offset(x y pair): equal to(left-bearing, shift-up).
            //  tracking: equal to right-bearing.
            //  kern-to: equal to right-kerning.

            // return a font
            if (FontProps.ContainsKey("spacing"))
            {
                int w, h;
                if (FontProps["spacing"] == "character-cell" ||
                    FontProps["spacing"] == "monospace")
                {
                    if (FontProps.TryGetValue("raster-size", out string value))
                    {
                        var dim = value.Split(' ');
                        w = int.Parse(dim[0]);
                        h = int.Parse(dim[1]);
                    }
                    else if (FontProps.TryGetValue("cell-size", out string value2))
                    {
                        var dim = value2.Split(' ');
                        w = int.Parse(dim[0]);
                        h = int.Parse(dim[1]);
                    }
                    else
                    {
                        // width height from first and last glyph
                        w = Math.Max(Glyphs[0].glyphs[0].Length, Glyphs.Last().glyphs[0].Length);
                        h = Glyphs[0].glyphs.Count;

                        if (Glyphs[0].props.TryGetValue("left-bearing", out string lb))
                        {
                            w += int.Parse(lb);
                        }
                        if (Glyphs[0].props.TryGetValue("right-bearing", out string rb))
                        {
                            w += int.Parse(rb);
                        }
                    }

                    var name = Path.GetFileNameWithoutExtension(filename);
                    if (FontProps.ContainsKey("name"))
                        name = FontProps["name"];
                    if (FontProps.TryGetValue("foundry", out string value3))
                        name = value3 + " " + name;

                    return new YaffFixedFont(w, h, name, Glyphs);
                }

                else if (FontProps["spacing"] == "proportional")
                {
                    var name = Path.GetFileNameWithoutExtension(filename);
                    if (FontProps.TryGetValue("name", out string fontname))
                        name = fontname;
                    if (FontProps.TryGetValue("foundry", out string foundry))
                        name = foundry + " " + name;

                    int width = 0;
                    int height = 0;
                    if (FontProps.TryGetValue("bounding-box", out string bb))
                    {
                        var bbs = bb.Trim().Split(" ");
                        int.TryParse(bbs[0], out width);
                        int.TryParse(bbs[1], out height);
                    }

                    return new YaffPropFont(name, Glyphs, width, height);
                }
            }

            throw new InvalidOperationException($"No Font available from {filename}");
        }
    }

    /// <summary>
    /// Represents a Single Character in Yaff Format
    /// </summary>
    public class YaffGlyph
    {
        public string comment { get; set; }
        public Dictionary<string, string> props { get; } = new Dictionary<string, string>();
        public List<string> labels { get; } = new List<string>(); // unicode codepage tag
        public List<string> glyphs { get; } = new List<string>(); // ink paper empty as string
    }

    #region Yaff Font Render

    public interface IYaffFont : IFont
    {
        string Name { get; }

        YaffFontType Type { get; }

        // All the characters representented by this font
        List<char> CharMap { get; }

        // Glyph as Lines instead of rows
        List<string> GlyphLines(char c);

        // Some properties for rendering proportial fonts ? 
        (int lb, int rb) GetBearing(char c);
    }

    public enum YaffFontType
    {
        None = 0,
        Proportional = 1,
        Fixed = 2
    }

    public class YaffFixedFont : IYaffFont
    {
        private static readonly string bearing = ".................";

        /// <summary>
        /// For Each Character, we need the glyph as bytes
        /// But it is only 1 byte per row if the font is 8 
        /// other widths need to be packed - this is why only 4 6 8 12 are valid
        /// </summary>
        public byte[] this[char character]
        {
            get
            {
                // Console.WriteLine($"Looking for {character}");

                // We need a bitarray for the whole character, not line by line
                var b = new BitArray(Width * Height);

                var yg = GetGlyph(character);
                if (yg.glyphs[0] == "-")
                {
                    // empty
                    b.SetAll(false);
                }
                else
                {
                    int yy = 0;
                    foreach (var g in yg.glyphs)
                    {
                        string modg = g;
                        // right or left bearing ? 
                        if (yg.props.TryGetValue("left-bearing", out var lb))
                        {
                            if (int.TryParse(lb, out var ilb))
                                if (ilb > 0)
                                    modg = bearing[..ilb] + modg;
                        }

                        if (yg.props.TryGetValue("right-bearing", out var rb))
                        {
                            if (int.TryParse(rb, out var irb))
                                if (irb > 0)
                                    modg += bearing[..irb];
                        }

                        //Console.WriteLine(modg);
                        int xx = 0;
                        foreach (var c in modg)
                        {
                            b.Set(yy * Width + xx, c == '@');
                            xx++;
                        }
                        yy++;
                    }
                }

                return BitArrayToByteArray(b);
            }
        }

        protected int width;
        public int Width => width;

        protected int height;
        public int Height => height;

        public string Name { get; protected set; }

        protected YaffFontType type;
        public YaffFontType Type => type;

        public List<char> CharMap
        {
            get
            {
                var cm = new List<char>();
                foreach (var ch in glyphs.Keys)
                    cm.Add((char)ch);
                return cm;
            }
        }

        private readonly SortedDictionary<uint, YaffGlyph> glyphs = new SortedDictionary<uint, YaffGlyph>();
        private readonly SortedDictionary<string, YaffGlyph> namedglyphs = new SortedDictionary<string, YaffGlyph>();

        public YaffFixedFont(int width, int height, string name, List<YaffGlyph> g)
        {
            this.width = width;  // 4 6 8 12 for IFont
            if (width <= 4)
                this.width = 4;
            else if (width <= 6)
                this.width = 6;
            else if (width <= 8)
                this.width = 8;
            else if (width <= 12)
                this.width = 12;

            this.height = height;
            if (Width == 6 | Width == 12)
            {
                if (height <= 8)
                    this.height = 8;
                else if (height <= 12)
                    this.height = 12;
                else if (height <= 16)
                    this.height = 16;
            }

            Name = name;
            this.type = YaffFontType.Fixed;

            // Parse the passed in Glyph collection - we want access by ascii char number / unicoode
            foreach (var gg in g)
            {
                foreach (var t in gg.labels)
                {
                    string tt = t.Trim('"').ToLowerInvariant();
                    // hex or unicode
                    if (tt.StartsWith("0x") || tt.StartsWith("u+"))
                    {
                        var utt = tt[2..].ToUpperInvariant();
                        if (uint.TryParse(utt,
                                          NumberStyles.AllowHexSpecifier,
                                          CultureInfo.InvariantCulture,
                                          out uint index) && !glyphs.ContainsKey(index))
                            glyphs.Add(index, gg);
                        else if (!namedglyphs.ContainsKey(tt))
                            namedglyphs.Add(tt, gg);
                    }
                    // decimal numeric
                    else if (uint.TryParse(tt, out uint index))
                        glyphs.Add(index, gg);
                    // string character or name
                    else if (!namedglyphs.ContainsKey(tt))
                        namedglyphs.Add(tt, gg);
                }
            }
        }

        /// <summary>
        /// return the glyph as vertical lines instead of horizontal
        /// </summary>
        /// <param name="c">character to get lines for</param>
        /// <returns>List of ink/paper lines</returns>
        public List<string> GlyphLines(char c)
        {
            var yg = GetGlyph(c);

            var height = yg.glyphs.Count;
            var width = yg.glyphs[0].Length;

            var result = new List<string>();

            // return vertical strips of the ink and empty 
            for (var i = 0; i < width; i++)
            {
                var line = new string(' ', height).ToCharArray();
                for (var y = 0; y < height; y++)
                    line[y] = yg.glyphs[y][i];

                result.Add(new string(line));
            }

            return result;
        }

        /// <summary>
        /// how much bearing to add before and after the character ( can be -ve !)
        /// </summary>
        /// <param name="c">character to get bearing for</param>
        /// <returns>tuple of bearings</returns>
        public (int lb, int rb) GetBearing(char c)
        {
            int lb = 0;
            int rb = 0;
            var yg = GetGlyph(c);

            if (yg.props.TryGetValue("left-bearing", out var lbearing))
                _ = int.TryParse(lbearing, out lb);

            if (yg.props.TryGetValue("right-bearing", out var rbearing))
                _ = int.TryParse(rbearing, out rb);

            return (lb, rb);
        }

        private YaffGlyph GetGlyph(char character)
        {
            if (glyphs.TryGetValue(character, out YaffGlyph chval))
                return chval;
            else if (namedglyphs.TryGetValue("default", out YaffGlyph defval))
                return defval;
            else if (namedglyphs.TryGetValue("empty", out YaffGlyph emval))
                return emval;
            else if (glyphs.ContainsKey(' '))
                return glyphs[' '];
            else
                return glyphs[glyphs.Keys.Last()];
        }

        private static byte[] BitArrayToByteArray(BitArray bits)
        {
            byte[] ret = new byte[(bits.Length - 1) / 8 + 1];
            bits.CopyTo(ret, 0);
            return ret;
        }
    }

    public class YaffPropFont : YaffFixedFont
    {
        public YaffPropFont(string name, List<YaffGlyph> g, int w, int h) : base(0, 0, name, g)
        {
            this.type = YaffFontType.Proportional;
            this.Name = name;

            if (w == 0 || h == 0)
            {
                this.width = g[0].glyphs[0].Length;
                this.height = g[0].glyphs.Count;
            }
            else
            {
                this.width = w;
                this.height = h;
            }
        }
    }

    #endregion

    #region Helper 
    public static class YaffFont
    {
        // Throw away the reader and just return the IFont
        public static IYaffFont GetFont(string filename)
        {
            if (!Path.IsPathFullyQualified(filename))
                filename = Path.GetFullPath(filename);

            var yfr = new YaYaffReader(filename);
            return yfr.Load_Yaff();
        }
    }

    #endregion

}
