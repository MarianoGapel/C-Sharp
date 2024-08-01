// Hacer un programa para ingresar un valor que estará expresado en minutos. Si los minutos superan los 60, pasar el valor a horas, de lo contrario dejarlo en minutos. 
// Mostrar el resultado en pantalla aclarando si se muestran minutos u horas.

using System;

namespace EJ12
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro, horas;
            Console.WriteLine("Ingresar un valor expresado en minutos:");
            nro = int.Parse(Console.ReadLine());

            if (nro > 60) {  
                horas = nro / 60;
                Console.WriteLine("La cantidad de horas son: " + horas);
            } else 
                Console.WriteLine("La cantidad de minutos son: " + nro);
            
        }
    }
}
