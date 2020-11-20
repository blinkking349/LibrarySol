using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Autor
    {

        // metodos de acceso a la base de datos
        public void Agregar(Entidades.Autor autor)
        {
            // variable sentencia a ejecutar
            string strSQL = @"Insert into Autores(Apellido,Nombre,FechaNacimiento,IdPais)
                            values(@Apellido,@Nombre,@FechaNacimiento,@IdPais)";
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand objComAgregar = new SqlCommand(strSQL, objConexion);
            objComAgregar.CommandType = CommandType.Text;
            // parametros
            objComAgregar.Parameters.AddWithValue("@Apellido", autor.Apellido);
            objComAgregar.Parameters.AddWithValue("@Nombre", autor.Nombre);
            objComAgregar.Parameters.AddWithValue("@FechaNacimiento", autor.FechaNacimiento);
            objComAgregar.Parameters.AddWithValue("@IdPais", autor.Pais.ID);
            try
            {

                //int a = 0;
                //int b = 30;
                //int c = b / a;
                // abrir la conexion
                objConexion.Open();
                objComAgregar.ExecuteNonQuery();
                
            }
            catch(DivideByZeroException)
            {
                throw new Exception("No se puede dividir por cero!!!");
            }
            catch(SqlException)
            {
                throw new Exception("Error en la comunicacion con el servidor, intente mas tarde");
            }
            catch (Exception ex)
            {
                // el error desaparecio
                // genero un error, y se lo envio a logica
                throw new Exception("Error en la capa de datos!!");
                
            }
            finally
            {
                // se ejecuta siempre
               if(objConexion.State==ConnectionState.Open)
                {
                    objConexion.Close();

                }
            }

        }
        public void Modificar(Entidades.Autor autor)
        {
            // variable con el nombre del sp
            string strProc = "procModificaAutor";
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand objComModificar = new SqlCommand(strProc, objConexion);
            // le indico que strProc, lo tome como un SP
            objComModificar.CommandType = CommandType.StoredProcedure;
            // parametros
            objComModificar.Parameters.AddWithValue("@ID", autor.ID);
            objComModificar.Parameters.AddWithValue("@Apellido", autor.Apellido);
            objComModificar.Parameters.AddWithValue("@Nombre", autor.Nombre);
            objComModificar.Parameters.AddWithValue("@FechaNacimiento", autor.FechaNacimiento);
            objComModificar.Parameters.AddWithValue("@IdPais", autor.Pais.ID);
            // abrir la conexion
            objConexion.Open();
            objComModificar.ExecuteNonQuery();
            objConexion.Close();
        }
        public DataTable TraerTodos()
        {
            DataTable dt = new DataTable();
            string strSQL = "select * from VistaAutores";
            SqlDataAdapter objDaTraer = new SqlDataAdapter(strSQL, Conexion.strConexion);
            objDaTraer.Fill(dt);
            return dt;
        }
        public Entidades.Autor TraerxID(int id)
        {
            Entidades.Autor objAutor = new Entidades.Autor();
            string strSQL = "Select * from Autores where id=" + id;
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand objComTraerUno = new SqlCommand(strSQL, objConexion);
            SqlDataReader drAutor;
            objConexion.Open();
            drAutor = objComTraerUno.ExecuteReader();
            //drAutor.Read(); // lee (o intenta ) el primer regitro del Datareader
            // si encontro un primer registro retorna true y se posiciona en el
            // si no encontro registros retorna False
            if (drAutor.Read())
            {
                objAutor.ID = id;
                objAutor.Apellido = drAutor["Apellido"].ToString();
                objAutor.Nombre = drAutor["Nombre"].ToString();
                objAutor.FechaNacimiento = Convert.ToDateTime(drAutor["FechaNacimiento"]);
                Entidades.Pais objPais = new Entidades.Pais();
                objPais.ID = Convert.ToInt32(drAutor["IdPais"]);
                objAutor.Pais = objPais;

            }
            else
            {
                objAutor.Apellido = "Autor Desconocido";
            }
            objConexion.Close();
            return objAutor;

        }
    }
}
