using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Parcial1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mes = "";
            string signo = "";

            Console.WriteLine("Ingrese su mes de nacimiento\n(enero, febrero, marzo, abril, mayo, junio, julio, agosto, semptiembre, octubre, noviembre, diciembre)");
            mes = Console.ReadLine();
            Console.WriteLine("Ingrese su signo zodiacal\n(aries, leo, sagitario, tauro, virgo, capricornio, geminis, libra, acuario, cancer, escorpio, piscis)");
            signo = Console.ReadLine();

            if ((mes == "enero" | mes == "febrero" | mes == "marzo" | mes == "abril" | mes == "mayo" | mes == "junio" | mes == "julio" | mes == "agosto" | mes == "septiembre" | mes == "octubre" | mes == "noviembre" | mes == "diciembre") && (signo == "aries" | signo == "leo" | signo == "sagitario" | signo == "tauro" | signo == "virgo" | signo == "capricornio" | signo == "geminis" | signo == "libra" | signo == "acuario" | signo == "cancer" | signo == "escorpio" | signo == "piscis"))
            {
                switch (mes)
                {
                    case "enero":
                        if (signo == "tauro" | signo == "virgo" | signo == "capricornio")
                        {
                            Console.WriteLine("El elemento de la persona es Tierra");
                        }
                        else if (signo == "geminis" | signo == "libra" | signo == "acuario")
                        {
                            Console.WriteLine("El elemento de la persona es Aire");
                        }
                        else
                        {
                            Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                        }
                        break;
                    case "febrero":
                        if (signo == "cancer" | signo == "escorpio" | signo == "piscis")
                        {
                            Console.WriteLine("El elemento de la persona es Agua");
                        }
                        else if (signo == "geminis" | signo == "libra" | signo == "acuario")
                        {
                            Console.WriteLine("El elemento de la persona es Aire");
                        }
                        else
                        {
                            Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                        }
                        break;
                    case "marzo":
                        if (signo == "cancer" | signo == "escorpio" | signo == "piscis")
                        {
                            Console.WriteLine("El elemento de la persona es Agua");
                        }
                        else if (signo == "aries" | signo == "leo" | signo == "sagitario")
                        {
                            Console.WriteLine("El elemento de la persona es Fuego");
                        }
                        else
                        {
                            Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                        }
                        break;
                    case "abril":
                        if (signo == "tauro" | signo == "virgo" | signo == "capricornio")
                        {
                            Console.WriteLine("El elemento de la persona es Tierra");
                        }
                        else if (signo == "aries" | signo == "leo" | signo == "sagitario")
                        {
                            Console.WriteLine("El elemento de la persona es Fuego");
                        }
                        else
                        {
                            Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                        }
                        break;
                    case "mayo":
                        if (signo == "tauro" | signo == "virgo" | signo == "capricornio")
                        {
                            Console.WriteLine("El elemento de la persona es Tierra");
                        }
                        else if (signo == "geminis" | signo == "libra" | signo == "acuario")
                        {
                            Console.WriteLine("El elemento de la persona es Aire");
                        }
                        else
                        {
                            Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                        }
                        break;
                    case "junio":
                        if (signo == "cancer" | signo == "escorpio" | signo == "piscis")
                        {
                            Console.WriteLine("El elemento de la persona es Agua");
                        }
                        else if (signo == "geminis" | signo == "libra" | signo == "acuario")
                        {
                            Console.WriteLine("El elemento de la persona es Aire");
                        }
                        else
                        {
                            Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                        }
                        break;
                    case "julio":
                        if (signo == "cancer" | signo == "escorpio" | signo == "piscis")
                        {
                            Console.WriteLine("El elemento de la persona es Agua");
                        }
                        else if (signo == "aries" | signo == "leo" | signo == "sagitario")
                        {
                            Console.WriteLine("El elemento de la persona es Fuego");
                        }
                        else
                        {
                            Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                        }
                        break;
                    case "agosto":
                        if (signo == "tauro" | signo == "virgo" | signo == "capricornio")
                        {
                            Console.WriteLine("El elemento de la persona es Tierra");
                        }
                        else if (signo == "aries" | signo == "leo" | signo == "sagitario")
                        {
                            Console.WriteLine("El elemento de la persona es Fuego");
                        }
                        else
                        {
                            Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                        }
                        break;
                    case "septiembre":
                        if (signo == "tauro" | signo == "virgo" | signo == "capricornio")
                        {
                            Console.WriteLine("El elemento de la persona es Tierra");
                        }
                        else if (signo == "geminis" | signo == "libra" | signo == "acuario")
                        {
                            Console.WriteLine("El elemento de la persona es Aire");
                        }
                        else
                        {
                            Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                        }
                        break;
                    case "octubre":
                        if (signo == "cancer" | signo == "escorpio" | signo == "piscis")
                        {
                            Console.WriteLine("El elemento de la persona es Agua");
                        }
                        else if (signo == "geminis" | signo == "libra" | signo == "acuario")
                        {
                            Console.WriteLine("El elemento de la persona es Aire");
                        }
                        else
                        {
                            Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                        }
                        break;
                    case "noviembre":
                        if (signo == "cancer" | signo == "escorpio" | signo == "piscis")
                        {
                            Console.WriteLine("El elemento de la persona es Agua");
                        }
                        else if (signo == "aries" | signo == "leo" | signo == "sagitario")
                        {
                            Console.WriteLine("El elemento de la persona es Fuego");
                        }
                        else
                        {
                            Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                        }
                        break;
                    case "diciembre":
                        if (signo == "tauro" | signo == "virgo" | signo == "capricornio")
                        {
                            Console.WriteLine("El elemento de la persona es Tierra");
                        }
                        else if (signo == "aries" | signo == "leo" | signo == "sagitario")
                        {
                            Console.WriteLine("El elemento de la persona es Fuego");
                        }
                        else
                        {
                            Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                        }
                        break;
                    default:
                        Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Los datos no coinciden con ningún elemento zodiacal");
            }
        }
    }
}
