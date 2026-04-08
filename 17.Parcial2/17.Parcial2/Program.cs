using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Parcial2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float examen1 = 0f;
            float examen2 = 0f;
            float investigacion = 0f;
            float promedio = 0f;

            Console.WriteLine("Curso de Ciencias Sociales | Nota definitiva con el promedio de las calificaciones del primer período académico\nSe aprueba con una nota igual o superior a 3,5\n");

            for (int contador = 1; contador <= 25; contador++)
            {
                Console.WriteLine($"Estudiante {contador}:\nIngrese la nota que sacó en el primer exámen");
                examen1 = Single.Parse( Console.ReadLine() );
                Console.WriteLine("Ingrese la nota que sacó en el segundo exámen");
                examen2 = Single.Parse( Console.ReadLine() );
                Console.WriteLine("Ingrese la nota que sacó en el trabajo de investigación");
                investigacion = Single.Parse( Console.ReadLine() );

                if (examen1 <= 5.0f && examen1 >= 0.0f && examen2 <= 5.0f && examen2 >= 0.0f && investigacion <= 5.0f && investigacion >= 0.0f)
                {
                    promedio = (examen1 + examen2 + investigacion) / 3f;

                    if (promedio >= 3.5f)
                    {
                        Console.WriteLine($"El promedio del estudiante {contador} fue de: {promedio} | Aprobado\n");
                    }
                    else
                    {
                        Console.WriteLine($"El promedio del estudiante {contador} fue de: {promedio} | Desaprobado\n");
                    }
                }
                else
                {
                    Console.WriteLine($"Hubo un error en las notas ingresadas por el estudiante {contador} y no se pudo calcular el promedio\nAl menos una de las notas se encuentra fuera del rango 0.0 a 5.0 o puso un punto en lugar de una coma al poner una calificación con decimal\n");
                }
            }
        }
    }
}
