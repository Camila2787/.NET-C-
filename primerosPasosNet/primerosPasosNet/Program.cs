using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace primerosPasosNet
{
    internal class Program
    {
        static void Main(string[] args)

        {

            //Punto 2 taller practica (ejercicios que el profesor dejó cuando no pudo realizar clase)


            //        decimal tasaCambioUSD = 0.00027m; 
            //        decimal tasaCambioEUR = 0.00023m; 


            //        Console.Write("Ingrese el salario:");
            //        decimal salarioIngresadoEnPesosCop = Convert.ToDecimal(Console.ReadLine());






            //        decimal salarioEnDolares = salarioIngresadoEnPesosCop * tasaCambioUSD;
            //        decimal salarioEnEuros = salarioIngresadoEnPesosCop * tasaCambioEUR;


            //        Console.WriteLine($"Salario en Pesos: {salarioIngresadoEnPesosCop:C}");
            //        Console.WriteLine($"Salario en Dólares: {salarioEnDolares:C}");
            //        Console.WriteLine($"Salario en Euros: {salarioEnEuros:C}");
            //        Console.WriteLine($"Fecha y Hora de la transacción: {DateTime.Now}");
            //    }
            //}


            //punto 3 practica

            // Solicitar las notas al usuario
            //double nota1, nota2, nota3;

            //aqui lo que se hace es verificar que el usuario no ingrese datos menores a 0 y mayores a 5
            //se utiliza un parse para convertir lo que ingrese el usuario a double
            //y en caso de que no se pueda convertir enviar una excepción
            //        Console.Write("Ingrese la primera nota (máximo 5): ");
            //        if (!double.TryParse(Console.ReadLine(), out nota1) || nota1 < 0 || nota1 > 5)
            //        {
            //            Console.WriteLine("Por favor, ingrese un valor válido para la nota (entre 0 y 5).");
            //            return;
            //        }

            //        Console.Write("Ingrese la segunda nota (máximo 5): ");
            //        if (!double.TryParse(Console.ReadLine(), out nota2) || nota2 < 0 || nota2 > 5)
            //        {
            //            Console.WriteLine("Por favor, ingrese un valor válido para la nota (entre 0 y 5).");
            //            return;
            //        }

            //        Console.Write("Ingrese la tercera nota (máximo 5): ");
            //        if (!double.TryParse(Console.ReadLine(), out nota3) || nota3 < 0 || nota3 > 5)
            //        {
            //            Console.WriteLine("Por favor, ingrese un valor válido para la nota (entre 0 y 5).");
            //            return;
            //        }

            //        // Calcular el promedio
            //        double promedio = (nota1 + nota2 + nota3) / 3;

            //        // Redondear el promedio a 2 decimales
            //        promedio = Math.Round(promedio, 2);

            //        // Imprimir el promedio
            //        Console.WriteLine($"Promedio: {promedio}");

            //        // Verificar si aprobó y mostrar mensaje en color
            //        if (promedio > 3.5)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.WriteLine("¡Aprobaste!");
            //            Console.ResetColor();
            //        }
            //        else
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.WriteLine("No aprobaste.");
            //            Console.ResetColor();
            //        }
            //    }
            //}


            //punto 4 practica
            // Datos de la planta de producción
            //            int empleados = 5;
            //            int diasTrabajados = 6;
            //            int horasDiarias = 8;
            //            int produccionTotal = 1500;

            //            // Calcular indicadores, crear funciones
            //            CalcularProductividadPorHoraIndividual(empleados, diasTrabajados, horasDiarias, produccionTotal);
            //            CalcularProductividadPorDiaIndividual(empleados, diasTrabajados, horasDiarias, produccionTotal);
            //            CalcularProductividadGrupoPorDia(empleados, diasTrabajados, horasDiarias, produccionTotal);
            //            CalcularVariacionAbsolutaHoraHombre(empleados, diasTrabajados, horasDiarias, produccionTotal);
            //            CalcularVariacionRelativaHoraHombre(empleados, diasTrabajados, horasDiarias, produccionTotal);
            //            CalcularVariacionRelativaProduccionGlobal(empleados, diasTrabajados, horasDiarias, produccionTotal);
            //        }

            //        //crear metodos utilizando las funciones para poder realizar la operacion e imprimirla
            //        static void CalcularProductividadPorHoraIndividual(int empleados, int diasTrabajados, int horasDiarias, int produccionTotal)
            //        {
            //            double productividadPorHoraIndividual = produccionTotal / (empleados * diasTrabajados * horasDiarias);
            //            Console.WriteLine($"Productividad Individual por Hora: {productividadPorHoraIndividual} prendas/hora/empleado");
            //        }

            //        static void CalcularProductividadPorDiaIndividual(int empleados, int diasTrabajados, int horasDiarias, int produccionTotal)
            //        {
            //            double productividadPorDiaIndividual = produccionTotal / (empleados * diasTrabajados);
            //            Console.WriteLine($"Productividad Individual por Día: {productividadPorDiaIndividual} prendas/día/empleado");
            //        }

            //        static void CalcularProductividadGrupoPorDia(int empleados, int diasTrabajados, int horasDiarias, int produccionTotal)
            //        {
            //            double productividadGrupoPorDia = produccionTotal / diasTrabajados;
            //            Console.WriteLine($"Productividad del Grupo por Día: {productividadGrupoPorDia} prendas/día");
            //        }

            //        static void CalcularVariacionAbsolutaHoraHombre(int empleados, int diasTrabajados, int horasDiarias, int produccionTotal)
            //        {
            //            double productividadInicial = produccionTotal / (empleados * diasTrabajados * horasDiarias);
            //            double productividadFinal = productividadInicial * 1.1; // Asumiendo un aumento del 10%

            //            double variacionAbsoluta = productividadFinal - productividadInicial;
            //            Console.WriteLine($"Variación Absoluta de la Productividad Hora Hombre: {variacionAbsoluta} prendas/hora/empleado");
            //        }

            //        static void CalcularVariacionRelativaHoraHombre(int empleados, int diasTrabajados, int horasDiarias, int produccionTotal)
            //        {
            //            double productividadInicial = produccionTotal / (empleados * diasTrabajados * horasDiarias);
            //            double productividadFinal = productividadInicial * 1.1; // Asumiendo un aumento del 10%

            //            double variacionRelativa = (productividadFinal - productividadInicial) / productividadInicial * 100;
            //            Console.WriteLine($"Variación Relativa de la Productividad Hora Hombre: {variacionRelativa}%");
            //        }

            //        static void CalcularVariacionRelativaProduccionGlobal(int empleados, int diasTrabajados, int horasDiarias, int produccionTotal)
            //        {
            //            int produccionFinal = produccionTotal * 2; // Asumiendo un aumento del 100%

            //            double variacionRelativa = ((double)(produccionFinal - produccionTotal) / produccionTotal) * 100;
            //            Console.WriteLine($"Variación Relativa de la Producción Global: {variacionRelativa}%");
            //        }
            //    }
            //}

            //            Console.WriteLine("Colocar signo de pesos y separadores de mil:");
            //            double precioVenta = 100767.89;

            //            Console.WriteLine($"El precio de venta es: {precioVenta:C}"); //concatenar el precio de venta agregando el signo $
            //            Console.ReadKey(); //salto de linea
            //            Console.WriteLine("---------------------------");

            //        }
            //    }
            //}

            //Formatear porcentaje
            //reto individual


            //Console.WriteLine("Ingrese el nombre del empleado:");
            //string nombreEmpleado = Console.ReadLine();

            //Console.WriteLine("Ingrese el código del empleado:");
            //int codigoEmpleado = Convert.ToInt16(Console.ReadLine());

            //Console.WriteLine("Cantidad de horas laboradas:");
            //int horasLaboradas = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ingrese el valor x hora: ");
            //double valorHora = Convert.ToDouble(Console.ReadLine());

            //double salarioSinFormato = horasLaboradas * valorHora;


            //Console.WriteLine("El salario es:" + salarioSinFormato);

            //double salarioRedondeado = Math.Round(salarioSinFormato, 2);

            //Console.WriteLine($"El salario redondeado a 2 decimales es: {salarioRedondeado:C}");

            //double salarioRedondeadoCercano = Math.Round(salarioSinFormato);
            //Console.WriteLine($"El salario redondeado al numero mas cercano es: {salarioRedondeadoCercano:C}");

            //if (salarioSinFormato >= 2600000)
            //{
            //    Console.WriteLine("Alerta: Este empleado no recibe subsidio de transporte.");
            //}




            //        }

            //    }
            //}

            //reto individual 2

            //            Console.Write("Ingresar su edad: ");
            //            int edad = Convert.ToInt32(Console.ReadLine());

            //            switch (edad)
            //            {
            //                case int n when (n >= 0 && n <= 5):
            //                    Console.WriteLine("Infante");
            //                    break;
            //                case int n when (n >= 6 && n <= 10):
            //                    Console.WriteLine("Niño");
            //                    break;
            //                case int n when (n >= 11 && n <= 15):
            //                    Console.WriteLine("Pre adolescente");
            //                    break;
            //               
            //        }
            //    }
            //}



            //RETO 0

            //            Console.WriteLine("Ingrese el nombre del empleado:");
            //            string nombreEmpleado = Console.ReadLine();

            //            Console.WriteLine("Ingrese el sueldo del empleado:");
            //            double sueldo = Convert.ToDouble(Console.ReadLine());

            //            Console.WriteLine("Ingrese el número de hijos del empleado:");
            //            int numeroHijos = Convert.ToInt32(Console.ReadLine());

            //            double bono = 0;

            //            switch (numeroHijos)
            //            {
            //                case 0:
            //                    if (sueldo <= 1160000)
            //                    {
            //                        bono = 0;
            //                    }
            //                    break;
            //                case int n when (n >= 1 && n <= 3):
            //                    if (sueldo >= 1160000 && sueldo <= 2320000)
            //                    {
            //                        bono = sueldo * 0.10;
            //                    }
            //                    break;
            //                case int n when (n > 3 && n <= 5):
            //                    if (sueldo <= 1160000)
            //                    {
            //                        bono = sueldo * 0.25;
            //                    }
            //                    break;
            //            }

            //            double total = sueldo + bono;

            //            Console.WriteLine($"El bono del empleado es: ${bono:N}");
            //            Console.WriteLine($"El total que el empleado recibirá es: ${total:N}");

            //            Console.WriteLine("\nPresione cualquier tecla para salir...");
            //            Console.ReadKey();
            //        }
            //    }
            //}


            //RETO 2 BECA
            //            Console.WriteLine("Programa para determinar si un estudiante tiene derecho a recibir una beca");
            //            Console.WriteLine("Fecha de simulación: " + DateTime.Now.ToShortDateString());

            //            Console.WriteLine("Ingrese la distancia en kilómetros desde su casa hasta la universidad:");
            //            double distancia = Convert.ToDouble(Console.ReadLine());

            //            Console.WriteLine("Ingrese los ingresos familiares mensuales:");
            //            double ingresosFamiliares = Convert.ToDouble(Console.ReadLine());

            //            Console.WriteLine("Ingrese el estrato del estudiante:");
            //            int estrato = Convert.ToInt32(Console.ReadLine());

            //            if (distancia > 5 && ingresosFamiliares < 600000 && (estrato == 1 || estrato == 2))
            //            
            //                double smlv = 908526; // Valor del Salario Mínimo Legal Vigente para el año 2022
            //                double beca = smlv * 0.44;
            //                Console.WriteLine("¡Felicitaciones! El estudiante cumple con los requisitos para recibir la beca.");
            //                Console.WriteLine("Valor de la beca: $" + beca);
            //            }
            //            else
            //            {
            //                Console.WriteLine("El estudiante no cumple con los requisitos para recibir la beca.");
            //            }
            //        }
            //    }
            //}

            //RETO 3

            //    Console.WriteLine("Bienvenido al programa de subsidios");

            //    Console.WriteLine("Ingrese su edad");
            //    int edad = Convert.ToInt16(Console.ReadLine());

            //    Console.WriteLine("Ingrese su sueldo");
            //    double sueldo = Convert.ToDouble(Console.ReadLine());

            //    double subsidio = 0;

            //    if (sueldo <= 908526)
            //    {
            //        switch (edad)
            //        {
            //            case int n when (n < 18):
            //                Console.WriteLine("La persona no tiene derecho a subsidio porque es menor de 18 años");
            //                break;
            //            case int n when (n >= 18 && n >= 39):
            //                subsidio = sueldo * 0.05;
            //                Console.WriteLine("La persona tiene derecho a su subsidio.");
            //                Console.WriteLine($"El valor del subsidio es: {subsidio:C}");
            //                break;
            //            case int n when (n >= 40 && n <= 64):
            //                subsidio = sueldo * 0.07;
            //                Console.WriteLine("La persona tiene derecho a subsidio.");
            //                Console.WriteLine($"El valor del subsidio es: {subsidio:C}");
            //                break;
            //            default:
            //                subsidio = sueldo * 0.10;
            //                Console.WriteLine("La persona tiene derecho a subsidio.");
            //                Console.WriteLine($"El valor del subsidio es: {subsidio:C}");
            //                Console.WriteLine("Programa adulto mayor");
            //                break;
            //        }

            //        }
            //    else
            //    {
            //        Console.WriteLine("La persona no tiene derecho a subsidio porque su salario excede los $908.526");
            //    }

            //        }
            //    }


            //}
            //reto 5

            //            Console.WriteLine("Bienvenido a la tienda de computadoras");
            //            Console.WriteLine("Por favor, seleccione una opción de compra:");
            //            Console.WriteLine("1. Teclado inalámbrico");
            //            Console.WriteLine("2. Mouse inalámbrico");
            //            Console.WriteLine("3. DRON con cámara");
            //            Console.WriteLine("4. Tablet Huawei");
            //            Console.WriteLine("5. Portátil Lenovo E480");
            //            Console.WriteLine("6. Xbox 360");


            //            int opcion = Convert.ToInt32(Console.ReadLine());

            //            switch (opcion)
            //            {
            //                case 1:
            //                    Console.WriteLine("Teclado inalámbrico");
            //                    Console.WriteLine("Descuento del 3%: $" + (32000 * 0.03));
            //                    break;

            //                case 2:
            //                    Console.WriteLine("Mouse inalámbrico");
            //                    Console.WriteLine("Sin descuento");
            //                    break;
            //                case 3:
            //                    Console.WriteLine("DRON con cámara");
            //                    Console.WriteLine("Descuento del 5%: $" + (10000 * 0.05));
            //                    break;
            //                case 4:
            //                    Console.WriteLine("Table huawei");
            //                    Console.WriteLine("Descuento del 8%: $" + (155000 * 0.08));
            //                    break;
            //                case 5:
            //                    Console.WriteLine("portatil lenovo E480");
            //                    Console.WriteLine("Precio con IVA: $" + (1345000 * 1.19));
            //                    break;
            //                case 6:
            //                    Console.WriteLine("Xbox 360");
            //                    Console.WriteLine("Precio con IVA: $" + (1490000 * 1.19));
            //                    break;
            //                default:
            //                    Console.WriteLine("Producto no existe");
            //                    break;
            //            }
            //        }
            //    }
            //}


            //TALLER 5 

            //PUNTO 1
            //            Console.WriteLine("Ingrese su edad:");
            //            int edad = Convert.ToInt32(Console.ReadLine());

            //            // Verificar si el usuario está inscrito en el evento (supongamos que sí por simplicidad)
            //            bool inscrito = true;

            //            // Verificar si la edad está entre 18 y 25 años y si el usuario está inscrito en el evento
            //            if (edad >= 18 && edad <= 25 && inscrito)
            //            {
            //                Console.WriteLine("Puede pasar, tienes " + edad + " años.");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Lo siento, no puedes pasar, solo tienes " + edad + " años.");
            //            }
            //        }
            //    }
            //}

            //PUNTO 2 (ya realizado, BECA RETO 2)

            //PUNTO 3
            //            // Obtener la velocidad captada por la cámara
            //            Console.WriteLine("Ingrese la velocidad captada por la cámara en km/h:");
            //            int velocidad = Convert.ToInt32(Console.ReadLine());

            //            // Obtener la fecha y hora de la lectura
            //            DateTime fechaHoraLectura = DateTime.Now;

            //            // Determinar la zona en la que está transitando el automóvil y la velocidad máxima permitida
            //            string zona = "";
            //            int velocidadMaxima = 0;

            //            if (velocidad <= 30)
            //            {
            //                zona = "Zona Escolar";
            //                velocidadMaxima = 30;
            //            }
            //            else if (velocidad <= 60)
            //            {
            //                zona = "Vía Urbana";
            //                velocidadMaxima = 60;
            //            }
            //            else if (velocidad <= 80)
            //            {
            //                zona = "Vía Rural";
            //                velocidadMaxima = 80;
            //            }
            //            else
            //            {
            //                zona = "Ruta Nacional";
            //                velocidadMaxima = 100;
            //            }

            //            // Imprimir la información
            //            Console.WriteLine("\nFecha y Hora de la Lectura: " + fechaHoraLectura);
            //            Console.WriteLine("Velocidad captada por la cámara: " + velocidad + " km/h");
            //            Console.WriteLine("Zona en la que está transitando: " + zona);
            //            Console.WriteLine("Velocidad máxima permitida en esta zona: " + velocidadMaxima + " km/h");
            //        }
            //    }
            //}

            //PUNTO 4
//            Console.WriteLine("Ingrese la edad de la persona:");
//            int edad = Convert.ToInt32(Console.ReadLine());

//            double subsidio = 0;

//            if (edad >= 0 && edad <= 5)
//            {
//                subsidio = 0.12 * 908526; // 12% del salario mínimo legal vigente (SMLV)
//                Console.WriteLine("El infante está en un programa de bebés sanos.");
//            }
//            else if (edad >= 6 && edad <= 10)
//            {
//                subsidio = 0.10 * 908526; // 10% del salario mínimo legal vigente (SMLV)
//                Console.WriteLine("El niño está en un programa de niños canguro.");
//            }
//            else if (edad >= 11 && edad <= 15)
//            {
//                subsidio = 0.05 * 908526; // 5% del salario mínimo legal vigente (SMLV)
//                Console.WriteLine("El preadolescente está en un programa de joven sano.");
//            }
//            else if (edad >= 56)
//            {
//                // Simulando el cálculo del subsidio correspondiente al IPC del mes evaluado
//                double ipc = 0.03; // Supongamos un IPC del 3%
//                subsidio = ipc * 908526; // IPC * salario mínimo legal vigente (SMLV)
//                Console.WriteLine("El anciano está en un programa de adulto mayor.");
//            }

//            Console.WriteLine("El subsidio correspondiente es: $" + subsidio);
//        }
//    }
//}


            //PUNTO 5

// Menú de opciones
//        Console.WriteLine("Bienvenido a la entidad bancaria");
//        Console.WriteLine("Por favor, seleccione una opción:");
//        Console.WriteLine("1. Servicio de caja");
//        Console.WriteLine("2. Servicio al cliente");
//        Console.WriteLine("3. Pago de impuestos");
//        Console.WriteLine("4. Crédito hipotecario");
//        Console.WriteLine("5. Operaciones con tarjeta de crédito");

//        // Leer la opción seleccionada por el usuario
//        int opcion = Convert.ToInt32(Console.ReadLine());

//        // Generar número de ticket aleatorio
//        Random random = new Random();
//        int numeroTicket = random.Next(1000, 10000);

//        // Obtener ID de la sucursal (simulado con un valor aleatorio)
//        int idSucursal = random.Next(1, 100);

//        // Obtener fecha y hora actual
//        DateTime fechaHoraActual = DateTime.Now;

//        // Imprimir información del ticket
//        Console.WriteLine("\nNúmero del Ticket: " + numeroTicket);
//        Console.WriteLine("ID de la Sucursal: " + idSucursal);
//        Console.WriteLine("Fecha y Hora Actual: " + fechaHoraActual);

//        // Determinar para qué servicio va el usuario
//        string servicio = "";
//        switch (opcion)
//        {
//            case 1:
//                servicio = "Servicio de caja";
//                break;
//            case 2:
//                servicio = "Servicio al cliente";
//                break;
//            case 3:
//                servicio = "Pago de impuestos";
//                break;
//            case 4:
//                servicio = "Crédito hipotecario";
//                break;
//            case 5:
//                servicio = "Operaciones con tarjeta de crédito";
//                break;
//            default:
//                Console.WriteLine("Opción no válida");
//                return; // Salir del programa si la opción no es válida
//        }

//        // Imprimir para qué servicio va el usuario
//        Console.WriteLine("Para qué servicio va: " + servicio);
//    }
//}









