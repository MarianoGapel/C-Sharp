// Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.

// Los numeros primos son aquellos numeros que solamente son divisibles por 1 y por si mismo. 
// Todos los numeros son divisibles por 1 y por si mismo, pero hay numeros que son exclusivamente divisibles por 1 por si mismo, esos son los numeros primos.
// Por ejemplo: el numero 5 es divisible por 1 y por 5, por lo tanto, es un numero primo.
// Pero el numero 8, es divisible por 1, por 2 y por 4, por lo tanto, no es un numero primo.

// La forma que tenemos para resolver si un numero que ingresamos es o no es primo es a traves de un algoritmo:
// Un numero va a ser primo si solamente fue divisible 2 veces, es decir, yo ingreso el numero 25 y lo voy a dividir por todos los numeros desde el 1 hasta el 25.



using System;

namespace EJ3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con, conPrimos = 0;

            for (int x = 0; x < 10; x++) // En este ciclo for ingresaremos 10 numeros distintos, cada vez que ingresamos un numero, el contador debe volver a cero, para poder ingresar al otro ciclo for.
            {
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());

                con = 0; // Este contador se inicia en cero antes de entrar al segundo ciclo, ya que contabiliza la cantidad de veces que el numero ingresado es divisible y nos da 0 como resultado. 
                for (int y = 1; y <= n; y++)        // En este ciclo for que empieza con 1, vamos a calcular el resto del numero ingresado (n), por los numeros que van de 1 hasta el numero ingresado (n). 
                {                                   // Por ejemplo 25, si el resto de dividirlo por todos los numeros que hay desde el 1 hasta el 25. 
                    if(n % y == 0)                  // Por cada vez que el resultado nos de cero, a la variable contador se le suma 1. 
                    con++;                          // En el caso del numero 25, el contador va a sumar 3, ya que 25 % 1 = 0, 25 % 5 = 5, 25 % 25 = 0, tenemos 3 valores que nos da 0 como resultado.
                }                                   // Cuando termine de calcular el resto y haya acumulado los resultados que sean = a 0 en la variable contador, pasaremos a separar cuales son los primos.
                if (con == 2) {                     // Si el contador nos da igual a 2, se trata de un numero primo, de lo contrario no lo es. 
                    conPrimos++;                    // Por cada vez que la variable con nos de == 2, a la variable conPrimos le sumaremos 1, de ese modo, iremos acumulando los numeros primos.
                    Console.WriteLine("Es primo."); // Y asi se ira repitiendo, hasta que terminemos de ingresar los 10 numeros distintos y luego mostrar por pantalla la cantidad de numeros primos. 
                }                                   // La variable conPrimos, se inicia en 0 antes del ciclo y no vuelve a cero ya que se va a ir acumulando hasta terminar el ciclo y mostrar cuantos son los primos.
            }     
            Console.WriteLine("La cantidad de numeros primos es: " + conPrimos);       
        }
    }     
}     