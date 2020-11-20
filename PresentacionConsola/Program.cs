using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentacionConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            // creo una lista nueva de autores
            List<Entidades.Autor> ListaAutores = new List<Entidades.Autor>();
            // creo una instancia de autor ( entidades )
            Entidades.Autor objEntidadAutor1 = new Entidades.Autor();
            objEntidadAutor1.Apellido = "Perez";
            objEntidadAutor1.Nombre = "Juan";

            Entidades.Pais objPais = new Entidades.Pais();
            objPais.ID = 1;
            
            objEntidadAutor1.Pais = objPais;

            objEntidadAutor1.FechaNacimiento = Convert.ToDateTime("01/01/1999");

            // agregar este autor a la coleccion
            Logica.Autor objLogicaAutor = new Logica.Autor();
            objLogicaAutor.Agregar(objEntidadAutor1, ListaAutores);
            objLogicaAutor.Agregar(objEntidadAutor1);


            // agrego mas autores
            Entidades.Autor objEntidadAutor2= new Entidades.Autor();
            objEntidadAutor2.Apellido = "Mendia";
            objEntidadAutor2.Nombre = "Ignacio";
            objEntidadAutor2.Pais = objPais;
            objEntidadAutor2.FechaNacimiento = Convert.ToDateTime("01/01/1994");
            objLogicaAutor.Agregar(objEntidadAutor2, ListaAutores);
            objLogicaAutor.Agregar(objEntidadAutor2);

            // mostrar lista de autores
            foreach (var a in ListaAutores)
            {
                Console.WriteLine(a.Apellido+", "+a.Nombre);
            }

            Console.ReadKey();
        }

    }
}
