namespace ProyectosMini;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Elige el ejercicio: 1) Empleados. 2)Libros. 3) Conversor Monedas. 4) salir ");
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
                Cafetera cafetera = new Cafetera(); // Crear una nueva instancia de Cafetera

        // Agregar agua
        Console.Write("Ingrese la cantidad de agua a agregar (ml): ");
        double cantidadAgua = double.Parse(Console.ReadLine());
        cafetera.AgregarAgua(cantidadAgua);

        // Agregar café
        Console.Write("Ingrese la cantidad de café a agregar (g): ");
        double cantidadCafe = double.Parse(Console.ReadLine());
        cafetera.AgregarCafe(cantidadCafe);

        // Agregar azúcar
        Console.Write("Ingrese la cantidad de azúcar a agregar (g): ");
        double cantidadAzucar = double.Parse(Console.ReadLine());
        cafetera.AgregarAzucar(cantidadAzucar);

        // Intentar preparar el café
        cafetera.PrepararCafe(); // Verifica si es posible preparar el café
                break;
                case 5:
                    //Cerrar
                    return;
            }
            Console.WriteLine("------------------------------------------------------");
        }
    }
}