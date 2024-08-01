// Hacer un programa para ingresar un número y luego se emita por pantalla un cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.

using System;

namespace EJ1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro;
            Console.WriteLine("ingrese un numero");
            nro = int.Parse(Console.ReadLine());

            if (nro > 10)
                Console.WriteLine("Es mayor a 10");
            else
                Console.WriteLine("No es mayor a 10");
        }
    }
}
