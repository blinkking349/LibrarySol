using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWEB
{
    public partial class UnAutor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // recuperar el valor del id de autor que envio VistaAutores
                int intID = Convert.ToInt32(Request.QueryString["id"]);
                // invoco al metodo de logica TraerxID
                Logica.Autor objLogica = new Logica.Autor();
                Entidades.Autor objAutor = new Entidades.Autor();
                objAutor = objLogica.TraerxID(intID);


                lblID.Text = objAutor.ID.ToString();
                txtApellido.Text = objAutor.Apellido;
                txtNombre.Text = objAutor.Nombre;
                txtFecha.Text = objAutor.FechaNacimiento.ToString();
                txtPais.Text = objAutor.Pais.ID.ToString();

            }
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            // llamar al metodo de logica
            Logica.Autor objLogica = new Logica.Autor();
            Entidades.Autor objEntidad = new Entidades.Autor();
            // asigno las propiedades
            objEntidad.ID =Convert.ToInt32(lblID.Text);
            objEntidad.Apellido = txtApellido.Text;
            objEntidad.Nombre = txtNombre.Text;
            objEntidad.FechaNacimiento = Convert.ToDateTime(txtFecha.Text);
            Entidades.Pais objPais = new Entidades.Pais();
            objPais.ID = Convert.ToInt32(txtPais.Text);
            objEntidad.Pais = objPais;
            objLogica.Modificar(objEntidad);
            lblMensaje.Text = "Datos del autor modificados";

        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            // Response.Redirect("VistaAutores.aspx",false);
           
        }
    }
}