using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int acumulador = 0;

            for (int contador = 0; contador <= 5; contador++)
            {
                acumulador += contador;
            }

            Console.WriteLine($"La suma de los cinco primeros números enteros es: {acumulador}");*/


            /*int factorial = 1;
            int num = 0;

            Console.WriteLine("Ingrese un número para sacar su factorial");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"El factorial de {num} es: {factorial}");*/


            int rango1 = 0;
            int rango2 = 0;
            int multiplos = 0;

            Console.WriteLine("Ingrese el inicio del rango de números a evaluar");
            rango1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el final del rango de números a evaluar");
            rango2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"En el rango entre {rango1} y {rango2}, los siguientes números son multiplos de cinco:");

            for (int i = rango1; i <= rango2; i++)
            {
                if (i % 5 == 0)
                {
                    multiplos++;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine($"Dentro del rango hay un total de {multiplos} multiplos de cinco");
        }


    }
}
