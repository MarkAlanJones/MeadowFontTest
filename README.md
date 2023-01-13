# Meadow Font Test
Add new fonts to Meadow MicroGraphics Library

Here we demonstrate adding new fonts to the Meadow MicroGraphics Library

1. Consolas 
2. IBM Plex Mono
3. Sometype Mono
4. BP Typewrite
5. IBM 3270
6. 52 Adafruit GFX fonts
7. Microsoft .NetMF fixed fonts
8. Petscii - character ROM dump
9. Release the Hoard! - 37 Fixed width Yaff fonts from the [Bitmap Hoard](https://github.com/robhagemans/hoard-of-bitfonts) 

The <a href="https://github.com/WildernessLabs/Meadow.Foundation/tree/main/Source/Meadow.Foundation.Libraries_and_Frameworks/Graphics.MicroGraphics">Meadow.Foundation MicroGraphics Library</a>
supports drawing fonts in a few (now 8) fixed width sizes.  

4x6| 4x8| 6x8| 8x8| 8x12| 8x16| 12x16| 12x20|
:-:|:-: |:-: |:-: |:-: |:-: |:-: |:-:  |
![OG Font4x6](ScreenShots/Font4x6.png)|![OG Font4x8](ScreenShots/Font4x8.png)|![OG Font6x8](ScreenShots/Font6x8.png)|![OG Font8x8](ScreenShots/Font8x8.png)|![OG Font8x12](ScreenShots/Font8x12.png)|![OG Font8x16](ScreenShots/Font8x16.png)|![OG Font12x16](ScreenShots/Font12x16.png)|![OG Font12x20](ScreenShots/Font12x20.png)

The smaller sizes may be appropriate for hand drawn fonts, but if we are converting higher quality desktop fonts, 12x20 is the only size that can support fonts with descenders.
These initial attempts target fixed width or Monospaced fonts.

## Consolas
<a href="https://docs.microsoft.com/en-us/typography/font-list/consolas">Consolas</a> is a Microsoft font, used in visual studio, it may not be appropriate for open source use. 

<a href="http://wiki.squeak.org/squeak/1849">Although apparently Fonts are not Copyright protected</a>

So I found 3 open source fonts, which ended up with a much smaller character set

![Consolas Font](ScreenShots/Consolas.png)

## IBM Plex Mono
<a href="https://www.1001fonts.com/ibm-plex-mono-font.html">IBM Plex Mono</a> or on <a href="https://github.com/IBM/plex">Github</a>

![IBM Plex Mono Font](ScreenShots/IBMMonoPlex.png)

## Sometype Mono
<a href="https://monospacedfont.com/">monospacedfont</a> or on <a href="https://github.com/dharmatype/Sometype-Mono">Github</a>

![Sometype Mono](ScreenShots/SometypeMono.png)

## BP Typewrite
<a href="https://www.1001fonts.com/bptypewrite-font.html">BP Typewrite</a> may be the most distinct of these fonts. It is based on an italic font stood upwrite.
Smaller set of characters.

![BP Typewrite](ScreenShots/BPTypewrite.png)

## IBM 3270

A favourite for terminal fonts or code editing. This version comes from an OpenType font converted back to bitmap 12x20.
It has many of the drawing symbols of the petscii font - at a larger size, and at less precision. This font has many unicode characters hence the double size screenshot.

![IBM327012x20](ScreenShots/IBM327012x20.png)

from <a href="https://github.com/rbanffy/3270font">github</a>

To use them in your meadow project, you just need to compile the font file into your application.
Then 
```
graphics.CurrentFont = new BPtypewrite12x20();
```

The Windows application to generate these font files is called <a href="https://github.com/MarkAlanJones/FontConverter">FontConverter</a>

# GFX Fonts

from <a href="https://github.com/adafruit/Adafruit-GFX-Library">Adafruit</a>. These are bitmap fonts, that are proportionatley spaced, and support text wrapping.
I had to convert the C++ .h files into C#. There seems to be 3 font faces converted from Berkley Unix.

1. **Free Mono**
2. **Free Sans**
3. **Free Serif**

Each font has four typefaces: **Normal**, **Bold**, **Oblique** (or *Italic*), and **Bold Oblique** (or *Bold Italic*) 
and appears in four sizes: 9pt, 12pt, 18pt, 24pt.

## Free Mono

| Normal     |      Bold     |  Oblique  | Bold Oblique   |
|:----------:|:-------------:|:---------:|:--------------:|
|![Free Mono 9pt](ScreenShots/FreeMono9pt.png)   | ![Free Mono Bold 9pt](ScreenShots/FreeMonoBold9pt.png)   |![Free Mono Oblique 9pt](ScreenShots/FreeMonoOblique9pt.png)  |![Free Mono Bold Oblique 9pt](ScreenShots/FreeMonoBoldOblique9pt.png)  |
|![Free Mono 12pt](ScreenShots/FreeMono12pt.png) | ![Free Mono Bold  12pt](ScreenShots/FreeMonoBold12pt.png) |![Free Mono Oblique 12pt](ScreenShots/FreeMonoOblique12pt.png)|![Free Mono Bold Oblique 12pt](ScreenShots/FreeMonoBoldOblique12pt.png)|
|![Free Mono 18pt](ScreenShots/FreeMono18pt.png) | ![Free Mono Bold  18pt](ScreenShots/FreeMonoBold18pt.png) |![Free Mono Oblique 18pt](ScreenShots/FreeMonoOblique18pt.png) |![Free Mono Bold Oblique 18pt](ScreenShots/FreeMonoBoldOblique18pt.png) |
|![Free Mono 24pt](ScreenShots/FreeMono24pt.png) | ![Free Mono Bold  24pt](ScreenShots/FreeMonoBold24pt.png) |![Free Mono Oblique 24pt](ScreenShots/FreeMonoOblique24pt.png)|![Free Mono Bold Oblique 24pt](ScreenShots/FreeMonoBoldOblique24pt.png)|

## Free Sans

| Normal     |      Bold     |  Oblique  | Bold Oblique   |
|:----------:|:-------------:|:---------:|:--------------:|
|![Free Sans 9pt](ScreenShots/FreeSans9pt.png)   | ![Free Sans Bold 9pt](ScreenShots/FreeSansBold9pt.png)   |![Free Sans Oblique 9pt](ScreenShots/FreeSansOblique9pt.png)  |![Free Sans Bold Oblique 9pt](ScreenShots/FreeSansBoldOblique9pt.png)  |
|![Free Sans 12pt](ScreenShots/FreeSans12pt.png) | ![Free Sans Bold  12pt](ScreenShots/FreeSansBold12pt.png) |![Free Sans Oblique 12pt](ScreenShots/FreeSansOblique12pt.png)|![Free Sans Bold Oblique 12pt](ScreenShots/FreeSansBoldOblique12pt.png)|
|![Free Sans 18pt](ScreenShots/FreeSans18pt.png) | ![Free Sans Bold  18pt](ScreenShots/FreeSansBold18pt.png) |![Free Sans Oblique 18pt](ScreenShots/FreeSansOblique18pt.png) |![Free Sans Bold Oblique 18pt](ScreenShots/FreeSansBoldOblique18pt.png) |
|![Free Sans 24pt](ScreenShots/FreeSans24pt.png) | ![Free Sans Bold  24pt](ScreenShots/FreeSansBold24pt.png) |![Free Sans Oblique 24pt](ScreenShots/FreeSansOblique24pt.png)|![Free Sans Bold Oblique 24pt](ScreenShots/FreeSansBoldOblique24pt.png)|

## Free Serif

| Normal     |      Bold     |  Italic   | Bold Italic    | 
|:----------:|:-------------:|:---------:|:--------------:|
|![Free Serif 9pt](ScreenShots/FreeSerif9pt.png)   | ![Free Serif Bold 9pt](ScreenShots/FreeSerifBold9pt.png)   |![Free Serif Italic 9pt](ScreenShots/FreeSerifItalic9pt.png)  |![Free Serif Bold Italic 9pt](ScreenShots/FreeSerifBoldItalic9pt.png)  |
|![Free Serif 12pt](ScreenShots/FreeSerif12pt.png) | ![Free Serif Bold  12pt](ScreenShots/FreeSerifBold12pt.png) |![Free Serif Italic 12pt](ScreenShots/FreeSerifItalic12pt.png)|![Free Serif Bold Italic 12pt](ScreenShots/FreeSerifBoldItalic12pt.png)|
|![Free Serif 18pt](ScreenShots/FreeSerif18pt.png) | ![Free Serif Bold  18pt](ScreenShots/FreeSerifBold18pt.png) |![Free Serif Italic 18pt](ScreenShots/FreeSerifItalic18pt.png) |![Free Serif Bold Italic 18pt](ScreenShots/FreeSerifBoldItalic18pt.png) |
|![Free Serif 24pt](ScreenShots/FreeSerif24pt.png) | ![Free Serif Bold  24pt](ScreenShots/FreeSerifBold24pt.png) |![Free Serif Italic 24pt](ScreenShots/FreeSerifItalic24pt.png)|![Free Serif Bold Italic 24pt](ScreenShots/FreeSerifBolditalic24pt.png)|

There are also 4 additional extra small fonts, in one typeface each. Other than the TomThumb font, only the lower 7bit ascii characters are available.
I have included a 4 times zoom of each of the small fonts so you can see the detail (or lack thereof).

## Org_01
![Org_01](ScreenShots/Org_01.png)
![Org_01](ScreenShots/Org_01-4x.png)

## Picopixel
![Pico Pixel](ScreenShots/Picopixel.png)
![Pico Pixel](ScreenShots/Picopixel-4x.png)

## Tiny3x3
![Tiny3x3](ScreenShots/Tiny3x3a2pt.png)
![Tiny3x3](ScreenShots/Tiny3x3a2pt-4x.png)

## Tom Thumb
![Tom Thumb](ScreenShots/TomThumb.png)
![Tom Thumb](ScreenShots/TomThumb-4x.png)



To use GFX fonts in your Meadow project, you need to include the **GFXFontBase.cs** and the **GraphicsLibraryEx.cs** as well as any of the GFX fonts you want to use.
**DrawGFXText** is used to display text. The x,y origin is for the left baseline of the character (not the upper left). The **WrapText** property can be enabled and text will be written on the next line if it doesn't fit on the current line. 
 

More GFX font info: <a href="https://learn.adafruit.com/adafruit-gfx-graphics-library/using-fonts">Here</a> and 
<a href="https://glenviewsoftware.com/projects/products/adafonteditor/adafruit-gfx-font-format/">Here</a>

There are certainly other GFX fonts avaialble, including tools to convert to the GFX format. Adafruit says they will not expand the base fonts available on Github any further.

# Microsoft .NetMF fixed fonts

I found these in the abandoned <a href="https://github.com/NETMF/netmf-interpreter/tree/dev/DeviceCode/Drivers/Display/TextFonts">.net Micro Framework</a> repository. They include a few extended characters. The way the character bitmaps are laid out is much easier to hand edit if you want to.

Converted from C++ these are compatible with the Meadow Graphics Library Fonts (just include the font file).

## 8x8 
![MSFont8x8](ScreenShots/MSFont8x8.png)

## 8x15 
![MSFont8x15](ScreenShots/MSFont8x15.png)

# Petscii 8x8

The OG personal computer circa 1977 was the Commodore PET - 6502 processor, cassette deck, green text enclosed in an industrial steel case.
This version of the ROM is from the SuperPet a weird work from home offshoot that had Pascal, Fortran and APL built in along with the MSBasic.
So along with the famous line drawing characters, we also get some APL symbols and several other rare math symbols.
The character set is mapped to unicode (rather than the original shiftable 7bit ascii). See the comments for which unicode character to use.

from <a href="http://www.6502.org/users/sjgray/computer/cbmchr/cbmchr.html">6502.org</a>

## Petscii8x8
![Petscii8x8](ScreenShots/Petscii8x8.png)

and don't forget, the Meadow Graphics Library can also display fonts at 2X or 3X
here is petscii at 2X (16x16)

![Petscii8x82X](ScreenShots/Petscii8x82X.png)

# The Bitmap Hoard 
## Part 1 - Fixed width 12px or less

[Rob Hagemans](https://github.com/robhagemans/hoard-of-bitfonts) has not only collected many historical bitmap fonts, he has also created a new storage format ([Yaff](https://github.com/robhagemans/monobit/blob/master/YAFF.md)) that is more human readable than most formats, and not too bad to parse.

These Fonts, are read by the YaffReader, which returns an IYaffFont which is an IFont that the Micrographics DrawText function can use.
This means you can include the YaYaffReader.cs in your meadow application, along with any number of these Yaff files, and load and display the font at runtime.
This consumes more memory than compiling the fonts, but being able to treat the fonts as files, instead of code is more convienient.

### Amiga

| Topaz | | | |
|:----------:|:-------------:|:---------:|:--------------:|
| ![amiga-ks30-topaz-08](ScreenShots/amiga-ks30-topaz-08.yaff.png) | ![amiga-ks30-topaz-09](ScreenShots/amiga-ks30-topaz-09.yaff.png) |  ![amiga-wb31-topaz-11](ScreenShots/amiga-wb31-topaz-11.yaff.png) |  |
| Xen | | | |
| ![amiga-magicwb-xen-08](ScreenShots/amiga-magicwb-xen-08.yaff.png) |  ![amiga-magicwb-xen-09](ScreenShots/amiga-magicwb-xen-09.yaff.png) |  ![amiga-magicwb-xen-11](ScreenShots/amiga-magicwb-xen-11.yaff.png) | |
| Nudel | | | |
| ![amiga-nudelfonts-polarsmall-6](ScreenShots/amiga-nudelfonts-polarsmall-6.yaff.png) | ![amiga-nudelfonts-eagleplayer-8](ScreenShots/amiga-nudelfonts-eagleplayer-8.yaff.png) | ![amiga-nudelfonts-pot-ibm-8](ScreenShots/amiga-nudelfonts-pot-ibm-8.yaff.png) |  ![amiga-nudelfonts-pot-noodle-8](ScreenShots/amiga-nudelfonts-pot-noodle-8.yaff.png) |
| MagicWB XCourier | | | |
| ![amiga-magicwb-xcourier-11](ScreenShots/amiga-magicwb-xcourier-11.yaff.png) | ![amiga-magicwb-xcourier-13](ScreenShots/amiga-magicwb-xcourier-13.yaff.png) |  ![amiga-magicwb-xcourier-15](ScreenShots/amiga-magicwb-xcourier-15.yaff.png) | |
| Courier |
| ![amiga-wb31-courier-11](ScreenShots/amiga-wb31-courier-11.yaff.png) | ![amiga-wb31-courier-13](ScreenShots/amiga-wb31-courier-13.yaff.png) | ![amiga-wb31-courier-15](ScreenShots/amiga-wb31-courier-15.yaff.png) |  ![amiga-wb31-courier-18](ScreenShots/amiga-wb31-courier-18.yaff.png) |

### Apple [Mac](https://github.com/robhagemans/hoard-of-bitfonts/tree/master/apple-mac)

Gacha and Monaco are two of the few fixed Mac Fonts. There are a few slightly smaller versions of both.

| Gacha 7x13 |  Monaco 7x16 |
|:----------:|:-------------:|
|![Gacha_7x13](ScreenShots/Gacha_7x13.yaff.png) | ![Monaco_7x16](ScreenShots/Monaco_7x16.yaff.png) |

### Atari 

| Classic | ST 6x6 | ST 8x8 | ST 8x16 |
|:----------:|:-------------:|:---------:|:--------------:|
|![Classic](ScreenShots/atascii.yaff.png) |![ST6x6](ScreenShots/atari-st-6x6.yaff.png) |![ST8x8](ScreenShots/atari-st-8x8.yaff.png) |![ST8x16](ScreenShots/atari-st-8x16.yaff.png) |
![CoA](ScreenShots/CultofAtari.png)

### [Gem](https://github.com/robhagemans/hoard-of-bitfonts/tree/master/gem)

There are several other sizes for these fonts in the hoard

| DrDos 8x19 | Gem 3.1 6x6 | Viewmax 8x8|
|:----------:|:-------------:|:---------:|
| ![drdos 8x19](ScreenShots/drdos-6v-sbcs-8x19.yaff.png) | ![Gem 3.1 6x6](ScreenShots/gem-3.1-6x6.yaff.png) | ![Viewmax](ScreenShots/viewmax-2-8x8.yaff.png)|

### [Hellschreiber](https://github.com/robhagemans/hoard-of-bitfonts/tree/master/hellschreiber)

| Feld-Hell Typenbildschreiber 7x14  | Hellschreiber T-Typ 72 GL 7x14  | Hell-80  7x9 | GTL Telewriter 7x8   | 
|:----------:|:-------------:|:---------:|:--------------:|
|![Feld-Hell Typenbildschreiber ](ScreenShots/feld-hell-tbs24a-7x14.yaff.png) |![Hellschreiber T-Typ 72 GL ](ScreenShots/t-typ72-gl-7x14.yaff.png) |![Hell 80](ScreenShots/hell80-7x9.yaff.png) |![GTL Telewriter ](ScreenShots/gtl-telewriter-7x8.yaff.png) |
| Abtastfernschreiber  8x14     ||||
|![Abtastfernschreiber](ScreenShots/abtastfernschreiber-8x14.yaff.png)   ||||

### DEC VT-xxx Terminals

| VT-52 | VT-100 | VT-220 |
|:----------:|:-------------:|:---------:|
|![VT-52](ScreenShots/vt52.yaff.png) | ![VT-100](ScreenShots/vt100.yaff.png) |  ![VT-220](ScreenShots/vt220.yaff.png) |
| funky g and lightning tilda | Desenders and line drawing characters  | Accented characters, backward ?  | 

### [Olivetti](https://github.com/robhagemans/hoard-of-bitfonts/tree/master/kyotronic)

There are other regional versions with slightly different characters as well

![olivetti-m10-us.yaff.png](ScreenShots/olivetti-m10-us.yaff.png)


