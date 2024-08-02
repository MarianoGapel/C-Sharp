// Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.

using System;

namespace EJ9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, acu, con, promedio;
            acu = 0;
            con = 0;
            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese una edad:");
                n = int.Parse(Console.ReadLine());              

                if (n >= 18) { 
                    acu += n;
                    con++;
                }
            }
            promedio = acu / con;
            Console.WriteLine("El promedio de edades mayores de 18 años es de: " + promedio);
        }
    }
}
