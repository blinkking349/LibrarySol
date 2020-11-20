using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWEB
{
    public partial class NuevoAutor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cvNac.ValueToCompare = DateTime.Today.ToShortDateString();
                TraerPaises();
            }
        }
        void TraerPaises()
        {
            // invocar al metodo de logica TraerTodos
            Logica.Pais objLogica = new Logica.Pais();
            ddlPaises.DataSource = objLogica.TraerTodos();
            // campo del select a mostrar
            ddlPaises.DataTextField = "Nombre";
            // valor de que campo guardar
            ddlPaises.DataValueField = "ID";
            ddlPaises.DataBind();
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            // validacion en el servidor
            if (Page.IsValid)
            {
                // todos los controles validadores
                // estan OK
                //lblMensaje.Text = "Datos Validados
                Logica.Autor objLogicaAutor = new Logica.Autor();
                Entidades.Autor objEntidadAutor = new Entidades.Autor();
                objEntidadAutor.Apellido = txtApellido.Text;
                objEntidadAutor.Nombre = txtNombre.Text;
                objEntidadAutor.FechaNacimiento =Convert.ToDateTime(txtFechaNac.Text);
                Entidades.Pais objEntidadPais = new Entidades.Pais();
                objEntidadPais.ID =Convert.ToInt32(ddlPaises.SelectedValue);
                objEntidadAutor.Pais = objEntidadPais;
                try
                {
                    objLogicaAutor.Agregar(objEntidadAutor);
                    lblMensaje.Text = "Autor ingresado a la base de datos!";
                }
                catch (Exception ex)
                {

                    lblMensaje.Text = ex.Message;
                }
               
            }
            else
            {
                // alguno de los controles dio False
                lblMensaje.Text = "Datos NO Validados!!";
            }
        }
    }
}