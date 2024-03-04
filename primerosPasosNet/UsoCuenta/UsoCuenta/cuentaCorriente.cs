using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoCuenta
{
    internal class cuentaCorriente
    {
        private double saldo;
        private String nombreTitular;
        private long numeroCuenta;

        //Creamos constructor

        public cuentaCorriente(double saldo, string nombreTitular)
        {
            this.saldo = saldo;
            this.nombreTitular = nombreTitular;
            Random rnd = new Random();
            numeroCuenta = Math.Abs(rnd.Next());

        }

        //Método setter para realizar ingresos 
        public void setIngreso(double ingreso)
        {
            if (ingreso < 0)
                Console.WriteLine("No se permiten ingresos negativos");
            else
                saldo += ingreso;
        }

        //Metodo setter para realizar retiros/SALIDAS
        public void setRetiro(double retiro)
        {
            saldo -= retiro;
        }

        //Metodo getter para obtener saldo y datos generales
        private String getSaldo()
        {
            return ("El saldo de la cuenta es: " + saldo);
        }
        //Metodo adicional para realizar transferencias (los metodos estaticos se utilizan para llamar desde la clase sin crear una instancia
        public static void Transferencia(cuentaCorriente titul1, cuentaCorriente titul2, double cantidad)
        {
            titul2.saldo += cantidad;
            titul1.saldo -= cantidad;
        }

        public String getDatosCuenta()
        {
            return "Titular:" + nombreTitular + "\n" +
                "No cuenta" + numeroCuenta + "\n" + "Saldo:" + saldo;
        }
    }
}
