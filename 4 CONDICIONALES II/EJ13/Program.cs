// Hacer un programa que solicite el ingreso de dos números y luego calcular:
// La resta si el primero es mayor que el segundo.
// La suma si son iguales.
// El producto si el primero es menor.
// Se deberá emitir un cartel por pantalla con el resultado correspondiente.

using System;

namespace EJ13
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro1, nro2, resultado;
            Console.WriteLine("Ingrese dos numeros");
            nro1 = int.Parse(Console.ReadLine());
            nro2 = int.Parse(Console.ReadLine());

            if (nro1 > nro2) {
                resultado = nro1 - nro2;
                Console.WriteLine("El resultado de la resta de los numeros ingresados es: " + resultado);
            }
            if (nro1 == nro2) {
                resultado = nro1 + nro2;
                Console.WriteLine("El resultado de la suma de los numeros ingresados es: " + resultado);
            }
            if (nro1 < nro2) {
                resultado = nro1 * nro2;
                Console.WriteLine("El resultado de la multiplicacion de los numeros ingresados es: " + resultado);
            }
        }
    }
}
