using System;
using System.Collections.Generic;
using System.Data;

namespace Logica
{
    public class Autor
    {
        // metodos
        public void Agregar(Entidades.Autor autor,List<Entidades.Autor> lista)
        {
            // agrego el objeto autor a la coleccion/lista que recibo
            lista.Add(autor);
        }

        // metodos de acceso a la capa de datos
        public void Agregar(Entidades.Autor autor)
        {
            // invocar al metodo Agregar de la capa de de datos
            // y pasarle el objeto autor
            try
            {
                // reglas de logica
                // nuestra regla:no se admiten nombres que empiecen con P
                if (autor.Nombre.Substring(0,1).ToUpper()=="T")
                {
                    throw new Exception("No se admiten nombres con T");
                }
                Datos.Autor objDatos = new Datos.Autor();
                objDatos.Agregar(autor);
            }
            catch (Exception ex)
            {
                // paso a presentacion la excepcion
                throw new Exception(ex.Message);
                
            }
            
        }
        public DataTable TraerTodos()
        {
            Datos.Autor objDatos = new Datos.Autor();
            return objDatos.TraerTodos();
        }
        public Entidades.Autor TraerxID(int id)
        {
            Datos.Autor objDatos = new Datos.Autor();
            return objDatos.TraerxID(id);
        }
        public void Modificar(Entidades.Autor autor)
        {
            Datos.Autor objDatos = new Datos.Autor();
            objDatos.Modificar(autor);
        }
    }
}
