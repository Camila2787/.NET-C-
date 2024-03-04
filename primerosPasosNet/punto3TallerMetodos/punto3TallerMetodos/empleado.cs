using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3TallerMetodos
{
    internal class empleado
    {
        private string nombre;
        private string apellido;
        private double salario;

        //Constrcutor que inicializa el nombre, apellido y salario
        public empleado(string nombre, string apellido, double salario)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.salario = salario;
        }

        //metodo para imprimir los datos del empleado

        public void imprimirDatos()
        {
            Console.WriteLine("\nDatos del empleado:");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellido: " + apellido);
            Console.WriteLine("Salario: " + salario);
        }
    }
}
