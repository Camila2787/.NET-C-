using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoCuenta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cuentaCorriente cuenta1 = new cuentaCorriente(500, "Emiliano Rangel");
            cuentaCorriente cuenta2 = new cuentaCorriente(2500, "Jhonatan Barahona");
            //le pasamos los datos de cada cuenta por parámetro, de una sacamos y
            //llevamos a otra
            cuentaCorriente.Transferencia(cuenta1, cuenta2, 200);
            Console.WriteLine(cuenta1.getDatosCuenta());
            Console.WriteLine(cuenta2.getDatosCuenta());

        }
    }
}
