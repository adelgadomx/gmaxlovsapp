<%@ Page Title="" Language="C#" MasterPageFile="~/GmxGeneral.Master" AutoEventWireup="true" CodeBehind="GestionarRoles.aspx.cs" Inherits="Presentacion.GestionarRoles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100px
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <section class="content-header">
        <h1 style="text-align:center">Roles de Personas</h1>
    </section>
    <section class="content">
        <!-- BEGIN: Formulario para alta y modificacion -->
        <asp:multiview ID="mvMainRoles" ActiveViewIndex="1" runat="server">
            <asp:View ID="ABrolesView" runat="server">
                <div class="row">
                    <div class="col-mod-6">
                        <div class="box box-primary">
                            <div class="box-body">
                                <div class="form-group">
                                    <label>Descripcion</label>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox ID="txtDescripcion" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row" align="center">
                    <table>
                        <tr>
                            <td>
                                <asp:Button ID="btnRegistrar" runat="server" CssClass="btn btn-primary" Width="200px" Text="Registrar" OnClick="btnRegistrar_Click" />
                            </td>
                            <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                            <td>
                                <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-danger" Width="200px" Text="Cancelar" OnClick="btnCancelar_Click" />
                            </td>
                        </tr>
                    </table>
                </div>
            </asp:View>
            <!--   END: Formulario para alta y modificacion -->
            <br/>
            <!-- BEGIN: Data table registros y acciones -->
            <asp:View ID="DTBrolesView" runat="server">
                <div class="row">
                    <div class="col-xs-12">
                        <div class="box box-primary">
                            <table>
                                <tr>
                                    <td>
                                        <div class="box-header">
                                            <h3 class="box-title">Lista de Roles de personas</h3>
                                        </div>
                                    </td>
                                    <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                    <td>
                                        <asp:Button ID="btnAltaAction" runat="server" CssClass="btn btn-primary" Width="200px" Text="Agregar" OnClick="btnAltaAction_Click" />
                                    </td>
                                </tr>
                            </table>
                            <div class="box-body table-responsive">
                                <table id="tbl_roles" class="table table-bordered table-hover">
                                    <thead>
                                        <tr>
                                            <th>Código</th>
                                            <th>Descripcion</th>
                                            <th>Acciones</th>
                                        </tr>
                                    </thead>
                                    <tbody id="tbl_body_table">
                                        <!-- DATA POR MEDIO DE AJAX-->
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </asp:View>
            <!--   END: Formulario para alta y modificacion -->
            </asp:multiview>
    </section>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
    <script src="js/roles.js" type="text/javascript"></script>
</asp:Content>
