// Una universidad desea conocer los porcentajes de mujeres y hombres en las carreras de ciencias exactas. 
// Se solicita un programa para cargar la cantidad de mujeres y la cantidad de hombres y que el mismo 
// calcule y emita por pantalla los porcentajes correspondientes.


using System;

namespace EJ8
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantH, cantM, totalE, porcH, porcM;
            Console.WriteLine("Ingrese la cantidad de hombres:");
            cantH = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de mujeres:");
            cantM = int.Parse(Console.ReadLine());

            totalE = cantH + cantM;
            porcH = (cantH * 100) / totalE;
            porcM = (cantM * 100) / totalE;

            Console.WriteLine("El porcentaje de estudiantes hombres es de: " + porcH);
            Console.WriteLine("El porcentaje de estudiantes mujeres es de: " + porcM);
        }
    }
}
