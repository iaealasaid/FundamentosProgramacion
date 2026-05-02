using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BorrarPantalla();
            Saludo();
            Console.WriteLine($"Edad: {CalcularEdad()}");
        }
        static void BorrarPantalla()
        {
            Console.Clear();
        }
        static void Saludo()
        {
            string nombre = "Isabella";
            Console.WriteLine($"Bienvenid@ {nombre}");
        }
        static int CalcularEdad()
        {
            int añoActual = 2026;
            int añoNacimiento = 2008;
            int edad = añoActual - añoNacimiento;
            return edad;

        }
        static int CalcularEdad(int añoActual, int añoNacimiento)
        {
            return añoActual - añoNacimiento;
        }
    }
}
