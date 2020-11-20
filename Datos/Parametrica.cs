using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
    public class Parametrica
    {
        public enum Tipos
        {
            Alta,
            Baja,
            Modificacion,
            Traer
        }
        private string tabla;
        public Parametrica(string pTabla)
        {
            tabla = pTabla;
        }
        public DataTable TraerTodos()
        {
            DataTable dt = new DataTable();
            string strProc = "ProcTraer";
            SqlDataAdapter da = new SqlDataAdapter(strProc, Conexion.strConexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@Tabla", tabla);
            da.Fill(dt);
            return dt;
        }
        public void Agregar(string nombre)
        {
            Operacion("ProcAlta", Tipos.Alta, 0, nombre);
        }
        public void Modificar(int id,string nombre)
        {
            Operacion("ProcModifica", Tipos.Modificacion, id, nombre);
        }
        public void Borrar(int id)
        {
            Operacion("ProcBaja", Tipos.Baja, id, "");
        }
        public void Operacion(string sp, Tipos tipo, int id, string nombre)
        {
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand com = new SqlCommand(sp, objConexion);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Tabla", tabla);
            switch (tipo)
            {
                case Tipos.Alta:
                    com.Parameters.AddWithValue("@Nombre", nombre);
                    break;
                case Tipos.Baja:
                    com.Parameters.AddWithValue("@Id", id);
                    break;
                case Tipos.Modificacion:
                    com.Parameters.AddWithValue("@Id", id);
                    com.Parameters.AddWithValue("@Nombre", nombre);
                    break;
                default:
                    break;
            }
            objConexion.Open();
            com.ExecuteNonQuery();
            objConexion.Close();
        }

    }
}
