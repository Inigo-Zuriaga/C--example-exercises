using CMProyecto.Models;
using CMProyecto.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CMProyecto.Controllers
{
    // Caracteristicas de un controlador
    // 1. Debe estar en la carpeta Controllers
    // 2. Debe heredar de Controller
    // 3. Debe tener metodos publicos que devuelvan IActionResult
    // 4. Cada metodo debe devolver una vista mediante el metodo View()
    // 5. Las vistas deben estar en la carpeta Views
    // 6. El nombre de la clase es <Nombre>Controller  -> Nombre el nombre del controlador


    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Datos a mostrar en la pagina de inicio
            // -Nombre de empresa
            // -Version de la aplicacion
            // -Fecha de creacion
            // -Autor
            // -Descripcion de la aplicacion

            // Cuando hay bastantes datos que pasar a la vista
            // se utiliza un ViewModel
            // Un ViewModel es una clase que contiene todas las propiedades
            // que se quieren mostrar en la vista
            // Esta en la carpeta ViewModels
            // El nombre del ViewModel es 
            // <NombreControlador><NombreMetodo>ViewModel
            // Ejemplo
            // HomeIndexViewModel 

            var vm = new HomeIndexViewModel
            {
                Empresa = "Mi empresa",
                NombreApp = "Mi aplicacion",
                Version = "1.0",
                Fecha = DateTime.Now,
                Autor = "Mi nombre",
                Descripcion = "Mi descripcion",
                Multiplicacion = 5 * 5,
                Poblacion = "Madrid"
            };

            return View(vm);
        }

        public IActionResult Privacy()
        {
            // Datos a mostrar en la pagina de privacidad
            // -Nombre de empresa
            // -Tratamiento de datos
            // -Politica de privacidad

            // Nombre del ViewModel
            // <NombreControlador><NombreMetodo>ViewModel
            // HomePrivacyViewModel

            // Crear el ViewModel
            var vm = new HomePrivacyViewModel
            {
                Empresa = "Mi empresa",
                TratamientoDatos = "Tratamiento de datos",
                PoliticaPrivacidad = "Politica de privacidad",
                Vacaciones = "Vacaciones en Agosto 2025"
            };

            return View(vm);
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
