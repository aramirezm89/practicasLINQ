using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Fuentes
{
    public  class LinqToObject
    {
        public static void LinqConObjetos()
        {
            string[] lenguajes = new string[] { "c#", "Java", "JavaScript", "C++", "Python", "Asp.Net", "Cobol" };

            var lista = lenguajes.Where(l => l.ToLower().Substring(0, 1).Equals("j")).ToList();
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }


            List<Persona> listaPersona = new List<Persona>()
            {
                new Persona(1,"Antonio"),
                new Persona(2,"Raphael"),
                new Persona(3,"Armando"),
                new Persona(4,"Fabiola")
            };

            var lista2 = listaPersona.Where(p => p.Name.ToLower().Substring(0, 1).Equals("a")).Select(p => new {nombre= p.Name,identidad = p.Id});

            foreach (var item in lista2)
            {
                Console.WriteLine($"{item.nombre}, {item.identidad}");
            }
        }


    }


    class Persona
    {
        public Persona(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; } 
        public string Name { get; set; }

       
    }
}
