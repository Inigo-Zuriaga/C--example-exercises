using Supabase;
using Postgrest;
using Postgrest.Models;  // Esto debería funcionar ahora
using Postgrest.Responses; // Esto también debería funcionar
using System;
using System.Threading.Tasks;
using AnimalesNamespace;

// Clase para representar los datos del animal en la base de datos
public class AnimalData : Postgrest.Models.BaseModel
{
    public int id { get; set; } // Asegúrate de que la base de datos genere este ID automáticamente
    public string tipo { get; set; }
    public string raza { get; set; }
    public string alimentacion { get; set; }
    public string habitat { get; set; }
    public bool extinto { get; set; }
    public double peso { get; set; }
    public double tamano { get; set; }
    public string categoria { get; set; } // base, salvaje, domestico
    public double? velocidad_max { get; set; } // Solo para salvaje
    public bool? cazador { get; set; } // Solo para salvaje
    public int? nv_peligrosidad { get; set; } // Solo para salvaje
    public string nombre_dueno { get; set; } // Solo para domestico
    public bool? independiente { get; set; } // Solo para domestico
    public string compania { get; set; } // Solo para domestico
    public string facilidad_cuidado { get; set; } // Solo para domestico
}

class Program
{
    static async Task Main(string[] args)
    {
        // Inicializamos la conexión con Supabase
        var supabaseUrl = "https://xryiqmpbztcpluqzbijx.supabase.co";
        var supabaseKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InhyeWlxbXBienRjcGx1cXpiaWp4Iiwicm9zZSI6ImFub24iLCJpYXQiOjE3MjgwNTkxOTgsImV4cCI6MjA0MzYzNTE5OH0.1sNRx4FnKQ5gwSc4XTiU3ANAqkXW20fvmLSeDQm4mDs";

        var client = new Supabase.Client(supabaseUrl, supabaseKey);
        await client.InitializeAsync();

        Console.WriteLine("Conectado a Supabase!");

        // Vamos a crear un animal de ejemplo
        var nuevoAnimal = new AnimalData
        {
            tipo = "Mamífero",
            raza = "Tigre",
            alimentacion = "Carnívoro",
            habitat = "Selva",
            extinto = false,
            peso = 220.5,
            tamano = 3.1,
            categoria = "salvaje",
            velocidad_max = 60.0,
            cazador = true,
            nv_peligrosidad = 9
        };

        // Insertamos el animal en la base de datos
        var respuesta = await client.From<AnimalData>().Insert(nuevoAnimal);
        Console.WriteLine("Animal insertado correctamente!");

        // Recuperamos todos los animales de la tabla
        var animales = await client.From<AnimalData>().Get();
        foreach (var animal in animales.Models)
        {
            Console.WriteLine($"Animal: {animal.tipo}, Raza: {animal.raza}, Categoría: {animal.categoria}");
        }
    }
}
