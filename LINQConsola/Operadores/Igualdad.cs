using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    public class Igualdad
    {
        public void DeIgualdad()
        {
            using (var db = new CursosVirtualesEntities1())
            {
                var continentes1 = db.Continentes.ToList();
                var continentes2 = db.Continentes.Take(3).ToList();

                bool igualdad = continentes1.SequenceEqual(continentes2);

                Console.WriteLine(igualdad);
            } ;
        }
    }
}
