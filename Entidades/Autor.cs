using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Autor
    {
        // propiedades
        public int ID { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        // propiedades de navegaciones
        public Pais Pais { get; set; }
        public List<Libro> Libros { get; set; }

    }
}
