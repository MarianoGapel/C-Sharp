// Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.
using System;

namespace EJ12
{
    class Program
    {
        static void Main(string[] args)
        {
        
        int n, max = 0, min = 0;
        bool banPar = false, banImpar = false;
        
        for (int x = 0; x < 20; x++)
        {
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0){   
                if(banPar == false){
                    max = n;
                    banPar = true;
                }
                else if(n > max)
                    max = n;
            }else{
                if (banImpar == false){
                    min = n;
                    banImpar = true;
                }                  
                else if(n < min)
                    min = n;
            }
        }
        Console.WriteLine("El mayor par ingresado es: " + max);
        Console.WriteLine("El menor impar ingresado es: " + min);

        }
    }
}


// Se declaran las variables n, max y min. n se utiliza para almacenar el número ingresado por el usuario, max se utiliza para guardar el número par más grande y min para guardar el número impar más pequeño. 
// Se inicializan en 0.

// Se declaran las variables booleanas banPar y banImpar para llevar un seguimiento de si se ha encontrado algún número par e impar respectivamente. Se inicializan en false.

// Se utiliza un bucle for que se ejecuta 20 veces, ya que x se incrementa de 0 a 19. Esto permite que el usuario ingrese 20 números.

// Dentro del bucle, se muestra por pantalla el mensaje "Ingrese un número" y se lee el número ingresado por el usuario utilizando Console.ReadLine(). 
// Luego, se convierte a un entero utilizando int.Parse() y se guarda en la variable n.

// Se utiliza un condicional if para verificar si el número n es par. Esto se hace verificando si el resto de la división de n entre 2 es igual a 0 (n % 2 == 0).

// Si el número n es par, se verifica si banPar es false, lo que significa que no se ha encontrado ningún número par aún. En ese caso, se asigna el valor de n a max y se establece banPar en true.

// Si banPar es true, lo que indica que ya se encontró al menos un número par, se compara el valor de n con max. Si n es mayor que max, se actualiza el valor de max con n.

// Si el número n no es par, se ejecuta el bloque de código del else. Aquí se verifica si banImpar es false, lo que significa que no se ha encontrado ningún número impar aún. 
// En ese caso, se asigna el valor de n a min y se establece banImpar en true.

// Si banImpar es true, lo que indica que ya se encontró al menos un número impar, se compara el valor de n con min. Si n es menor que min, se actualiza el valor de min con n.

// Después de que se hayan ingresado los 20 números, se muestra por pantalla el resultado. 
// Se imprime "El mayor par ingresado es: " seguido del valor de max y "El menor impar ingresado es: " seguido del valor de min.

// En resumen, el código recopila 20 números ingresados por el usuario y encuentra el número par más grande y el número impar más pequeño de esos 20 números. 
// Luego muestra estos resultados por pantalla.