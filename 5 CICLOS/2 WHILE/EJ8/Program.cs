// Hacer un programa que solicite una lista de números que corta cuando se ingresa un cero y luego mostrar por pantalla el menor y el segundo menor.

using System;

namespace EJ8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m1, m2;
            bool b;
            b = false;        
            Console.WriteLine("Ingrese un numero:");
            n = int.Parse(Console.ReadLine());
            m1 = n;
            m2 = 0;
            while (n != 0)
            {
                if (n < m1)
                {
                    m2 = m1;
                    m1 = n;
                }
                else if (!b){
                    m2 = n;
                    b = true;
                }
                else if (n < m2)
                    m2 = n;

                
                Console.WriteLine("Ingrese un numero:");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("El primer menor es: " + m1);
            Console.WriteLine("El segundo menor es: " + m2);
        }
    }
}