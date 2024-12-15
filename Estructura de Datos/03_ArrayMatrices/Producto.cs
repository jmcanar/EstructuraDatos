namespace EstructuraDatos;

public class Producto
{
    // Propiedades del producto
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Unidad { get; set; }
    
    // Array para almacenar tres precios
    public double[] Precios { get; set; }

    // Constructor
    public Producto(int id, string nombre, string unidad)
    {
        Id = id;
        Nombre = nombre;
        Unidad = unidad;
        Precios = new double[3]; // Inicialización de array de precios
    }

    // Método para asignar precios
    public void AsignarPrecios(double precio1, double precio2, double precio3)
    {
        Precios[0] = precio1;
        Precios[1] = precio2;
        Precios[2] = precio3;
    }

    // Método para mostrar información del producto
    public void MostrarInformacion()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Unidad: {Unidad}");
        Console.WriteLine("Precios:");
        for (int i = 0; i < Precios.Length; i++)
        {
            Console.WriteLine($"Precio {i + 1}: {Precios[i]:C2}");
        }
    }
}