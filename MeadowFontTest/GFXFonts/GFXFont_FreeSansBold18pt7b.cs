

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
   � 2020 GitHub, Inc.  */

    public class GFXFont_FreeSansBold18pt7b : GFXFontBase
    {
        static readonly byte[] FreeSansBold18pt7bBitmaps = {
    0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFE, 0xE7, 0x39, 0xCE, 0x73, 0x80,
    0x0F, 0xFF, 0xFF, 0xF8, 0xF8, 0xFF, 0xC7, 0xFE, 0x3F, 0xF1, 0xFF, 0x8F,
    0xFC, 0x7D, 0xC1, 0xCE, 0x0E, 0x70, 0x70, 0x03, 0xC3, 0x80, 0x3C, 0x78,
    0x03, 0xC7, 0x80, 0x38, 0x78, 0x07, 0x87, 0x07, 0xFF, 0xFF, 0x7F, 0xFF,
    0xF7, 0xFF, 0xFF, 0x7F, 0xFF, 0xF0, 0xF0, 0xE0, 0x0F, 0x0E, 0x00, 0xF1,
    0xE0, 0x0F, 0x1E, 0x00, 0xE1, 0xE0, 0xFF, 0xFF, 0xCF, 0xFF, 0xFC, 0xFF,
    0xFF, 0xCF, 0xFF, 0xFC, 0x1C, 0x3C, 0x03, 0xC3, 0x80, 0x3C, 0x78, 0x03,
    0xC7, 0x80, 0x38, 0x78, 0x03, 0x87, 0x80, 0x00, 0x60, 0x00, 0x7F, 0x80,
    0x3F, 0xFC, 0x0F, 0xFF, 0xC3, 0xFF, 0xFC, 0xFC, 0xDF, 0x9F, 0x19, 0xFB,
    0xC3, 0x1F, 0x78, 0x63, 0xEF, 0x8C, 0x01, 0xFD, 0x80, 0x1F, 0xF0, 0x01,
    0xFF, 0xC0, 0x1F, 0xFE, 0x00, 0x7F, 0xE0, 0x03, 0xFE, 0x00, 0x67, 0xE0,
    0x0C, 0x7F, 0xE1, 0x8F, 0xFC, 0x31, 0xFF, 0xC6, 0x3E, 0xFC, 0xDF, 0x9F,
    0xFF, 0xF1, 0xFF, 0xFC, 0x0F, 0xFF, 0x00, 0x7F, 0x80, 0x01, 0x80, 0x00,
    0x30, 0x00, 0x06, 0x00, 0x0F, 0x00, 0x1C, 0x01, 0xFE, 0x00, 0xE0, 0x1F,
    0xF8, 0x0E, 0x00, 0xFF, 0xC0, 0x70, 0x0F, 0x0F, 0x07, 0x00, 0x70, 0x38,
    0x38, 0x03, 0x81, 0xC3, 0x80, 0x1C, 0x0E, 0x3C, 0x00, 0xF0, 0xF1, 0xC0,
    0x03, 0xFF, 0x1C, 0x00, 0x1F, 0xF8, 0xE0, 0x00, 0x7F, 0x8E, 0x00, 0x00,
    0xF0, 0x70, 0xF8, 0x00, 0x07, 0x1F, 0xF0, 0x00, 0x39, 0xFF, 0xC0, 0x03,
    0x8F, 0xFE, 0x00, 0x1C, 0xF0, 0x78, 0x01, 0xC7, 0x01, 0xC0, 0x0C, 0x38,
    0x0E, 0x00, 0xE1, 0xC0, 0x70, 0x06, 0x0F, 0x07, 0x80, 0x70, 0x3F, 0xF8,
    0x07, 0x01, 0xFF, 0xC0, 0x38, 0x07, 0xFC, 0x03, 0x80, 0x0F, 0x80, 0x01,
    0xF0, 0x00, 0x1F, 0xE0, 0x00, 0xFF, 0xC0, 0x03, 0xFF, 0x80, 0x1F, 0x1E,
    0x00, 0x7C, 0x78, 0x01, 0xF1, 0xE0, 0x07, 0xE7, 0x80, 0x0F, 0xBC, 0x00,
    0x1F, 0xE0, 0x00, 0x3F, 0x00, 0x01, 0xF8, 0x00, 0x1F, 0xF0, 0xF0, 0xFF,
    0xE3, 0xC7, 0xE7, 0xCF, 0x3F, 0x0F, 0xF8, 0xF8, 0x3F, 0xE3, 0xE0, 0x7F,
    0x8F, 0x80, 0xFC, 0x3F, 0x03, 0xF0, 0x7E, 0x3F, 0xE1, 0xFF, 0xFF, 0x83,
    0xFF, 0xFF, 0x07, 0xFE, 0x7E, 0x07, 0xF0, 0xFC, 0xFF, 0xFF, 0xFF, 0xFD,
    0xCE, 0x70, 0x07, 0x87, 0x83, 0xC3, 0xC1, 0xE1, 0xE0, 0xF0, 0x78, 0x78,
    0x3C, 0x1E, 0x1E, 0x0F, 0x07, 0x83, 0xC1, 0xE0, 0xF0, 0x78, 0x3C, 0x1E,
    0x0F, 0x03, 0x81, 0xE0, 0xF0, 0x78, 0x1E, 0x0F, 0x03, 0x81, 0xE0, 0x70,
    0x3C, 0x0E, 0x07, 0x80, 0xF0, 0x38, 0x1E, 0x07, 0x83, 0xC0, 0xF0, 0x78,
    0x3C, 0x0F, 0x07, 0x83, 0xC0, 0xF0, 0x78, 0x3C, 0x1E, 0x0F, 0x07, 0x83,
    0xC1, 0xE0, 0xF0, 0x78, 0x78, 0x3C, 0x1E, 0x0F, 0x0F, 0x07, 0x87, 0x83,
    0xC1, 0xC1, 0xE0, 0xE0, 0xF0, 0x00, 0x06, 0x00, 0x60, 0x06, 0x07, 0x6E,
    0x7F, 0xE3, 0xFC, 0x0F, 0x01, 0xF8, 0x1F, 0x83, 0x9C, 0x10, 0x80, 0x03,
    0xC0, 0x03, 0xC0, 0x03, 0xC0, 0x03, 0xC0, 0x03, 0xC0, 0x03, 0xC0, 0xFF,
    0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x03, 0xC0, 0x03, 0xC0, 0x03,
    0xC0, 0x03, 0xC0, 0x03, 0xC0, 0x03, 0xC0, 0xFF, 0xFF, 0xFF, 0x8C, 0x63,
    0x37, 0xB0, 0xFF, 0xFF, 0xFF, 0xFF, 0xF0, 0xFF, 0xFF, 0xFF, 0x80, 0x01,
    0x81, 0xC0, 0xC0, 0x60, 0x70, 0x38, 0x18, 0x0C, 0x0E, 0x06, 0x03, 0x01,
    0x81, 0xC0, 0xC0, 0x60, 0x30, 0x38, 0x18, 0x0C, 0x0E, 0x07, 0x03, 0x01,
    0x81, 0xC0, 0xC0, 0x00, 0x07, 0xF0, 0x0F, 0xFE, 0x0F, 0xFF, 0x87, 0xFF,
    0xC7, 0xE3, 0xF3, 0xE0, 0xF9, 0xF0, 0x7D, 0xF0, 0x1F, 0xF8, 0x0F, 0xFC,
    0x07, 0xFE, 0x03, 0xFF, 0x01, 0xFF, 0x80, 0xFF, 0xC0, 0x7F, 0xE0, 0x3F,
    0xF0, 0x1F, 0xF8, 0x0F, 0xFC, 0x07, 0xDF, 0x07, 0xCF, 0x83, 0xE7, 0xE3,
    0xF1, 0xFF, 0xF0, 0xFF, 0xF8, 0x3F, 0xF8, 0x07, 0xF0, 0x00, 0x01, 0xC0,
    0xF0, 0x3C, 0x1F, 0x1F, 0xFF, 0xFF, 0xFF, 0xFF, 0x07, 0xC1, 0xF0, 0x7C,
    0x1F, 0x07, 0xC1, 0xF0, 0x7C, 0x1F, 0x07, 0xC1, 0xF0, 0x7C, 0x1F, 0x07,
    0xC1, 0xF0, 0x7C, 0x1F, 0x07, 0xC0, 0x07, 0xF0, 0x0F, 0xFE, 0x0F, 0xFF,
    0x8F, 0xFF, 0xE7, 0xE3, 0xF7, 0xE0, 0xFF, 0xE0, 0x3F, 0xF0, 0x1F, 0xF8,
    0x0F, 0x80, 0x07, 0xC0, 0x07, 0xE0, 0x03, 0xE0, 0x03, 0xF0, 0x03, 0xF0,
    0x07, 0xF0, 0x07, 0xF0, 0x07, 0xE0, 0x07, 0xE0, 0x07, 0xC0, 0x07, 0xC0,
    0x03, 0xE0, 0x03, 0xFF, 0xFD, 0xFF, 0xFE, 0xFF, 0xFF, 0x7F, 0xFF, 0x80,
    0x07, 0xE0, 0x0F, 0xFC, 0x0F, 0xFF, 0x0F, 0xFF, 0xCF, 0xC3, 0xF7, 0xC0,
    0xFB, 0xE0, 0x7D, 0xF0, 0x3E, 0x00, 0x1F, 0x00, 0x1F, 0x00, 0x0F, 0x80,
    0x3F, 0x80, 0x1F, 0xC0, 0x0F, 0xF0, 0x00, 0xFC, 0x00, 0x3F, 0x00, 0x0F,
    0xFC, 0x07, 0xFE, 0x03, 0xFF, 0x83, 0xF7, 0xC3, 0xF3, 0xFF, 0xF8, 0xFF,
    0xF8, 0x3F, 0xF8, 0x07, 0xF0, 0x00, 0x00, 0xFC, 0x00, 0xFC, 0x01, 0xFC,
    0x01, 0xFC, 0x03, 0xFC, 0x07, 0x7C, 0x07, 0x7C, 0x0E, 0x7C, 0x0E, 0x7C,
    0x1C, 0x7C, 0x18, 0x7C, 0x38, 0x7C, 0x70, 0x7C, 0x60, 0x7C, 0xE0, 0x7C,
    0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x7C, 0x00, 0x7C,
    0x00, 0x7C, 0x00, 0x7C, 0x00, 0x7C, 0x00, 0x7C, 0x1F, 0xFF, 0x0F, 0xFF,
    0x8F, 0xFF, 0xC7, 0xFF, 0xE3, 0xC0, 0x01, 0xE0, 0x00, 0xE0, 0x00, 0x70,
    0x00, 0x79, 0xF0, 0x3F, 0xFE, 0x1F, 0xFF, 0x8F, 0xFF, 0xE7, 0xC3, 0xF0,
    0x00, 0xFC, 0x00, 0x3E, 0x00, 0x1F, 0x00, 0x0F, 0x80, 0x07, 0xFE, 0x03,
    0xFF, 0x03, 0xFF, 0xC3, 0xF3, 0xFF, 0xF1, 0xFF, 0xF8, 0x3F, 0xF0, 0x07,
    0xE0, 0x00, 0x03, 0xF8, 0x03, 0xFF, 0x81, 0xFF, 0xF0, 0xFF, 0xFE, 0x3E,
    0x1F, 0x9F, 0x03, 0xE7, 0xC0, 0x03, 0xE0, 0x00, 0xF8, 0xF8, 0x3E, 0xFF,
    0x8F, 0xFF, 0xF3, 0xFF, 0xFE, 0xFE, 0x1F, 0xBF, 0x03, 0xFF, 0x80, 0x7F,
    0xE0, 0x1F, 0xF8, 0x07, 0xFE, 0x01, 0xF7, 0x80, 0x7D, 0xF0, 0x3E, 0x7E,
    0x1F, 0x8F, 0xFF, 0xC1, 0xFF, 0xF0, 0x3F, 0xF0, 0x03, 0xF0, 0x00, 0xFF,
    0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xF0, 0x00, 0xF0, 0x00, 0xF8,
    0x00, 0xF8, 0x00, 0x78, 0x00, 0x7C, 0x00, 0x3C, 0x00, 0x3E, 0x00, 0x1E,
    0x00, 0x1F, 0x00, 0x0F, 0x00, 0x0F, 0x80, 0x07, 0xC0, 0x03, 0xC0, 0x03,
    0xE0, 0x01, 0xF0, 0x00, 0xF8, 0x00, 0x78, 0x00, 0x7C, 0x00, 0x3E, 0x00,
    0x1F, 0x00, 0x0F, 0x80, 0x00, 0x07, 0xE0, 0x07, 0xFC, 0x0F, 0xFF, 0x07,
    0xFF, 0xC7, 0xC3, 0xF3, 0xC0, 0xF9, 0xE0, 0x3C, 0xF0, 0x1E, 0x78, 0x1F,
    0x1E, 0x1F, 0x07, 0xFF, 0x01, 0xFF, 0x03, 0xFF, 0xE3, 0xF1, 0xF9, 0xF0,
    0x7D, 0xF0, 0x1F, 0xF8, 0x0F, 0xFC, 0x07, 0xFE, 0x03, 0xFF, 0x83, 0xF7,
    0xC3, 0xF3, 0xFF, 0xF8, 0xFF, 0xF8, 0x3F, 0xF8, 0x07, 0xF0, 0x00, 0x07,
    0xE0, 0x0F, 0xFC, 0x0F, 0xFF, 0x0F, 0xFF, 0xC7, 0xE3, 0xF7, 0xE0, 0xFB,
    0xE0, 0x3D, 0xF0, 0x1F, 0xF8, 0x0F, 0xFC, 0x07, 0xFE, 0x03, 0xFF, 0x83,
    0xF7, 0xE3, 0xFB, 0xFF, 0xFC, 0xFF, 0xFE, 0x3F, 0xDF, 0x07, 0xCF, 0x80,
    0x07, 0x80, 0x03, 0xDF, 0x03, 0xE7, 0xC3, 0xE3, 0xFF, 0xF0, 0xFF, 0xF0,
    0x3F, 0xF0, 0x07, 0xE0, 0x00, 0xFF, 0xFF, 0xFF, 0x80, 0x00, 0x00, 0x00,
    0x00, 0x7F, 0xFF, 0xFF, 0xC0, 0xFF, 0xFF, 0xFF, 0x80, 0x00, 0x00, 0x00,
    0x00, 0x7F, 0xFF, 0xFF, 0xC6, 0x33, 0x9B, 0xD8, 0x00, 0x00, 0xC0, 0x00,
    0xF0, 0x01, 0xFC, 0x03, 0xFF, 0x03, 0xFF, 0x07, 0xFE, 0x0F, 0xFC, 0x03,
    0xF8, 0x00, 0xF0, 0x00, 0x3F, 0x80, 0x0F, 0xFC, 0x00, 0x7F, 0xE0, 0x07,
    0xFF, 0x00, 0x3F, 0xF0, 0x01, 0xFC, 0x00, 0x1F, 0x00, 0x00, 0xC0, 0xFF,
    0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xF0, 0x00, 0x00, 0x00, 0x00,
    0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF,
    0xF0, 0xC0, 0x00, 0x3C, 0x00, 0x0F, 0xE0, 0x03, 0xFF, 0x00, 0x3F, 0xF0,
    0x01, 0xFF, 0x80, 0x0F, 0xFC, 0x00, 0x7F, 0x00, 0x03, 0xC0, 0x07, 0xF0,
    0x0F, 0xFC, 0x1F, 0xF8, 0x3F, 0xF8, 0x3F, 0xF0, 0x0F, 0xE0, 0x03, 0xC0,
    0x00, 0xC0, 0x00, 0x00, 0x07, 0xF0, 0x07, 0xFF, 0x03, 0xFF, 0xF1, 0xFF,
    0xFC, 0x7E, 0x3F, 0xBF, 0x03, 0xFF, 0x80, 0x7F, 0xE0, 0x1F, 0xF8, 0x07,
    0xC0, 0x03, 0xF0, 0x01, 0xFC, 0x00, 0xFE, 0x00, 0x7F, 0x00, 0x3F, 0x80,
    0x1F, 0xC0, 0x07, 0xC0, 0x03, 0xE0, 0x00, 0xF0, 0x00, 0x3C, 0x00, 0x00,
    0x00, 0x00, 0x00, 0x00, 0xF8, 0x00, 0x3E, 0x00, 0x0F, 0x80, 0x03, 0xE0,
    0x00, 0xF8, 0x00, 0x00, 0x07, 0xFC, 0x00, 0x00, 0x3F, 0xFF, 0x00, 0x00,
    0xFF, 0xFF, 0xC0, 0x01, 0xF8, 0x07, 0xF0, 0x03, 0xE0, 0x01, 0xF8, 0x07,
    0x80, 0x00, 0x7C, 0x0F, 0x00, 0x00, 0x3C, 0x1E, 0x03, 0xE3, 0x9E, 0x3C,
    0x0F, 0xF7, 0x8E, 0x38, 0x1F, 0xFF, 0x0E, 0x78, 0x3E, 0x1F, 0x07, 0x70,
    0x38, 0x0F, 0x07, 0x70, 0x78, 0x0F, 0x07, 0xE0, 0x70, 0x0E, 0x07, 0xE0,
    0x70, 0x0E, 0x07, 0xE0, 0xE0, 0x0E, 0x07, 0xE0, 0xE0, 0x1E, 0x0F, 0xE0,
    0xE0, 0x1C, 0x0E, 0xE0, 0xE0, 0x3C, 0x1E, 0xE0, 0xF0, 0x3C, 0x3C, 0xF0,
    0xF0, 0xFC, 0x7C, 0x70, 0x7F, 0xFF, 0xF8, 0x78, 0x3F, 0xCF, 0xF0, 0x3C,
    0x1F, 0x07, 0xC0, 0x3E, 0x00, 0x00, 0x00, 0x1F, 0x00, 0x00, 0x00, 0x0F,
    0xC0, 0x01, 0x00, 0x07, 0xF0, 0x0F, 0x00, 0x03, 0xFF, 0xFF, 0x00, 0x00,
    0xFF, 0xFF, 0x00, 0x00, 0x1F, 0xF8, 0x00, 0x00, 0x7E, 0x00, 0x00, 0x7F,
    0x00, 0x00, 0x7F, 0x00, 0x00, 0xFF, 0x00, 0x00, 0xFF, 0x80, 0x01, 0xFF,
    0x80, 0x01, 0xFF, 0x80, 0x01, 0xF7, 0xC0, 0x03, 0xE7, 0xC0, 0x03, 0xE7,
    0xC0, 0x03, 0xE3, 0xE0, 0x07, 0xC3, 0xE0, 0x07, 0xC3, 0xE0, 0x07, 0xC1,
    0xF0, 0x0F, 0x81, 0xF0, 0x0F, 0x81, 0xF0, 0x0F, 0xFF, 0xF8, 0x1F, 0xFF,
    0xF8, 0x1F, 0xFF, 0xFC, 0x1F, 0xFF, 0xFC, 0x3E, 0x00, 0x7C, 0x3E, 0x00,
    0x7E, 0x3E, 0x00, 0x3E, 0x7C, 0x00, 0x3E, 0x7C, 0x00, 0x3F, 0x7C, 0x00,
    0x1F, 0xFF, 0xFC, 0x0F, 0xFF, 0xF0, 0xFF, 0xFF, 0x8F, 0xFF, 0xFC, 0xF8,
    0x07, 0xEF, 0x80, 0x3E, 0xF8, 0x03, 0xEF, 0x80, 0x3E, 0xF8, 0x03, 0xEF,
    0x80, 0x3E, 0xF8, 0x07, 0xCF, 0xFF, 0xF8, 0xFF, 0xFF, 0x0F, 0xFF, 0xF8,
    0xFF, 0xFF, 0xCF, 0x80, 0x7E, 0xF8, 0x01, 0xEF, 0x80, 0x1F, 0xF8, 0x01,
    0xFF, 0x80, 0x1F, 0xF8, 0x01, 0xFF, 0x80, 0x3E, 0xFF, 0xFF, 0xEF, 0xFF,
    0xFC, 0xFF, 0xFF, 0x8F, 0xFF, 0xE0, 0x00, 0xFF, 0x00, 0x07, 0xFF, 0x80,
    0x3F, 0xFF, 0xC0, 0xFF, 0xFF, 0xC3, 0xF8, 0x1F, 0x87, 0xE0, 0x1F, 0x9F,
    0x80, 0x1F, 0x3E, 0x00, 0x1F, 0x7C, 0x00, 0x3F, 0xF0, 0x00, 0x03, 0xE0,
    0x00, 0x07, 0xC0, 0x00, 0x0F, 0x80, 0x00, 0x1F, 0x00, 0x00, 0x3E, 0x00,
    0x00, 0x7C, 0x00, 0x00, 0xF8, 0x00, 0x00, 0xF8, 0x00, 0x7D, 0xF0, 0x00,
    0xFB, 0xF0, 0x03, 0xF3, 0xF0, 0x0F, 0xC7, 0xF0, 0x3F, 0x87, 0xFF, 0xFE,
    0x07, 0xFF, 0xF8, 0x03, 0xFF, 0xC0, 0x01, 0xFE, 0x00, 0xFF, 0xFC, 0x07,
    0xFF, 0xF8, 0x3F, 0xFF, 0xE1, 0xFF, 0xFF, 0x8F, 0x80, 0xFE, 0x7C, 0x01,
    0xF3, 0xE0, 0x07, 0xDF, 0x00, 0x3E, 0xF8, 0x01, 0xF7, 0xC0, 0x07, 0xFE,
    0x00, 0x3F, 0xF0, 0x01, 0xFF, 0x80, 0x0F, 0xFC, 0x00, 0x7F, 0xE0, 0x03,
    0xFF, 0x00, 0x1F, 0xF8, 0x00, 0xFF, 0xC0, 0x0F, 0xFE, 0x00, 0x7D, 0xF0,
    0x03, 0xEF, 0x80, 0x3E, 0x7C, 0x07, 0xF3, 0xFF, 0xFF, 0x1F, 0xFF, 0xF0,
    0xFF, 0xFF, 0x07, 0xFF, 0xE0, 0x00, 0xFF, 0xFF, 0xDF, 0xFF, 0xFB, 0xFF,
    0xFF, 0x7F, 0xFF, 0xEF, 0x80, 0x01, 0xF0, 0x00, 0x3E, 0x00, 0x07, 0xC0,
    0x00, 0xF8, 0x00, 0x1F, 0x00, 0x03, 0xE0, 0x00, 0x7F, 0xFF, 0xCF, 0xFF,
    0xF9, 0xFF, 0xFF, 0x3F, 0xFF, 0xE7, 0xC0, 0x00, 0xF8, 0x00, 0x1F, 0x00,
    0x03, 0xE0, 0x00, 0x7C, 0x00, 0x0F, 0x80, 0x01, 0xF0, 0x00, 0x3F, 0xFF,
    0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFC, 0xFF, 0xFF, 0xFF, 0xFF,
    0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x80, 0x07, 0xC0, 0x03, 0xE0, 0x01, 0xF0,
    0x00, 0xF8, 0x00, 0x7C, 0x00, 0x3E, 0x00, 0x1F, 0xFF, 0xEF, 0xFF, 0xF7,
    0xFF, 0xFB, 0xFF, 0xFD, 0xF0, 0x00, 0xF8, 0x00, 0x7C, 0x00, 0x3E, 0x00,
    0x1F, 0x00, 0x0F, 0x80, 0x07, 0xC0, 0x03, 0xE0, 0x01, 0xF0, 0x00, 0xF8,
    0x00, 0x7C, 0x00, 0x00, 0x00, 0x7F, 0x80, 0x03, 0xFF, 0xE0, 0x07, 0xFF,
    0xF8, 0x0F, 0xFF, 0xFC, 0x1F, 0xC0, 0xFE, 0x3F, 0x00, 0x7E, 0x7E, 0x00,
    0x3F, 0x7C, 0x00, 0x1F, 0x7C, 0x00, 0x00, 0xF8, 0x00, 0x00, 0xF8, 0x00,
    0x00, 0xF8, 0x00, 0x00, 0xF8, 0x03, 0xFF, 0xF8, 0x03, 0xFF, 0xF8, 0x03,
    0xFF, 0xF8, 0x03, 0xFF, 0xFC, 0x00, 0x0F, 0x7C, 0x00, 0x1F, 0x7C, 0x00,
    0x1F, 0x7E, 0x00, 0x3F, 0x3F, 0x00, 0x7F, 0x1F, 0xC1, 0xFF, 0x0F, 0xFF,
    0xFF, 0x07, 0xFF, 0xE7, 0x03, 0xFF, 0xC7, 0x00, 0xFF, 0x07, 0xF8, 0x01,
    0xFF, 0x80, 0x1F, 0xF8, 0x01, 0xFF, 0x80, 0x1F, 0xF8, 0x01, 0xFF, 0x80,
    0x1F, 0xF8, 0x01, 0xFF, 0x80, 0x1F, 0xF8, 0x01, 0xFF, 0x80, 0x1F, 0xFF,
    0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xF8, 0x01, 0xFF,
    0x80, 0x1F, 0xF8, 0x01, 0xFF, 0x80, 0x1F, 0xF8, 0x01, 0xFF, 0x80, 0x1F,
    0xF8, 0x01, 0xFF, 0x80, 0x1F, 0xF8, 0x01, 0xFF, 0x80, 0x1F, 0xF8, 0x01,
    0xFF, 0x80, 0x1F, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF,
    0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xC0, 0x00, 0x1F, 0x00, 0x1F,
    0x00, 0x1F, 0x00, 0x1F, 0x00, 0x1F, 0x00, 0x1F, 0x00, 0x1F, 0x00, 0x1F,
    0x00, 0x1F, 0x00, 0x1F, 0x00, 0x1F, 0x00, 0x1F, 0x00, 0x1F, 0x00, 0x1F,
    0x00, 0x1F, 0x00, 0x1F, 0xF8, 0x1F, 0xF8, 0x1F, 0xF8, 0x1F, 0xF8, 0x1F,
    0xF8, 0x1F, 0xFC, 0x3F, 0x7F, 0xFE, 0x3F, 0xFC, 0x1F, 0xF8, 0x07, 0xE0,
    0xF8, 0x01, 0xFB, 0xE0, 0x0F, 0xCF, 0x80, 0x7E, 0x3E, 0x03, 0xF0, 0xF8,
    0x1F, 0x83, 0xE0, 0xFC, 0x0F, 0x87, 0xE0, 0x3E, 0x3F, 0x00, 0xF8, 0xF8,
    0x03, 0xE7, 0xE0, 0x0F, 0xBF, 0x00, 0x3F, 0xF8, 0x00, 0xFF, 0xF0, 0x03,
    0xFF, 0xE0, 0x0F, 0xFF, 0x80, 0x3F, 0xBF, 0x00, 0xFC, 0x7E, 0x03, 0xE0,
    0xFC, 0x0F, 0x81, 0xF8, 0x3E, 0x07, 0xE0, 0xF8, 0x0F, 0xC3, 0xE0, 0x1F,
    0x8F, 0x80, 0x7F, 0x3E, 0x00, 0xFC, 0xF8, 0x01, 0xFB, 0xE0, 0x03, 0xF0,
    0xF8, 0x00, 0x7C, 0x00, 0x3E, 0x00, 0x1F, 0x00, 0x0F, 0x80, 0x07, 0xC0,
    0x03, 0xE0, 0x01, 0xF0, 0x00, 0xF8, 0x00, 0x7C, 0x00, 0x3E, 0x00, 0x1F,
    0x00, 0x0F, 0x80, 0x07, 0xC0, 0x03, 0xE0, 0x01, 0xF0, 0x00, 0xF8, 0x00,
    0x7C, 0x00, 0x3E, 0x00, 0x1F, 0x00, 0x0F, 0x80, 0x07, 0xC0, 0x03, 0xFF,
    0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xC0, 0xFF, 0x00, 0xFF, 0xFF,
    0x00, 0xFF, 0xFF, 0x00, 0xFF, 0xFF, 0x01, 0xFF, 0xFF, 0x81, 0xFF, 0xFF,
    0x81, 0xFF, 0xFF, 0x81, 0xFF, 0xFF, 0x81, 0xFF, 0xFB, 0xC3, 0xDF, 0xFB,
    0xC3, 0xDF, 0xFB, 0xC3, 0xDF, 0xFB, 0xC3, 0xDF, 0xF9, 0xC7, 0xDF, 0xF9,
    0xE7, 0x9F, 0xF9, 0xE7, 0x9F, 0xF9, 0xE7, 0x9F, 0xF9, 0xE7, 0x9F, 0xF8,
    0xFF, 0x1F, 0xF8, 0xFF, 0x1F, 0xF8, 0xFF, 0x1F, 0xF8, 0xFF, 0x1F, 0xF8,
    0x7F, 0x1F, 0xF8, 0x7E, 0x1F, 0xF8, 0x7E, 0x1F, 0xF8, 0x7E, 0x1F, 0xF8,
    0x3E, 0x1F, 0xF8, 0x01, 0xFF, 0xC0, 0x1F, 0xFE, 0x01, 0xFF, 0xE0, 0x1F,
    0xFF, 0x01, 0xFF, 0xF0, 0x1F, 0xFF, 0x81, 0xFF, 0xF8, 0x1F, 0xFF, 0xC1,
    0xFF, 0xBC, 0x1F, 0xFB, 0xE1, 0xFF, 0x9F, 0x1F, 0xF9, 0xF1, 0xFF, 0x8F,
    0x9F, 0xF8, 0x79, 0xFF, 0x87, 0xDF, 0xF8, 0x3D, 0xFF, 0x83, 0xFF, 0xF8,
    0x1F, 0xFF, 0x81, 0xFF, 0xF8, 0x0F, 0xFF, 0x80, 0xFF, 0xF8, 0x07, 0xFF,
    0x80, 0x3F, 0xF8, 0x03, 0xFF, 0x80, 0x1F, 0x00, 0x7F, 0x00, 0x01, 0xFF,
    0xF0, 0x01, 0xFF, 0xFC, 0x03, 0xFF, 0xFF, 0x01, 0xFC, 0x1F, 0xC1, 0xF8,
    0x03, 0xF1, 0xF8, 0x00, 0xFC, 0xF8, 0x00, 0x3E, 0x7C, 0x00, 0x1F, 0x7C,
    0x00, 0x07, 0xFE, 0x00, 0x03, 0xFF, 0x00, 0x01, 0xFF, 0x80, 0x00, 0xFF,
    0xC0, 0x00, 0x7F, 0xE0, 0x00, 0x3F, 0xF0, 0x00, 0x1F, 0xF8, 0x00, 0x0F,
    0xBE, 0x00, 0x0F, 0x9F, 0x00, 0x07, 0xCF, 0xC0, 0x07, 0xE3, 0xF0, 0x07,
    0xE0, 0xFE, 0x0F, 0xE0, 0x7F, 0xFF, 0xE0, 0x0F, 0xFF, 0xE0, 0x03, 0xFF,
    0xE0, 0x00, 0x3F, 0x80, 0x00, 0xFF, 0xFC, 0x1F, 0xFF, 0xE3, 0xFF, 0xFE,
    0x7F, 0xFF, 0xEF, 0x80, 0xFF, 0xF0, 0x0F, 0xFE, 0x00, 0xFF, 0xC0, 0x1F,
    0xF8, 0x03, 0xFF, 0x00, 0x7F, 0xE0, 0x1F, 0xFC, 0x07, 0xEF, 0xFF, 0xFD,
    0xFF, 0xFF, 0x3F, 0xFF, 0xC7, 0xFF, 0xE0, 0xF8, 0x00, 0x1F, 0x00, 0x03,
    0xE0, 0x00, 0x7C, 0x00, 0x0F, 0x80, 0x01, 0xF0, 0x00, 0x3E, 0x00, 0x07,
    0xC0, 0x00, 0xF8, 0x00, 0x1F, 0x00, 0x00, 0x00, 0x7F, 0x00, 0x01, 0xFF,
    0xF0, 0x01, 0xFF, 0xFC, 0x03, 0xFF, 0xFF, 0x01, 0xFC, 0x1F, 0xC1, 0xF8,
    0x03, 0xF1, 0xF8, 0x00, 0xFC, 0xF8, 0x00, 0x3E, 0x7C, 0x00, 0x1F, 0x7C,
    0x00, 0x07, 0xFE, 0x00, 0x03, 0xFF, 0x00, 0x01, 0xFF, 0x80, 0x00, 0xFF,
    0xC0, 0x00, 0x7F, 0xE0, 0x00, 0x3F, 0xF0, 0x00, 0x1F, 0xF8, 0x01, 0x0F,
    0xBE, 0x01, 0xCF, 0x9F, 0x01, 0xFF, 0xCF, 0xC0, 0x7F, 0xE3, 0xF0, 0x1F,
    0xE0, 0xFE, 0x0F, 0xF0, 0x7F, 0xFF, 0xF8, 0x0F, 0xFF, 0xFE, 0x03, 0xFF,
    0xEF, 0x80, 0x3F, 0xC3, 0x80, 0x00, 0x00, 0x80, 0xFF, 0xFF, 0x07, 0xFF,
    0xFE, 0x3F, 0xFF, 0xF9, 0xFF, 0xFF, 0xCF, 0x80, 0x3F, 0x7C, 0x00, 0xFB,
    0xE0, 0x07, 0xDF, 0x00, 0x3E, 0xF8, 0x01, 0xF7, 0xC0, 0x0F, 0x3E, 0x00,
    0xF9, 0xFF, 0xFF, 0x8F, 0xFF, 0xF8, 0x7F, 0xFF, 0xC3, 0xFF, 0xFF, 0x1F,
    0x00, 0xFC, 0xF8, 0x03, 0xE7, 0xC0, 0x1F, 0x3E, 0x00, 0xF9, 0xF0, 0x07,
    0xCF, 0x80, 0x3E, 0x7C, 0x01, 0xF3, 0xE0, 0x0F, 0x9F, 0x00, 0x7C, 0xF8,
    0x03, 0xF7, 0xC0, 0x0F, 0xC0, 0x07, 0xF8, 0x01, 0xFF, 0xF0, 0x3F, 0xFF,
    0x87, 0xFF, 0xFC, 0x7E, 0x0F, 0xCF, 0xC0, 0x7E, 0xF8, 0x03, 0xEF, 0x80,
    0x3E, 0xF8, 0x00, 0x0F, 0xC0, 0x00, 0xFF, 0x00, 0x07, 0xFF, 0xC0, 0x3F,
    0xFF, 0x81, 0xFF, 0xFC, 0x03, 0xFF, 0xE0, 0x01, 0xFF, 0x00, 0x03, 0xF0,
    0x00, 0x1F, 0xF8, 0x01, 0xFF, 0x80, 0x1F, 0xFC, 0x03, 0xFF, 0xE0, 0x7E,
    0x7F, 0xFF, 0xE3, 0xFF, 0xFC, 0x1F, 0xFF, 0x00, 0x3F, 0xC0, 0xFF, 0xFF,
    0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xF0, 0x1F, 0x00, 0x03, 0xE0,
    0x00, 0x7C, 0x00, 0x0F, 0x80, 0x01, 0xF0, 0x00, 0x3E, 0x00, 0x07, 0xC0,
    0x00, 0xF8, 0x00, 0x1F, 0x00, 0x03, 0xE0, 0x00, 0x7C, 0x00, 0x0F, 0x80,
    0x01, 0xF0, 0x00, 0x3E, 0x00, 0x07, 0xC0, 0x00, 0xF8, 0x00, 0x1F, 0x00,
    0x03, 0xE0, 0x00, 0x7C, 0x00, 0x0F, 0x80, 0x01, 0xF0, 0x00, 0x3E, 0x00,
    0xF8, 0x01, 0xFF, 0x80, 0x1F, 0xF8, 0x01, 0xFF, 0x80, 0x1F, 0xF8, 0x01,
    0xFF, 0x80, 0x1F, 0xF8, 0x01, 0xFF, 0x80, 0x1F, 0xF8, 0x01, 0xFF, 0x80,
    0x1F, 0xF8, 0x01, 0xFF, 0x80, 0x1F, 0xF8, 0x01, 0xFF, 0x80, 0x1F, 0xF8,
    0x01, 0xFF, 0x80, 0x1F, 0xF8, 0x01, 0xFF, 0x80, 0x1F, 0xF8, 0x01, 0xFF,
    0x80, 0x1F, 0x7C, 0x03, 0xE7, 0xE0, 0x7E, 0x3F, 0xFF, 0xC3, 0xFF, 0xFC,
    0x0F, 0xFF, 0x00, 0x3F, 0xC0, 0xF8, 0x00, 0xFB, 0xE0, 0x03, 0xE7, 0xC0,
    0x1F, 0x9F, 0x00, 0x7C, 0x7C, 0x01, 0xF0, 0xF8, 0x07, 0xC3, 0xE0, 0x3E,
    0x0F, 0x80, 0xF8, 0x1E, 0x03, 0xE0, 0x7C, 0x1F, 0x01, 0xF0, 0x7C, 0x03,
    0xC1, 0xF0, 0x0F, 0x87, 0x80, 0x3E, 0x3E, 0x00, 0xF8, 0xF8, 0x01, 0xE3,
    0xC0, 0x07, 0xCF, 0x00, 0x1F, 0x7C, 0x00, 0x3D, 0xE0, 0x00, 0xFF, 0x80,
    0x03, 0xFE, 0x00, 0x07, 0xF0, 0x00, 0x1F, 0xC0, 0x00, 0x7F, 0x00, 0x00,
    0xF8, 0x00, 0x03, 0xE0, 0x00, 0xF8, 0x07, 0xC0, 0x3F, 0xF8, 0x07, 0xE0,
    0x3E, 0xFC, 0x07, 0xE0, 0x3E, 0x7C, 0x0F, 0xE0, 0x3E, 0x7C, 0x0F, 0xE0,
    0x7E, 0x7C, 0x0F, 0xE0, 0x7C, 0x7C, 0x0F, 0xF0, 0x7C, 0x3E, 0x0F, 0xF0,
    0x7C, 0x3E, 0x1E, 0xF0, 0x78, 0x3E, 0x1E, 0x70, 0xF8, 0x1E, 0x1E, 0x70,
    0xF8, 0x1E, 0x1E, 0x78, 0xF8, 0x1F, 0x1E, 0x78, 0xF0, 0x1F, 0x3C, 0x78,
    0xF0, 0x0F, 0x3C, 0x39, 0xF0, 0x0F, 0x3C, 0x3D, 0xF0, 0x0F, 0x3C, 0x3D,
    0xE0, 0x0F, 0xBC, 0x3D, 0xE0, 0x07, 0xF8, 0x3D, 0xE0, 0x07, 0xF8, 0x1F,
    0xE0, 0x07, 0xF8, 0x1F, 0xC0, 0x03, 0xF8, 0x1F, 0xC0, 0x03, 0xF8, 0x1F,
    0xC0, 0x03, 0xF0, 0x0F, 0x80, 0x03, 0xF0, 0x0F, 0x80, 0x01, 0xF0, 0x0F,
    0x80, 0xFE, 0x01, 0xF9, 0xF8, 0x07, 0xE3, 0xF0, 0x3F, 0x0F, 0xC0, 0xF8,
    0x1F, 0x87, 0xE0, 0x7E, 0x3F, 0x00, 0xFC, 0xFC, 0x01, 0xF7, 0xE0, 0x07,
    0xFF, 0x00, 0x0F, 0xFC, 0x00, 0x3F, 0xE0, 0x00, 0x7F, 0x00, 0x00, 0xFC,
    0x00, 0x07, 0xF0, 0x00, 0x1F, 0xE0, 0x00, 0xFF, 0x80, 0x03, 0xFF, 0x00,
    0x1F, 0x7E, 0x00, 0xFC, 0xF8, 0x03, 0xE3, 0xF0, 0x1F, 0x87, 0xC0, 0x7C,
    0x1F, 0x83, 0xF0, 0x3F, 0x1F, 0x80, 0xFC, 0x7E, 0x01, 0xFB, 0xF0, 0x07,
    0xF0, 0xFC, 0x01, 0xFF, 0xE0, 0x0F, 0x9F, 0x00, 0xFC, 0xFC, 0x07, 0xC3,
    0xE0, 0x7E, 0x1F, 0x83, 0xE0, 0x7C, 0x1F, 0x03, 0xF1, 0xF0, 0x0F, 0x8F,
    0x80, 0x7E, 0xF8, 0x01, 0xF7, 0xC0, 0x0F, 0xFC, 0x00, 0x3F, 0xE0, 0x00,
    0xFE, 0x00, 0x07, 0xF0, 0x00, 0x1F, 0x00, 0x00, 0xF8, 0x00, 0x07, 0xC0,
    0x00, 0x3E, 0x00, 0x01, 0xF0, 0x00, 0x0F, 0x80, 0x00, 0x7C, 0x00, 0x03,
    0xE0, 0x00, 0x1F, 0x00, 0x00, 0xF8, 0x00, 0x07, 0xC0, 0x00, 0xFF, 0xFF,
    0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xF0, 0x00, 0x7E, 0x00, 0x1F,
    0x80, 0x07, 0xE0, 0x00, 0xFC, 0x00, 0x3F, 0x00, 0x0F, 0xC0, 0x03, 0xF8,
    0x00, 0x7E, 0x00, 0x1F, 0x80, 0x07, 0xE0, 0x01, 0xFC, 0x00, 0x3F, 0x00,
    0x0F, 0xC0, 0x03, 0xF0, 0x00, 0x7E, 0x00, 0x1F, 0x80, 0x07, 0xE0, 0x01,
    0xFC, 0x00, 0x3F, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFC,
    0xFF, 0xFF, 0xFF, 0xFF, 0xF8, 0xF8, 0xF8, 0xF8, 0xF8, 0xF8, 0xF8, 0xF8,
    0xF8, 0xF8, 0xF8, 0xF8, 0xF8, 0xF8, 0xF8, 0xF8, 0xF8, 0xF8, 0xF8, 0xF8,
    0xF8, 0xF8, 0xF8, 0xF8, 0xF8, 0xFF, 0xFF, 0xFF, 0xFF, 0xE0, 0x38, 0x06,
    0x01, 0x80, 0x70, 0x0C, 0x03, 0x00, 0xE0, 0x18, 0x06, 0x01, 0xC0, 0x30,
    0x0C, 0x03, 0x00, 0xE0, 0x18, 0x06, 0x01, 0xC0, 0x30, 0x0C, 0x03, 0x80,
    0x60, 0x18, 0x07, 0x01, 0xC0, 0xFF, 0xFF, 0xFF, 0xFF, 0x1F, 0x1F, 0x1F,
    0x1F, 0x1F, 0x1F, 0x1F, 0x1F, 0x1F, 0x1F, 0x1F, 0x1F, 0x1F, 0x1F, 0x1F,
    0x1F, 0x1F, 0x1F, 0x1F, 0x1F, 0x1F, 0x1F, 0x1F, 0x1F, 0x1F, 0xFF, 0xFF,
    0xFF, 0xFF, 0x03, 0xE0, 0x07, 0xE0, 0x07, 0xE0, 0x0F, 0xF0, 0x0F, 0xF0,
    0x0F, 0x78, 0x1E, 0x78, 0x1E, 0x78, 0x3C, 0x3C, 0x3C, 0x3C, 0x3C, 0x1E,
    0x78, 0x1E, 0x78, 0x1E, 0x70, 0x0F, 0xF0, 0x0F, 0xFF, 0xFF, 0xFF, 0xFF,
    0xFF, 0xFF, 0xFF, 0xFE, 0xF8, 0xF0, 0xF0, 0xE0, 0xE0, 0x07, 0xF8, 0x07,
    0xFF, 0x83, 0xFF, 0xF1, 0xFF, 0xFE, 0x7C, 0x1F, 0xBE, 0x03, 0xE0, 0x00,
    0xF8, 0x01, 0xFE, 0x0F, 0xFF, 0x8F, 0xFF, 0xE7, 0xF8, 0xFB, 0xF0, 0x3E,
    0xF8, 0x0F, 0xBE, 0x07, 0xEF, 0xC3, 0xFB, 0xFF, 0xFE, 0x7F, 0xFF, 0x8F,
    0xFB, 0xF1, 0xF8, 0xFC, 0xF8, 0x00, 0x3E, 0x00, 0x0F, 0x80, 0x03, 0xE0,
    0x00, 0xF8, 0x00, 0x3E, 0x00, 0x0F, 0x80, 0x03, 0xE7, 0xE0, 0xFB, 0xFC,
    0x3F, 0xFF, 0xCF, 0xFF, 0xF3, 0xF8, 0x7E, 0xFC, 0x0F, 0xBF, 0x03, 0xFF,
    0x80, 0x7F, 0xE0, 0x1F, 0xF8, 0x07, 0xFE, 0x01, 0xFF, 0x80, 0x7F, 0xF0,
    0x3F, 0xFC, 0x0F, 0xBF, 0x87, 0xEF, 0xFF, 0xF3, 0xFF, 0xFC, 0xFB, 0xFC,
    0x3E, 0x7E, 0x00, 0x03, 0xF0, 0x07, 0xFE, 0x0F, 0xFF, 0x87, 0xFF, 0xE7,
    0xE1, 0xFB, 0xE0, 0x7F, 0xE0, 0x3F, 0xF0, 0x00, 0xF8, 0x00, 0x7C, 0x00,
    0x3E, 0x00, 0x1F, 0x00, 0x0F, 0x80, 0xFB, 0xE0, 0x7D, 0xF8, 0x7E, 0x7F,
    0xFE, 0x3F, 0xFE, 0x0F, 0xFE, 0x00, 0xFC, 0x00, 0x00, 0x03, 0xE0, 0x00,
    0x7C, 0x00, 0x0F, 0x80, 0x01, 0xF0, 0x00, 0x3E, 0x00, 0x07, 0xC0, 0x00,
    0xF8, 0x1F, 0x1F, 0x0F, 0xFB, 0xE3, 0xFF, 0xFC, 0xFF, 0xFF, 0xBF, 0x8F,
    0xF7, 0xC0, 0x7F, 0xF8, 0x0F, 0xFE, 0x00, 0xFF, 0xC0, 0x1F, 0xF8, 0x03,
    0xFF, 0x00, 0x7F, 0xE0, 0x0F, 0xFE, 0x03, 0xF7, 0xC0, 0x7E, 0xFC, 0x3F,
    0xCF, 0xFF, 0xF8, 0xFF, 0xFF, 0x0F, 0xFB, 0xE0, 0xFC, 0x7C, 0x07, 0xE0,
    0x07, 0xFE, 0x03, 0xFF, 0xE0, 0xFF, 0xF8, 0x7E, 0x1F, 0x1F, 0x03, 0xCF,
    0x80, 0xFB, 0xE0, 0x1E, 0xFF, 0xFF, 0xBF, 0xFF, 0xEF, 0xFF, 0xFB, 0xE0,
    0x00, 0xF8, 0x00, 0x3F, 0x03, 0xE7, 0xE1, 0xF9, 0xFF, 0xFC, 0x3F, 0xFE,
    0x07, 0xFF, 0x00, 0x7F, 0x00, 0x0F, 0xC7, 0xF3, 0xFC, 0xFF, 0x3E, 0x0F,
    0x83, 0xE3, 0xFE, 0xFF, 0xBF, 0xE3, 0xE0, 0xF8, 0x3E, 0x0F, 0x83, 0xE0,
    0xF8, 0x3E, 0x0F, 0x83, 0xE0, 0xF8, 0x3E, 0x0F, 0x83, 0xE0, 0xF8, 0x3E,
    0x0F, 0x80, 0x07, 0xC7, 0xC3, 0xFD, 0xF3, 0xFF, 0xFC, 0xFF, 0xFF, 0x7E,
    0x1F, 0xDF, 0x03, 0xFF, 0xC0, 0xFF, 0xE0, 0x1F, 0xF8, 0x07, 0xFE, 0x01,
    0xFF, 0x80, 0x7F, 0xE0, 0x1F, 0xFC, 0x0F, 0xDF, 0x03, 0xF7, 0xE1, 0xFD,
    0xFF, 0xFF, 0x3F, 0xFF, 0xC7, 0xFD, 0xF0, 0x7C, 0x7C, 0x00, 0x1F, 0x00,
    0x07, 0xFF, 0x03, 0xF7, 0xE1, 0xF9, 0xFF, 0xFC, 0x3F, 0xFE, 0x01, 0xFE,
    0x00, 0xF8, 0x00, 0x7C, 0x00, 0x3E, 0x00, 0x1F, 0x00, 0x0F, 0x80, 0x07,
    0xC0, 0x03, 0xE0, 0x01, 0xF1, 0xF0, 0xFB, 0xFE, 0x7F, 0xFF, 0xBF, 0xFF,
    0xDF, 0xC3, 0xFF, 0xC0, 0xFF, 0xC0, 0x7F, 0xE0, 0x3F, 0xF0, 0x1F, 0xF8,
    0x0F, 0xFC, 0x07, 0xFE, 0x03, 0xFF, 0x01, 0xFF, 0x80, 0xFF, 0xC0, 0x7F,
    0xE0, 0x3F, 0xF0, 0x1F, 0xF8, 0x0F, 0xFC, 0x07, 0xC0, 0xFF, 0xFF, 0xF0,
    0x00, 0x1F, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF,
    0xFF, 0xC0, 0x3E, 0x7C, 0xF9, 0xF0, 0x00, 0x00, 0x1F, 0x3E, 0x7C, 0xF9,
    0xF3, 0xE7, 0xCF, 0x9F, 0x3E, 0x7C, 0xF9, 0xF3, 0xE7, 0xCF, 0x9F, 0x3E,
    0x7C, 0xF9, 0xF3, 0xFF, 0xFF, 0xFE, 0xF8, 0xF8, 0x00, 0x7C, 0x00, 0x3E,
    0x00, 0x1F, 0x00, 0x0F, 0x80, 0x07, 0xC0, 0x03, 0xE0, 0x01, 0xF0, 0x3E,
    0xF8, 0x3E, 0x7C, 0x3F, 0x3E, 0x3F, 0x1F, 0x3F, 0x0F, 0x9F, 0x07, 0xDF,
    0x03, 0xFF, 0x81, 0xFF, 0xC0, 0xFF, 0xF0, 0x7F, 0xF8, 0x3F, 0x7E, 0x1F,
    0x1F, 0x0F, 0x87, 0xC7, 0xC3, 0xF3, 0xE0, 0xF9, 0xF0, 0x7E, 0xF8, 0x1F,
    0x7C, 0x0F, 0xC0, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF,
    0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xC0, 0xF8, 0xF8, 0x3F, 0x1F,
    0x7F, 0x9F, 0xF3, 0xFF, 0xFF, 0xFF, 0x7F, 0xFF, 0xFF, 0xFF, 0xC3, 0xF8,
    0x7F, 0xF8, 0x3F, 0x07, 0xFE, 0x07, 0xC0, 0xFF, 0xC0, 0xF8, 0x1F, 0xF8,
    0x1F, 0x03, 0xFF, 0x03, 0xE0, 0x7F, 0xE0, 0x7C, 0x0F, 0xFC, 0x0F, 0x81,
    0xFF, 0x81, 0xF0, 0x3F, 0xF0, 0x3E, 0x07, 0xFE, 0x07, 0xC0, 0xFF, 0xC0,
    0xF8, 0x1F, 0xF8, 0x1F, 0x03, 0xFF, 0x03, 0xE0, 0x7F, 0xE0, 0x7C, 0x0F,
    0x80, 0xF8, 0xF8, 0x7D, 0xFF, 0x3F, 0xFF, 0xDF, 0xFF, 0xEF, 0xE1, 0xFF,
    0xE0, 0x7F, 0xE0, 0x3F, 0xF0, 0x1F, 0xF8, 0x0F, 0xFC, 0x07, 0xFE, 0x03,
    0xFF, 0x01, 0xFF, 0x80, 0xFF, 0xC0, 0x7F, 0xE0, 0x3F, 0xF0, 0x1F, 0xF8,
    0x0F, 0xFC, 0x07, 0xFE, 0x03, 0xE0, 0x03, 0xF8, 0x01, 0xFF, 0xC0, 0x7F,
    0xFC, 0x1F, 0xFF, 0xC7, 0xF0, 0xFC, 0xF8, 0x0F, 0xBF, 0x01, 0xFF, 0xC0,
    0x1F, 0xF8, 0x03, 0xFF, 0x00, 0x7F, 0xE0, 0x0F, 0xFC, 0x01, 0xFF, 0xC0,
    0x7E, 0xF8, 0x0F, 0x9F, 0x87, 0xF1, 0xFF, 0xFC, 0x1F, 0xFF, 0x01, 0xFF,
    0xC0, 0x0F, 0xE0, 0x00, 0xF8, 0xF8, 0x3E, 0xFF, 0x8F, 0xFF, 0xF3, 0xFF,
    0xFC, 0xFE, 0x1F, 0xBF, 0x03, 0xEF, 0xC0, 0xFF, 0xE0, 0x1F, 0xF8, 0x07,
    0xFE, 0x01, 0xFF, 0x80, 0x7F, 0xE0, 0x1F, 0xFC, 0x0F, 0xFF, 0x03, 0xEF,
    0xE1, 0xFB, 0xFF, 0xFC, 0xFF, 0xFF, 0x3E, 0xFF, 0x0F, 0x8F, 0x83, 0xE0,
    0x00, 0xF8, 0x00, 0x3E, 0x00, 0x0F, 0x80, 0x03, 0xE0, 0x00, 0xF8, 0x00,
    0x3E, 0x00, 0x00, 0x07, 0xE3, 0xE1, 0xFF, 0x7C, 0x7F, 0xFF, 0x9F, 0xFF,
    0xF7, 0xF1, 0xFE, 0xF8, 0x0F, 0xFF, 0x01, 0xFF, 0xC0, 0x1F, 0xF8, 0x03,
    0xFF, 0x00, 0x7F, 0xE0, 0x0F, 0xFC, 0x01, 0xFF, 0xC0, 0x7E, 0xF8, 0x0F,
    0xDF, 0x83, 0xF9, 0xFF, 0xFF, 0x3F, 0xFF, 0xE1, 0xFF, 0x7C, 0x1F, 0x8F,
    0x80, 0x01, 0xF0, 0x00, 0x3E, 0x00, 0x07, 0xC0, 0x00, 0xF8, 0x00, 0x1F,
    0x00, 0x03, 0xE0, 0x00, 0x7C, 0xF8, 0xFF, 0x7F, 0xFF, 0xFF, 0xFF, 0xE1,
    0xF8, 0x3E, 0x07, 0xC0, 0xF8, 0x1F, 0x03, 0xE0, 0x7C, 0x0F, 0x81, 0xF0,
    0x3E, 0x07, 0xC0, 0xF8, 0x1F, 0x03, 0xE0, 0x00, 0x07, 0xF0, 0x0F, 0xFE,
    0x0F, 0xFF, 0x87, 0xFF, 0xE7, 0xE1, 0xF3, 0xE0, 0x79, 0xF8, 0x00, 0xFF,
    0x80, 0x3F, 0xFC, 0x1F, 0xFF, 0x83, 0xFF, 0xC0, 0x3F, 0xF0, 0x01, 0xFF,
    0xC0, 0x7D, 0xF0, 0x7E, 0xFF, 0xFE, 0x3F, 0xFF, 0x0F, 0xFF, 0x01, 0xFE,
    0x00, 0x3E, 0x1F, 0x0F, 0x87, 0xC3, 0xE7, 0xFF, 0xFF, 0xFF, 0x3E, 0x1F,
    0x0F, 0x87, 0xC3, 0xE1, 0xF0, 0xF8, 0x7C, 0x3E, 0x1F, 0x0F, 0x87, 0xF3,
    0xF8, 0xFC, 0x3E, 0xF8, 0x0F, 0xFC, 0x07, 0xFE, 0x03, 0xFF, 0x01, 0xFF,
    0x80, 0xFF, 0xC0, 0x7F, 0xE0, 0x3F, 0xF0, 0x1F, 0xF8, 0x0F, 0xFC, 0x07,
    0xFE, 0x03, 0xFF, 0x01, 0xFF, 0x80, 0xFF, 0xC0, 0xFF, 0xF0, 0xFF, 0xFF,
    0xFF, 0x7F, 0xFF, 0x9F, 0xF7, 0xC7, 0xE3, 0xE0, 0x7C, 0x07, 0xCF, 0x80,
    0xF9, 0xF0, 0x1F, 0x1F, 0x07, 0xC3, 0xE0, 0xF8, 0x7C, 0x1F, 0x07, 0x83,
    0xC0, 0xF8, 0xF8, 0x1F, 0x1F, 0x01, 0xE3, 0xC0, 0x3E, 0x78, 0x07, 0xDF,
    0x00, 0x7B, 0xC0, 0x0F, 0xF8, 0x01, 0xFF, 0x00, 0x1F, 0xC0, 0x03, 0xF8,
    0x00, 0x7F, 0x00, 0x07, 0xC0, 0x00, 0xFC, 0x1F, 0x03, 0xEF, 0x83, 0xE0,
    0x7D, 0xF0, 0x7E, 0x1F, 0x3E, 0x0F, 0xC3, 0xE3, 0xC3, 0xF8, 0x7C, 0x7C,
    0x7F, 0x0F, 0x0F, 0x8F, 0xF3, 0xE1, 0xF1, 0xDE, 0x7C, 0x1E, 0x7B, 0xCF,
    0x83, 0xEF, 0x39, 0xE0, 0x7D, 0xE7, 0x3C, 0x07, 0xB8, 0xFF, 0x80, 0xF7,
    0x1F, 0xE0, 0x1F, 0xE3, 0xFC, 0x03, 0xFC, 0x3F, 0x80, 0x3F, 0x07, 0xF0,
    0x07, 0xE0, 0xFC, 0x00, 0xFC, 0x1F, 0x80, 0x0F, 0x83, 0xF0, 0x00, 0xFC,
    0x1F, 0x9F, 0x07, 0xE7, 0xE3, 0xF0, 0xF8, 0xF8, 0x1F, 0x7E, 0x07, 0xDF,
    0x00, 0xFF, 0x80, 0x1F, 0xE0, 0x07, 0xF0, 0x00, 0xF8, 0x00, 0x7F, 0x00,
    0x3F, 0xE0, 0x0F, 0xF8, 0x07, 0xDF, 0x03, 0xF7, 0xE0, 0xF8, 0xF8, 0x7E,
    0x3F, 0x1F, 0x07, 0xEF, 0xC0, 0xF8, 0x7C, 0x03, 0xEF, 0x80, 0xF9, 0xF8,
    0x1F, 0x1F, 0x03, 0xE3, 0xE0, 0xF8, 0x7C, 0x1F, 0x07, 0xC3, 0xE0, 0xF8,
    0x78, 0x0F, 0x1F, 0x01, 0xF3, 0xC0, 0x3E, 0x78, 0x03, 0xDF, 0x00, 0x7F,
    0xC0, 0x0F, 0xF8, 0x00, 0xFF, 0x00, 0x1F, 0xC0, 0x01, 0xF8, 0x00, 0x3F,
    0x00, 0x07, 0xC0, 0x00, 0xF8, 0x00, 0x1E, 0x00, 0x07, 0xC0, 0x07, 0xF8,
    0x00, 0xFE, 0x00, 0x1F, 0x80, 0x03, 0xE0, 0x00, 0x7F, 0xFE, 0x7F, 0xFE,
    0x7F, 0xFE, 0x7F, 0xFE, 0x00, 0x7E, 0x00, 0xFC, 0x01, 0xF8, 0x03, 0xF0,
    0x03, 0xF0, 0x07, 0xE0, 0x0F, 0xC0, 0x1F, 0x80, 0x3F, 0x00, 0x7E, 0x00,
    0xFE, 0x00, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x07, 0x87,
    0xC7, 0xE3, 0xF1, 0xE0, 0xF0, 0x78, 0x3C, 0x1E, 0x0F, 0x07, 0x83, 0xC1,
    0xE0, 0xF0, 0xF9, 0xF8, 0xF0, 0x7E, 0x0F, 0x83, 0xC1, 0xE0, 0xF0, 0x78,
    0x3C, 0x1E, 0x0F, 0x07, 0x83, 0xC1, 0xE0, 0xFC, 0x7E, 0x1F, 0x07, 0x80,
    0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF,
    0xE0, 0xF0, 0x7C, 0x3E, 0x1F, 0x83, 0xC1, 0xE0, 0xF0, 0x78, 0x3C, 0x1E,
    0x0F, 0x07, 0x83, 0xC1, 0xE0, 0xF0, 0x7C, 0x1F, 0x83, 0xC7, 0xE7, 0xC3,
    0xC1, 0xE0, 0xF0, 0x78, 0x3C, 0x1E, 0x0F, 0x07, 0x83, 0xC7, 0xE3, 0xE1,
    0xF0, 0xF0, 0x00, 0x3C, 0x00, 0xFE, 0x0F, 0xFE, 0x1E, 0x1F, 0xFC, 0x0F,
    0xC0, 0x0F, 0x00};

        static readonly GFXglyph[] FreeSansBold18pt7bGlyphs = {
    new GFXglyph(0, 0, 0, 10, 0, 1),        // 0x20 ' '
    new GFXglyph(0, 5, 25, 12, 4, -24),     // 0x21 '!'
    new GFXglyph(16, 13, 9, 17, 2, -25),    // 0x22 '"'
    new GFXglyph(31, 20, 24, 19, 0, -23),   // 0x23 '#'
    new GFXglyph(91, 19, 29, 19, 0, -25),   // 0x24 '$'
    new GFXglyph(160, 29, 25, 31, 1, -24),  // 0x25 '%'
    new GFXglyph(251, 22, 25, 25, 2, -24),  // 0x26 '&'
    new GFXglyph(320, 5, 9, 9, 2, -25),     // 0x27 '''
    new GFXglyph(326, 9, 33, 12, 1, -25),   // 0x28 '('
    new GFXglyph(364, 9, 33, 12, 1, -25),   // 0x29 ')'
    new GFXglyph(402, 12, 11, 14, 0, -25),  // 0x2A '*'
    new GFXglyph(419, 16, 16, 20, 2, -15),  // 0x2B '+'
    new GFXglyph(451, 5, 11, 9, 2, -4),     // 0x2C ','
    new GFXglyph(458, 9, 4, 12, 1, -10),    // 0x2D '-'
    new GFXglyph(463, 5, 5, 9, 2, -4),      // 0x2E '.'
    new GFXglyph(467, 9, 25, 10, 0, -24),   // 0x2F '/'
    new GFXglyph(496, 17, 25, 19, 1, -24),  // 0x30 '0'
    new GFXglyph(550, 10, 25, 19, 3, -24),  // 0x31 '1'
    new GFXglyph(582, 17, 25, 19, 1, -24),  // 0x32 '2'
    new GFXglyph(636, 17, 25, 19, 1, -24),  // 0x33 '3'
    new GFXglyph(690, 16, 25, 19, 2, -24),  // 0x34 '4'
    new GFXglyph(740, 17, 25, 19, 1, -24),  // 0x35 '5'
    new GFXglyph(794, 18, 25, 19, 1, -24),  // 0x36 '6'
    new GFXglyph(851, 17, 25, 19, 1, -24),  // 0x37 '7'
    new GFXglyph(905, 17, 25, 19, 1, -24),  // 0x38 '8'
    new GFXglyph(959, 17, 25, 19, 1, -24),  // 0x39 '9'
    new GFXglyph(1013, 5, 18, 9, 2, -17),   // 0x3A ':'
    new GFXglyph(1025, 5, 24, 9, 2, -17),   // 0x3B ';'
    new GFXglyph(1040, 18, 17, 20, 1, -16), // 0x3C '<'
    new GFXglyph(1079, 17, 12, 20, 2, -13), // 0x3D '='
    new GFXglyph(1105, 18, 17, 20, 1, -16), // 0x3E '>'
    new GFXglyph(1144, 18, 26, 21, 2, -25), // 0x3F '?'
    new GFXglyph(1203, 32, 31, 34, 1, -25), // 0x40 '@'
    new GFXglyph(1327, 24, 26, 24, 0, -25), // 0x41 'A'
    new GFXglyph(1405, 20, 26, 25, 3, -25), // 0x42 'B'
    new GFXglyph(1470, 23, 26, 25, 1, -25), // 0x43 'C'
    new GFXglyph(1545, 21, 26, 25, 3, -25), // 0x44 'D'
    new GFXglyph(1614, 19, 26, 23, 3, -25), // 0x45 'E'
    new GFXglyph(1676, 17, 26, 22, 3, -25), // 0x46 'F'
    new GFXglyph(1732, 24, 26, 27, 1, -25), // 0x47 'G'
    new GFXglyph(1810, 20, 26, 26, 3, -25), // 0x48 'H'
    new GFXglyph(1875, 5, 26, 11, 3, -25),  // 0x49 'I'
    new GFXglyph(1892, 16, 26, 20, 1, -25), // 0x4A 'J'
    new GFXglyph(1944, 22, 26, 25, 3, -25), // 0x4B 'K'
    new GFXglyph(2016, 17, 26, 22, 3, -25), // 0x4C 'L'
    new GFXglyph(2072, 24, 26, 30, 3, -25), // 0x4D 'M'
    new GFXglyph(2150, 20, 26, 26, 3, -25), // 0x4E 'N'
    new GFXglyph(2215, 25, 26, 27, 1, -25), // 0x4F 'O'
    new GFXglyph(2297, 19, 26, 24, 3, -25), // 0x50 'P'
    new GFXglyph(2359, 25, 27, 27, 1, -25), // 0x51 'Q'
    new GFXglyph(2444, 21, 26, 25, 3, -25), // 0x52 'R'
    new GFXglyph(2513, 20, 26, 24, 2, -25), // 0x53 'S'
    new GFXglyph(2578, 19, 26, 23, 2, -25), // 0x54 'T'
    new GFXglyph(2640, 20, 26, 26, 3, -25), // 0x55 'U'
    new GFXglyph(2705, 22, 26, 23, 1, -25), // 0x56 'V'
    new GFXglyph(2777, 32, 26, 34, 1, -25), // 0x57 'W'
    new GFXglyph(2881, 22, 26, 24, 1, -25), // 0x58 'X'
    new GFXglyph(2953, 21, 26, 22, 1, -25), // 0x59 'Y'
    new GFXglyph(3022, 19, 26, 21, 1, -25), // 0x5A 'Z'
    new GFXglyph(3084, 8, 33, 12, 2, -25),  // 0x5B '['
    new GFXglyph(3117, 10, 25, 10, 0, -24), // 0x5C '\'
    new GFXglyph(3149, 8, 33, 12, 1, -25),  // 0x5D ']'
    new GFXglyph(3182, 16, 15, 20, 2, -23), // 0x5E '^'
    new GFXglyph(3212, 21, 3, 19, -1, 5),   // 0x5F '_'
    new GFXglyph(3220, 7, 5, 9, 1, -25),    // 0x60 '`'
    new GFXglyph(3225, 18, 19, 20, 1, -18), // 0x61 'a'
    new GFXglyph(3268, 18, 26, 22, 2, -25), // 0x62 'b'
    new GFXglyph(3327, 17, 19, 20, 1, -18), // 0x63 'c'
    new GFXglyph(3368, 19, 26, 22, 1, -25), // 0x64 'd'
    new GFXglyph(3430, 18, 19, 20, 1, -18), // 0x65 'e'
    new GFXglyph(3473, 10, 26, 12, 1, -25), // 0x66 'f'
    new GFXglyph(3506, 18, 26, 21, 1, -18), // 0x67 'g'
    new GFXglyph(3565, 17, 26, 21, 2, -25), // 0x68 'h'
    new GFXglyph(3621, 5, 26, 10, 2, -25),  // 0x69 'i'
    new GFXglyph(3638, 7, 33, 10, 0, -25),  // 0x6A 'j'
    new GFXglyph(3667, 17, 26, 20, 2, -25), // 0x6B 'k'
    new GFXglyph(3723, 5, 26, 9, 2, -25),   // 0x6C 'l'
    new GFXglyph(3740, 27, 19, 31, 2, -18), // 0x6D 'm'
    new GFXglyph(3805, 17, 19, 21, 2, -18), // 0x6E 'n'
    new GFXglyph(3846, 19, 19, 21, 1, -18), // 0x6F 'o'
    new GFXglyph(3892, 18, 26, 22, 2, -18), // 0x70 'p'
    new GFXglyph(3951, 19, 26, 22, 1, -18), // 0x71 'q'
    new GFXglyph(4013, 11, 19, 14, 2, -18), // 0x72 'r'
    new GFXglyph(4040, 17, 19, 19, 1, -18), // 0x73 's'
    new GFXglyph(4081, 9, 23, 12, 1, -22),  // 0x74 't'
    new GFXglyph(4107, 17, 19, 21, 2, -18), // 0x75 'u'
    new GFXglyph(4148, 19, 19, 19, 0, -18), // 0x76 'v'
    new GFXglyph(4194, 27, 19, 27, 0, -18), // 0x77 'w'
    new GFXglyph(4259, 18, 19, 19, 1, -18), // 0x78 'x'
    new GFXglyph(4302, 19, 26, 19, 0, -18), // 0x79 'y'
    new GFXglyph(4364, 16, 19, 18, 1, -18), // 0x7A 'z'
    new GFXglyph(4402, 9, 33, 14, 1, -25),  // 0x7B '{'
    new GFXglyph(4440, 3, 33, 10, 4, -25),  // 0x7C '|'
    new GFXglyph(4453, 9, 33, 14, 3, -25),  // 0x7D '}'
    new GFXglyph(4491, 15, 6, 18, 1, -10)}; // 0x7E '~'

        public GFXFont_FreeSansBold18pt7b()
        {
            gfxfont = new GFXfont(FreeSansBold18pt7bBitmaps, FreeSansBold18pt7bGlyphs, 0x20, 0x7E, 42);
        }
        // Approx. 5175 bytes
    }
}