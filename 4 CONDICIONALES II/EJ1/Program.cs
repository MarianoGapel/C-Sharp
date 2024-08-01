// Hacer un programa que solicite el ingreso de un número y que luego emita un cartel por pantalla aclarando si el mismo es múltiplo de 5.

using System;

namespace EJ1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro;
            Console.WriteLine("Ingrese un numero");
            nro = int.Parse(Console.ReadLine());

            if (nro % 5 == 0)
                Console.WriteLine("Es multiplo de 5");
        }
    }
}
