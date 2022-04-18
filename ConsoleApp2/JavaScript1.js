function onLoad() {
    if (Xrm.Page.getAttribute("new_cutomername").getValue() == null) {
        Xrm.Page.ui.setFormNotification("Don't forget to put in an account name!", "INFO", "1");
    }
}

function onSave() {
    if (Xrm.Page.getAttribute("new_cutomername").getValue() != null) {
        Xrm.Page.ui.setFormNotification("THANKS!", "INFO", "1");
    }
}
