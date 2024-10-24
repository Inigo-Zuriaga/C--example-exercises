using Microsoft.AspNetCore.Mvc;

namespace TiendaProyecto.Controllers
{
    public class CajasController : Controller
    {
        public IActionResult Index()
        {
            // Crear una caja que almacena un entero
            var cajaEntero = new Caja<int>(10);

            // Crear una caja que almacena un decimal
            var cajaDecimal = new Caja<decimal>(10.5M);

            // Crear una caja que almacena un string
            var cajaString = new Caja<string>("Hola Mundo");

            // Crear una caja que almacena un objeto complejo
            var cajaCompleja = new Caja<Moneda>(new Moneda());

            // Pasar todas las cajas a la vista
            ViewBag.CajaEntero = cajaEntero;
            ViewBag.CajaDecimal = cajaDecimal;
            ViewBag.CajaString = cajaString;
            ViewBag.CajaCompleja = cajaCompleja;

            return View();
        }
    }
}
