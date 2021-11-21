using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiLibreria
{
    public class Persona
    {
        public int Edad { get; set; }
        public string Nombre { get; set; }

        public Persona(int edad, string nombre)
        {
            this.Edad = edad;   
            this.Nombre = nombre;   
        }

        public string Saludo()
        {
            return $"Hola {this.Nombre}";
        }

        public string GetEdad()
        {
            return $"{this.Nombre}, tienes {this.Edad} años";
        }
    }
}
