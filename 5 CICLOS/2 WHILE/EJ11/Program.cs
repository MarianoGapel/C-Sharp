// Hacer un programa para ingresar una lista de números que corta cuando se ingresa un cero y luego mostrar: 
// la cantidad de números primos, 
// la cantidad de números pares, 
// la cantidad de positivos y 
// la cantidad de negativos.


using System;

namespace EJ11
{
    class Program
    {
        static void Main(string[] args)
{
            int n, cPos, cNeg, cPri, cPa, con, j;
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
            cPos = 0;
            cNeg = 0;
            cPri = 0;
            cPa = 0;
            con = 0;
            j = 1;

            while (n != 0)
            {
                if (n > 0) { 
                    cPos++;
                }else{
                    cNeg++;
                }if (n % 2 == 0){
                    cPa++; 
                    }
            while (j <= n)
            {
                if (n % j == 0){
                con++;
                }
                j++;
            }
            if (con == 2) {
                cPri++;
            }
            Console.WriteLine("Ingrese otro numero:");
            n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("La cantidad de pares son: " + cPa);
            Console.WriteLine("La cantidad de primos son: " + cPri);
            Console.WriteLine("La cantidad de negativos son: " + cNeg);
            Console.WriteLine("La cantidad de positivos son: " + cPos);


        }
    }
}
