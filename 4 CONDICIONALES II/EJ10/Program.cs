// Hacer un programa que solicite cuatro números y emitir un cartel aclaratorio si son todos iguales entre sí, caso contrario, no emitir nada.

using System;

namespace EJ10
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro1, nro2, nro3, nro4;
            Console.WriteLine("Ingrese 4 numeros");
            nro1 = int.Parse(Console.ReadLine());
            nro2 = int.Parse(Console.ReadLine());
            nro3 = int.Parse(Console.ReadLine());
            nro4 = int.Parse(Console.ReadLine());

            if (nro1 == nro2 && nro2 == nro3 && nro3 == nro4)
                Console.WriteLine("Son iguales.");

        }
    }
}
