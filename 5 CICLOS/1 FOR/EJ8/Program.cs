// Hacer un programa que solicite 20 números y luego mostrar por pantalla el menor de ellos y la posición en la que fue encontrado.

using System;

namespace EJ8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, min, pos;
            min = 0;
            pos = 0;
            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un numero:");  
                n = int.Parse(Console.ReadLine());

                if (x == 0) {
                    min = n;
                    pos = 1;
                }else if (n < min) {
                    min = n;
                    pos = x+1;
                }
            }
            Console.WriteLine("El menor numero ingresado es: " + min + " y se encuentra en la posicion: " + pos);  
            
        }
    }
}