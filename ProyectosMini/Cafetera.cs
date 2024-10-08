using System;


namespace ProyectosMini;

public class Cafetera
{

    public double CantidadAgua { get; set; }
    public double CantidadCafe { get; set; }
    public double CantidadAzucar { get; set; }

    public Cafetera(double cantidadAgua, double cantidadCafe, double cantidadAzucar)
    {
        CantidadAgua = cantidadAgua;
        CantidadCafe = cantidadCafe;
        CantidadAzucar = cantidadAzucar;
    }

public void AgregarAgua(double cantidad){
        CantidadAgua += cantidad;
        Console.WriteLine($"Has agregado{CantidadAgua}ml de Agua");

    }

    public void AgregarCafe(double cantidad)
    {
        CantidadCafe += cantidad;
        Console.WriteLine($"Has agregado{CantidadCafe}g de Cafe");

    }

    public void AgregarAzucar(double cantidad)
    {
        CantidadAzucar += cantidad;
        Console.WriteLine($"Has agregado{CantidadAzucar}g de Azucar");

    }

    public void PrepararCafe
}