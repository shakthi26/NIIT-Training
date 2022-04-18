Navigate = {

    navigateToIssueForm: function () {

        var entityFormOptions = {};
        entityFormOptions.entityName = "new_salary";
        entityFormOptions.formId = "B543E639-9624-4556-B02E-C512644A5380";
        entityFormOptions.openInNewWindow = true;


        // Open the form.
        Xrm.Navigation.openForm(entityFormOptions).then(
            function (success) {
                console.log(success);
            },
            function (error) {
                console.log(error);
            });
    }
}
