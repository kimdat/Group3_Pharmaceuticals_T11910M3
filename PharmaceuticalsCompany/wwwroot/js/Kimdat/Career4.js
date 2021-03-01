

window.dataLayer = window.dataLayer || [];
function gtag() { dataLayer.push(arguments); }
gtag('js', new Date());

gtag('config', 'UA-23581568-13');
function openCity(evt, cityName) {


    var i, tabcontent, tablinks;
    tabcontent = document.getElementsByClassName("tabcontent");
    for (i = 0; i < tabcontent.length; i++) {
        tabcontent[i].style.display = "none";
    }
    tablinks = document.getElementsByClassName("tablinks");
    for (i = 0; i < tablinks.length; i++) {
        tablinks[i].className = tablinks[i].className.replace(" active", "");
    }
    document.getElementById(cityName).style.display = "block";
    evt.currentTarget.className += " active";


}

// Get the element with id="defaultOpen" and click on it
document.getElementById("defaultOpen").click();


var droppedFiles = false;
var fileName = '';
var $dropzone = $('.dropzone');
var $button = $('.upload-btn');
var uploading = false;
var $syncing = $('.syncing');
var $done = $('.done');
var $bar = $('.bar');
var timeOut;

$dropzone.on('drag dragstart dragend dragover dragenter dragleave drop', function (e) {
    e.preventDefault();
    e.stopPropagation();
})
    .on('dragover dragenter', function () {
        $dropzone.addClass('is-dragover');
    })
    .on('dragleave dragend drop', function () {
        $dropzone.removeClass('is-dragover');
    })
    .on('drop', function (e) {

        droppedFiles = e.originalEvent.dataTransfer.files;
        fileName = droppedFiles[0]['name'];
        $('.filename').html(fileName);
        $('.dropzone .upload').hide();
    });
$(".booking-form input").change(function () {

    if ($(this).attr("name").split(".")[1] == "chooseJoin") {
        var d1 = new Date();
        var d2 = new Date();

        d1 = ($(this).val());
   
        var EndDate = $(this).parent().parent().parent().find(".chooseEnd");
        d2 = EndDate.val();
     
       
        if (d1 < d2 && d2 != "") {
        
            EndDate.parent().find(".error").html("");
        }


    }


 


})
//valid from education
$(".booking-form input").focus(function () {

   $(this).parent().find(".error").html("");
   
  
})
$(".booking-form input").keydown(function () {

    
    $(this).parent().find(".error").html("");


})
$('input[type=date]').each(function () {
    var today = new Date();
    var dd = today.getDate();
    var mm = today.getMonth() + 1; //January is 0!
    var yyyy = today.getFullYear();
    if (dd < 10) {
        dd = '0' + dd
    }
    if (mm < 10) {
        mm = '0' + mm
    }

    today = yyyy + '-' + mm + '-' + dd;
    $(this).attr("min", "1971-01-01");
    $(this).attr("max", today);
})
$(' input[type=date]').keydown(function (e)
{
   
    e.preventDefault();
})

function Validation() {


    var flag = true;
    var error = "";

    var countName = 0;
    $(".name_school").each(function () {

        countName++;
        regexNameSchool = /^[a-zA-Z\sÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]{6,50}$/;


        

        if ($(this).val().trim() == "") {


            error += "Name of school " + countName + " must be required<br/>";
            $(this).parent().find(".error").html("name must be required");

            flag = false;
        }
        else if ($(this).val().trim().length < 6 || $(this).val().trim().length > 100) {
            error += "Name of school " + countName + " must be from 6 to 100 character<br/>";
            $(this).parent().find(".error").html("name must be from 6 to 100 character");
            flag = false;
        }
        else if (!regexNameSchool.test($(this).val().trim())) {
            error += "Name of school " + countName + " must be vali(only alpha characters and space)<br/>";
                $(this).parent().find(".error").html("name must be valid(only alpha characters and space)");

                flag = false;
        }
      

    });
    var countLocation = 0;
    $(".location").each(function () {

        countLocation++;
        if ($(this).val().trim() == "") {

            $(this).parent().find(".error").html("location mus be required");
            error += "Location of school " + countLocation + " must be required<br/>";
            flag = false;
        }
    });

    var countJoin = 0;
    $(".JoinDate").each(function () {

        countJoin++;
        if ($(this).val().trim() == "") {

            $(this).parent().find(".error").html("please choose join date");
            error += "Join Date  of school " + countJoin + " must be required<br/>";


            flag = false;
        }

    });
    var countEnd = 0;

    $(".EndDate").each(function () {

        countEnd++;
        if ($(this).val().trim() == "") {


            error += "End Date  of school " + countEnd + " must be required<br/>";

            $(this).parent().find(".error").html("please choose end date");

            flag = false;
        }

        else {
            var d1 = new Date(($(this).val().trim()));
            var d2 = new Date($(this).parent().parent().parent().find(".JoinDate").val());

            if (d2 >= d1) {

                $(this).parent().find(".error").html("end date must be greater than join date");
                error += "End Date of school " + countEnd + " must greater than Join Date <br/>";
                flag = false;
            }



        }
    });
    if (flag == false) {

        /*
        errorJoin = errorJoin.substr(0, errorJoin.length - 1);
        errorEnd = errorEnd.substr(0, errorEnd.length - 1);
        errorName = errorName.substr(0, errorName.length - 1);
        errorLocation = errorLocation.substr(0, errorLocation.length - 1);
        errorlengthname = errorlengthname.substr(0, errorlengthname.length - 1);
        if (errorJoin != "") {
            errorJoin = "<br/>please choose " + errorJoin;
        }
        if (errorEnd != "") {
            errorEnd = "<br/>please choose " + errorEnd;
        }
        if (errorName != "") {
            errorName += "  is required";
        }
        if (errorLocation != "") {
            errorLocation = "<br/>"+errorLocation + " is required ";
        }
        if (errorlengthname != "")
            errorlengthname = errorlengthname + " must  have from 6 to 100 chracter"
        */
        $("#ModalValid .modal-body p").html(error);
        $(".modalValid").click();

    }
    return flag;


}




function startUpload() {
    if (!uploading && fileName != '') {
        uploading = true;
        $button.html('Uploading...');
        $dropzone.fadeOut();
        $syncing.addClass('active');
        $done.addClass('active');
        $bar.addClass('active');
        timeoutID = window.setTimeout(showDone, 3200);
    }
}
//change joindate
function mychangeJoin() {
   
        var d1 = new Date();
        var d2 = new Date();

        d1 = ($(this).val());
  
        var EndDate = $(this).parent().parent().parent().find(".EndDate");
        d2 = EndDate.val();

        if (d1 < d2 && d2 != "") {
            EndDate.parent().find(".error").html("");
        }



    var a = $(this).parent().find(".JoinDate");
    var b = $(this).val();
    b = b.split(" ")[0];
    b = new Date(b);

    var month = b.getMonth() + 1;
    var year = b.getFullYear();

    var day = b.getDate();

    if (day < 10)
        day = "0" + day;
    if (month < 10)
        month = "0" + month;
    var date = year + "-" + month + "-" + day;


    a.val(date);
}
//change enddate
function mychangeEnd() {
    var a = $(this).parent().find(".EndDate");
    var b = $(this).val();
    b = b.split(" ")[0];
    b = new Date(b);

    var month = b.getMonth() + 1;
    var year = b.getFullYear();

    var day = b.getDate();

    if (day < 10)
        day = "0" + day;
    if (month < 10)
        month = "0" + month;
    var date = year + "-" + month + "-" + day;


    a.val(date);
}
function showDone() {
    $button.html('Done');
}
//set max,min day and prevent enter from input date for this input date when focuskeydown on this  input date
function onfocuKeydown() {
    $(' input[type=date]').keydown(function (e) {

        e.preventDefault();
    })
    var today = new Date();
    var dd = today.getDate();
    var mm = today.getMonth() + 1; //January is 0!
    var yyyy = today.getFullYear();
    if (dd < 10) {
        dd = '0' + dd
    }
    if (mm < 10) {
        mm = '0' + mm
    }

    today = yyyy + '-' + mm + '-' + dd;
    $(this).attr("min","1971-01-01");
    $(this).attr("max", today);
    $(this).parent().find(".error").html("");


}
//Add new school education detail
function newwin() {
    var valid = Validation();
    if (valid == true) {
        var first = $(".booking-form").length;

        if (first == 1) {
            var button = document.createElement("button");
            button.classList.add("btn");
            button.classList.add("btn-danger");
            button.classList.add("remove");
            button.append("Remove");
            button.setAttribute("type", "button");
            button.addEventListener("click", remove);
            $("#booking legend").append(button);


        }
        var a = $('.JoinDate').length;
        var divP = document.createElement("div");

        divP.classList.add("row");

        var filedset = document.createElement("fieldset");
        filedset.classList.add("booking-form");

        var legend = document.createElement("legend");
       
        legend.append("School");
        legend.classList.add("form-header");

        var button = document.createElement("button");
        button.classList.add("btn");
        button.classList.add("btn-danger");
        button.classList.add("remove");
        button.append("Remove");
        button.setAttribute("type", "button");
        button.addEventListener("click", remove);
        legend.append(button);
        filedset.append(legend);

        var divrA = document.createElement("div");
        divrA.classList.add("no-margin");
        divrA.classList.add("row");

        var divCA1 = document.createElement("div");
        divCA1.classList.add("col-md-6");

        var divFA1 = document.createElement("div");
        divFA1.classList.add("form-group");
        divFA1.classList.add("separator");

        var divSA1 = document.createElement("span");
        divSA1.classList.add("form-label");
        divSA1.append("Name_school");
        divFA1.append(divSA1);

        var inputA1 = document.createElement("input");
        inputA1.classList.add("form-control");
        inputA1.classList.add("name_school");
        inputA1.setAttribute("type", "text");
        inputA1.addEventListener("keydown", onfocuKeydown);
        inputA1.addEventListener("focus", onfocuKeydown);
        inputA1.setAttribute("name", "[" + a + "].Name_school");


        divFA1.append(inputA1);

        var errorA1 = document.createElement("span");
        errorA1.classList.add("error");

        divFA1.append(errorA1);

        divCA1.append(divFA1);

        var divCA2 = document.createElement("div");
        divCA2.classList.add("col-md-6");

        var divFA2 = document.createElement("div");
        divFA2.classList.add("form-group");


        var divSA2 = document.createElement("span");
        divSA2.classList.add("form-label");
        divSA2.append("Location");
        divFA2.append(divSA2);

        var inputA2 = document.createElement("input");
        inputA2.classList.add("form-control");
        inputA2.setAttribute("type", "text");
        divFA2.append(inputA2);

        var errorA2 = document.createElement("span");
        errorA2.classList.add("error");
        divFA2.append(errorA2);

        divCA2.append(divFA2);
        divrA.append(divCA1);
        divrA.append(divCA2);
        filedset.append(divrA);
        divP.append(filedset);
        inputA2.classList.add("location");
        inputA2.setAttribute("name", "[" + a + "].Location");
        inputA2.addEventListener("keydown", onfocuKeydown);
        inputA2.addEventListener("focus", onfocuKeydown);
        var divrA = document.createElement("div");
        divrA.classList.add("no-margin");
        divrA.classList.add("row");

        var divCA1 = document.createElement("div");
        divCA1.classList.add("col-md-6");

        var divFA1 = document.createElement("div");
        divFA1.classList.add("form-group");
        divFA1.classList.add("separator");

        var divSA1 = document.createElement("span");
        divSA1.classList.add("form-label");
        divSA1.append("JoinDate");
        divFA1.append(divSA1);

        var hiddenA1 = document.createElement("input");
        hiddenA1.classList.add("form-control");
        hiddenA1.classList.add("JoinDate");
        hiddenA1.setAttribute("type", "hidden");


        divFA1.append(hiddenA1);
        var inputA1 = document.createElement("input");
        inputA1.classList.add("form-control");
        inputA1.classList.add("chooseJoin");

        inputA1.setAttribute("type", "date");
        inputA1.setAttribute("name", "[" + a + "].JoinDate");

        inputA1.addEventListener("change", mychangeJoin);
        inputA1.addEventListener("focus", onfocuKeydown);

        divFA1.append(inputA1);

        var errorA1 = document.createElement("span");
        errorA1.classList.add("error");
        divFA1.append(errorA1);

        divCA1.append(divFA1);

        var divCA2 = document.createElement("div");
        divCA2.classList.add("col-md-6");

        var divFA2 = document.createElement("div");
        divFA2.classList.add("form-group");


        var divSA2 = document.createElement("span");
        divSA2.classList.add("form-label");
        divSA2.append("EndDate");
        divFA2.append(divSA2);
        var hiddenA2 = document.createElement("input");
        hiddenA2.classList.add("form-control");
        hiddenA2.classList.add("EndDate");
        hiddenA2.setAttribute("type", "hidden");
        hiddenA2.setAttribute("name", "[" + a + "].EndDate");
        divFA2.append(hiddenA2);
        var inputA2 = document.createElement("input");
        inputA2.classList.add("form-control");
        inputA2.setAttribute("type", "date");
        inputA2.setAttribute("name", "[" + a + "].ChooseEnd");
        inputA2.addEventListener("change", mychangeEnd);
        inputA2.addEventListener("focus", onfocuKeydown);
        divFA2.append(inputA2);

        var errorA2 = document.createElement("span");
        errorA2.classList.add("error");
        divFA2.append(errorA2);

        divCA2.append(divFA2);
        divrA.append(divCA1);
        divrA.append(divCA2);

        filedset.append(divrA);
        divP.append(filedset);

        $('#booking').append(divP);

    }

    else {
        $("#ModalValid .modal-body p").append("<br/>please Fill valid all above school before add new school");
    }
}
//remove one school education detail 
function remove() {
    var a = $(this).parent().parent();

    a.remove();
    var last = $(".booking-form").length;

    if (last == 1) {
        var lastRemove = $(".remove");
        lastRemove.remove();
    }
    var count = 0;
    $('.name_school').each(function () {

        $(this).attr("name", "[" + count + "].Name_school")
        count++;

    });
    var count = 0;
    $('.location').each(function () {

        $(this).attr("name", "[" + count + "].Location")
        count++;

    });
    var count = 0;
    $('.JoinDate').each(function () {

        $(this).attr("name", "[" + count + "].JoinDate")
        count++;

    });
    var count = 0;
    $('.EndDate').each(function () {

        $(this).attr("name", "[" + count + "].EndDate")
        count++;

    });
    var count = 0;
    $('.chooseJoin').each(function () {

        $(this).attr("name", "[" + count + "].chooseJoin")
        count++;

    });
    var count = 0;
    $('.chooseEnd').each(function () {

        $(this).attr("name", "[" + count + "].chooseEnd")
        count++;

    });

}


$(document).ready(function () {
  
    $('input[name="CurrentPassWord"]').keypress(function () {

        $(".CurrentPassWord").html("");
    });
    $('input[name="NewPassWord"]').keypress(function () {

        $(".NewPassword").html("");
    });
    $('input[name="ConFirmNewPassWord"]').keypress(function () {
        $(".ConFirmNewPassWord").html("");
    });

    var valB = $('input[name="DateOfBirth"]').val();
    valB = valB.split(" ")[0];
    valB = new Date(valB);


    var monthB = valB.getMonth() + 1;
    var yearB = valB.getFullYear();

    var dayB = valB.getDate();
    if (dayB < 10)
        dayB = "0" + dayB;
    if (monthB < 10)
        monthB = "0" + monthB;
    var dateB = yearB + "-" + monthB + "-" + dayB;
    $('input[name="chooseDateOfBirth"]').val(dateB);

    $('input[name="chooseDateOfBirth"]').change(function () {
        $('input[name="DateOfBirth"]').val($(this).val());
    });
    $('.JoinDate').each(function () {

        var a = $(this).parent().find(".chooseJoin");
        var b = $(this).val();

        b = b.split(" ")[0];
        b = new Date(b);

        var month = b.getMonth() + 1;
        var year = b.getFullYear();

        var day = b.getDate();

        if (day < 10)
            day = "0" + day;
        if (month < 10)
            month = "0" + month;
        var date = year + "-" + month + "-" + day;

        a.val(date);
    })
    $('.EndDate').each(function () {

        var a = $(this).parent().find(".chooseEnd");
        var b = $(this).val();

        b = b.split(" ")[0];
        b = new Date(b);

        var month = b.getMonth() + 1;
        var year = b.getFullYear();

        var day = b.getDate();

        if (day < 10)
            day = "0" + day;
        if (month < 10)
            month = "0" + month;
        var date = year + "-" + month + "-" + day;

        a.val(date);
    })
    $('.chooseEnd').change(function () {

        var b = $(this).parent().find(".EndDate");
        b.val($(this).val());
    });
    $('.chooseJoin').change(function () {
       

        var b = $(this).parent().find(".JoinDate");

        b.val($(this).val());
    });
    //remove one school
    $('.remove').click(function () {
        var a = $(this).parent().parent();
        var b = $("#booking");
        a.remove();
        var last = $(".booking-form").length;

        if (last == 1) {
            var lastRemove = $(".remove");
            lastRemove.remove();
        }
        var count = 0;
        $('.name_school').each(function () {

            $(this).attr("name", "[" + count + "].Name_school")
            count++;


        });
        var count = 0;
        $('.location').each(function () {

            $(this).attr("name", "[" + count + "].Location")
            count++;

        });
        var count = 0;
        $('.JoinDate').each(function () {

            $(this).attr("name", "[" + count + "].JoinDate")
            count++;

        });
        var count = 0;
        $('.EndDate').each(function () {

            $(this).attr("name", "[" + count + "].EndDate")
            count++;

        });
        var count = 0;
        $('.chooseJoin').each(function () {

            $(this).attr("name", "[" + count + "].chooseJoin")
            count++;

        });
        var count = 0;
        $('.chooseEnd').each(function () {

            $(this).attr("name", "[" + count + "].chooseEnd")
            count++;

        });

    });
    $('input[name="Gender[]"').change(function () {

        var atLeastOneIsChecked = $('input[name="Gender[]"]:checked');
        $('input[name="Gender').val(atLeastOneIsChecked.val());

    });

    $('input[name="checkbox"').change(function () {

        if ($(this).is(':checked')) {
            // Do something...
            $('.photo').removeClass('hidden');


        }
        else {
            $('.photo').addClass('hidden');
        }

    });
    
    $('input[name="checkboxResume"').change(function () {

        if ($(this).is(':checked')) {
            // Do something...
            $('.centerIndex').removeClass('hidden');


        }
        else {
            $('.centerIndex').addClass('hidden');
        }

    });
});



/*==================================================================
[ Focus Contact2 ]*/
$('.input2').each(function () {
    $(this).on('blur', function () {
        if ($(this).val().trim() != "") {
            $(this).addClass('has-val');
        }
        else {
            $(this).removeClass('has-val');
        }
    })
})



/*==================================================================
[ Validate ]*/
$("input[type='text'").focus(function () {
    $(".successUpdate").hide();
});
$("input[type='radio'").focus(function () {
    $(".successUpdate").hide();
});
$("input[type='date'").focus(function () {
    $(".successUpdate").hide();
});
$("input[type='file'").change(function () {
    $(".successUpdate").hide();
});
//valid personal detail
function ValidationPersonal() {

    var name = $('input[name="FullName"]');
    var add = $('input[name="Address"]');
    var phone = $('input[name="Phone"]');


    var check = true;
    regexName = /^[a-zA-Z\sÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]{6,50}$/;


    if (!regexName.test($(name).val().trim()))
        {
        showValidate(name);
        check = false;
    }



    if ($(add).val().trim() == '') {
        showValidate(add);
        check = false;
    }
    if ($(phone).val().trim().match(/\(?([0-9]{3})\)?([ .-]?)([0-9]{3})\2([0-9]{4})$/) == null) {
        showValidate(phone);
        check = false;
    }
    if (check == false) {
        $("#ModalValid .modal-body p").html("pleas fill valid personal detail");
        $(".modalValid").click();

    }
 


    return check;
}


$('.validate-form .input2').each(function () {
    $(this).focus(function () {
        hideValidate(this);
    });
});

function showValidate(input) {
    var thisAlert = $(input).parent();

    $(thisAlert).addClass('alert-validate');
}

function hideValidate(input) {
    var thisAlert = $(input).parent();

    $(thisAlert).removeClass('alert-validate');
}
//chrom file cancel fix
var debug = true;//true: add debug logs when cloning
var evenMoreListeners = true;//demonstrat re-attaching javascript Event Listeners (Inline Event Listeners don't need to be re-attached)
if (evenMoreListeners) {
    var allFleChoosers = $("input[type='file']");
    addEventListenersTo(allFleChoosers);
    function addEventListenersTo(fileChooser) {
        fileChooser.change(function (event) { console.log("file( #" + event.target.id + " ) : " + event.target.value.split("\\").pop()) });
        fileChooser.click(function (event) { console.log("open( #" + event.target.id + " )") });
    }
}
(function () {
    var old = console.log;
    var logger = document.getElementById('log');
    console.log = function () {
        for (var i = 0; i < arguments.length; i++) {
            if (typeof arguments[i] == 'object') {
                logger.innerHTML += (JSON && JSON.stringify ? JSON.stringify(arguments[i], undefined, 2) : arguments[i]) + '<br />';
            } else {
                logger.innerHTML += arguments[i] + '<br />';
            }
        }
        old.apply(console, arguments);
    }
})();

var clone = {};

// FileClicked()
function fileClicked(event) {
    var fileElement = event.target;
    if (fileElement.value != "") {
        if (debug) { console.log("Clone( #" + fileElement.id + " ) : " + fileElement.value.split("\\").pop()) }
        clone[fileElement.id] = $(fileElement).clone(); //'Saving Clone'

    }
    //What ever else you want to do when File Chooser Clicked
}

// FileChanged()

function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $('#blah').attr('src', e.target.result);
        }

        reader.readAsDataURL(input.files[0]); // convert to base64 string
    }
}

function fileChangedPhoto(event, photoChange) {


    $('#blah').removeClass("hidden");
    var fileElement = event.target;
    var val = fileElement.value.toLowerCase();
    regex = new RegExp("(.*?)\.(jpg|png|jpeg|jpe|jfit)$");

    if (val == "" || !(regex.test(val))) {
        $("input[name='fileUser']").val("");
        if (val != "") {

            $(".modalValid").click();
            $("#ModalValid .modal-body p").html("Please select corret file image(*.jpg,*.jpeg,*.jpe,*.jfit,*.png");
        }
        if (debug) { console.log("Restore( #" + fileElement.id + " ) : " + clone[fileElement.id].val().split("\\").pop()) }
        clone[fileElement.id].insertBefore(fileElement); //'Restoring Clone'
        $(fileElement).remove(); //'Removing Original'
        if (evenMoreListeners) { addEventListenersTo(clone[fileElement.id]) }//If Needed Re-attach additional Event Listeners
    }
    else {
        readURL(photoChange);
    }
    //What ever else you want to do when File Chooser Changed
}

function fileChangedResume(event) {



    var fileElement = event.target;
    var val = fileElement.value.toLowerCase();
    regex = new RegExp("(.*?)\.(docx|doc|docm|docx|dot|dotx|ppt|pptm|pptx|xlm|xls|xlsm|xlsx|pdf)$");

    if (val == "" || !(regex.test(val))) {
        $("input[name='file']").val("");
        if (val != "") {

            $(".modalValid").click();
            $("#ModalValid .modal-body p").html("Please select file word,excel,pdf or power point");
            // $('.filename').html('');
        }
        if (debug) { console.log("Restore( #" + fileElement.id + " ) : " + clone[fileElement.id].val().split("\\").pop()) }
        clone[fileElement.id].insertBefore(fileElement); //'Restoring Clone'
        $(fileElement).remove(); //'Removing Original'
        if (evenMoreListeners) { addEventListenersTo(clone[fileElement.id]) }//If Needed Re-attach additional Event Listeners
    }
    else {
        fileName = $("input[name='file']")[0].files[0].name;

        $('.filename').html(fileName);
        $('.dropzone .upload').hide();
    }

    //What ever else you want to do when File Chooser Changed
}