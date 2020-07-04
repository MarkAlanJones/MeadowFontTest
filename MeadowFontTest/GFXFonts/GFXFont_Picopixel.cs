// Picopixel by Sebastian Weber.  A tiny font
// with all characters within a 6 pixel height.



namespace Meadow.Foundation.Graphics
{

    /*    Software License Agreement (BSD License)

   Copyright (c) 2012 Adafruit Industries.  All rights reserved.

   Redistribution and use in source and binary forms, with or without
   modification, are permitted provided that the following conditions are met:

   - Redistributions of source code must retain the above copyright notice,
     this list of conditions and the following disclaimer.
   - Redistributions in binary form must reproduce the above copyright notice,
     this list of conditions and the following disclaimer in the documentation
     and/or other materials provided with the distribution.

   THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
   AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
   IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
   ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
   LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
   CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
   SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
   INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
   CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
   ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
   POSSIBILITY OF SUCH DAMAGE.
   © 2020 GitHub, Inc.  */

    public class GFXFont_Picopixel : GFXFontBase
    {
        static readonly byte[] PicopixelBitmaps = {
    0xE8, 0xB4, 0x57, 0xD5, 0xF5, 0x00, 0x4E, 0x3E, 0x80, 0xA5, 0x4A, 0x4A,
    0x5A, 0x50, 0xC0, 0x6A, 0x40, 0x95, 0x80, 0xAA, 0x80, 0x5D, 0x00, 0x60,
    0xE0, 0x80, 0x25, 0x48, 0x56, 0xD4, 0x75, 0x40, 0xC5, 0x4E, 0xC5, 0x1C,
    0x97, 0x92, 0xF3, 0x1C, 0x53, 0x54, 0xE5, 0x48, 0x55, 0x54, 0x55, 0x94,
    0xA0, 0x46, 0x64, 0xE3, 0x80, 0x98, 0xC5, 0x04, 0x56, 0xC6, 0x57, 0xDA,
    0xD7, 0x5C, 0x72, 0x46, 0xD6, 0xDC, 0xF3, 0xCE, 0xF3, 0x48, 0x72, 0xD4,
    0xB7, 0xDA, 0xF8, 0x24, 0xD4, 0xBB, 0x5A, 0x92, 0x4E, 0x8E, 0xEB, 0x58,
    0x80, 0x9D, 0xB9, 0x90, 0x56, 0xD4, 0xD7, 0x48, 0x56, 0xD4, 0x40, 0xD7,
    0x5A, 0x71, 0x1C, 0xE9, 0x24, 0xB6, 0xD4, 0xB6, 0xA4, 0x8C, 0x6B, 0x55,
    0x00, 0xB5, 0x5A, 0xB5, 0x24, 0xE5, 0x4E, 0xEA, 0xC0, 0x91, 0x12, 0xD5,
    0xC0, 0x54, 0xF0, 0x90, 0xC7, 0xF0, 0x93, 0x5E, 0x71, 0x80, 0x25, 0xDE,
    0x5E, 0x30, 0x6E, 0x80, 0x77, 0x9C, 0x93, 0x5A, 0xB8, 0x45, 0x60, 0x92,
    0xEA, 0xAA, 0x40, 0xD5, 0x6A, 0xD6, 0x80, 0x55, 0x00, 0xD7, 0x40, 0x75,
    0x90, 0xE8, 0x71, 0xE0, 0xBA, 0x40, 0xB5, 0x80, 0xB5, 0x00, 0x8D, 0x54,
    0xAA, 0x80, 0xAC, 0xE0, 0xE5, 0x70, 0x6A, 0x26, 0xFC, 0xC8, 0xAC, 0x5A};

        static readonly GFXglyph[] PicopixelGlyphs = {
            new GFXglyph(0, 0, 0, 2, 0, 1),     // 0x20 ' '
                                            new GFXglyph(0, 1, 5, 2, 0, -4),    // 0x21 '!'
                                            new GFXglyph(1, 3, 2, 4, 0, -4),    // 0x22 '"'
                                            new GFXglyph(2, 5, 5, 6, 0, -4),    // 0x23 '#'
                                            new GFXglyph(6, 3, 6, 4, 0, -4),    // 0x24 '$'
                                            new GFXglyph(9, 3, 5, 4, 0, -4),    // 0x25 '%'
                                            new GFXglyph(11, 4, 5, 5, 0, -4),   // 0x26 '&'
                                            new GFXglyph(14, 1, 2, 2, 0, -4),   // 0x27 '''
                                            new GFXglyph(15, 2, 5, 3, 0, -4),   // 0x28 '('
                                            new GFXglyph(17, 2, 5, 3, 0, -4),   // 0x29 ')'
                                            new GFXglyph(19, 3, 3, 4, 0, -3),   // 0x2A '*'
                                            new GFXglyph(21, 3, 3, 4, 0, -3),   // 0x2B '+'
                                            new GFXglyph(23, 2, 2, 3, 0, 0),    // 0x2C ','
                                            new GFXglyph(24, 3, 1, 4, 0, -2),   // 0x2D '-'
                                            new GFXglyph(25, 1, 1, 2, 0, 0),    // 0x2E '.'
                                            new GFXglyph(26, 3, 5, 4, 0, -4),   // 0x2F '/'
                                            new GFXglyph(28, 3, 5, 4, 0, -4),   // 0x30 '0'
                                            new GFXglyph(30, 2, 5, 3, 0, -4),   // 0x31 '1'
                                            new GFXglyph(32, 3, 5, 4, 0, -4),   // 0x32 '2'
                                            new GFXglyph(34, 3, 5, 4, 0, -4),   // 0x33 '3'
                                            new GFXglyph(36, 3, 5, 4, 0, -4),   // 0x34 '4'
                                            new GFXglyph(38, 3, 5, 4, 0, -4),   // 0x35 '5'
                                            new GFXglyph(40, 3, 5, 4, 0, -4),   // 0x36 '6'
                                            new GFXglyph(42, 3, 5, 4, 0, -4),   // 0x37 '7'
                                            new GFXglyph(44, 3, 5, 4, 0, -4),   // 0x38 '8'
                                            new GFXglyph(46, 3, 5, 4, 0, -4),   // 0x39 '9'
                                            new GFXglyph(48, 1, 3, 2, 0, -3),   // 0x3A ':'
                                            new GFXglyph(49, 2, 4, 3, 0, -3),   // 0x3B ';'
                                            new GFXglyph(50, 2, 3, 3, 0, -3),   // 0x3C '<'
                                            new GFXglyph(51, 3, 3, 4, 0, -3),   // 0x3D '='
                                            new GFXglyph(53, 2, 3, 3, 0, -3),   // 0x3E '>'
                                            new GFXglyph(54, 3, 5, 4, 0, -4),   // 0x3F '?'
                                            new GFXglyph(56, 3, 5, 4, 0, -4),   // 0x40 '@'
                                            new GFXglyph(58, 3, 5, 4, 0, -4),   // 0x41 'A'
                                            new GFXglyph(60, 3, 5, 4, 0, -4),   // 0x42 'B'
                                            new GFXglyph(62, 3, 5, 4, 0, -4),   // 0x43 'C'
                                            new GFXglyph(64, 3, 5, 4, 0, -4),   // 0x44 'D'
                                            new GFXglyph(66, 3, 5, 4, 0, -4),   // 0x45 'E'
                                            new GFXglyph(68, 3, 5, 4, 0, -4),   // 0x46 'F'
                                            new GFXglyph(70, 3, 5, 4, 0, -4),   // 0x47 'G'
                                            new GFXglyph(72, 3, 5, 4, 0, -4),   // 0x48 'H'
                                            new GFXglyph(74, 1, 5, 2, 0, -4),   // 0x49 'I'
                                            new GFXglyph(75, 3, 5, 4, 0, -4),   // 0x4A 'J'
                                            new GFXglyph(77, 3, 5, 4, 0, -4),   // 0x4B 'K'
                                            new GFXglyph(79, 3, 5, 4, 0, -4),   // 0x4C 'L'
                                            new GFXglyph(81, 5, 5, 6, 0, -4),   // 0x4D 'M'
                                            new GFXglyph(85, 4, 5, 5, 0, -4),   // 0x4E 'N'
                                            new GFXglyph(88, 3, 5, 4, 0, -4),   // 0x4F 'O'
                                            new GFXglyph(90, 3, 5, 4, 0, -4),   // 0x50 'P'
                                            new GFXglyph(92, 3, 6, 4, 0, -4),   // 0x51 'Q'
                                            new GFXglyph(95, 3, 5, 4, 0, -4),   // 0x52 'R'
                                            new GFXglyph(97, 3, 5, 4, 0, -4),   // 0x53 'S'
                                            new GFXglyph(99, 3, 5, 4, 0, -4),   // 0x54 'T'
                                            new GFXglyph(101, 3, 5, 4, 0, -4),  // 0x55 'U'
                                            new GFXglyph(103, 3, 5, 4, 0, -4),  // 0x56 'V'
                                            new GFXglyph(105, 5, 5, 6, 0, -4),  // 0x57 'W'
                                            new GFXglyph(109, 3, 5, 4, 0, -4),  // 0x58 'X'
                                            new GFXglyph(111, 3, 5, 4, 0, -4),  // 0x59 'Y'
                                            new GFXglyph(113, 3, 5, 4, 0, -4),  // 0x5A 'Z'
                                            new GFXglyph(115, 2, 5, 3, 0, -4),  // 0x5B '['
                                            new GFXglyph(117, 3, 5, 4, 0, -4),  // 0x5C '\'
                                            new GFXglyph(119, 2, 5, 3, 0, -4),  // 0x5D ']'
                                            new GFXglyph(121, 3, 2, 4, 0, -4),  // 0x5E '^'
                                            new GFXglyph(122, 4, 1, 4, 0, 1),   // 0x5F '_'
                                            new GFXglyph(123, 2, 2, 3, 0, -4),  // 0x60 '`'
                                            new GFXglyph(124, 3, 4, 4, 0, -3),  // 0x61 'a'
                                            new GFXglyph(126, 3, 5, 4, 0, -4),  // 0x62 'b'
                                            new GFXglyph(128, 3, 3, 4, 0, -2),  // 0x63 'c'
                                            new GFXglyph(130, 3, 5, 4, 0, -4),  // 0x64 'd'
                                            new GFXglyph(132, 3, 4, 4, 0, -3),  // 0x65 'e'
                                            new GFXglyph(134, 2, 5, 3, 0, -4),  // 0x66 'f'
                                            new GFXglyph(136, 3, 5, 4, 0, -3),  // 0x67 'g'
                                            new GFXglyph(138, 3, 5, 4, 0, -4),  // 0x68 'h'
                                            new GFXglyph(140, 1, 5, 2, 0, -4),  // 0x69 'i'
                                            new GFXglyph(141, 2, 6, 3, 0, -4),  // 0x6A 'j'
                                            new GFXglyph(143, 3, 5, 4, 0, -4),  // 0x6B 'k'
                                            new GFXglyph(145, 2, 5, 3, 0, -4),  // 0x6C 'l'
                                            new GFXglyph(147, 5, 3, 6, 0, -2),  // 0x6D 'm'
                                            new GFXglyph(149, 3, 3, 4, 0, -2),  // 0x6E 'n'
                                            new GFXglyph(151, 3, 3, 4, 0, -2),  // 0x6F 'o'
                                            new GFXglyph(153, 3, 4, 4, 0, -2),  // 0x70 'p'
                                            new GFXglyph(155, 3, 4, 4, 0, -2),  // 0x71 'q'
                                            new GFXglyph(157, 2, 3, 3, 0, -2),  // 0x72 'r'
                                            new GFXglyph(158, 3, 4, 4, 0, -3),  // 0x73 's'
                                            new GFXglyph(160, 2, 5, 3, 0, -4),  // 0x74 't'
                                            new GFXglyph(162, 3, 3, 4, 0, -2),  // 0x75 'u'
                                            new GFXglyph(164, 3, 3, 4, 0, -2),  // 0x76 'v'
                                            new GFXglyph(166, 5, 3, 6, 0, -2),  // 0x77 'w'
                                            new GFXglyph(168, 3, 3, 4, 0, -2),  // 0x78 'x'
                                            new GFXglyph(170, 3, 4, 4, 0, -2),  // 0x79 'y'
                                            new GFXglyph(172, 3, 4, 4, 0, -3),  // 0x7A 'z'
                                            new GFXglyph(174, 3, 5, 4, 0, -4),  // 0x7B '{'
                                            new GFXglyph(176, 1, 6, 2, 0, -4),  // 0x7C '|'
                                            new GFXglyph(177, 3, 5, 4, 0, -4),  // 0x7D '}'
                                            new GFXglyph(179, 4, 2, 5, 0, -3)}; // 0x7E '~'


        public GFXFont_Picopixel()
        {
            gfxfont = new GFXfont(PicopixelBitmaps, PicopixelGlyphs, 0x20, 0x7E, 7);
        }
        // Approx. 852 bytes
    }
}
