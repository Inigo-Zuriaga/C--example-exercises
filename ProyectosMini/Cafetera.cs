using System;


namespace ProyectosMini;

public class Cafetera
{

    public double CantidadAgua { get; set; }
    public double CantidadCafe { get; set; }
    public double CantidadAzucar { get; set; }

    public Cafetera()
    {
        CantidadAgua = 0;
        CantidadCafe = 0;
        CantidadAzucar = 0;
    }
    public Cafetera(double cantidadAgua, double cantidadCafe, double cantidadAzucar)
    {
        CantidadAgua = cantidadAgua;
        CantidadCafe = cantidadCafe;
        CantidadAzucar = cantidadAzucar;
    }

    public void AgregarAgua(double cantidad)
    {
        CantidadAgua += cantidad;
        Console.WriteLine($"Has agregado {CantidadAgua}ml de Agua");

    }

    public void AgregarCafe(double cantidad)
    {
        CantidadCafe += cantidad;
        Console.WriteLine($"Has agregado {CantidadCafe}g de Cafe");

    }

    public void AgregarAzucar(double cantidad)
    {
        CantidadAzucar += cantidad;
        Console.WriteLine($"Has agregado {CantidadAzucar}g de Azucar");

    }


    public bool PrepararCafe()
    {

        if (CantidadAgua >= 200 && CantidadCafe >= 15)
        {
            Console.WriteLine("¡El café está listo! Disfrútalo.");
            return true;
        }
        else if (CantidadAgua == 0 && CantidadCafe == 0 && CantidadCafe == 0) //de esta manera al iniciar el programa no mandara error
        {

            return false;
        }
        else
        {
            Console.WriteLine("ERROR: No se puede preparar el café.");

            // Mostrar las cantidades actuales de agua, café y azúcar
            Console.WriteLine($"- Agua disponible: {CantidadAgua}ml (necesarios: 200ml)");
            Console.WriteLine($"- Café disponible: {CantidadCafe}g (necesarios: 15g)");
            Console.WriteLine($"- Azúcar disponible: {CantidadAzucar}g (no hay minimo)");
            return false;
        }
    }
}