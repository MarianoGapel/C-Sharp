//Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:
//a. Si vende menos de 100 litros, no hay descuento.
//b. Si vende entre 101 y 300 litros, el descuento es del 10%.
//c. Si vende entre 301 y 500 litros, el descuento es del 15%.
//d. Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
//Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y calcule y emita el importe con el descuento aplicado.

using System;

namespace EJ4
{
    class Program
    {
        static void Main(string[] args)
        {
            float l, montoInicial, descuento, montoFinal;
            Console.WriteLine("Ingrese la cantidad de litros vendidos");
            l = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el importe de la venta:");
            montoInicial = float.Parse(Console.ReadLine());

            descuento = 0;
            montoFinal = 0;

            if (l > 500) { 
                descuento = montoInicial * 0.25F;
                montoFinal = montoInicial - descuento;
            }if (l >= 301 && l <= 500) { 
                descuento = montoInicial * 0.15F;
                montoFinal = montoInicial - descuento;
            }if (l >= 101 && l <= 300) { 
                descuento = montoInicial * 0.10F;
                montoFinal = montoInicial - descuento;
            }if (l < 100)
                montoFinal = montoInicial;

            Console.WriteLine("El importe final con el descuento aplicado es de: " + montoFinal);
        }
    }
}
