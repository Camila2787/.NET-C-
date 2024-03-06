using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace tallerListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Paso 1: Crear una lista con el nombre Empleados.
            //List<string> Empleados = new List<string>();

            ////Paso 2: Agregar 5 empleados a la lista
            //Empleados.Add("Juan");
            //Empleados.Add("María");
            //Empleados.Add("Pedro");
            //Empleados.Add("Luis");
            //Empleados.Add("Ana");

            ////Paso 3: Imprimir los empleados de la lista usando un ciclo for
            //Console.WriteLine("Empleados:");
            //for (int i = 0; i < Empleados.Count; i++)
            //{
            //    Console.WriteLine(Empleados[i]);
            //}

            ////Paso 4: Ordenar ascendentemente los nombres de la lista (método Sort())
            //Empleados.Sort();

            ////Paso 5: Eliminar uno de los empleados (Método remove())
            //Empleados.Remove("Luis");

            ////Paso 6: Eliminar el elemento en el índice deseado
            //Empleados.RemoveAt(2); //Por ejemplo, eliminemos el tercer empleado(Pedro)

            ////Paso 7: Insertar el nombre "Samantha" en el índice 1}
            //Empleados.Insert(1, "Samantha");

            ////Paso 8: Eliminar el último elemento de la lista
            //Empleados.RemoveAt(Empleados.Count - 1);

            ////Paso 9: Desordenar los elementos de nuevo. Metoedo Reverse()
            //Empleados.Reverse();

            ////Imprimir la lista actualizada
            //Console.WriteLine("\nEmpleados actualizados:");
            //foreach (String empleado in Empleados)
            //{
            //    Console.WriteLine(empleado);
            //}




            //EJERCICIO CREADO QUE INCLUYE FOREACH:
            //        Se te ha asignado la tarea de desarrollar un programa en C# para una tienda de abarrotes. La tienda quiere mantener un registro de los productos en stock y su cantidad disponible. Se te pide que escribas un programa que realice lo siguiente:

            //Crea una lista llamada Inventario que almacenará información sobre los productos en stock.Cada elemento de la lista será una cadena que contiene el nombre del producto seguido de un guion y luego la cantidad disponible del producto, por ejemplo, "Arroz-20".

            //Agrega al menos 5 productos al inventario con sus respectivas cantidades.
            //        Utiliza un bucle foreach para mostrar el contenido del inventario en la consola, imprimiendo el nombre del producto y su cantidad disponible en líneas separadas.
            //        La tienda decide agregar nuevos productos al inventario.Crea una lista llamada NuevosProductos que contenga nombres de productos nuevos que deben ser agregados al inventario.
            //        Utiliza otro bucle foreach para recorrer la lista NuevosProductos y agregar cada nuevo producto al inventario con una cantidad inicial de 10 unidades.

            //Imprime nuevamente el contenido actualizado del inventario utilizando un bucle foreach.
            //    



            //Crear la lista con los productos y su cantidad

//            List<string> inventario = new List<string>();

//            inventario.Add("Arroz-20");
//            inventario.Add("Papa-10");
//            inventario.Add("Lentejas-5");
//            inventario.Add("Leche-10");
//            inventario.Add("Sal-25");

//            Console.WriteLine("Inventario actual:");
//            foreach (String producto in  inventario)
//            {
//                Console.WriteLine(producto);
//            }

//            //Crear la lista de productos nuevos
//            List<String> nuevosProductos = new List<String>();

//            foreach (String nuevoProducto in inventario)
//            {
//                Console.WriteLine($"{nuevoProducto}-10");
//            }

//            Console.WriteLine("\nInventario actualizado:");
//            foreach(string producto in inventario)
//            {
//                Console.WriteLine(producto);
//            }
//    }
//}
// }//            List<string> inventario = new List<string>();

//            inventario.Add("Arroz-20");
//            inventario.Add("Papa-10");
//            inventario.Add("Lentejas-5");
//            inventario.Add("Leche-10");
//            inventario.Add("Sal-25");

//            Console.WriteLine("Inventario actual:");
//            foreach (String producto in  inventario)
//            {
//                Console.WriteLine(producto);
//            }

//            //Crear la lista de productos nuevos
//            List<String> nuevosProductos = new List<String>();

//            foreach (String nuevoProducto in inventario)
//            {
//                Console.WriteLine($"{nuevoProducto}-10");
//            }

//            Console.WriteLine("\nInventario actualizado:");
//            foreach(string producto in inventario)
//            {
//                Console.WriteLine(producto);
//            }
//    }
//}
// }



