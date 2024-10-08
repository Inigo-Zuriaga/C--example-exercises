using System;

namespace ProyectosMini
{
    // Clase que representa una cafetera
    public class Cafetera
    {
        // Propiedades de la clase que almacenan la cantidad de ingredientes
        public double CantidadAgua { get; set; }
        public double CantidadCafe { get; set; }
        public double CantidadAzucar { get; set; }

        // Constructor que inicializa la cafetera con cantidades iniciales de ingredientes
        public Cafetera()
        {
            CantidadAgua = 0;   // Inicializa la cantidad de agua a 0
            CantidadCafe = 0;   // Inicializa la cantidad de café a 0
            CantidadAzucar = 0;  // Inicializa la cantidad de azúcar a 0
        }

        // Método para agregar agua a la cafetera
        public void AgregarAgua(double cantidad)
        {
            CantidadAgua += cantidad; // Aumenta la cantidad de agua
            Console.WriteLine($"Se han agregado {cantidad} ml de agua. Total ahora: {CantidadAgua} ml.");
        }

        // Método para agregar café a la cafetera
        public void AgregarCafe(double cantidad)
        {
            CantidadCafe += cantidad; // Aumenta la cantidad de café
            Console.WriteLine($"Se han agregado {cantidad} g de café. Total ahora: {CantidadCafe} g.");
        }

        // Método para agregar azúcar a la cafetera
        public void AgregarAzucar(double cantidad)
        {
            CantidadAzucar += cantidad; // Aumenta la cantidad de azúcar
            Console.WriteLine($"Se han agregado {cantidad} g de azúcar. Total ahora: {CantidadAzucar} g.");
        }

        // Método para preparar café
        public void PrepararCafe()
        {
            // Verifica si hay suficiente agua y café
            if (CantidadAgua >= 200 && CantidadCafe >= 15)
            {
                // Reduce la cantidad de agua y café utilizadas para preparar un café
                CantidadAgua -= 200;
                CantidadCafe -= 15;
                Console.WriteLine("¡El café está listo! Disfrútalo.");
            }
            else
            {
                // Informa qué ingredientes faltan
                if (CantidadAgua < 200)
                {
                    Console.WriteLine("No hay suficiente agua para preparar el café.");
                }
                if (CantidadCafe < 15)
                {
                    Console.WriteLine("No hay suficiente café para preparar el café.");
                }
            }
        }
    }
}
