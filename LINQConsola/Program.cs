using LINQConsola.Operadores;
using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQConsola.Fuentes;

namespace LINQConsola
{
    class Program
    {
        private readonly CursosVirtualesEntities1 _db;
       
        static void Main(string[] args)
        {




            //    int[] numeros = { 1, 23, 45, 6, 7, 2, 4 };
            //    int suma = 0;

            //    using (var _db = new CursosVirtualesEntities())
            //    {
            //        IEnumerable<Cursos> cursos = from curso in _db.Cursos select curso;

            //        Console.WriteLine();
            //        foreach (var curso in cursos)
            //        {


            //            Console.WriteLine($"ID: {curso.CursoId}, nombre: {curso.Nombre}");

            //        }
            //    }

            //    IEnumerable<int> consultaNumero =
            //        from numero in numeros
            //        where (numero % 2 == 0)
            //        select numero;
            //    foreach (var numero in consultaNumero)
            //    {
            //        suma += numero;
            //        Console.WriteLine($"pares: {numero}");
            //    }
            //    Console.WriteLine($"La sunma de numeros pares es: {suma}");



            //    IEnumerable<int> SintaxisMetodo = numeros.Where(n => n % 2 == 0).OrderBy(n => n);

            //    foreach (var numero in SintaxisMetodo)
            //    {
            //        Console.WriteLine($"Nummeros pares usando sintaxis metodo {numero}");
            //    }

            //    int sumaNumerosArray =
            //   (from numero in numeros
            //    where (numero % 2 == 0)
            //    select numero).Sum();
            //    Console.WriteLine($"EL resultado funcion Sum es  {sumaNumerosArray}");

            //    int cantidadElementos =
            //(from numero in numeros
            // where (numero % 2 == 0)
            // select numero).Count();
            //    Console.WriteLine($"EL resultado funcion Count es  {cantidadElementos}");

            //    int cantidadElemtos2 = numeros.Where(n => n % 2 == 0).Count();
            //    Console.WriteLine($"EL resultado funcion Count usando metodos es  {cantidadElemtos2}");
            //    int id = numeros.FirstOrDefault(n => n == 1);
            //    Console.WriteLine($"ID asignado con firstOrDefault {id}");

            //    int numeroMinimoArray =
            //    (from numero in numeros
            //     select numero).Min();
            //    Console.WriteLine($"EL resultado funcion Min es  {numeroMinimoArray}");

            //    IEnumerable<int> listaAray =
            //      (from numero in numeros
            //       where (numero %2 !=0)
            //       select numero).ToList();

            //    Console.WriteLine($"El elemento en la pocision 3 usando funcion ElementAt es: {listaAray.ElementAt(3)}");


            //Ordenacion orden = new Ordenacion();

            //orden.Ordenar();

            //new Conjuntos().Conjunto();

            //new Filtrado().Filtrar();



            //Prueba post = new Prueba();
            ////post.Agregar();
            ////post.Eliminar(8);

            //new Cuantificadores().Cuantificar();
            //Proyeccion proyeccion = new Proyeccion();
            //proyeccion.Proyectar();
            //proyeccion.ManyMetodo();
            //new Particionado().Particionar();

            //new Combinacion().Combinaciones();
            //new Agrupacion().Agrupaciones();
            //new Generacion().Generar();
            //new Igualdad().DeIgualdad();
            //new Elementos().Elemento();
            //new Conversion().ConrversionDeTipos();
            //new Concatenacion().Concatenar();
            //new Agregacion().OperadoresAgregacion();



            //PRACTICA

            //var cadena = "Bienvenidos           al   curso   LINQ";

            //Console.WriteLine(new LinqToString().EliminarEspacios(cadena));

            //string text = "Un texto es una composición de signos codificados en un sistema de escritura que forma una unidad de sentido. También es una composición de caracteres imprimibles generados por un algoritmo de cifrado que, aunque no tienen sentido para cualquier persona,";
            //var repeticiones = LinqToString.RepeticionesPalabra("es", text);

            //Console.WriteLine(repeticiones);



            //LinqToString.ReordenarListado("../../Archivos/Listado.csv");

            //var ensamblado = new LinqToReflection("MiLibreria");


            //ensamblado.getInfo();

            //LinqToFileDirectories.BuscarArchivosDirectorio(@"C:\Users\metal\Downloads", ".rar");
            //LinqToFileDirectories.ObtenerTotalBytesCarpeta(@"C:\Users\metal\Downloads");
            //LinqToFileDirectories.BuscarTextoEnArchivos("../../Archivos/", "cursoLINQ", ".txt");

            //LinqToObject.LinqConObjetos();


            //new LinqToArrayList().ObtenerEstudiantes();

            //LinqToSql.Agregar();
            //LinqToSql.Actualizar(125);
            LinqToSql.Eliminar(125);

           

            Console.ReadKey();

        }





    }

   
}
