using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Fuentes
{
    public class Estudiante
    {
        public Estudiante(string nombre, string apellido, int[] notas)
        {
            Nombre = nombre;
            Apellido = apellido;
            Notas = notas;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int[] Notas { get; set; }


    }
    public class LinqToArrayList
    {
        public void ObtenerEstudiantes()
        {
            ArrayList  arrayListEstudiantes =  new ArrayList();

            arrayListEstudiantes.Add(new Estudiante("Antonio", "Ramirez",new int[] {7,6,5,1,7}));
            arrayListEstudiantes.Add(new Estudiante("Aramando", "Manzanero",new int[] {7,6,5,4,7}));
            arrayListEstudiantes.Add(new Estudiante("Florencia", "Labbe",new int[] {1,1,5,1,7}));
            arrayListEstudiantes.Add(new Estudiante("Magnolia", "Alborada",new int[] {7,7,5,1,7}));
            arrayListEstudiantes.Add(new Estudiante("Fabiola", "Gonzalez",new int[] {1,1,1,1,1}));
            
           var estudiantesAprobados = from Estudiante estudiante in arrayListEstudiantes
                                      orderby  estudiante.Notas.Average() descending
                                      select estudiante;

            foreach (var item in estudiantesAprobados)
            {
                Console.WriteLine(item.Notas.Average() >=4 ?$"Estudiantes Aprobados: {item.Nombre} {item.Apellido}, promedio:{item.Notas.Average()}":$"Estudiantes reprobados: {item.Nombre} {item.Apellido} {item.Notas.Average()}");
            }
        }
    }
}
