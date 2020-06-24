using System;
using System.Threading;
using Meadow;
using Meadow.Devices;
using Meadow.Foundation;
using Meadow.Foundation.Displays.Tft;
using Meadow.Foundation.Graphics;
using Meadow.Hardware;

namespace MeadowFontTest
{
    public class MeadowApp : App<F7Micro, MeadowApp>
    {
        St7789 display;
        GraphicsLibrary graphics;
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

            }

            void Showfont(FontBase font, Color c)
            {
                graphics.Clear();
                graphics.CurrentFont = font;
                CharacterTest(c);
                Thread.Sleep(5000);
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

                graphics = new GraphicsLibrary(display);

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
                graphics.DrawText(0, yPos, "Consolas12x20: 0Og", Color.BlueViolet);
                yPos += 22;

                graphics.CurrentFont = new IBMPlexMono12x20();
                graphics.DrawText(0, yPos, "IBMPlexMono12x20: 0Og", Color.DarkGoldenrod);
                yPos += 22;

                graphics.CurrentFont = new SometypeMono12x20();
                graphics.DrawText(0, yPos, "SometypeMono12x20: 0Og", Color.DarkOrange);
                yPos += 22;

                graphics.CurrentFont = new BPtypewrite12x20();
                graphics.DrawText(0, yPos, "BPtypewrite12x20: 0Og", Color.BurlyWood);
                yPos += 22;

                graphics.Show();
            }


        }
    }
}