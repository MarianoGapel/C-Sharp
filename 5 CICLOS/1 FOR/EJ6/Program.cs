// Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.
// Nota: un número es primo cuando es divisible únicamente por 1 y por sí mismo.


using System;

namespace EJ6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con;
            con = 0;
            Console.WriteLine("Ingrese un numero:");
            n = int.Parse(Console.ReadLine());
            for (int x = 1; x <= n; x++)
            {
                if (n % x == 0)
                    con++;
            }
            if (con == 2)
                Console.WriteLine("Es primo.");
            else
                Console.WriteLine("No es primo.");
        }
    }
}
// El código verifica si el número ingresado es primo o no. El bucle for se inicia desde x = 1 y va hasta x = n, contando cuántos divisores tiene el número n.
// Si el número n tiene exactamente dos divisores (1 y el propio número), entonces se considera primo, ya que los números primos solo tienen dos divisores. 
// De lo contrario, si tiene más de dos divisores, se considera compuesto y, por lo tanto, no es primo.