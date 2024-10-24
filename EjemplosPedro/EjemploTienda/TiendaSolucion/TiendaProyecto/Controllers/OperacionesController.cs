using Microsoft.AspNetCore.Mvc;
using TiendaProyecto.Resultados;

namespace TiendaProyecto.Controllers
{
    public class OperacionesController : Controller
    {
        
        // Resultado de una operación que devuelve un entero
        public IActionResult ResultadoEntero()
        {
            // Realizar una operacion que devuleva un entero
            int resultado = 5 + 5;

            // Pasar el resultado a la vista
            var resultadoOperacion = new ResultadoOperacion<int>();
            resultadoOperacion.Resultado = resultado;
            resultadoOperacion.Mensaje = $"Resultado de la operación {resultado}";


            return View(resultado);
        }

        // Resultado de una operación que devuelve un decimal
        public IActionResult ResultadoDecimal()
        {
            // Realizar una operacion que devuleva un entero
            decimal resultado = 5 + 5;

            // Pasar el resultado a la vista
            var resultadoOperacion = new ResultadoOperacion<decimal>();
            resultadoOperacion.Resultado = resultado;
            resultadoOperacion.Mensaje = $"Resultado de la operación {resultado}";


            return View(resultado);
        }


        // Resultado de una operación que devuelve un string
        public IActionResult ResultadoString()
        {
            // Realizar una operacion que devuleva una cadena
            string resultado = "10ABC";

            // Pasar el resultado a la vista
            var resultadoOperacion = new ResultadoOperacion<string>();
            resultadoOperacion.Resultado = resultado;
            resultadoOperacion.Mensaje = $"Resultado de la operación {resultado}";

            return View(resultado);
        }

        // Resultado de una operación que devuelve un string
        public IActionResult ResultadoEmpleado()
        {
            // Realizar una operacion que devuleva una cadena
            Moneda resultado = new  Moneda();

            // Pasar el resultado a la vista
            var resultadoOperacion = new ResultadoOperacion<Moneda>();
            resultadoOperacion.Resultado = resultado; ;
            resultadoOperacion.Mensaje = $"Resultado de la operación {resultado}";

            return View(resultado);
        }

    }
}
