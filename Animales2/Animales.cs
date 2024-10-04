using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AnimalesNamespace.Animales;

namespace AnimalesNamespace
{
    public class Animales
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
        public static int vueltas = 0;
        public static int numAnimales = 0;
        public static void PedirAnimales() //void cuando el método no necesita devolver un valor
        {
            //creo una lista para añadir los animales
            List<Animal> animales = new List<Animal>();

            Console.WriteLine("Hola, cuantos animales quieres añadir?");
            numAnimales = int.Parse(Console.ReadLine());

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
                        vueltas++;
                        Animal animalBase = pedirAnimalBase();
                        animales.Add(animalBase); //añado a al lista
                        break;
                    case 2:
                        vueltas++;
                        Animal animalSalvaje = pedirAnimalSalvaje();
                        animales.Add(animalSalvaje); //añado a al lista
                        break;
                    case 3:
                        vueltas++;
                        Animal animalDomestico = pedirAnimalDomestico();
                        animales.Add(animalDomestico); //añado a al lista
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
