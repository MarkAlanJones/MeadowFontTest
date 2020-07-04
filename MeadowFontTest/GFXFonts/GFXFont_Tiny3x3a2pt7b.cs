/**
** The FontStruction “Tiny3x3a”
** (https://fontstruct.com/fontstructions/show/670512) by “Michaelangel007” is
** licensed under a Creative Commons Attribution Non-commercial Share Alike
*license
** (http://creativecommons.org/licenses/by-nc-sa/3.0/).
** “Tiny3x3a” was originally cloned (copied) from the FontStruction
** “CHECKER” (https://fontstruct.com/fontstructions/show/2391) by Wolf grant
** Grant, which is licensed under a Creative Commons Attribution Non-commercial
** Share Alike license (http://creativecommons.org/licenses/by-nc-sa/3.0/).
*
* Converted by eadmaster with fontconvert
**/



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

    public class GFXFont_Tiny3x3a2pt7b : GFXFontBase
    {
        static readonly byte[] Tiny3x3a2pt7bBitmaps = {
    0xC0, 0xB4, 0xBF, 0x80, 0x6B, 0x00, 0xDD, 0x80, 0x59, 0x80, 0x80, 0x64,
    0x98, 0xF0, 0x5D, 0x00, 0xC0, 0xE0, 0x80, 0x2A, 0x00, 0x55, 0x00, 0x94,
    0xC9, 0x80, 0xEF, 0x80, 0xBC, 0x80, 0x6B, 0x00, 0x9F, 0x80, 0xE4, 0x80,
    0x7F, 0x00, 0xFC, 0x80, 0xA0, 0x58, 0x64, 0xE3, 0x80, 0x98, 0xD8, 0xD8,
    0x80, 0x5E, 0x80, 0xDF, 0x80, 0x71, 0x80, 0xD7, 0x00, 0xFB, 0x80, 0xFA,
    0x00, 0xD7, 0x80, 0xBE, 0x80, 0xE0, 0x27, 0x00, 0xBA, 0x80, 0x93, 0x80,
    0xFE, 0x80, 0xF6, 0x80, 0xF7, 0x80, 0xFE, 0x00, 0xF7, 0x00, 0xDE, 0x80,
    0x6B, 0x00, 0xE9, 0x00, 0xB7, 0x80, 0xB5, 0x00, 0xBF, 0x80, 0xAA, 0x80,
    0xA9, 0x00, 0xEB, 0x80, 0xEC, 0x88, 0x80, 0xDC, 0x54, 0xE0, 0x90, 0x70,
    0xBC, 0xF0, 0x7C, 0xB0, 0x68, 0xFC, 0xBC, 0xC0, 0x58, 0x9A, 0x80, 0xA4,
    0xDC, 0xD4, 0xF0, 0xF8, 0xF4, 0xE0, 0x60, 0x59, 0x80, 0xBC, 0xA8, 0xEC,
    0xF0, 0xAC, 0x80, 0x90, 0x79, 0x80, 0xF0, 0xCF, 0x00, 0x78};

        static readonly GFXglyph[] Tiny3x3a2pt7bGlyphs = {
    new GFXglyph(0, 0, 0, 4, 0, 1),     // 0x20 ' '
    new GFXglyph(0, 1, 2, 3, 1, -2),    // 0x21 '!'
    new GFXglyph(1, 3, 2, 4, 0, -2),    // 0x22 '"'
    new GFXglyph(2, 3, 3, 4, 0, -2),    // 0x23 '#'
    new GFXglyph(4, 3, 3, 4, 0, -2),    // 0x24 '$'
    new GFXglyph(6, 3, 3, 4, 0, -2),    // 0x25 '%'
    new GFXglyph(8, 3, 3, 4, 0, -2),    // 0x26 '&'
    new GFXglyph(10, 1, 1, 3, 1, -2),   // 0x27 '''
    new GFXglyph(11, 2, 3, 3, 0, -2),   // 0x28 '('
    new GFXglyph(12, 2, 3, 4, 1, -2),   // 0x29 ')'
    new GFXglyph(13, 2, 2, 4, 1, -2),   // 0x2A '*'
    new GFXglyph(14, 3, 3, 4, 0, -2),   // 0x2B '+'
    new GFXglyph(16, 1, 2, 2, 0, 0),    // 0x2C ','
    new GFXglyph(17, 3, 1, 4, 0, -1),   // 0x2D '-'
    new GFXglyph(18, 1, 1, 2, 0, 0),    // 0x2E '.'
    new GFXglyph(19, 3, 3, 4, 0, -2),   // 0x2F '/'
    new GFXglyph(21, 3, 3, 4, 0, -2),   // 0x30 '0'
    new GFXglyph(23, 2, 3, 3, 0, -2),   // 0x31 '1'
    new GFXglyph(24, 3, 3, 4, 0, -2),   // 0x32 '2'
    new GFXglyph(26, 3, 3, 4, 0, -2),   // 0x33 '3'
    new GFXglyph(28, 3, 3, 4, 0, -2),   // 0x34 '4'
    new GFXglyph(30, 3, 3, 4, 0, -2),   // 0x35 '5'
    new GFXglyph(32, 3, 3, 4, 0, -2),   // 0x36 '6'
    new GFXglyph(34, 3, 3, 4, 0, -2),   // 0x37 '7'
    new GFXglyph(36, 3, 3, 4, 0, -2),   // 0x38 '8'
    new GFXglyph(38, 3, 3, 4, 0, -2),   // 0x39 '9'
    new GFXglyph(40, 1, 3, 3, 1, -2),   // 0x3A ':'
    new GFXglyph(41, 2, 3, 3, 0, -1),   // 0x3B ';'
    new GFXglyph(42, 2, 3, 3, 0, -2),   // 0x3C '<'
    new GFXglyph(43, 3, 3, 4, 0, -2),   // 0x3D '='
    new GFXglyph(45, 2, 3, 4, 1, -2),   // 0x3E '>'
    new GFXglyph(46, 2, 3, 4, 1, -2),   // 0x3F '?'
    new GFXglyph(47, 3, 3, 4, 0, -2),   // 0x40 '@'
    new GFXglyph(49, 3, 3, 4, 0, -2),   // 0x41 'A'
    new GFXglyph(51, 3, 3, 4, 0, -2),   // 0x42 'B'
    new GFXglyph(53, 3, 3, 4, 0, -2),   // 0x43 'C'
    new GFXglyph(55, 3, 3, 4, 0, -2),   // 0x44 'D'
    new GFXglyph(57, 3, 3, 4, 0, -2),   // 0x45 'E'
    new GFXglyph(59, 3, 3, 4, 0, -2),   // 0x46 'F'
    new GFXglyph(61, 3, 3, 4, 0, -2),   // 0x47 'G'
    new GFXglyph(63, 3, 3, 4, 0, -2),   // 0x48 'H'
    new GFXglyph(65, 1, 3, 3, 1, -2),   // 0x49 'I'
    new GFXglyph(66, 3, 3, 4, 0, -2),   // 0x4A 'J'
    new GFXglyph(68, 3, 3, 4, 0, -2),   // 0x4B 'K'
    new GFXglyph(70, 3, 3, 4, 0, -2),   // 0x4C 'L'
    new GFXglyph(72, 3, 3, 4, 0, -2),   // 0x4D 'M'
    new GFXglyph(74, 3, 3, 4, 0, -2),   // 0x4E 'N'
    new GFXglyph(76, 3, 3, 4, 0, -2),   // 0x4F 'O'
    new GFXglyph(78, 3, 3, 4, 0, -2),   // 0x50 'P'
    new GFXglyph(80, 3, 3, 4, 0, -2),   // 0x51 'Q'
    new GFXglyph(82, 3, 3, 4, 0, -2),   // 0x52 'R'
    new GFXglyph(84, 3, 3, 4, 0, -2),   // 0x53 'S'
    new GFXglyph(86, 3, 3, 4, 0, -2),   // 0x54 'T'
    new GFXglyph(88, 3, 3, 4, 0, -2),   // 0x55 'U'
    new GFXglyph(90, 3, 3, 4, 0, -2),   // 0x56 'V'
    new GFXglyph(92, 3, 3, 4, 0, -2),   // 0x57 'W'
    new GFXglyph(94, 3, 3, 4, 0, -2),   // 0x58 'X'
    new GFXglyph(96, 3, 3, 4, 0, -2),   // 0x59 'Y'
    new GFXglyph(98, 3, 3, 4, 0, -2),   // 0x5A 'Z'
    new GFXglyph(100, 2, 3, 3, 0, -2),  // 0x5B '['
    new GFXglyph(101, 3, 3, 4, 0, -2),  // 0x5C '\'
    new GFXglyph(103, 2, 3, 4, 1, -2),  // 0x5D ']'
    new GFXglyph(104, 3, 2, 4, 0, -2),  // 0x5E '^'
    new GFXglyph(105, 3, 1, 4, 0, 0),   // 0x5F '_'
    new GFXglyph(106, 2, 2, 3, 0, -2),  // 0x60 '`'
    new GFXglyph(107, 2, 2, 3, 0, -1),  // 0x61 'a'
    new GFXglyph(108, 2, 3, 3, 0, -2),  // 0x62 'b'
    new GFXglyph(109, 2, 2, 3, 0, -1),  // 0x63 'c'
    new GFXglyph(110, 2, 3, 3, 0, -2),  // 0x64 'd'
    new GFXglyph(111, 2, 2, 3, 0, -1),  // 0x65 'e'
    new GFXglyph(112, 2, 3, 3, 0, -2),  // 0x66 'f'
    new GFXglyph(113, 2, 3, 3, 0, -1),  // 0x67 'g'
    new GFXglyph(114, 2, 3, 3, 0, -2),  // 0x68 'h'
    new GFXglyph(115, 1, 2, 2, 0, -1),  // 0x69 'i'
    new GFXglyph(116, 2, 3, 3, 0, -1),  // 0x6A 'j'
    new GFXglyph(117, 3, 3, 4, 0, -2),  // 0x6B 'k'
    new GFXglyph(119, 2, 3, 3, 0, -2),  // 0x6C 'l'
    new GFXglyph(120, 3, 2, 4, 0, -1),  // 0x6D 'm'
    new GFXglyph(121, 3, 2, 4, 0, -1),  // 0x6E 'n'
    new GFXglyph(122, 2, 2, 3, 0, -1),  // 0x6F 'o'
    new GFXglyph(123, 2, 3, 3, 0, -1),  // 0x70 'p'
    new GFXglyph(124, 2, 3, 3, 0, -1),  // 0x71 'q'
    new GFXglyph(125, 2, 2, 3, 0, -1),  // 0x72 'r'
    new GFXglyph(126, 2, 2, 3, 0, -1),  // 0x73 's'
    new GFXglyph(127, 3, 3, 4, 0, -2),  // 0x74 't'
    new GFXglyph(129, 3, 2, 4, 0, -1),  // 0x75 'u'
    new GFXglyph(130, 3, 2, 4, 0, -1),  // 0x76 'v'
    new GFXglyph(131, 3, 2, 4, 0, -1),  // 0x77 'w'
    new GFXglyph(132, 2, 2, 3, 0, -1),  // 0x78 'x'
    new GFXglyph(133, 3, 3, 4, 0, -1),  // 0x79 'y'
    new GFXglyph(135, 2, 2, 3, 0, -1),  // 0x7A 'z'
    new GFXglyph(136, 3, 3, 4, 0, -2),  // 0x7B '{'
    new GFXglyph(138, 1, 4, 3, 1, -2),  // 0x7C '|'
    new GFXglyph(139, 3, 3, 4, 0, -2),  // 0x7D '}'
    new GFXglyph(141, 3, 2, 4, 0, -2)}; // 0x7E '~'

        public GFXFont_Tiny3x3a2pt7b()
        {
            gfxfont = new GFXfont(Tiny3x3a2pt7bBitmaps, Tiny3x3a2pt7bGlyphs, 0x20, 0x7E, 4);
        }
        // Approx. 814 bytes
    }
}