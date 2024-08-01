// Hacer un programa para ingresar dos números distintos y luego se muestre por pantalla el menor de ellos.

using System;

namespace EJ2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro1, nro2;
            Console.WriteLine("Ingrese 2 numeros: ");
            nro1 = int.Parse(Console.ReadLine());
            nro2 = int.Parse(Console.ReadLine());

            if (nro1 < nro2)
                Console.WriteLine("El numero menor es: " + nro1);
            else
                Console.WriteLine("El numero menor es: " + nro2);     
        }
    }
}
