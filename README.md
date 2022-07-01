# NeonLightning's Edits
[Screenshot](https://raw.githubusercontent.com/NeonLightning/StreamStatus/master/SS.png)

well i changed a bunch i can't really rememember what right now. the original i couldn't get working so in the process
of trying to figure out how i did some changes. and those just kept going. i hope to merge this but i doubt they will.
(mostly because i have no idea what i'm doing)
one thing to note that i didn't realize is the resolution for the overlay is mostly based on the image size
you'll need to use full path for the fonts.
should be easy to figure out how to change my modlist. and where to edit the font/put the fonts/what font is needed.

# Instructions
You will need to install apache and php in the 7 versions or lower.
and get dejavu mono font if you wanna use it or verdana if you wanna use that.
copy the streamstatus files to your htdocs in a subfolder
edit imagegen.php to make the font path to where yours is. i've found it really picky about what fonts and only verdana 
and dejavu have worked right.
run the game. then run the exe then click start.
then add a browser source pointed at http://127.0.0.1/streamstatus/
make sure the size is set to the same as the background.png in base.
you can replace background.png with whatever you want. i suggest a 320x900 image.

# StreamStatus
My stream overlay project, designed for my Final Fantasy 7 streaming. An unholy combination of VB, PHP, and JavaScript.
This project was originally developed to provide an interesting and eye catching overlay
for my twitch streams of Final Fantasy 7, and then turned into a first (and successful) delve
into hooking and memory reading so as to grab the data live. As of this writing (4/18/2015), the plan going forward
is to create a generic overlay system for twitch streams, potentially including a direct OBS plugin
instead of the use of browser support, as well as layout tables and tables of memory addresses for different games.
This is currently planned for future, and as of this writing the code here is best suited for streaming Final Fantasy 7.
This code can be freely distributed and modified. See the LICENSE file for details.
