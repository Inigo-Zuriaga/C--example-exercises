namespace TiendaProyecto.Servicios
{
    public class ProveedorCafeEstrella : IProveedorCafe
    {
        public string TipoCafe { get; set; }
        public string HoraEntrega { get; set; }

        public decimal Descuento { get; set; }
    }
}
