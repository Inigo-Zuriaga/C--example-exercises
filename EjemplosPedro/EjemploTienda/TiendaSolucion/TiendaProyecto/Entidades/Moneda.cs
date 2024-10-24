namespace TiendaProyecto.Entidades;

// Entidad para tratar con monedas
public class Moneda
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Codigo { get; set; } = string.Empty;
    public string Simbolo { get; set; } = string.Empty;
}