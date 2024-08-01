// Hacer un programa para ingresar dos números y que luego emita por pantalla el mayor de ellos o un cartel aclaratorio “Son iguales” en el caso de que así sea.


using System;

namespace EJ3
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro1, nro2;
            Console.WriteLine("Ingrese dos numeros");
            nro1 = int.Parse(Console.ReadLine());
            nro2 = int.Parse(Console.ReadLine());

            if (nro1 > nro2)
                Console.WriteLine("El mayor es: " + nro1);
            else if (nro2 > nro1) 
                Console.WriteLine("El mayor es: " + nro2);
            else   
                Console.WriteLine("Son iguales");
                
        }  
    }
}
