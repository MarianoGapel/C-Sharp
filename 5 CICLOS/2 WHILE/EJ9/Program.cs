//Realizar el nuevamente el ejercicio 8 pero ahora debe devolver además la posición en la que fue encontrado cada uno de los mínimos.

using System;

namespace EJ9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m1, m2, p, p1, p2;
            bool b;
            b = false;
            Console.WriteLine("Ingrese un numero:");
            n = int.Parse(Console.ReadLine());
            m1 = n;
            m2 = 0;
            p = 1;
            p1 = 1;
            p2 = 1;

            while (n != 0)
            {
                if (n < m1)
                {
                    m2 = m1;
                    m1 = n;
                    p2 = p1;
                    p1 = p;
                    b = true;
                }
                else if (!b)
                {
                    m2 = n;
                    p2 = p;
                }
                else if (n < m2)
                {
                    m2 = n;
                    p2 = p;
                }
                p++;
                Console.WriteLine("Ingrese un numero:");
                n = int.Parse(Console.ReadLine());
                ;
            }

            Console.WriteLine("El primer menor es: " + m1 + ", encontrado en la posición: " + p1);
            Console.WriteLine("El segundo menor es: " + m2 + ", encontrado en la posición: " + p2);
        }
    }
}