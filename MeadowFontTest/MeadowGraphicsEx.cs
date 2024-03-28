using Meadow.Foundation.Graphics;
using Meadow.Peripherals.Displays;
using System;
using YaffReader;

namespace Meadow.Foundation.MyExtensions
{
    // Extend the GraphicsLibrary 
    public class MicroGraphicsEx : MicroGraphics
    {
        new readonly IPixelDisplay display;

        public MicroGraphicsEx(IPixelDisplay display) : base(display)
        {
            this.display = display;
        }

        public int CursorX { get; set; }
        public int CursorY { get; set; }
        public bool WrapText { get; set; }

        /// <summary>
        /// GFX assumes the starting xpos ypos is the left side of the baseline (not the top)
        /// the X and Y offset of the glyph get us to the top of the bitmap which is width x height bits extra bits to the right are ignored
        /// once we have drawn the cursor is moved by xAdvance from the orginal location not the finshed drawing location
        /// the yadvance is for a newline or when wrapping is enabled/detected
        /// </summary>
        public void DrawGFXText(int xPos, int yPos, string text, Color c)
        {
            if (CurrentFont == null)
            {
                throw new Exception("CurrentFont must be set before calling DrawGFXText.");
            }
            else if (!(CurrentFont is GFXFontBase))
            {
                throw new Exception("CurrentFont must be GFXFont");
            }

            CursorX = xPos;
            CursorY = yPos;

            byte[] characterMap;

            // each character
            for (int i = 0; i < text.Length; i++)
            {
                characterMap = CurrentFont[text[i]];
                GFXglyph g = ((GFXFontBase)CurrentFont).Glyph(text[i]);

                int xDraw = CursorX + g.xOffset;
                int yDraw = CursorY + g.yOffset;
                int w = 0;

                //copy data for 1 character at a time going top to bottom
                for (int b = 0; b < characterMap.Length; b++)
                {
                    for (int bit = 7; bit >= 0; bit--)
                    {
                        if (characterMap[b].GetBit(bit))
                            DrawPixel(xDraw, yDraw, c);

                        xDraw++;
                        w++;

                        if (w >= g.width)
                        {
                            w = 0;
                            xDraw = CursorX + g.xOffset;
                            yDraw++;
                        }
                    }
                }

                CursorX += g.xAdvance;
                if (WrapText)
                {
                    if (CursorX > display.Width - ((GFXFontBase)CurrentFont).Width)
                    {
                        CursorX = xPos; // assume original xPos was left margin
                        CursorY += ((GFXFontBase)CurrentFont).YAdvance;
                    }
                }
            }

        }

        /// <summary>
        /// Set the CurrentFont to a YaffFont - proportional or fixed 
        /// DrawYaffText uses x,y of the TOP LEFT corner, same as DrawText
        /// If the WrapText property is set, the Text will wrap by advancing CursorY and returning to the original CursorX
        /// </summary>
        /// <param name="xPos">Distance from left edge of screen to start</param>
        /// <param name="yPos">Distance from top edge of screen to start</param>
        /// <param name="text">Text to render</param>
        /// <param name="color">Color to render text in </param>
        /// <param name="scaleFactor">Size of text</param>
        /// <exception cref="Exception">set a Yaff Font</exception>
        public void DrawYaffText(int xPos, int yPos, string text,
                                 Color color, ScaleFactor scaleFactor = ScaleFactor.X1)
        {
            if (CurrentFont == null)
            {
                throw new Exception("CurrentFont must be set before calling DrawYaffText.");
            }
            else if (!(CurrentFont is IYaffFont))
            {
                throw new Exception("CurrentFont must be YaffFont");
            }

            IYaffFont yaffFont = (IYaffFont)CurrentFont;
            CursorX = xPos;
            CursorY = yPos;

            // each character
            for (int i = 0; i < text.Length; i++)
            {
                var c = yaffFont.GlyphLines(text[i]);
                (var lb, var rb) = yaffFont.GetBearing(text[i]);

                // Detect wrapping first, so we have the actual width of the charcter not the ifont width of the font
                var cw = (int)scaleFactor * (lb + yaffFont.GetWidth(text[i]) + rb);
                if (WrapText && (xPos >= display.Width - cw))
                {
                    xPos = CursorX;
                    CursorY += (c[0].Length + 1) * (int)scaleFactor;
                }

                xPos += lb * (int)scaleFactor; // left bearing
                foreach (var line in c)
                {
                    var j = -(int)scaleFactor;
                    foreach (var p in line)
                    {
                        j += (int)scaleFactor;
                        if (p.Equals(YaffConst.ink))
                        {
                            for (var k = 0; k < (int)scaleFactor; k++)
                                for (var l = 0; l < (int)scaleFactor; l++)
                                    DrawPixel(xPos + k, CursorY + j + l, color);
                        }
                    }
                    xPos += (int)scaleFactor;
                }
                xPos += rb * (int)scaleFactor; // right bearing
            }
        }

        public void DrawBigCenteredText(string text, Color color, bool clear = true, bool show = true)
        {
            if (clear)
                Clear(true);

            ScaleFactor big = ScaleFactor.X3;
            DrawText(((int)display.Width - CurrentFont.Width * text.Length * (int)big) / 2,
                      ((int)display.Height - CurrentFont.Height * (int)big) / 2,
                      text, color, big);
            if (show)
                Show();
        }

    }

    public static class Extensions
    {
        public static bool GetBit(this byte b, int bitNumber)
        {
            return (b & (1 << bitNumber)) != 0;
        }
    }
}