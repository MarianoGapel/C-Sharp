// Hacer un programa que solicite 20 números y calcule y emita por pantalla cuántos son positivos (mayores a cero). Se debe mostrar un solo valor: el conteo final.

using System;

namespace EJ2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con;

            con = 0;
            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un numero:");
                n = int.Parse(Console.ReadLine());

                if (n > 0)
                    con++;
            }
            Console.WriteLine("La cantidad de numeros positivos son: " + con);
        }
    }
}