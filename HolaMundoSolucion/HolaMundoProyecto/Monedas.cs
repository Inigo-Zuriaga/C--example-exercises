using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundoProyecto
{
    internal class Monedas
    {
        public class Moneda
        {
            public string MonedaOrigen { get ; set; }
            public string MonedaDestino { get; set; }
            public double NumeroDestino { get; set; }
            public double NumeroDestino { get; set; }
            // Constructor
            public Moneda(string monedaOrigen, string monedaDestino, double numeroOrigen, double numeroDestino)
            {
                MonedaOrigen = monedaOrigen;
                MonedaDestino = monedaDestino;
                NumeroOrigen = numeroOrigen;
                NumeroDestino = numeroDestino;
            }

        }

        Console.Write();

    }
}