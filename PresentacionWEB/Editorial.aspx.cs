using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWEB
{
    public partial class Editorial :Utilidades
    {
        Logica.Editorial objLogica = new Logica.Editorial();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                TraerTodos();
            }
        }
        void TraerTodos()
        {

            gvDatos.DataSource = objLogica.TraerTodos();
            gvDatos.DataBind();
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            lblID.Text = "Nuevo";
            txtNombre.Focus();
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtNombre.Focus();
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            string strOpcion = lblID.Text;
            switch (strOpcion)
            {
                case "Nuevo":
                    objLogica.Agregar(txtNombre.Text);
                    MsgBox("Editorial agregada!!!");
                    txtNombre.Text = "";
                    break;
                default:
                    int intId = Convert.ToInt32(lblID.Text);
                    objLogica.Modificar(intId, txtNombre.Text);
                    MsgBox("Editorial Modificada!!!");
                    break;
            }
            TraerTodos();
            txtNombre.Enabled = false;

        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            int intId = Convert.ToInt32(lblID.Text);
            objLogica.Borrar(intId);
            TraerTodos();
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void gvDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow filaSeleccionada = gvDatos.SelectedRow;
            lblID.Text = filaSeleccionada.Cells[1].Text;
            txtNombre.Text = filaSeleccionada.Cells[2].Text;

        }
    }
}