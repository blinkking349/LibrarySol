using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWEB
{
    public partial class VistaPaises : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // se ejecuta por cada request / peticion
            TraerPaises();
        }
        void TraerPaises()
        {
            // invocar al metodo de logica TraerTodos
            Logica.Pais objLogica = new Logica.Pais();
            gvPaises.DataSource = objLogica.TraerTodos();
            gvPaises.DataBind();
        }

        
    }
}