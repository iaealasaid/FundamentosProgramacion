using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.ArreglosVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] numeros = new int[4];
            numeros[0] = 13;
            numeros[1] = 3;
            numeros[2] = 4;
            numeros[3] = 18;
            string[] nombres = new string[5];
            char[] simbolos = new char[] { 'd', '%', '#', 't', 'w', '¡' };
            float[] notas = { 4.5f, 2.3f, 1.9f, 3.8f, 4.8f };
            string[] estudiantes = new string[7];

            for(int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Ingrese el nombre para la posición {i + 1} con índice {i}");
                estudiantes[i]=Console.ReadLine();
            }
            for(int i = 0; i < numeros.Length;  i++)
            {
                Console.WriteLine(numeros[i] + " | ");
            }*/

            /*int[] numeros = new int[100];
            for(int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = 10;
                Console.WriteLine(numeros[i]);
            }*/

            int[] numeros = new int[15];
            int mayor = 0;
            int menor = 0;
            int[] posiciones = new int[2];
            for(int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Ingrese un número para P{i + 1}: I{i}:");
                numeros[i] = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    mayor = numeros[0];
                    menor = numeros[0];
                    posiciones[0] = i;
                    posiciones[1] = i;
                }
                else
                {
                    if (numeros[i] > mayor)
                    {
                        mayor = numeros[i];
                        posiciones[0] = i;
                    }

                    if (numeros[i] < menor)
                    {
                        menor = numeros[i];
                        posiciones[1] = i;
                    }
                }
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i] + " | ");
            }
            Console.WriteLine($"\nEl número mayor es: {mayor} en la posición {posiciones[0] + 1}");
            Console.WriteLine($"El número mayor es: {menor} en la posición {posiciones[1] + 1}");
        }
    }
}
