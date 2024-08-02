// Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:
// El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
// Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

using System;

namespace EJ2
{
    class Program
    {
        static void Main(string[] args)
         {
            int n, nTotal, conImpar, grupoImparesMaximo = 0, min, conOrdenados = 0;
            double porcentajeImpares, porcentajeMaximo = 0;
            bool banderaOrdenados;

            for (int i = 0; i < 5; i++)
            {
                nTotal = 0;
                conImpar = 0;
                banderaOrdenados = true;
                Console.WriteLine("Ingrese un número (0 para finalizar el grupo):");
                n = int.Parse(Console.ReadLine());
                min = n;

                while (n != 0)
                {
                    nTotal++;
                    if (n % 2 != 0)
                    {
                        conImpar++;
                    }

                    if (n <= min)
                    {
                        min = n;
                    }
                    else
                    {
                        banderaOrdenados = false;
                    }

                    Console.WriteLine("Ingrese otro número (0 para finalizar el grupo):");
                    n = int.Parse(Console.ReadLine());
                }

                if (nTotal > 0)
                {
                    porcentajeImpares = (double)conImpar * 100 / nTotal;
                    Console.WriteLine($"El porcentaje de números impares en el grupo {i + 1} es: {porcentajeImpares}%");

                    if (porcentajeImpares > porcentajeMaximo)
                    {
                        porcentajeMaximo = porcentajeImpares;
                        grupoImparesMaximo = i + 1;
                    }

                    if (banderaOrdenados)
                    {
                        conOrdenados++;
                    }
                }
            }

            Console.WriteLine($"El grupo con mayor porcentaje de impares es: {grupoImparesMaximo}");
            Console.WriteLine($"La cantidad de grupos con números ordenados es: {conOrdenados}");
        }
    }
}