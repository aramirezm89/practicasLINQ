using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    public class Combinacion
    {
        public void Combinaciones()
        {
            IList<Curso> cursos = new List<Curso>()
            {
                new Curso(1,"POO"),
                new Curso(2,"Principios Solid"),
                new Curso(3,"Patrones de Diseño"),
                new Curso(4,"Arquitectura de Software"),
               
            };

            IList<Estudiante> estudiantes = new List<Estudiante>()
            {
                new Estudiante(1,"Juan","Perez",1),
                new Estudiante(2,"Amaro","Pablos",2),
                new Estudiante(3,"Alexandra","Arola",1),
                new Estudiante(4,"Ximena","Pereira",4),
                new Estudiante(5,"Julio","Iglesisas",4),
                new Estudiante(6,"Marina","Acevedo",3),
                new Estudiante(7,"Fermin","CAceres",3),
                new Estudiante(8,"Fabian","Muñoz",1),
            };
            //var unionConsulta = from estudiante in estudiantes
            //                    join curso in cursos
            //                    on estudiante.CursoId equals curso.Id
            //                    select new
            //                    {
            //                        EstudianteID = estudiante.Id,
            //                        Nombres = estudiante.Nombre + " " + estudiante.Apellido,
            //                        Curso = curso.Nombre

            //                    };
            //var unionMetodo = estudiantes.Join(cursos, e => e.CursoId, c => c.Id, (e, c) => new
            //{
            //    EstudianteID = e.Id,
            //    Nombres = e.Nombre + " "+e.Apellido,
            //    Curso = c.Nombre

            //}).OrderBy(e => e.Nombres);


            //foreach (var item in unionConsulta)
            //{
            //    Console.WriteLine($"" +
            //        $"ID: {item.EstudianteID,-5}" +
            //        $"Nombres: {item.Nombres}" +
            //        $"Curso: {item.Curso}"
            //        );
            //}

            //foreach (var item in unionMetodo)
            //{
            //    Console.WriteLine($"" +
            //      $"ID: {item.EstudianteID,-5}" +
            //      $"Nombres: {item.Nombres}" +
            //      $"Curso: {item.Curso}"
            //      );
            //}

            ///////////////////////////////////////////////////////
            /////grooupJoin
            ///

            var groupjoinMetodo = from curso in cursos
                            join estudiante in estudiantes
                            on curso.Id equals estudiante.CursoId
                            into grupoEstudiantes
                            select new
                            {
                                CursoNombre = curso.Nombre,
                                Estudiante = grupoEstudiantes
                            };

            var groupJoinMetodo = cursos.GroupJoin(estudiantes, c => c.Id, e => e.CursoId, (c, e) => 
            new
            {
               CursoNombre = c.Nombre,
               Estudiante = estudiantes
            });

            foreach (var item in groupjoinMetodo)
            {
                Console.WriteLine($"Estudiante en : {item.CursoNombre}");

                foreach (var estudiante in item.Estudiante)
                {
                    Console.WriteLine($"\t{estudiante.Nombre} {estudiante.Apellido}");
                }

                Console.WriteLine(Environment.NewLine);
            }


            foreach (var item in groupjoinMetodo.OrderBy(c => c.CursoNombre))
            {
                Console.WriteLine($"Estudiante en : {item.CursoNombre}");

                foreach (var estudiante in item.Estudiante)
                {
                    Console.WriteLine($"\t{estudiante.Nombre} {estudiante.Apellido}");
                }

                Console.WriteLine(Environment.NewLine);
            }
        }

        
    }

    public class Curso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Curso(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }

    public class Estudiante
    {
       
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int CursoId { get; set; }

        public Estudiante(int id, string nombre, string apellido, int cursoId)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            CursoId = cursoId;
        }


    }
}
