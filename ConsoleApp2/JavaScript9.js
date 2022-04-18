function OnLoadHideFields(executionContext) {
    var formContext = executionContext.getFormContext();
  
 
       formContext.getControl("new_tax").setVisible(false);
        formContext.getControl("new_totaltaxdeduction").setVisible(false);


    

}