<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UnAutor.aspx.cs" Inherits="PresentacionWEB.UnAutor" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">

  <script type="text/javascript">
  function cerrar(){
      window.close();
      window.opener.location.reload();
    
  }
</script>

    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 175px;
        }
        .auto-style3 {
            width: 81%;
        }
        .auto-style4 {
            width: 6px;
        }
        .auto-style5 {
            width: 270px;
        }
        .auto-style6 {
            width: 68px;
        }
    </style>
</head>
<body>
    <p>
        <br />
        MODIFICACION DE AUTOR</p>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style3">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="ID:"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="lblID" runat="server" Text=""></asp:Label>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label2" runat="server" Text="Apellido :"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Text="Nombre :"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label4" runat="server" Text="Fecha :"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label5" runat="server" Text="Pais :"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtPais" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar" OnClick="btnConfirmar_Click" />
                    <input id="Button1" type="button" value="volver" onclick="cerrar()" class="auto-style6" /></td>
                <td class="auto-style5">
                    <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
  </body>
</html>

