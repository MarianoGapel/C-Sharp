// Hacer un programa para ingresar cinco números distintos y luego mostrar por pantalla el mayor y el menor de ellos.

using System;

namespace EJ9
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro1, nro2, nro3, nro4, nro5, nMayor, nMenor;
            Console.WriteLine("Ingrese 5 numeros");
            nro1 = int.Parse(Console.ReadLine());
            nro2 = int.Parse(Console.ReadLine());
            nro3 = int.Parse(Console.ReadLine());
            nro4 = int.Parse(Console.ReadLine());
            nro5 = int.Parse(Console.ReadLine());

            if (nro1 > nro2){
                nMayor = nro1;
                nMenor = nro2;
            }else{
                nMayor = nro2;
                nMenor = nro1;
            }

            if (nro3 > nMayor)
                nMayor = nro3;
            else if (nro3 < nMenor)
                nMenor = nro3;

            if (nro4 > nMayor)
                nMayor = nro4;
            else if (nro4 < nMenor)
                nMenor = nro4;
            
            if (nro5 > nMayor)
                nMayor = nro5;
            else if (nro5 < nMenor)
                nMenor = nro5;
            
            Console.WriteLine("El mayor de los numeros ingresados es: " + nMayor);
            Console.WriteLine("El menor de los numeros ingresados es: " + nMenor);
        }
    }
}
