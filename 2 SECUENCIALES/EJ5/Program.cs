// Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule 
// y emita por pantalla el promedio final.


using System;

namespace EJ5
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, promedio;
            Console.WriteLine("Ingrese la nota del examen");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del examen");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del examen");
            nota3 = float.Parse(Console.ReadLine());

            promedio = (nota1 + nota2 +nota3) / 3;

            Console.WriteLine("El promedio de los 3 examenes es: " + promedio);
        }
    }
}
