using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.CicloWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int contador = 1;
            int acumulador = 0;

            while (contador <= 99)
            {
                acumulador += contador;
                contador += 2;
            }
            Console.WriteLine($"Suma de números impares del 1 al 99: {acumulador}");*/

            /*int cantidad = 0;
            int contador = 1;
            int ceros = 0;
            int mayorCero = 0;
            int menorCero = 0;
            int num = 0;

            Console.WriteLine("¿Cuantos números va a ingresar?");
            cantidad = int.Parse(Console.ReadLine());

            while (contador <= cantidad)
            {
                Console.WriteLine($"Ingrese el valor del número {contador}");
                num = int.Parse(Console.ReadLine());

                if (num == 0)
                {
                    ceros++;
                }
                else
                {
                    if (num > 0)
                    {
                        mayorCero++;
                    }
                    else
                    {
                        menorCero++;
                    }
                }
                contador++;
            }
            Console.WriteLine($"Ceros: {ceros} | Mayores a cero: {mayorCero} | Menores a cero: {menorCero}");*/

            float ahorroMes = 0;
            float ahorroTotal = 0;
            int contador = 1;

            while (contador <= 12)
            {
                Console.WriteLine($"Ingrese cuanto va a ahorrar en el mes {contador}");
                ahorroMes = Single.Parse( Console.ReadLine() );
                ahorroTotal += ahorroMes;

                Console.WriteLine($"--- Este mes usted ahorró ${ahorroMes}, el total ahorrado hasta el mes {contador} es: ${ahorroTotal}\n");
                contador++;
            }
            Console.WriteLine($"El total ahorrado para el año es: ${ahorroTotal}");
        }
    }
}
