using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Logica
{
    public class Pais
    {
        Datos.Pais objDatos = new Datos.Pais();

        public void Agregar(Entidades.Pais pais)
        {
            objDatos.Agregar(pais);
        }
        public DataTable TraerTodos()
        {
          
            return objDatos.TraerTodos();
        }
    }
}
