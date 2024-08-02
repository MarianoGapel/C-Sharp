// Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.

using System;

namespace EJ1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, mayor;
            mayor = 0;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un numero:");
                n = int.Parse(Console.ReadLine());

                if (x == 0)
                    mayor = n;
                else if (n > mayor)
                    mayor = n;
            }
            Console.WriteLine("El mayor numero ingresado es: " + mayor);
        }
    }
}

// EN ESTE CODIGO UTILIZANDO: "if (x == 0)" mayor = n; 
// EL PRIMER NUMERO QUE INGRESE VA A SER GUARDADO COMO MAYOR, PUDIENDO GUARDARSE NUMEROS NEGATIVOS, POR LO TANTO, DE ESTE MODO PODEMOS INGRESAR 
// TANTO NUMEROS POSITIVOS COMO NEGATIVOS. 
