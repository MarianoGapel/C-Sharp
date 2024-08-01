// Hacer un programa para ingresar dos números. Si el segundo es distinto de cero, calcular la división del primero por el segundo y mostrar el resultado por pantalla; 
// caso contrario, emitir un cartel aclarando que no se puede dividir por cero.

using System;

namespace EJ3
{
    class Program
    {
        static void Main(string[] args)
        {
            float nro1, nro2, r;
            Console.WriteLine("Ingrese dos numeros");
            nro1 = float.Parse(Console.ReadLine());
            nro2 = float.Parse(Console.ReadLine());

            r = 0;
            if (nro2 != 0) {  
                r = nro1 / nro2;
                Console.WriteLine("El resultado es: " + r);
            } else  
                Console.WriteLine("No se puede dividir por cero.");   
        }
    }
}
