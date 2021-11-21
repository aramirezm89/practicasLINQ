using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    public class Generacion
    {

        public void Generar()
        {
            //defaultIfEmpty()

            using(var db = new CursosVirtualesEntities1())
            {
                Cursos cursosPorDefecto = new Cursos
                {
                    CursoId = 0,
                    Nombre = "Sin Curso",
                    Idioma = "Sin idioma",
                    Precio = 0,
                    FechaModificacion = DateTime.MinValue,
                    FechaRegistro = DateTime.MinValue,
                    Estado = false
                };

                //var cursos = db.Cursos.Where(c => c.Precio > 1000).Take(5);

                //foreach (var curso in cursos.AsEnumerable().DefaultIfEmpty(cursosPorDefecto))
                //{
                //    Console.WriteLine($"Id: { curso.CursoId},Nombre: {curso.Nombre}, Idioma: {curso.Idioma}, Precio: {curso.Precio}");
                //}



                //Empty()
                //var vacio = Enumerable.Empty<int>();

                //Console.WriteLine(vacio.Count());




                //Range()

                //var numeros = Enumerable.Range(50, 10);

                //foreach (var item in numeros)
                //{
                //    Console.WriteLine(item);
                //}


                var curso = Enumerable.Repeat(cursosPorDefecto, 5); //primer numero indica el valor que se repetira y el segundo la cantidad de veces que se repetira

                foreach (var item in curso)
                {
                    Console.WriteLine(item.Nombre);
                }

            }

        }
    }
}
