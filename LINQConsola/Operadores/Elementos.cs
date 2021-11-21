using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    public class Elementos 
    {

       public void Elemento()
        {
            using(var db = new CursosVirtualesEntities1())
            {
                //ElementAt 
                //Obtener Listado de 10 paises y luego buscarlos por indice con ElementAt()


                //var paises = db.Paises.OrderByDescending(p => p.PaisId).Take(10);

                //foreach (var pais in paises)
                //{
                //    Console.WriteLine($"{pais.Nombre}");
                //}

                //Console.WriteLine(Environment.NewLine);

                //var paisEspecifico = paises.AsEnumerable().ElementAt(9);

                //Console.WriteLine(paisEspecifico.Nombre);


                //ElementAtOfDefault()

                //var paises = db.Paises.OrderByDescending(p => p.PaisId).Take(10);

                //foreach (var pais in paises)
                //{
                //    Console.WriteLine($"{pais.Nombre}");
                //}

                //Console.WriteLine(Environment.NewLine);

                //int index = 10;

                //var paisEspecifico = paises.AsEnumerable().ElementAtOrDefault(index);

                //Console.WriteLine("El pais {0} es: {1}",index,(paisEspecifico == null ?"no hay pais":paisEspecifico.Nombre));



                //First()
                var cursosBaratos = db.Cursos.Where(c => c.Precio == 9.99).ToList();

                //var curso = cursosBaratos.First();


                //FirstOrDefault()

                //var curso = cursosBaratos.FirstOrDefault(); //difrencia es que FirstOrDefault() devuelve null y First() devuelve Exeption

              
                
                //last(), devuelve ultimo elemento de la lista, devuelve exception si la consulta no encuentra datos
                
                //var cursos = db.Cursos.Where(c => c.Idioma.Equals("portugues") && c.Precio > 85).ToList();

                //var ultimoCurso = cursos.Last();

                //LastOrDefault() a diferencias de Last(), devuelve null si no encuentra un dato segun consulta realizada

                //var curso = db.Cursos.LastOrDefault(c => c.Precio < 10);



                //Single() devuelve un unico elemento que cumpla con el filtro realizado, en caso de no encontrar nada devuelve Exeption

                //var curso = db.Cursos.Single(c => c.Nombre.Equals("programación orientada a objetos"));

                //SingleOrDefault lo mismo que Single() pero devuelve null si no encuentra nada

                var curso = db.Cursos.SingleOrDefault(c => c.Nombre.Equals("programación orientada a objeto"));
            }
        }
    }
}
