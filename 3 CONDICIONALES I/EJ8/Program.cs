// Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.
using System;

namespace EJ8
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro1, nro2, nro3, nro4, nMenor;
            Console.WriteLine("ingrese 4 numeros:");
            nro1 = int.Parse(Console.ReadLine());
            nro2 = int.Parse(Console.ReadLine());
            nro3 = int.Parse(Console.ReadLine());
            nro4 = int.Parse(Console.ReadLine());

            if (nro1 < nro2)
                nMenor = nro1;
            else 
                nMenor = nro2;
            if (nro3 < nMenor)
                nMenor = nro3;
            if (nro4 < nMenor)
                nMenor = nro4;
            
            Console.WriteLine("El menor numero ingresado es: " + nMenor);
        }
    }
}
