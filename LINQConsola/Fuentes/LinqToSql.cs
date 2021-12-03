using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Fuentes
{
    public  class LinqToSql
    {
        //agregar()

        public static void Agregar()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["LINQConsola.Properties.Settings.CursosVirtualesConnectionString"].ToString();
            LINQtoSQLDataContext db = new LINQtoSQLDataContext(connectionString);

            Cursos nuevoCurso = new Cursos
            {
                Nombre = "Aprendiendo Linq to SQL",
                Idioma = "español",
                Precio = 45.99,
                FechaModificacion = DateTime.UtcNow,
                FechaRegistro = DateTime.UtcNow,
                Estado = true
            };

            db.Cursos.InsertOnSubmit(nuevoCurso);

            db.SubmitChanges();

            var cursoInsertado = db.Cursos.Where(c => c.Nombre.Equals("Aprendiendo Linq to SQL")).FirstOrDefault();

            Console.WriteLine($"El curso {cursoInsertado.Nombre} ha sido insertado correctamente.");
        }
          
       //actualizar()

        public static void Actualizar(int id)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["LINQConsola.Properties.Settings.CursosVirtualesConnectionString"].ToString();
            LINQtoSQLDataContext db = new LINQtoSQLDataContext(connectionString);

            Cursos curso = db.Cursos.Where(c => c.CursoId == id).FirstOrDefault();

            curso.Nombre = "Trabajando Solo SQL";
            curso.Precio = 250.99;
            curso.FechaModificacion = DateTime.UtcNow;

            db.SubmitChanges();

            var cursoActualziado = db.Cursos.Where(c => c.Nombre.Equals("Trabajando Solo SQL")).FirstOrDefault();

            Console.WriteLine($"El curso se actualizo correctamente: {cursoActualziado.Nombre}, {cursoActualziado.Precio}");
             
        }

        public static void Eliminar(int id)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["LINQConsola.Properties.Settings.CursosVirtualesConnectionString"].ToString();
            LINQtoSQLDataContext db = new LINQtoSQLDataContext(connectionString);

            var curso = db.Cursos.Where(c => c.CursoId == id).FirstOrDefault();

            db.Cursos.DeleteOnSubmit(curso);

            db.SubmitChanges();

            Console.WriteLine($"Curso eliminado correctamente {curso.Nombre} ");
        }

    }
}
