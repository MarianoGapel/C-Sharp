// Una importante cadena de delivery cuenta con una promoción por tiempo limitado en la que otorga 
// un 15% de descuento sobre el total del valor de la compra realizada. 
// Hacer un programa para solicitar el monto total y el mismo calcule y emita por pantalla 
// el total a cobrar con el descuento aplicado.


using System;

namespace EJ7
{
    class Program
    {
        static void Main(string[] args)
        {
            float descuento, montoInicial, montoFinal;
            Console.WriteLine("Ingrese el valor de la comprar a realizar:");
            montoInicial = float.Parse(Console.ReadLine());

            descuento = montoInicial * 0.15F;
            montoFinal = montoInicial - descuento;

            Console.WriteLine("El monto final a cobrar con el descuento del 15% es de: " + montoFinal);
        }
    }
}
