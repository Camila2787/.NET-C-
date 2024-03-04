using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosClasePolimorfismo
{
    public class vehiculoDeportivo : Vehiculo
    {
        private double cilindraje;

        public vehiculoDeportivo(double cilindraje, String matricula, String marca, String modelo) : base(matricula, marca, modelo)
        {
            this.cilindraje = cilindraje;
        }

        public double getCilindraje()
        {
            return this.cilindraje;
        }


        public override string mostrarDatos()
        {
            return "Matricula: " + getMatricula() + "\nMarca: " + getMarca() +
                "\nModelo " +
                getModelo() + "\nCILINDRAJE: " + cilindraje;
        }
    }


}
