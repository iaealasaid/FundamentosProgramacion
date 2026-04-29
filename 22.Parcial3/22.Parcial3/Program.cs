using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Parcial3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[,] nota = new float[3, 4];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.WriteLine($"Ingrese la calificación del estudiante {i + 1} para Matemáticas:");
                    nota[i, j] = Single.Parse(Console.ReadLine());

                    if (nota[i, j] < 0 || nota[i, j] > 5)
                    {
                        Console.WriteLine($"La calificación ingresada para el estudiante {i + 1} en Matemáticas esta fuera del rango [0.0 a 5.0] | Vuelva a poner la nota:");
                        nota[i, j] = Single.Parse(Console.ReadLine());
                    }
                }

                for (int j = 1; j < 2; j++)
                {
                    Console.WriteLine($"Ingrese la calificación del estudiante {i + 1} para Física:");
                    nota[i, j] = Single.Parse(Console.ReadLine());

                    if (nota[i, j] < 0 || nota[i, j] > 5)
                    {
                        Console.WriteLine($"La calificación ingresada para el estudiante {i + 1} en Física esta fuera del rango [0.0 a 5.0] | Vuelva a poner la nota:");
                        nota[i, j] = Single.Parse(Console.ReadLine());
                    }
                }

                for (int j = 2; j < 3; j++)
                {
                    Console.WriteLine($"Ingrese la calificación del estudiante {i + 1} para Inglés:");
                    nota[i, j] = Single.Parse(Console.ReadLine());

                    if (nota[i, j] < 0 || nota[i, j] > 5)
                    {
                        Console.WriteLine($"La calificación ingresada para el estudiante {i + 1} en Inglés esta fuera del rango [0.0 a 5.0] | Vuelva a poner la nota:");
                        nota[i, j] = Single.Parse(Console.ReadLine());
                    }
                }

                for (int j = 3; j < 4; j++)
                {
                    Console.WriteLine($"Ingrese la calificación del estudiante {i + 1} para Sociales:");
                    nota[i, j] = Single.Parse(Console.ReadLine());

                    if (nota[i, j] < 0 || nota[i, j] > 5)
                    {
                        Console.WriteLine($"La calificación ingresada para el estudiante {i + 1} en Sociales esta fuera del rango [0.0 a 5.0] | Vuelva a poner la nota:");
                        nota[i, j] = Single.Parse(Console.ReadLine());
                    }
                }
            }

            Console.WriteLine("               Matemáticas | Física      | Inglés      | Sociales    |");
            for (int i = 0; i < nota.GetLength(0); i++)
            {
                Console.Write($"Estudiante {i + 1} : ");
                for (int j = 0;j < nota.GetLength(1); j++)
                {
                    Console.Write(nota[i, j] + "           | ");
                }
                Console.WriteLine();
            }
        }
    }
}
