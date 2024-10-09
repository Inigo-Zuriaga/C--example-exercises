using System;
namespace AnimalesNamespace;

public class Animal
{
    public string Tipo { get; set; }
    public string Raza { get; set; }
    public string Alimentacion { get; set; }
    public string Habitat { get; set; }
    public bool Extinto { get; set; }
    public double Peso { get; set; }
    public double Tamano { get; set; }

    // Constructor de la clase base CTRL + . creas el constructor
    public Animal(string tipo, string raza, string alimentacion, string habitat, bool extinto, double peso, double tamano)
    {
        Tipo = tipo;
        Raza = raza;
        Alimentacion = alimentacion;
        Habitat = habitat;
        Extinto = extinto;
        Peso = peso;
        Tamano = tamano;
    }

}