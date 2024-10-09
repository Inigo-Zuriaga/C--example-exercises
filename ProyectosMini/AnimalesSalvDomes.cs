﻿using System;
using System.Collections.Generic;

namespace AnimalesNamespace
{
    public class Animales
    {
        public static int vueltas = 0;
        public static int numAnimales = 0;

        public static void PedirAnimales()
        {
            List<Animal> animales = new List<Animal>();

            Console.WriteLine("Hola, cuántos animales quieres añadir?");
            numAnimales = int.Parse(Console.ReadLine());
            Console.WriteLine("Qué tipo de animales quieres añadir?");
            Console.WriteLine("1. Cualquiera.");
            Console.WriteLine("2. Salvajes");
            Console.WriteLine("3. Domésticos");
            Console.WriteLine("Elige 1, 2 o 3:");
            int categoria = int.Parse(Console.ReadLine());

            for (int i = 0; i < numAnimales; i++)
            {
                switch (categoria)
                {
                    case 1:
                        vueltas++;
                        Animal animalBase = pedirAnimalBase();
                        animales.Add(animalBase);
                        break;
                    case 2:
                        vueltas++;
                        AnimalSalvaje animalSalvaje = pedirAnimalSalvaje();
                        animales.Add(animalSalvaje);
                        break;
                    case 3:
                        vueltas++;
                        AnimalDomestico animalDomestico = pedirAnimalDomestico();
                        animales.Add(animalDomestico);
                        break;
                }
            }
        }

        public static Animal pedirAnimalBase()
        {
            Console.WriteLine("\nIntroduce los datos del animal base: " + vueltas + " de " + numAnimales);
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

        public static AnimalSalvaje pedirAnimalSalvaje()
        {
            Console.WriteLine("\nIntroduce los datos del animal salvaje: " + vueltas + " de " + numAnimales);
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

            Console.Write("Velocidad Máxima: ");
            double velocidadMax = double.Parse(Console.ReadLine());

            Console.Write("¿Es un cazador? (true/false): ");
            bool cazador = bool.Parse(Console.ReadLine());

            Console.Write("Nivel de Peligrosidad: ");
            int nvPeligrosidad = int.Parse(Console.ReadLine());

            return new AnimalSalvaje(tipo, raza, alimentacion, habitat, extinto, peso, tamano, velocidadMax, cazador, nvPeligrosidad);
        }

        public static AnimalDomestico pedirAnimalDomestico()
        {
            Console.WriteLine("\nIntroduce los datos del animal doméstico: " + vueltas + " de " + numAnimales);
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

            Console.Write("Nombre del dueño: ");
            string nombreDueno = Console.ReadLine();

            Console.Write("Independiente?: ");
            bool independiente = bool.Parse(Console.ReadLine());

            Console.Write("Compañía: ");
            string compania = Console.ReadLine();

            Console.Write("Facilidad de cuidado: ");
            string facilidadCuidado = Console.ReadLine();

            return new AnimalDomestico(tipo, raza, alimentacion, habitat, extinto, peso, tamano, nombreDueno, independiente, compania, facilidadCuidado);
        }
    }
}
