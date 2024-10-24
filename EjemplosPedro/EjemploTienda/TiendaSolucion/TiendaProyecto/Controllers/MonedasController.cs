

namespace TiendaProyecto.Controllers;

public class MonedasController : Controller
{
    private readonly IMonedaRepositorio _monedaRepositorio;

    public MonedasController(IMonedaRepositorio monedaRepositorio)
    {
        _monedaRepositorio = monedaRepositorio;
    }

    // Acción para mostrar todas las monedas
    public IActionResult Index()
    {
        IEnumerable<Moneda> monedas = _monedaRepositorio.ObtenerTodas();
        return View(monedas);
    }

    // Acción para mostrar detalles de una moneda por Id
    public IActionResult Detalles(int id)
    {
        var moneda = _monedaRepositorio.ObtenerPorId(id);
        if (moneda == null)
        {
            return NotFound();
        }
        return View(moneda);
    }
}
