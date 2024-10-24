using Microsoft.AspNetCore.Mvc;

namespace CMProyecto.Controllers
{
    // Caracteristicas de un controlador
    // 1. Debe estar en la carpeta Controllers
    // 2. Debe heredar de Controller
    // 3. Debe tener metodos publicos que devuelvan IActionResult
    // 4. Cada metodo debe devolver una vista mediante el metodo View()
    // 5. Las vistas deben estar en la carpeta Views
    // 6. El nombre de la clase es <Nombre>Controller  -> Nombre el nombre del controlador

    // Como agregar una vista
    // 1. Click derecho en el nombre del metodo de accion
    // 2. Elegir Agregar vista
    // 3. Elegir Vista De Razor Vacia
    // 4. Darle el MISMO NOMBRE que el METODO sobre el que hemos pulsado boton derecho

    public class ConversorController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Historico()
        {
            return View();
        }
    }
}
