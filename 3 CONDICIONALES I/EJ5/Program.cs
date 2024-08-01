// Hacer un programa para ingresar un número y mostrar por pantalla un cartel aclaratorio si el mismo es PAR o IMPAR.

using System;

namespace EJ5
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro;
            Console.WriteLine("Ingrese un numero");
            nro = int.Parse(Console.ReadLine());

            if (nro % 2 == 0)
                Console.WriteLine("Es par");
            else
                Console.WriteLine("Es impar");
        }
    }
}
