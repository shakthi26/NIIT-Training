var Sdk = window.Sdk || {};
(function () {

    this.changeproductprice = function (executionContext) {
            //Get the form context
            var formContext = executionContext.getFormContext();
            var ProductName = formContext.getAttribute("new_productname").getValue();
            //Set the field value here
            if (ProductName.toLowerCase().search("rice") != -1) {
                formContext.getAttribute("new_productprice").setValue(50);
            }
            if (ProductName.toLowerCase().search("wheat") != -1) {
                formContext.getAttribute("new_productprice").setValue(100);
            }
            if (ProductName.toLowerCase().search("sugar") != -1) {
                formContext.getAttribute("new_productprice").setValue(150);
            }
        }
}).call(Sdk);