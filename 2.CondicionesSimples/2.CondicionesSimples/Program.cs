using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CondicionesSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string nombre = "";
            float sueldo = 0;
            Console.WriteLine("Ingrese el nombre del usuario");
            nombre=Console.ReadLine(); //Todo lo que el usuario ingresa desde la consola llega como una cadena de caracteres
            Console.WriteLine("Ingrese el valor del sueldo");
            sueldo=Convert.ToSingle( Console.ReadLine() );

            if (sueldo>=3000)
            {
                Console.WriteLine($"El usuario {nombre} debe abonar impuesto");
            }*/

            byte edad = 0;
            Console.WriteLine("Ingrese su edad");
            edad=Convert.ToByte( Console.ReadLine() );

            if (edad>=18)
            {
                Console.WriteLine($"Bienvenido a mi sitio web");
            }
        }
    }
}
