﻿
function AppInit() {
        $(document).ready(function () {
            $(document).delegate(".submenu-active", "click", function () {
                $(".submenu-active").each(function (index, value) {
                    $(this).removeClass("active");
                });
                $(this).addClass("active");
            });

            App.init();



            $('.masked-benid').inputmask('9999999');
            $('.masked-phone').inputmask('999-999-9999');
            $('.masked-date').inputmask('99-99-9999');

            $('.select2').select2({
                //placeholder: "Make a Selection",
            });

            $('#family-nationality').select2({
                //placeholder: "Make a Selection",
                dropdownParent: $('#family-modal'),
            });

            $(".select2-container").each(function (index, value) {
                $(this).removeClass("mb-4");
            });

            $('.datepicker').flatpickr({
                dateFormat: "d-m-Y",
                allowInput: true,
                dropdownParent: $("#familymodal"),
            });
           
            
        });


            //$(function () {
        //    var url = window.location.href;
        //    alert(url);
        //    // passes on every "a" tag
        //    //$(document).delegate(".submenu-active", "onload", function () {
        //    $(".submenu-active").each(function () {
        //        // checks if its the same on the address bar
        //        alert(this.href);
        //        if (url == (this.href)) {
        //            $(this).closest("li").addClass("active");
        //        }
        //    });


        //    //});
        //}
    }



function ClaimJS(dotNetHelper) {

    $('#benid').inputmask('9999999', {
        oncomplete: function () {
            var val = $(this).val();
            return dotNetHelper.invokeMethodAsync('OnBenIDChanged', val);
        }
    });

    $(document).delegate('#province', "change", function (event) {
        var val = $(this).val();
        return dotNetHelper.invokeMethodAsync('GetDistricts', val);
    });

    $(document).delegate('#district', "change", function (event) {
        var val = $(this).val();
        return dotNetHelper.invokeMethodAsync('GetCommunes', val);
    });

    $(document).delegate('.removedoc', "click", function (event) {
        var val = $(this).data('index');
        swal({
           /* title: 'លុប',*/
            text: "តើអ្នកពិតជាចង់លុបចេញមែនទេ?",
           /* type: 'question',*/
            showCancelButton: true,
            confirmButtonClass: 'btn btn-danger mr-2',
            confirmButtonText: 'លុប',
            cancelButtonText: 'បោះបង់',
            cancelButtonClass: 'btn btn-primary',
            buttonsStyling: false,
            padding: '1.2em'
        }).then(function (result) {
            if (result.value) {
                dotNetHelper.invokeMethodAsync('OnRemoveClaimDocument', val);
            }
        })
    });

    //$('#family-nat').select2({
    //    tags: true,
    //    dropdownParent: $('#family-modal'),
    //});

}




