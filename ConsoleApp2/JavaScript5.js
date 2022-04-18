function SetTheFieldRequirementLevel(executionContext) {
    try {
        //Get the form context
        var formContext = executionContext.getFormContext();
        //Set as Business Required
        formContext.getAttribute("new_fname").setRequiredLevel("Required");
        formContext.getAttribute("new_lname").setRequiredLevel("Required");
        formContext.getAttribute("new_address").setRequiredLevel("Required");
        formContext.getAttribute("new_selectcountry").setRequiredLevel("Required");
        formContext.getAttribute("new_select_city").setRequiredLevel("Required");
        formContext.getAttribute("new_empsalary").setRequiredLevel("Required");
       

    }
    catch (e) {
        Xrm.Utility.alertDialog(e.message);
    }
}