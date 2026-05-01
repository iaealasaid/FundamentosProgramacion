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
            /*string[,] salon = new string[3, 3];
            int fila = 0;
            int columna = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Ingrese el nombre en P {i},{j}:");
                    salon[i, j] = Console.ReadLine();
                }
            }

            Console.WriteLine("\nMatriz original");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(salon[i, j] + "            ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nIngrese la fila a eliminar (0-2):");
            fila = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la columna a eliminar (0-2):");
            columna = Int32.Parse(Console.ReadLine());

            salon[fila, columna] = "";

            Console.WriteLine("\nMatriz con el alumno eliminado:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(salon[i, j] + "            ");
                }
                Console.WriteLine();
            }*/


            //     -     ---------     -     ---------     -     ---------     -     ---------


            /*int[,] num = new int[10, 20];

            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese un número para P {i},{j}");
                    num[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    Console.Write(num[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nSuma de cada columna:");

            for (int j = 0; j < num.GetLength(1); j++)
            {
                int suma = 0;

                for (int i = 0; i < num.GetLength(0); i++)
                {
                    suma += num[i, j];
                }

                Console.WriteLine("Columna " + j + ": " + suma);
            }*/


            //     -     ---------     -     ---------     -     ---------     -     ---------


            /*int n = 0;
            int m = 0;

            Console.WriteLine("Ingrese número de filas:");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese número de columnas:");
            m = int.Parse(Console.ReadLine());

            char[,] matriz = new char[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"Ingrese un caracter en P {i},{j}");
                    matriz[i, j] = char.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMatriz original:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int j = 0; j < m; j++)
            {
                char aux = matriz[0, j];
                matriz[0, j] = matriz[n - 1, j];
                matriz[n - 1, j] = aux;
            }

            Console.WriteLine("\nMatriz con filas intercambiadas:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }*/


            //     -     ---------     -     ---------     -     ---------     -     ---------


            /*int[,] matriz = new int[5, 5];
            int[] frecuencia = new int[10];
            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = rand.Next(1, 11);
                }
            }

            Console.WriteLine("Matriz:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int num = matriz[i, j];
                    frecuencia[num - 1]++;
                }
            }

            Console.WriteLine("\nFrecuencia de números:");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine((i + 1) + " aparece " + frecuencia[i] + " veces");
            }*/


            //     -     ---------     -     ---------     -     ---------     -     ---------


            /*string[,] tablero = new string[5, 5];
            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    tablero[i, j] = "-";
                }
            }

            for (int k = 0; k < 3; k++)
            {
                int fila = rand.Next(0, 5);
                int col = rand.Next(0, 5);

                if (tablero[fila, col] == "X")
                {
                    k--;
                }
                else
                {
                    tablero[fila, col] = "X";
                }
            }

            bool acerto = false;

            for (int intento = 1; intento <= 3; intento++)
            {
                Console.WriteLine("Intento " + intento);

                Console.WriteLine("Ingrese fila (0-4):");
                int f = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese columna (0-4):");
                int c = int.Parse(Console.ReadLine());

                if (tablero[f, c] == "X")
                {
                    Console.WriteLine($"Acertaste. Había una X en [{f}, {c}]");
                    acerto = true;
                    break;
                }
                else
                {
                    Console.WriteLine("No hay X ahí");
                }
            }

            if (!acerto)
            {
                Console.WriteLine("\nNo acertaste. Tablero:");

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write(tablero[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }*/


            //     -     ---------     -     ---------     -     ---------     -     ---------


            /*int n = 0;
            int m = 0;

            Console.WriteLine("Ingrese número de filas:");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese número de columnas:");
            m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, m];
            int[,] transpuesta = new int[m, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"Ingrese valor en [{i},{j}]:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMatriz original:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    transpuesta[j, i] = matriz[i, j];
                }
            }

            Console.WriteLine("\nMatriz transpuesta:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(transpuesta[i, j] + " ");
                }
                Console.WriteLine();
            }*/


            //     -     ---------     -     ---------     -     ---------     -     ---------


            int n = 0;
            int m = 0;

            Console.WriteLine("Ingrese número de filas:");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese número de columnas:");
            m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, m];
            int[] frecuencia = new int[3];
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = rand.Next(1, 4);
                    frecuencia[matriz[i, j] - 1]++;
                }
            }

            Console.WriteLine("\nMatriz:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine((i + 1) + " aparece " + frecuencia[i] + " veces");
            }

            int mayor = 0;
            int numero = 1;

            for (int i = 0; i < 3; i++)
            {
                if (frecuencia[i] > mayor)
                {
                    mayor = frecuencia[i];
                    numero = i + 1;
                }
            }

            Console.WriteLine("\nEl número que más se repite es: " + numero);
        }
    }
}
