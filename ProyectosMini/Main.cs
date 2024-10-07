

namespace ProyectosMini;

class Program
{
    static void Main(string[] args)
    {
        Empleado empleado1 = new Empleado("Pedro", "IT");
        Empleado empleado2 = new Empleado("Maria", "Desarrollo de Apps");
        Empleado empleado3 = new Empleado("Juan", "Recursos Humanos");

        empleado1.MostrarInfo();
        empleado2.MostrarInfo();
        empleado3.MostrarInfo();


        //Llamar al método para pedir monedas y realizar la conversión
        Moneda.PedirMonedas();

        Libro libro1 = new Libro("Mortadelo", "Ibañez", 100);
        Libro libro2 = new Libro("Quijote", "Cervantes", 400);

        libro1.MostrarDetalles();
        libro1.esLargo();
    }
}