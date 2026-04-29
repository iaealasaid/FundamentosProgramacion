using System;
using System.Collections.Generic;
using System.Configuration.Assemblies;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _19.TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] num = new int[15];

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Ingrese un número");
                num[i] = Int32.Parse(Console.ReadLine());
            }

            int max = num[0];
            int min = num[0];

            for (int i = 1; i < 15; i++)
            {
                if (num[i] > max)
                {
                    max = num[i];
                }
                if (num[i] < min)
                {
                    min = num[i];
                }
            }

            Console.WriteLine($"El valor máximo de la lista es: {max}");
            Console.WriteLine($"El valor mínimo de la lista es: {min}");*/


            //     -     ---------     -     ---------     -     ---------     -     ---------


            /*int[] v1 = new int[5];
            int[] v2 = new int[5];
            int contador = 0;

            Console.WriteLine("Vector 1");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un número");
                v1[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Vector 2");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un número");
                v1[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                if (v1[i] == v2[i])
                {
                    contador++;
                }
            }

            Console.WriteLine($"Los elementos iguales en la misma posición son: {contador}");*/


            //     -     ---------     -     ---------     -     ---------     -     ---------


            /*char[] caracter = new char[6];
            char[] invertido = new char[6];

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Ingrese un número");
                caracter[i] = char.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 6; i++)
            {
                invertido[i] = caracter[5 - i];
            }

            Console.WriteLine(""*/


            //     -     ---------     -     ---------     -     ---------     -     ---------


            /*int[] vector = new int[20];
            Random rand = new Random();

            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = rand.Next(0, 51);
            }

            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " | ");
            }

            int buscar = 0;
            Console.WriteLine("Ingrese un número a buscar");
            buscar = Int32.Parse(Console.ReadLine());

            int posicion = -1;

            for (int i = 0; i < 20; i++)
            {
                if (vector[i] == buscar)
                {
                    posicion = i;
                    break;
                } 
            }

            if (posicion != -1)
            {
                Console.WriteLine("Número encontrado en la posición: " + posicion);

                Console.WriteLine("Vector resaltado:");
                for (int i = 0; i < 20; i++)
                {
                    if (vector[i] == buscar)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(vector[i] + " ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(vector[i] + " ");
                    }
                }
            }
            else
            {
                Console.WriteLine("-1 (Número no encontrado)");
            }*/


            //     -     ---------     -     ---------     -     ---------     -     ---------


            /*int[] vector = new int[7];
            int mitad = vector.Length / 2;

            Console.WriteLine("Ingrese un número");
            int num = Int32.Parse(Console.ReadLine());

            vector[mitad] = num;

            int valor = num - 1;
            for (int i = mitad - 1; i >= 0; i--)
            {
                vector[i] = valor;
                valor--;
            }

            valor = num + 1;
            for (int i = mitad + 1; i < vector.Length; i++)
            {
                vector[i] = valor;
                valor++;
            }

            Console.WriteLine("Vector final:");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }*/


            //     -     ---------     -     ---------     -     ---------     -     ---------


            /*Random rand = new Random();

            // tamaños
            Console.WriteLine("Ingrese el tamaño del vector 1:");
            int n1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tamaño del vector 2:");
            int n2 = Int32.Parse(Console.ReadLine());

            // vectores
            int[] v1 = new int[n1];
            int[] v2 = new int[n2];
            int[] combinado = new int[n1 + n2];

            // llenar v1 → 0 a (n1+1)
            for (int i = 0; i < n1; i++)
            {
                v1[i] = rand.Next(0, n1 + 2); // +2 porque el límite superior no se incluye
            }

            // llenar v2 → n2 a (n2*2)
            for (int i = 0; i < n2; i++)
            {
                v2[i] = rand.Next(n2, (n2 * 2) + 1);
            }

            // combinar
            for (int i = 0; i < n1; i++)
            {
                combinado[i] = v1[i];
            }

            for (int i = 0; i < n2; i++)
            {
                combinado[n1 + i] = v2[i];
            }

            // mostrar v1
            Console.WriteLine("\nVector 1:");
            for (int i = 0; i < n1; i++)
            {
                Console.Write(v1[i] + " ");
            }

            // mostrar v2
            Console.WriteLine("\nVector 2:");
            for (int i = 0; i < n2; i++)
            {
                Console.Write(v2[i] + " ");
            }

            // mostrar combinado
            Console.WriteLine("\nVector combinado:");
            for (int i = 0; i < combinado.Length; i++)
            {
                Console.Write(combinado[i] + " ");
            }*/


            //     -     ---------     -     ---------     -     ---------     -     ---------


            /*string[] nombres = new string[10];
            int contador = 0;

            // Llenar el vector
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un nombre:");
                nombres[i] = Console.ReadLine();
            }

            // Pedir letra
            Console.WriteLine("Ingrese una letra:");
            char letra = Console.ReadLine()[0];

            // Contar
            for (int i = 0; i < 10; i++)
            {
                if (nombres[i][0] == letra || nombres[i][0] == letra + 32 || nombres[i][0] == letra - 32)
                {
                    contador++;
                }
            }

            // Mostrar resultado
            Console.WriteLine("Cantidad de nombres que empiezan con esa letra: " + contador);*/


            //     -     ---------     -     ---------     -     ---------     -     ---------


            string[] nombres = new string[10];

            // Llenar el vector
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un nombre:");
                nombres[i] = Console.ReadLine();
            }

            Console.WriteLine("\nResultados:");

            // Identificar repetidos y contar
            for (int i = 0; i < 10; i++)
            {
                if (nombres[i] != null)
                {
                    int contador = 1;

                    for (int j = i + 1; j < 10; j++)
                    {
                        if (nombres[i] == nombres[j])
                        {
                            contador++;
                            nombres[j] = null;
                        }
                    }

                    Console.WriteLine(nombres[i] + " aparece " + contador + " veces");
                }
            }
        }
    }
}
