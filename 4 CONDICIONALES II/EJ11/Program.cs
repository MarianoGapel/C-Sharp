// Hacer un programa para ingresar tres números y luego mostrarlos ordenados de menor a mayor.

using System;

namespace EJ11
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro1, nro2, nro3, menor, medio, mayor;
            Console.WriteLine("ingresar 3 numeros");
            nro1 = int.Parse(Console.ReadLine());
            nro2 = int.Parse(Console.ReadLine());
            nro3 = int.Parse(Console.ReadLine());
            
            mayor = 0;
            menor = 0;
            medio = 0;

            if (nro1 > nro2){
                mayor = nro1;
                menor = nro2;
            }else {
                mayor = nro2;
                menor = nro1;
            }if (nro3 > mayor)
                mayor = nro3;
            if (nro3 < menor)
                menor = nro3;
            else 
                medio = nro3;
            if (nro1 > menor && nro1 < mayor)
                medio = nro1;
            if (nro2 > menor && nro2 < mayor)
                medio = nro2;
            
            Console.WriteLine("Los numeros ordenados de menor a mayor son: " + menor + ", " + medio + ", " + mayor);
        }
    }
}
