﻿
// Write your JavaScript code.

function GAPI_Load() {
    gapi.client.setApiKey("AIzaSyD0kZmoBWTVe_n_KQBdN1CxPxEvJV1_Cew");
}
function searchMovie(movieName) {
    var qSearch = movieName + " trailer";
    debugger;
    gapi.client.load('youtube', 'v3', function () {
        debugger;
        var request = gapi.client.youtube.search.list({
            q: qSearch,
            part: 'snippet',
            maxResults: 1
        });

        request.execute(function (response) {
            var str = JSON.stringify(response.result);
            var trailerId = response.items[0].id.videoId;
            showVideo(trailerId);
            debugger;
        });
    });
}
function showVideo(trailerId) {
    var videoEl = document.getElementById("trailer");
    videoEl.innerHTML = "<iframe width='560' height='315'  frameborder='0' src='https://www.youtube.com/embed/" + trailerId + "' allowfullscreen></iframe>";
}

function post(path, params, method) {
    method = method || "post";

 
    var form = document.createElement("form");
    form.setAttribute("method", method);
    form.setAttribute("action", path);

    for (var key in params) {
        if (params.hasOwnProperty(key)) {
            var hiddenField = document.createElement("input");
            hiddenField.setAttribute("type", "hidden");
            hiddenField.setAttribute("name", key);
            hiddenField.setAttribute("value", params[key]);

            form.appendChild(hiddenField);
        }
    }

    document.body.appendChild(form);
    form.submit();
}

$(document).ready(function () {
    $('#characterLeft').text('140 characters left');
    $('#message').keydown(function () {
        var max = 140;
        var len = $(this).val().length;
        if (len >= max) {
            $('#characterLeft').text('You have reached the limit');
            $('#characterLeft').addClass('red');
            $('#btnSubmit').addClass('disabled');
        }
        else {
            var ch = max - len;
            $('#characterLeft').text(ch + ' characters left');
            $('#btnSubmit').removeClass('disabled');
            $('#characterLeft').removeClass('red');
        }
    });
});