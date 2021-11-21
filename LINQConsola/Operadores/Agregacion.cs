using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    public class Agregacion
    {
        public void OperadoresAgregacion()
        {
            //Agregate()

            //int[] enteros = new int[] { 1, 4, 87, 6, 24, 9, 41, 9, 36, 82 };
            //int suma = 0;
            //int pares = 0;
            //for (int i = 0; i < enteros.Length; i++)
            //{
            //    if (enteros[i] % 2 == 0)
            //    {
            //        suma += enteros[i];
            //        pares = pares + 1;

            //    }


            //}

            // Console.WriteLine($"{suma} elementos pares:{pares}");
            //int numerosPares = enteros.Aggregate((total, numero) => numero % 2 == 0 ? total + 1  : total);

            //Console.WriteLine(numerosPares);


            //List<int> numeros = new List<int> { 1, 2, 3, 10, 20, 34, 2 };

            //int suma = numeros.Aggregate((resultado, numero) => resultado + numero);

            //int suma2 = numeros.Sum();

            //Console.WriteLine(suma);
            //Console.WriteLine(Environment.NewLine);
            //Console.WriteLine(suma2);


            //var letras = new[] { "l", "i", "n", "q" };
            //var palabra = letras.Aggregate((resultado, letra) => resultado + letra);

            //string nombre = "curso " + palabra ;
            //Console.WriteLine( nombre);
            //Console.WriteLine(Environment.NewLine);



            //Average() calcula promedio de una secuencia numerica

            //List<int> numeros = new List<int> { 1, 2, 3, 10, 20, 34, 2 };

            //var promedio = numeros.Average();

            //for (int i = 0; i < numeros.Count ; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}

            //Console.WriteLine(Math.Round(promedio,2));





            using (var db = new CursosVirtualesEntities1())
            {
                //Count() devuelve el numero de elementos

                //var cursos = db.Cursos.Count(c => c.Idioma.Equals("ingles"));

                //Console.WriteLine(cursos);




                //Max() devuelve el numer maximo de un conjunto de datos
                //var cursoMayorPrecio = db.Cursos.Max(c => c.Precio);
                //var curso = db.Cursos.FirstOrDefault(c => c.Precio == cursoMayorPrecio);



                //    Console.WriteLine($"{curso.Nombre}, precio: {curso.Precio}");



                //Min() devuelve el valor minimo

                //var cursosMenorPrecio = db.Cursos.Min(c => c.Precio);
                //var curso = db.Cursos.Where(c => c.Precio == cursosMenorPrecio);

                //foreach (var item in curso)
                //{
                //    Console.WriteLine($"{item.Nombre}, precio: {item.Precio}");
                //}


                //Sum() suma una secuencia de valores

                var sumaPrecios = db.Cursos.Sum(c => c.Precio);
                var penultimo = db.Continentes.Count() -1;
                var continentes = db.Continentes.AsEnumerable().ElementAt(1);

                Console.WriteLine(continentes.Nombre);
                Console.WriteLine(sumaPrecios.ToString("C2"));

            }
        }
    }
}
