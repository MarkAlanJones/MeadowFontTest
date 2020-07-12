

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

    public class GFXFont_FreeMonoOblique12pt7b : GFXFontBase
    {
        static readonly byte[] FreeMonoOblique12pt7bBitmaps = {
    0x11, 0x11, 0x12, 0x22, 0x22, 0x00, 0x0E, 0xE0, 0xE7, 0xE7, 0xC6, 0xC6,
    0xC6, 0x84, 0x84, 0x02, 0x40, 0x88, 0x12, 0x02, 0x40, 0x48, 0x7F, 0xC2,
    0x40, 0x48, 0x11, 0x1F, 0xF8, 0x48, 0x09, 0x02, 0x40, 0x48, 0x09, 0x02,
    0x20, 0x02, 0x01, 0x00, 0xF4, 0xC3, 0x60, 0x50, 0x04, 0x00, 0xC0, 0x0F,
    0x00, 0x60, 0x0A, 0x02, 0x81, 0x30, 0xC7, 0xC0, 0x80, 0x20, 0x08, 0x00,
    0x0E, 0x02, 0x20, 0x84, 0x10, 0x82, 0x20, 0x38, 0x00, 0x38, 0x38, 0x38,
    0x08, 0xE0, 0x22, 0x08, 0x41, 0x08, 0x22, 0x03, 0x80, 0x07, 0x84, 0x04,
    0x02, 0x01, 0x00, 0xC1, 0xA2, 0x8A, 0x85, 0x43, 0x31, 0x8F, 0x60, 0xFF,
    0x6D, 0x20, 0x00, 0x44, 0x42, 0x21, 0x08, 0x84, 0x21, 0x08, 0x42, 0x10,
    0x42, 0x00, 0x00, 0x84, 0x10, 0x84, 0x21, 0x08, 0x46, 0x21, 0x10, 0x88,
    0x44, 0x00, 0x04, 0x02, 0x02, 0x1D, 0x13, 0xF0, 0x40, 0x50, 0x48, 0x44,
    0x00, 0x02, 0x00, 0x40, 0x08, 0x02, 0x00, 0x41, 0xFF, 0xC1, 0x00, 0x20,
    0x08, 0x01, 0x00, 0x20, 0x00, 0x1C, 0xE3, 0x18, 0x63, 0x08, 0x00, 0xFF,
    0xE0, 0x7F, 0x00, 0x00, 0x08, 0x00, 0x80, 0x04, 0x00, 0x40, 0x04, 0x00,
    0x60, 0x02, 0x00, 0x20, 0x03, 0x00, 0x10, 0x01, 0x00, 0x18, 0x00, 0x80,
    0x08, 0x00, 0x80, 0x04, 0x00, 0x40, 0x04, 0x00, 0x00, 0x07, 0x06, 0x23,
    0x04, 0x81, 0x40, 0x50, 0x14, 0x06, 0x02, 0x80, 0xA0, 0x28, 0x0A, 0x04,
    0x83, 0x11, 0x83, 0x80, 0x03, 0x03, 0x83, 0x83, 0x43, 0x20, 0x10, 0x08,
    0x08, 0x04, 0x02, 0x01, 0x01, 0x00, 0x80, 0x43, 0xFE, 0x01, 0xC0, 0x62,
    0x0C, 0x10, 0x81, 0x00, 0x10, 0x02, 0x00, 0x60, 0x0C, 0x01, 0x00, 0x20,
    0x0C, 0x01, 0x80, 0x20, 0x04, 0x04, 0xFF, 0xC0, 0x07, 0xC3, 0x0C, 0x00,
    0x80, 0x10, 0x06, 0x01, 0x81, 0xC0, 0x0C, 0x00, 0x40, 0x08, 0x01, 0x00,
    0x20, 0x09, 0x86, 0x0F, 0x00, 0x00, 0xC0, 0x50, 0x24, 0x12, 0x04, 0x82,
    0x21, 0x08, 0x82, 0x21, 0x10, 0x4F, 0xF8, 0x04, 0x01, 0x00, 0x80, 0xF8,
    0x0F, 0xE2, 0x00, 0x40, 0x08, 0x01, 0x00, 0x4E, 0x0E, 0x20, 0x02, 0x00,
    0x40, 0x08, 0x01, 0x00, 0x40, 0x19, 0x06, 0x1F, 0x00, 0x01, 0xE0, 0xC0,
    0x60, 0x18, 0x02, 0x00, 0x80, 0x13, 0xC5, 0x88, 0xE0, 0x98, 0x12, 0x02,
    0x40, 0x48, 0x10, 0x84, 0x0F, 0x00, 0xFF, 0xA0, 0x20, 0x08, 0x04, 0x01,
    0x00, 0x80, 0x20, 0x10, 0x04, 0x02, 0x00, 0x80, 0x40, 0x10, 0x08, 0x02,
    0x00, 0x07, 0x81, 0x08, 0x40, 0x90, 0x12, 0x02, 0x40, 0x84, 0x20, 0x78,
    0x30, 0x88, 0x0A, 0x01, 0x40, 0x28, 0x08, 0x82, 0x0F, 0x80, 0x07, 0x81,
    0x08, 0x40, 0x90, 0x12, 0x02, 0x40, 0xC8, 0x39, 0x8D, 0x1E, 0x40, 0x08,
    0x02, 0x00, 0xC0, 0x30, 0x18, 0x3E, 0x00, 0x19, 0xCC, 0x00, 0x00, 0x0C,
    0xE6, 0x00, 0x06, 0x1C, 0x30, 0x00, 0x00, 0x00, 0x1C, 0x30, 0xE1, 0x86,
    0x08, 0x00, 0x00, 0x30, 0x0C, 0x03, 0x00, 0xC0, 0x30, 0x06, 0x00, 0x30,
    0x00, 0xC0, 0x06, 0x00, 0x18, 0x00, 0xC0, 0x7F, 0xF8, 0x00, 0x00, 0x01,
    0xFF, 0xE0, 0x18, 0x00, 0xC0, 0x03, 0x00, 0x18, 0x00, 0x60, 0x03, 0x00,
    0xC0, 0x30, 0x0C, 0x03, 0x00, 0xC0, 0x00, 0x3E, 0xC3, 0x81, 0x01, 0x03,
    0x06, 0x18, 0x20, 0x20, 0x00, 0x00, 0x00, 0xE0, 0xE0, 0x07, 0x82, 0x31,
    0x04, 0x81, 0x20, 0x48, 0x74, 0x65, 0x21, 0x48, 0x92, 0x28, 0x7A, 0x00,
    0x80, 0x20, 0x04, 0x00, 0xF8, 0x07, 0xE0, 0x02, 0x80, 0x0A, 0x00, 0x48,
    0x01, 0x20, 0x08, 0x40, 0x41, 0x01, 0x04, 0x0F, 0xF0, 0x20, 0x41, 0x01,
    0x04, 0x02, 0x20, 0x0B, 0xE1, 0xF0, 0x1F, 0xF0, 0x40, 0xC2, 0x02, 0x10,
    0x10, 0x81, 0x84, 0x18, 0x7F, 0x82, 0x02, 0x10, 0x08, 0x80, 0x44, 0x02,
    0x60, 0x22, 0x03, 0x7F, 0xE0, 0x07, 0x91, 0x87, 0x20, 0x34, 0x02, 0x40,
    0x08, 0x00, 0x80, 0x08, 0x00, 0x80, 0x08, 0x00, 0x80, 0x04, 0x04, 0x61,
    0x81, 0xE0, 0x1F, 0xE0, 0x41, 0x82, 0x06, 0x10, 0x11, 0x00, 0x88, 0x04,
    0x40, 0x22, 0x01, 0x10, 0x11, 0x00, 0x88, 0x08, 0x40, 0xC2, 0x0C, 0x7F,
    0x80, 0x1F, 0xFC, 0x20, 0x10, 0x80, 0x82, 0x00, 0x08, 0x00, 0x22, 0x01,
    0xF8, 0x04, 0x20, 0x10, 0x00, 0x40, 0x01, 0x01, 0x0C, 0x04, 0x20, 0x13,
    0xFF, 0xC0, 0x1F, 0xFC, 0x20, 0x10, 0x80, 0x42, 0x01, 0x08, 0x00, 0x22,
    0x01, 0xF8, 0x04, 0x20, 0x10, 0x00, 0x40, 0x01, 0x00, 0x0C, 0x00, 0x20,
    0x03, 0xF8, 0x00, 0x07, 0xD0, 0x83, 0x30, 0x12, 0x00, 0x40, 0x04, 0x00,
    0x80, 0x08, 0x00, 0x83, 0xE8, 0x04, 0x80, 0x4C, 0x04, 0x60, 0x41, 0xF8,
    0x0F, 0x3C, 0x08, 0x10, 0x20, 0x20, 0x40, 0x40, 0x81, 0x01, 0x02, 0x03,
    0xFC, 0x08, 0x08, 0x10, 0x10, 0x20, 0x40, 0x40, 0x80, 0x81, 0x02, 0x02,
    0x1F, 0x1E, 0x00, 0x3F, 0xE0, 0x40, 0x08, 0x01, 0x00, 0x20, 0x08, 0x01,
    0x00, 0x20, 0x04, 0x00, 0x80, 0x20, 0x04, 0x00, 0x81, 0xFF, 0x00, 0x03,
    0xFE, 0x00, 0x20, 0x00, 0x80, 0x01, 0x00, 0x02, 0x00, 0x04, 0x00, 0x08,
    0x00, 0x20, 0x40, 0x40, 0x80, 0x81, 0x01, 0x02, 0x04, 0x06, 0x10, 0x07,
    0xC0, 0x00, 0x1F, 0x1E, 0x10, 0x10, 0x20, 0xC0, 0x43, 0x00, 0x88, 0x01,
    0x20, 0x07, 0xC0, 0x0C, 0x40, 0x10, 0x40, 0x20, 0x80, 0x41, 0x01, 0x81,
    0x02, 0x02, 0x1F, 0x87, 0x00, 0x3F, 0x80, 0x40, 0x04, 0x00, 0x40, 0x08,
    0x00, 0x80, 0x08, 0x00, 0x80, 0x08, 0x01, 0x01, 0x10, 0x11, 0x02, 0x10,
    0x2F, 0xFE, 0x1C, 0x03, 0x85, 0x03, 0x02, 0x82, 0x81, 0x41, 0x40, 0xA1,
    0x20, 0x89, 0x30, 0x44, 0x90, 0x22, 0x88, 0x11, 0x44, 0x08, 0x42, 0x08,
    0x03, 0x04, 0x01, 0x02, 0x00, 0x87, 0xC3, 0xE0, 0x3C, 0x3E, 0x18, 0x08,
    0x38, 0x20, 0x50, 0x41, 0x20, 0x82, 0x61, 0x04, 0x42, 0x08, 0x88, 0x10,
    0x90, 0x41, 0x20, 0x83, 0x41, 0x02, 0x82, 0x06, 0x1F, 0x04, 0x00, 0x03,
    0xC0, 0x61, 0x84, 0x04, 0x40, 0x14, 0x00, 0xA0, 0x06, 0x00, 0x30, 0x01,
    0x80, 0x14, 0x00, 0xA0, 0x08, 0x80, 0x86, 0x18, 0x0F, 0x00, 0x1F, 0xE0,
    0x40, 0x82, 0x02, 0x10, 0x10, 0x80, 0x84, 0x08, 0x40, 0x83, 0xF8, 0x10,
    0x00, 0x80, 0x04, 0x00, 0x60, 0x02, 0x00, 0x7F, 0x00, 0x03, 0xC0, 0x61,
    0x84, 0x04, 0x40, 0x14, 0x00, 0xA0, 0x06, 0x00, 0x30, 0x01, 0x80, 0x14,
    0x00, 0xA0, 0x08, 0x80, 0x86, 0x18, 0x1F, 0x00, 0x40, 0x0F, 0xC4, 0x41,
    0xC0, 0x1F, 0xE0, 0x40, 0x82, 0x02, 0x10, 0x10, 0x80, 0x84, 0x08, 0x60,
    0x83, 0xF8, 0x10, 0xC0, 0x82, 0x04, 0x08, 0x40, 0x42, 0x03, 0x7E, 0x0C,
    0x07, 0xA3, 0x0C, 0x40, 0x90, 0x12, 0x00, 0x40, 0x06, 0x00, 0x3C, 0x00,
    0x40, 0x0A, 0x01, 0x40, 0x4C, 0x11, 0x7C, 0x00, 0xFF, 0xE8, 0x42, 0x84,
    0x20, 0x40, 0x04, 0x00, 0x80, 0x08, 0x00, 0x80, 0x08, 0x00, 0x80, 0x10,
    0x01, 0x00, 0x10, 0x0F, 0xE0, 0xF8, 0xF9, 0x00, 0x88, 0x08, 0x80, 0x44,
    0x02, 0x20, 0x11, 0x01, 0x08, 0x08, 0x80, 0x44, 0x02, 0x20, 0x31, 0x01,
    0x04, 0x30, 0x1E, 0x00, 0xF8, 0x7D, 0x00, 0x42, 0x01, 0x08, 0x08, 0x20,
    0x40, 0x81, 0x02, 0x08, 0x08, 0x20, 0x11, 0x00, 0x48, 0x01, 0x20, 0x05,
    0x00, 0x14, 0x00, 0x60, 0x00, 0xF8, 0x7D, 0x00, 0x44, 0x01, 0x11, 0x84,
    0x46, 0x21, 0x18, 0x84, 0xA2, 0x12, 0x90, 0x91, 0x42, 0x45, 0x0A, 0x14,
    0x28, 0x60, 0xC1, 0x83, 0x06, 0x00, 0x1E, 0x1E, 0x10, 0x10, 0x10, 0x40,
    0x21, 0x00, 0x24, 0x00, 0x78, 0x00, 0x60, 0x01, 0xC0, 0x06, 0x80, 0x09,
    0x80, 0x21, 0x00, 0x81, 0x02, 0x02, 0x1E, 0x1F, 0x00, 0xF0, 0xF4, 0x04,
    0x20, 0x82, 0x18, 0x11, 0x01, 0x20, 0x1C, 0x00, 0x80, 0x08, 0x00, 0x80,
    0x10, 0x01, 0x00, 0x10, 0x0F, 0xE0, 0x0F, 0xF1, 0x01, 0x10, 0x21, 0x04,
    0x00, 0x80, 0x10, 0x02, 0x00, 0x40, 0x0C, 0x01, 0x82, 0x10, 0x22, 0x04,
    0x40, 0x47, 0xFC, 0x0E, 0x20, 0x40, 0x81, 0x02, 0x08, 0x10, 0x20, 0x40,
    0x82, 0x04, 0x08, 0x10, 0x20, 0x81, 0xE0, 0x84, 0x20, 0x84, 0x20, 0x84,
    0x21, 0x04, 0x21, 0x08, 0x21, 0x08, 0x40, 0x1E, 0x04, 0x08, 0x20, 0x40,
    0x81, 0x02, 0x04, 0x10, 0x20, 0x40, 0x81, 0x02, 0x08, 0x11, 0xE0, 0x04,
    0x06, 0x04, 0x84, 0x44, 0x14, 0x0C, 0xFF, 0xFE, 0x99, 0x90, 0x1F, 0xC0,
    0x06, 0x00, 0x20, 0x02, 0x1F, 0xE6, 0x04, 0xC0, 0x48, 0x04, 0x81, 0xC7,
    0xEF, 0x18, 0x00, 0x40, 0x02, 0x00, 0x10, 0x00, 0x80, 0x09, 0xF0, 0x50,
    0xC3, 0x03, 0x10, 0x08, 0x80, 0x48, 0x02, 0x40, 0x23, 0x03, 0x1C, 0x33,
    0xBE, 0x00, 0x0F, 0xD3, 0x07, 0x60, 0x24, 0x02, 0x80, 0x08, 0x00, 0x80,
    0x08, 0x06, 0x41, 0xC3, 0xF0, 0x00, 0x38, 0x00, 0x40, 0x02, 0x00, 0x20,
    0x01, 0x07, 0xC8, 0x43, 0x44, 0x0E, 0x40, 0x24, 0x01, 0x20, 0x09, 0x00,
    0xC8, 0x0E, 0x20, 0xE0, 0xF9, 0xC0, 0x0F, 0x86, 0x09, 0x00, 0xA0, 0x1F,
    0xFF, 0x00, 0x20, 0x06, 0x00, 0x60, 0xC7, 0xE0, 0x01, 0xF8, 0x10, 0x01,
    0x00, 0x08, 0x00, 0x40, 0x1F, 0xF0, 0x20, 0x01, 0x00, 0x08, 0x00, 0x40,
    0x04, 0x00, 0x20, 0x01, 0x00, 0x08, 0x03, 0xFE, 0x00, 0x0F, 0x31, 0x86,
    0x10, 0x10, 0x80, 0x88, 0x04, 0x40, 0x22, 0x02, 0x10, 0x10, 0x43, 0x81,
    0xE4, 0x00, 0x40, 0x02, 0x00, 0x20, 0x3E, 0x00, 0x1C, 0x00, 0x20, 0x03,
    0x00, 0x10, 0x00, 0x80, 0x05, 0xF0, 0x30, 0xC3, 0x02, 0x10, 0x10, 0x80,
    0x84, 0x0C, 0x20, 0x63, 0x02, 0x10, 0x13, 0xE3, 0xE0, 0x01, 0x80, 0x40,
    0x10, 0x00, 0x00, 0x07, 0xC0, 0x20, 0x08, 0x02, 0x00, 0x80, 0x20, 0x10,
    0x04, 0x01, 0x0F, 0xFC, 0x00, 0x40, 0x10, 0x0C, 0x00, 0x00, 0x07, 0xF0,
    0x04, 0x01, 0x00, 0x40, 0x20, 0x08, 0x02, 0x00, 0x80, 0x20, 0x10, 0x04,
    0x01, 0x00, 0x8F, 0xC0, 0x18, 0x00, 0x80, 0x08, 0x00, 0x80, 0x08, 0x01,
    0x1F, 0x10, 0x81, 0x30, 0x14, 0x01, 0xC0, 0x26, 0x02, 0x20, 0x21, 0x02,
    0x08, 0xE1, 0xE0, 0x0F, 0x80, 0x40, 0x10, 0x04, 0x01, 0x00, 0x40, 0x20,
    0x08, 0x02, 0x00, 0x80, 0x20, 0x10, 0x04, 0x01, 0x0F, 0xFC, 0x3B, 0xB8,
    0x33, 0x91, 0x08, 0x44, 0x21, 0x10, 0x84, 0x42, 0x12, 0x10, 0x48, 0x42,
    0x21, 0x0B, 0xC6, 0x30, 0x19, 0xE0, 0xE3, 0x08, 0x11, 0x01, 0x10, 0x11,
    0x02, 0x10, 0x21, 0x02, 0x20, 0x2F, 0x87, 0x0F, 0x86, 0x19, 0x80, 0xA0,
    0x18, 0x03, 0x00, 0x60, 0x14, 0x06, 0x61, 0x87, 0xC0, 0x19, 0xF0, 0x28,
    0x20, 0xC0, 0x42, 0x01, 0x10, 0x04, 0x40, 0x11, 0x00, 0x86, 0x06, 0x14,
    0x30, 0xCF, 0x02, 0x00, 0x08, 0x00, 0x20, 0x03, 0xF0, 0x00, 0x0F, 0x39,
    0x85, 0x18, 0x18, 0x80, 0x88, 0x04, 0x40, 0x22, 0x01, 0x18, 0x18, 0x63,
    0x81, 0xE4, 0x00, 0x20, 0x01, 0x00, 0x10, 0x07, 0xE0, 0x1C, 0x78, 0x2C,
    0x01, 0x80, 0x18, 0x00, 0x80, 0x04, 0x00, 0x20, 0x02, 0x00, 0x10, 0x07,
    0xFC, 0x00, 0x0F, 0x44, 0x32, 0x04, 0x80, 0x1E, 0x00, 0x60, 0x0A, 0x02,
    0xC1, 0x2F, 0x80, 0x10, 0x08, 0x04, 0x02, 0x0F, 0xF9, 0x00, 0x80, 0x40,
    0x20, 0x20, 0x10, 0x08, 0x04, 0x19, 0xF0, 0xE0, 0xF2, 0x02, 0x40, 0x24,
    0x02, 0x40, 0x24, 0x06, 0x40, 0x44, 0x04, 0x41, 0xC3, 0xE6, 0xF8, 0xFA,
    0x01, 0x08, 0x10, 0x41, 0x02, 0x08, 0x10, 0x80, 0x48, 0x02, 0x40, 0x14,
    0x00, 0xC0, 0x00, 0xE0, 0x7A, 0x01, 0x10, 0x08, 0x8C, 0x84, 0xA4, 0x25,
    0x21, 0x4A, 0x0A, 0x50, 0x63, 0x02, 0x18, 0x00, 0x1E, 0x3C, 0x20, 0x40,
    0x46, 0x00, 0xB0, 0x03, 0x00, 0x0E, 0x00, 0xC8, 0x06, 0x10, 0x20, 0x23,
    0xE3, 0xC0, 0x3C, 0x3C, 0x40, 0x20, 0x81, 0x02, 0x08, 0x08, 0x20, 0x31,
    0x00, 0x48, 0x01, 0x40, 0x05, 0x00, 0x08, 0x00, 0x40, 0x02, 0x00, 0x08,
    0x03, 0xF0, 0x00, 0x3F, 0xC4, 0x18, 0x06, 0x01, 0x80, 0x60, 0x10, 0x04,
    0x01, 0x00, 0x40, 0x9F, 0xF0, 0x06, 0x10, 0x20, 0x41, 0x02, 0x04, 0x08,
    0x21, 0x80, 0x81, 0x02, 0x08, 0x10, 0x20, 0x40, 0xC0, 0x01, 0x11, 0x12,
    0x22, 0x24, 0x44, 0x44, 0x88, 0x80, 0x0C, 0x08, 0x10, 0x20, 0x40, 0x82,
    0x04, 0x08, 0x0C, 0x20, 0x81, 0x02, 0x04, 0x08, 0x21, 0x80, 0x38, 0x28,
    0x88, 0x0E, 0x00};

        static readonly GFXglyph[] FreeMonoOblique12pt7bGlyphs = {
    new GFXglyph(0, 0, 0, 14, 0, 1),        // 0x20 ' '
    new GFXglyph(0, 4, 15, 14, 6, -14),     // 0x21 '!'
    new GFXglyph(8, 8, 7, 14, 5, -14),      // 0x22 '"'
    new GFXglyph(15, 11, 16, 14, 3, -14),   // 0x23 '#'
    new GFXglyph(37, 10, 18, 14, 4, -15),   // 0x24 '$'
    new GFXglyph(60, 11, 15, 14, 3, -14),   // 0x25 '%'
    new GFXglyph(81, 9, 12, 14, 3, -11),    // 0x26 '&'
    new GFXglyph(95, 3, 7, 14, 8, -14),     // 0x27 '''
    new GFXglyph(98, 5, 18, 14, 8, -14),    // 0x28 '('
    new GFXglyph(110, 5, 18, 14, 4, -14),   // 0x29 ')'
    new GFXglyph(122, 9, 9, 14, 5, -14),    // 0x2A '*'
    new GFXglyph(133, 11, 11, 14, 3, -11),  // 0x2B '+'
    new GFXglyph(149, 6, 7, 14, 3, -3),     // 0x2C ','
    new GFXglyph(155, 11, 1, 14, 3, -6),    // 0x2D '-'
    new GFXglyph(157, 3, 3, 14, 6, -2),     // 0x2E '.'
    new GFXglyph(159, 13, 18, 14, 2, -15),  // 0x2F '/'
    new GFXglyph(189, 10, 15, 14, 4, -14),  // 0x30 '0'
    new GFXglyph(208, 9, 15, 14, 3, -14),   // 0x31 '1'
    new GFXglyph(225, 12, 15, 14, 2, -14),  // 0x32 '2'
    new GFXglyph(248, 11, 15, 14, 3, -14),  // 0x33 '3'
    new GFXglyph(269, 10, 15, 14, 3, -14),  // 0x34 '4'
    new GFXglyph(288, 11, 15, 14, 3, -14),  // 0x35 '5'
    new GFXglyph(309, 11, 15, 14, 4, -14),  // 0x36 '6'
    new GFXglyph(330, 10, 15, 14, 5, -14),  // 0x37 '7'
    new GFXglyph(349, 11, 15, 14, 3, -14),  // 0x38 '8'
    new GFXglyph(370, 11, 15, 14, 3, -14),  // 0x39 '9'
    new GFXglyph(391, 5, 10, 14, 5, -9),    // 0x3A ':'
    new GFXglyph(398, 7, 13, 14, 3, -9),    // 0x3B ';'
    new GFXglyph(410, 12, 11, 14, 3, -11),  // 0x3C '<'
    new GFXglyph(427, 13, 4, 14, 2, -8),    // 0x3D '='
    new GFXglyph(434, 12, 11, 14, 2, -11),  // 0x3E '>'
    new GFXglyph(451, 8, 14, 14, 6, -13),   // 0x3F '?'
    new GFXglyph(465, 10, 16, 14, 3, -14),  // 0x40 '@'
    new GFXglyph(485, 14, 14, 14, 0, -13),  // 0x41 'A'
    new GFXglyph(510, 13, 14, 14, 1, -13),  // 0x42 'B'
    new GFXglyph(533, 12, 14, 14, 3, -13),  // 0x43 'C'
    new GFXglyph(554, 13, 14, 14, 1, -13),  // 0x44 'D'
    new GFXglyph(577, 14, 14, 14, 1, -13),  // 0x45 'E'
    new GFXglyph(602, 14, 14, 14, 1, -13),  // 0x46 'F'
    new GFXglyph(627, 12, 14, 14, 3, -13),  // 0x47 'G'
    new GFXglyph(648, 15, 14, 14, 1, -13),  // 0x48 'H'
    new GFXglyph(675, 11, 14, 14, 3, -13),  // 0x49 'I'
    new GFXglyph(695, 15, 14, 14, 2, -13),  // 0x4A 'J'
    new GFXglyph(722, 15, 14, 14, 1, -13),  // 0x4B 'K'
    new GFXglyph(749, 12, 14, 14, 2, -13),  // 0x4C 'L'
    new GFXglyph(770, 17, 14, 14, 0, -13),  // 0x4D 'M'
    new GFXglyph(800, 15, 14, 14, 1, -13),  // 0x4E 'N'
    new GFXglyph(827, 13, 14, 14, 2, -13),  // 0x4F 'O'
    new GFXglyph(850, 13, 14, 14, 1, -13),  // 0x50 'P'
    new GFXglyph(873, 13, 17, 14, 2, -13),  // 0x51 'Q'
    new GFXglyph(901, 13, 14, 14, 1, -13),  // 0x52 'R'
    new GFXglyph(924, 11, 14, 14, 3, -13),  // 0x53 'S'
    new GFXglyph(944, 12, 14, 14, 4, -13),  // 0x54 'T'
    new GFXglyph(965, 13, 14, 14, 3, -13),  // 0x55 'U'
    new GFXglyph(988, 14, 14, 14, 3, -13),  // 0x56 'V'
    new GFXglyph(1013, 14, 14, 14, 3, -13), // 0x57 'W'
    new GFXglyph(1038, 15, 14, 14, 1, -13), // 0x58 'X'
    new GFXglyph(1065, 12, 14, 14, 4, -13), // 0x59 'Y'
    new GFXglyph(1086, 12, 14, 14, 2, -13), // 0x5A 'Z'
    new GFXglyph(1107, 7, 18, 14, 6, -14),  // 0x5B '['
    new GFXglyph(1123, 5, 18, 14, 6, -15),  // 0x5C '\'
    new GFXglyph(1135, 7, 18, 14, 3, -14),  // 0x5D ']'
    new GFXglyph(1151, 9, 6, 14, 5, -14),   // 0x5E '^'
    new GFXglyph(1158, 15, 1, 14, -1, 3),   // 0x5F '_'
    new GFXglyph(1160, 3, 4, 14, 6, -15),   // 0x60 '`'
    new GFXglyph(1162, 12, 10, 14, 2, -9),  // 0x61 'a'
    new GFXglyph(1177, 13, 15, 14, 1, -14), // 0x62 'b'
    new GFXglyph(1202, 12, 10, 14, 3, -9),  // 0x63 'c'
    new GFXglyph(1217, 13, 15, 14, 2, -14), // 0x64 'd'
    new GFXglyph(1242, 11, 10, 14, 3, -9),  // 0x65 'e'
    new GFXglyph(1256, 13, 15, 14, 3, -14), // 0x66 'f'
    new GFXglyph(1281, 13, 14, 14, 3, -9),  // 0x67 'g'
    new GFXglyph(1304, 13, 15, 14, 1, -14), // 0x68 'h'
    new GFXglyph(1329, 10, 15, 14, 2, -14), // 0x69 'i'
    new GFXglyph(1348, 10, 19, 14, 2, -14), // 0x6A 'j'
    new GFXglyph(1372, 12, 15, 14, 2, -14), // 0x6B 'k'
    new GFXglyph(1395, 10, 15, 14, 2, -14), // 0x6C 'l'
    new GFXglyph(1414, 14, 10, 14, 0, -9),  // 0x6D 'm'
    new GFXglyph(1432, 12, 10, 14, 1, -9),  // 0x6E 'n'
    new GFXglyph(1447, 11, 10, 14, 3, -9),  // 0x6F 'o'
    new GFXglyph(1461, 14, 14, 14, 0, -9),  // 0x70 'p'
    new GFXglyph(1486, 13, 14, 14, 3, -9),  // 0x71 'q'
    new GFXglyph(1509, 13, 10, 14, 2, -9),  // 0x72 'r'
    new GFXglyph(1526, 10, 10, 14, 3, -9),  // 0x73 's'
    new GFXglyph(1539, 9, 14, 14, 3, -13),  // 0x74 't'
    new GFXglyph(1555, 12, 10, 14, 2, -9),  // 0x75 'u'
    new GFXglyph(1570, 13, 10, 14, 3, -9),  // 0x76 'v'
    new GFXglyph(1587, 13, 10, 14, 3, -9),  // 0x77 'w'
    new GFXglyph(1604, 14, 10, 14, 1, -9),  // 0x78 'x'
    new GFXglyph(1622, 14, 14, 14, 1, -9),  // 0x79 'y'
    new GFXglyph(1647, 11, 10, 14, 3, -9),  // 0x7A 'z'
    new GFXglyph(1661, 7, 18, 14, 5, -14),  // 0x7B '{'
    new GFXglyph(1677, 4, 17, 14, 6, -13),  // 0x7C '|'
    new GFXglyph(1686, 7, 18, 14, 4, -14),  // 0x7D '}'
    new GFXglyph(1702, 11, 3, 14, 3, -7)};  // 0x7E '~'

        public GFXFont_FreeMonoOblique12pt7b()
        {
            gfxfont = new GFXfont(FreeMonoOblique12pt7bBitmaps, FreeMonoOblique12pt7bGlyphs, 0x20, 0x7E, 24);
        }
        // Approx. 2379 bytes
    }
}