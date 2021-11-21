using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace LINQConsola
{
    public class Proyeccion
    {
        public void Proyectar()
        {
            //metodo select

            using (var db = new CursosVirtualesEntities1())
            {

                var personasNombre = db.Personas.Where(p => p.TipoPersona == "instructor").Select(p => p.Nombre + "," + p.Apellido).ToList();
                var personasDatos = db.Personas.Where(p => p.Paises.Nombre.Equals("Colombia"))
                                    .OrderByDescending(p => p.PersonaId)
                                    .Select(p => new
                                    {
                                        Id = p.PersonaId,
                                        Nombres = p.Nombre + " " + p.Apellido,
                                        Email = p.CorreoElectronico,
                                        Pais = p.Paises.Nombre,
                                        Continente = p.Paises.Continentes.Nombre,


                                    }).ToList()
                                    .Select(p => new Personas
                                    {
                                        PersonaId = p.Id,
                                        Nombre = p.Nombres,
                                        CorreoElectronico = p.Email,
                                        Paises = new Paises() { Nombre = p.Pais, Continentes = new Continentes() { Nombre = p.Continente } },



                                    }).ToList();


                foreach (var persona in personasDatos)
                {


                    Console.WriteLine($"ID: {persona.PersonaId}\t\t" +
                                 $"Nombres: {persona.Nombre,-20}\t" +
                                 $"Correo: {persona.CorreoElectronico,-10}\t\t" +
                                 $"Pais: {persona.Paises.Nombre,-10}\t" +
                                 $"Continente: {persona.Paises.Continentes.Nombre}\t");


                };


            }


        }

        public void ManyMetodo()
        {
            //metodo SelectMany() combina los elmentos de distintas estructuras como arreglos en una sola estructura

            var letras = new[] { "a,b,c", "e,f,", "g,h,i" };




            //for (int i = 0; i < letras.Length; i++)
            //{
            //    Console.WriteLine(letras[i]);
            //}

            var letrasCombinadas = letras.SelectMany(letra => letra.Split(','));

            foreach (var item in letrasCombinadas)
            {
                Console.Write(item);
            }

            var escuelas = new Escuela[]
            {
                new Escuela()
                {
                    Estudiantes = new Estudiante[]
                    {
                        new Estudiante{Nombre = "Julio"},
                        new Estudiante{Nombre = "Antonio"},
                        new Estudiante{Nombre = "Alberto"}
                    }
                },
                new Escuela()
                {
                    Estudiantes = new Estudiante[]
                    {
                        new Estudiante{Nombre = "Camila"},
                        new Estudiante{Nombre = "Jaira"}
                    }
                }
            };

            var estudiantes = escuelas.SelectMany(e => e.Estudiantes);

            foreach (var estudiante in estudiantes)
            {
                Console.WriteLine($"{estudiante.Nombre}, ");
            }
           

        }




    }

    public class Estudiante
    {
        public string Nombre { get; set; }
    }

    public class Escuela
    {
        public Estudiante[] Estudiantes { get; set; }
    }
}
    