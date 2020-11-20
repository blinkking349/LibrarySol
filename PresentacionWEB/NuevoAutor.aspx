<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NuevoAutor.aspx.cs" Inherits="PresentacionWEB.NuevoAutor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <h2>Nuevo Autor</h2>
    <br />

    <table class="table" style="width: 100%; height: 168px;">
        <tr>
            <td class="modal-sm" style="width: 222px; text-align: right;">
                <asp:Label ID="lblApellido" runat="server" Text="Ingrese Apellido :"></asp:Label>
            </td>
            <td style="width: 280px">
                <asp:TextBox ID="txtApellido" runat="server" Width="254px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ControlToValidate="txtApellido" ErrorMessage="1. El apellido es obligatorio!" Font-Bold="True" ForeColor="#FF3300">1. Campo Obligatorio</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revApellido" runat="server" ControlToValidate="txtApellido" ErrorMessage="No se permiten numeros" Font-Bold="True" ForeColor="#FF3300" ValidationExpression="[A-Za-z]{2-50}" Enabled="False"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 222px; height: 6px; text-align: right;">
                <asp:Label ID="lblNombre" runat="server" Text="Nombre :"></asp:Label>
            </td>
            <td style="height: 6px; width: 280px">
                <asp:TextBox ID="txtNombre" runat="server" Width="254px"></asp:TextBox>
            </td>
            <td style="height: 6px">
                <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre" ErrorMessage="Campo Obligatorio!" Font-Bold="True" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 222px; text-align: right;">
                <asp:Label ID="FechaNacimiento" runat="server" Text="Fecha de Nacimiento :"></asp:Label>
            </td>
            <td style="width: 280px">
                <asp:TextBox ID="txtFechaNac" runat="server" Width="254px"></asp:TextBox>
            </td>
            <td>
                <asp:CompareValidator ID="cvFechaNac" runat="server" ControlToValidate="txtFechaNac" Display="Dynamic" ErrorMessage="3. Formato de Fecha Nacimiento no valido!" Font-Bold="True" ForeColor="#FF3300" Operator="DataTypeCheck" Type="Date">3. Formato no valido!</asp:CompareValidator>
                <asp:RequiredFieldValidator ID="rfvFechaNac" runat="server" ControlToValidate="txtFechaNac" Display="Dynamic" ErrorMessage="Campo Obligatorio!" Font-Bold="True" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="cvNac" runat="server" ControlToValidate="txtFechaNac" ErrorMessage="Error de fecha" Font-Bold="True" ForeColor="#FF3300" Operator="LessThan">La fecha debe ser menor a hoy</asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 222px; text-align: right;">
                <asp:Label ID="lblNacionalidad" runat="server"  Text="Nacionalidad :"></asp:Label>
            </td>
            <td style="width: 280px">
                <asp:DropDownList ID="ddlPaises" runat="server" Width="254px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 222px; text-align: right;">
                <asp:Button CssClass="btn-primary" ID="btnConfirmar" runat="server" Text="Confirmar" OnClick="btnConfirmar_Click" />
            </td>
            <td style="width: 280px">
                <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <div>

        <asp:ValidationSummary ID="vsAutor" runat="server" CssClass="alert-danger" HeaderText="Errores de validacion" Height="95px" ShowMessageBox="True" ShowSummary="False" />

    </div>
</asp:Content>
