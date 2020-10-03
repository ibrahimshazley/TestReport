$(document).ready(function () {
  
});


var strBranchNo, strCompanyNo, strEmpSerialNo;
var varRptCaptionName, AddCation;

function viewReport() {
    debugger;
    //if (($('#selBranch_Id').val() != "-1" && $('#selBranch_Id').val() != null && $('#selBranch_Id').val() != NaN) && ($('#selBranch_Id').val() != "-1" && $('#selBranch_Id').val() != null && $('#selBranch_Id').val() != NaN)) {
    // var strParamterValue = "005,1,0,@,@,@,@,-1"
    varRptCaptionName = "Test";
    AddCation = "";


    var strParamterValue = GetDataParamter();

    debugger;
    var DTO = { 'strParamterValue': strParamterValue, 'strRptCaptionName': varRptCaptionName };
    $.ajax({
        url: /*$(location).attr('href') +*/ "WebForm3.aspx/GetDataReport",
        type: "POST",
        //url: 'WebForm3.aspx/GetDataReport',
        dataType: "json",
        data: JSON.stringify({ strParamterValue: strParamterValue, strRptCaptionName: varRptCaptionName }),
        contentType: "application/json; charset=utf-8",
        async: false,
        success: function (data) {
            debugger;
            if (data.d != null) {
                debugger;

                var params = [
                    'height=' + screen.height,
                    'width=' + screen.width,
                    'fullscreen=yes' // only works in IE, but here for completeness
                ].join(',');
                //window.location.href = data.d;
                window.open(data.d, '_blank', 'height=900,width=1000');

                //window.open(data.d, "open", params);
                //var popup = window.open(data.d, "open", params);
                //popup.moveTo(0, 0);
            }

        }
    }).fail(function (jqXHR, textStatus, errorThrown) {
        alert("Request failed: " + textStatus);
        alert(jqXHR.responseText);
        console.log(jqXHR.responseText);
        alert(errorThrown);



    });
}

    //} else
    //{
    //    bootbox.alert(GetTitledataLabel('strMsgChkComapnyAndBranch'));
    //}
//}
//function viewReport() {
//    varRptCaptionName = "Employees' Certificates";
//    AddCation = "";

//    //if (($('#selBranch_Id').val() != "-1" && $('#selBranch_Id').val() != null && $('#selBranch_Id').val() != NaN) && ($('#selBranch_Id').val() != "-1" && $('#selBranch_Id').val() != null && $('#selBranch_Id').val() != NaN)) {
//        // var strParamterValue = "005,1,0,@,@,@,@,-1"
//        var strParamterValue = GetDataParamter();

//        debugger;
//        var DTO = {'strParamterValue':strParamterValue,'strRptCaptionName':varRptCaptionName };
//        $.ajax({
//            type: "POST",
//            url: $(location).attr('href') + "/GetDataReport",
//            data: JSON.stringify(DTO),
//            contentType: "application/json",
//            dataType: "json",
//            async: false,
//            success: function (data) {
//                if (data.d != null) {
//                    debugger;

//                    var params = [
//                        'height=' + screen.height,
//                        'width=' + screen.width,
//                        'fullscreen=yes' // only works in IE, but here for completeness
//                    ].join(',');

//                    var popup = window.open(data.d, "open", params);
//                    popup.moveTo(0, 0);
//                }

//            },
//            error: function (XMLHttpRequest, status, error, jqXHR) {
//                //do nothing
//                alert(error);
//               alert(jqXHR.responseText);
//            }

//        });
//    //} else {
//    //    bootbox.alert(GetTitledataLabel('strMsgChkComapnyAndBranch'));
//    //}
//}


function GetDataParamter()
{
    var strdataPara;
    debugger;
    var dataPara = new Array();
    dataPara.push("001");
    dataPara.push("001");
    dataPara.push(0);
    dataPara.push('@');
    dataPara.push('@');
    dataPara.push('@');
    dataPara.push('@');
    dataPara.push('@');
    dataPara.push("-1");

    strdataPara = dataPara[0];

    for (var i = 0; i < dataPara.length; i++)
    {
        if (i > 0)
        {
            debugger;
            strdataPara = strdataPara + "," + dataPara[i];
        }
        
    }

   // alert(strdataPara);
    debugger;
    return strdataPara;
}
