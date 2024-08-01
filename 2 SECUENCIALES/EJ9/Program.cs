// Hacer un programa que permita ingresar por teclado dos números y que luego muestre por pantalla la suma, la resta, la multiplicación y la división de dichos números. 
// Se deben mostrar cuatro resultados en pantalla. Los números deben ser solicitados una única vez.

using System;

namespace EJ9
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro1, nro2, s, r, m, d;
            Console.WriteLine("ingrese dos numeros");
            nro1 = int.Parse(Console.ReadLine());
            nro2 = int.Parse(Console.ReadLine());

            s = nro1 + nro2;
            r = nro1 - nro2;
            d = nro1 / nro2;
            m = nro1 * nro2;

            Console.WriteLine("El resultado de la suma de " +nro1+ " y " +nro2+ " es: " + s);            
            Console.WriteLine("El resultado de la resta de " +nro1+ " y " +nro2+ " es: " + r);
            Console.WriteLine("El resultado de la division de " +nro1+ " y " +nro2+ " es: " + d);
            Console.WriteLine("El resultado de la multiplicacion de " +nro1+ " y " +nro2+ " es: " + m);
        }
    }
}
