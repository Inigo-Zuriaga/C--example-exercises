using System;
namespace AnimalesNamespace;

public class AnimalDomestico : Animal
{
    public string NombreDueno { get; set; }
    public bool Independiente { get; set; }
    public string Compania { get; set; }
    public string FacilidadCuidado { get; set; }

    // Constructor de la clase derivada
    public AnimalDomestico(string tipo, string raza, string alimentacion, string habitat, bool extinto, double peso, double tamano,
                           string nombreDueno, bool independiente, string compania, string facilidadCuidado)
        : base(tipo, raza, alimentacion, habitat, extinto, peso, tamano)
    {
        NombreDueno = nombreDueno;
        Independiente = independiente;
        Compania = compania;
        FacilidadCuidado = facilidadCuidado;
    }
}