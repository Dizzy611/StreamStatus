// Copyright (C) 2015 Dylan J. Morrison <insidious@gmail.com>
// This work is free. You can redistribute it and/or modify
// it under the terms of the Do What The Fuck You Want To 
// Public License, Version 2, as published by Sam Hocevar.
// See http://www.wtfpl.net/ for more details.

$(document).ready(function () {
    var $img = $('#reloader');
    setInterval(function () {
        $.get('imagegen.php', function (data) {
            var $loader = $(document.createElement('img'));
            $loader.one('load', function () {
                $img.attr('src', $loader.attr('src'));
            });
            $loader.attr('src', data);
            if ($loader.complete) {
                $loader.trigger('load');
            }
        });
    }, 250);
});