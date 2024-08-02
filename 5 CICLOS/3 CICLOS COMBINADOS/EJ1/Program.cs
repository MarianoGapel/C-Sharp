// Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
// El fin de la carga se notifica con un número negativo. 
// Luego mostrar cuántos números tiene cada lista. 

using System;

namespace EJ1
{
    class Program
    {
        static void Main(string[] args)
         {
            int n, contador, grupoNumero = 0;
            bool esNegativo = false;

            Console.WriteLine("Ingrese un grupo números positivos separados por cero. Finalice con un número negativo.");

            while (!esNegativo)
            {
                grupoNumero++;
                contador = 0;

                n = int.Parse(Console.ReadLine());

                if (n < 0) {
                    esNegativo = true;
                }
                else
                {
                    while (n > 0) {
                        contador++;
                        n = int.Parse(Console.ReadLine());
                    }

                    if (n == 0) {
                        Console.WriteLine("La cantidad del grupo " + grupoNumero + " es: " + contador);
                    }
                }
            }
            Console.WriteLine("Fin de la carga de datos.");
        }
    }
}