using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;
using System.Collections;

namespace LavadoraEjercicio
{
    public class Lavadora
    {
        private string sonidoLlenado = @"C:\Users\camil\Downloads\french-meme-song.wav";
        private string sonidoLavado = @"C:\Users\camil\Downloads\lavadora-lg.wav";
        private string sonidoEnjuague = @"C:\Users\camil\Downloads\copo-dagua.wav";
        private string sonidoSecado = @"C:\Users\camil\Downloads\1-viento-fuerte.wav";
        private List<String> tiposDeRopa = new List<string>();
        private int clientesAtendidos = 0;
        private double costoKilo = 4000;
        private double costoKwh = 516.72;
        private double gananciaDueño = 0;



        //Se crear la clase lavadora que recibe los componentes de la lista y contiene los metodos privados exceptuando el cicloTerminado()
        public Lavadora()
        {
            tiposDeRopa.Add("ropa de colores");
            tiposDeRopa.Add("algodón");
            tiposDeRopa.Add("lycra");
            tiposDeRopa.Add("sedas");
            tiposDeRopa.Add("jeans");
            tiposDeRopa.Add("pena");
            tiposDeRopa.Add("drill");
            tiposDeRopa.Add("acolchados");
            tiposDeRopa.Add("lino");
            tiposDeRopa.Add("sabanas");
        }


        //Se crea el unico metodo publico cicloTerminado, que va a llamar los demas metodos
        public void CicloTerminado(int kilos, string tipoRopa, int temperatura, int tiempoLavado)
        {
            MostrarRecomendacionTemperatura(temperatura);
            Llenar();
            Lavado();
            Enjuague();
            Secado();
            IncrementarClientesAtendidos();
            MostrarFactura(kilos, tipoRopa, temperatura);


        }


        //Se crean los metodos que simulan el proceso de la lavadora
        private void Llenar()
        {
            Console.WriteLine("Llenando...");
            ReproducirSonido(sonidoLlenado);
            Thread.Sleep(7000);
            Console.WriteLine("Llenando...");
        }

        private void Lavado()
        {
            Console.WriteLine($"Iniciando lavado...");
            ReproducirSonido(sonidoLavado);
            Thread.Sleep(5000);
            Console.WriteLine($"lavando...");
            Thread.Sleep(5000);
            Console.WriteLine("Lavado completado.");
        }

        private void Enjuague()
        {
            Console.WriteLine("Iniciando enjuague...");
            ReproducirSonido(sonidoEnjuague);
            Thread.Sleep(7000);
            Console.WriteLine("Enjuando....");
            Thread.Sleep(7000);
            Console.WriteLine("Enjuague completado.");
        }

        private void Secado()
        {
            Console.WriteLine("Secando...");
            ReproducirSonido(sonidoSecado);
            Thread.Sleep(7000);
            Console.WriteLine("Secando...");
            Thread.Sleep(7000);
            Console.WriteLine("Secado completado.");
        }

        private void MostrarRecomendacionTemperatura(int temperatura)
        {
            if (temperatura <= 20)
            {
                Console.WriteLine("Se recomienda agua fría para prendas delicadas.");
            }
            else if (temperatura <= 50)
            {
                Console.WriteLine("Se recomienda agua tibia para prendas más resistentes.");
            }
            else
            {
                Console.WriteLine("Se recomienda agua caliente para prendas gruesas y toallas.");
            }
        }

        private void ReproducirSonido(string rutaSonido)
        {
            try
            {
                SoundPlayer sonido = new SoundPlayer(rutaSonido);
                sonido.Play();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al reproducir el sonido: {ex.Message}");
            }
        }


        //Crear metodo que calcule el total del lavado con iva y tenga en cuenta el aumento del 5% si escoge el tipo de ropa mencionada.
        private double ObtenerCostoLavado(int kilos, string tipoRopa)
        {
            double costoTotal = kilos * costoKilo;
            double costoConIva = costoTotal * 1.19;

            if (tipoRopa.ToLower() == "algodón" || tipoRopa.ToLower() == "ropa de colores")
            {
                costoConIva *= 1.05; // Aumento del 5% para ciertos tipos de ropa
            }

            return costoConIva;
        }



        //Metodo para calcular la ganacia del dueño
        private double ObtenerGanancia(int kilos, string tipoRopa)
        {
            double costoLavado = ObtenerCostoLavado(kilos, tipoRopa);
            double ganancia = costoLavado * 0.3; // 30% de ganancia para el dueño
            gananciaDueño += ganancia;
            return ganancia;
        }


        //Metodo para calcular el consumo de energía.
        private double ObtenerConsumoKwh(int kilos, int temperatura)
        {
            // Lógica para calcular el consumo de kWh
            return kilos * (temperatura / 10) * costoKwh;
        }


        //Metodos para calcular los cientes atendidos
      

        private void IncrementarClientesAtendidos()
        {
            clientesAtendidos++;
        }
    

        //Metodo para llamar y mostrar todos los datos que se deben incluir y mostrarle al cliente en la factura.

    private void MostrarFactura(int kilos, string tipoRopa, int temperatura)
        {
            double costoTotalConIva = ObtenerCostoLavado(kilos, tipoRopa);
            double ganancia = ObtenerGanancia(kilos, tipoRopa);
            double consumoKwh = ObtenerConsumoKwh(kilos, temperatura);

            Console.WriteLine($"Costo total del lavado sin iva: {costoTotalConIva:C}");
            Console.WriteLine($"Ganancia del dueño: {ganancia:C}");
            Console.WriteLine($"Consumo de energía: {consumoKwh} kWh");
            Console.WriteLine($"Cantidad de clientes atendidos: {clientesAtendidos}");
        }

    }
}
