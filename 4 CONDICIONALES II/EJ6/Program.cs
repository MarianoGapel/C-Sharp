//Hacer un programa para ingresar por teclado la longitud de los tres lados de un triángulo y que luego determine e informe con un cartel aclaratorio a qué tipo de triángulo corresponde:
//a. Equilátero: cuando los tres lados sean iguales.
//b. Isósceles: cuando dos de los tres lados sean iguales.
//c. Escaleno: cuando todos los lados sean distintos.


using System;

namespace EJ6
{
    class Program
    {
        static void Main(string[] args)
        {
            int l1, l2, l3;
            Console.WriteLine("Inserte las longitudes de los 3 lados de un triangulo");
            l1 = int.Parse(Console.ReadLine());
            l2 = int.Parse(Console.ReadLine());
            l3 = int.Parse(Console.ReadLine());

            if (l1 == l2 && l2 == l3)
                Console.WriteLine("Equilátero");
            else if (l1 == l2 || l1 == l3 || l2 == l3)
                Console.WriteLine("Isósceles");
            else
                Console.WriteLine("Escaleno");    
        }
    }
}
// La primera condición if (l1 == l2 && l2 == l3) verifica si los tres lados son iguales. Si es cierto, se muestra en la consola el mensaje "Equilátero".
// Si la primera condición no se cumple, se pasa a la siguiente condición else if (l1 == l2 || l1 == l3 || l2 == l3). 
//Esta condición verifica si al menos dos lados son iguales. Si es cierto, se muestra en la consola el mensaje "Isósceles".
// Si ninguna de las condiciones anteriores es verdadera, se ejecuta el bloque de código dentro del else.
// Esto significa que todos los lados son distintos, por lo que se muestra en la consola el mensaje "Escaleno".