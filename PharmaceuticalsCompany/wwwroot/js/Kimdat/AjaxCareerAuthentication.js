﻿
$(document).ready(function () {







    $('#register input').each(function () {
        $(this).keydown(function () {
            $(this).parent().find(".error").html("");
        })
        $(this).focus(function () {
            $(this).parent().find(".error").html("");
        })
    })

    $('input[name="file"]').click(function () {

        $(".errorResume").html("");
    });
    $('input[name="fileUser"]').click(function () {

        $(".errorImage").html("");
    });


    $("#register").submit(function (e) {
     
        $('.wait').show();

        var flagResume = true;
        var flagPersonal = true;
        var flagEducation = true;

        if ($('input[name="fileUser"]').val() == "") {
            $(".errorImage").html(" please choose your image");
            flagPersonal = false;

        }
        if ($('input[name="Phone"]').val().trim().match(/\(?([0-9]{3})\)?([ .-]?)([0-9]{3})\2([0-9]{4})$/) == null) {
            $('input[name = "Phone"]').parent().find(".error").html(" Valid PHONE Is required: (123)456789,(123).456.7899,(123)-456-7899,123-456-7899,123 456 7899,1234567899");
            flagPersonal = false;
        }
    
        if ($('.register input[name="Email"]').val().trim().match(/^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{1,5}|[0-9]{1,3})(\]?)$/) == null)  {
            $('.register input[name = "Email"]').parent().find(".error").html(" Valid email is required: ex@abc.xyz");
            flagPersonal = false;
        }
        
        $(".name_school").each(function () {


            if ($(this).val().trim() == "") {



                $(this).parent().find(".error").html("name is required");

                flagEducation = false;


            }
            else if ($(this).val().trim().length < 6 || $(this).val().trim().length > 100) {
                $(this).parent().find(".error").html("name  must be  6 to 100 chractactrs");

                flagEducation = false;
            }

        });
        $(".location").each(function () {


            if ($(this).val().trim() == "") {


                $(this).parent().find(".error").html("location is required");

                flagEducation = false;
            }
        });

        if ($('input[name="file"]').val() == "") {
            $(".errorResume").html(" please choose your resume");
            flagResume = false;
        }



        $(".EndDate").each(function () {
            var d1 = new Date(($(this).val().trim()));
            var d2 = new Date($(this).parent().parent().parent().find(".JoinDate").val());
            if (d2 >= d1) {
                $(this).parent().find(".error").html("End Date must be greater than joindate");
                //  error += "End Date of school " + countEnd + " must greater than Join Date <br/>";
                flagEducation = false;
            }


        });
        e.preventDefault();

        $.ajax({


            method: 'post',
            url: this.action,

            complete: function () { $('.wait').hide(); },

            data: new FormData(this),
            processData: false,
            contentType: false,
            error: function (xhr) {
                alert("loi roi");
            },
            success: function (result) {

                if (!result.success) {

                    var errorPass = "";
                    for (i = 0; i < result.errors.length; i++) {

                        var name = result.errors[i].key;
                        if (name.split(".")[1] != "JoinDate" && name.split(".")[1] != "EndDate") {
                            flagPersonal = false;

                            $(".register input[name='" + name + "']").parent().find(".error").html(result.errors[i].errors[0]);
                            if (name == "EmailExist")
                                $(".register input[name='Email']").parent().find(".error").html("Email is exist");
                            if (name == "DateOfBirth")
                                $("input[name='" + name + "']").parent().find(".error").html(" please choose your birthday");
                            if (name.indexOf("Password") !== -1) {
                                errorPass += result.errors[i].errors[0] + "<br/>";
                                $(".register input[name='PassWord']").parent().find(".error").html(errorPass);
                            }
                            if ($("input[name='Password']").val() == "" && $("input[name='ConfirmPassWord']") != "") {
                                $("input[name='ConfirmPassWord']").parent().find(".error").html("");
                            }



                        }
                        else {
                            flagEducation = false;
                            $("input[name='" + name + "']").parent().find(".error").html("please choose " + name.split(".")[1]);
                        }
                        console.log(result.errors[i].key);
                        console.log(result.errors[i].errors[0]);
                    }

                    var error = "";
                    if (flagPersonal == false)
                        error += " please fill valid personal detail </br>"
                    if (flagEducation == false)
                        error += " please fill valid education detail </br>"
                    if (flagResume == false)
                        error += "pls upload your resume </br>"
                    $(".modalValid").click();
                    $("#ModalValid .modal-body p").html(error);

                }

                else {



                    $(".modalValid").click();
                    $("#ModalValid .modal-body p").html(" Your account have been created, we have sent one email for you to vertiy, please vertify it before you want to watch and edit your profile.");
                }

                // location.reload();
                //var a=data.status;
                //alert(a);
                //  document.getElementById("total").innerHTML = 123;
            }

        });


    });
    $('.forgot input[name="Email"]').focus(function (e) {
        $('.forgot input[name = "Email"]').parent().find(".error").html("");
    })
    $("#forgotPass").submit(function (e) {
        e.preventDefault();
        var flag = true;
        if ($('.forgot input[name="Email"]').val().trim()=="") {
            $('.forgot input[name = "Email"]').parent().find(".error").html(" Mail is required");
            flag = false;
        }
        else if ($('.forgot input[name="Email"]').val().trim().match(/^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{1,5}|[0-9]{1,3})(\]?)$/) == null) {
            $('.forgot input[name = "Email"]').parent().find(".error").html(" Valid email is required: ex@abc.xyz");
            flag = false;
        }
        if (flag == true) {
            $.ajax({

                method: 'post',
                url: this.action,
                data: $(this).serialize(),
                datatype: 'json',
                beforeSend: function () { $('.wait').show(); },
                complete: function () { $('.wait').hide(); },
                error: function (xhr) {
                    alert("loi roi");
                },
                success: function (result) {
                    if (!result.success) {
                        $('.forgot input[name = "Email"]').parent().find(".error").html("this mail  hasn't been vertified or  hasn't beeen register");


                    }
                    else {


                        $(".forgot input").addClass("hidden");

                        $(".forgot p").html("we have sent your email for you to reset your password")
                        $(".sendReset").addClass("hidden");
                    }

                    // location.reload();
                    //var a=data.status;
                    //alert(a);
                    //  document.getElementById("total").innerHTML = 123;
                }

            });
        }
      
    });
    $('.login input[name="Email"]').focus(function (e)
    {
        $('.login input[name = "Email"]').parent().find(".error").html("");
    })
    $('.login input[name="PassWord"]').focus(function (e) {
        $('.login input[name = "PassWord"]').parent().find(".error").html("");
    })
    $("#signupform").submit(function (e) {
        e.preventDefault();
        var flagPersonal = true;
        if ($('.login input[name="Email"]').val().trim() == "") {
            $('.login input[name = "Email"]').parent().find(".error").html(" Mail is required");
            flag = false;
        }
        else  if ($('.login input[name="Email"]').val().trim().match(/^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{1,5}|[0-9]{1,3})(\]?)$/) == null) {
            $('.login input[name = "Email"]').parent().find(".error").html(" Valid email is required: ex@abc.xyz");
            flagPersonal = false;
        }
        var password = $('.login input[name="PassWord"]');
      
        if (password.val().trim() == "") {
            $('.login input[name="PassWord"]').parent().find(".error").html("password is required");
            flagPersonal = false;
        }
    
        if (flagPersonal == true) {
            $.ajax({
                method: 'post',
                url: this.action,
                data: $(this).serialize(),
                datatype: 'json',
                beforeSend: function () { $('.wait').show(); },
                complete: function () { $('.wait').hide(); },
                error: function (xhr) {

                },
                success: function (result) {
                    if (!result.success) {
                        $(".modalValid").click();
                        if (result.role)
                            $("#ModalValid .modal-body p").html("your account haven't vertify");
                        else
                            $("#ModalValid .modal-body p").html("invalid account");



                    }
                    else {
                        if (result.role == "admin")
                            window.location.href = "/Admin"
                        else if (result.role == "user")
                            window.location.href = "/Career";



                    }

                    // location.reload();
                    //var a=data.status;
                    //alert(a);
                    //  document.getElementById("total").innerHTML = 123;
                }

            });
        }
     
       
    });
});