<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Generos.aspx.cs" Inherits="PresentacionWEB.Generos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
   <div>
       <table class="table-bordered" style="width: 100%; height: 334px;">
           <tr>
               <td style="width: 420px; height: 229px">
                   <asp:GridView ID="gvDatos" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Height="110px" Width="417px" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gvDatos_SelectedIndexChanged">
                       <AlternatingRowStyle BackColor="White" />
                       <FooterStyle BackColor="#CCCC99" />
                       <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                       <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                       <RowStyle BackColor="#F7F7DE" />
                       <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                       <SortedAscendingCellStyle BackColor="#FBFBF2" />
                       <SortedAscendingHeaderStyle BackColor="#848384" />
                       <SortedDescendingCellStyle BackColor="#EAEAD3" />
                       <SortedDescendingHeaderStyle BackColor="#575357" />
                   </asp:GridView>
               </td>
               <td style="height: 229px; width: 151px">
                   <br />
                   <br />
                   <br />
                   <br />
                   Codigo<br />
                   <br />
                   <asp:Label ID="lblID" runat="server" Text=""></asp:Label>
                   <br />
               </td>
               <td style="height: 229px">
                   <br />
                   <br />
                   <br />
                   <br />
                   Nombre<br />
                   <br />
                   <asp:TextBox ID="txtNombre" runat="server" Enabled="False"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td style="width: 420px">
                   <asp:Button ID="btnNuevo" runat="server" CssClass="btn-primary" Text="Nuevo" Width="132px" OnClick="btnNuevo_Click" />
                   <asp:Button ID="btnModificar" runat="server" CssClass="btn-primary" Text="Modificar" Width="132px" OnClick="btnModificar_Click" />
                   <asp:Button ID="btnConfirmar" runat="server" CssClass="btn-primary" Text="Confirmar" Width="132px" OnClick="btnConfirmar_Click" />
               </td>
               <td style="width: 151px">
                   <asp:Button ID="btnBorrar" CssClass="btn-primary" runat="server" Text="Borrar" OnClick="btnBorrar_Click" />
               </td>
               <td>
                   <strong>
                   <asp:Button ID="btnSalir" CssClass="btn-primary" runat="server" Text="Salir" style="font-weight: bold" Width="167px" OnClick="btnSalir_Click" />
                   </strong>
               </td>
           </tr>
           </table>
   </div>
</asp:Content>


