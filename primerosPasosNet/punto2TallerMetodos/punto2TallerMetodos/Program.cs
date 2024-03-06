using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2TallerMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            salariosCalculador calculator = new salariosCalculador(2700000, 2800000, 3500000);


            //obtener y mostrar el total de los salarios
            double totalSalarios = calculator.sumarSalarios();
            Console.WriteLine("Total de los salarios:" + totalSalarios);

            //Obtener y mostrar el promedio de los salarios
            double promedioSalarios = calculator.calcularPromedioSalarios();
            Console.WriteLine("Promedio de los salarios:" + promedioSalarios);

        }
    }
}
