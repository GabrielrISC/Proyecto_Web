/// <reference path="jquery-3.6.0.min.js" />

function fnJQueryAjax(strTipo, strUrl, strParametros, bolAsync, fnSuccess) {
    $.ajax({
        type: strTipo,
        url: strUrl,
        data: strParametros,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        async: bolAsync,
        success: function (objResultado) {
            fnSuccess(objResultado.d);
            return false;
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            if (errorThrown !== "") {
                console.log("Error:" + errorThrown);
                //alert("Error en Post: " + errorThrown);
                alert("Contacte a personal de IT.");
            }
        }
    });

    return false;
}