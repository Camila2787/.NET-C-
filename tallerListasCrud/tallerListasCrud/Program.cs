using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tallerListasCrud
{
    internal class Program
    {
        //Se crea la lista como un campo estático para poder que pueda ser compartida
        //y modificada dentro de la clase program
        //Se combierte en un miembro de la clase den lugar de una instancia
        //Es decir que todas las instancias de la clase program compartiran la misma
        //lista de licores en lugar de tener una lista separada por cada
        //instancia
        static List<string> licores = new List<string>();
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("\n---Menú---");
                Console.WriteLine("1. Ingresar licor");
                Console.WriteLine("2. Consultar licor");
                Console.WriteLine("3. Actualizar licor");
                Console.WriteLine("4. Eliminar un licor");
                Console.WriteLine("5. Listar todos los licores");
                Console.WriteLine("0. Salir");

                Console.Write("Ingrese su opcion: ");
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opcion no valida. Por favor, ingrese un número válido.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        ingresarLicor();
                        break;
                    case 2:
                        consultarLicor();
                        break;
                    case 3:
                        actualizarLicor();
                        break;
                    case 4:
                        eliminarLicor();
                        break;
                    case 5:
                        listarLicores();
                        break;
                    case 0:
                        Console.WriteLine("Hasta nunca");
                        break;
                    default:
                        Console.WriteLine("Opcion no válida. Por favor, seleccione una opción válida.");
                        break;

                }
            } while (opcion != 0);
        }

        static void ingresarLicor()
        {
            string licor;
            do
            {
                Console.Write("ingrese el nombre del licor a agregar: ");
                licor = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(licor))
                {
                    licores.Add(licor);
                    Console.WriteLine($"Licor \"{licor}\" agregado con éxito.");

                }
                else
                {
                    Console.WriteLine("El nombre del licor no puede estar vacío. Por favor, intente nuevamente.");
                }

                Console.WriteLine("Desea agregar otro licor? (Si/No): ");
            } while (Console.ReadLine().Trim().ToUpper() == "Si");
        }

        static void consultarLicor()
        {
            string licor;
            do
            {
                Console.Write("Ingrese el nombre del licor a consultar:");
                licor = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(licor))
                {
                    if (licores.Contains(licor))
                    {
                        Console.WriteLine($"El licor \"{licor}\" se encuentra en el inventario.");
                    }
                    else
                    {
                        Console.WriteLine($"El licor \"{licor}\" no se encuentra en el inventario.");
                    }
                }
                else
                {
                    Console.WriteLine("El nombre del licor no puede estar vacío. Por favor, intente nuevamente.");
                }
                Console.WriteLine("¿Desea consultar otro licor? (Si/No):");

            } while (Console.ReadLine().Trim().ToUpper() == "Si");

            }

        static void actualizarLicor()
        {
            string licor;
            do
            {
                Console.Write("Ingrese el nombre del licor a actualizar: ");
                licor = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(licor))
                {
                    if (licores.Contains(licor))
                    {
                        licores.Remove(licor);
                        Console.WriteLine($"El licor \"{licor}\" ha sido eliminado con éxito.");
                        ingresarLicor();
                    }
                    else
                    {
                        Console.WriteLine($"El licor \"{licor}\" no se encuentra en el inventario. No se puede actualizar.");
                    }
                }
                else
                {
                    Console.WriteLine("El nombre del licor no puede estar vacío. Por favor, intente nuevamente.");
                }

                Console.Write("¿Desea actualizar otro licor? (Si/No): ");
            }while (Console.ReadLine().Trim().ToUpper() == "Si");
        }
        static void eliminarLicor()
        {
            string licor;
            do
            {
                Console.Write("Ingrese el nombre del licor a eliminar: ");
                licor = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(licor))
                {
                    if (licores.Contains(licor))
                    {
                        licores.Remove(licor);
                        Console.WriteLine($"El licor \"{licor}\" ha sido eliminado con éxito.");
                    }
                    else
                    {
                        Console.WriteLine($"El licor \"{licor}\" no se encuentra en el inventario. No se puede eliminar.");
                    }
                }
                else
                {
                    Console.WriteLine("El nombre del licor no puede estar vacío. Por favor, intente nuevamente.");
                }

                Console.Write("¿Desea eliminar otro licor? (S/N): ");
            } while (Console.ReadLine().Trim().ToUpper() == "S");
        }

        static void listarLicores()
        {
            Console.WriteLine("\n--- Licores en el inventario ---");
            foreach (var licor in licores)
            {
                Console.WriteLine(licor);
            }
        }
    }


}
        
   

