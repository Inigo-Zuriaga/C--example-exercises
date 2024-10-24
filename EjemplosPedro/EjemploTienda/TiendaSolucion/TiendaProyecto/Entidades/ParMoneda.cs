namespace TiendaProyecto.Entidades;

// Entidad para tratar con pares de monedas
public class ParMoneda
{
    // Identificador del par de monedas
    public int Id { get; set; }

    // Moneda origen y destino y factor de conversion
    public string MonedaOrigen { get; set; }
    public string MonedaDestino { get; set; }
    public decimal FactorConversion { get; set; }

}
