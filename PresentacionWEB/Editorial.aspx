<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Editorial.aspx.cs" Inherits="PresentacionWEB.Editorial" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <br />
    <br />
   <div>
       <table class="table-bordered" style="width: 100%; height: 334px;">
           <tr>
               <td style="width: 420px; height: 229px">
                   <asp:Label ID="lblTitulo" runat="server" Text="Editoriales"></asp:Label>
                   <asp:GridView ID="gvDatos" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" Height="140px" Width="417px" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gvDatos_SelectedIndexChanged" EmptyDataText="No hay datos">
                       <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                       <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                       <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                       <RowStyle BackColor="White" ForeColor="#003399" />
                       <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                       <SortedAscendingCellStyle BackColor="#EDF6F6" />
                       <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                       <SortedDescendingCellStyle BackColor="#D6DFDF" />
                       <SortedDescendingHeaderStyle BackColor="#002876" />
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
