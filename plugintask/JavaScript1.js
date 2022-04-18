function deliverorder(primaryControl) {
    var formContext = primaryControl;
    var rem = formContext.getAttribute("shka_remaining").getValue();
    if (rem == 0) {
        formContext.data.entity.save();
        formContext.getAttribute("shka_status").setValue(780710001);
        
    }
    if (rem > 0) {
        formContext.data.entity.save();
        formContext.getAttribute("shka_status").setValue(780710002);
       
    }
    
}