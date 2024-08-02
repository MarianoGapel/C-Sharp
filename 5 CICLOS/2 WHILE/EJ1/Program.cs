// Hacer un programa para mostrar los números del 1 al 10. No se debe realizar ningún pedido de datos. USANDO WHILE.

using System;

namespace EJ1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = 1;

            while (n <= 10)
            {
                Console.WriteLine(n);
                n ++;    
            }    
            
        }
    }
}