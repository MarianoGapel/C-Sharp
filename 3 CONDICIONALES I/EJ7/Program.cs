// Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el mayor de ellos.

using System;

namespace EJ7
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro1, nro2, nro3, nro4, nMayor;
            Console.WriteLine("Ingrese 4 numeros");
            nro1 = int.Parse(Console.ReadLine());
            nro2 = int.Parse(Console.ReadLine());
            nro3 = int.Parse(Console.ReadLine());
            nro4 = int.Parse(Console.ReadLine());

            if (nro1 > nro2)
                nMayor = nro1;
            else
                nMayor = nro2;
            if (nro3 > nMayor)
                nMayor = nro3;
            if (nro4 > nMayor)
                nMayor = nro4;
            
            Console.WriteLine("El numero mayor ingresado es: " + nMayor);
        }
    }
}
