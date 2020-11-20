
using System.Web.UI;

namespace PresentacionWEB
{
    public class Utilidades:Page
    {
        public void MsgBox(string pMensaje)
        {
            string msj = "<script language='Javascript'> alert('" + pMensaje + "');</script>";
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "mensaje", msj);

        }
    }
}