using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    public class Particionado
    {
       public void Particionar()
        {
            string[] palabras = new string[]
            {
                "abc","abz","def","fgh","fui"
            };

            var grupo1 = palabras.Take(1);
            var grupo1While = palabras.TakeWhile(p => p.StartsWith("a"));
            var grupo2 = palabras.Skip(2);
            var grupo2SkipWhile = palabras.SkipWhile(p => p.Contains("a"));

            foreach (var item in grupo1)
            {
                Console.WriteLine(item);
            }
            foreach (var item in grupo1While)
            {
                Console.WriteLine($"ocupando TakeWhile {item}");
            }
            foreach (var item in grupo2)
            {
                Console.WriteLine(item);
            }

            foreach (var item in grupo2SkipWhile)
            {
                Console.WriteLine($"ocupando SkipWhile {item}");
            }
        }
    }
}
