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
$font = 'font/verdana.ttf';

// Function to log a line to a file.
function logIt($logstring) {
    $logfile = fopen("imagegen.log", "a");
    fwrite($logfile, $logstring . "\n");
    fclose($logfile);
}

function pxtoPt($pixels) {
	return ($pixels*3)/4;
}

// Function to print an error to an image, link the image, and then die. Contains a small subset of this program within it.
// Code fast, compile young, and leave a beautifulCorpse(). Needs to be less than 24 characters!
function beautifulCorpse($string) {
    $font = 'font/micross.ttf';
    $errimg = imagecreatefrompng("base/background.png");
    imagesavealpha($errimg, TRUE);
    $ercolor = imagecolorallocatealpha($errimg, 255, 255, 255, 0);
    imagettftext($errimg, pxtoPt(18), 0, 25, 30, $ercolor, $font, $string);
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

//Function to word-wrap a string to the specified pixel length. 
// Returns an array of two strings: A shortened first string 
// and the wrapped second string. Call again on the second string 
// if it's also too long!
function doWrap($string, $length, $font, $pt) {
	$words = explode(" ", $string);
	$strbbox = imagettfbbox($pt, 0, $font, $string);
	$strlen = $strbbox[2] - $strbbox[0];
	if ($strlen <= $length) { // We're already done!
		return array(0 => $string, 1 => "");
	} else { // Wrap it!
		$secwords = array();
		while($strlen > $length) {
			$wrapword = array_pop($words);
			// Check if that word is, in itself, longer than the 
			// length.
			// If so, die! We can't deal with that yet.
			$wordbbox = imagettfbbox($pt, 0, $font, $wrapword);
			$wordlen = $wordbbox[2] - $wordbbox[0];
			if ($wordlen > $length) {
				beautifulCorpse("Word too long to wrap");
				die();
			}
			$newstr = implode(" ", $words);
			array_push($secwords, $wrapword);
			$strbbox = imagettfbbox($pt, 0, $font, $newstr);
			$strlen = $strbbox[2] - $strbbox[0];
		}
		$secwords = array_reverse($secwords);
		$secstr = implode(" ", $secwords);
		return array(0 => $newstr, 1 => $secstr);
	}
}

// Function that returns an array of wrapped strings, using the prior function.	
function fullWrap($string, $length, $font, $pt) {
	$strbbox = imagettfbbox($pt, 0, $font, $string);
	$strlen = $strbbox[2] - $strbbox[0];
	$strings = array(0 => $string);
	$lastlen = $strlen;
	while ($lastlen > $length) {
		$toWrap = array_pop($strings);
		$tempArr = doWrap($toWrap, $length, $font, $pt);
		array_push($strings, $tempArr[0], $tempArr[1]);
		$lastbbox = imagettfbbox($pt, 0, $font, $tempArr[1]);
		$lastlen = $lastbbox[2] - $lastbbox[0];
	}
	return $strings;
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


/* The following bits create our image as a 320x720 png,
   using Covarr's background image, and set our colors.
*/

// Create our image, and be sure to save alpha
$img = imagecreatefrompng("base/background.png");
imagesavealpha($img, TRUE);

/* Define our colors: This time it's a lot easier, as for
   starters we'll just be using white, with black for dropshadow.
 */
$black = imagecolorallocatealpha($img, 0, 0, 0, 0);
$white = imagecolorallocatealpha($img, 255, 255, 255, 0);

// Get the length of a space
$spacebbox = imagettfbbox(pxtoPt(18), 0, $font, " ");
$spacelen = $spacebbox[2] - $spacebbox[0];
// Get the ideal max character name length
$charbbox = imagettfbbox(pxtoPt(18), 0, $font, "Sephiroth");
$charlen = $charbbox[2] - $charbbox[0];
// Get the ideal max length of the lastevent/mod lines (number of characters calculated using trial and error :/)
$wrapbbox = imagettfbbox(pxtoPt(18), 0, $font, "AAAAAAAAAAAAAAAAAA");
$wraplen = $wrapbbox[2] - $wrapbbox[0];

/* Add our text */
$outstring = "";
// Disc
$outstring = $outstring . "Disc " . $disc . "/3\n\n";

// Party
$outstring = $outstring . "Party:\n    ";
$nummems = 0;
foreach ($members as $member) {
	$namebbox = imagettfbbox(pxtoPt(18), 0, $font, $member->name);
	$namelen = $namebbox[2] - $namebbox[0];
	if ($namelen < $charlen) {
		$namestr = $member->name;
		$diff = $charlen - $namelen;
		$spaces = $diff/$spacelen;
		if (($diff%$spacelen) > $spacelen-3) {
			$spaces = $spaces + 1;
		}
		foreach (range(1, $spaces) as $unused) {
			$namestr = $namestr . " ";
		}
	} else {
		$namestr = $member->name;
	}
    $outstring = $outstring . $namestr . " - L" . $member->level . "\n    ";
}
$outstring = $outstring . "\n";

// Same spacing regardless of number of party members

// Location
$outstring = $outstring . "Location:\n    " . $location . "\n\n";

// Last Event
$outstring = $outstring . "When we left off:\n";
$wrapevent = fullWrap($lastevent, $wraplen, $font, pxtoPt(18));
foreach ($wrapevent as $line) {
	$outstring = $outstring . "    " . $line . "\n";
}
$outstring = $outstring . "\n";

// Time
$outstring = $outstring . "Time:\n";
$ingamebbox = imagettfbbox(pxtoPt(18), 0, $font, "In-Game");
$ingamelen = $ingamebbox[2] - $ingamebbox[0];
$streambbox = imagettfbbox(pxtoPt(18), 0, $font, "Stream");
$streamlen = $streambbox[2] - $streambbox[0];
$localbbox = imagettfbbox(pxtoPt(18), 0, $font, "Local");
$locallen = $localbbox[2] - $localbbox[0];
$streamdiff = $ingamelen - $streamlen;
$localdiff = $ingamelen - $locallen;
$streamspaces = $streamdiff/$spacelen;
$localspaces = $localdiff/$spacelen;
$streampad = "";
$localpad = "";
foreach (range(1, $streamspaces) as $unused) {
	$streampad = $streampad . " ";
}
foreach (range(1, $localspaces) as $unused) {
	$localpad = $localpad . " ";
}
$outstring = $outstring . "   Local" . $localpad . " - " . date("H:i:s") . "\n";
$outstring = $outstring . "   Stream" . $streampad . " - " . $streamtime . "\n";
$outstring = $outstring . "   In-Game - " . $gametime . "\n\n";

// Mods
$outstring = $outstring . "Mods:\n";
foreach ($mods as $mod) {
	$wrapmod = fullWrap($mod, $wraplen, $font, pxtoPt(18));
	$i = 0;
	foreach ($wrapmod as $line) {
		if ($i = 0) {
			$outstring = $outstring . "   - ";
		} else {
			$outstring = $outstring . "     ";
		}
		$outstring = $outstring . $line . "\n";
		$i = $i = 1;
	}
}
 
// Trim any leading/trailing newlines or etc from output string
$outstring = trim($outstring);

// And output! Now with hacky drop shadow.
// First, center it.
$bounding = imagettfbbox(pxtoPt(18), 0, $font, $outstring);
$height = $bounding[1] - $bounding[7];
$topy = 360 - ($height/2);
imagettftext($img, pxtoPt(18), 0, 27, $topy+2, $black, $font, $outstring);
imagettftext($img, pxtoPt(18), 0, 25, $topy, $white, $font, $outstring);

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