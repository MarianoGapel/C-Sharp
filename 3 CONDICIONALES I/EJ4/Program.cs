// Hacer un programa para ingresar un número y luego se emita un cartel por pantalla “Positivo” si el número es mayor a cero, “Negativo” si el número es menor a cero o “Cero” si el número es igual a cero.

using System;

namespace EJ4
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro;
            Console.WriteLine("Ingrese un numero:");
            nro = int.Parse(Console.ReadLine());

            if (nro > 0)
                Console.WriteLine("Positivo");
            else if (nro == 0)
                Console.WriteLine("Cero");
            else 
                Console.WriteLine("Negativo");
        }
    }
}
