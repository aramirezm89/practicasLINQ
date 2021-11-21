using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    public class Ordenacion
    {
        public void Ordenar()
        {
            //string[] colores = new string[] { "rojo", "amarillo", "azul", "verde", "morado", "naranjo", "negro" };


            //IEnumerable<string> ordenColoresAsc =
            //    from color in colores
            //    orderby color descending
            //    select color;
                
            //foreach (var color in colores)
            //{
            //    Console.WriteLine(color);
            //}
            //foreach (var color in ordenColoresAsc)
            //{
            //    Console.WriteLine(color);

            //}



            using (var db = new CursosVirtualesEntities1())
            {
                IEnumerable<Cursos> listaCurso = /*db.Cursos.OrderByDescending(c => c.Idioma).ThenByDescending(c => c.Nombre) ;*/
                    from curso in db.Cursos
                    orderby curso.Idioma descending, curso.Nombre descending
                    select curso;



                foreach (var curso in listaCurso)
                {
                    Console.WriteLine($"Idioma: {curso.Idioma}, Nombre: {curso.Nombre}, Fecha Registro: {curso.FechaRegistro}");
                }

                var continentes = db.Continentes;

                foreach (var continente in continentes)
                {
                    Console.WriteLine($"ID: {continente.ContinenteId}, NOMBRE: {continente.Nombre}");
                }

                Console.WriteLine("\n");
                var continentesReverse = db.Continentes.AsEnumerable().Reverse();
                foreach (var continente in continentesReverse)
                {
                    Console.WriteLine($"ID: {continente.ContinenteId}, NOMBRE: {continente.Nombre}");
                }
            }

             

        }
    }
}
