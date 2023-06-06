using Meadow;
using Meadow.Devices;
using Meadow.Foundation;
using Meadow.Foundation.Displays;
using Meadow.Foundation.Graphics;
using Meadow.Foundation.MyExtensions;
using Meadow.Hardware;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using YaffReader;

namespace MeadowFontTest
{
    public class MeadowApp : App<F7FeatherV1>
    {
        St7789 display;
        MicroGraphicsEx graphics;
        const int displayWidth = 240;
        const int displayHeight = 240;
        private readonly Random rand = new Random();

        long allocated;

        public override Task Run()
        {
            while (graphics != null)
            {
                graphics.CurrentFont = new Font8x16();
                graphics.DrawBigCenteredText("Meadow", Color.LawnGreen, clear: true, show: true);
                Thread.Sleep(2000);

                Showfont(new Font12x20(), Color.LawnGreen);
                Showfont(new Font8x16(), Color.LightSalmon); // new rc1

                graphics.CurrentFont = new IBMPlexMono12x20();
                graphics.DrawBigCenteredText("Convert", Color.DeepSkyBlue, clear: true, show: true);
                Thread.Sleep(2000);
                // consolas has a type initializer fault that is fatal in rc1 & rc2
                // Showfont(new Consolas12x20(), Color.CornflowerBlue);

                Showfont(new IBMPlexMono12x20(), Color.DeepSkyBlue);
                Showfont(new SometypeMono12x20(), Color.DeepPink);
                Showfont(new BPtypewrite12x20(), Color.DarkGreen);
                Showfont(new ibm327012x20(), Color.AliceBlue);

                graphics.CurrentFont = new MSFont8x15();
                graphics.DrawBigCenteredText(".NetMF", Color.LightYellow, clear: true, show: true);
                Thread.Sleep(2000);
                Showfont(new MSFont8x8(), Color.LightYellow);
                Showfont(new MSFont8x15(), Color.LightYellow);

                graphics.CurrentFont = new Petscii8x8();
                graphics.DrawBigCenteredText("PETscii", Color.Green, clear: true, show: true);
                Thread.Sleep(2000);
                // unicode PETscii with symbols from 1977 Commodore PET
                Showfont(new Petscii8x8(), Color.Green);

                FontTest();
                Thread.Sleep(5000);

                graphics.CurrentFont = new Font8x16();
                graphics.DrawBigCenteredText("GFX", Color.Orange, clear: true, show: true);
                Thread.Sleep(2000);
                GFXFonts();
                Thread.Sleep(5000);

                // Fixed width fonts 12px or thinner
                // Wider Fixed Width fonts 
                // note pick a yaff font that the base drawtext can deal with for DBCT
                // Proportional Mac Lisa others
                graphics.CurrentFont = YaffFont.GetFont(MeadowOS.FileSystem.UserFileSystemRoot + "Terminal_8514.yaff");
                graphics.DrawBigCenteredText("Yaff", Color.LightSteelBlue, clear: true, show: true);
                Thread.Sleep(2000);
                YaffFont3();
            }
            return base.Run();
        }

        public override Task Initialize()
        {
            Console.WriteLine("Initializing...");

            var spiBus = Device.CreateSpiBus(Device.Pins.SCK, Device.Pins.MOSI, Device.Pins.MISO);

            display = new St7789(
                spiBus: spiBus,
                chipSelectPin: null,
                dcPin: Device.Pins.D01,
                resetPin: Device.Pins.D00,
                width: displayWidth, height: displayHeight);

            graphics = new MicroGraphicsEx(display)
            {
                Rotation = RotationType._90Degrees,
                Stroke = 1
            };

            allocated = GC.GetAllocatedBytesForCurrentThread();

            graphics.Clear();
            return base.Initialize();
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

        /// <summary>
        /// Show anyfont based on type
        /// </summary>
        void Showfont(IFont font, Color c, ScaleFactor x = ScaleFactor.X1)
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
            else if (font is IYaffFont yafffont)
            {
                // Write the name of the Font at the Top
                graphics.CurrentFont = new Font6x8();
                if (font is YaffPropFont)
                    graphics.PenColor = Color.Orange;
                else
                    graphics.PenColor = Color.LawnGreen;
                graphics.DrawText(0, 0, yafffont.Name);
                Console.WriteLine($"{yafffont.Name}");

                // Display the Font
                graphics.CurrentFont = font;
                YaffCharacterTest(c, x);
            }
            else
            {
                graphics.CurrentFont = font;
                CharacterTest(c);
            }

            MonitorMemory();
            Thread.Sleep(1000);
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

            // 8
            graphics.CurrentFont = new Font8x8();
            graphics.DrawText(0, yPos, "Font_8x8: ABCDEFabcdefg123@#$%", Color.Orange);
            yPos += 10;

            graphics.CurrentFont = new Font8x12();
            graphics.DrawText(0, yPos, "Font_8x12: ABCDEFabcde123@#$%", Color.Yellow);
            yPos += 14;

            graphics.CurrentFont = new Font8x16(); // new rc1
            graphics.DrawText(0, yPos, "Font_8x16: ABCDEFabcde123@#$%", Color.LightSalmon);
            yPos += 18;

            // 12
            graphics.CurrentFont = new Font12x16();
            graphics.DrawText(0, yPos, "Font_12x16: ABCdefg123@#$", Color.LawnGreen);
            yPos += 18;

            graphics.CurrentFont = new Font12x20();
            graphics.DrawText(0, yPos, "Font_12x20: ABCdef123@#$", Color.Cyan);
            yPos += 22;

            // custom
            // consolas has a type initializer fault that is fatal in rc1
            //graphics.CurrentFont = new Consolas12x20();
            //graphics.DrawText(0, yPos, "Consolas12x20: 0Og123@#$", Color.BlueViolet);
            //yPos += 22;

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

        // font returns space for missing characters 
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

        #region New For Yaff

        /// <summary>
        ///  Show all Yaff Fonts in directory - Yaff Fonts are file based, not compiled
        /// </summary>
        private void YaffFont3()
        {
            var sortedYaffFiles = Directory.GetFiles(MeadowOS.FileSystem.UserFileSystemRoot, "*.yaff")
                                 .OrderBy(name => name);
            foreach (var x in sortedYaffFiles)
            {
                try
                {
                    Console.WriteLine(x);
                    var yaff = new YaYaffReader(x);
                    var yf = yaff.Load_Yaff();

                    graphics.CurrentFont = yf;

                    Showfont(yf, Color.LightSteelBlue, ScaleFactor.X1);
                    Thread.Sleep(500);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + " for " + x);
                }
            }

            CultofAtari();

            Apples();
            Thread.Sleep(5000);

        }

        private void YaffCharacterTest(Color c, ScaleFactor x = ScaleFactor.X1)
        {
            var msg = new StringBuilder();

            int yPos = 12;

            foreach (var ch in ((IYaffFont)(graphics.CurrentFont)).CharMap)
                msg.Append(ch.ToString());
            msg.Append((char)0xFFF); // a missing "default" char at end - blank in some fonts

            graphics.WrapText = true;
            Console.WriteLine($"{msg.Length - 1} chars in Yaff font");

            // note for fixed yaff fonts that are 12px or smaller and aligned on a nybble boundary
            // you can use the stardard DrawText
            graphics.DrawYaffText(12, yPos, msg.ToString(), c, x);
            Console.WriteLine(msg);

            graphics.Show();
            Console.WriteLine("");
        }

        // Easter Egg Characters from Atari?
        private void CultofAtari()
        {
            var fonts = new List<string>()
            {
                "atari-st-6x6.yaff",
                "atari-st-8x8.yaff",
                "atari-st-8x16.yaff",
                "atari-st-16x32.yaff",
            };

            string atariLogo = UnicodeToChar("f82a") + UnicodeToChar("f82b");
            string bobtop = UnicodeToChar("f82c") + UnicodeToChar("f82d");
            string bobbot = UnicodeToChar("f82e") + UnicodeToChar("f82f");

            var loadedfonts = new List<IYaffFont>();
            foreach (var f in fonts)
                loadedfonts.Add(YaffFont.GetFont(MeadowOS.FileSystem.UserFileSystemRoot + f));

            int[] lineoffset = { 2, 0, 0, 0 };

            graphics.WrapText = false;
            graphics.Clear();
            for (var i = 0; i < 50; i++)
            {
                ScaleFactor s = ScaleFactor.X1;
                var sr = rand.Next(4);
                if (sr == 3)
                    s = ScaleFactor.X4;
                else if (sr == 2)
                    s = ScaleFactor.X3;
                else if (sr == 1)
                    s = ScaleFactor.X2;

                var fontnum = rand.Next(3);
                graphics.CurrentFont = loadedfonts[fontnum];

                if (rand.Next(2) == 0)
                {
                    // bob
                    var x = rand.Next(displayWidth);
                    var y = rand.Next(displayHeight);
                    var c = RandColor();

                    graphics.DrawYaffText(x, y, bobtop, c, s);
                    var y2 = y + (graphics.CurrentFont.Height - lineoffset[fontnum]) * (int)s;
                    graphics.DrawYaffText(x, y2, bobbot, c, s);
                }
                else
                {
                    // logo
                    graphics.DrawYaffText(rand.Next(displayWidth),
                                          rand.Next(displayHeight),
                                          atariLogo, RandColor(), s);

                }
            }
            graphics.Show();
        }

        private void Apples()
        {
            var fonts = new List<string>()
            {
                "Chicago_12.yaff",
                "Courier_18.yaff",
                "Cream_12.yaff",
                "Espy_Sans_16.yaff",
                "Espy_Sans_Bold_12.yaff",
                "Espy_Sans_Bold_14.yaff",
                "Espy_Serif_Bold_14.yaff",
                "eWorld_Tight_18.yaff",
                "Helvetica_12.yaff",
                "Palatino_14.yaff",
                "Palatino_18.yaff",
                "Symbol_12.yaff",
                "Symbol_18.yaff",
                "System_Text.yaff",       // Lisa
                "Window_Manager.yaff",    // Lisa
            };

            string apple = UnicodeToChar("f8ff");
            string applecream = UnicodeToChar("00c4");
            string lisaapple = UnicodeToChar("0e");
            string lisawin = UnicodeToChar("8f");

            var loadedfonts = new List<IYaffFont>();
            foreach (var f in fonts)
                loadedfonts.Add(YaffFont.GetFont(MeadowOS.FileSystem.UserFileSystemRoot + f));

            graphics.WrapText = false;
            graphics.Clear();
            for (var i = 0; i < 75; i++)
            {
                ScaleFactor s = ScaleFactor.X1;
                var sr = rand.Next(4);
                if (sr == 3)
                    s = ScaleFactor.X4;
                if (sr == 2)
                    s = ScaleFactor.X3;
                if (sr == 1)
                    s = ScaleFactor.X2;

                var fontnum = rand.Next(loadedfonts.Count);
                graphics.CurrentFont = loadedfonts[fontnum];

                // why does this font have the apple at a differnt character?
                string c = apple;
                if (loadedfonts[fontnum].Name == "Cream Regular 12")
                    c = applecream;
                else if (loadedfonts[fontnum].Name == "System Text")
                    c = lisaapple;
                else if (loadedfonts[fontnum].Name == "Window Manager")
                    c = lisawin;

                graphics.DrawYaffText(rand.Next(displayWidth),
                                      rand.Next(displayHeight),
                                      c, RandColor(), s);

            }
            graphics.Show();
        }

        private static string UnicodeToChar(string hex)
        {
            int code = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
            string unicodeString = char.ConvertFromUtf32(code);
            return unicodeString;
        }

        private Color RandColor()
        {
            return Color.FromRgb(rand.Next(255), rand.Next(255), rand.Next(255));
        }

        #endregion
    }
}
