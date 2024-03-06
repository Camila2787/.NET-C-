using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavadoraEjercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definir variables que se utilizarán
            int kilos;
            string tipoRopa;
            int temperatura;
            string nombreCliente;
            int tiempoLavado = 0;

            // Aquí se crea el objeto lavadora
            Lavadora lavadora = new Lavadora();

            // Aquí se utiliza un temporizador para contar el tiempo de lavado total
            Stopwatch tiempoLavadoTotal = new Stopwatch();

            // Aquí se utiliza un while para que el usuario solo se pueda salir del lavado con la letra Q en mayúscula
            // y se da la opción de hacer otro lavado con la letra S
            string opcion = "";
            while (opcion.ToUpper() != "Q")
            {
                // Pedir los datos requeridos para el funcionamiento de la lavadora
                Console.WriteLine("Ingrese su nombre:");
                nombreCliente = Console.ReadLine();

                Console.WriteLine("Ingrese la cantidad de kilos de ropa a lavar (entre 10 y 30): ");
               while(!int.TryParse(Console.ReadLine(), out kilos) || kilos<10 || kilos > 30)
                {
                    Console.WriteLine("Solo se aceptan entre 10 kilos a 30 kilos.");
                }

                Console.WriteLine("Ingrese el tipo de ropa a lavar: ");
                Console.WriteLine("\nropa de colores \nalgodón \nlycra \nsedas \njeans \npena \ndrill \nacolchados \nlino \nsabanas ");
                tipoRopa = Console.ReadLine();

                Console.WriteLine("Ingrese la temperatura del agua (en grados Celsius): ");
                temperatura = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Si la ropa está muy sucia: ¿Desea fijar un tiempo de lavado en minutos? (Ingrese el tiempo en minutos o 0 para no fijar): ");
                tiempoLavado = Convert.ToInt32(Console.ReadLine());

                //Mostrar la adición de minutos
                Console.WriteLine($"Adición de {tiempoLavado} min porque la ropa se encuentra muy sucia");
                // Iniciando lavado (Mostrar hora y fecha del lavado, y mostrar nombre del Cliente
                Console.WriteLine($"Iniciando lavado para el cliente: {nombreCliente}");
                Console.WriteLine($"Fecha y hora del lavado: {DateTime.Now}");
                //Iniciar cronometro
                tiempoLavadoTotal.Start();

                // Llamada al método CicloTerminado de la lavadora
                lavadora.CicloTerminado(kilos, tipoRopa, temperatura, tiempoLavado);

                // Detener el cronómetro
                tiempoLavadoTotal.Stop();

                // Mostrar el tiempo total de duración del lavado
                Console.WriteLine($"Tiempo total de lavado: {tiempoLavadoTotal.Elapsed}");

                // Preguntar si desea realizar otro lavado
                Console.WriteLine("¿Desea realizar otro lavado? (S/N) (presione Q para salir): ");
                string respuesta = Console.ReadLine();
                if (respuesta.ToUpper() != "S")
                    break;
            }
        }
    }
}
