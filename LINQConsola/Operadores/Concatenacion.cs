using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQDataAccess;

namespace LINQConsola.Operadores
{
    public class Concatenacion
    {
        public void Concatenar()
        {
            using(var db = new CursosVirtualesEntities1())
            {
                var instructores = db.Personas.Take(10).Where(p => p.TipoPersona.Equals("instructor"));

                var estudiantes = db.Personas.Where(p => p.TipoPersona.Equals("estudiante")).Take(10);



                foreach (var instructor in instructores)
                {
                    Console.WriteLine($"{instructor.Nombre} {instructor.Apellido}");
                }

                Console.WriteLine(Environment.NewLine);

                foreach (var estudiante in estudiantes)
                {
                    Console.WriteLine($"{estudiante.Nombre} {estudiante.Apellido}");

                }

                Console.WriteLine(Environment.NewLine);

                var concatenar = instructores.Concat(estudiantes);

                foreach (var item in concatenar.OrderBy(c => c.TipoPersona))
                {
                    Console.WriteLine($"{item.Nombre} {item.Apellido} - {item.TipoPersona}");
                }

                Console.WriteLine(Environment.NewLine);

                var concatenar2 = instructores.Select(i => i.Nombre).Concat(estudiantes.Select(e => e.Nombre));

                foreach (var item in concatenar2)
                {
                    Console.WriteLine($"{item}");
                }

            }
        }
    }
}
