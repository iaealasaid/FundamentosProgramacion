using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CondicionalesDobles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string nombre = "";
            float sueldo = 0;
            Console.WriteLine("Ingresar nombre");
            nombre=Console.ReadLine();
            Console.WriteLine("Ingresar sueldo");
            sueldo=Single.Parse(Console.ReadLine());

            if (sueldo >= 3000)
            {
                Console.WriteLine($"El usuario {nombre} debe abonar impuestos");
            }
            else
            {
                Console.WriteLine($"El usuario esta excento de impuestos");
            }*/

            /*float num1 = 0;
            float num2 = 0;
            Console.WriteLine("Ingresar el primer número");
            num1=Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar el segundo número");
            num2=Single.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("La suma de los números es: " + (num1 + num2) + "\nLa diferencia de los números es: " + (num1 - num2));
            }
            else
            {
                Console.WriteLine("El producto de los números es: " + (num1 * num2) + "\nLa división de los números es: " + (num1 / num2));
            }*/

            byte num1 = 0;
            Console.WriteLine("Ingrese un número de uno o dos dígitos");
            num1 = Convert.ToByte(Console.ReadLine());

            if ((num1 / 10) >= 1)
            {
                Console.WriteLine("El número es de dos dígitos");
            }
            else
            {
                Console.WriteLine("El número es de un dígito");
            }
        }
    }
}
