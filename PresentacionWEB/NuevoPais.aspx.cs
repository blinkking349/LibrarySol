using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWEB
{
    public partial class NuevoPais : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            // este codigo se ejecuta cada vez que el usuario haga click
            // en el boton btnConfirmar
            Logica.Pais objLogica = new Logica.Pais();
            Entidades.Pais objEntidad = new Entidades.Pais();
            objEntidad.Nombre = txtNombre.Text;
            objLogica.Agregar(objEntidad);
            lblMensaje.Text = "Pais agregado a la base de datos";
        }
    }
}