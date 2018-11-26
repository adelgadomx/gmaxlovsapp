var tabla;
var datos;

function addRowDT(data) {
    tabla = $("#tbl_roles").DataTable();
    for (var i = 0; i < data.length; i++) {
        tabla.fnAddData(
            [
                  data[i].IDrol
                , data[i].DErol
                , '<button type="button" value="Actualizar" title="Actualizar" class="btn btn-primary btn-edit"><i  class="fa fa-check-square-o" aria-hidden="true" OnClick="btnRegistrar_Click"></i></button>&nbsp;'
                + '<button type="button" value="Eliminar"   title="Eliminar"   class="btn btn-danger btn-delete"><i class="fa fa-minus-square-o" aria-hidden="true"></i></button>'
            ]);
    }

}

function sendDataAjax() {
    $.ajax({
         type: "POST"
        , url: "GestionarRoles.aspx/ListarRoles"
        , data: {}
        , contentType: "application/json; charset=utf-8"
        , error: function (xhr, ajaxOptions, thrownError) {
            console.log(xhr.status + "\n" + xhr.responseText + "\n" + thrownError);
        }
        , success: function (data) {
            //console.log(data);
            addRowDT(data.d);
        }
    })
}

// Trigger actualizar
$(document).on('click', '.btn-edit', function (e) {
    //e.preventDefault();
    console.log("se hizo click en actualizar");
    //console.log($(this).parent().parent().children().first().text());
    var row = $(this).parent().parent()[0];
    datos = tabla.fnGetData(row);
    console.log(datos[0]);
    fillData();
})

// Trigger borrar
$(document).on('click', '.btn-delete', function (e) {
    e.preventDefault();
    console.log("se hizo click en borrar");
    var row = $(this).parent().parent()[0];
    var datos = tabla.fnGetData(row);
    console.log(datos[0]);
})

function fillData() {
    $("#txtDescripcion").val(datos[1]);
    //$("#mvMainRoles").prop("ActiveViewIndex","0");
}
// Ejecuta el llenado del datatable.
sendDataAjax();