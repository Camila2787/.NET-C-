using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosClasePolimorfismo
{
   public class Vehiculo
    {
        protected String matricula;
        protected String marca;
        protected String modelo;
        //Cuando se utiliza herencia debe ser protected

        //Se crea el constructor 
        public Vehiculo(string matricula, string marca, string modelo)
        {
            this.matricula = matricula;
            this.marca = marca;
            this.modelo = modelo;
        }

        public Vehiculo()
        {
        }

        public String getMatricula() 
        {  
            return matricula; 
        }

        public String getMarca() 
        {
            return marca;
        }

        public String getModelo() 
        {
            return modelo;
        }
        

        //Virtual para poder realizar polimorfismo
        public virtual string mostrarDatos()
        {
            return "Matricula:" + matricula + "\nMarca: " + marca + "\nModelo: " +
                modelo;
        }


    }
}
