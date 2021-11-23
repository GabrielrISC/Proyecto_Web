/// <reference path="../../js/jquery-3.6.0.min.js" />
/// <reference path="../../js/utilerias.js" />

function GetUsuarioFrontEnd() {
    return {
        strNombre: $("#txtNombre").val(),
        strUsuarioId: $("#txtUsuarioId").val(),
        strPassword: $("#strPassword").val(),
        intRolId: $("#intRolId").val(),
        bolEsAdministrador: $("#chkEsAdministrador").val()
    };
}

function GetUsuarioBackEnd(strUsuarioId) {
    var objUsuario;
    fnJQueryAjax("POST", "../Registro.asmx/GetUsuario", "{strUsuarioId:'" + strUsuarioId + "'}", false, function (Usuario) {
        objUsuario = Usuario
    });
    return objUsuario;
}


