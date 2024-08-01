//Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente.

using System;

namespace EJ7
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro1, nro2, nro3, nro4;
            Console.WriteLine("Ingresar 4 numeros");
            nro1 = int.Parse(Console.ReadLine());
            nro2 = int.Parse(Console.ReadLine());
            nro3 = int.Parse(Console.ReadLine());
            nro4 = int.Parse(Console.ReadLine());

            if (nro1 > nro2 && nro2 > nro3 && nro3 > nro4)
                Console.WriteLine("Estan ordenados de forma decreciente");
        }
    }
}
