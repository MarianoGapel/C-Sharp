// Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.

using System;

namespace EJ10
{
    class Program
    {
        static void Main(string[] args)
            {
            int nro1, nro2, nro3, nro4;
            Console.WriteLine("Ingresaar 4 numeros");
            nro1 = int.Parse(Console.ReadLine());
            nro2 = int.Parse(Console.ReadLine());
            nro3 = int.Parse(Console.ReadLine());
            nro4 = int.Parse(Console.ReadLine());

            if (nro1 > 100)
                Console.WriteLine("El numero ingresado: " + nro1 + " Es mayor a 100");
            if (nro2 > 100)
                Console.WriteLine("El numero ingresado: " + nro2 + " Es mayor a 100");
            if (nro3 > 100)
                Console.WriteLine("El numero ingresado: " + nro3 + " Es mayor a 100");
            if (nro4 > 100)
                Console.WriteLine("El numero ingresado: " + nro4 + " Es mayor a 100");
            else
            {
                Console.WriteLine("Ningun numero ingresado es mayor a 100.");
            }
        }
    }
}
