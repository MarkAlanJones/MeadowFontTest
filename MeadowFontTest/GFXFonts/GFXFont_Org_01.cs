// Org_v01 by Orgdot (www.orgdot.com/aliasfonts).  A tiny,
// stylized font with all characters within a 6 pixel height.



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

    public class GFXFont_Org_01 : GFXFontBase
    {
        static readonly byte[] Org_01Bitmaps = {
    0xE8, 0xA0, 0x57, 0xD5, 0xF5, 0x00, 0xFD, 0x3E, 0x5F, 0x80, 0x88, 0x88,
    0x88, 0x80, 0xF4, 0xBF, 0x2E, 0x80, 0x80, 0x6A, 0x40, 0x95, 0x80, 0xAA,
    0x80, 0x5D, 0x00, 0xC0, 0xF0, 0x80, 0x08, 0x88, 0x88, 0x00, 0xFC, 0x63,
    0x1F, 0x80, 0xF8, 0xF8, 0x7F, 0x0F, 0x80, 0xF8, 0x7E, 0x1F, 0x80, 0x8C,
    0x7E, 0x10, 0x80, 0xFC, 0x3E, 0x1F, 0x80, 0xFC, 0x3F, 0x1F, 0x80, 0xF8,
    0x42, 0x10, 0x80, 0xFC, 0x7F, 0x1F, 0x80, 0xFC, 0x7E, 0x1F, 0x80, 0x90,
    0xB0, 0x2A, 0x22, 0xF0, 0xF0, 0x88, 0xA8, 0xF8, 0x4E, 0x02, 0x00, 0xFD,
    0x6F, 0x0F, 0x80, 0xFC, 0x7F, 0x18, 0x80, 0xF4, 0x7D, 0x1F, 0x00, 0xFC,
    0x21, 0x0F, 0x80, 0xF4, 0x63, 0x1F, 0x00, 0xFC, 0x3F, 0x0F, 0x80, 0xFC,
    0x3F, 0x08, 0x00, 0xFC, 0x2F, 0x1F, 0x80, 0x8C, 0x7F, 0x18, 0x80, 0xF9,
    0x08, 0x4F, 0x80, 0x78, 0x85, 0x2F, 0x80, 0x8D, 0xB1, 0x68, 0x80, 0x84,
    0x21, 0x0F, 0x80, 0xFD, 0x6B, 0x5A, 0x80, 0xFC, 0x63, 0x18, 0x80, 0xFC,
    0x63, 0x1F, 0x80, 0xFC, 0x7F, 0x08, 0x00, 0xFC, 0x63, 0x3F, 0x80, 0xFC,
    0x7F, 0x29, 0x00, 0xFC, 0x3E, 0x1F, 0x80, 0xF9, 0x08, 0x42, 0x00, 0x8C,
    0x63, 0x1F, 0x80, 0x8C, 0x62, 0xA2, 0x00, 0xAD, 0x6B, 0x5F, 0x80, 0x8A,
    0x88, 0xA8, 0x80, 0x8C, 0x54, 0x42, 0x00, 0xF8, 0x7F, 0x0F, 0x80, 0xEA,
    0xC0, 0x82, 0x08, 0x20, 0x80, 0xD5, 0xC0, 0x54, 0xF8, 0x80, 0xF1, 0xFF,
    0x8F, 0x99, 0xF0, 0xF8, 0x8F, 0x1F, 0x99, 0xF0, 0xFF, 0x8F, 0x6B, 0xA4,
    0xF9, 0x9F, 0x10, 0x8F, 0x99, 0x90, 0xF0, 0x55, 0xC0, 0x8A, 0xF9, 0x90,
    0xF8, 0xFD, 0x63, 0x10, 0xF9, 0x99, 0xF9, 0x9F, 0xF9, 0x9F, 0x80, 0xF9,
    0x9F, 0x20, 0xF8, 0x88, 0x47, 0x1F, 0x27, 0xC8, 0x42, 0x00, 0x99, 0x9F,
    0x99, 0x97, 0x8C, 0x6B, 0xF0, 0x96, 0x69, 0x99, 0x9F, 0x10, 0x2E, 0x8F,
    0x2B, 0x22, 0xF8, 0x89, 0xA8, 0x0F, 0xE0};

        static readonly GFXglyph[] Org_01Glyphs = {
                                         new GFXglyph(0, 0, 0, 6, 0, 1),     // 0x20 ' '
                                         new GFXglyph(0, 1, 5, 2, 0, -4),    // 0x21 '!'
                                         new GFXglyph(1, 3, 1, 4, 0, -4),    // 0x22 '"'
                                         new GFXglyph(2, 5, 5, 6, 0, -4),    // 0x23 '#'
                                         new GFXglyph(6, 5, 5, 6, 0, -4),    // 0x24 '$'
                                         new GFXglyph(10, 5, 5, 6, 0, -4),   // 0x25 '%'
                                         new GFXglyph(14, 5, 5, 6, 0, -4),   // 0x26 '&'
                                         new GFXglyph(18, 1, 1, 2, 0, -4),   // 0x27 '''
                                         new GFXglyph(19, 2, 5, 3, 0, -4),   // 0x28 '('
                                         new GFXglyph(21, 2, 5, 3, 0, -4),   // 0x29 ')'
                                         new GFXglyph(23, 3, 3, 4, 0, -3),   // 0x2A '*'
                                         new GFXglyph(25, 3, 3, 4, 0, -3),   // 0x2B '+'
                                         new GFXglyph(27, 1, 2, 2, 0, 0),    // 0x2C ','
                                         new GFXglyph(28, 4, 1, 5, 0, -2),   // 0x2D '-'
                                         new GFXglyph(29, 1, 1, 2, 0, 0),    // 0x2E '.'
                                         new GFXglyph(30, 5, 5, 6, 0, -4),   // 0x2F '/'
                                         new GFXglyph(34, 5, 5, 6, 0, -4),   // 0x30 '0'
                                         new GFXglyph(38, 1, 5, 2, 0, -4),   // 0x31 '1'
                                         new GFXglyph(39, 5, 5, 6, 0, -4),   // 0x32 '2'
                                         new GFXglyph(43, 5, 5, 6, 0, -4),   // 0x33 '3'
                                         new GFXglyph(47, 5, 5, 6, 0, -4),   // 0x34 '4'
                                         new GFXglyph(51, 5, 5, 6, 0, -4),   // 0x35 '5'
                                         new GFXglyph(55, 5, 5, 6, 0, -4),   // 0x36 '6'
                                         new GFXglyph(59, 5, 5, 6, 0, -4),   // 0x37 '7'
                                         new GFXglyph(63, 5, 5, 6, 0, -4),   // 0x38 '8'
                                         new GFXglyph(67, 5, 5, 6, 0, -4),   // 0x39 '9'
                                         new GFXglyph(71, 1, 4, 2, 0, -3),   // 0x3A ':'
                                         new GFXglyph(72, 1, 4, 2, 0, -3),   // 0x3B ';'
                                         new GFXglyph(73, 3, 5, 4, 0, -4),   // 0x3C '<'
                                         new GFXglyph(75, 4, 3, 5, 0, -3),   // 0x3D '='
                                         new GFXglyph(77, 3, 5, 4, 0, -4),   // 0x3E '>'
                                         new GFXglyph(79, 5, 5, 6, 0, -4),   // 0x3F '?'
                                         new GFXglyph(83, 5, 5, 6, 0, -4),   // 0x40 '@'
                                         new GFXglyph(87, 5, 5, 6, 0, -4),   // 0x41 'A'
                                         new GFXglyph(91, 5, 5, 6, 0, -4),   // 0x42 'B'
                                         new GFXglyph(95, 5, 5, 6, 0, -4),   // 0x43 'C'
                                         new GFXglyph(99, 5, 5, 6, 0, -4),   // 0x44 'D'
                                         new GFXglyph(103, 5, 5, 6, 0, -4),  // 0x45 'E'
                                         new GFXglyph(107, 5, 5, 6, 0, -4),  // 0x46 'F'
                                         new GFXglyph(111, 5, 5, 6, 0, -4),  // 0x47 'G'
                                         new GFXglyph(115, 5, 5, 6, 0, -4),  // 0x48 'H'
                                         new GFXglyph(119, 5, 5, 6, 0, -4),  // 0x49 'I'
                                         new GFXglyph(123, 5, 5, 6, 0, -4),  // 0x4A 'J'
                                         new GFXglyph(127, 5, 5, 6, 0, -4),  // 0x4B 'K'
                                         new GFXglyph(131, 5, 5, 6, 0, -4),  // 0x4C 'L'
                                         new GFXglyph(135, 5, 5, 6, 0, -4),  // 0x4D 'M'
                                         new GFXglyph(139, 5, 5, 6, 0, -4),  // 0x4E 'N'
                                         new GFXglyph(143, 5, 5, 6, 0, -4),  // 0x4F 'O'
                                         new GFXglyph(147, 5, 5, 6, 0, -4),  // 0x50 'P'
                                         new GFXglyph(151, 5, 5, 6, 0, -4),  // 0x51 'Q'
                                         new GFXglyph(155, 5, 5, 6, 0, -4),  // 0x52 'R'
                                         new GFXglyph(159, 5, 5, 6, 0, -4),  // 0x53 'S'
                                         new GFXglyph(163, 5, 5, 6, 0, -4),  // 0x54 'T'
                                         new GFXglyph(167, 5, 5, 6, 0, -4),  // 0x55 'U'
                                         new GFXglyph(171, 5, 5, 6, 0, -4),  // 0x56 'V'
                                         new GFXglyph(175, 5, 5, 6, 0, -4),  // 0x57 'W'
                                         new GFXglyph(179, 5, 5, 6, 0, -4),  // 0x58 'X'
                                         new GFXglyph(183, 5, 5, 6, 0, -4),  // 0x59 'Y'
                                         new GFXglyph(187, 5, 5, 6, 0, -4),  // 0x5A 'Z'
                                         new GFXglyph(191, 2, 5, 3, 0, -4),  // 0x5B '['
                                         new GFXglyph(193, 5, 5, 6, 0, -4),  // 0x5C '\'
                                         new GFXglyph(197, 2, 5, 3, 0, -4),  // 0x5D ']'
                                         new GFXglyph(199, 3, 2, 4, 0, -4),  // 0x5E '^'
                                         new GFXglyph(200, 5, 1, 6, 0, 1),   // 0x5F '_'
                                         new GFXglyph(201, 1, 1, 2, 0, -4),  // 0x60 '`'
                                         new GFXglyph(202, 4, 4, 5, 0, -3),  // 0x61 'a'
                                         new GFXglyph(204, 4, 5, 5, 0, -4),  // 0x62 'b'
                                         new GFXglyph(207, 4, 4, 5, 0, -3),  // 0x63 'c'
                                         new GFXglyph(209, 4, 5, 5, 0, -4),  // 0x64 'd'
                                         new GFXglyph(212, 4, 4, 5, 0, -3),  // 0x65 'e'
                                         new GFXglyph(214, 3, 5, 4, 0, -4),  // 0x66 'f'
                                         new GFXglyph(216, 4, 5, 5, 0, -3),  // 0x67 'g'
                                         new GFXglyph(219, 4, 5, 5, 0, -4),  // 0x68 'h'
                                         new GFXglyph(222, 1, 4, 2, 0, -3),  // 0x69 'i'
                                         new GFXglyph(223, 2, 5, 3, 0, -3),  // 0x6A 'j'
                                         new GFXglyph(225, 4, 5, 5, 0, -4),  // 0x6B 'k'
                                         new GFXglyph(228, 1, 5, 2, 0, -4),  // 0x6C 'l'
                                         new GFXglyph(229, 5, 4, 6, 0, -3),  // 0x6D 'm'
                                         new GFXglyph(232, 4, 4, 5, 0, -3),  // 0x6E 'n'
                                         new GFXglyph(234, 4, 4, 5, 0, -3),  // 0x6F 'o'
                                         new GFXglyph(236, 4, 5, 5, 0, -3),  // 0x70 'p'
                                         new GFXglyph(239, 4, 5, 5, 0, -3),  // 0x71 'q'
                                         new GFXglyph(242, 4, 4, 5, 0, -3),  // 0x72 'r'
                                         new GFXglyph(244, 4, 4, 5, 0, -3),  // 0x73 's'
                                         new GFXglyph(246, 5, 5, 6, 0, -4),  // 0x74 't'
                                         new GFXglyph(250, 4, 4, 5, 0, -3),  // 0x75 'u'
                                         new GFXglyph(252, 4, 4, 5, 0, -3),  // 0x76 'v'
                                         new GFXglyph(254, 5, 4, 6, 0, -3),  // 0x77 'w'
                                         new GFXglyph(257, 4, 4, 5, 0, -3),  // 0x78 'x'
                                         new GFXglyph(259, 4, 5, 5, 0, -3),  // 0x79 'y'
                                         new GFXglyph(262, 4, 4, 5, 0, -3),  // 0x7A 'z'
                                         new GFXglyph(264, 3, 5, 4, 0, -4),  // 0x7B '{'
                                         new GFXglyph(266, 1, 5, 2, 0, -4),  // 0x7C '|'
                                         new GFXglyph(267, 3, 5, 4, 0, -4),  // 0x7D '}'
                                         new GFXglyph(269, 5, 3, 6, 0, -3)}; // 0x7E '~'


        public GFXFont_Org_01()
        {
            gfxfont = new GFXfont(Org_01Bitmaps, Org_01Glyphs, 0x20, 0x7E, 7);
        }
        // Approx. 943 bytes
    }
}