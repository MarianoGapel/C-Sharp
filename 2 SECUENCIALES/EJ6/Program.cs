// Hacer un programa para ingresar por teclado los metros cuadrados totales de un predio y los metros cuadrados cubiertos; 
// luego calcular y mostrar por pantalla el porcentaje de metros cuadrados cubiertos y el porcentaje de metros cuadrados descubiertos.

using System;

namespace EJ6
{
    class Program
    {
        static void Main(string[] args)
        { 
            float mct, mcc, mcd, pmcc, pmcd;
            Console.WriteLine("Ingrese los metros cuadrados totales:");
            mct = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese los metros cuadrados cubiertos:");
            mcc = float.Parse(Console.ReadLine());

            mcd = mct - mcc;

            pmcc = (mcc * 100) / mct;
            pmcd = (mcd * 100) / mct;

            Console.WriteLine("El porcentaje de metros cuadrados cubiertos es: " + pmcc + "%");
            Console.WriteLine("El porcentaje de metros cuadrados descubiertos es: " + pmcd + "%");   
        }
    }
}
