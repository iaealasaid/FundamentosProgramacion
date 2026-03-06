using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.TallerProgramación
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Taller programación

            /*float numero1 = 0f;
            float numero2 = 0f;
            float numero3 = 0f;

            Console.WriteLine("Ingrese números diferentes\n---");
            Console.WriteLine("Ingrese el número 1");
            numero1 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número 2");
            numero2 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número 3");
            numero3 = Single.Parse(Console.ReadLine());

            if (numero1 != numero2 && numero1 != numero3 && numero2 != numero3)
            {
                if (numero2 >  numero3 && numero2 < numero1)
                {
                    Console.WriteLine($"El número mayor es: {numero1}");
                    Console.WriteLine($"Los orden de los números de mayor a menor es: {numero1}, {numero2}, {numero3}");
                }
                else if (numero3 > numero2 && numero3 < numero1)
                {
                    Console.WriteLine($"El número mayor es: {numero1}");
                    Console.WriteLine($"Los orden de los números de mayor a menor es: {numero1}, {numero3}, {numero2}");
                }
                else if (numero1 > numero3 && numero1 < numero2)
                {
                    Console.WriteLine($"El número mayor es: {numero2}");
                    Console.WriteLine($"Los orden de los números de mayor a menor es: {numero2}, {numero1}, {numero3}");
                }
                else if (numero3 > numero1 && numero3 < numero2)
                {
                    Console.WriteLine($"El número mayor es: {numero2}");
                    Console.WriteLine($"Los orden de los números de mayor a menor es: {numero2}, {numero3}, {numero1}");
                }
                else if (numero1 > numero2 && numero1 < numero3)
                {
                    Console.WriteLine($"El número mayor es: {numero3}");
                    Console.WriteLine($"Los orden de los números de mayor a menor es: {numero3}, {numero1}, {numero2}");
                }
                else if (numero2 > numero1 && numero2 < numero3)
                {
                    Console.WriteLine($"El número mayor es: {numero3}");
                    Console.WriteLine($"Los orden de los números de mayor a menor es: {numero3}, {numero2}, {numero1}");
                }
            }
            else
            {
                Console.WriteLine("Debe ingresar números diferentes");
            }*/


            /*bool invencible = false;
            int municion = 0;
            string respuesta = "";
            Random rnd = new Random();
            municion = rnd.Next(1, 11);

            Console.WriteLine($"Tienes {municion} de munición\n¿Su personaje se encuentra en estado invencible? (Ingrese 'si' o 'no')");
            respuesta=Console.ReadLine();

            if (respuesta == "si")
            {
                invencible = true;
            }
            Console.WriteLine(invencible == true && municion >= 1 ? "El personaje está disparando" : "");*/


            /*float x1 = 0;
            float y1 = 0;
            float x2 = 0;
            float y2 = 0;
            float x3 = 0;
            float y3 = 0;

            Console.WriteLine("Ingrese el valor de x para P1");
            x1 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de y para P1");
            y1 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de x para P2");
            x2 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de y para P2");
            y2 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de x para P3");
            x3 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de y para P3");
            y3 = Single.Parse(Console.ReadLine());

            float dP1P2 = (float)Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            float dP2P3 = (float)Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
            float dP1P3 = (float)Math.Sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1));

            bool triangulo = (dP1P2 + dP1P3 > dP2P3) && (dP1P2 + dP2P3 > dP1P3) && (dP2P3 + dP1P3 > dP1P2);
            bool cond1 = (dP1P2 + dP1P3 > dP2P3);
            bool cond2 = (dP1P2 + dP2P3 > dP1P3);
            bool cond3 = (dP2P3 + dP1P3 > dP1P2);

            Console.WriteLine($"Distancias: P1 a P2: {dP1P2} | P2 a P3: {dP2P3} | P1 a P3: {dP1P3}");
            
            if (!triangulo)
            {
                Console.WriteLine("No se puede contruir un triángulo");
                if (!cond1)
                {
                    Console.WriteLine($"No cumple la condición: (P1 a P2) + (P1 a P3) > (P2 a P3) | {dP1P2} + {dP1P3} <= {dP2P3}");
                }
                if (!cond2)
                {
                    Console.WriteLine($"No cumple la condición: (P1 a P2) + (P2 a P3) > (P1 a P3) | {dP1P2} + {dP2P3} <= {dP1P3}");
                }
                if (!cond3)
                {
                    Console.WriteLine($"No cumple la condición: (P2 a P3) + (P1 a P3) > (P1 a P2) | {dP2P3} + {dP1P3} <= {dP1P2}");
                }
            }
            else
            {
                Console.WriteLine("Se puede construir un triángulo");
            }*/


            /*char direccion = ' ';

            Console.WriteLine("El personaje se mueve hacia la izquierda o hacia la derecha, según la tecla que presione en el teclado\n¿Hacia que dirección se mueve el personaje? (Ingrese un carácter)");
            direccion=Convert.ToChar(Console.ReadLine());

            switch (direccion)
            {
                case 'a':
                    Console.WriteLine("El personaje se mueve hacia la izquierda");
                    break;
                case 'd':
                    Console.WriteLine("El personaje se mueve hacia la derecha");
                    break;
                default:
                    Console.WriteLine("No me puedo mover en otra dirección");
                    break;
            }*/


            int vidas;
            Random rnd = new Random();
            vidas = rnd.Next(0, 6);
            char accion = ' ';

            Console.WriteLine($"El jugador tiene {vidas} vida/s");

            if (vidas > 0)
            {
                Console.WriteLine("¿Qué acción va a realizar? (c = disparar, x = hablar con la Rana, t = activar turbo, i = invencibilidad)");
                accion=Convert.ToChar(Console.ReadLine());
                switch (accion)
                {
                    case 'c':
                        Console.WriteLine("El personaje está disparando");
                        break;
                    case 'x':
                        Console.WriteLine("El personaje está hablando con la Rana");
                        break;
                    case 't':
                        Console.WriteLine("El personaje está en modo Turbo");
                        break;
                    case 'i':
                        Console.WriteLine("El personaje es invencible");
                        break;
                    default:
                        Console.WriteLine("El jugador no realizo ninguna acción valida");
                        break;
                }
            }
            else
            {
                Console.WriteLine("El personaje no posee vidas, y no puede realizar ninguna acción");
            }
        }
    }
}
