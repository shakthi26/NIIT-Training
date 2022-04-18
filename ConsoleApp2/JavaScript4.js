function GetDateFieldValues(executionContext) {
    try {
        //Get the form contextvar formContext = executionContext.getFormContext();
        //Get value of the field here, Give field logical name here
        var formContext = executionContext.getFormContext();
        var dateOfBirth = formContext.getAttribute("new_dateofbirth").getValue();
        //Get Year
        Xrm.Utility.alertDialog(dateOfBirth);
        //Get Month
    }
    catch (e) {
        Xrm.Utility.alertDialog(e.message);
    }
    finally {
        Xrm.Utility.alertDialog("Advance Happy Birthday");
    }
}

