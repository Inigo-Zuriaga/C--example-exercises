﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundoProyecto
{
    internal class Animales
    {
        //clase base
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

        //clase derivada
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

        //clase derivada
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
        public static void PedirAnimales() //void cuando el método no necesita devolver un valor
        {
            //creo una lista para añadir los animales
            List<Animal> animales = new List<Animal>();

            Console.WriteLine("Hola, cuantos animales quieres añadir?");
            int numAnimales = int.Parse(Console.ReadLine());
            Console.WriteLine("Que tipo de animales quieres añadir?");
            Console.WriteLine("1. Cualquiera.");
            Console.WriteLine("2. Salvajes");
            Console.WriteLine("3. Domesticos");
            Console.WriteLine("Elige 1, 2 o 3:");
            int categoria = int.Parse(Console.ReadLine());

            for (int i = 0; i < numAnimales; i++)
            {



                switch (categoria)
                {
                    case 1:
                        Animal animalBase = pedirAnimalBase();
                        animales.Add(animalBase); //añado a al lista
                        break;
                }
            }
        }

        public static Animal pedirAnimalBase()
        {
            Console.WriteLine("\nIntroduce los datos del animal base:");

            Console.Write("Tipo: ");
            string tipo = Console.ReadLine();

            Console.Write("Raza: ");
            string raza = Console.ReadLine();

            Console.Write("Alimentación: ");
            string alimentacion = Console.ReadLine();

            Console.Write("Hábitat: ");
            string habitat = Console.ReadLine();

            Console.Write("¿Está extinto? (true/false): ");
            bool extinto = bool.Parse(Console.ReadLine());

            Console.Write("Peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Tamaño: ");
            double tamano = double.Parse(Console.ReadLine());

            return new Animal(tipo, raza, alimentacion, habitat, extinto, peso, tamano);
        }
    }
}
