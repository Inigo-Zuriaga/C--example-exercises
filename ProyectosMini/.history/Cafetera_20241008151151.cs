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

public void AgregarAgua(){
    System.Console.WriteLine("Agrega una cantidad específica de agua a la cafetera.");
    double cantidadAgua = double.Parse(Console.ReadLine());
}

public void AgregarCafe(){
    System.Console.WriteLine("Agrega una cantidad específica de agua a la cafetera.");
    double cantidadCafe = double.Parse(Console.ReadLine());
}

public void AgregarAzucar(){
    System.Console.WriteLine("Agrega una cantidad específica de agua a la cafetera.");
    double cantidadAgua = double.Parse(Console.ReadLine());
}
}