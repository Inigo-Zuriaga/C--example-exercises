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

Cafetera cafe1 = new Cafetera(1,1,1);

public void AgregarAgua(){
    System.Console.WriteLine("Agrega una cantidad específica de agua a la cafetera.");
    double cantidadAgua = double.Parse(Console.ReadLine());
}}