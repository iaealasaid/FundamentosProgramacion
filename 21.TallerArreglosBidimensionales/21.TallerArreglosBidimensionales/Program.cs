using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.TallerArreglosBidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] num = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2;  j++)
                {
                    Console.WriteLine($"Ingrese un número para el valor de P {i}, {j}");
                    num[i, j] = int.Parse( Console.ReadLine() );
                }
            }

            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    Console.Write(num[i, j] + "|");
                }
                Console.WriteLine();
            }

            Console.WriteLine("La suma de las columnas es:");
            
            for (int i = 0; i < num.GetLength(1); i++)
            {
                int suma = 0;
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    suma += num[0, i];
                    Console.Write(suma + "|");
                }
            }
            Console.WriteLine();
        }
    }
}
