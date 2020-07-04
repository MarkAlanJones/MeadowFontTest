using System;
using System.Threading;
using Meadow;
using Meadow.Devices;
using Meadow.Foundation;
using Meadow.Foundation.Displays.Tft;
using Meadow.Foundation.Graphics;
using Meadow.Foundation.MyExtensions;
using Meadow.Hardware;

namespace MeadowFontTest
{
    public class MeadowApp : App<F7Micro, MeadowApp>
    {
        St7789 display;
        GraphicsLibraryEx graphics;
        const int displayWidth = 240;
        const int displayHeight = 240;


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

                FontTest();
                Thread.Sleep(5000);

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

            void Showfont(FontBase font, Color c)
            {
                graphics.Clear();

                graphics.CurrentFont = font;

                if (font is GFXFontBase)
                {
                    graphics.CurrentFont = new Font8x12();
                    graphics.DrawText(3, 3, font.GetType().Name.Replace("GFXFont_", "").Replace("7b", ""), Color.LawnGreen);
                   
                    graphics.CurrentFont = font;
                    GFXCharacterTest(c);
                }
                else
                {
                    graphics.CurrentFont = font;
                    CharacterTest(c);
                }
                Thread.Sleep(1000);
            }

            void Initialize()
            {
                Console.WriteLine("Initializing...");

                var config = new SpiClockConfiguration(48000, SpiClockConfiguration.Mode.Mode3);
                var spiBus = Device.CreateSpiBus(Device.Pins.SCK, Device.Pins.MOSI, Device.Pins.MISO, config);

                display = new St7789(
                    device: Device,
                    spiBus: spiBus,
                    chipSelectPin: null,
                    dcPin: Device.Pins.D01,
                    resetPin: Device.Pins.D00,
                    width: (uint)displayWidth, height: (uint)displayHeight);

                graphics = new GraphicsLibraryEx(display);

                graphics.Rotation = GraphicsLibrary.RotationType._270Degrees;
                graphics.Stroke = 1;

                display.Clear();
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

                    if (count >= 18 || i >= 254)
                    {
                        graphics.DrawText(12, yPos, msg, c);
                        Console.WriteLine(msg);
                        yPos += 24;

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

                graphics.CurrentFont = new Font4x8();
                graphics.DrawText(0, yPos, "Font_4x8: ABCdef123@#$", Color.Red);
                yPos += 12;

                graphics.CurrentFont = new Font8x8();
                graphics.DrawText(0, yPos, "Font_8x8: ABCdef123@#$", Color.Orange);
                yPos += 12;

                graphics.CurrentFont = new Font8x12();
                graphics.DrawText(0, yPos, "Font_8x12: ABCdef123@#$", Color.Yellow);
                yPos += 16;

                graphics.CurrentFont = new Font12x16();
                graphics.DrawText(0, yPos, "Font_12x16: ABCdef123@#$", Color.LawnGreen);
                yPos += 20;

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

        }
    }
}