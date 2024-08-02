// Hacer un programa que solicite 10 números y luego mostrar por pantalla el máximo de ellos y la posición en la que fue ingresado.

using System;

namespace EJ7
{
    class Program
    {
        static void Main(string[] args)
        {
            int pos, mayor, n;
            mayor = 0;
            pos = 0;
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("ingrese un numero:");
                n = int.Parse(Console.ReadLine());
                if (x == 0) { // Utilizo corchetes dentro del if para que se tenga en cuenta las dos lineas siguientes.
                    mayor = n;
                    pos = 1;    
                }else if (n > mayor){
                    mayor = n;
                    pos = x+1;
                }    
            }
            Console.WriteLine("El mayor es: " + mayor + ". Ubicado en la posicion: " + pos);
        }
    } 
}