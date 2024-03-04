using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosClasePolimorfismo
{
    public class vehiculoTurismo: Vehiculo
    {
        private int nPuertas;

        public vehiculoTurismo(int nPuertas, String matricula, String marca, String modelo): base(matricula, marca, modelo) 
        {
            this.nPuertas = nPuertas;
        }


        //Metodo getter para retornar el numero de puertas
        public int getPuertas()
        {
            return nPuertas;
        }



        public override string mostrarDatos()
        {
            return "Matricula: " + getMatricula() + "\nMarca: " + getMarca() +
                "\nModelo " +
                getModelo() + "\nNumero de puertas: " + nPuertas;
        }

    }
}
