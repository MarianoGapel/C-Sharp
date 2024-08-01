// El negocio de desinfectante antes mencionado vende además detergente suelto, y los precios se aplican según la siguiente escala:
// a. 25 ARS por litro los primeros 50 litros.
// b. 20 ARS por litro si la venta es de 51 a 200 litros.
// c. 15 ARS por litro si la venta es de 201 a 500 litros.
// d. 10 ARS por litro si la venta es de más de 500 litros.
// Además, si paga en efectivo, tiene un adicional del 10% sobre el importe final.
// Hacer un programa que solicite la cantidad de litros vendidos y el tipo de pago (ingresará 1 si paga en efectivo y 0 con cualquier otro medio de pago) 
// y calcule y emita por pantalla el monto final a abonar por el cliente.


using System;

namespace EJ8
{
    class Program
    {
        static void Main(string[] args)
        {
            int l;
            float monto, descuento, montoFinal;
            Console.WriteLine("Cantidad de litros vendidos:");
            l = int.Parse(Console.ReadLine());

            if (l > 500)
                monto = l * 10;
            else if (l >= 201 && l <= 500)
                monto = l * 15;
            else if (l >= 51 && l <= 200)
                monto = l * 20;
            else 
                monto = l * 25;
            
            Console.WriteLine("Si desea pagar en efectivo y tener un 10% de descuento, presione 1. De lo contrario presione 0.");
            descuento = float.Parse(Console.ReadLine());

            if (descuento == 1)
                descuento = monto * 0.10F;
            
            montoFinal = monto - descuento;
            Console.WriteLine("EL monto final es: " + montoFinal);
        }
    }
}