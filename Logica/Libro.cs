using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Libro
    {
        public void Agregar(Entidades.Libro libro)
        {
            try
            {
                Datos.Libro objDatos = new Datos.Libro();
                objDatos.Agregar(libro);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
