# MeadowFontTest
Add new fonts to Meadow Graphics Library

Here we demonstrate adding new fonts to the Meadow Graphics Library

1. Consolas 
2. IBM Plex Mono
3. Sometype Mono
4. BP Typewrite

The <a href="https://github.com/WildernessLabs/Meadow.Foundation/tree/develop/Source/Meadow.Foundation.Libraries_and_Frameworks/Displays.GraphicsLibrary">Meadow.Foundation Graphics Library</a>
supports drawing fonts in a few fixed width sizes.  4x8 8x8 8x12 12x16 12x20

The smaller sizes may be appropriate for hand drawn fonts, but if we are converting higher quality desktop fonts, 12x20 is the only size that can support fonts with descenders.
These initial attempts target fixed width or Monospaced fonts.

## Consolas
<a href="https://docs.microsoft.com/en-us/typography/font-list/consolas">Consolas</a> is a Microsoft font, used in visual studio, it may not be appropriate for open source use.

so I found 3 open source fonts, which ended up with a much smaller character set

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

To use them in your meadow project, you just need to compile the font file into your application.
Then 
```
graphics.CurrentFont = new BPtypewrite12x20();
```

The Windows application to generate these font files is called <a href="https://github.com/MarkAlanJones/FontConverter">FontConverter</a>
