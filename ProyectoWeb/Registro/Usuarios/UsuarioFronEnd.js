/// <reference path="usuarios.js" />
function CargarInformacion() {

    var objUsuario = GetUsuarioBackEnd($("#txtUsuarioId").val());


}
function PostUsuarioBackEnd() {
    var objUsuario = GetUsuarioFrontEnd();
    fnJQueryAjax("POST", "../Registro.asmx/PostUsuario", "{objUsuario:" + JSON.stringify(objUsuario) + "}", false, function (Usuario) {
        objUsuario = Usuario
    });
    return objUsuario;
}