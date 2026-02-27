using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.CondicionalesMultiplesOperadorTernario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*char dia= ' ';
            float total = 0;
            float descuento = 0;
            Console.WriteLine("Ingrese el día de la semana: (l = lunes, m = martes, i = miércoles, j = jueves, v = viernes, s = sábado, d = domingo)");
            dia=Char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el total de la compra:");
            total=Single.Parse(Console.ReadLine());

            switch (dia)
            {
                case 'l':
                    descuento=total * 0.1f;
                    Console.WriteLine($"Hoy es lunes, el descuento es de {descuento}, el total de la compra es de {total - descuento}");
                    break;
                case 'm':
                    descuento = total * 0.15f;
                    Console.WriteLine($"Hoy es martes, el descuento es de {descuento}, el total de la compra es de {total - descuento}");
                    break;
                case 'i':
                    descuento = total * 0.1f;
                    Console.WriteLine($"Hoy es miércoles, el descuento es de {descuento}, el total de la compra es de {total - descuento}");
                    break;
                case 'j':
                    descuento = total * 0.15f;
                    Console.WriteLine($"Hoy es jueves, el descuento es de {descuento}, el total de la compra es de {total - descuento}");
                    break;
                case 'v':
                    descuento = total * 0.2f;
                    Console.WriteLine($"Hoy es viernes, el descuento es de {descuento}, el total de la compra es de {total - descuento}");
                    break;
                case 's':
                    descuento = total * 0.2f;
                    Console.WriteLine($"Hoy es sábado, el descuento es de {descuento}, el total de la compra es de {total - descuento}");
                    break;
                case 'd':
                    descuento = total * 0;
                    Console.WriteLine($"Hoy es domingo, el descuento es de {descuento}, el total de la compra es de {total - descuento}");
                    break;
                default:
                    Console.WriteLine("Seleccione un día correcto de la semana");
                    break;
            }*/

            /*float num1 = 0;
            float num2 = 0;
            char operacion = ' ';
            float resultado = 0;
            Console.WriteLine("¿Qué operación va a realizar? (s = suma, r = resta, m = multiplicación, d = división)");
            operacion=Char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del primer número");
            num1=Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del segundo número");
            num2=Single.Parse(Console.ReadLine());

            switch (operacion)
            {
                case 's':
                    resultado = num1 + num2;
                    Console.WriteLine($"La suma {num1} + {num2} da como resultado: {resultado}");
                    break;
                case 'r':
                    resultado = num1 - num2;
                    Console.WriteLine($"La resta {num1} - {num2} da como resultado: {resultado}");
                    break;
                case 'm':
                    resultado = num1 * num2;
                    Console.WriteLine($"La multiplicación {num1} * {num2} da como resultado: {resultado}");
                    break;
                case 'd':
                    resultado = num1 / num2;
                    Console.WriteLine($"La división {num1} / {num2} da como resultado: {resultado}");
                    break;
                default:
                    Console.WriteLine("Seleccione un tipo de operación correcta");
                    break;
            }*/

            /*int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Ingrese el valor del primer número");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del segundo número");
            num2=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine( num1 > num2 ? $"El número mayor es: {num1}" : $"El número mayor es: {num2}");*/

            int edad = 0;
            Console.WriteLine("Ingrese su edad");
            edad=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(edad >= 18 ? "Bienvenido a mi sitio web" : "No es apto para el contenido de este sitio web");
        }
    }
}
