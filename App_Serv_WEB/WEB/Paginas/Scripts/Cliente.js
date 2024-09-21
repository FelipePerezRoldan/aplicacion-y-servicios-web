jQuery(function () {
    //Registrar los botones para responder al evento click
    $("#dvMenu").load("../Paginas/Menu.html")
});

async function Consultar()
{
    let Documento = $("#txtDocumento").val();
    try {
        const Resultado = await fetch("http://localhost:59788/api/Clientes/ConsultarDocumento?Documento=" + Docuento,
            {

                method: "GET",
                mode: "cors",
                headers: { "Content-Type": "application/json" }
            });
        const Respuesta = await Resultado.json();
        $("#txtNombre").val(Respuesta.Nombre);
        $("#txtPrimerApellido").val(Respuesta.PrimerApellido);
        $("#txtSegundoApellido").val(Respuesta.SegundoApellido);
        $("#txtEmail").val(Respuesta.Email);
        $("#txtDireccion").val(Respuesta.Direccion);
        $("#txtFechaNacimiento").val(Respuesta.FechaNacimiento);
    }
    catch (error) {
        $("#dvMesaje").html(error);
    }
}