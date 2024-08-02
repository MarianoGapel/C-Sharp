//Hacer un programa que solicite una lista de números que corta cuando se ingresa un cero y luego emitir por pantalla el máximo de los números negativos y el mínimo de los números positivos.

using System;

namespace EJ10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, maxNeg, minPos;
            bool bP, bN;
            bP = false;
            bN = false;
            maxNeg = 0;
            minPos = 0;

            Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                if (n > 0) {
                    if (!bP || n < minPos) {
                        minPos = n;
                        bP = true;
                    }
                }
                else
                {
                    if (!bN || n > maxNeg) {
                        maxNeg = n;
                        bN = true;
                    }
                }

                Console.WriteLine("Ingrese otro numero (0 para terminar):");
                n = int.Parse(Console.ReadLine());
            }

            if (bN)
                Console.WriteLine("El máximo negativo es: " + maxNeg);
            else
                Console.WriteLine("No se ingresaron números negativos.");

            if (bP)
                Console.WriteLine("El mínimo positivo es: " + minPos);
            else
                Console.WriteLine("No se ingresaron números positivos.");
        }
    }
}