using System;
using static AnimalesNamespace.Animales;

namespace AnimalesNamespace;

public class AnimalSalvaje : Animal
{
    public double VelocidadMax { get; set; }
    public bool Cazador { get; set; }
    public int NvPeligrosidad { get; set; }

    // Constructor de la clase derivada
    public AnimalSalvaje(string tipo, string raza, string alimentacion, string habitat, bool extinto, double peso, double tamano,
                         double velocidadMax, bool cazador, int nvPeligrosidad)
        : base(tipo, raza, alimentacion, habitat, extinto, peso, tamano)
    {
        VelocidadMax = velocidadMax;
        Cazador = cazador;
        NvPeligrosidad = nvPeligrosidad;
    }
}