using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Datos
{
    public class Pais
    {
        public void Agregar(Entidades.Pais pais)
        {
            string strSQL ="Insert into Paises(Nombre) values(@Nombre)";
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand objComAgregar = new SqlCommand(strSQL, objConexion);
            objComAgregar.Parameters.AddWithValue("@Nombre", pais.Nombre);
            objConexion.Open();
            objComAgregar.ExecuteNonQuery();
            objConexion.Close();

        }
        public DataTable TraerTodos()
        {
            DataTable dt = new DataTable();
            // llenar con datos el dt
            string strSQL = "select * from paises";
            // clase para conectarse y ejecutar una sentencia de sql y luego desconectrase
            // SqlDataAdapter
            SqlDataAdapter objDaTraer = new SqlDataAdapter(strSQL, Conexion.strConexion);
            objDaTraer.Fill(dt);
            return dt;
        }
    }
}
