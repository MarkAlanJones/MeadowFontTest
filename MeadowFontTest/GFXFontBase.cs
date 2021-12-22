using System;
using System.Linq;

namespace Meadow.Foundation.Graphics
{
    /// <summary>
    /// Adafruit GFX Fonts are bitmap fonts with variable spacing
    /// </summary>

    public struct GFXglyph
    {
        public ushort bitmapOffset;     // Pointer into GFXfont->bitmap
        public byte width, height;      // Bitmap dimensions in pixels
        public int xAdvance;            // Distance to advance cursor (x axis)
        public int xOffset, yOffset;    // Dist from cursor pos to UL corner

        public GFXglyph(ushort bitmapOffset, byte width, byte height, int xAdvance, int xOffset, int yOffset) : this()
        {
            this.bitmapOffset = bitmapOffset;
            this.width = width;
            this.height = height;
            this.xAdvance = xAdvance;
            this.xOffset = xOffset;
            this.yOffset = yOffset;
        }
    }

    public struct GFXfont
    {
        public byte[] bitmap;        // Glyph bitmaps, concatenated
        public GFXglyph[] glyph;     // Glyph array
        public byte first, last;     // ASCII extents
        public byte yAdvance;        // Newline distance (y axis)

        public GFXfont(byte[] bitmap, GFXglyph[] glyph, byte first, byte last, byte yAdvance)
        {
            this.bitmap = bitmap;
            this.glyph = glyph;
            this.first = first;
            this.last = last;
            this.yAdvance = yAdvance;
        }
    }

    public abstract class GFXFontBase : IFont
    {

        protected GFXfont gfxfont;

        public byte[] this[char character]
        {
            get
            {
                var g = Glyph(character);
                double size = g.width * g.height / 8.0;
                if (g.width > 0)
                    size = Math.Ceiling(size);

                byte[] result = new byte[(int)size];
                for (int i = 0; i < result.Length; i++)
                    result[i] = gfxfont.bitmap[g.bitmapOffset + i];

                return result;
            }
        }

        public GFXglyph Glyph(char character)
        {
            var c = (int)character;
            int offset = gfxfont.first;

            // only tomthumb - extended characters with unprintable chunk
            if (c >= 0x7F && c <= 0xA0)
                c = -1;
            if (c > 0xA0)
                offset = gfxfont.first + 0xA0 - 0x7F;

            if (c >= gfxfont.first &&
                c <= gfxfont.last)
                return gfxfont.glyph[c - offset];
            else
                return gfxfont.glyph[0];
        }

        public int Width => gfxfont.glyph.Max(x => x.xAdvance);

        public int Height => gfxfont.yAdvance - 1;

        public byte yAdvance => gfxfont.yAdvance;

        public byte first => gfxfont.first;

        public byte last => gfxfont.last;

    };
}
