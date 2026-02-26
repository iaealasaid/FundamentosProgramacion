using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.DescuentoPorDia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float monto = 0;
            string dia = "";

            Console.WriteLine("Ingrese el monto de compra");
            monto=Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el día de la semana");
            dia=Console.ReadLine();

            if (dia == "lunes" || dia == "miercoles")
            {
                Console.WriteLine("Tiene un 10% de descuento. Su monto total es: " + (monto - (monto * 0.1f)));
            }
            else if (dia == "martes" || dia == "jueves")
            {
                Console.WriteLine("Tiene un 15% de descuento. Su monto total es: " + (monto - (monto * 0.15f)));
            }
            else if (dia == "viernes" || dia == "sabado")
            {
                Console.WriteLine("Tiene un 20% de descuento. Su monto total es: " + (monto - (monto * 0.2f)));
            }
            else
            {
                Console.WriteLine($"No tiene descuento. Su monto total es: {monto}");
            }
        }
    }
}
