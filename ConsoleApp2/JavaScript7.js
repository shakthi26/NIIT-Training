function ShowHideFields(executionContext) {
    var formContext = executionContext.getFormContext();
    var databaseValue = formContext.getAttribute("new_empsalary").getValue();
    if (databaseValue >= 80000) {
        formContext.getControl("new_tax").setVisible(true);
        formContext.getControl("new_totaltaxdeduction").setVisible(true);
    }
    else {
        formContext.getControl("new_tax").setVisible(false);
        formContext.getControl("new_totaltaxdeduction").setVisible(false);


    }

}