using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int contador = 0;
            double sumaSaldos = 0;
            string continuar;

            do
            {
                Console.WriteLine("Ingrese nombre:");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese número de cuenta:");
                string cuenta = Console.ReadLine();

                Console.WriteLine("Ingrese saldo:");
                double saldo = double.Parse(Console.ReadLine());

                if (saldo > 3000000)
                {
                    Console.WriteLine(nombre + " | " + cuenta + " | " + saldo + " | Es apto para el crédito");
                }
                else
                {
                    Console.WriteLine(nombre + " | " + cuenta + " | " + saldo + " | No es apto para el crédito");
                }

                contador++;
                sumaSaldos += saldo;

                Console.WriteLine("¿Desea ingresar otro usuario? (si/no)");
                continuar = Console.ReadLine();

            } while (continuar == "si" || continuar == "Si" || continuar == "SI");

            Console.WriteLine("\nTotal de usuarios: " + contador);

            if (contador > 0)
            {
                double promedio = sumaSaldos / contador;
                Console.WriteLine("Promedio de saldos: " + promedio);
            }*/


            /*int num = 2;

            do
            {
                int contador = 0;
                int i = 1;

                do
                {
                    if (num % i == 0)
                    {
                        contador++;
                    }
                    i++;
                } while (i <= num);

                if (contador == 2)
                {
                    Console.Write(num + " ");
                }

                num++;

            } while (num <= 100);*/


            /*int opcion = 0;
            int num1 = 0;
            int num2 = 0;
            int resultado = 0;

            do
            {
                Console.WriteLine("\n1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Salir");
                Console.WriteLine("Elija una opción:");

                opcion = int.Parse(Console.ReadLine());

                if (opcion >= 1 && opcion <= 4)
                {
                    Console.WriteLine("Ingrese primer número:");
                    num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese segundo número:");
                    num2 = int.Parse(Console.ReadLine());

                    if (opcion == 1)
                        resultado = num1 + num2;
                    else if (opcion == 2)
                        resultado = num1 - num2;
                    else if (opcion == 3)
                        resultado = num1 * num2;
                    else
                        resultado = num1 / num2;

                    Console.WriteLine($"Resultado: {resultado}");
                }

            } while (opcion != 5);*/


            int num = 0;
            int pares = 0;
            int impares = 0;
            int suma = 0;
            int contador = 0;
            string continuar = "";

            do
            {
                Console.WriteLine("Ingrese un número:");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                    pares++;
                else
                    impares++;

                suma += num;
                contador++;

                Console.WriteLine("¿Desea ingresar otro número? (si/no)");
                continuar = Console.ReadLine();

            } while (continuar == "si" || continuar == "Si" || continuar == "SI");

            Console.WriteLine("\nPares: " + pares);
            Console.WriteLine("Impares: " + impares);

            if (contador > 0)
            {
                int promedio = suma / contador;
                Console.WriteLine("Promedio: " + promedio);
            }
        }
    }
}
