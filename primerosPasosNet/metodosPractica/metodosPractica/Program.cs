using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodosPractica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            leerDatosEmpleado();
        }

        static void leerDatosEmpleado()
        {
            Console.WriteLine("Ingrese la fecha (dd/mm/aaaa):");
            string fecha = Console.ReadLine();

            Console.WriteLine("Ingrese nombre del empleado:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese los apellidos del empleado:");
            string apellidos = Console.ReadLine();

            Console.WriteLine("\nDatos del empleado:");
            Console.WriteLine("Fecha: " + fecha);
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellidos: " + apellidos);
        }
    }
}
