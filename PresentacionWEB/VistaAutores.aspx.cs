using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWEB
{
    public partial class VistaAutores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!Page.IsPostBack)
            //{
                TraerAutores();
            //}
        }
        void TraerAutores()
        {
            Logica.Autor objLogicaAutor = new Logica.Autor();
            gvAutores.DataSource = objLogicaAutor.TraerTodos();
            gvAutores.DataBind();
        }

        protected void gvAutores_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            // indico nuevo indice de la pagina
            gvAutores.PageIndex = e.NewPageIndex;
            // posiciono en esa pagina
            TraerAutores();
        }

        protected void gvAutores_SelectedIndexChanged(object sender, EventArgs e)
        {
            // detecta que el usuario selecciono una fila
            // y puedo acceder al valor de cualquier columa
            // en este caso al ID , columna 1 ( cells)
            GridViewRow filaSeleccionada = gvAutores.SelectedRow;
            string url = "unAutor.aspx?id=" + filaSeleccionada.Cells[1].Text;
            string strPersonal = "width=350,height=300,top=350,left=300,scrollbars=NO,menubar=NO,titlebar= NO,status=NO,toolbar=NO,directories=no";
            string strScript = string.Format("<script type='text/javascript'>window.open('{0}', 'autor', '{1}');</script>", url, strPersonal);
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "autor", strScript);
            
        }
    }
}