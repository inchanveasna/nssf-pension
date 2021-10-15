
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




    //var oTable = $('#tableClaimList').dataTable();






		 


    $('#benid').inputmask('9999999', {
        //oncomplete: function () {
        //    var val = $(this).val();
        //    dotNetHelper.invokeMethodAsync('OnBenIdCompleted', val);
        //},
    });

    $("#benid").on('paste input', function (event) {
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

    $(document).delegate('#memsex', "change", function (event) {
        var val = $(this).val();
        return dotNetHelper.invokeMethodAsync('OnSexChanged', val);
    });

    //$(document).delegate('#remove-doc', "click", function (event) {
    //    var val = $(this).data('index');
    //    swal({
    //       /* title: 'លុប',*/
    //        text: "តើអ្នកពិតជាចង់លុបចេញមែនទេ?",
    //       /* type: 'question',*/
    //        showCancelButton: true,
    //        confirmButtonClass: 'btn btn-danger mr-2',
    //        confirmButtonText: 'លុប',
    //        cancelButtonText: 'បោះបង់',
    //        cancelButtonClass: 'btn btn-primary',
    //        buttonsStyling: false,
    //        padding: '1.2em'
    //    }).then(function (result) {
    //        if (result.value) {
    //            dotNetHelper.invokeMethodAsync('OnRemoveClaimDocument', val);
    //        }
    //    })
    //});

    //$(document).delegate('#edit-doc', "click", function (event) {
    //    var val = $(this).data('index');
    //    $('#exampleModal').modal('toggle').then(() => {
    //        dotNetHelper.invokeMethodAsync('OnEditClaimDocument', val);
    //    });
    //});

    $('.datepicker').flatpickr({
        dateFormat: "d-m-Y",
        /*allowInput: true,*/
        // onClose: function (selectedDates, dateStr, instance) {
        //     var dateStrs = dateStr.split('-');
        //     if (dateStrs.length == 3) {
        //         instance.setDate(instance.input.value, false);
        //     }
        //}
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
