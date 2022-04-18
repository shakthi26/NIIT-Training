function updatecheckout(primaryControl) {
    var formContext = primaryControl;
    var planned = formContext.getAttribute("shka_plannedcheckoutdate").setValue(new Date());
    var actual = formContext.getAttribute("shka_actualcheckoutdate").setValue(new Date());

    var entity = {};
    entity.subject = "Checkout Done";

    Xrm.WebApi.online.createRecord("task", entity).then(
        function success(result) {
            var newEntityId = result.id;
        },
        function (error) {
            Xrm.Utility.alertDialog(error.message);
        }
    );
}


function roomstatus(context) {
    'use strict'
    debugger;
    var formContext = context.getFormContext();
    var optValue = formContext.getAttribute("shka_roomstatus").getSelectedOption().value;
    var today = new Date();
    if (optValue == 780710000) {
        formContext.getAttribute("shka_checkindate").setValue(today);
    }
    else {
        formContext.getAttribute("shka_plannedcheckoutdate").setValue(today);
        formContext.getAttribute("shka_actualcheckoutdate").setValue(today);
    }
}
