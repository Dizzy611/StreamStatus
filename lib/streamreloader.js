﻿$(document).ready(function () {
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