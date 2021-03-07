﻿
var countryOptions = "<option>Choose city</option>";

$.each(json, function (i, city) {

    countryOptions += "<option value='" +
        city.code + "'>"
        + city.name + "</option>";

});


$('#country').html(countryOptions);
var districtOptions;
$("#country").change(function () {
    distincOptions = "";
    distincOptions = "<option>Choose district</option>";

    var cityChoose = $(this).val();

    $.each(json, function (i, city) {

        if (cityChoose == city.code) {

            $.each(city.districts, function (i, districtsA) {

                distincOptions += "<option value='" +
                    districtsA.name + "'>"
                    + districtsA.name + "</option>";


            });

        }

    });
    $('#district').html(distincOptions);
    var wardOptions = "<option> Choose ward</option>";
    $('#ward').html(wardOptions);
});

var wardOptions;
$("#district").change(function () {
    wardOptions = "";
    var wardOptions = "<option>Choose ward</option>";


    var districtChoose = $(this).val();

    $.each(json, function (i, city) {
        $.each(city.districts, function (i, district) {
            if (districtChoose == district.name) {
         
                $.each(district.wards, function (i, ward) {

                    wardOptions += "<option value='" +
                        ward + "'>"
                        + ward.name + "</option>";


                });

            }
        });


    });

    $('#ward').html(wardOptions);



});