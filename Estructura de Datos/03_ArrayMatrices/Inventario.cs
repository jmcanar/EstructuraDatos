using System;

namespace RegistroDeProductos
{
    // Definición de la clase Producto
    public class Producto
    {
        // Campos públicos para almacenar la información del producto
        public int Id; // Identificador único del producto
        public string Nombre; // Nombre del producto
        public string Unidad; // Unidad de medida del producto (ej. kg, litros)
        public decimal[] Precios; // Array para almacenar tres precios del producto

        // Constructor de la clase Producto
        public Producto(int id, string nombre, string unidad, decimal[] precios)
        {
            Id = id; // Asignar el ID del producto
            Nombre = nombre; // Asignar el nombre del producto
            Unidad = unidad; // Asignar la unidad de medida
            Precios = precios; // Asignar el array de precios
        }

        // Método para mostrar la información del producto
        public void MostrarInformacion()
        {
            // Imprimir el ID del producto
            Console.WriteLine($"ID: {Id}");
            // Imprimir el nombre del producto
            Console.WriteLine($"Nombre: {Nombre}");
            // Imprimir la unidad de medida del producto
            Console.WriteLine($"Unidad: {Unidad}");
            // Imprimir los precios del producto
            Console.WriteLine("Precios:");
            for (int i = 0; i < Precios.Length; i++)
            {
                // Imprimir cada precio formateado como moneda
                Console.WriteLine($"Precio {i + 1}: {Precios[i]:C}");
            }
            // Imprimir una línea en blanco para separar productos
            Console.WriteLine();
        }
    }

    // Clase principal que contiene el método Main
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un array para almacenar productos
            Producto[] productos = new Producto[10]; // Array para almacenar hasta 10 productos

            // Crear algunos productos con sus precios
            decimal[] preciosProducto1 = { 10.99m, 9.99m, 8.99m }; // Precios del primer producto
            productos[0] = new Producto(1, "Arroz", "kg", preciosProducto1); // Crear el primer producto

            decimal[] preciosProducto2 = { 5.49m, 4.99m, 4.49m }; // Precios del segundo producto
            productos[1] = new Producto(2, "Aceite", "litros", preciosProducto2); // Crear el segundo producto

            decimal[] preciosProducto3 = { 2.99m, 2.49m, 1.99m }; // Precios del tercer producto
            productos[2] = new Producto(3, "Sal", "kg", preciosProducto3); // Crear el tercer producto

            // Mostrar la información de los productos
            for (int i = 0; i < productos.Length; i++)
            {
                // Verificar que el producto no sea nulo antes de mostrar la información
                if (productos[i] != null) 
                {
                    productos[i].MostrarInformacion(); // Llamar al método para mostrar la información del producto
                }
            }

            // Esperar a que el usuario presione una tecla antes de cerrar la consola
            Console.ReadLine(); 
        }
    }
}