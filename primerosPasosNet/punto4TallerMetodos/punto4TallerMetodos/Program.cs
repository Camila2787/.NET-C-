using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4TallerMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vendedor vendedor = new Vendedor(2000000);

            //calcular y mostrar la comision del vendedor
            decimal ventasTotales = 12000000;
            decimal comision = vendedor.calcularComision(ventasTotales);
            Console.WriteLine("La comision del vendedor es: $" + comision);

            //Calcular y mostrar el total de una venta incluyendo el IVA
            decimal venta = 500;
            decimal iva = 10;
            decimal totalVenta = vendedor.calcularTotalVenta(venta, iva);
            Console.WriteLine("El total de la venta incluyendo el IVA es: $" + totalVenta);

        }
    }
}
