using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4TallerMetodos
{
    internal class Vendedor
    {
        private decimal salarioBase;

        //constructor que inicializa el salario base del vendedr
        public Vendedor(decimal salarioBase)
        {
            this.salarioBase = salarioBase;
        }

        //metodo para calcular la comisión del vendedor
        public decimal calcularComision(decimal ventasTotales)
        {
            decimal comision = 0;

            if (ventasTotales >= 10000)
            {
                comision = ventasTotales * 0.20m;
            }

            else if (ventasTotales >= 5000)
            {
                comision = ventasTotales * 0.07m;

            }
            else if(ventasTotales >= 1000)
            {
                comision = ventasTotales * 0.05m;
            }

            return salarioBase + comision;
        }

        //metodo para calcular el valor total de una venta incluyendo el iva
        public decimal calcularTotalVenta(decimal venta, decimal iva)
        {
            return venta + (venta * iva / 100);
        }
   
    }
}
