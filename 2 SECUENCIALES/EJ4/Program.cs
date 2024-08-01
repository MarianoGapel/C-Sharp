using System;
// Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado. 
// Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.

namespace EJ4
{
    class Program
    {
        static void Main(string[] args)
        {
            float totalFacturado, comision, sueldoTotal;
            Console.WriteLine("Ingrese el total facturado por empleado: ");
            totalFacturado = float.Parse(Console.ReadLine());

            comision = totalFacturado * 0.05F;  //Le agrego la letra F para asignarlo como dato float ya que es un numero con decimales //
            sueldoTotal = 15000 + comision;
            Console.WriteLine("El sueldo total a cobrar es igual a: " + sueldoTotal);
        }
    }
}
//100 * 1.2 = 120 (20% de aumento)
//100 * 1.5 = 150 (50% de aumento)
//100 * 0.9 = 90 (10% de descuento o el 90% de 100)
//100 * 0.05 = 5 (95% de descuento o el 5% de 100)