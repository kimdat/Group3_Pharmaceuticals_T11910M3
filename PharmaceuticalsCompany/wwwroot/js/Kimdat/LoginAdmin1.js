
(function ($) {
    "use strict";


    /*==================================================================
    [ Focus Contact2 ]*/
    $('.input100').each(function () {
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
    var input = $('.validate-input .input100');

    $('.validate-form').on('submit', function (e) {
        var check = true;

        for (var i = 0; i < input.length; i++) {
            if (validate(input[i]) == false) {
                showValidate(input[i]);
                check = false;
            }
        }
        e.preventDefault();
        if (check == true) {
            $.ajax({
                method: 'post',
                url: this.action,
                data: $(this).serialize(),
                datatype: 'json',
                beforeSend: function () { $('.wait').show(); },
                complete: function () { $('.wait').hide(); },
                error: function (xhr) {
                    console.log(xhr);
                },
                success: function (result) {
                   
                    if (!result.success) {
                        $(".modalValid").click();
                        $("#ModalValid .modal-body p").html("Account not exist in system");



                    }
                    else {

                      
                            window.location.href = "/Admin"
                       

                    }

                    // location.reload();
                    //var a=data.status;
                    //alert(a);
                    //  document.getElementById("total").innerHTML = 123;
                }

            });
        }
    });


    $('.validate-form .input100').each(function () {
        $(this).focus(function () {
            hideValidate(this);
        });
    });

    function validate(input) {
        if ($(input).attr('type') == 'email' || $(input).attr('name') == 'email') {
            if ($(input).val().trim().match(/^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{1,5}|[0-9]{1,3})(\]?)$/) == null) {
                return false;
            }
        }
        else {
            if ($(input).val().trim() == '') {
                return false;
            }
        }
    }

    function showValidate(input) {
        var thisAlert = $(input).parent();

        $(thisAlert).addClass('alert-validate');
    }

    function hideValidate(input) {
        var thisAlert = $(input).parent();

        $(thisAlert).removeClass('alert-validate');
    }


})(jQuery);