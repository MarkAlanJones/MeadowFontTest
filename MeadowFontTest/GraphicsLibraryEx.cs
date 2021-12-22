using Meadow.Foundation.Displays;
using Meadow.Foundation.Graphics;
using System;

namespace Meadow.Foundation.MyExtensions
{

    // Extend the GraphicsLibrary 
    public class MicroGraphicsEx : MicroGraphics
    {
        IGraphicsDisplay display;

        public MicroGraphicsEx(IGraphicsDisplay display) : base(display)
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
                        CursorY += ((GFXFontBase)CurrentFont).yAdvance;
                    }
                }
            }

        }

    }

    public static class extensions
    {
        public static bool GetBit(this byte b, int bitNumber)
        {
            return (b & (1 << bitNumber)) != 0;
        }
    }
}