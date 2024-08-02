// Hacer un programa que solicite la edad de un grupo de personas. El programa deberá pedir edades hasta que se ingrese una edad menor a 18 años. 
// Deberá mostrar por pantalla cuántas personas mayores se registraron.

using System;

namespace EJ3
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, con;
            Console.WriteLine("Ingrese edad: ");
            edad = int.Parse(Console.ReadLine());
            con = 0;

            while (edad >= 18)
            {
               con++;
               Console.WriteLine("Ingrese edad: ");
               edad = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("La cantidad de personas mayores de 18 son: " + con);
        }
    }
}