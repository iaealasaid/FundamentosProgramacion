using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int contador = 1;
            int acumulador = 0;

            while (contador <= 5)
            {
                acumulador += contador;
                contador++;

                Console.WriteLine($"Contador: {contador} | Acumulador: {acumulador}");
            }
            Console.WriteLine($"La suma de los cinco primeros números enteros es: {acumulador}");*/


            /*int contador = 1;
            int acumulador = 1;
            int num = 0;
            Console.WriteLine("Ingrese el número");
            num = Int32.Parse(Console.ReadLine());

            while (contador <= num)
            {
                acumulador += contador;
                contador++;
            }
            Console.WriteLine($"El factorial de {num} es {acumulador}");*/


            int num = 0;
            int acumulador = 0;

            Console.WriteLine("Ingrese un número entero");
            acumulador = Int32.Parse(Console.ReadLine());

            while (num >= 0)
            {
                acumulador += num;
                Console.WriteLine("Ingrese otro número entero");
                num = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Ha ingresado un número negativo | La suma total de los números enteros positivos ingresados es {acumulador}");
        }
    }
}
