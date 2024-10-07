using System;

namespace ProyectosMini
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
    

    public static double dolarDolar = 1;
    public static double dolarEuro = 0.91;
    public static double dolarLibra = 0.76;

    public static void PedirMonedas()
    {
        Console.WriteLine("Hola, introduce moneda origen: euro, dolar, libra");
        string monedaOrigen = Console.ReadLine().ToLower();
        Console.WriteLine("Introduce moneda destino: euro, dolar, libra");
        string monedaDestino = Console.ReadLine().ToLower();
        Console.WriteLine("Introduce el monto a convertir: ej 1.15");

        if (!double.TryParse(Console.ReadLine(), out double numeroOrigen))
        {
            Console.WriteLine("Por favor, introduce un número válido.");
            return;
        }

        double numeroDestino = 0;

        switch (monedaOrigen)
        {
            case "dolar":
                numeroDestino = ConvertirDeDolares(monedaDestino, numeroOrigen);
                break;
            case "euro":
                numeroDestino = ConvertirDeEuros(monedaDestino, numeroOrigen);
                break;
            case "libra":
                numeroDestino = ConvertirDeLibras(monedaDestino, numeroOrigen);
                break;
            default:
                Console.WriteLine("Moneda de origen no válida.");
                return;
        }

        Moneda moneda1 = new Moneda(monedaOrigen, monedaDestino, numeroOrigen, numeroDestino);
        Console.WriteLine($"El monto ( {numeroOrigen} {monedaOrigen} ) convertido es: {numeroDestino.ToString("F2")} {monedaDestino}");
    }

    public static double ConvertirDeDolares(string monedaDestino, double numeroOrigen)
    {
        switch (monedaDestino)
        {
            case "euro":
                return (numeroOrigen * dolarEuro);
            case "libra":
                return numeroOrigen * dolarLibra;
            case "dolar":
                return numeroOrigen;
            default:
                throw new ArgumentException("Moneda de destino no válida");
        }
    }

    public static double ConvertirDeEuros(string monedaDestino, double numeroOrigen)
    {
        double montoEnDolares = numeroOrigen * (1 / dolarEuro);
        return ConvertirDeDolares(monedaDestino, montoEnDolares);
    }

    public static double ConvertirDeLibras(string monedaDestino, double numeroOrigen)
    {
        double montoEnDolares = numeroOrigen * (1 / dolarLibra);
        return ConvertirDeDolares(monedaDestino, montoEnDolares);
    }


}
}
