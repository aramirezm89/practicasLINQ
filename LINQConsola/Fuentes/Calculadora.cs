using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Fuentes
{
    public class Calculadora
    {
       

        public static void calcular(double num1,double num2, double opcion)
        {
            double resultado = 0;
            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine(resultado);
                    break;
                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine(resultado);
                    break;

                case 3:
                    resultado =  num1 * num2;
                    Console.WriteLine(resultado);
                    break;
                case 4:
                    if (num1 == 0)
                    {
                        Console.WriteLine("no se puede dividir por 0");
                    }
                    else
                    {
                        resultado =  num1 / num2;
                        Console.WriteLine(resultado);
                    }
                    break;
                    
            } 

        }

        public static void Sumar(int num1, int num2)
        {
            int result =  num1 + num2;  
             Console.WriteLine(result);
        }

        public static void Restar(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine(result);

        }

        public static void Multiplicar(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine(result);
        }

        public static void Dividir(double num1 , double num2)
        {
            if(num1 == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                double result  = num1 / num2;
                Console.WriteLine(Math.Round(result,2));
            }
        }
    }

}
