using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.NumerosPositivosONegativos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num = 0;
            Console.WriteLine("Ingrese un número entero");
            Num = Convert.ToInt32(Console.ReadLine());

            if (Num >= 0)
            {
                Console.WriteLine("El número es positivo");
            }
            else
            {
                Console.WriteLine("El número es negativo");
            }
        }
    }
}
