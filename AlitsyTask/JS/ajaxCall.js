const URL = "http://127.0.0.1:8080/Home/save";

$(document).ready(function () {
    
    $('#btn').click(function () {

        var data = {
            "BillType_Name": $("input[name='billTypeOptions']:checked").val(),
            "EntryMethod_Name": $("input[name='entryMethodOptions']:checked").val(),
            "PeakCharge": $("#peakCharge").val(),
            "PeakQuantity": $("#peakQuantity").val(),
            "PeakEnergyRate": $("#peakEnergyRate").val(),
            "ShoulderCharge": $("#shoulderCharge").val(),
            "ShoulderQuantity": $("#shoulderQuantity").val(),
            "ShoulderEnergyRate": $("#shoulderEnergyRate").val(),
            "OffPeakCharge": $("#offPeakCharge").val(),
            "OffPeakQuantity": $("#offPeakQuantity").val(),
            "OffPeakEnergyRate": $("#offPeakEnergyRate").val(),
            "GST": $("input[name='gstOptions']:checked").val(),
        };
        if ($("#peakCharge").val() != '' && $("#peakQuantity").val() != '' && $("#peakEnergyRate").val() != ''
            && $("#shoulderCharge").val() != '' && $("#shoulderQuantity").val() != '' && $("#shoulderEnergyRate").val() != '' &&
            $("#offPeakCharge").val() != '' && $("#offPeakQuantity").val() != '' && $("#offPeakEnergyRate").val() != '' &&
            $("input[name='billTypeOptions']:checked").val() != '' && $("input[name='entryMethodOptions']:checked").val() != '' &&
            $("input[name='gstOptions']:checked").val() != ''
        ) {

            $.ajax(
                {
                    type: "POST",
                    url: URL,
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    data: JSON.stringify(data),
                    success: function () {
                        alert('Data Successfully Saved');
                    },
                    error: function (request, message, error) {
                        handleException(request, message, error);
                    }

                });
        } else {
            alert('Please enter all value');

        }


    });
});

function handleException(request, message, error) {
    var msg = "";
    msg += "Code: " + request.status + "\n";
    msg += "Text: " + request.statusText + "\n";
    if (request.responseJSON != null) {
        msg += "Message: " +
            request.responseJSON.Message + "\n";
    }
    alert(msg);
}