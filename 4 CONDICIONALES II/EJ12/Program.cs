// Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.

using System;

namespace EJ12
{
    class Program
    {
        static void Main(string[] args)
        {   
            int nro1, nro2, nro3, r1, r2;
            Console.WriteLine("Ingres 3 numeros");
            nro1 = int.Parse(Console.ReadLine());
            nro2 = int.Parse(Console.ReadLine());
            nro3 = int.Parse(Console.ReadLine());

            r1 = nro1 + nro2;
            r2 = nro2 * nro3;

            if (r1 > r2)
                Console.WriteLine("Es mayor");
        }
    }
}
