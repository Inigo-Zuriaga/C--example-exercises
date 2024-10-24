namespace TiendaProyecto.Controllers;

public class MonedasEjemploController : Controller
{

    // METODO DE ACCION PARA LA VISTA DE MONEDAS
    public IActionResult Index()
    {
        ViewBag.Titulo = "Monedas";
        ViewBag.Descripcion = "En esta sección podrás encontrar las monedas que tenemos disponibles para ti.";
        ViewBag.Precio = "Precio";
        ViewBag.Fecha = DateTime.Now;

        return View();
    }
}
