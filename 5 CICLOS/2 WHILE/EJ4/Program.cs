// Hacer un programa que solicite dos números y luego muestre los números entre el menor y el mayor de ellos. Acordate, usando While.

using System;

namespace EJ4
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro1, nro2, mayor, menor;

            Console.WriteLine("Ingrese dos numeros: ");
            nro1 = int.Parse(Console.ReadLine());
            nro2 = int.Parse(Console.ReadLine());

            if (nro1 > nro2) { 
                mayor = nro1;
                menor = nro2;
            }else {
                mayor = nro2;
                menor = nro1;
            }
            while (mayor >= menor)
            {
                Console.WriteLine(menor);
                menor++;   
            }
        }
    }
}