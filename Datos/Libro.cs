using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Libro
    {
        public void Agregar(Entidades.Libro libro)
        {
            string strProc = "ProcAltaLibro";
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand objCom = new SqlCommand(strProc, objConexion);
            objCom.CommandType = CommandType.StoredProcedure;
            // parametros
            objCom.Parameters.AddWithValue("@ISBN", libro.ISBN);
            objCom.Parameters.AddWithValue("@Titulo", libro.Titulo);
            objCom.Parameters.AddWithValue("@Edicion", libro.Edicion);
            objCom.Parameters.AddWithValue("@IdGenero", libro.Genero.ID);
            objCom.Parameters.AddWithValue("@IdEditorial", libro.Editorial.ID);
            // 6to parametros con los id de los autores
            
            // creo un DataTable para enviar al SP
            DataTable dtAutores = new DataTable();
            DataColumn IdAutor = dtAutores.Columns.Add("IdAutor", typeof(int));
            // recorro la lista de autores de ese libro, tomar el id
            // y agregarlo a una fila del dataTable

            foreach (var a in libro.Autores)
            {
                // creo una nueva fila en blanco para el datatable
                DataRow fila = dtAutores.NewRow();
                // completo el valor con el ID
                fila["IdAutor"] = a.ID;
                // agrego a la coleccion de filas(Rows)
                dtAutores.Rows.Add(fila);
            }
            SqlParameter paramAutores = new SqlParameter();
            paramAutores.Direction = ParameterDirection.Input;
            paramAutores.ParameterName = "@Autores";
            paramAutores.SqlDbType = SqlDbType.Structured;
            paramAutores.Value = dtAutores;
            objCom.Parameters.Add(paramAutores);
            try
            {
                objConexion.Open();
                objCom.ExecuteNonQuery();
                objConexion.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }
    }
}
