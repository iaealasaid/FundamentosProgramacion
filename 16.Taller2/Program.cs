using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Taller2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*float calificacion = 0f;
            float promedio = 0f;
            int cantidad = 0;
            string salida = "";

            do
            {
                cantidad++;
                Console.WriteLine($"Ingrese su calificación {cantidad}");
                calificacion = Single.Parse(Console.ReadLine());
                promedio += calificacion;

                Console.WriteLine("¿Desea ingresar otra calificación? (Ingrese 'si' o 'no')");
                salida = Console.ReadLine();
            } while (salida == "si");
            Console.WriteLine("Su calificación promedio es: " + (promedio / cantidad));*/


            /*int num = 0;

            Console.WriteLine("Ingrese un número del que desee sacar sus divisores");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Los divisores del número {num} son:");

            for (int contador = 1; contador <= num; contador++)
            {
                if (num % contador == 0)
                {
                    Console.WriteLine(contador);
                }
            }*/


            int numBase = 0;
            int exponente = 0;
            int resultado = 0;
            char salida = ' ';

            do
            {
                Console.WriteLine("Ingrese un número para la base | Ingrese 'n' para salir");
                numBase = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese un número para el exponente | Ingrese 'n' para salir");
                exponente = int.Parse(Console.ReadLine());

                resultado = (int)Math.Pow(numBase, exponente);
                Console.WriteLine($"{numBase} elevado a {exponente} da como resultado: {resultado}");
            } while (salida != 'n');
        }
    }
}
