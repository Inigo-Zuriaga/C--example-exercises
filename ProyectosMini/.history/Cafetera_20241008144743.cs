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

}

public void AgregarAgua(){
    System.Console.WriteLine("");
}