using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Genero
    {
        Datos.Genero objDatos = new Datos.Genero();
        public DataTable TraerTodos()
        {
            return objDatos.TraerTodos();
        }
        public void Agregar(string pNombre)
        {
            objDatos.Agregar(pNombre);
        }
        public void Borrar(int pId)
        {
            objDatos.Borrar(pId);
        }
        public void Modificar(int pId, string pNombre)
        {
            objDatos.Modificar(pId, pNombre);
        }

    }
}
