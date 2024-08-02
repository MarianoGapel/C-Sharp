// Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.

using System;

namespace EJ10
{
    class Program
    {
        static void Main(string[] args)
        {
            int minI, maxP, n;
            bool bI, bP;
            bI = false;
            bP = false;
            minI = 0;
            maxP = 0;
            
            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un numero:");
                n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    if (!bP) // if(!false) que es igual a if(true)
                    {
                        maxP = n;
                        bP = true;
                    }
                    else if (n > maxP)
                        maxP = n;
                }
                else 
                {
                    if (!bI)
                    {
                        minI = n;
                        bI = true;
                    }
                
                    else if (n < minI)
                        minI = n;
                }
            }
            Console.WriteLine("El maximo par es: " + maxP);
            Console.WriteLine("El minimo impar es: " + minI);
        }
    }
}

// Al inicio del programa, se inicializa bP con el valor false, ya que aún no se ha encontrado ningún número par.
// En la primera entrada del ciclo, si el número ingresado (n) es par (n % 2 == 0 es verdadero), se ejecutará el bloque dentro del if. 
// En esta primera iteración, la condición if (!bP) será if (!false), que es equivalente a if (true).
// Por lo tanto, se ejecutará la acción especial dentro del if, que es asignar el valor de n a maxP y cambiar bP a true.

// A partir de ese momento, bP se convierte en true. Esto significa que ya se ha encontrado al menos un número par en las iteraciones anteriores.

// En las siguientes iteraciones del ciclo, si se ingresan más números pares, la condición if (!bP) se evaluará como if (!true) que es equivalente a if (false). 
// En estas iteraciones, el bloque dentro del if no se ejecutará, ya que ya se encontró al menos un número par y no se requiere realizar ninguna acción especial.