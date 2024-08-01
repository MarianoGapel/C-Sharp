//Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo. 
// Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.


using System;

namespace EJ3
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia, velocidad, tiempo;
            Console.WriteLine("Ingrese la distancia en km entre dos ciudades: ");
            distancia = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la velocidad promedio del vehiculo");
            velocidad = int.Parse(Console.ReadLine());

            tiempo = distancia / velocidad;

            Console.WriteLine("El tiempo que le demandara es de: " + tiempo + " horas.");
        }
    }
}
