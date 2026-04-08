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


            /*int numBase = 0;
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
            } while (salida != 'n');*/


            /*float calificacion = 0f;
            float cantidadNum = 0f;
            float acumulador = 0f;
            string salida = "";

            do
            {
                Console.WriteLine($"Ingrese una calificacíon");
                calificacion = Single.Parse(Console.ReadLine());
                acumulador += calificacion;
                cantidadNum++;
                Console.WriteLine("¿Desea ingresar otra calificación? | Escriba 'si' o 'no'");
                salida = Console.ReadLine();

            } while (salida == "si");
            if (cantidadNum == 0)
            {
                Console.WriteLine($"Su calificación promedio es de : {calificacion}");
            }
            else
            {
                Console.WriteLine($"Su calificación promedio es de : " + (acumulador / cantidadNum));
            }*/


            /*int num = 0;
            int i = 1;

            Console.WriteLine("Ingrese un número para saber sus divisores");
            num = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Los divisores de {num} son:");

            while (i <= num)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }*/


            /*int numBase = 0;
            int numExp = 0;
            int contador = 1;
            int resultado = 1;
            string salida = "";

            while (salida != "n")
            {
                Console.WriteLine("Ingrese el valor de la base");
                numBase = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el valor del exponente");
                numExp = Int32.Parse(Console.ReadLine());

                contador = 1;
                resultado = 1;

                while (contador <= numExp)
                {
                    resultado *= numBase;
                    contador++;
                }

                Console.WriteLine($"El resultado de {numBase} elevado a {numExp} es: {resultado}");
                Console.WriteLine("\nSi desea terminar ingrese 'n' | Si desea continuar ingrese algo diferente");
                salida = Console.ReadLine();
            }*/


            /*float tiempo = 0;
            float total = 0;
            float promedio = 0;
            bool mayor20 = false;
            bool menor15 = false;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Ingrese el tiempo que tardó en recorrer los 5km en el día {i}");
                tiempo = Single.Parse(Console.ReadLine());
                total += tiempo;

                if (tiempo > 20)
                {
                    mayor20 = true;
                }
                if (tiempo < 15)
                {
                    menor15 = true;
                }
            }
            promedio = total / 10;

            if (!mayor20 && menor15 && (promedio <= 18))
            {
                Console.WriteLine("El atleta es apto para la prueba");
            }
            else
            {
                Console.WriteLine("El atleta no es apto para la prueba");
            }*/


            /*int n = 0;
            string respuesta = "";
            int favor = 0;
            int contra = 0;
            int noResponde = 0;

            Console.WriteLine("Ingrese el número de personas que van a ser encuestadas");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Persona {i}: Ingrese su respuesta | 'favor' / 'contra' / 'no'");
                respuesta = Console.ReadLine();

                if (respuesta == "favor")
                {
                    favor++;
                }
                else if (respuesta == "contra")
                {
                    contra++;
                }
                else
                {
                    noResponde++;
                }
            }

            float pFavor = (favor * 100f) / n;
            float pContra = (contra * 100f) / n;
            float pNoResponde = (noResponde * 100f) / n;

            Console.WriteLine($"Porcentaje a favor: {pFavor}%\nPorcentaje en contra: {pContra}%\nPorcentaje no responde: {pNoResponde}%");*/


            int positivos = 0;
            int negativos = 0;
            int ceros = 0;
            int sumaPositivos = 0;
            int sumaNegativos = 0;
            int num = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Ingrese un número");
                num = int.Parse(Console.ReadLine());

                if (num > 0)
                {
                    positivos++;
                    sumaPositivos += num;
                }
                else if (num < 0)
                {
                    negativos++;
                    sumaNegativos += num;
                }
                else
                {
                    ceros++;
                }
            }
            Console.WriteLine($"Cantidad de números positivos: {positivos}");
            Console.WriteLine($"Cantidad de números negativos: {negativos}");
            Console.WriteLine($"Cantidad de números ceros: {ceros}");
            Console.WriteLine($"\nTotal de la suma de los números positivos: {positivos}");
            Console.WriteLine($"\nTotal de la suma de los números negativos: {negativos}");
        }
    }
}
