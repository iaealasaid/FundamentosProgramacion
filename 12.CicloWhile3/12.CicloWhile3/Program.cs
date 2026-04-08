using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CicloWhile3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int i = 1;
            int contador = 0;

            Console.WriteLine("Ingrese un número entero");
            n = Int32.Parse(Console.ReadLine());

            while (n >= i)
            {
                if (i % 2 == 0)
                {
                    contador++;
                }
                i++;
            }
            Console.WriteLine($"La cantidad de números pares entre 0 y {n} es de: {contador}");
        }
    }
}
