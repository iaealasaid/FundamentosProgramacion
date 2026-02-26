using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.VariablesConstantesTiposDatosOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = -num1;
            Console.WriteLine(num1 + "//" + num2);

            //Aritmeticas
            int num3 = 5 + 6;
            int num4 = 120 - 231;
            int num5 = 12 * 56;
            float num6 = 5 / 3f;
            Console.WriteLine("Suma: {0}, Diferencia: {1}, Multiplicación: {2}, División: {3}", num3, num4, num5, num6);

            //Incremento y decremento
            num3++;
            Console.WriteLine("Incremento: " + num3);
            num4--;
            Console.WriteLine("Decremento: " + num4);
            num5 += 4;
            num3 -= 5;
            num5 *= num3;
            num6 /= num3;

            //Evaluadores númericos
            float num7 = 4 * 3 / 2f;
            float num8 = 4f * (3f / 2);
            float num9 = 4 + 6f * (2 - 1);

            Console.WriteLine(num7);
            Console.WriteLine(num8);
            Console.WriteLine(num9);
        }
    }
}
