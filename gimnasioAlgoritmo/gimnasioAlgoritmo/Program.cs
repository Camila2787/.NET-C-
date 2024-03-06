using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace gimnasioAlgoritmo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();
            int contadorPersonasAtendidas = 0;

            while (true)
            {
                Console.WriteLine("--Registro Cliente--\n");
                Cliente cliente = new Cliente();

                Console.Write("Nombre Completo:");
                cliente.nombreCompleto = Console.ReadLine();

                Console.Write("Documento:");
                cliente.documento = Console.ReadLine();

                Console.Write("EPS: ");
                cliente.eps = Console.ReadLine();

                Console.Write("Correo Electrónico: ");
                cliente.correoElectronico = Console.ReadLine();

                Console.Write("Dirección:");
                cliente.direccion = Console.ReadLine();

                Console.Write("Telefono:");
                cliente.telefono = Console.ReadLine();

                Console.Write("Fecha de nacimiento(yyyy-mm-day): ");
                cliente.fechaNacimiento = DateTime.Parse(Console.ReadLine());

                Console.Write("Edad: ");
                cliente.edad = int.Parse(Console.ReadLine());

                if (cliente.edad < 15)
                {
                    Console.WriteLine("El cliente no puede ingresar aún debido a que es menor de 15 años.");
                    continue;

                }

                Console.Write("Grado de escolaridad:");
                cliente.gradoEscolaridad = Console.ReadLine();

                Console.Write("Comorbilidades (separadas por coma)");
                string[] comorbilidades = Console.ReadLine().Split(',');

                cliente.Comorbilidades = new List<string>(comorbilidades);

                Console.Write("Peso(kg): ");
                cliente.peso = double.Parse(Console.ReadLine());

                Console.Write("Estatura(m): ");
                cliente.estatura = double.Parse(Console.ReadLine());

                cliente.fechaMatriculacion = DateTime.Now;

                clientes.Add(cliente);
                contadorPersonasAtendidas++;

                Console.WriteLine("\n --Información del cliente--\n");
                Console.WriteLine("Datos personales:");
                Console.WriteLine("Nombre completo: " + cliente.nombreCompleto);
                Console.WriteLine("Documento: " + cliente.documento);
                Console.WriteLine("EPS: " + cliente.eps);
                Console.WriteLine("Correo electrónico:" + cliente.correoElectronico);
                Console.WriteLine("Dirección: " + cliente.direccion);
                Console.WriteLine("Teléfono: " + cliente.telefono);
                Console.WriteLine("Fecha de nacimiento: " + cliente.fechaNacimiento.ToString("yyyy-mm-dd"));
                Console.WriteLine("Edad: " + cliente.edad);
                Console.WriteLine("Grado de escolaridad: " + cliente.gradoEscolaridad);
                Console.WriteLine("Comorbilidades: " + string.Join(", ", cliente.Comorbilidades));
                Console.WriteLine("Fecha de matriculación: " + cliente.fechaMatriculacion.ToString("yyyy-mm-dd HH:mm:ss"));


                double imc = cliente.peso / Math.Pow(cliente.estatura, 2);

                Console.WriteLine("\nÍndice de masa corporal(IMC):" + imc.ToString("F2"));

                string diagnostico = obtenerDiagnostico(imc, cliente.Comorbilidades);

                Console.WriteLine("Diagnóstico:" + diagnostico);

                string recomendaciones = obtenerRecomendaciones(diagnostico);
                Console.WriteLine("Recomendaciones: " + recomendaciones);

                double valorMensualidad = calcularValorMensualidad(cliente.Comorbilidades.Count, cliente.edad);
                string modalidadPago = obtenerModalidadPago();

                Console.WriteLine("\n--Información de pago--\n");
                Console.WriteLine("Valor a pagar: $" + valorMensualidad.ToString("F2"));
                Console.WriteLine("Modalidad de pago: " + modalidadPago);

                Console.WriteLine("\nNúmero de personas atendidas durante la jornada:" + contadorPersonasAtendidas);

                Console.WriteLine("\nPresione enter para continuar o escriba 'salir' para finalizar.");
                string opcion = Console.ReadLine();
                if (opcion.ToLower() == "salir")
                    break;

                Console.Clear();
            }
        }

        static string obtenerDiagnostico(double imc, List<string> comorbilidades)
        {
            if (comorbilidades.Count > 0)
                return "Asignar un intructor especial";
            if (imc > 40)
                return "Debe consultar primero a su eps";

            return "Sin restricciones";

        }

        static string obtenerRecomendaciones(string diagnostico)
        {
            switch (diagnostico)
            {
                case "Asignar un intructor especial":
                    return "Se recomienda que el cliente sea supervisado por un intructor especializado debido a sus comorbilidades";

                case "Debe consultar primero a su EPS":
                    return "Se recomienda que el cliente consule a su eps antes de iniciar cualquier rutina de ejercicio.";

                case "Sin restricciones":
                    return "El cliente no presenta restricciones para iniciar la rutina.";

                default:
                    return "";
            }

        }

        static double calcularValorMensualidad(int cantidadComorbilidades, int edad)
        {
            double valorBase = 70000;
            double descuento = 0;

            if (cantidadComorbilidades > 0)
                descuento = 0;
            else if (edad < 15)
                descuento = 0.1;

            return valorBase * (1 - descuento);
        }

        static string obtenerModalidadPago()
        {
            Console.WriteLine("\nSeleccione la modalidad de pago:");
            Console.WriteLine("1.PAGO DE CONTADO");
            Console.WriteLine("2. TARJETA DE CRÉDITO");

            int opcion;
            while (true)
            {
                Console.Write("Opcion: ");
                if(int.TryParse(Console.ReadLine(), out opcion))
                {
                    if (opcion >= 1 && opcion <= 2)
                        break;
                }

                Console.WriteLine("Opción inválida. Por favor seleccione una opción válida");

            }

            return opcion == 1 ? "Pago de contado(10% de descuento)" : "Tarjeta de crédito";
        }
    }
}
