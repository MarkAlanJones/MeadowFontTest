

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

    public class GFXFont_FreeSans18pt7b : GFXFontBase
    {
        static readonly byte[] FreeSans18pt7bBitmaps = {
    0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xE9, 0x20, 0x3F, 0xFC, 0xE3, 0xF1,
    0xF8, 0xFC, 0x7E, 0x3F, 0x1F, 0x8E, 0x82, 0x41, 0x00, 0x01, 0xC3, 0x80,
    0x38, 0x70, 0x06, 0x0E, 0x00, 0xC1, 0x80, 0x38, 0x70, 0x07, 0x0E, 0x0F,
    0xFF, 0xF9, 0xFF, 0xFF, 0x3F, 0xFF, 0xE0, 0xE1, 0xC0, 0x1C, 0x38, 0x03,
    0x87, 0x00, 0x70, 0xE0, 0x0C, 0x18, 0x3F, 0xFF, 0xF7, 0xFF, 0xFE, 0xFF,
    0xFF, 0xC1, 0xC3, 0x80, 0x30, 0x60, 0x06, 0x0C, 0x01, 0xC3, 0x80, 0x38,
    0x70, 0x07, 0x0E, 0x00, 0xC1, 0x80, 0x03, 0x00, 0x0F, 0xC0, 0x3F, 0xF0,
    0x3F, 0xF8, 0x7B, 0x3C, 0xF3, 0x1C, 0xE3, 0x0E, 0xE3, 0x0E, 0xE3, 0x0E,
    0xE3, 0x00, 0xE3, 0x00, 0xF3, 0x00, 0x7B, 0x00, 0x7F, 0x80, 0x1F, 0xF0,
    0x07, 0xFC, 0x03, 0x7E, 0x03, 0x0F, 0x03, 0x07, 0xE3, 0x07, 0xE3, 0x07,
    0xE3, 0x07, 0xE3, 0x0F, 0x73, 0x3E, 0x7F, 0xFC, 0x3F, 0xF8, 0x0F, 0xE0,
    0x03, 0x00, 0x03, 0x00, 0x03, 0x00, 0x00, 0x00, 0x0C, 0x00, 0x78, 0x00,
    0xE0, 0x0F, 0xF0, 0x06, 0x00, 0xFF, 0xC0, 0x70, 0x07, 0x0E, 0x07, 0x00,
    0x70, 0x38, 0x38, 0x03, 0x00, 0xC3, 0x80, 0x18, 0x06, 0x1C, 0x00, 0xE0,
    0x71, 0xC0, 0x03, 0x87, 0x8C, 0x00, 0x1F, 0xF8, 0xE0, 0x00, 0x7F, 0x86,
    0x00, 0x01, 0xF8, 0x70, 0x00, 0x00, 0x03, 0x03, 0xC0, 0x00, 0x38, 0x7F,
    0x80, 0x01, 0x87, 0xFE, 0x00, 0x1C, 0x38, 0x70, 0x00, 0xC3, 0x81, 0xC0,
    0x0E, 0x18, 0x06, 0x00, 0xE0, 0xC0, 0x30, 0x07, 0x07, 0x03, 0x80, 0x70,
    0x1C, 0x38, 0x03, 0x80, 0xFF, 0xC0, 0x38, 0x03, 0xFC, 0x01, 0x80, 0x07,
    0x80, 0x01, 0xF0, 0x00, 0x7F, 0x80, 0x0F, 0xFC, 0x01, 0xE1, 0xE0, 0x1C,
    0x0E, 0x01, 0xC0, 0xE0, 0x1C, 0x0E, 0x01, 0xE1, 0xE0, 0x0E, 0x3C, 0x00,
    0x77, 0x80, 0x07, 0xF0, 0x00, 0x7C, 0x00, 0x0F, 0xE0, 0x03, 0xCF, 0x1C,
    0x78, 0x79, 0xC7, 0x03, 0xDC, 0xE0, 0x1F, 0x8E, 0x00, 0xF8, 0xE0, 0x0F,
    0x0E, 0x00, 0x70, 0xF0, 0x0F, 0x87, 0xC3, 0xFC, 0x7F, 0xFD, 0xC3, 0xFF,
    0x0E, 0x0F, 0xC0, 0xF0, 0xFF, 0xFF, 0xFA, 0x40, 0x06, 0x06, 0x0C, 0x0C,
    0x18, 0x18, 0x38, 0x30, 0x70, 0x70, 0x70, 0x60, 0xE0, 0xE0, 0xE0, 0xE0,
    0xE0, 0xE0, 0xE0, 0xE0, 0xE0, 0x60, 0x70, 0x70, 0x70, 0x30, 0x38, 0x18,
    0x18, 0x0C, 0x0C, 0x06, 0x03, 0xC0, 0x60, 0x30, 0x30, 0x38, 0x18, 0x1C,
    0x0C, 0x0E, 0x0E, 0x0E, 0x06, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07,
    0x07, 0x07, 0x06, 0x0E, 0x0E, 0x0E, 0x0C, 0x1C, 0x18, 0x38, 0x30, 0x30,
    0x60, 0xC0, 0x0C, 0x03, 0x00, 0xC3, 0xB7, 0xFF, 0xC7, 0x81, 0xE0, 0xEC,
    0x73, 0x88, 0x40, 0x01, 0x80, 0x01, 0x80, 0x01, 0x80, 0x01, 0x80, 0x01,
    0x80, 0x01, 0x80, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x01, 0x80, 0x01,
    0x80, 0x01, 0x80, 0x01, 0x80, 0x01, 0x80, 0x01, 0x80, 0x01, 0x80, 0xFF,
    0xF6, 0xDA, 0xC0, 0xFF, 0xFF, 0xFF, 0xFF, 0xF0, 0x00, 0xC0, 0x30, 0x18,
    0x06, 0x01, 0x80, 0xC0, 0x30, 0x0C, 0x06, 0x01, 0x80, 0x60, 0x30, 0x0C,
    0x03, 0x00, 0xC0, 0x60, 0x18, 0x06, 0x03, 0x00, 0xC0, 0x30, 0x18, 0x06,
    0x01, 0x80, 0xC0, 0x30, 0x00, 0x07, 0xE0, 0x0F, 0xF8, 0x1F, 0xFC, 0x3C,
    0x3C, 0x78, 0x1E, 0x70, 0x0E, 0x70, 0x0E, 0xE0, 0x07, 0xE0, 0x07, 0xE0,
    0x07, 0xE0, 0x07, 0xE0, 0x07, 0xE0, 0x07, 0xE0, 0x07, 0xE0, 0x07, 0xE0,
    0x07, 0xE0, 0x07, 0xE0, 0x0F, 0x70, 0x0E, 0x70, 0x0E, 0x78, 0x1E, 0x3C,
    0x3C, 0x1F, 0xF8, 0x1F, 0xF0, 0x07, 0xE0, 0x03, 0x03, 0x07, 0x0F, 0x3F,
    0xFF, 0xFF, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07,
    0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0xE0, 0x1F, 0xF8,
    0x3F, 0xFC, 0x7C, 0x3E, 0x70, 0x0F, 0xF0, 0x0F, 0xE0, 0x07, 0xE0, 0x07,
    0x00, 0x07, 0x00, 0x07, 0x00, 0x0F, 0x00, 0x1E, 0x00, 0x3C, 0x00, 0xF8,
    0x03, 0xF0, 0x07, 0xC0, 0x1F, 0x00, 0x3C, 0x00, 0x38, 0x00, 0x70, 0x00,
    0x60, 0x00, 0xE0, 0x00, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x07, 0xF0,
    0x07, 0xFE, 0x07, 0xFF, 0x87, 0x83, 0xC3, 0x80, 0xF3, 0x80, 0x39, 0xC0,
    0x1C, 0xE0, 0x0E, 0x00, 0x07, 0x00, 0x0F, 0x00, 0x7F, 0x00, 0x3F, 0x00,
    0x1F, 0xE0, 0x00, 0x78, 0x00, 0x1E, 0x00, 0x07, 0x00, 0x03, 0xF0, 0x01,
    0xF8, 0x00, 0xFE, 0x00, 0x77, 0x00, 0x73, 0xE0, 0xF8, 0xFF, 0xF8, 0x3F,
    0xF8, 0x07, 0xF0, 0x00, 0x00, 0x38, 0x00, 0x38, 0x00, 0x78, 0x00, 0xF8,
    0x00, 0xF8, 0x01, 0xF8, 0x03, 0xB8, 0x03, 0x38, 0x07, 0x38, 0x0E, 0x38,
    0x1C, 0x38, 0x18, 0x38, 0x38, 0x38, 0x70, 0x38, 0x60, 0x38, 0xE0, 0x38,
    0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x38, 0x00, 0x38, 0x00, 0x38,
    0x00, 0x38, 0x00, 0x38, 0x00, 0x38, 0x1F, 0xFF, 0x0F, 0xFF, 0x8F, 0xFF,
    0xC7, 0x00, 0x03, 0x80, 0x01, 0xC0, 0x00, 0xE0, 0x00, 0x70, 0x00, 0x39,
    0xF0, 0x3F, 0xFE, 0x1F, 0xFF, 0x8F, 0x83, 0xE7, 0x00, 0xF0, 0x00, 0x3C,
    0x00, 0x0E, 0x00, 0x07, 0x00, 0x03, 0x80, 0x01, 0xC0, 0x00, 0xFC, 0x00,
    0xEF, 0x00, 0x73, 0xC0, 0xF0, 0xFF, 0xF8, 0x3F, 0xF8, 0x07, 0xE0, 0x00,
    0x03, 0xE0, 0x0F, 0xF8, 0x1F, 0xFC, 0x3C, 0x1E, 0x38, 0x0E, 0x70, 0x0E,
    0x70, 0x00, 0x60, 0x00, 0xE0, 0x00, 0xE3, 0xE0, 0xEF, 0xF8, 0xFF, 0xFC,
    0xFC, 0x3E, 0xF0, 0x0E, 0xF0, 0x0F, 0xE0, 0x07, 0xE0, 0x07, 0xE0, 0x07,
    0x60, 0x07, 0x70, 0x0F, 0x70, 0x0E, 0x3C, 0x3E, 0x3F, 0xFC, 0x1F, 0xF8,
    0x07, 0xE0, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x06, 0x00, 0x0E,
    0x00, 0x1C, 0x00, 0x18, 0x00, 0x38, 0x00, 0x70, 0x00, 0x60, 0x00, 0xE0,
    0x00, 0xC0, 0x01, 0xC0, 0x01, 0x80, 0x03, 0x80, 0x03, 0x80, 0x07, 0x00,
    0x07, 0x00, 0x07, 0x00, 0x0E, 0x00, 0x0E, 0x00, 0x0E, 0x00, 0x0C, 0x00,
    0x1C, 0x00, 0x1C, 0x00, 0x07, 0xF0, 0x0F, 0xFE, 0x0F, 0xFF, 0x87, 0x83,
    0xC7, 0x80, 0xF3, 0x80, 0x39, 0xC0, 0x1C, 0xE0, 0x0E, 0x78, 0x0F, 0x1E,
    0x0F, 0x07, 0xFF, 0x01, 0xFF, 0x03, 0xFF, 0xE3, 0xE0, 0xF9, 0xC0, 0x1D,
    0xC0, 0x0F, 0xE0, 0x03, 0xF0, 0x01, 0xF8, 0x00, 0xFC, 0x00, 0xF7, 0x00,
    0x73, 0xE0, 0xF8, 0xFF, 0xF8, 0x3F, 0xF8, 0x07, 0xF0, 0x00, 0x07, 0xE0,
    0x1F, 0xF8, 0x3F, 0xFC, 0x7C, 0x3C, 0x70, 0x0E, 0xF0, 0x0E, 0xE0, 0x06,
    0xE0, 0x07, 0xE0, 0x07, 0xE0, 0x07, 0xE0, 0x0F, 0x70, 0x0F, 0x78, 0x3F,
    0x3F, 0xFF, 0x1F, 0xF7, 0x07, 0xC7, 0x00, 0x07, 0x00, 0x06, 0x00, 0x0E,
    0x70, 0x0E, 0x70, 0x1C, 0x78, 0x3C, 0x3F, 0xF8, 0x1F, 0xF0, 0x07, 0xC0,
    0xFF, 0xF0, 0x00, 0x00, 0x00, 0x07, 0xFF, 0x80, 0xFF, 0xF0, 0x00, 0x00,
    0x00, 0x07, 0xFF, 0xB6, 0xD6, 0x00, 0x00, 0x80, 0x03, 0xC0, 0x07, 0xE0,
    0x0F, 0xC0, 0x3F, 0x80, 0x7E, 0x00, 0xFC, 0x01, 0xF0, 0x00, 0xE0, 0x00,
    0x7C, 0x00, 0x1F, 0xC0, 0x01, 0xF8, 0x00, 0x3F, 0x80, 0x07, 0xF0, 0x00,
    0x7E, 0x00, 0x0F, 0x00, 0x01, 0x80, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF,
    0xE0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF,
    0xFF, 0x80, 0x80, 0x00, 0x70, 0x00, 0x3E, 0x00, 0x0F, 0xE0, 0x00, 0xFC,
    0x00, 0x1F, 0xC0, 0x03, 0xF8, 0x00, 0x3F, 0x00, 0x07, 0x80, 0x0F, 0xC0,
    0x1F, 0x80, 0x7F, 0x00, 0xFC, 0x01, 0xF8, 0x03, 0xF0, 0x01, 0xC0, 0x00,
    0x80, 0x00, 0x00, 0x0F, 0xC0, 0x7F, 0xE1, 0xFF, 0xE3, 0xC3, 0xEF, 0x01,
    0xFC, 0x01, 0xF8, 0x03, 0xF0, 0x07, 0x00, 0x0E, 0x00, 0x38, 0x00, 0xF0,
    0x07, 0xC0, 0x1F, 0x00, 0x7C, 0x00, 0xE0, 0x03, 0xC0, 0x07, 0x00, 0x0E,
    0x00, 0x1C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xC0, 0x03, 0x80,
    0x07, 0x00, 0x0E, 0x00, 0x00, 0x07, 0xF8, 0x00, 0x00, 0x3F, 0xFF, 0x00,
    0x00, 0xFF, 0xFF, 0xC0, 0x01, 0xF8, 0x0F, 0xE0, 0x03, 0xE0, 0x01, 0xF0,
    0x07, 0x80, 0x00, 0xF8, 0x0F, 0x00, 0x00, 0x3C, 0x1E, 0x00, 0x00, 0x1E,
    0x3C, 0x03, 0xE0, 0x1E, 0x38, 0x0F, 0xF3, 0x8E, 0x78, 0x1E, 0x3F, 0x0F,
    0x70, 0x38, 0x1F, 0x07, 0x70, 0x78, 0x0F, 0x07, 0xE0, 0x70, 0x0E, 0x07,
    0xE0, 0x70, 0x0E, 0x07, 0xE0, 0xE0, 0x0E, 0x07, 0xE0, 0xE0, 0x1C, 0x07,
    0xE0, 0xE0, 0x1C, 0x0E, 0xE0, 0xE0, 0x1C, 0x0E, 0xE0, 0xE0, 0x38, 0x1C,
    0xF0, 0x70, 0x78, 0x3C, 0x70, 0x78, 0xFC, 0x78, 0x78, 0x3F, 0xDF, 0xF0,
    0x38, 0x1F, 0x0F, 0xC0, 0x3C, 0x00, 0x00, 0x00, 0x1F, 0x00, 0x00, 0x00,
    0x0F, 0x80, 0x00, 0x00, 0x07, 0xF0, 0x0E, 0x00, 0x01, 0xFF, 0xFE, 0x00,
    0x00, 0x7F, 0xFE, 0x00, 0x00, 0x1F, 0xF0, 0x00, 0x00, 0xF8, 0x00, 0x03,
    0xE0, 0x00, 0x0F, 0xC0, 0x00, 0x7F, 0x00, 0x01, 0xDC, 0x00, 0x07, 0x78,
    0x00, 0x3C, 0xE0, 0x00, 0xE3, 0x80, 0x03, 0x8F, 0x00, 0x1E, 0x1C, 0x00,
    0x70, 0x70, 0x01, 0xC1, 0xE0, 0x0E, 0x03, 0x80, 0x38, 0x0E, 0x00, 0xE0,
    0x3C, 0x07, 0xFF, 0xF0, 0x1F, 0xFF, 0xE0, 0xFF, 0xFF, 0x83, 0xC0, 0x0E,
    0x0E, 0x00, 0x3C, 0x78, 0x00, 0xF1, 0xE0, 0x01, 0xC7, 0x00, 0x07, 0xBC,
    0x00, 0x1E, 0xF0, 0x00, 0x3B, 0x80, 0x00, 0xF0, 0xFF, 0xFC, 0x1F, 0xFF,
    0xE3, 0xFF, 0xFE, 0x70, 0x03, 0xCE, 0x00, 0x3D, 0xC0, 0x03, 0xB8, 0x00,
    0x77, 0x00, 0x0E, 0xE0, 0x01, 0xDC, 0x00, 0x73, 0x80, 0x1E, 0x7F, 0xFF,
    0x8F, 0xFF, 0xF1, 0xFF, 0xFF, 0x38, 0x00, 0xF7, 0x00, 0x0E, 0xE0, 0x00,
    0xFC, 0x00, 0x1F, 0x80, 0x03, 0xF0, 0x00, 0x7E, 0x00, 0x0F, 0xC0, 0x03,
    0xF8, 0x00, 0xF7, 0xFF, 0xFC, 0xFF, 0xFF, 0x1F, 0xFF, 0x80, 0x00, 0xFF,
    0x00, 0x0F, 0xFF, 0x00, 0xFF, 0xFE, 0x07, 0xE0, 0x7C, 0x3E, 0x00, 0x78,
    0xF0, 0x00, 0xE7, 0x80, 0x03, 0xDC, 0x00, 0x07, 0x70, 0x00, 0x03, 0x80,
    0x00, 0x0E, 0x00, 0x00, 0x38, 0x00, 0x00, 0xE0, 0x00, 0x03, 0x80, 0x00,
    0x0E, 0x00, 0x00, 0x38, 0x00, 0x00, 0xE0, 0x00, 0x1D, 0xC0, 0x00, 0x77,
    0x00, 0x03, 0xDE, 0x00, 0x0E, 0x3C, 0x00, 0x78, 0xF8, 0x03, 0xC1, 0xF8,
    0x1F, 0x03, 0xFF, 0xF8, 0x03, 0xFF, 0xC0, 0x03, 0xF8, 0x00, 0xFF, 0xF8,
    0x0F, 0xFF, 0xE0, 0xFF, 0xFF, 0x0E, 0x00, 0xF8, 0xE0, 0x03, 0xCE, 0x00,
    0x1C, 0xE0, 0x00, 0xEE, 0x00, 0x0E, 0xE0, 0x00, 0xFE, 0x00, 0x07, 0xE0,
    0x00, 0x7E, 0x00, 0x07, 0xE0, 0x00, 0x7E, 0x00, 0x07, 0xE0, 0x00, 0x7E,
    0x00, 0x07, 0xE0, 0x00, 0x7E, 0x00, 0x0F, 0xE0, 0x00, 0xEE, 0x00, 0x0E,
    0xE0, 0x01, 0xEE, 0x00, 0x3C, 0xE0, 0x0F, 0x8F, 0xFF, 0xF0, 0xFF, 0xFE,
    0x0F, 0xFF, 0x80, 0xFF, 0xFF, 0xBF, 0xFF, 0xEF, 0xFF, 0xFB, 0x80, 0x00,
    0xE0, 0x00, 0x38, 0x00, 0x0E, 0x00, 0x03, 0x80, 0x00, 0xE0, 0x00, 0x38,
    0x00, 0x0E, 0x00, 0x03, 0xFF, 0xFE, 0xFF, 0xFF, 0xBF, 0xFF, 0xEE, 0x00,
    0x03, 0x80, 0x00, 0xE0, 0x00, 0x38, 0x00, 0x0E, 0x00, 0x03, 0x80, 0x00,
    0xE0, 0x00, 0x38, 0x00, 0x0E, 0x00, 0x03, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF,
    0xFF, 0xF0, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFC, 0x00, 0x0E, 0x00,
    0x07, 0x00, 0x03, 0x80, 0x01, 0xC0, 0x00, 0xE0, 0x00, 0x70, 0x00, 0x38,
    0x00, 0x1F, 0xFF, 0xCF, 0xFF, 0xE7, 0xFF, 0xF3, 0x80, 0x01, 0xC0, 0x00,
    0xE0, 0x00, 0x70, 0x00, 0x38, 0x00, 0x1C, 0x00, 0x0E, 0x00, 0x07, 0x00,
    0x03, 0x80, 0x01, 0xC0, 0x00, 0xE0, 0x00, 0x70, 0x00, 0x00, 0x00, 0x7F,
    0x80, 0x03, 0xFF, 0xE0, 0x07, 0xFF, 0xF8, 0x0F, 0x80, 0xFC, 0x1E, 0x00,
    0x3E, 0x3C, 0x00, 0x0E, 0x78, 0x00, 0x0F, 0x70, 0x00, 0x07, 0x70, 0x00,
    0x00, 0xE0, 0x00, 0x00, 0xE0, 0x00, 0x00, 0xE0, 0x00, 0x00, 0xE0, 0x03,
    0xFF, 0xE0, 0x03, 0xFF, 0xE0, 0x03, 0xFF, 0xE0, 0x00, 0x07, 0xF0, 0x00,
    0x07, 0x70, 0x00, 0x07, 0x70, 0x00, 0x0F, 0x78, 0x00, 0x0F, 0x3C, 0x00,
    0x1F, 0x1E, 0x00, 0x3F, 0x0F, 0xC0, 0xF7, 0x07, 0xFF, 0xE7, 0x03, 0xFF,
    0xC3, 0x00, 0xFF, 0x03, 0xE0, 0x00, 0xFC, 0x00, 0x1F, 0x80, 0x03, 0xF0,
    0x00, 0x7E, 0x00, 0x0F, 0xC0, 0x01, 0xF8, 0x00, 0x3F, 0x00, 0x07, 0xE0,
    0x00, 0xFC, 0x00, 0x1F, 0x80, 0x03, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF,
    0xFF, 0xF8, 0x00, 0x3F, 0x00, 0x07, 0xE0, 0x00, 0xFC, 0x00, 0x1F, 0x80,
    0x03, 0xF0, 0x00, 0x7E, 0x00, 0x0F, 0xC0, 0x01, 0xF8, 0x00, 0x3F, 0x00,
    0x07, 0xE0, 0x00, 0xFC, 0x00, 0x1C, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF,
    0xFF, 0xFF, 0xFF, 0xFC, 0x00, 0x1C, 0x00, 0x70, 0x01, 0xC0, 0x07, 0x00,
    0x1C, 0x00, 0x70, 0x01, 0xC0, 0x07, 0x00, 0x1C, 0x00, 0x70, 0x01, 0xC0,
    0x07, 0x00, 0x1C, 0x00, 0x70, 0x01, 0xC0, 0x07, 0x00, 0x1F, 0x80, 0x7E,
    0x01, 0xF8, 0x07, 0xE0, 0x1F, 0xC0, 0xF7, 0x87, 0x9F, 0xFE, 0x3F, 0xF0,
    0x3F, 0x00, 0xE0, 0x01, 0xEE, 0x00, 0x3C, 0xE0, 0x07, 0x8E, 0x00, 0xF0,
    0xE0, 0x1E, 0x0E, 0x03, 0xE0, 0xE0, 0x7C, 0x0E, 0x0F, 0x80, 0xE1, 0xF0,
    0x0E, 0x1E, 0x00, 0xE3, 0xC0, 0x0E, 0x7C, 0x00, 0xEF, 0xE0, 0x0F, 0xCE,
    0x00, 0xF8, 0xF0, 0x0F, 0x07, 0x80, 0xE0, 0x3C, 0x0E, 0x03, 0xC0, 0xE0,
    0x1E, 0x0E, 0x00, 0xF0, 0xE0, 0x0F, 0x0E, 0x00, 0x78, 0xE0, 0x03, 0xCE,
    0x00, 0x3C, 0xE0, 0x01, 0xEE, 0x00, 0x0F, 0xE0, 0x01, 0xC0, 0x03, 0x80,
    0x07, 0x00, 0x0E, 0x00, 0x1C, 0x00, 0x38, 0x00, 0x70, 0x00, 0xE0, 0x01,
    0xC0, 0x03, 0x80, 0x07, 0x00, 0x0E, 0x00, 0x1C, 0x00, 0x38, 0x00, 0x70,
    0x00, 0xE0, 0x01, 0xC0, 0x03, 0x80, 0x07, 0x00, 0x0E, 0x00, 0x1C, 0x00,
    0x38, 0x00, 0x7F, 0xFF, 0xFF, 0xFF, 0xFF, 0xFC, 0xF8, 0x00, 0x1F, 0xF8,
    0x00, 0x1F, 0xF8, 0x00, 0x1F, 0xFC, 0x00, 0x3F, 0xFC, 0x00, 0x3F, 0xFC,
    0x00, 0x3F, 0xEE, 0x00, 0x77, 0xEE, 0x00, 0x77, 0xEE, 0x00, 0x77, 0xE7,
    0x00, 0xE7, 0xE7, 0x00, 0xE7, 0xE7, 0x00, 0xE7, 0xE3, 0x81, 0xC7, 0xE3,
    0x81, 0xC7, 0xE3, 0x81, 0xC7, 0xE1, 0xC3, 0x87, 0xE1, 0xC3, 0x87, 0xE1,
    0xC3, 0x87, 0xE0, 0xE7, 0x07, 0xE0, 0xE7, 0x07, 0xE0, 0xE7, 0x07, 0xE0,
    0x7E, 0x07, 0xE0, 0x7E, 0x07, 0xE0, 0x7E, 0x07, 0xE0, 0x3C, 0x07, 0xE0,
    0x3C, 0x07, 0xF0, 0x00, 0x7F, 0x00, 0x07, 0xF8, 0x00, 0x7F, 0xC0, 0x07,
    0xFC, 0x00, 0x7F, 0xE0, 0x07, 0xEF, 0x00, 0x7E, 0x70, 0x07, 0xE7, 0x80,
    0x7E, 0x3C, 0x07, 0xE1, 0xC0, 0x7E, 0x1E, 0x07, 0xE0, 0xE0, 0x7E, 0x0F,
    0x07, 0xE0, 0x78, 0x7E, 0x03, 0x87, 0xE0, 0x3C, 0x7E, 0x01, 0xE7, 0xE0,
    0x0E, 0x7E, 0x00, 0xF7, 0xE0, 0x07, 0xFE, 0x00, 0x3F, 0xE0, 0x03, 0xFE,
    0x00, 0x1F, 0xE0, 0x01, 0xFE, 0x00, 0x0F, 0x00, 0x7F, 0x00, 0x01, 0xFF,
    0xF0, 0x01, 0xFF, 0xFC, 0x01, 0xF0, 0x1F, 0x01, 0xE0, 0x03, 0xC1, 0xE0,
    0x00, 0xF1, 0xE0, 0x00, 0x3C, 0xE0, 0x00, 0x0E, 0x70, 0x00, 0x07, 0x70,
    0x00, 0x03, 0xF8, 0x00, 0x00, 0xFC, 0x00, 0x00, 0x7E, 0x00, 0x00, 0x3F,
    0x00, 0x00, 0x1F, 0x80, 0x00, 0x0F, 0xC0, 0x00, 0x07, 0xE0, 0x00, 0x03,
    0xB8, 0x00, 0x03, 0x9C, 0x00, 0x01, 0xCF, 0x00, 0x01, 0xE3, 0xC0, 0x01,
    0xE0, 0xF0, 0x01, 0xE0, 0x3E, 0x03, 0xE0, 0x0F, 0xFF, 0xE0, 0x03, 0xFF,
    0xE0, 0x00, 0x3F, 0x80, 0x00, 0xFF, 0xFC, 0x3F, 0xFF, 0x8F, 0xFF, 0xF3,
    0x80, 0x3E, 0xE0, 0x03, 0xF8, 0x00, 0x7E, 0x00, 0x1F, 0x80, 0x07, 0xE0,
    0x01, 0xF8, 0x00, 0x7E, 0x00, 0x3F, 0x80, 0x1E, 0xFF, 0xFF, 0x3F, 0xFF,
    0x8F, 0xFF, 0xC3, 0x80, 0x00, 0xE0, 0x00, 0x38, 0x00, 0x0E, 0x00, 0x03,
    0x80, 0x00, 0xE0, 0x00, 0x38, 0x00, 0x0E, 0x00, 0x03, 0x80, 0x00, 0xE0,
    0x00, 0x38, 0x00, 0x00, 0x00, 0x7F, 0x00, 0x01, 0xFF, 0xF0, 0x01, 0xFF,
    0xFC, 0x01, 0xF0, 0x1F, 0x01, 0xE0, 0x03, 0xC1, 0xE0, 0x00, 0xF1, 0xE0,
    0x00, 0x3C, 0xE0, 0x00, 0x0E, 0x70, 0x00, 0x07, 0x70, 0x00, 0x01, 0xF8,
    0x00, 0x00, 0xFC, 0x00, 0x00, 0x7E, 0x00, 0x00, 0x3F, 0x00, 0x00, 0x1F,
    0x80, 0x00, 0x0F, 0xC0, 0x00, 0x07, 0xE0, 0x00, 0x07, 0xB8, 0x00, 0x03,
    0x9C, 0x00, 0x01, 0xCF, 0x00, 0x39, 0xE3, 0xC0, 0x1F, 0xE0, 0xF0, 0x07,
    0xE0, 0x3E, 0x03, 0xF0, 0x0F, 0xFF, 0xFC, 0x03, 0xFF, 0xEE, 0x00, 0x3F,
    0x83, 0x80, 0x00, 0x00, 0xC0, 0x00, 0x00, 0x20, 0xFF, 0xFE, 0x0F, 0xFF,
    0xF8, 0xFF, 0xFF, 0xCE, 0x00, 0x3C, 0xE0, 0x01, 0xEE, 0x00, 0x0E, 0xE0,
    0x00, 0xEE, 0x00, 0x0E, 0xE0, 0x00, 0xEE, 0x00, 0x0E, 0xE0, 0x01, 0xCE,
    0x00, 0x3C, 0xFF, 0xFF, 0x8F, 0xFF, 0xF0, 0xFF, 0xFF, 0x8E, 0x00, 0x3C,
    0xE0, 0x01, 0xEE, 0x00, 0x0E, 0xE0, 0x00, 0xEE, 0x00, 0x0E, 0xE0, 0x00,
    0xEE, 0x00, 0x0E, 0xE0, 0x00, 0xEE, 0x00, 0x0E, 0xE0, 0x00, 0xFE, 0x00,
    0x0F, 0x03, 0xFC, 0x00, 0xFF, 0xF0, 0x1F, 0xFF, 0x83, 0xE0, 0x7C, 0x38,
    0x01, 0xE7, 0x00, 0x0E, 0x70, 0x00, 0xE7, 0x00, 0x00, 0x70, 0x00, 0x07,
    0x80, 0x00, 0x3E, 0x00, 0x01, 0xFE, 0x00, 0x0F, 0xFE, 0x00, 0x3F, 0xF8,
    0x00, 0x3F, 0xE0, 0x00, 0x3E, 0x00, 0x00, 0xF0, 0x00, 0x07, 0xE0, 0x00,
    0x7E, 0x00, 0x07, 0xF0, 0x00, 0x77, 0x80, 0x0E, 0x7C, 0x03, 0xE3, 0xFF,
    0xFC, 0x1F, 0xFF, 0x80, 0x3F, 0xC0, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF,
    0xFF, 0x80, 0x70, 0x00, 0x0E, 0x00, 0x01, 0xC0, 0x00, 0x38, 0x00, 0x07,
    0x00, 0x00, 0xE0, 0x00, 0x1C, 0x00, 0x03, 0x80, 0x00, 0x70, 0x00, 0x0E,
    0x00, 0x01, 0xC0, 0x00, 0x38, 0x00, 0x07, 0x00, 0x00, 0xE0, 0x00, 0x1C,
    0x00, 0x03, 0x80, 0x00, 0x70, 0x00, 0x0E, 0x00, 0x01, 0xC0, 0x00, 0x38,
    0x00, 0x07, 0x00, 0x00, 0xE0, 0x00, 0x1C, 0x00, 0xE0, 0x00, 0xFC, 0x00,
    0x1F, 0x80, 0x03, 0xF0, 0x00, 0x7E, 0x00, 0x0F, 0xC0, 0x01, 0xF8, 0x00,
    0x3F, 0x00, 0x07, 0xE0, 0x00, 0xFC, 0x00, 0x1F, 0x80, 0x03, 0xF0, 0x00,
    0x7E, 0x00, 0x0F, 0xC0, 0x01, 0xF8, 0x00, 0x3F, 0x00, 0x07, 0xE0, 0x00,
    0xFC, 0x00, 0x1F, 0x80, 0x03, 0xF0, 0x00, 0x7F, 0x00, 0x1E, 0xF0, 0x07,
    0x9F, 0x01, 0xF1, 0xFF, 0xFC, 0x1F, 0xFE, 0x00, 0x7F, 0x00, 0xE0, 0x00,
    0x7F, 0x80, 0x03, 0xFC, 0x00, 0x1C, 0xE0, 0x01, 0xE7, 0x80, 0x0F, 0x3C,
    0x00, 0x70, 0xE0, 0x07, 0x87, 0x80, 0x3C, 0x1C, 0x01, 0xC0, 0xE0, 0x0E,
    0x07, 0x80, 0xE0, 0x1C, 0x07, 0x00, 0xE0, 0x38, 0x07, 0x83, 0x80, 0x1C,
    0x1C, 0x00, 0xE0, 0xE0, 0x07, 0x8E, 0x00, 0x1C, 0x70, 0x00, 0xE3, 0x80,
    0x07, 0xB8, 0x00, 0x1D, 0xC0, 0x00, 0xEE, 0x00, 0x07, 0xE0, 0x00, 0x1F,
    0x00, 0x00, 0xF8, 0x00, 0x03, 0x80, 0x00, 0x70, 0x03, 0xC0, 0x0F, 0x70,
    0x03, 0xC0, 0x0F, 0x78, 0x03, 0xE0, 0x0F, 0x78, 0x03, 0xE0, 0x0E, 0x38,
    0x07, 0xE0, 0x0E, 0x38, 0x07, 0xF0, 0x1E, 0x3C, 0x07, 0x70, 0x1E, 0x3C,
    0x07, 0x70, 0x1C, 0x1C, 0x0E, 0x70, 0x1C, 0x1C, 0x0E, 0x38, 0x3C, 0x1C,
    0x0E, 0x38, 0x3C, 0x1E, 0x1E, 0x38, 0x38, 0x0E, 0x1C, 0x38, 0x38, 0x0E,
    0x1C, 0x1C, 0x38, 0x0E, 0x1C, 0x1C, 0x78, 0x0F, 0x3C, 0x1C, 0x70, 0x07,
    0x38, 0x0E, 0x70, 0x07, 0x38, 0x0E, 0x70, 0x07, 0x38, 0x0E, 0x70, 0x07,
    0x70, 0x0E, 0xE0, 0x03, 0xF0, 0x07, 0xE0, 0x03, 0xF0, 0x07, 0xE0, 0x03,
    0xF0, 0x07, 0xE0, 0x03, 0xE0, 0x03, 0xC0, 0x01, 0xE0, 0x03, 0xC0, 0x01,
    0xE0, 0x03, 0xC0, 0xF0, 0x00, 0x7B, 0xC0, 0x07, 0x8F, 0x00, 0x38, 0x78,
    0x03, 0xC1, 0xE0, 0x3C, 0x07, 0x81, 0xC0, 0x3C, 0x1E, 0x00, 0xF1, 0xE0,
    0x03, 0x8E, 0x00, 0x1E, 0xF0, 0x00, 0x7F, 0x00, 0x01, 0xF0, 0x00, 0x0F,
    0x80, 0x00, 0x7C, 0x00, 0x07, 0xF0, 0x00, 0x3B, 0x80, 0x03, 0xDE, 0x00,
    0x3C, 0x78, 0x01, 0xC1, 0xC0, 0x1E, 0x0F, 0x01, 0xE0, 0x3C, 0x0E, 0x00,
    0xE0, 0xF0, 0x07, 0x8F, 0x00, 0x1E, 0x70, 0x00, 0xF7, 0x80, 0x03, 0xC0,
    0xF0, 0x00, 0x3C, 0xF0, 0x00, 0x78, 0xF0, 0x01, 0xE1, 0xE0, 0x03, 0x81,
    0xE0, 0x0F, 0x01, 0xC0, 0x1C, 0x03, 0xC0, 0x78, 0x03, 0xC1, 0xE0, 0x07,
    0x83, 0x80, 0x07, 0x8F, 0x00, 0x07, 0x1C, 0x00, 0x0F, 0x78, 0x00, 0x0E,
    0xE0, 0x00, 0x0F, 0x80, 0x00, 0x1F, 0x00, 0x00, 0x1C, 0x00, 0x00, 0x38,
    0x00, 0x00, 0x70, 0x00, 0x00, 0xE0, 0x00, 0x01, 0xC0, 0x00, 0x03, 0x80,
    0x00, 0x07, 0x00, 0x00, 0x0E, 0x00, 0x00, 0x1C, 0x00, 0x00, 0x38, 0x00,
    0x00, 0x70, 0x00, 0x7F, 0xFF, 0xEF, 0xFF, 0xFD, 0xFF, 0xFF, 0x80, 0x00,
    0xF0, 0x00, 0x3C, 0x00, 0x0F, 0x80, 0x01, 0xE0, 0x00, 0x78, 0x00, 0x1E,
    0x00, 0x07, 0x80, 0x00, 0xF0, 0x00, 0x3C, 0x00, 0x0F, 0x00, 0x03, 0xC0,
    0x00, 0x78, 0x00, 0x1E, 0x00, 0x07, 0x80, 0x01, 0xE0, 0x00, 0x7C, 0x00,
    0x0F, 0x00, 0x03, 0xC0, 0x00, 0xF0, 0x00, 0x3E, 0x00, 0x07, 0xFF, 0xFF,
    0xFF, 0xFF, 0xFF, 0xFF, 0xFC, 0xFF, 0xFF, 0xF8, 0xE3, 0x8E, 0x38, 0xE3,
    0x8E, 0x38, 0xE3, 0x8E, 0x38, 0xE3, 0x8E, 0x38, 0xE3, 0x8E, 0x38, 0xE3,
    0x8E, 0x38, 0xE3, 0x8F, 0xFF, 0xFC, 0xC0, 0x30, 0x06, 0x01, 0x80, 0x60,
    0x0C, 0x03, 0x00, 0xC0, 0x18, 0x06, 0x01, 0x80, 0x20, 0x0C, 0x03, 0x00,
    0x40, 0x18, 0x06, 0x01, 0x80, 0x30, 0x0C, 0x03, 0x00, 0x60, 0x18, 0x06,
    0x00, 0xC0, 0x30, 0xFF, 0xFF, 0xC7, 0x1C, 0x71, 0xC7, 0x1C, 0x71, 0xC7,
    0x1C, 0x71, 0xC7, 0x1C, 0x71, 0xC7, 0x1C, 0x71, 0xC7, 0x1C, 0x71, 0xC7,
    0x1C, 0x7F, 0xFF, 0xFC, 0x07, 0x00, 0x78, 0x03, 0xC0, 0x3F, 0x01, 0xD8,
    0x0C, 0xE0, 0xE3, 0x06, 0x1C, 0x70, 0xE3, 0x83, 0x18, 0x1D, 0xC0, 0x6C,
    0x03, 0x80, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xC0, 0xF0, 0xF0, 0xE0, 0xE0,
    0xE0, 0x07, 0xF0, 0x0F, 0xFC, 0x0F, 0xFF, 0x0F, 0x03, 0xC7, 0x00, 0xE0,
    0x00, 0x70, 0x00, 0x38, 0x00, 0x1C, 0x00, 0xFE, 0x0F, 0xFF, 0x1F, 0xF3,
    0x9F, 0x01, 0xCF, 0x00, 0xE7, 0x00, 0x73, 0x80, 0x79, 0xE0, 0xFC, 0x7F,
    0xEF, 0x9F, 0xE3, 0xC7, 0xE1, 0xE0, 0xE0, 0x00, 0xE0, 0x00, 0xE0, 0x00,
    0xE0, 0x00, 0xE0, 0x00, 0xE0, 0x00, 0xE0, 0x00, 0xE3, 0xE0, 0xEF, 0xF8,
    0xFF, 0xFC, 0xFC, 0x3E, 0xF8, 0x1E, 0xF0, 0x0E, 0xE0, 0x0F, 0xE0, 0x07,
    0xE0, 0x07, 0xE0, 0x07, 0xE0, 0x07, 0xE0, 0x07, 0xE0, 0x07, 0xF0, 0x0E,
    0xF8, 0x1E, 0xFC, 0x3C, 0xEF, 0xFC, 0xEF, 0xF8, 0xE3, 0xE0, 0x07, 0xF0,
    0x1F, 0xF8, 0x3F, 0xFC, 0x3C, 0x1E, 0x78, 0x0E, 0x70, 0x07, 0xE0, 0x00,
    0xE0, 0x00, 0xE0, 0x00, 0xE0, 0x00, 0xE0, 0x00, 0xE0, 0x00, 0xE0, 0x07,
    0x70, 0x07, 0x78, 0x0E, 0x7C, 0x1E, 0x3F, 0xFC, 0x1F, 0xF8, 0x07, 0xE0,
    0x00, 0x03, 0x80, 0x01, 0xC0, 0x00, 0xE0, 0x00, 0x70, 0x00, 0x38, 0x00,
    0x1C, 0x00, 0x0E, 0x0F, 0xC7, 0x1F, 0xFB, 0x9F, 0xFF, 0xDF, 0x07, 0xEF,
    0x01, 0xF7, 0x00, 0x7F, 0x80, 0x3F, 0x80, 0x0F, 0xC0, 0x07, 0xE0, 0x03,
    0xF0, 0x01, 0xF8, 0x00, 0xFC, 0x00, 0x77, 0x00, 0x7B, 0xC0, 0x7D, 0xF0,
    0x7E, 0x7F, 0xFB, 0x1F, 0xF9, 0x83, 0xF0, 0xC0, 0x07, 0xE0, 0x1F, 0xF8,
    0x3F, 0xFC, 0x7C, 0x1E, 0x70, 0x0E, 0x60, 0x06, 0xE0, 0x07, 0xFF, 0xFF,
    0xFF, 0xFF, 0xFF, 0xFF, 0xE0, 0x00, 0xE0, 0x00, 0xE0, 0x00, 0x70, 0x07,
    0x78, 0x0E, 0x3C, 0x1E, 0x3F, 0xFC, 0x1F, 0xF8, 0x07, 0xE0, 0x0E, 0x3C,
    0xF9, 0xC3, 0x87, 0x0E, 0x7F, 0xFF, 0xFC, 0xE1, 0xC3, 0x87, 0x0E, 0x1C,
    0x38, 0x70, 0xE1, 0xC3, 0x87, 0x0E, 0x1C, 0x38, 0x70, 0x07, 0xC7, 0x1F,
    0xF7, 0x3F, 0xFF, 0x3C, 0x3F, 0x78, 0x0F, 0x70, 0x0F, 0xE0, 0x07, 0xE0,
    0x07, 0xE0, 0x07, 0xE0, 0x07, 0xE0, 0x07, 0xE0, 0x07, 0xE0, 0x07, 0x70,
    0x0F, 0x78, 0x0F, 0x7C, 0x3F, 0x3F, 0xF7, 0x1F, 0xE7, 0x07, 0xC7, 0x00,
    0x07, 0x00, 0x07, 0x00, 0x0E, 0x70, 0x0E, 0x78, 0x1E, 0x3F, 0xFC, 0x1F,
    0xF8, 0x07, 0xE0, 0xE0, 0x01, 0xC0, 0x03, 0x80, 0x07, 0x00, 0x0E, 0x00,
    0x1C, 0x00, 0x38, 0x00, 0x71, 0xF8, 0xE7, 0xFD, 0xDF, 0xFB, 0xF0, 0xFF,
    0xC0, 0xFF, 0x00, 0xFC, 0x01, 0xF8, 0x03, 0xF0, 0x07, 0xE0, 0x0F, 0xC0,
    0x1F, 0x80, 0x3F, 0x00, 0x7E, 0x00, 0xFC, 0x01, 0xF8, 0x03, 0xF0, 0x07,
    0xE0, 0x0F, 0xC0, 0x1C, 0xFF, 0xF0, 0x07, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF,
    0xFF, 0xFC, 0x1C, 0x71, 0xC7, 0x00, 0x00, 0x07, 0x1C, 0x71, 0xC7, 0x1C,
    0x71, 0xC7, 0x1C, 0x71, 0xC7, 0x1C, 0x71, 0xC7, 0x1C, 0x71, 0xC7, 0x1C,
    0x73, 0xFF, 0xFB, 0xC0, 0xE0, 0x00, 0xE0, 0x00, 0xE0, 0x00, 0xE0, 0x00,
    0xE0, 0x00, 0xE0, 0x00, 0xE0, 0x00, 0xE0, 0x3C, 0xE0, 0x78, 0xE0, 0xF0,
    0xE1, 0xE0, 0xE3, 0xC0, 0xE7, 0x80, 0xEF, 0x00, 0xEF, 0x80, 0xFF, 0x80,
    0xFB, 0xC0, 0xF1, 0xE0, 0xE0, 0xE0, 0xE0, 0xF0, 0xE0, 0x70, 0xE0, 0x78,
    0xE0, 0x3C, 0xE0, 0x1C, 0xE0, 0x1E, 0xE0, 0x0E, 0xFF, 0xFF, 0xFF, 0xFF,
    0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFC, 0xE3, 0xE0, 0xF8, 0xE7, 0xF1, 0xFE,
    0xEF, 0xFB, 0xFE, 0xF8, 0x7F, 0x0F, 0xF0, 0x3E, 0x07, 0xF0, 0x1C, 0x07,
    0xE0, 0x1C, 0x07, 0xE0, 0x1C, 0x07, 0xE0, 0x1C, 0x07, 0xE0, 0x1C, 0x07,
    0xE0, 0x1C, 0x07, 0xE0, 0x1C, 0x07, 0xE0, 0x1C, 0x07, 0xE0, 0x1C, 0x07,
    0xE0, 0x1C, 0x07, 0xE0, 0x1C, 0x07, 0xE0, 0x1C, 0x07, 0xE0, 0x1C, 0x07,
    0xE0, 0x1C, 0x07, 0xE3, 0xF1, 0xCF, 0xFB, 0xBF, 0xF7, 0xE1, 0xFF, 0x81,
    0xFE, 0x01, 0xF8, 0x03, 0xF0, 0x07, 0xE0, 0x0F, 0xC0, 0x1F, 0x80, 0x3F,
    0x00, 0x7E, 0x00, 0xFC, 0x01, 0xF8, 0x03, 0xF0, 0x07, 0xE0, 0x0F, 0xC0,
    0x1F, 0x80, 0x38, 0x07, 0xF0, 0x0F, 0xFE, 0x0F, 0xFF, 0x87, 0x83, 0xC7,
    0x80, 0xF3, 0x80, 0x3B, 0x80, 0x1F, 0xC0, 0x07, 0xE0, 0x03, 0xF0, 0x01,
    0xF8, 0x00, 0xFC, 0x00, 0x7E, 0x00, 0x3B, 0x80, 0x39, 0xE0, 0x3C, 0x78,
    0x3C, 0x3F, 0xFE, 0x0F, 0xFE, 0x01, 0xFC, 0x00, 0xE3, 0xE0, 0xE7, 0xF8,
    0xEF, 0xFC, 0xFC, 0x3E, 0xF8, 0x1E, 0xF0, 0x0E, 0xE0, 0x0F, 0xE0, 0x07,
    0xE0, 0x07, 0xE0, 0x07, 0xE0, 0x07, 0xE0, 0x07, 0xE0, 0x07, 0xF0, 0x0E,
    0xF8, 0x1E, 0xFC, 0x3E, 0xFF, 0xFC, 0xEF, 0xF8, 0xE3, 0xE0, 0xE0, 0x00,
    0xE0, 0x00, 0xE0, 0x00, 0xE0, 0x00, 0xE0, 0x00, 0xE0, 0x00, 0x07, 0xE1,
    0x8F, 0xFC, 0xCF, 0xFF, 0x67, 0x83, 0xF7, 0x80, 0xFB, 0x80, 0x3F, 0xC0,
    0x1F, 0xC0, 0x07, 0xE0, 0x03, 0xF0, 0x01, 0xF8, 0x00, 0xFC, 0x00, 0x7E,
    0x00, 0x3B, 0x80, 0x3D, 0xE0, 0x3E, 0xF8, 0x3F, 0x3F, 0xFF, 0x8F, 0xFD,
    0xC1, 0xF8, 0xE0, 0x00, 0x70, 0x00, 0x38, 0x00, 0x1C, 0x00, 0x0E, 0x00,
    0x07, 0x00, 0x03, 0x80, 0xE3, 0xF7, 0xFB, 0xFF, 0x8F, 0x07, 0x83, 0x81,
    0xC0, 0xE0, 0x70, 0x38, 0x1C, 0x0E, 0x07, 0x03, 0x81, 0xC0, 0xE0, 0x70,
    0x38, 0x00, 0x0F, 0xC0, 0xFF, 0x87, 0xFF, 0x3C, 0x1E, 0xE0, 0x3B, 0x80,
    0x0E, 0x00, 0x3C, 0x00, 0x7F, 0x00, 0xFF, 0x80, 0xFF, 0x80, 0x7F, 0x00,
    0x3F, 0x80, 0x7E, 0x01, 0xFC, 0x1F, 0x7F, 0xF8, 0xFF, 0xC1, 0xFC, 0x00,
    0x38, 0x70, 0xE1, 0xCF, 0xFF, 0xFF, 0x9C, 0x38, 0x70, 0xE1, 0xC3, 0x87,
    0x0E, 0x1C, 0x38, 0x70, 0xE1, 0xC3, 0xE7, 0xC7, 0x80, 0xE0, 0x0F, 0xC0,
    0x1F, 0x80, 0x3F, 0x00, 0x7E, 0x00, 0xFC, 0x01, 0xF8, 0x03, 0xF0, 0x07,
    0xE0, 0x0F, 0xC0, 0x1F, 0x80, 0x3F, 0x00, 0x7E, 0x00, 0xFC, 0x03, 0xFC,
    0x0F, 0xFC, 0x3F, 0x7F, 0xEE, 0xFF, 0x9C, 0x7E, 0x38, 0x70, 0x03, 0xB8,
    0x03, 0x9C, 0x01, 0xC7, 0x00, 0xE3, 0x80, 0xE1, 0xC0, 0x70, 0x70, 0x38,
    0x38, 0x38, 0x1C, 0x1C, 0x07, 0x0E, 0x03, 0x8E, 0x01, 0xC7, 0x00, 0x77,
    0x00, 0x3B, 0x80, 0x1D, 0xC0, 0x07, 0xC0, 0x03, 0xE0, 0x01, 0xF0, 0x00,
    0x70, 0x00, 0xF0, 0x1C, 0x03, 0xB8, 0x1F, 0x03, 0xDC, 0x0F, 0x81, 0xCE,
    0x07, 0xC0, 0xE7, 0x83, 0xE0, 0x71, 0xC3, 0xB8, 0x70, 0xE1, 0xDC, 0x38,
    0x70, 0xEE, 0x1C, 0x1C, 0x63, 0x0E, 0x0E, 0x71, 0xCE, 0x07, 0x38, 0xE7,
    0x03, 0x9C, 0x73, 0x80, 0xEC, 0x19, 0x80, 0x7E, 0x0F, 0xC0, 0x3F, 0x07,
    0xE0, 0x0F, 0x83, 0xF0, 0x07, 0x80, 0xF0, 0x03, 0xC0, 0x78, 0x01, 0xE0,
    0x3C, 0x00, 0x70, 0x07, 0x38, 0x0E, 0x3C, 0x1C, 0x1C, 0x1C, 0x0E, 0x38,
    0x0F, 0x70, 0x07, 0x70, 0x03, 0xE0, 0x03, 0xC0, 0x01, 0xC0, 0x03, 0xE0,
    0x07, 0xE0, 0x07, 0x70, 0x0E, 0x78, 0x1E, 0x38, 0x1C, 0x1C, 0x38, 0x1E,
    0x78, 0x0E, 0x70, 0x07, 0x70, 0x07, 0x38, 0x03, 0x9C, 0x01, 0xC7, 0x01,
    0xC3, 0x80, 0xE1, 0xC0, 0x70, 0x70, 0x70, 0x38, 0x38, 0x1C, 0x3C, 0x07,
    0x1C, 0x03, 0x8E, 0x01, 0xCE, 0x00, 0x77, 0x00, 0x3B, 0x80, 0x1F, 0x80,
    0x07, 0xC0, 0x03, 0xE0, 0x01, 0xE0, 0x00, 0x70, 0x00, 0x38, 0x00, 0x38,
    0x00, 0x1C, 0x00, 0x1E, 0x00, 0x0E, 0x00, 0x3F, 0x00, 0x1F, 0x00, 0x0F,
    0x00, 0x00, 0x7F, 0xFC, 0xFF, 0xF9, 0xFF, 0xF0, 0x00, 0xE0, 0x03, 0x80,
    0x0E, 0x00, 0x3C, 0x00, 0xF0, 0x03, 0xC0, 0x0F, 0x00, 0x1C, 0x00, 0x70,
    0x01, 0xE0, 0x07, 0x80, 0x1E, 0x00, 0x78, 0x00, 0xFF, 0xFF, 0xFF, 0xFF,
    0xFF, 0xF8, 0x07, 0x0F, 0x1F, 0x1C, 0x1C, 0x1C, 0x1C, 0x1C, 0x1C, 0x1C,
    0x1C, 0x1C, 0x1C, 0x1C, 0x38, 0xF8, 0xE0, 0xF8, 0x38, 0x1C, 0x1C, 0x1C,
    0x1C, 0x1C, 0x1C, 0x1C, 0x1C, 0x1C, 0x1C, 0x1C, 0x1F, 0x0F, 0x07, 0xFF,
    0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xC0, 0xE0, 0xF0, 0xF8, 0x38,
    0x38, 0x38, 0x38, 0x38, 0x38, 0x38, 0x38, 0x38, 0x38, 0x38, 0x1C, 0x1F,
    0x07, 0x1F, 0x1C, 0x38, 0x38, 0x38, 0x38, 0x38, 0x38, 0x38, 0x38, 0x38,
    0x38, 0x38, 0xF8, 0xF0, 0xE0, 0x38, 0x00, 0xFC, 0x03, 0xFC, 0x1F, 0x3E,
    0x3C, 0x1F, 0xE0, 0x1F, 0x80, 0x1E, 0x00};

        static readonly GFXglyph[] FreeSans18pt7bGlyphs = {
    new GFXglyph(0, 0, 0, 9, 0, 1),         // 0x20 ' '
    new GFXglyph(0, 3, 26, 12, 4, -25),     // 0x21 '!'
    new GFXglyph(10, 9, 9, 12, 1, -24),     // 0x22 '"'
    new GFXglyph(21, 19, 24, 19, 0, -23),   // 0x23 '#'
    new GFXglyph(78, 16, 30, 19, 2, -26),   // 0x24 '$'
    new GFXglyph(138, 29, 25, 31, 1, -24),  // 0x25 '%'
    new GFXglyph(229, 20, 25, 23, 2, -24),  // 0x26 '&'
    new GFXglyph(292, 3, 9, 7, 2, -24),     // 0x27 '''
    new GFXglyph(296, 8, 33, 12, 3, -25),   // 0x28 '('
    new GFXglyph(329, 8, 33, 12, 1, -25),   // 0x29 ')'
    new GFXglyph(362, 10, 10, 14, 2, -25),  // 0x2A '*'
    new GFXglyph(375, 16, 16, 20, 2, -15),  // 0x2B '+'
    new GFXglyph(407, 3, 9, 10, 3, -3),     // 0x2C ','
    new GFXglyph(411, 8, 3, 12, 2, -10),    // 0x2D '-'
    new GFXglyph(414, 3, 4, 9, 3, -3),      // 0x2E '.'
    new GFXglyph(416, 10, 26, 10, 0, -25),  // 0x2F '/'
    new GFXglyph(449, 16, 25, 19, 2, -24),  // 0x30 '0'
    new GFXglyph(499, 8, 25, 19, 4, -24),   // 0x31 '1'
    new GFXglyph(524, 16, 25, 19, 2, -24),  // 0x32 '2'
    new GFXglyph(574, 17, 25, 19, 1, -24),  // 0x33 '3'
    new GFXglyph(628, 16, 25, 19, 1, -24),  // 0x34 '4'
    new GFXglyph(678, 17, 25, 19, 1, -24),  // 0x35 '5'
    new GFXglyph(732, 16, 25, 19, 2, -24),  // 0x36 '6'
    new GFXglyph(782, 16, 25, 19, 2, -24),  // 0x37 '7'
    new GFXglyph(832, 17, 25, 19, 1, -24),  // 0x38 '8'
    new GFXglyph(886, 16, 25, 19, 1, -24),  // 0x39 '9'
    new GFXglyph(936, 3, 19, 9, 3, -18),    // 0x3A ':'
    new GFXglyph(944, 3, 24, 9, 3, -18),    // 0x3B ';'
    new GFXglyph(953, 17, 17, 20, 2, -16),  // 0x3C '<'
    new GFXglyph(990, 17, 9, 20, 2, -12),   // 0x3D '='
    new GFXglyph(1010, 17, 17, 20, 2, -16), // 0x3E '>'
    new GFXglyph(1047, 15, 26, 19, 3, -25), // 0x3F '?'
    new GFXglyph(1096, 32, 31, 36, 1, -25), // 0x40 '@'
    new GFXglyph(1220, 22, 26, 23, 1, -25), // 0x41 'A'
    new GFXglyph(1292, 19, 26, 23, 3, -25), // 0x42 'B'
    new GFXglyph(1354, 22, 26, 25, 1, -25), // 0x43 'C'
    new GFXglyph(1426, 20, 26, 24, 3, -25), // 0x44 'D'
    new GFXglyph(1491, 18, 26, 22, 3, -25), // 0x45 'E'
    new GFXglyph(1550, 17, 26, 21, 3, -25), // 0x46 'F'
    new GFXglyph(1606, 24, 26, 27, 1, -25), // 0x47 'G'
    new GFXglyph(1684, 19, 26, 25, 3, -25), // 0x48 'H'
    new GFXglyph(1746, 3, 26, 10, 4, -25),  // 0x49 'I'
    new GFXglyph(1756, 14, 26, 18, 1, -25), // 0x4A 'J'
    new GFXglyph(1802, 20, 26, 24, 3, -25), // 0x4B 'K'
    new GFXglyph(1867, 15, 26, 20, 3, -25), // 0x4C 'L'
    new GFXglyph(1916, 24, 26, 30, 3, -25), // 0x4D 'M'
    new GFXglyph(1994, 20, 26, 26, 3, -25), // 0x4E 'N'
    new GFXglyph(2059, 25, 26, 27, 1, -25), // 0x4F 'O'
    new GFXglyph(2141, 18, 26, 23, 3, -25), // 0x50 'P'
    new GFXglyph(2200, 25, 28, 27, 1, -25), // 0x51 'Q'
    new GFXglyph(2288, 20, 26, 25, 3, -25), // 0x52 'R'
    new GFXglyph(2353, 20, 26, 23, 1, -25), // 0x53 'S'
    new GFXglyph(2418, 19, 26, 22, 1, -25), // 0x54 'T'
    new GFXglyph(2480, 19, 26, 25, 3, -25), // 0x55 'U'
    new GFXglyph(2542, 21, 26, 23, 1, -25), // 0x56 'V'
    new GFXglyph(2611, 32, 26, 33, 0, -25), // 0x57 'W'
    new GFXglyph(2715, 21, 26, 23, 1, -25), // 0x58 'X'
    new GFXglyph(2784, 23, 26, 24, 0, -25), // 0x59 'Y'
    new GFXglyph(2859, 19, 26, 22, 1, -25), // 0x5A 'Z'
    new GFXglyph(2921, 6, 33, 10, 2, -25),  // 0x5B '['
    new GFXglyph(2946, 10, 26, 10, 0, -25), // 0x5C '\'
    new GFXglyph(2979, 6, 33, 10, 1, -25),  // 0x5D ']'
    new GFXglyph(3004, 13, 13, 16, 2, -24), // 0x5E '^'
    new GFXglyph(3026, 21, 2, 19, -1, 5),   // 0x5F '_'
    new GFXglyph(3032, 7, 5, 9, 1, -25),    // 0x60 '`'
    new GFXglyph(3037, 17, 19, 19, 1, -18), // 0x61 'a'
    new GFXglyph(3078, 16, 26, 20, 2, -25), // 0x62 'b'
    new GFXglyph(3130, 16, 19, 18, 1, -18), // 0x63 'c'
    new GFXglyph(3168, 17, 26, 20, 1, -25), // 0x64 'd'
    new GFXglyph(3224, 16, 19, 19, 1, -18), // 0x65 'e'
    new GFXglyph(3262, 7, 26, 10, 1, -25),  // 0x66 'f'
    new GFXglyph(3285, 16, 27, 19, 1, -18), // 0x67 'g'
    new GFXglyph(3339, 15, 26, 19, 2, -25), // 0x68 'h'
    new GFXglyph(3388, 3, 26, 8, 2, -25),   // 0x69 'i'
    new GFXglyph(3398, 6, 34, 9, 0, -25),   // 0x6A 'j'
    new GFXglyph(3424, 16, 26, 18, 2, -25), // 0x6B 'k'
    new GFXglyph(3476, 3, 26, 7, 2, -25),   // 0x6C 'l'
    new GFXglyph(3486, 24, 19, 28, 2, -18), // 0x6D 'm'
    new GFXglyph(3543, 15, 19, 19, 2, -18), // 0x6E 'n'
    new GFXglyph(3579, 17, 19, 19, 1, -18), // 0x6F 'o'
    new GFXglyph(3620, 16, 25, 20, 2, -18), // 0x70 'p'
    new GFXglyph(3670, 17, 25, 20, 1, -18), // 0x71 'q'
    new GFXglyph(3724, 9, 19, 12, 2, -18),  // 0x72 'r'
    new GFXglyph(3746, 14, 19, 17, 2, -18), // 0x73 's'
    new GFXglyph(3780, 7, 23, 10, 1, -22),  // 0x74 't'
    new GFXglyph(3801, 15, 19, 19, 2, -18), // 0x75 'u'
    new GFXglyph(3837, 17, 19, 17, 0, -18), // 0x76 'v'
    new GFXglyph(3878, 25, 19, 25, 0, -18), // 0x77 'w'
    new GFXglyph(3938, 16, 19, 17, 0, -18), // 0x78 'x'
    new GFXglyph(3976, 17, 27, 17, 0, -18), // 0x79 'y'
    new GFXglyph(4034, 15, 19, 17, 1, -18), // 0x7A 'z'
    new GFXglyph(4070, 8, 33, 12, 1, -25),  // 0x7B '{'
    new GFXglyph(4103, 2, 33, 9, 3, -25),   // 0x7C '|'
    new GFXglyph(4112, 8, 33, 12, 3, -25),  // 0x7D '}'
    new GFXglyph(4145, 15, 7, 18, 1, -15)}; // 0x7E '~'

        public GFXFont_FreeSans18pt7b()
        {
            gfxfont = new GFXfont(FreeSans18pt7bBitmaps, FreeSans18pt7bGlyphs, 0x20, 0x7E, 42);
        }
        // Approx. 4831 bytes
    }
}