using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3TallerMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre del empleado: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido del empleado: ");
            string apellido = Console.ReadLine();

            Console.WriteLine("Ingrese el salario del empleado: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            //Crear objeto de la clase Empleado utilizando el constructor
            empleado Empleado = new empleado(nombre, apellido, salario);
            Empleado.imprimirDatos();

        }
    }
}
