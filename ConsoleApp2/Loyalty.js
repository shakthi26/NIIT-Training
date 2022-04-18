$(document).ready(function () {
    // To get loggedin user guid
   
    var card = '{{ user.cr207_cardtype}}';

   
    $("#shka_cardused").val(card);
    onChangeofProductpoints();
    onChangeofProduct();
    onChangeofQuantity();
});


function onChangeofProductpoints() {
    $("#shka_productcategory").change(function () {
        debugger;

        var domain = "https://" + document.domain;
        var contactid = $('#shka_productcategory').val();
        if (contactid != undefined && contactid != "" && contactid != null) {
            var domain = "https://" + document.domain;
            var serverUrl = domain;
            var ODATA_ENDPOINT = "/_odata";
            var ODATA_EntityCollection = "/productcategorySet";
            var QUERY = "(guid'" + contactid + "')?";
            QUERY += "$select=shka_pointstobeearned";
            var URL = serverUrl + ODATA_ENDPOINT + ODATA_EntityCollection + QUERY;
            $.ajax({
                type: "GET",
                contentType: "application/json; charset=utf-8",
                datatype: "json",
                url: URL,
                beforeSend: function (XMLHttpRequest) {
                    XMLHttpRequest.setRequestHeader("Accept", "application/json");
                },
                async: false,
                success: function (data, textStatus, XmlHttpRequest) {
                    var EmailObject = data.d;
                    var lookupVal = new Array();
                    var pointstobeearn = data.shka_pointstobeearned;
                    if (pointstobeearn != null) {
                        $("#shka_productcategorypoints").val(pointstobeearn);
                    }
                },
                error: function (XmlHttpRequest, textStatus, errorThrown) {
                }
            });
        }
    });
}

function onChangeofProduct() {
    $("#shka_product").change(function () {
        debugger;

        var domain = "https://" + document.domain;
        var contactid = $('#shka_product').val();
        if (contactid != undefined && contactid != "" && contactid != null) {
            var domain = "https://" + document.domain;
            var serverUrl = domain;
            var ODATA_ENDPOINT = "/_odata";
            var ODATA_EntityCollection = "/Default";
            var QUERY = "(guid'" + contactid + "')?";
            QUERY += "$select=shka_p_price";
            var URL = serverUrl + ODATA_ENDPOINT + ODATA_EntityCollection + QUERY;
            $.ajax({
                type: "GET",
                contentType: "application/json; charset=utf-8",
                datatype: "json",
                url: URL,
                beforeSend: function (XMLHttpRequest) {
                    XMLHttpRequest.setRequestHeader("Accept", "application/json");
                },
                async: false,
                success: function (data, textStatus, XmlHttpRequest) {
                    var EmailObject = data.d;
                    var lookupVal = new Array();
                    var price = data.shka_p_price;
                    if (price != null) {
                        $("#shka_price").val(price);

                    }
                },
                error: function (XmlHttpRequest, textStatus, errorThrown) {
                }
            });
        }
    });
}



function onChangeofQuantity() {
    $("#shka_quantity").change(function () {
        debugger;
        var qnty = $("#shka_quantity").val();
        var price = $("#shka_price").val();

        var tltprice = qnty * price;
        $("#shka_total_price").val(tltprice);

        var earned = $("#shka_productcategorypoints").val();
        var points = (tltprice * earned) / 100;//2 2 = 4 
        $("#shka_pointsearned").val(points);

    });
}
