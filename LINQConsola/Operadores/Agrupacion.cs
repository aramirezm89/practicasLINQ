using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LINQConsola.Operadores
{
    public class Agrupacion
    {
        public void Agrupaciones()
        {
            //List<int> numeros = new List<int>()
            //{
            //    1,45,78,54,65,99,13,75,68,74,11
            //};

            //var grupos1 = numeros.GroupBy(e => e %2 );

            //foreach (var item in grupos1)
            //{
            //    if (item.Key %2 == 0)
            //    {
            //        Console.WriteLine($"Numeros Pares");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Numeros impares");
            //    }

            //    foreach (var numero in item)
            //    {
            //        Console.WriteLine($"\t{numero}");
            //    }

            //    Console.WriteLine(Environment.NewLine);
            //}

            /*
               Agrupar los cursos por 3 rangos de precio:

                 (barato 0 - ,9.99, promedio 10 - 24.99, caro > 25
             */

            using(var db = new CursosVirtualesEntities1())
            {
                var grupos = db.Cursos.ToList().GroupBy(c =>
                {
                    if(c.Precio <=9.99)
                    {
                        return "$0.00 - 0.99 (barato)";
                    }else if(c.Precio <=24.99)
                    {
                        return "$10.00 - 24.99 (promedio)";
                    }
                    else
                    {
                        return "$25.00... (caro)";
                    }

                }).OrderBy(c => c.Key);

                foreach (var item in grupos)
                {
                    Console.WriteLine($"cursos con precio entre {item.Key}: {item.Count()}");

                    foreach (var curso in item)
                    {
                        Console.WriteLine($"\t{curso.Nombre}: {curso.Precio.ToString("C2")}");
                    }
                }

                Console.WriteLine(Environment.NewLine);

                //agrupar personas por pais

                var grupoPaises = db.Personas.GroupBy(p => p.Paises.Nombre);

                foreach (var item in grupoPaises)
                {
                    Console.WriteLine($"{item.Key}:{item.Count()}");


                    foreach (var persona in item)
                    {
                        Console.WriteLine($"\t{persona.Nombre} {persona.Apellido}");
                    }
                }
                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}
