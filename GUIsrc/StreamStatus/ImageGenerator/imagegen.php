<?php
/* Copyright (C) 2015 Dylan J. Morrison <insidious@gmail.com>
   This work is free. You can redistribute it and/or modify
   it under the terms of the Do What The Fuck You Want To 
   Public License, Version 2, as published by Sam Hocevar.
   See http://www.wtfpl.net/ for more details.

   Stream Banner for my FF7 Stream: Image/URL generator.
  
   This code is probably useful to others only as an
   example, and a dirty one at that. Nonetheless, this
   code is freely available for your use.
*/


// Set font filename
$font = 'font/constan.ttf';

// Function to log a line to a file.
function logIt($logstring) {
    $logfile = fopen("imagegen.log", "a");
    fwrite($logfile, $logstring . "\n");
    fclose($logfile);
}


// Function to print an error to an image, link the image, and then die. Contains a small subset of this program within it.
// Code fast, compile young, and leave a beautifulCorpse()
function beautifulCorpse($string) {
    $font = 'font/constan.ttf';
    $errimg = imagecreatetruecolor(1280,120);
    imagesavealpha($errimg, TRUE);
    $bgcolor = imagecolorallocatealpha($errimg, 0, 0, 0, 63);
    $ercolor = imagecolorallocatealpha($errimg, 255, 0, 0, 31);
    imagefill($errimg, 0, 0, $bgcolor);
    imagettftext($errimg, 16, 0, 160, 60, $ercolor, $font, $string);
    imagepng($errimg, "error.png", 0, NULL);
    $myurl=$_SERVER['REQUEST_URI'];
    $temparray = explode("/", $myurl);
    end($temparray);
    $tempkey = key($temparray);
    unset($temparray[$tempkey]);
    reset($temparray);
    unset($tempkey);
    $newurl = implode("/", $temparray) . "/error.png";
    unset($temparray);
    die($newurl);
}

// Load our XML status file.
$status = simplexml_load_file("status.xml");

// Check XML for completeness and parse to variables.
$counter = 0;
if (isset($status->disc)) {
    $counter = $counter + 1;
    $disc = $status->disc;
} else {
    logIt("ERR: Could not find disc number.");
}
if (isset($status->location)) {
    $counter = $counter + 1;
    $location = $status->location;
} else {
    logIt("ERR: Could not find location.");
}
if (isset($status->streamtime)) {
    $counter = $counter + 1;
    $streamtime = $status->streamtime;
} else {
    logIt("ERR: Could not get stream start time.");
}
if (isset($status->gametime)) {
    $counter = $counter + 1;
    $gametime = $status->gametime;
} else {
    logIt("ERR: Could not find total game time.");
}
if (isset($status->lastevent)) {
    $counter = $counter + 1;
    $lastevent = $status->lastevent;
} else {
    logIt("ERR: Could not find last event.");
}
if (isset($status->mods)) {
    $counter = $counter + 1;
    $mods = $status->mods->mod;
} else {
    logIt("ERR: Could not find list of mods in use.");
}
if (isset($status->party)) {
    if (isset($status->party->member)) {
        $members = $status->party->member;
        foreach($members as $memnumber => $member)
        {
            if (isset($member->name)) {
                $counter = $counter + 1;
            } else {
                logIt("ERR: Could not find a party member's name! (Member " . $memnumber . ")");
            }
            if (isset($member->level)) {
                $counter = $counter + 1;
            } else {
                logIt("ERR: Could find a party member's level! (Member " . $memnumber . ")");
            }
        }
    } else {
        logIt("ERR: Could not find party members array.");
    }
} else {
    logIt("ERR: Could not find party element.");
}
if ($counter < 8) {
    logIt("ERR: Dying due to previous errors. DEBUG: Counter was " . $counter);
    beautifulCorpse("ERROR: Could not generate image due to incomplete XML file. See log.");
}


/* The following bits create our image as a 1280x120 png,
   set our colors, and fill the PNG with a semi-transparent
  black background.
*/

// Create our image, and be sure to save alpha
$img = imagecreatetruecolor(1280,120);
imagesavealpha($img, TRUE);

/* Define our colors and fill that black!
   Background: Half-transparent black: #0000003F
   Dynamic text: Quarter-transparent orange: #FF99001F
   Label (for above): Quarter-transparent tangerine: #FFCC001F
   Static text: Quarter-transparent laser lemon: #FFFF661F
 */
$bgcolor = imagecolorallocatealpha($img, 0, 0, 0, 63);
$dtcolor = imagecolorallocatealpha($img, 255, 153, 0, 31);
$lbcolor = imagecolorallocatealpha($img, 255, 204, 0, 31);
$stcolor = imagecolorallocatealpha($img, 255, 255, 102, 31);
imagefill($img, 0, 0, $bgcolor);

/* Add our text
 
   Example: 
 
   Disc: X/3 Party: Cloud (##), Tifa (##), Barrett (##) 
   Location: Blah blah doodlyfuck is this enough space 
   When We Last Left Our Heroes: They fucked a sheep.
   Time: Local (HH:MM:SS), Stream (HH:MM:SS), Total (HH:MM:SS)
  
   Coordinates were determined by mockups and trial and error.
   $font is the constan.ttftina font I'm using.
 */

// Line 1
imagettftext($img, 16, 0, 160, 24, $lbcolor, $font, "Disc");
imagettftext($img, 16, 0, 205, 24, $dtcolor, $font, $disc . "/3");
imagettftext($img, 16, 0, 235, 24, $lbcolor, $font, "Party:");
$partystring = "";
foreach ($members as $member) {
    $partystring = $partystring . $member->name . " (" . $member->level . ") ";
}
imagettftext($img, 16, 0, 293, 24, $dtcolor, $font, $partystring);

//Line 2
imagettftext($img, 16, 0, 160, 46, $lbcolor, $font, "Location:");
imagettftext($img, 16, 0, 248, 46, $dtcolor, $font, $location);

//Line 3
imagettftext($img, 16, 0, 160, 68, $lbcolor, $font, "When We Last Left Our Heroes:");
imagettftext($img, 16, 0, 455, 68, $dtcolor, $font, $lastevent);

//Get our timestamps together for Line 4
$timestring = "Local (";
$timestring = $timestring . date("H:i:s");
$timestring = $timestring . "), Stream (";
$timestring = $timestring . $streamtime;
$timestring = $timestring . "), Total Playtime (";
$timestring = $timestring . $gametime . ")";

//Line 4
imagettftext($img, 16, 0, 160, 90, $lbcolor, $font, "Time:");
imagettftext($img, 16, 0, 220, 90, $dtcolor, $font, $timestring);

var_dump($mods);
//And finally, Line 5
$modstring = "";
foreach ($mods as $mod) {
    $modstring = $modstring . $mod . ", ";
}
$modstring = trim($modstring, " ,");
imagettftext($img, 16, 0, 160, 112, $lbcolor, $font, "Mods in use:");
imagettftext($img, 16, 0, 280, 112, $dtcolor, $font, $modstring);



// Delete any PNGs still in the directory, and output our image
array_map('unlink', glob("*.png"));
$mytime = time();
$filename = "img" . $mytime . ".png";
imagepng($img, $filename, 0, NULL);

/* Get the current URL, remove the reference to the
   script, and add a refernce to the png, to get the
   correct URL for the png, then echo it for the AJAX
   calling script. This is dirty, hacky code and will
   ONLY work on Apache servers.
*/
$myurl=$_SERVER['REQUEST_URI'];
$temparray = explode("/", $myurl);
end($temparray);
$tempkey = key($temparray);
unset($temparray[$tempkey]);
reset($temparray);
unset($tempkey);
$newurl = implode("/", $temparray) . "/" . $filename;
unset($temparray);
echo($newurl);
?>