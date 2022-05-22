
function AppInit() {
    $('[data-toggle="popover"]').popover({
        trigger: 'hover'
    })

        $(document).ready(function () {
            $(document).delegate(".submenu-active", "click", function () {
                $(".submenu-active").each(function (index, value) {
                    $(this).removeClass("active");
                });
                $(this).addClass("active");
            });

            
            App.init();


            $('.masked-benid').inputmask('9999999');
            $('.masked-phone').inputmask({ mask: "999-999-9999" });
            $('.masked-date').inputmask('99-99-9999');
            $('.masked-code').inputmask('99999/99');

            $('.select2').select2({
                //placeholder: "Make a Selection",
            });

            $('#memnat').select2({
                //placeholder: "Make a Selection",
                dropdownParent: $('#ModalMember'),
            });

            $(".select2-container").each(function (index, value) {
                $(this).removeClass("mb-4");
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

    $('.masked-benid').inputmask('9999999');
    $('.masked-phone').inputmask({ mask: "999-999-9999" });
    $('.masked-date').inputmask('99-99-9999');
    $('.masked-code').inputmask('99999/99');


    $("#benid").inputmask('9999999').on('paste input', function (event) {
        if ($(this).inputmask("isComplete")) {
            var val = $(this).val();
            dotNetHelper.invokeMethodAsync('OnBenIdCompleted', val);
        }
        else {
            dotNetHelper.invokeMethodAsync('OnBenIdInCompleted', "");
        }
    });

    $(document).delegate('#province', "change", function (event) {
        var val = $(this).val();
        return dotNetHelper.invokeMethodAsync('OnProvinceChanged', val);
    });

    $(document).delegate('#district', "change", function (event) {
        var val = $(this).val();
        return dotNetHelper.invokeMethodAsync('OnDistrictChanged', val);
    });

    
    $(document).delegate('#claimtype', "change", function (event) {
        var val = $(this).val();
        return dotNetHelper.invokeMethodAsync('OnPensionTypeChanged', val);
    });


    $('.datepicker').flatpickr({
        dateFormat: "d-m-Y"
    });


    //Initialize Select2 Elements
    $('.select2').select2()

    //Initialize Select2 Elements
    $('.select2bs4').select2({
        theme: 'bootstrap4'
    })
}


function ClaimFamily(dotNetHelper) {
    $(document).delegate('#memsex', "change", function (event) {
        var val = $(this).val();
        return dotNetHelper.invokeMethodAsync('OnSexChanged', val);
    });
}


//function InitDatatable(table) {
//    $(document).ready(function () {
//    $(table).DataTable({
//        "paging": false,
//        "lengthChange": false,
//        "searching": false,
//        "ordering": true,
//        "info": false,
//        "autoWidth": false,
//        "responsive": true,
//    });
//    });
//}


function InitDatePicker() {
    $('#docdate').flatpickr({
        dateFormat: "d-m-Y",
    });

    //var offset = $('#docdate').offset();
    //var posY = offset.top - y;
    //$('.flatpickr-calendar').css("top", posY);


    
    $("#docdate").focus(function () {
        var bodyTop = parseFloat($("body").css("top"));
        var y = Math.abs(bodyTop) + $(this).offset().top + $(this).height() + 10;
        $(".flatpickr-calendar").css("top", y);
    });
}



function GetMaskPhoneText(id) {
    var result = $('#' + id).val().replace(/-/g, "").replace(/_/g, "");
    return result
}

function GetMaskCode(id) {
    var txt = $('#' + id).inputmask('99999/99');

    if (txt.inputmask("isComplete")) {
        return $('#' + id).val();
    }
    else {
       return $('#' + id).val().replace(/-/g, "").replace(/_/g, "");
    }
}


function GetMaskDateText(id) {
    var result = $('#' + id).val().split('-');
    if (result.length == 3) {
        return new Date(result[2] + "/" + result[1] + "/" + result[0])
    }
    return null;
}
