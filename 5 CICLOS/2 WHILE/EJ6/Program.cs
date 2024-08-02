// Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.
// Nota: usando While. Ya lo hicimos con FOR, ahora con While.

using System;

namespace EJ6
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro, x, con;
            x = 1;
            con = 0;
            Console.WriteLine("ingrese un numero:");
            nro = int.Parse(Console.ReadLine());

            while (x <= nro)
            {
                if (nro % x == 0){ 
                    con++;
                }
                x++;        
            }
            if (con == 2)
                Console.WriteLine("Es primo");
            else
                Console.WriteLine("No es primo");
        }
    }
}