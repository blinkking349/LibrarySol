<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NuevoPais.aspx.cs" Inherits="PresentacionWEB.NuevoPais" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <h2>Ingreso de nuevo pais</h2>
    <br />
   
    <table class="table" style="width: 69%; height: 114px;">
        <tr>
            <td style="width: 157px">
                <asp:Label ID="lblNombre" runat="server" Text="Nombre del Pais:"></asp:Label>
            </td>
            <td style="width: 216px">
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre" ErrorMessage="Campo obligatorio!" Font-Bold="True" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 157px">
                <asp:Button ID="btnConfirmar"  CssClass="btn-primary" runat="server" Text="Confirmar" OnClick="btnConfirmar_Click" />
            </td>
            <td style="width: 216px">
                <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>
