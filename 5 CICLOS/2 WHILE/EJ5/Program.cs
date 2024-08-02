// Hacer un programa que muestre los números del 1 al 100 de 5 en 5. Ejemplo: 0, 5, 10, 15, 20.... 100. Usando While.

using System;

namespace EJ5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            while (n <= 100)
            {
                Console.WriteLine(n);
                n+= 5;   
            }    
        }
    }
}