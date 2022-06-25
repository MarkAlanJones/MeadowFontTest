using Meadow;
using Meadow.Devices;
using Meadow.Foundation;
using Meadow.Foundation.Displays.TftSpi;
using Meadow.Foundation.Graphics;
using Meadow.Foundation.MyExtensions;
using Meadow.Hardware;
using System;
using System.Linq;
using System.Threading;

namespace MeadowFontTest
{
    public class MeadowApp : App<F7FeatherV1, MeadowApp>
    {
        St7789 display;
        MicroGraphicsEx graphics;
        const int displayWidth = 240;
        const int displayHeight = 240;

        long allocated;

        public MeadowApp()
        {
            Initialize();

            while (true)
            {
                Showfont(new Font12x20(), Color.LawnGreen);
                Showfont(new Consolas12x20(), Color.CornflowerBlue);
                Showfont(new IBMPlexMono12x20(), Color.DeepSkyBlue);
                Showfont(new SometypeMono12x20(), Color.DeepPink);
                Showfont(new BPtypewrite12x20(), Color.DarkGreen);
                Showfont(new ibm327012x20(), Color.AliceBlue);

                Showfont(new MSFont8x8(), Color.LightYellow);
                Showfont(new MSFont8x15(), Color.LightYellow);

                // unicode PETscii with symbols from 1977 Commodore PET
                Showfont(new Petscii8x8(), Color.Green);

                FontTest();
                Thread.Sleep(5000);

                GFXFonts();
            }
        }

        void GFXFonts()
        {
            // GFX Fonts
            // Free Mono - Normal Bold Oblique BoldOblique - 9 12 18 24 (16 fonts)
            Showfont(new GFXFont_FreeMono9pt7b(), Color.Orange);
            Showfont(new GFXFont_FreeMono12pt7b(), Color.Orange);
            Showfont(new GFXFont_FreeMono18pt7b(), Color.Orange);
            Showfont(new GFXFont_FreeMono24pt7b(), Color.Orange);

            Showfont(new GFXFont_FreeMonoBold9pt7b(), Color.Orange);
            Showfont(new GFXFont_FreeMonoBold12pt7b(), Color.Orange);
            Showfont(new GFXFont_FreeMonoBold18pt7b(), Color.Orange);
            Showfont(new GFXFont_FreeMonoBold24pt7b(), Color.Orange);

            Showfont(new GFXFont_FreeMonoOblique9pt7b(), Color.Orange);
            Showfont(new GFXFont_FreeMonoOblique12pt7b(), Color.Orange);
            Showfont(new GFXFont_FreeMonoOblique18pt7b(), Color.Orange);
            Showfont(new GFXFont_FreeMonoOblique24pt7b(), Color.Orange);

            Showfont(new GFXFont_FreeMonoBoldOblique9pt7b(), Color.Orange);
            Showfont(new GFXFont_FreeMonoBoldOblique12pt7b(), Color.Orange);
            Showfont(new GFXFont_FreeMonoBoldOblique18pt7b(), Color.Orange);
            Showfont(new GFXFont_FreeMonoBoldOblique24pt7b(), Color.Orange);

            // Free Sans - Normal Bold Oblique BoldOblique - 9 12 18 24 (16 fonts)
            Showfont(new GFXFont_FreeSans9pt7b(), Color.YellowGreen);
            Showfont(new GFXFont_FreeSans12pt7b(), Color.YellowGreen);
            Showfont(new GFXFont_FreeSans18pt7b(), Color.YellowGreen);
            Showfont(new GFXFont_FreeSans24pt7b(), Color.YellowGreen);

            Showfont(new GFXFont_FreeSansBold9pt7b(), Color.YellowGreen);
            Showfont(new GFXFont_FreeSansBold12pt7b(), Color.YellowGreen);
            Showfont(new GFXFont_FreeSansBold18pt7b(), Color.YellowGreen);
            Showfont(new GFXFont_FreeSansBold24pt7b(), Color.YellowGreen);

            Showfont(new GFXFont_FreeSansOblique9pt7b(), Color.YellowGreen);
            Showfont(new GFXFont_FreeSansOblique12pt7b(), Color.YellowGreen);
            Showfont(new GFXFont_FreeSansOblique18pt7b(), Color.YellowGreen);
            Showfont(new GFXFont_FreeSansOblique24pt7b(), Color.YellowGreen);

            Showfont(new GFXFont_FreeSansBoldOblique9pt7b(), Color.YellowGreen);
            Showfont(new GFXFont_FreeSansBoldOblique12pt7b(), Color.YellowGreen);
            Showfont(new GFXFont_FreeSansBoldOblique18pt7b(), Color.YellowGreen);
            Showfont(new GFXFont_FreeSansBoldOblique24pt7b(), Color.YellowGreen);

            // Free Serif - Normal Bold Italic BoldItalic - 9 12 18 24 (16 fonts)
            Showfont(new GFXFont_FreeSerif9pt7b(), Color.GreenYellow);
            Showfont(new GFXFont_FreeSerif12pt7b(), Color.GreenYellow);
            Showfont(new GFXFont_FreeSerif18pt7b(), Color.GreenYellow);
            Showfont(new GFXFont_FreeSerif24pt7b(), Color.GreenYellow);

            Showfont(new GFXFont_FreeSerifBold9pt7b(), Color.GreenYellow);
            Showfont(new GFXFont_FreeSerifBold12pt7b(), Color.GreenYellow);
            Showfont(new GFXFont_FreeSerifBold18pt7b(), Color.GreenYellow);
            Showfont(new GFXFont_FreeSerifBold24pt7b(), Color.GreenYellow);

            Showfont(new GFXFont_FreeSerifItalic9pt7b(), Color.GreenYellow);
            Showfont(new GFXFont_FreeSerifItalic12pt7b(), Color.GreenYellow);
            Showfont(new GFXFont_FreeSerifItalic18pt7b(), Color.GreenYellow);
            Showfont(new GFXFont_FreeSerifItalic24pt7b(), Color.GreenYellow);

            Showfont(new GFXFont_FreeSerifBoldItalic9pt7b(), Color.GreenYellow);
            Showfont(new GFXFont_FreeSerifBoldItalic12pt7b(), Color.GreenYellow);
            Showfont(new GFXFont_FreeSerifBoldItalic18pt7b(), Color.GreenYellow);
            Showfont(new GFXFont_FreeSerifBoldItalic24pt7b(), Color.GreenYellow);

            // 4 Extra (small) Fonts
            // Org_01 6x6
            // PicoPixel 6x6
            // Tiny3x3
            // TomThumb 4x5 - extended characters
            Showfont(new GFXFont_Org_01(), Color.CornflowerBlue);
            Showfont(new GFXFont_Picopixel(), Color.Orange);
            Showfont(new GFXFont_Tiny3x3a2pt7b(), Color.LawnGreen);
            Showfont(new GFXFont_TomThumb(), Color.GreenYellow);
        }

        void Showfont(IFont font, Color c)
        {
            graphics.Clear();

            graphics.CurrentFont = font;
            Console.WriteLine(font.GetType().Name);

            if (font is GFXFontBase)
            {
                graphics.CurrentFont = new Font8x12();
                graphics.DrawText(3, 3, font.GetType().Name.Replace("GFXFont_", "").Replace("7b", ""), Color.LawnGreen);

                graphics.CurrentFont = font;
                GFXCharacterTest(c);
            }
            else if (font.GetType().Name == "Petscii8x8" || font.GetType().Name == "ibm327012x20")
            {
                graphics.CurrentFont = font;
                UnicodeTest(c);
            }
            else
            {
                graphics.CurrentFont = font;
                CharacterTest(c);
            }

            MonitorMemory();
            Thread.Sleep(1000);
        }

        void Initialize()
        {
            Console.WriteLine("Initializing...");

            var config = new SpiClockConfiguration(St7789.DefaultSpiBusSpeed, SpiClockConfiguration.Mode.Mode3);
            var spiBus = Device.CreateSpiBus(Device.Pins.SCK, Device.Pins.MOSI, Device.Pins.MISO, config);

            display = new St7789(
                device: Device,
                spiBus: spiBus,
                chipSelectPin: null,
                dcPin: Device.Pins.D01,
                resetPin: Device.Pins.D00,
                width: displayWidth, height: displayHeight)
            {
                IgnoreOutOfBoundsPixels = true
            };

            graphics = new MicroGraphicsEx(display)
            {
                Rotation = RotationType._270Degrees,
                Stroke = 1
            };

            allocated = GC.GetAllocatedBytesForCurrentThread();

            graphics.Clear();
        }

        void CharacterTest(Color c)
        {
            string msg = string.Empty;

            int yPos = 12;
            int count = 0;

            for (int i = 32; i < 254; i++)
            {
                if (i == 127)
                    i += 33;

                if (count >= ((displayWidth - 24) / graphics.CurrentFont.Width) || i >= 254)
                {
                    graphics.DrawText(12, yPos, msg, c);
                    Console.WriteLine(msg);
                    yPos += (int)(graphics.CurrentFont.Height + 4);

                    count = 0;
                    msg = string.Empty;
                }

                msg += (char)(i);
                count++;
            }

            graphics.Show();
            Console.WriteLine();
        }

        void FontTest()
        {
            graphics.Clear();

            int yPos = 0;

            graphics.CurrentFont = new Font4x6(); //new b4.6
            graphics.DrawText(0, yPos, "Font_4x6: ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmno123@#$%", Color.Cornsilk);
            yPos += 8;

            graphics.CurrentFont = new Font4x8();
            graphics.DrawText(0, yPos, "Font_4x8: ABCDEFGHIJKLMNOPQRSTUVWXabcdefghijklmno123@#$%", Color.Red);
            yPos += 10;

            graphics.CurrentFont = new Font6x8(); //new b.4.6
            graphics.DrawText(0, yPos, "Font_6x8: ABCDEFGHIJKLMNOPabcdefghi123@#$%", Color.Aquamarine);
            yPos += 10;

            graphics.CurrentFont = new Font8x8();
            graphics.DrawText(0, yPos, "Font_8x8: ABCDEFabcdefg123@#$%", Color.Orange);
            yPos += 10;

            graphics.CurrentFont = new Font8x12();
            graphics.DrawText(0, yPos, "Font_8x12: ABCDEFabcde123@#$%", Color.Yellow);
            yPos += 14;

            graphics.CurrentFont = new Font12x16();
            graphics.DrawText(0, yPos, "Font_12x16: ABCdefg123@#$", Color.LawnGreen);
            yPos += 18;

            graphics.CurrentFont = new Font12x20();
            graphics.DrawText(0, yPos, "Font_12x20: ABCdef123@#$", Color.Cyan);
            yPos += 22;

            graphics.CurrentFont = new Consolas12x20();
            graphics.DrawText(0, yPos, "Consolas12x20: 0Og123@#$", Color.BlueViolet);
            yPos += 22;

            graphics.CurrentFont = new IBMPlexMono12x20();
            graphics.DrawText(0, yPos, "IBMPlexMono12x20: 0Og123@#$", Color.DarkGoldenrod);
            yPos += 22;

            graphics.CurrentFont = new SometypeMono12x20();
            graphics.DrawText(0, yPos, "SometypeMono12x20: 0Og123@#$", Color.DarkOrange);
            yPos += 22;

            graphics.CurrentFont = new BPtypewrite12x20();
            graphics.DrawText(0, yPos, "BPtypewrite12x20: 0Og123@#$", Color.BurlyWood);
            yPos += 22;

            graphics.CurrentFont = new ibm327012x20();
            graphics.DrawText(0, yPos, "ibm327012x20: 0Og123@#$", Color.AliceBlue);
            yPos += 22;

            graphics.CurrentFont = new MSFont8x8();
            graphics.DrawText(0, yPos, "MSFont8x8: ABCdefg12345@#$%Ø¶Æ" + (char)0xa5, Color.Goldenrod);
            yPos += 10;

            graphics.CurrentFont = new MSFont8x15();
            graphics.DrawText(0, yPos, "MSFont8x15: ABCdefg12345@#$%Ø¶Æ" + (char)0xa5, Color.Gold);
            yPos += 18;

            graphics.CurrentFont = new Petscii8x8();
            graphics.DrawText(0, yPos, "Petscii8x8: ABCdef123@#$" + (char)0x2592 + (char)0x2593 + (char)0x25cf + (char)0x25f7 + (char)0x25f8, Color.Green);
            yPos += 12;

            graphics.Show();
        }

        // Variable Width but only low ascii characters
        // character position is the baseline left not the upper left
        // !"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\]^_`abcdefghijklmnopqrstuvwxyz{|}~
        void GFXCharacterTest(Color c)
        {
            string msg = string.Empty;
            int yPos = Math.Max(12 + ((GFXFontBase)graphics.CurrentFont).Height, 24);

            for (int i = ((GFXFontBase)graphics.CurrentFont).first; i <= ((GFXFontBase)graphics.CurrentFont).last; i++)
                msg += (char)(i);

            graphics.WrapText = true;
            graphics.DrawGFXText(12, yPos, msg, c);
            Console.WriteLine(msg);

            graphics.Show();
            Console.WriteLine();
        }

        // Display all characters upto FFFF skip blanks
        // can display all characters at 1X, 2X or 3X
        void UnicodeTest(Color c, ScaleFactor x = ScaleFactor.X1)
        {
            string msg = string.Empty;

            int yPos = 12;
            int count = 0;

            for (int i = 32; i <= 0xFFFF; i++)
            {
                if (i == 127)
                    i += 33;
                // skip the empty bits
                if (i == 0x0200)
                    i += 0xc6;
                else if (i == 0x0300)
                    i += 0xb1;
                else if (i == 0x0400)
                    i = 0x1D00;
                else if (i == 0x1E00)
                    i = 0x2190;
                else if (i == 0x2400)
                    i = 0x2500;
                else if (i == 0x2800)
                    i = 0xF100;
                else if (i == 0xF200)
                    i = 0xFE00;
                else if (i > 0xFF3F)
                    i = 0xFFFF;

                if (count >= ((displayWidth - 24) / graphics.CurrentFont.Width / (int)x) || i >= 0xFFFF)
                {
                    graphics.DrawText(12, yPos, msg, c, x);
                    Console.WriteLine(msg);
                    yPos += graphics.CurrentFont.Height * (int)x + 8;

                    count = 0;
                    msg = string.Empty;
                }

                if (i == 0x20 || CharExists(i))
                {
                    msg += (char)(i);
                    count++;
                }
            }

            graphics.Show();
            Console.WriteLine();
        }

        // font returns space for missing chacters 
        // false for all 0 - true when a non zero byte is found
        bool CharExists(int i)
        {
            var raw = graphics.CurrentFont[(char)i];
            return raw.Any(b => b > 0);
        }

        void MonitorMemory()
        {
            // Garbage Collector knows about memory use 
            long totalmem = GC.GetTotalMemory(false);  // forcing Garbage collection hangs app!
                                                       // the total number of bytes allocated on the managed heap during the lifetime of a thread,
                                                       // NOT the total number of bytes that have survived garbage collection.               
            long used = GC.GetAllocatedBytesForCurrentThread() - allocated;
            Console.WriteLine($"GC Total {totalmem:n0} bytes and last font allocated {used:n0} bytes");
            allocated = GC.GetAllocatedBytesForCurrentThread();
        }

    }
}
