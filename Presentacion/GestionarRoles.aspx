<%@ Page Title="" Language="C#" MasterPageFile="~/GmxGeneral.Master" AutoEventWireup="true" CodeBehind="GestionarRoles.aspx.cs" Inherits="Presentacion.GestionarRoles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <section class="content-header">
        <h1 style="text-align:center">Roles de Personas</h1>
    </section>
    <section class="content">
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
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
