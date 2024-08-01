// Hacer un programa que permita ingresar el año actual y el año de la fecha de nacimiento de una persona y luego calcule y emita por pantalla su edad.

using System;

namespace EJ2
{
    class Program
    {
        static void Main(string[] args)
        {
            int anioActual, fechaNacimiento, edad;
            Console.WriteLine("Ingrese el año actual");
            anioActual = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la fecha de nacimiento:");
            fechaNacimiento = int.Parse(Console.ReadLine());

            edad = anioActual - fechaNacimiento;

            Console.WriteLine("La edad es: " + edad);

        }
    }
}
