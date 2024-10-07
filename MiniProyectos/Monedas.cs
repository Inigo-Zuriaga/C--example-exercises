using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProyectos;

internal class Monedas
{

    public class Moneda
    {
        public string MonedaOrigen { get; set; }
        public string MonedasDestino { get; set; }
        public double NumeroOrigen { get; set; }
        public double NumeroDestino { get; set; }

        public Moneda(string monedaOrigen, string monedasDestino, double numeroOrigen, double numeroDestino)
        {
            MonedaOrigen = monedaOrigen;
            MonedasDestino = monedasDestino;
            NumeroOrigen = numeroOrigen;
            NumeroDestino = numeroDestino;
        }


    }
    public static double dolarDolar = 1;
    public static double dolarEuro = 0.91;
    public static double dolarLibra = 0.76;

    public static void PedirMonedas()
    {
        Console.WriteLine("Hola, introduce moneda origen: euro , dolar , libra");
        string monedaOrigen = Console.ReadLine().ToLower();
        Console.WriteLine("Introduce moneda destino: euro , dolar , libra");
        string monedaDestino = Console.ReadLine().ToLower();

        Console.WriteLine("Introduce el monto a convertir: ej 1.15");

        // Manejo de errores al leer el monto
        if (!double.TryParse(Console.ReadLine(), out double numeroOrigen))
        {
            Console.WriteLine("Por favor, introduce un número válido.");
            return;
        }

        double numeroDestino = 0;


        if (monedaOrigen == "dolar")
        {
           numeroDestino= ConvertirDeDolares(monedaDestino, numeroOrigen);
        }
        Moneda moneda1 = new Moneda(monedaOrigen, monedaDestino, numeroOrigen, numeroDestino);


    }
    private static double ConvertirDeDolares(string monedaDestino, double numeroOrigen) {
        switch (monedaDestino)
        {
            case "euro":
                return numeroOrigen * dolarEuro;
            case "libra":
                return numeroOrigen * dolarLibra;
            case "dolar":
                return numeroOrigen;
            default:
                throw new ArgumentException("Moneda de destino no válida");
            }
        }
    }

