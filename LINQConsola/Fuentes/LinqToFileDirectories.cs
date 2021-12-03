using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Fuentes
{
    public class LinqToFileDirectories
    {
        //buscar archivos por extensión en un directorio
        public static void BuscarArchivosDirectorio(string carpeta, string formato)
        {
            DirectoryInfo directorio = new DirectoryInfo(carpeta);

            IEnumerable<FileInfo> listadoArchivos = directorio.GetFiles("*.*", SearchOption.AllDirectories);

            IEnumerable<FileInfo> query = from archivo in listadoArchivos
                                          where archivo.Extension.Equals(formato)
                                          orderby archivo.Name
                                          select archivo;

            if (query.Any())
            {
                Console.WriteLine($"Se encontraron {query.Count()} archivos");
                int i = 1;

                foreach (FileInfo archivo in query)
                {
                    Console.WriteLine($"{i++}{archivo.FullName} - [{archivo.CreationTime}]");
                }
            }
            else
            {

            }
        }

        //Obtener el total de Bytes de un conjunto de carpetas

        public static void ObtenerTotalBytesCarpeta(string carpeta)
        {
            var listaArchivo = Directory.GetFiles(carpeta, "*.*", SearchOption.AllDirectories);

            var query = (from archivo in listaArchivo
                         select ObtenerLongitudArchivos(archivo)).ToArray();


            long totalBytes = query.Sum();

            Console.WriteLine($"Hay {totalBytes.ToString("C0")} bytes en {listaArchivo.Count()} archivos dentro de {carpeta}");


        }

        private static long ObtenerLongitudArchivos(string archivo)
        {
            long longitud;

            try
            {
                FileInfo file = new FileInfo(archivo);

                longitud = file.Length;
            }
            catch (FileNotFoundException)
            {

                longitud = 0;
            }

            return longitud;
        }


        //buscar una cadena de texto en un directorio de archivos

        public static void BuscarTextoEnArchivos(string carpeta, string terminoBusqueda, string formato)
        {
            DirectoryInfo directorio = new DirectoryInfo(carpeta);
            IEnumerable<FileInfo> listaArchivos = directorio.GetFiles("*.*", SearchOption.AllDirectories);

            var query = from archivo in listaArchivos
                        where archivo.Extension.Equals(formato)
                        let contenidoArchivo = BuscarEnElArchivo(archivo.FullName)
                        where contenidoArchivo.Contains(terminoBusqueda)
                        select archivo.FullName;

            if (query.Any())
            {
                Console.WriteLine($"El termino {terminoBusqueda} fue encontrado en:\n ");

                foreach (var fileName in query)
                {
                    Console.WriteLine(fileName);
                }
            }
            else
            {
                Console.WriteLine($"El termino {terminoBusqueda} no fue encontrado");
            }
        
        }

        private static string BuscarEnElArchivo(string nombre)
        {
            string fileContents = string.Empty;

            if (File.Exists(nombre))
            {
                fileContents = File.ReadAllText(nombre);    
            }

            return fileContents;    
        }
    }
}
