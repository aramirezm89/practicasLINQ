using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQDataAccess;

namespace LINQConsola.Fuentes
{
    public class LinqToString
    {
        //eliminar spacios de una cadena

        public  string  EliminarEspacios(string cadena)
        {
            var result = cadena.ToLowerInvariant().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Soy result {result}");
            StringBuilder nuevacadena = new StringBuilder();
         
            foreach (var palabra in result)
            {
                nuevacadena.Append(palabra).Append(" ");
              
            }


            return nuevacadena.ToString();
        } 


        //Contar cuantas veces se repite una palabra en un textos
        public static string RepeticionesPalabra(string palabra,string texto)
        {
           

            var fuente = texto.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

            var coincidencias = fuente.Where(p => p.ToLowerInvariant().Equals(palabra.ToLowerInvariant()));

           

            var repeticiones = coincidencias.Count();


            return $"la palabra {palabra} se repite {repeticiones} veces.";
           
        }

        public static void ReordenarListado(string rutaArchivo)
        {
            string[] lineas = File.ReadAllLines(rutaArchivo);

            for (int i = 0; i < lineas.Length; i++)
            {
                Console.WriteLine(lineas[i]);
            }

            Console.WriteLine(Environment.NewLine);

            var consulta = (from linea in lineas
                            let columna = linea.Split(',')
                            orderby columna[2]
                            select columna[2].Trim() + "," + columna[0] + "." + columna[1]).ToArray();


            for (int i = 0; i < consulta.Length; i++)
            {
                Console.WriteLine(consulta[i]+"prueba");
                    
            }

           
           

        }
    }
}
