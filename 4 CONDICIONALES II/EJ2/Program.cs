// Hacer un programa que solicite el ingreso de dos números y luego calcular:
// a. La resta si el primero es mayor que el segundo.
// b. La suma si son iguales.
// c. El producto si el primero es menor.
// Se deberá emitir un cartel por pantalla con el resultado correspondiente.

using System;

namespace EJ2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro1, nro2, r;
            Console.WriteLine("Ingrese dos numeros");
            nro1 = int.Parse(Console.ReadLine());
            nro2 = int.Parse(Console.ReadLine());

            r = 0;
            
            if (nro1 > nro2)
                r = nro1 - nro2;
            if (nro1 == nro2)
                r = nro1 + nro2;
            if (nro1 < nro2)
                r = nro1 * nro2;
            
            Console.WriteLine("El resultado es: " + r);
        }
    }
}
