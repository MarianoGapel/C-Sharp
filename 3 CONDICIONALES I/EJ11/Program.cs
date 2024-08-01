// Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuántos son menores a 100.
using System;

namespace EJ11
{
    class Program
    {
        static void Main(string[] args)
            {
            int nro1, nro2, nro3, nro4, cont;
            Console.WriteLine("Ingrese 4 numeros");
            nro1 = int.Parse(Console.ReadLine());
            nro2 = int.Parse(Console.ReadLine());
            nro3 = int.Parse(Console.ReadLine());
            nro4 = int.Parse(Console.ReadLine());

            cont = 0;

            if (nro1 < 100)
                cont = cont + 1;
            if (nro2 < 100)
                cont = cont + 1;
            if (nro3 < 100)
                cont = cont + 1;
            if (nro4 < 100)
                cont = cont + 1;
            Console.WriteLine("La cantidad de numeros menores a 100 son: " + cont);
        }
    }
}
