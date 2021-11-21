using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola
{
   public  class Cuantificadores
    {
        public void Cuantificar()
        {
            //any
            //int[] numeros = new int[] {2,1 };

            //if (numeros.Any())
            //{
            //    Console.WriteLine($"El arreglo contiene datos: {numeros.Any()}");
            //}
            //else
            //{
            //    Console.WriteLine($"El arreglo no contiene datos:{numeros.Any()}");
            //}

            using (var db = new CursosVirtualesEntities1())
            {
                //string idioma = "frances";
                //bool existenCursos = db.Cursos.Any(c => c.Idioma == idioma);

                //if (existenCursos)
                //{
                //    Console.WriteLine($"Existen cursos en {idioma}");
                //}
                //else
                //{
                //    Console.WriteLine($"No Existen cursos en {idioma}");
                //}

                string[] palabras = new string[] {"america","jopo","europa" };
                //metodo All devuelve un boleano
                bool prueba = palabras.All(p => p.Contains("a"));

                if (prueba)
                {
                    Console.WriteLine($"todas las palabras contienen la letra: a");
                }
                else
                {
                    Console.WriteLine($"No todas las palabras contienen la letra: a");
                }
                //determinar si todos los cursos tinen un precio mayor a $5.00
                bool precios = db.Cursos.All(c => c.Precio >= 5);

                var precio = db.Cursos.All(c => c.Precio >= 10) ? "Correcto" : "Incorrecto";

                if (precios)
                {
                    Console.WriteLine($"Todos los cursos tiene valor superior a $5.00");
                }
                else
                {
                    Console.WriteLine($"No todos los cursos tiene valor superior a $5.00");
                }

                Console.WriteLine($"¿Todos los cursos valen mas de $10.00 ? = {precio}");

                // validar si todos los cursos de ingles  tienen un precio mayor o igual a $20.00

                var precioCursoIngles = db.Cursos.All(c => c.Idioma == "ingles" && c.Precio >= 20) ? "Correcto" : "Incorrecto";
                Console.WriteLine($"¿Todos los cursos de INGLES valen mas de $20.00 ? = {precioCursoIngles}");

                //Contains

                List<Cliente> clientes = new List<Cliente>()
                {
                    new Cliente{Nombre = "Antonio",Fruta = new string[]{"manzana","peras","bananas","caqui"}},
                    new Cliente{Nombre = "Joaquin", Fruta = new string[]{"limon","mandarina","platano"}},
                    new Cliente{Nombre = "Alberto", Fruta = new string[]{"uvas","sandia","manzana"}}
                };

                var clientesManzana = clientes.Where(c => c.Fruta.Contains("manzana"));

                foreach (var item in clientesManzana)
                {
                    Console.WriteLine($"los clientes que contienen manzanas son: {item.Nombre}");
                }
               
            }
        }
    }
    class Cliente
    {
        public string Nombre { get; set; }
        public string[] Fruta { get; set; }
    }


}
