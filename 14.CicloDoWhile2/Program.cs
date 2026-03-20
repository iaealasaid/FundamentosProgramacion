using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.CicloDoWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int contadorNum = 1;
            int contador = 1;
            int divisores = 0;

            do
            {
                do
                {
                    if (contadorNum % contador == 0)
                    {
                        divisores++;
                    }
                    contador++;
                } while (contador <= contadorNum);
                contador = 1;

                if (divisores == 2)
                {
                    Console.WriteLine(contadorNum);
                }
                divisores = 0;

                contadorNum++;
            } while (contadorNum <= 100);*/

            string operacion = "";
            float num1 = 0;
            float num2 = 0;
            string salida = "";

            /*do
            {
                if (operacion = "salir")
                {
                    if (operacion == "suma")
                    {
                        Console.WriteLine($"El resultado de la suma de {num1} y {num2} es: " + (num1 + num2));
                    }
                    else if (operacion == "resta")
                    {
                        Console.WriteLine($"El resultado de la suma de {num1} y {num2} es: " + (num1 + num2));
                    }
                    else if (operacion == "multiplicacion")
                    {
                        Console.WriteLine($"El resultado de la suma de {num1} y {num2} es: " + (num1 + num2));
                    }
                    else if (operacion == "division")
                    {
                        Console.WriteLine($"El resultado de la suma de {num1} y {num2} es: " + (num1 + num2));
                    }
                    Console.WriteLine("\n¿Qué operación quiere realizar? (suma, resta, multiplicacion, division) | Escriba 'salir' para salir del programa");
                operacion = Console.ReadLine();
                Console.WriteLine("Ingrese el valor del primer número");
                num1 = Single.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el valor del segundo número");
                num2 = Single.Parse(Console.ReadLine());
                }
                else if (operacion == "salir")
                {

                }
            } while (operacion == "suma" | operacion == "resta" | operacion == "multiplicacion" | operacion == "division" & operacion != "salir");*/

            int cantidad = 0;
            int contador = 1;
            int pares = 0;
            int impares = 0;

            Console.WriteLine("¿Cuantos números desea ingresar?");
            cantidad = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"Ingrese el valor del número {contador}");
                contador = int.Parse(Console.ReadLine());

            } while (contador <= cantidad);
        }
    }
}
