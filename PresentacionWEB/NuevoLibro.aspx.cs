using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWEB
{
    public partial class NuevoLibro : Utilidades
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LlenarDatosIniciales();
                LlenarAutores();
            }
        }
        void LlenarDatosIniciales()
        {
            // generos
            Logica.Genero objGenero = new Logica.Genero();
            ddlGeneros.DataSource = objGenero.TraerTodos();
            ddlGeneros.DataValueField = "ID";
            ddlGeneros.DataTextField= "Nombre";
            ddlGeneros.DataBind();
            // editoriales
            Logica.Editorial objEditorial = new Logica.Editorial();
            ddlEditoriales.DataSource = objEditorial.TraerTodos();
            ddlEditoriales.DataValueField = "ID";
            ddlEditoriales.DataTextField = "Nombre";
            ddlEditoriales.DataBind();
            
        }
        void LlenarAutores()
        {
            // autores
            Logica.Autor objAutor = new Logica.Autor();
            gvAutores.DataSource = objAutor.TraerTodos();
            gvAutores.DataBind();
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Entidades.Libro objEntidadLibro = new Entidades.Libro();
            Logica.Libro objLogica = new Logica.Libro();
            // completo el objeto de entidad
            objEntidadLibro.ISBN = txtISBN.Text;
            objEntidadLibro.Titulo = txtTitulo.Text;
            objEntidadLibro.Edicion =Convert.ToInt32(txtEdicion.Text);

            Entidades.Genero objGenero = new Entidades.Genero();
            objGenero.ID = Convert.ToInt32(ddlGeneros.SelectedValue);
            objEntidadLibro.Genero = objGenero;

            Entidades.Editorial objEditorial = new Entidades.Editorial();
            objEditorial.ID = Convert.ToInt32(ddlEditoriales.SelectedValue);
            objEntidadLibro.Editorial = objEditorial;
            // autores
            List<Entidades.Autor> listaAutores = new List<Entidades.Autor>();
            foreach (GridViewRow fila in gvAutores.Rows)
            {
                if (fila.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkRow = (fila.Cells[3].FindControl("SelectCheckBox") as CheckBox);
                    if (chkRow.Checked)
                    {
                        Entidades.Autor objEntidadAutor = new Entidades.Autor();
                        int idAutor = Convert.ToInt32(fila.Cells[0].Text);
                        objEntidadAutor.ID = idAutor;
                        objEntidadAutor.Apellido = fila.Cells[1].Text;
                        listaAutores.Add(objEntidadAutor);
                    }
                }

            }
            
            objEntidadLibro.Autores = listaAutores;
            try
            {
                objLogica.Agregar(objEntidadLibro);
                MsgBox("Libro agregado exitosamente!!");
            }
            catch (Exception ex)
            {

                MsgBox(ex.Message);
            }
        }

        protected void gvAutores_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvAutores.PageIndex = e.NewPageIndex;
            LlenarAutores();
        }
    }
}