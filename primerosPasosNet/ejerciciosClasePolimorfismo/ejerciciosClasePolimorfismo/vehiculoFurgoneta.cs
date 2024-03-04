using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosClasePolimorfismo
{
    public class vehiculoFurgoneta: Vehiculo
    {
        private double carga;

        public vehiculoFurgoneta(double carga, String matricula, String marca, String modelo) : base(matricula, marca, modelo) 
        {
            this.carga = carga;
        }

        public double getCarga()
        {
            return carga;
        }

        public override string mostrarDatos()
        {
            return "Matricula: " + getMatricula() + "\nMarca: " + getMarca() +
                "\nModelo " +
                getModelo() + "\nCARGA: " + carga;
        }

    }


}
