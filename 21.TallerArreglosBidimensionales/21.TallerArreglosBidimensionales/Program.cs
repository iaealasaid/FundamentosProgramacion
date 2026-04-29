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

            // a. Llenar la matriz
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Ingrese el nombre en la posición [{i},{j}]:");
                    salon[i, j] = Console.ReadLine();
                }
            }

            // Mostrar matriz original
            Console.WriteLine("\nMatriz original:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(salon[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // b. Pedir posición
            Console.WriteLine("\nIngrese la fila a eliminar (0-2):");
            int fila = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la columna a eliminar (0-2):");
            int columna = Int32.Parse(Console.ReadLine());

            // c. Eliminar (poner vacío)
            salon[fila, columna] = "";

            // d. Mostrar matriz resultante
            Console.WriteLine("\nMatriz con el alumno eliminado:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(salon[i, j] + "\t");
                }
                Console.WriteLine();
            }*/


            //     -     ---------     -     ---------     -     ---------     -     ---------


            /*int[,] num = new int[10, 20];

            // Llenar matriz
            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese un número para la posición [{i},{j}]:");
                    num[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Mostrar matriz (opcional)
            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    Console.Write(num[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nSuma de cada columna:");

            // Sumar columnas
            for (int j = 0; j < num.GetLength(1); j++) // columnas
            {
                int suma = 0;

                for (int i = 0; i < num.GetLength(0); i++) // filas
                {
                    suma += num[i, j]; // ✅ ahora sí cambia la fila
                }

                Console.WriteLine("Columna " + j + ": " + suma);
            }*/


            //     -     ---------     -     ---------     -     ---------     -     ---------


            /*Console.WriteLine("Ingrese número de filas:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese número de columnas:");
            int m = int.Parse(Console.ReadLine());

            char[,] matriz = new char[n, m];

            // Llenar matriz
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"Ingrese un caracter en [{i},{j}]:");
                    matriz[i, j] = char.Parse(Console.ReadLine());
                }
            }

            // Mostrar matriz original
            Console.WriteLine("\nMatriz original:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Intercambiar primera fila con la última
            for (int j = 0; j < m; j++)
            {
                char aux = matriz[0, j];
                matriz[0, j] = matriz[n - 1, j];
                matriz[n - 1, j] = aux;
            }

            // Mostrar matriz modificada
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

            // Llenar matriz con números aleatorios (1 a 10)
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = rand.Next(1, 11);
                }
            }

            // Mostrar matriz
            Console.WriteLine("Matriz:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Contar frecuencias
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int num = matriz[i, j];
                    frecuencia[num - 1]++; // clave 🔥
                }
            }

            // Mostrar frecuencias
            Console.WriteLine("\nFrecuencia de números:");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine((i + 1) + " aparece " + frecuencia[i] + " veces");
            }*/


            //     -     ---------     -     ---------     -     ---------     -     ---------


            /*string[,] tablero = new string[5, 5];
            Random rand = new Random();

            // Llenar con "-"
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    tablero[i, j] = "-";
                }
            }

            // Colocar 3 X (sin repetir posiciones)
            for (int k = 0; k < 3; k++)
            {
                int fila = rand.Next(0, 5);
                int col = rand.Next(0, 5);

                if (tablero[fila, col] == "X")
                {
                    k--; // repetir intento si ya hay X
                }
                else
                {
                    tablero[fila, col] = "X";
                }
            }

            // Intentos del usuario
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
                    Console.WriteLine("¡Acertaste! Había una X en [" + f + "," + c + "]");
                    acerto = true;
                    break;
                }
                else
                {
                    Console.WriteLine("No hay X ahí");
                }
            }

            // Resultado final
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


            /*Console.WriteLine("Ingrese número de filas:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese número de columnas:");
            int m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, m];
            int[,] transpuesta = new int[m, n];

            // Llenar matriz
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"Ingrese valor en [{i},{j}]:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Mostrar matriz original
            Console.WriteLine("\nMatriz original:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Transponer (filas → columnas)
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    transpuesta[j, i] = matriz[i, j];
                }
            }

            // Mostrar nueva matriz
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


            Console.WriteLine("Ingrese número de filas:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese número de columnas:");
            int m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, m];
            int[] frecuencia = new int[3]; // 0→1, 1→2, 2→3
            Random rand = new Random();

            // Llenar y contar
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = rand.Next(1, 4);
                    frecuencia[matriz[i, j] - 1]++;
                }
            }

            // Mostrar matriz
            Console.WriteLine("\nMatriz:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Mostrar frecuencias
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine((i + 1) + " aparece " + frecuencia[i] + " veces");
            }

            // Buscar el mayor
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
