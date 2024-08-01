// Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:
//• Si el importe es menor a ARS 1000, no hay descuento.
//• Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
//• Si el importe es ARS 5000 o más, aplica un descuento del 18%.
// Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final con el descuento que corresponda.


using System;

namespace EJ6
{
    class Program
    {
        static void Main(string[] args)
        {
            float importe, importeFinal, descuento;
            Console.WriteLine("Ingrese el monto total a abonar");
            importe = float.Parse(Console.ReadLine());

            importeFinal = 0;
            if (importe >= 5000) {   
                descuento = importe * 0.18F;
                importeFinal = importe - descuento;
                Console.WriteLine("Se aplica un descuento del 18%");
            }if (importe >= 1000 && importe < 5000) { 
                descuento = importe * 0.10F;
                importeFinal = importe - descuento;
                Console.WriteLine("Se aplica un descuento del 10%");
            }if (importe < 1000){  
                importeFinal = importe;
                Console.WriteLine("No se aplica descuento");
            }
            
            Console.WriteLine("El importe final es: " + importeFinal);
        }
    }
}
