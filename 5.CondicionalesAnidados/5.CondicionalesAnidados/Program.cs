using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.CondicionalesAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            Console.WriteLine("Por favor ingrese tres valores diferentes");
            Console.WriteLine("Ingrese el valor del número 1");
            num1=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del número 2");
            num2=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del número 3");
            num3=Int32.Parse(Console.ReadLine());*/

            /*if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine($"El número mayor es: {num1}");
                }
                else
                {
                    Console.WriteLine($"El número mayor es: {num3}");
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine($"El número mayor es: {num2}");
                }
                else
                {
                    Console.WriteLine($"El número mayor es: {num3}");
                }
            }*/

            /*if (num1 > num2 &&  num1 > num3)
            {
                Console.WriteLine($"El número mayor es: {num1}");
            }
            else
            {
                if (num2 > num1 && num2 > num3)
                {
                    Console.WriteLine($"El número mayor es: {num2}");
                }
                else
                {
                    Console.WriteLine($"El número mayor es: {num3}");
                }
            }*/

            //Promedio de 3 calificaciones

            float nota1 = 0f;
            float nota2 = 0f;
            float nota3 = 0f;

            Console.WriteLine("Ingrese la calificación 1");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la calificación 2");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la calificación 3");
            nota3 = float.Parse(Console.ReadLine());

            float promedio = (nota1 + nota2 + nota3) / 3f;

            if (promedio >= 0 && promedio <= 10)
            {
                Console.WriteLine($"Su calificación promedio es: {promedio}");
                if (promedio >= 9.5)
                {
                    Console.WriteLine("Excelente");
                }
                else if (promedio >= 8.5)
                {
                    Console.WriteLine("Bien");
                }
                else if (promedio >= 7.5)
                {
                    Console.WriteLine("Suficiente");
                }
                else
                {
                    Console.WriteLine("Insuficiente");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
