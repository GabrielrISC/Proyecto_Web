$('.login').submit(function (eve) {

    eve.preventDefault();
    let _datos = { "usuario": $('#txtUsr').val(), "contrasena": $('#txtContr').val() };
    $.ajax({
        type: 'POST',
        url: 'wsProyecto.asmx/Iniciar_Sesion',
        data: JSON.stringify(_datos),
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        async: true,
        success: function (respuesta) {
            let _valores = JSON.parse(respuesta.d);
            console.log(_valores);
        },
        error: function (XMLHttpRequest, textstatus, errorthrown) {
            console.log(errorthrown);
        }

    });
});