
$(document).ready(function () {
 
    $(function () {
        var countryOptions;
        $.getScript("Custom.js", function (result) {
            alert("123");

        });
        $.getJSON("A.json", function (result) {
            alert("123");
          
        });

    });
});
