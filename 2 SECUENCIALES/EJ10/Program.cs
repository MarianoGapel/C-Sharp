// Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo. 
// Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.


using System;

namespace EJ10
{
    class Program
    {
        static void Main(string[] args)
{
            float distancia, velocidad, tiempo; // utilizo float ya que van a ser numeros con decimales //
            Console.WriteLine("Ingrese la distancia en kilometros entre dos ciudades:");
            distancia = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la velocidad promedio del vehiculo:");
            velocidad = float.Parse(Console.ReadLine());

            tiempo = distancia / velocidad; // KM / KM/H = H //

            Console.WriteLine("El tiempo aproximado que demandara llegar de un punto al otro es de: " + tiempo.ToString("0.00") + " horas");
        }
    }
}
// distancia = km
// velocidad = km/h
// tiempo = km / km/h (los km se tachan)
// tiempo = h
// Si la distancia es 400 km y la velocidad promedio es 100km/h, el tiempo de llegada va a ser de 4 horas. 
// El método ToString("0.00") sirve para reducir el numero de decimales, utilizando solamente los 2 primeros.
// Este método se usa para convertir el valor numérico de 'tiempo' en una cadena de texto con un formato específico. 
// En este caso, "0.00" indica que el número debe ser formateado con dos decimales, sin importar cuántos decimales tenga el valor original. 
// Esto es útil para mostrar los números de manera consistente y legible.