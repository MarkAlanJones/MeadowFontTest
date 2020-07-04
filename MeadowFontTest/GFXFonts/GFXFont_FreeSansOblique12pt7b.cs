﻿using System.Runtime.CompilerServices;

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

    public class GFXFont_FreeSansOblique12pt7b : GFXFontBase
    {

        static readonly byte[] FreeSansOblique12pt7bBitmaps = {
    0x0C, 0x61, 0x86, 0x18, 0x63, 0x0C, 0x30, 0xC2, 0x18, 0x61, 0x00, 0x00,
    0xC3, 0x00, 0xCF, 0x3C, 0xE2, 0x8A, 0x20, 0x01, 0x8C, 0x03, 0x18, 0x06,
    0x60, 0x18, 0xC0, 0x31, 0x83, 0xFF, 0x87, 0xFF, 0x03, 0x18, 0x0C, 0x60,
    0x18, 0xC0, 0x23, 0x03, 0xFF, 0x8F, 0xFF, 0x02, 0x30, 0x0C, 0x60, 0x18,
    0x80, 0x63, 0x00, 0xC6, 0x00, 0x00, 0x80, 0x3F, 0x03, 0xFC, 0x32, 0x73,
    0x91, 0x99, 0x8C, 0xCC, 0x06, 0x60, 0x3E, 0x00, 0x7E, 0x01, 0xFC, 0x0C,
    0xEC, 0x43, 0x62, 0x1B, 0x11, 0x9D, 0x9C, 0x7F, 0xC1, 0xF8, 0x02, 0x00,
    0x10, 0x01, 0x80, 0x00, 0x00, 0x01, 0x83, 0xC0, 0x60, 0xFC, 0x18, 0x30,
    0xC2, 0x0C, 0x18, 0xC1, 0x83, 0x30, 0x38, 0xCC, 0x03, 0xF1, 0x00, 0x3C,
    0x40, 0x00, 0x18, 0xF0, 0x06, 0x3F, 0x01, 0x8C, 0x30, 0x23, 0x06, 0x0C,
    0x60, 0xC3, 0x0E, 0x30, 0xC0, 0xFC, 0x10, 0x0F, 0x00, 0x01, 0xE0, 0x3F,
    0x81, 0x8C, 0x18, 0x60, 0xC3, 0x06, 0x30, 0x1F, 0x00, 0xE0, 0x1F, 0x01,
    0xDC, 0xD8, 0x6D, 0x81, 0xEC, 0x0E, 0x60, 0x73, 0x87, 0xCF, 0xE6, 0x3E,
    0x38, 0xFE, 0xA0, 0x03, 0x06, 0x04, 0x0C, 0x18, 0x18, 0x30, 0x30, 0x60,
    0x60, 0x60, 0xC0, 0xC0, 0xC0, 0xC0, 0xC0, 0xC0, 0xC0, 0xC0, 0x40, 0x60,
    0x60, 0x20, 0x04, 0x06, 0x06, 0x02, 0x03, 0x03, 0x03, 0x03, 0x03, 0x03,
    0x03, 0x03, 0x06, 0x06, 0x06, 0x0C, 0x0C, 0x18, 0x18, 0x30, 0x20, 0x60,
    0xC0, 0x0C, 0x0C, 0x49, 0x7F, 0x3C, 0x3C, 0x6C, 0x00, 0x03, 0x00, 0x30,
    0x03, 0x00, 0x30, 0xFF, 0xFF, 0xFF, 0x06, 0x00, 0x60, 0x06, 0x00, 0xC0,
    0x0C, 0x00, 0x77, 0x22, 0x6C, 0xFF, 0xF0, 0xFC, 0x00, 0x40, 0x30, 0x08,
    0x06, 0x01, 0x00, 0xC0, 0x20, 0x18, 0x04, 0x02, 0x00, 0x80, 0x40, 0x10,
    0x08, 0x02, 0x01, 0x00, 0xC0, 0x20, 0x00, 0x07, 0xC0, 0xFE, 0x1C, 0x73,
    0x83, 0x30, 0x36, 0x03, 0x60, 0x36, 0x03, 0xC0, 0x7C, 0x07, 0xC0, 0x6C,
    0x06, 0xC0, 0xEC, 0x0C, 0xE3, 0x87, 0xF0, 0x3E, 0x00, 0x02, 0x0C, 0x77,
    0xEF, 0xC1, 0x83, 0x0C, 0x18, 0x30, 0x61, 0xC3, 0x06, 0x0C, 0x18, 0x60,
    0x03, 0xF0, 0x1F, 0xE0, 0xE1, 0xC7, 0x03, 0x18, 0x0C, 0x00, 0x30, 0x01,
    0x80, 0x0E, 0x00, 0x70, 0x07, 0x80, 0x78, 0x07, 0x80, 0x38, 0x01, 0xC0,
    0x06, 0x00, 0x1F, 0xFC, 0xFF, 0xE0, 0x07, 0xC0, 0xFE, 0x1C, 0x73, 0x03,
    0x30, 0x30, 0x03, 0x00, 0xE0, 0x7C, 0x07, 0xC0, 0x0E, 0x00, 0x60, 0x06,
    0xC0, 0x6C, 0x0C, 0xE1, 0xC7, 0xF8, 0x3E, 0x00, 0x00, 0x60, 0x06, 0x00,
    0xE0, 0x1E, 0x03, 0xE0, 0x6C, 0x0C, 0xC1, 0x8C, 0x30, 0xC6, 0x1C, 0xC1,
    0x8F, 0xFF, 0xFF, 0xE0, 0x18, 0x03, 0x00, 0x30, 0x03, 0x00, 0x0F, 0xF8,
    0x7F, 0xC6, 0x00, 0x30, 0x01, 0x00, 0x1B, 0xC0, 0xFF, 0x06, 0x1C, 0x60,
    0x60, 0x03, 0x00, 0x18, 0x00, 0xC0, 0x0C, 0x60, 0x63, 0x86, 0x0F, 0xE0,
    0x3E, 0x00, 0x03, 0xC0, 0xFE, 0x1C, 0x73, 0x83, 0x30, 0x06, 0x00, 0x67,
    0x87, 0xFC, 0xF0, 0xEE, 0x06, 0xC0, 0x6C, 0x06, 0xC0, 0x4C, 0x0C, 0xE1,
    0x87, 0xF8, 0x3E, 0x00, 0x3F, 0xFB, 0xFF, 0xC0, 0x0C, 0x00, 0xC0, 0x0C,
    0x00, 0xC0, 0x06, 0x00, 0x60, 0x06, 0x00, 0x70, 0x03, 0x00, 0x30, 0x03,
    0x80, 0x18, 0x01, 0xC0, 0x0C, 0x00, 0xE0, 0x00, 0x07, 0xC0, 0xFE, 0x1C,
    0x73, 0x03, 0x30, 0x33, 0x03, 0x38, 0x61, 0xFC, 0x3F, 0xC7, 0x0E, 0x60,
    0x6C, 0x06, 0xC0, 0x6C, 0x0C, 0xE1, 0xC7, 0xF8, 0x3E, 0x00, 0x07, 0xC1,
    0xFE, 0x38, 0x73, 0x03, 0x60, 0x36, 0x03, 0x60, 0x36, 0x07, 0x70, 0xF3,
    0xFE, 0x1E, 0x60, 0x0E, 0x00, 0xCC, 0x1C, 0xE3, 0x87, 0xF0, 0x3C, 0x00,
    0x39, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x39, 0xC0, 0x1C, 0x70, 0x00, 0x00,
    0x00, 0x00, 0x00, 0x07, 0x1C, 0x20, 0x86, 0x30, 0x00, 0x00, 0x01, 0xC0,
    0x3C, 0x0F, 0x81, 0xE0, 0x7C, 0x03, 0x80, 0x0F, 0x00, 0x1F, 0x00, 0x3E,
    0x00, 0x38, 0x00, 0x40, 0x7F, 0xFB, 0xFF, 0x80, 0x00, 0x00, 0x0F, 0xFF,
    0x7F, 0xF0, 0x20, 0x01, 0xC0, 0x07, 0xC0, 0x0F, 0x80, 0x0F, 0x00, 0x1C,
    0x03, 0xE0, 0x78, 0x1F, 0x03, 0xC0, 0x38, 0x00, 0x00, 0x00, 0x0F, 0x87,
    0xF9, 0xC3, 0xB0, 0x3C, 0x06, 0x00, 0xC0, 0x30, 0x0C, 0x03, 0x01, 0xC0,
    0x30, 0x0C, 0x01, 0x80, 0x00, 0x00, 0x00, 0x00, 0x30, 0x06, 0x00, 0x00,
    0x3F, 0x80, 0x01, 0xFF, 0xE0, 0x0F, 0x01, 0xE0, 0x38, 0x00, 0xE0, 0xE0,
    0x00, 0xC3, 0x87, 0x81, 0xCE, 0x1F, 0xB1, 0x98, 0x71, 0xC3, 0x61, 0x83,
    0x86, 0xC6, 0x06, 0x0F, 0x0C, 0x0C, 0x3E, 0x30, 0x30, 0x6C, 0x60, 0x61,
    0xD8, 0xC1, 0x87, 0x31, 0xC7, 0x1C, 0x61, 0xF7, 0xF0, 0x63, 0xCF, 0x80,
    0xE0, 0x00, 0x00, 0xF0, 0x00, 0x00, 0xFF, 0xE0, 0x00, 0x7F, 0x00, 0x00,
    0x00, 0x38, 0x00, 0x78, 0x00, 0x7C, 0x00, 0xFC, 0x00, 0xDC, 0x01, 0xCC,
    0x01, 0x8C, 0x03, 0x8C, 0x03, 0x0C, 0x06, 0x0C, 0x0E, 0x0E, 0x0F, 0xFE,
    0x1F, 0xFE, 0x18, 0x06, 0x38, 0x06, 0x30, 0x06, 0x70, 0x06, 0x60, 0x07,
    0x0F, 0xF8, 0x1F, 0xF8, 0x60, 0x38, 0xC0, 0x31, 0x80, 0x63, 0x00, 0xCE,
    0x03, 0x18, 0x0C, 0x3F, 0xF0, 0x7F, 0xF0, 0xC0, 0x73, 0x00, 0x66, 0x00,
    0xCC, 0x01, 0x98, 0x06, 0x70, 0x1C, 0xFF, 0xF1, 0xFF, 0x80, 0x01, 0xF8,
    0x07, 0xFE, 0x0E, 0x0E, 0x1C, 0x03, 0x38, 0x03, 0x30, 0x00, 0x60, 0x00,
    0x60, 0x00, 0xC0, 0x00, 0xC0, 0x00, 0xC0, 0x00, 0xC0, 0x00, 0xC0, 0x06,
    0xC0, 0x0C, 0xE0, 0x1C, 0x70, 0x78, 0x3F, 0xF0, 0x1F, 0x80, 0x0F, 0xF8,
    0x1F, 0xFC, 0x18, 0x0E, 0x18, 0x07, 0x18, 0x03, 0x18, 0x03, 0x38, 0x03,
    0x30, 0x03, 0x30, 0x03, 0x30, 0x03, 0x70, 0x06, 0x70, 0x06, 0x60, 0x0C,
    0x60, 0x0C, 0x60, 0x18, 0xE0, 0x78, 0xFF, 0xE0, 0xFF, 0x80, 0x0F, 0xFF,
    0x1F, 0xFE, 0x18, 0x00, 0x18, 0x00, 0x18, 0x00, 0x18, 0x00, 0x38, 0x00,
    0x30, 0x00, 0x3F, 0xFC, 0x3F, 0xF8, 0x70, 0x00, 0x70, 0x00, 0x60, 0x00,
    0x60, 0x00, 0x60, 0x00, 0xE0, 0x00, 0xFF, 0xF8, 0xFF, 0xF8, 0x0F, 0xFE,
    0x3F, 0xFC, 0x60, 0x00, 0xC0, 0x01, 0x80, 0x03, 0x00, 0x0E, 0x00, 0x18,
    0x00, 0x3F, 0xF0, 0x7F, 0xE1, 0xC0, 0x03, 0x80, 0x06, 0x00, 0x0C, 0x00,
    0x18, 0x00, 0x70, 0x00, 0xC0, 0x01, 0x80, 0x00, 0x01, 0xF8, 0x07, 0xFE,
    0x0E, 0x0F, 0x18, 0x03, 0x30, 0x03, 0x70, 0x00, 0x60, 0x00, 0x60, 0x00,
    0xC0, 0x7F, 0xC0, 0x7E, 0xC0, 0x02, 0xC0, 0x06, 0xC0, 0x06, 0xE0, 0x0E,
    0x60, 0x1E, 0x78, 0x3C, 0x3F, 0xE4, 0x0F, 0x84, 0x0C, 0x01, 0x8E, 0x00,
    0xC6, 0x00, 0xE3, 0x00, 0x61, 0x80, 0x30, 0xC0, 0x18, 0xE0, 0x0C, 0x60,
    0x0E, 0x3F, 0xFE, 0x1F, 0xFF, 0x1C, 0x01, 0x8E, 0x01, 0xC6, 0x00, 0xE3,
    0x00, 0x61, 0x80, 0x31, 0xC0, 0x18, 0xC0, 0x1C, 0x60, 0x0C, 0x00, 0x0C,
    0x71, 0x86, 0x18, 0x63, 0x8C, 0x30, 0xC3, 0x1C, 0x61, 0x86, 0x18, 0xE3,
    0x00, 0x00, 0x18, 0x01, 0x80, 0x0C, 0x00, 0x60, 0x03, 0x00, 0x38, 0x01,
    0x80, 0x0C, 0x00, 0x60, 0x03, 0x00, 0x38, 0x01, 0x8C, 0x0C, 0x60, 0x63,
    0x07, 0x1C, 0x70, 0x7F, 0x01, 0xF0, 0x00, 0x0C, 0x03, 0x87, 0x01, 0xC1,
    0x80, 0xE0, 0x60, 0x60, 0x18, 0x70, 0x06, 0x38, 0x03, 0x9C, 0x00, 0xCE,
    0x00, 0x37, 0x80, 0x0F, 0x70, 0x07, 0x8C, 0x01, 0xC3, 0x80, 0x60, 0x60,
    0x18, 0x1C, 0x06, 0x03, 0x03, 0x80, 0xE0, 0xC0, 0x18, 0x30, 0x07, 0x00,
    0x0C, 0x03, 0x80, 0x60, 0x0C, 0x01, 0x80, 0x30, 0x0E, 0x01, 0x80, 0x30,
    0x06, 0x01, 0xC0, 0x38, 0x06, 0x00, 0xC0, 0x18, 0x07, 0x00, 0xFF, 0xFF,
    0xFC, 0x0E, 0x00, 0x71, 0xE0, 0x0F, 0x1E, 0x00, 0xF1, 0xE0, 0x1E, 0x1E,
    0x01, 0xE1, 0xE0, 0x36, 0x3B, 0x03, 0x63, 0x30, 0x6E, 0x33, 0x0E, 0xC3,
    0x30, 0xCC, 0x33, 0x18, 0xC6, 0x31, 0x8C, 0x63, 0x31, 0xC6, 0x33, 0x18,
    0x61, 0xE1, 0x8E, 0x1E, 0x18, 0xC1, 0xC1, 0x8C, 0x1C, 0x38, 0x0C, 0x01,
    0x8F, 0x00, 0xC7, 0x80, 0x63, 0xE0, 0x71, 0xF0, 0x30, 0xD8, 0x18, 0xEE,
    0x0C, 0x63, 0x06, 0x31, 0xC7, 0x18, 0xE3, 0x0C, 0x31, 0x8C, 0x1C, 0xC6,
    0x06, 0x63, 0x03, 0xF1, 0x80, 0xF1, 0xC0, 0x78, 0xC0, 0x3C, 0x60, 0x0E,
    0x00, 0x01, 0xF8, 0x03, 0xFF, 0x03, 0x83, 0xC3, 0x80, 0x63, 0x00, 0x3B,
    0x80, 0x0D, 0x80, 0x06, 0xC0, 0x03, 0xC0, 0x01, 0xE0, 0x00, 0xF0, 0x00,
    0xF8, 0x00, 0x6C, 0x00, 0x36, 0x00, 0x31, 0x80, 0x30, 0xF0, 0x78, 0x3F,
    0xF0, 0x07, 0xE0, 0x00, 0x0F, 0xF8, 0x3F, 0xF8, 0x60, 0x38, 0xC0, 0x31,
    0x80, 0x63, 0x00, 0xCE, 0x03, 0x18, 0x0E, 0x3F, 0xF8, 0x7F, 0xE1, 0xC0,
    0x03, 0x80, 0x06, 0x00, 0x0C, 0x00, 0x18, 0x00, 0x70, 0x00, 0xC0, 0x01,
    0x80, 0x00, 0x00, 0xFC, 0x01, 0xFF, 0xC0, 0xF0, 0x78, 0x70, 0x06, 0x38,
    0x01, 0xCC, 0x00, 0x36, 0x00, 0x0D, 0x80, 0x03, 0xC0, 0x00, 0xF0, 0x00,
    0x3C, 0x00, 0x1B, 0x00, 0x06, 0xC0, 0x03, 0x38, 0x1D, 0xC6, 0x03, 0xE1,
    0xE0, 0xF0, 0x3F, 0xFE, 0x03, 0xF1, 0xC0, 0x00, 0x20, 0x0F, 0xFC, 0x1F,
    0xFE, 0x18, 0x07, 0x18, 0x03, 0x18, 0x03, 0x18, 0x03, 0x38, 0x06, 0x30,
    0x0C, 0x3F, 0xF8, 0x3F, 0xF8, 0x70, 0x1C, 0x70, 0x0C, 0x60, 0x0C, 0x60,
    0x0C, 0x60, 0x18, 0xE0, 0x18, 0xC0, 0x18, 0xC0, 0x1C, 0x03, 0xF8, 0x1F,
    0xF8, 0x70, 0x38, 0xC0, 0x33, 0x00, 0x66, 0x00, 0x0C, 0x00, 0x1E, 0x00,
    0x1F, 0xC0, 0x0F, 0xF0, 0x01, 0xF0, 0x00, 0xEC, 0x00, 0xD8, 0x01, 0xB0,
    0x06, 0x70, 0x38, 0x7F, 0xE0, 0x3F, 0x00, 0xFF, 0xFF, 0xFF, 0xF0, 0x70,
    0x01, 0xC0, 0x06, 0x00, 0x18, 0x00, 0x60, 0x03, 0x80, 0x0C, 0x00, 0x30,
    0x00, 0xC0, 0x03, 0x00, 0x1C, 0x00, 0x60, 0x01, 0x80, 0x06, 0x00, 0x18,
    0x00, 0xE0, 0x00, 0x18, 0x03, 0x38, 0x03, 0x30, 0x07, 0x30, 0x06, 0x30,
    0x06, 0x70, 0x06, 0x70, 0x0E, 0x60, 0x0C, 0x60, 0x0C, 0x60, 0x0C, 0xE0,
    0x0C, 0xC0, 0x1C, 0xC0, 0x18, 0xC0, 0x18, 0xC0, 0x38, 0xE0, 0x70, 0x7F,
    0xE0, 0x1F, 0x80, 0xC0, 0x0F, 0xC0, 0x1B, 0x80, 0x73, 0x00, 0xC6, 0x03,
    0x0C, 0x06, 0x18, 0x18, 0x30, 0x70, 0x60, 0xC0, 0xE3, 0x81, 0xC6, 0x01,
    0x9C, 0x03, 0x30, 0x06, 0xE0, 0x0D, 0x80, 0x1E, 0x00, 0x3C, 0x00, 0x70,
    0x00, 0xC0, 0x70, 0x1F, 0x01, 0xC0, 0x6C, 0x0F, 0x03, 0xB0, 0x3C, 0x0C,
    0xC1, 0xF0, 0x73, 0x06, 0xC1, 0x8C, 0x3B, 0x06, 0x30, 0xC6, 0x30, 0xC7,
    0x18, 0xC3, 0x18, 0x67, 0x0C, 0xE1, 0x98, 0x33, 0x06, 0xE0, 0xDC, 0x1B,
    0x03, 0x60, 0x6C, 0x07, 0x81, 0xE0, 0x1C, 0x07, 0x80, 0x70, 0x1C, 0x01,
    0x80, 0x70, 0x00, 0x07, 0x00, 0xE0, 0xE0, 0x38, 0x0C, 0x0E, 0x01, 0xC3,
    0x80, 0x18, 0xE0, 0x03, 0x98, 0x00, 0x36, 0x00, 0x07, 0x80, 0x00, 0xF0,
    0x00, 0x1E, 0x00, 0x07, 0xC0, 0x01, 0xDC, 0x00, 0x73, 0x80, 0x1C, 0x30,
    0x03, 0x07, 0x00, 0xC0, 0x60, 0x38, 0x0E, 0x0E, 0x00, 0xC0, 0xE0, 0x06,
    0x60, 0x0C, 0x70, 0x1C, 0x70, 0x38, 0x30, 0x70, 0x38, 0x60, 0x18, 0xC0,
    0x1D, 0xC0, 0x1F, 0x80, 0x0F, 0x00, 0x0E, 0x00, 0x0E, 0x00, 0x0E, 0x00,
    0x0C, 0x00, 0x0C, 0x00, 0x0C, 0x00, 0x1C, 0x00, 0x18, 0x00, 0x0F, 0xFF,
    0x87, 0xFF, 0x80, 0x01, 0xC0, 0x01, 0xC0, 0x01, 0xC0, 0x01, 0xC0, 0x01,
    0xC0, 0x01, 0xC0, 0x01, 0xC0, 0x01, 0xC0, 0x01, 0xC0, 0x01, 0xC0, 0x01,
    0xC0, 0x01, 0xC0, 0x00, 0xC0, 0x00, 0xC0, 0x00, 0xFF, 0xF8, 0x7F, 0xFC,
    0x00, 0x07, 0xC1, 0xE0, 0x60, 0x18, 0x0C, 0x03, 0x00, 0xC0, 0x30, 0x1C,
    0x06, 0x01, 0x80, 0x60, 0x18, 0x0E, 0x03, 0x00, 0xC0, 0x30, 0x0C, 0x06,
    0x01, 0x80, 0x60, 0x1E, 0x07, 0x80, 0x93, 0x6C, 0x92, 0x49, 0x24, 0xDB,
    0x24, 0x07, 0x81, 0xE0, 0x18, 0x06, 0x01, 0x80, 0xC0, 0x30, 0x0C, 0x03,
    0x01, 0xC0, 0x60, 0x18, 0x06, 0x01, 0x80, 0xE0, 0x30, 0x0C, 0x03, 0x00,
    0xC0, 0x60, 0x18, 0x1E, 0x0F, 0x80, 0x03, 0x01, 0xC0, 0xD8, 0x36, 0x19,
    0x84, 0x63, 0x19, 0x83, 0x60, 0xC0, 0xFF, 0xFC, 0xE6, 0x23, 0x07, 0xC3,
    0xFC, 0xE3, 0x98, 0x30, 0x06, 0x01, 0x87, 0xF3, 0xC6, 0xC0, 0xD8, 0x3B,
    0x0E, 0x7F, 0x77, 0xCC, 0x0C, 0x00, 0x60, 0x03, 0x00, 0x30, 0x01, 0x80,
    0x0C, 0xF0, 0x7F, 0xC3, 0x87, 0x38, 0x19, 0x80, 0xCC, 0x06, 0x60, 0x32,
    0x03, 0xB0, 0x19, 0xC1, 0xCE, 0x1C, 0x7F, 0xC3, 0x7C, 0x00, 0x0F, 0x83,
    0xF8, 0xE3, 0xB8, 0x36, 0x07, 0xC0, 0x30, 0x06, 0x00, 0xC0, 0x18, 0x1B,
    0x86, 0x3F, 0xC3, 0xE0, 0x00, 0x0C, 0x00, 0x60, 0x01, 0x80, 0x06, 0x00,
    0x18, 0x3E, 0x61, 0xFF, 0x0E, 0x3C, 0x70, 0x71, 0x80, 0xCE, 0x07, 0x30,
    0x18, 0xC0, 0x63, 0x01, 0x8C, 0x0E, 0x38, 0x78, 0x7F, 0xC0, 0xFB, 0x00,
    0x07, 0xC1, 0xFE, 0x38, 0x77, 0x03, 0x60, 0x37, 0xFF, 0xFF, 0xFC, 0x00,
    0xC0, 0x0C, 0x06, 0xE1, 0xC7, 0xF8, 0x3E, 0x00, 0x07, 0x0F, 0x1C, 0x18,
    0x18, 0x7E, 0x7E, 0x30, 0x30, 0x30, 0x30, 0x60, 0x60, 0x60, 0x60, 0x60,
    0xC0, 0xC0, 0x03, 0xCC, 0x3F, 0xA1, 0xC7, 0x8E, 0x0E, 0x30, 0x38, 0xC0,
    0xC6, 0x03, 0x18, 0x0C, 0x60, 0x71, 0x81, 0xC7, 0x0E, 0x0F, 0xF8, 0x1E,
    0x60, 0x03, 0x80, 0x0C, 0x30, 0x70, 0x7F, 0x80, 0xF8, 0x00, 0x0C, 0x00,
    0xC0, 0x0C, 0x01, 0x80, 0x18, 0x01, 0x9E, 0x1F, 0xF1, 0xC7, 0x38, 0x33,
    0x03, 0x30, 0x33, 0x07, 0x30, 0x66, 0x06, 0x60, 0x66, 0x06, 0x60, 0xC6,
    0x0C, 0x18, 0xC0, 0x00, 0x18, 0xC6, 0x33, 0x18, 0xC6, 0x31, 0x98, 0xC6,
    0x00, 0x01, 0x80, 0xC0, 0x00, 0x00, 0x00, 0x18, 0x1C, 0x0C, 0x06, 0x03,
    0x01, 0x81, 0x80, 0xC0, 0x60, 0x30, 0x18, 0x18, 0x0C, 0x06, 0x03, 0x03,
    0x87, 0x83, 0x80, 0x0C, 0x00, 0x60, 0x03, 0x00, 0x30, 0x01, 0x80, 0x0C,
    0x18, 0x61, 0x83, 0x38, 0x33, 0x81, 0xB8, 0x0F, 0xC0, 0x77, 0x03, 0x18,
    0x30, 0xC1, 0x87, 0x0C, 0x18, 0x60, 0xE3, 0x03, 0x00, 0x18, 0xC6, 0x63,
    0x18, 0xC6, 0x33, 0x18, 0xC6, 0x31, 0x98, 0xC6, 0x00, 0x1B, 0xE3, 0xC3,
    0xFD, 0xFC, 0xF1, 0xE1, 0x9C, 0x18, 0x33, 0x03, 0x06, 0x60, 0xC0, 0xCC,
    0x18, 0x3B, 0x83, 0x06, 0x60, 0x60, 0xCC, 0x0C, 0x19, 0x83, 0x03, 0x30,
    0x60, 0xE6, 0x0C, 0x18, 0x1B, 0xE1, 0xFF, 0x3C, 0x73, 0x83, 0x30, 0x33,
    0x03, 0x30, 0x77, 0x06, 0x60, 0x66, 0x06, 0x60, 0x66, 0x0C, 0x60, 0xC0,
    0x07, 0xC1, 0xFE, 0x38, 0x77, 0x03, 0x60, 0x3E, 0x03, 0xC0, 0x3C, 0x06,
    0xC0, 0x6C, 0x0E, 0xE1, 0xC7, 0xF8, 0x3E, 0x00, 0x0C, 0xF0, 0x3F, 0xE0,
    0xE1, 0xC7, 0x03, 0x1C, 0x0C, 0x60, 0x31, 0x80, 0xCE, 0x07, 0x38, 0x18,
    0xE0, 0xE3, 0xC7, 0x0F, 0xF8, 0x77, 0xC1, 0x80, 0x06, 0x00, 0x18, 0x00,
    0x60, 0x03, 0x80, 0x00, 0x0F, 0x98, 0xFF, 0xCE, 0x3C, 0xE0, 0xE6, 0x03,
    0x70, 0x1B, 0x01, 0x98, 0x0C, 0xC0, 0x66, 0x07, 0x38, 0x78, 0xFF, 0x83,
    0xCC, 0x00, 0x60, 0x07, 0x00, 0x38, 0x01, 0x80, 0x0C, 0x00, 0x1B, 0x8F,
    0xCF, 0x07, 0x03, 0x01, 0x80, 0xC0, 0xE0, 0x60, 0x30, 0x18, 0x0C, 0x06,
    0x00, 0x0F, 0xC1, 0xFF, 0x30, 0x76, 0x03, 0x60, 0x07, 0x80, 0x3F, 0x80,
    0x7E, 0x00, 0x6C, 0x06, 0xE0, 0xCF, 0xF8, 0x3E, 0x00, 0x18, 0x30, 0x67,
    0xEF, 0xC6, 0x0C, 0x30, 0x60, 0xC1, 0x83, 0x0C, 0x18, 0x3C, 0x38, 0x30,
    0x33, 0x03, 0x30, 0x37, 0x06, 0x60, 0x66, 0x06, 0x60, 0x66, 0x06, 0xC0,
    0xEC, 0x0C, 0xC3, 0xCF, 0xFC, 0x7C, 0xC0, 0xC0, 0x78, 0x1B, 0x03, 0x60,
    0xC6, 0x18, 0xC6, 0x19, 0xC3, 0x30, 0x6C, 0x0D, 0x81, 0xE0, 0x3C, 0x03,
    0x00, 0xC1, 0xC3, 0xE1, 0xE1, 0xB0, 0xF0, 0xD8, 0x78, 0xCC, 0x6C, 0x66,
    0x36, 0x63, 0x33, 0x30, 0x99, 0xB0, 0x58, 0xD8, 0x2C, 0x78, 0x1C, 0x3C,
    0x0E, 0x1C, 0x06, 0x0E, 0x00, 0x0C, 0x1C, 0x30, 0xE0, 0xE3, 0x01, 0x98,
    0x07, 0xC0, 0x0E, 0x00, 0x30, 0x01, 0xE0, 0x0F, 0x80, 0x73, 0x01, 0x8C,
    0x0C, 0x38, 0x60, 0x60, 0x18, 0x0C, 0x60, 0x61, 0x83, 0x86, 0x0C, 0x1C,
    0x60, 0x31, 0x80, 0xCC, 0x03, 0x30, 0x0D, 0x80, 0x36, 0x00, 0xF0, 0x03,
    0x80, 0x06, 0x00, 0x30, 0x00, 0xC0, 0x06, 0x00, 0xF0, 0x03, 0x80, 0x00,
    0x1F, 0xF1, 0xFF, 0x00, 0x70, 0x0C, 0x01, 0x80, 0x30, 0x06, 0x00, 0xC0,
    0x18, 0x03, 0x00, 0x60, 0x0F, 0xFC, 0xFF, 0xC0, 0x07, 0x0E, 0x18, 0x18,
    0x18, 0x18, 0x30, 0x30, 0x30, 0x30, 0x60, 0xE0, 0xE0, 0x60, 0x60, 0x60,
    0xC0, 0xC0, 0xC0, 0xC0, 0xC0, 0xF0, 0x60, 0x0C, 0x30, 0x82, 0x08, 0x61,
    0x84, 0x10, 0x43, 0x0C, 0x20, 0x86, 0x18, 0x41, 0x04, 0x30, 0xC2, 0x00,
    0x00, 0x06, 0x07, 0x80, 0xC0, 0x60, 0x30, 0x18, 0x0C, 0x0C, 0x06, 0x03,
    0x01, 0xC0, 0xE0, 0x60, 0x60, 0x30, 0x18, 0x0C, 0x0C, 0x06, 0x03, 0x01,
    0x83, 0x83, 0x80, 0x38, 0x0F, 0x82, 0x38, 0x83, 0xE0, 0x38};

        static readonly GFXglyph[] FreeSansOblique12pt7bGlyphs = {
            new GFXglyph(0, 0, 0, 7, 0, 1),         // 0x20 ' '
            new GFXglyph(0, 6, 18, 7, 3, -17),      // 0x21 '!'
            new GFXglyph(14, 6, 6, 9, 4, -16),      // 0x22 '"'
            new GFXglyph(19, 15, 18, 13, 1, -17),   // 0x23 '#'
            new GFXglyph(53, 13, 21, 13, 2, -17),   // 0x24 '$'
            new GFXglyph(88, 19, 17, 21, 3, -16),   // 0x25 '%'
            new GFXglyph(129, 13, 17, 16, 2, -16),  // 0x26 '&'
            new GFXglyph(157, 2, 6, 5, 4, -16),     // 0x27 '''
            new GFXglyph(159, 8, 23, 8, 3, -17),    // 0x28 '('
            new GFXglyph(182, 8, 23, 8, 0, -16),    // 0x29 ')'
            new GFXglyph(205, 8, 8, 9, 4, -17),     // 0x2A '*'
            new GFXglyph(213, 12, 11, 14, 2, -10),  // 0x2B '+'
            new GFXglyph(230, 4, 6, 7, 1, -1),      // 0x2C ','
            new GFXglyph(233, 6, 2, 8, 2, -7),      // 0x2D '-'
            new GFXglyph(235, 3, 2, 7, 2, -1),      // 0x2E '.'
            new GFXglyph(236, 10, 18, 7, 0, -17),   // 0x2F '/'
            new GFXglyph(259, 12, 17, 13, 2, -16),  // 0x30 '0'
            new GFXglyph(285, 7, 17, 13, 5, -16),   // 0x31 '1'
            new GFXglyph(300, 14, 17, 13, 1, -16),  // 0x32 '2'
            new GFXglyph(330, 12, 17, 13, 2, -16),  // 0x33 '3'
            new GFXglyph(356, 12, 17, 13, 2, -16),  // 0x34 '4'
            new GFXglyph(382, 13, 17, 13, 2, -16),  // 0x35 '5'
            new GFXglyph(410, 12, 17, 13, 2, -16),  // 0x36 '6'
            new GFXglyph(436, 13, 17, 13, 3, -16),  // 0x37 '7'
            new GFXglyph(464, 12, 17, 13, 2, -16),  // 0x38 '8'
            new GFXglyph(490, 12, 17, 13, 2, -16),  // 0x39 '9'
            new GFXglyph(516, 5, 12, 7, 3, -11),    // 0x3A ':'
            new GFXglyph(524, 6, 16, 7, 2, -11),    // 0x3B ';'
            new GFXglyph(536, 13, 12, 14, 2, -11),  // 0x3C '<'
            new GFXglyph(556, 13, 6, 14, 2, -8),    // 0x3D '='
            new GFXglyph(566, 13, 12, 14, 1, -10),  // 0x3E '>'
            new GFXglyph(586, 11, 18, 13, 4, -17),  // 0x3F '?'
            new GFXglyph(611, 23, 21, 24, 2, -17),  // 0x40 '@'
            new GFXglyph(672, 16, 18, 16, 0, -17),  // 0x41 'A'
            new GFXglyph(708, 15, 18, 16, 2, -17),  // 0x42 'B'
            new GFXglyph(742, 16, 18, 17, 2, -17),  // 0x43 'C'
            new GFXglyph(778, 16, 18, 17, 2, -17),  // 0x44 'D'
            new GFXglyph(814, 16, 18, 16, 2, -17),  // 0x45 'E'
            new GFXglyph(850, 15, 18, 14, 2, -17),  // 0x46 'F'
            new GFXglyph(884, 16, 18, 19, 3, -17),  // 0x47 'G'
            new GFXglyph(920, 17, 18, 17, 2, -17),  // 0x48 'H'
            new GFXglyph(959, 6, 18, 7, 2, -17),    // 0x49 'I'
            new GFXglyph(973, 13, 18, 12, 1, -17),  // 0x4A 'J'
            new GFXglyph(1003, 18, 18, 16, 2, -17), // 0x4B 'K'
            new GFXglyph(1044, 11, 18, 13, 2, -17), // 0x4C 'L'
            new GFXglyph(1069, 20, 18, 20, 2, -17), // 0x4D 'M'
            new GFXglyph(1114, 17, 18, 18, 2, -17), // 0x4E 'N'
            new GFXglyph(1153, 17, 18, 18, 2, -17), // 0x4F 'O'
            new GFXglyph(1192, 15, 18, 15, 2, -17), // 0x50 'P'
            new GFXglyph(1226, 18, 19, 19, 2, -17), // 0x51 'Q'
            new GFXglyph(1269, 16, 18, 17, 2, -17), // 0x52 'R'
            new GFXglyph(1305, 15, 18, 16, 2, -17), // 0x53 'S'
            new GFXglyph(1339, 14, 18, 15, 4, -17), // 0x54 'T'
            new GFXglyph(1371, 16, 18, 17, 3, -17), // 0x55 'U'
            new GFXglyph(1407, 15, 18, 15, 4, -17), // 0x56 'V'
            new GFXglyph(1441, 22, 18, 22, 4, -17), // 0x57 'W'
            new GFXglyph(1491, 19, 18, 16, 0, -17), // 0x58 'X'
            new GFXglyph(1534, 16, 18, 16, 4, -17), // 0x59 'Y'
            new GFXglyph(1570, 17, 18, 15, 1, -17), // 0x5A 'Z'
            new GFXglyph(1609, 10, 23, 7, 0, -17),  // 0x5B '['
            new GFXglyph(1638, 3, 18, 7, 4, -17),   // 0x5C '\'
            new GFXglyph(1645, 10, 23, 7, -1, -16), // 0x5D ']'
            new GFXglyph(1674, 10, 9, 11, 2, -16),  // 0x5E '^'
            new GFXglyph(1686, 14, 1, 13, -1, 4),   // 0x5F '_'
            new GFXglyph(1688, 4, 4, 8, 4, -17),    // 0x60 '`'
            new GFXglyph(1690, 11, 13, 13, 2, -12), // 0x61 'a'
            new GFXglyph(1708, 13, 18, 13, 1, -17), // 0x62 'b'
            new GFXglyph(1738, 11, 13, 12, 2, -12), // 0x63 'c'
            new GFXglyph(1756, 14, 18, 13, 2, -17), // 0x64 'd'
            new GFXglyph(1788, 12, 13, 13, 2, -12), // 0x65 'e'
            new GFXglyph(1808, 8, 18, 6, 2, -17),   // 0x66 'f'
            new GFXglyph(1826, 14, 18, 13, 1, -12), // 0x67 'g'
            new GFXglyph(1858, 12, 18, 13, 1, -17), // 0x68 'h'
            new GFXglyph(1885, 5, 18, 5, 2, -17),   // 0x69 'i'
            new GFXglyph(1897, 9, 23, 6, -1, -17),  // 0x6A 'j'
            new GFXglyph(1923, 13, 18, 12, 1, -17), // 0x6B 'k'
            new GFXglyph(1953, 5, 18, 5, 2, -17),   // 0x6C 'l'
            new GFXglyph(1965, 19, 13, 20, 1, -12), // 0x6D 'm'
            new GFXglyph(1996, 12, 13, 13, 1, -12), // 0x6E 'n'
            new GFXglyph(2016, 12, 13, 13, 2, -12), // 0x6F 'o'
            new GFXglyph(2036, 14, 18, 14, 0, -12), // 0x70 'p'
            new GFXglyph(2068, 13, 18, 13, 2, -12), // 0x71 'q'
            new GFXglyph(2098, 9, 13, 8, 1, -12),   // 0x72 'r'
            new GFXglyph(2113, 12, 13, 12, 1, -12), // 0x73 's'
            new GFXglyph(2133, 7, 16, 6, 2, -15),   // 0x74 't'
            new GFXglyph(2147, 12, 13, 13, 2, -12), // 0x75 'u'
            new GFXglyph(2167, 11, 13, 12, 3, -12), // 0x76 'v'
            new GFXglyph(2185, 17, 13, 17, 3, -12), // 0x77 'w'
            new GFXglyph(2213, 14, 13, 12, 0, -12), // 0x78 'x'
            new GFXglyph(2236, 14, 18, 11, 0, -12), // 0x79 'y'
            new GFXglyph(2268, 12, 13, 12, 1, -12), // 0x7A 'z'
            new GFXglyph(2288, 8, 23, 8, 3, -17),   // 0x7B '{'
            new GFXglyph(2311, 6, 23, 6, 1, -17),   // 0x7C '|'
            new GFXglyph(2329, 9, 23, 8, -1, -16),  // 0x7D '}'
            new GFXglyph(2355, 11, 5, 14, 3, -10)}; // 0x7E '~'

        public GFXFont_FreeSansOblique12pt7b()
        {
            gfxfont = new GFXfont(FreeSansOblique12pt7bBitmaps, FreeSansOblique12pt7bGlyphs, 0x20, 0x7E, 29);
        }
        // Approx. 3034 bytes

    }
}
