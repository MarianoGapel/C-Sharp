// Hacer un programa que solicite una lista de números que corta cuando se ingresa un cero y luego mostrar por pantalla el máximo de ellos y la posición en la que fue ingresado.

using System;

namespace EJ7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, max, pos, posmax;

            Console.WriteLine("Ingrese un numero:");
            n = int.Parse(Console.ReadLine());
            max = n;
            pos = 1;
            posmax = pos;
            while (n != 0)
            {
                if (n > max)
                {
                    max = n;
                    posmax = pos;
                }
                pos++;
                Console.WriteLine("Ingrese un numero:");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("El mayor es: " + max + ". En la posicion: " + posmax);
        }
    }
}