using LINQDataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
   public class Filtrado
    {
        public void Filtrar()
        {
            //string[] palabras = new string[]
            //{
            //   "silla",
            //   "mesa",
            //   "salon",
            //   "tambor",
            //   "sol",
            //   "la"
            //};

            //IEnumerable<string> consulta = palabras.Where(p => p.Length <= 4);

            //foreach (var palabra in consulta)
            //{
            //    Console.WriteLine(palabra);
            //}
            Continentes continente = new Continentes
            {
                ContinenteId = 12,
                Nombre = "Atlantida",
                FechaModificacion = DateTime.Now,
                FechaRegistro = DateTime.Now,
                Estado = true
            };
            ArrayList lista = new ArrayList()
            {
                12,
                "Hola",
                15,
                16,
                continente

            };
            using (CursosVirtualesEntities1 _db = new CursosVirtualesEntities1())
            {
                var paises = _db.Paises.Where(p=> p.Continentes.Nombre.Contains("América") && p.Poblacion > 15000000).OrderBy(p => p.ContinenteId).ThenBy(p => p.Nombre);
                var pruebaOftype = lista.OfType<int>();
                int suma = pruebaOftype.Sum();
              
                foreach (var pais in paises)
                {
                    Console.WriteLine($"Continente: {pais.Continentes.Nombre},Pais: {pais.Nombre}, Capital: {pais.Capital}");
                }
                foreach (var item in pruebaOftype)
                {
                    
                    Console.WriteLine($"elemntos segun tipo usando funcion OfType: {item}");
                }

                Console.WriteLine($"El resultado usando funcion sum es: {suma}");
            };
        }

    }
}
