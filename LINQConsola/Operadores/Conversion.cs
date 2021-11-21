using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQDataAccess;
namespace LINQConsola.Operadores
{
    public class Conversion
    {
        public void ConrversionDeTipos()
        {
            using (var db = new CursosVirtualesEntities1())
            {
                // AsEnumerable()


                //var persona = db.Personas.AsEnumerable().Last();

                //Console.WriteLine(persona.Nombre);


                //IEnumerable<IComparable> enteros = new List<IComparable> { 1, 44, 55, 79, 88 };

                //var result = enteros.Cast<int>();

                //foreach (var item in result )
                //{
                //    Console.WriteLine(item);
                //}

                //ArrayList frutas = new ArrayList() { "pera", "manzana" , "uva" , "platano"};

                //IEnumerable<string> stringFrutas = frutas.Cast<string>();

                //foreach (var item in stringFrutas)
                //{
                //    Console.WriteLine(item);
                //}

                //IQueryable<Cursos> cursos = db.Cursos.Take(10);

                //string[] cursoNombre = cursos.Select(c => c.Nombre).ToArray();

                //for (int i = 0; i < cursoNombre.Length; i++)
                //{
                //    Console.WriteLine($"{i}. {cursoNombre[i]}");
                //}



                //ToDictionary()

                //Dictionary<int, string> contientes = db.Continentes.ToDictionary(c => c.ContinenteId, c => c.Nombre);

                //foreach (KeyValuePair<int,string> item in contientes)
                //{
                //    Console.WriteLine($"Key: {item.Key}. Value: {item.Value}");
                //}


                //ToList()

                //string[] dias = new string[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" };

                //List<string> diasLista = dias.ToList();

                //foreach (var item in diasLista)
                //{
                //    Console.WriteLine(item);
                //}

                IQueryable<Personas> personas = db.Personas.Take(10);

                List<Personas> personaLista = personas.ToList();

                foreach (var item in personaLista)
                {
                    Console.WriteLine(item.Nombre);
                }
            }
        }
    }
}
