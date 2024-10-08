using AnimalesNamespace;

namespace ProyectosMini;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Elige el ejercicio: 1) Empleados. 2)Libros. 3) Conversor Monedas. 4) Cafetera. 5) Animales varios 0) Salir. ");
            int ejercicio = int.Parse(Console.ReadLine());

            switch (ejercicio)
            {
                case 1:
                    Empleado empleado1 = new Empleado("Pedro", "IT");
                    Empleado empleado2 = new Empleado("Maria", "Desarrollo de Apps");
                    Empleado empleado3 = new Empleado("Juan", "Recursos Humanos");

                    empleado1.MostrarInfo();
                    empleado2.MostrarInfo();
                    empleado3.MostrarInfo();
                    break;
                case 2:
                    Libro libro1 = new Libro("Mortadelo", "Ibañez", 100);
                    Libro libro2 = new Libro("Quijote", "Cervantes", 400);

                    libro1.MostrarDetalles();
                    libro1.esLargo();
                    libro2.MostrarDetalles();
                    libro2.esLargo();
                    break;

                case 3:
                    //Llamar al método para pedir monedas y realizar la conversión
                    Moneda.PedirMonedas();
                    break;
                case 4:
                    Cafetera cafe1 = new Cafetera();

                    Console.WriteLine("Agrega una cantidad específica de agua a la cafetera (ml).");
                    double cantidadAgua = double.Parse(Console.ReadLine());
                    cafe1.AgregarAgua(cantidadAgua);

                    Console.WriteLine("Agrega una cantidad específica de cafe a la cafetera (g).");
                    double cantidadCafe = double.Parse(Console.ReadLine());
                    cafe1.AgregarCafe(cantidadCafe);

                    Console.WriteLine("Agrega una cantidad específica de azúcar a la cafetera (g).");
                    double cantidadAzucar = double.Parse(Console.ReadLine());
                    cafe1.AgregarCafe(cantidadAzucar);

                    cafe1.PrepararCafe();
                    break;
                case 5:
                    Animales.PedirAnimales();
                    break;
                case 0:
                    //Cerrar
                    return;
            }
            Console.WriteLine($"\n ---------------------------------------------------------------------------- \n");
        }
    }
}