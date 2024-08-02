// Hacer un programa para mostrar los números del 10 al 1. No se debe realizar ningún pedido de datos. USANDO WHILE.

using System;

namespace EJ2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = 10;

            while (n > 0)
            {
                Console.WriteLine(n); 
                n--;   
            }
            
        }
    }
}