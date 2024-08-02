//Hacer un programa para ingresar 10 números y luego calcule y emita el mayor de los primos de la lista. En caso de no haber ningún número primo, deberá aclararlo con un cartel.

using System;

namespace EJ11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con, maxP;
            bool primo = false;
            maxP = 0;

            for (int x = 0; x < 10; x++)
            {
                con = 0;
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());
                for (int y = 1; y <= n; y++)
                {
                    if (n % y == 0)
                        con++;
                }
                if (con == 2)
                    if (!primo)
                    {
                        maxP = n;
                        primo = true;
                    }
                    else if (n > maxP)
                        maxP = n;

            }
            if (maxP == 0)
                    Console.WriteLine("No se ingresaron numeros primos");
            else 
            Console.WriteLine("El mayor de los numeros primos es: " + maxP);
        }
    }
}
// -Se declaran varias variables: n para almacenar cada número ingresado, con para contar la cantidad de divisores de un número, 
//  maxP para almacenar el mayor número primo encontrado y primo para llevar un registro de si se ha encontrado algún número primo hasta el momento.
// -Se inicializan maxP en 0 y primo en false, ya que aún no se ha encontrado ningún número primo.
// -A continuación, comienza un bucle for que se ejecutará 10 veces, ya que el objetivo es solicitar 10 números.
// -Dentro del bucle, se inicializa con en 0 para contar la cantidad de divisores de cada número ingresado.
// -Se imprime por pantalla "Ingrese un número: " y se lee el número ingresado por el usuario utilizando int.Parse(Console.ReadLine()).

// -Se inicia un segundo bucle for que se ejecutará desde y = 1 hasta y <= n, con el objetivo de contar los divisores del número ingresado (n).

// -Dentro del segundo bucle, se verifica si n es divisible por y, lo cual se realiza mediante la condición if (n % y == 0). 
//  Si se cumple esta condición, se incrementa con en 1, ya que y es un divisor de n.

// -Una vez finalizado el segundo bucle, con contendrá la cantidad de divisores que tiene n. Si con es igual a 2, significa que el número n es primo, 
//  ya que los números primos solo tienen dos divisores: 1 y ellos mismos.

// -Si con es igual a 2, se entra en el primer bloque if dentro del bucle principal. 
// En este bloque, se verifica si primo es false (es decir, si aún no se ha encontrado ningún número primo). 
// Si primo es false, se asigna el valor de n a maxP, y se establece primo como true para indicar que se ha encontrado al menos un número primo. 
// Si primo ya es true, se compara n con el valor actual de maxP, y si n es mayor, se actualiza maxP con el nuevo valor.

// -El bucle principal continúa hasta que se hayan ingresado los 10 números.

// -Una vez finalizado el bucle, se emite por pantalla el resultado. Si primo sigue siendo false, significa que no se encontró ningún número primo en la lista de 10 números, 
//  por lo que se mostrará el mensaje "El mayor de los números primos es: 0" (ya que maxP se inicializó en 0). Si se encontró al menos un número primo, 
//  se mostrará el valor de maxP como "El mayor de los números primos es: ..." con el número primo encontrado.