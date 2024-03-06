using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2TallerMetodos
{
    internal class salariosCalculador
    {
        private double salario1;
        private double salario2;
        private double salario3;

        //Constructor que inicializa los salarios
        public salariosCalculador(double salario1, double salario2, double salario3)
        {
            this.salario1 = salario1;
            this.salario2 = salario2;
            this.salario3 = salario3;
        }

        //metodo para sumar los salarios

        public double sumarSalarios()
        {
            return salario1 + salario2 + salario3;
        }

        //metodo para calcular el promedio

        public double calcularPromedioSalarios()
        {
            return (salario1 + salario2 + salario3) / 3.0;
        }

    }
}
