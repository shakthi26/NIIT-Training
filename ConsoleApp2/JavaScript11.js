function copyPhoneNo(executionContext) {
    var formContext = executionContext.getFormContext();
    var accountname = formContext.getAttribute("parentcustomerid").getValue;
    if (accountname != null) {

        Xrm.WebApi.online.retrieveRecord("account", "83883308-7ad5-ea11-a813-000d3a33f3b4", "?$select=telephone1").then(
            function success(result) {
                var telephone1 = result["telephone1"];
                formContext.getAttribute("mobilephone").setValue(telephone1);
            },
            function (error) {
                Xrm.Utility.alertDialog(error.message);
            }
        );

    }
};
req.send();