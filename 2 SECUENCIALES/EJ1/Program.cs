// Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.


using System;

namespace EJ1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro, r;
            Console.WriteLine("Ingrese un numero");
            nro = int.Parse(Console.ReadLine());

            r = nro * nro * nro;

            Console.WriteLine("El valor del numero ingresado: " + nro + " elevado al cubo es: " + r);
        }
    }
}
