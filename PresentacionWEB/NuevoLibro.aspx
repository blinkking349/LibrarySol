<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NuevoLibro.aspx.cs" Inherits="PresentacionWEB.NuevoLibro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <br />
        <h2>Ingreso de nuevo libro</h2>
        <table class="table-bordered" style="width: 100%; height: 141px; font-size: large; background-color: #CCFFFF;">
            <tr>
                <td style="width: 296px; text-align: right;">
                    <asp:Label ID="lblISBN" runat="server" Text="Ingrese ISBN(17 caracteres) :"></asp:Label>
                </td>
                <td style="width: 243px">
                    <asp:TextBox ID="txtISBN" runat="server" Width="250px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 296px; text-align: right;">
                    <asp:Label ID="lblTitulo" runat="server" Text="Titulo del libro :"></asp:Label>
                </td>
                <td style="width: 243px">
                    <asp:TextBox ID="txtTitulo" runat="server" Width="250px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 296px; text-align: right;">
                    <asp:Label ID="lblEdicion" runat="server" Text="Edicion :"></asp:Label>
                </td>
                <td style="width: 243px">
                    <asp:TextBox ID="txtEdicion" runat="server" Width="250px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 296px; text-align: right;">
                    <asp:Label ID="lblGenero" runat="server" Text="Genero :"></asp:Label>
                </td>
                <td style="width: 243px">
                    <asp:DropDownList ID="ddlGeneros" runat="server" Width="250px">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 296px; text-align: right;">
                    <asp:Label ID="lblEditoriales" runat="server" Text="Editoriales :"></asp:Label>
                </td>
                <td style="width: 243px">
                    <asp:DropDownList ID="ddlEditoriales" runat="server" Width="250px">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>
    <div>
        <h4>Seleccione Autores</h4>
        <p>
            <asp:GridView ID="gvAutores" runat="server" Width="766px" AutoGenerateColumns="False" AllowPaging="True" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" OnPageIndexChanging="gvAutores_PageIndexChanging">
               <Columns>
                  <asp:BoundField DataField="ID" HeaderText="ID" ItemStyle-Width="150" >
                                <ItemStyle Width="150px"></ItemStyle>
                   </asp:BoundField>
                  <asp:BoundField DataField="Apellido" HeaderText="Apellido" ItemStyle-Width="150" >
                                <ItemStyle Width="150px"></ItemStyle>
                   </asp:BoundField>
                  <asp:BoundField DataField="Nombre" HeaderText="Nombre" ItemStyle-Width="150" >

                                <ItemStyle Width="150px"></ItemStyle>
                   </asp:BoundField>

                <asp:TemplateField HeaderText="Seleccionar">
                     <ItemTemplate>
                         <asp:CheckBox ID="SelectCheckBox" runat="server" />
                     </ItemTemplate>
                </asp:TemplateField>

               </Columns>
            
            
                <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#594B9C" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#33276A" />
            
            
            </asp:GridView>
            <asp:Button ID="btnEnviar" CssClass="btn-primary" runat="server" Text="Enviar" Width="129px" OnClick="btnEnviar_Click" />
        </p>
    </div>

</asp:Content>
