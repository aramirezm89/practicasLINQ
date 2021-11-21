using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
   public  class Conjuntos
    {
        public void Conjunto()
        {
            string[] dias = new string[]
            {
                "Lunes",
                "Martes",
                "Miercoles",
                "Jueves",
                "Viernes",
                "Lunes",
                "Martes"

            };

            string[] dias2 = new string[]
            {
                 "Lunes",
                "Martes",
               
                "Jueves",
                "Viernes",
                "Lunes",
                "Martes",
                "Sabado",
                "Domingo"
            };
            IEnumerable<string> d = dias.Except(dias2);
            IEnumerable<string> d2 = dias.Intersect(dias2); //in
            IEnumerable<string> d3 = dias.Union(dias2);

            foreach (var dia in d)
            {
                Console.WriteLine($"metodo Except trae elemnto exclusivo del primer conjunto comparado con el segundo: {dia}");
            }
            foreach (var dia in d2)
            {
                Console.WriteLine($"metodo Intersect devuelve los elementos comunes entre los dos conjuntos : {dia}");
            }
            foreach (var dia in d3)
            {
                Console.WriteLine($"metodo Union devuelve los elementos de los dos conjuntos suprimiento elementos comunes : {dia}");
            }



        }
    }
}
