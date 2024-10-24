using Microsoft.AspNetCore.Mvc;

namespace TiendaProyecto.Controllers
{
    public class UsuariosEjemplo01Controller : Controller
    {
        public IActionResult Index()
        {
            // Usar Bogus para generar 100 usuarios
            List<Usuario> usuarios = new Bogus.Faker<TiendaProyecto.Entidades.Usuario>()
                .RuleFor(u => u.Id, f => f.IndexFaker)
                .RuleFor(u => u.Nombre, f => f.Person.FirstName)
                .RuleFor(u => u.Apellidos, f => f.Person.LastName)
                .RuleFor(u => u.Email, f => f.Person.Email)
                .RuleFor(u => u.Telefono, f => f.Person.Phone)
                .Generate(100);


            return View(usuarios);
        }

        public IActionResult Paises()
        {
            // Usar Bogus para generar 100 paises
            List<Pais> paises = new Bogus.Faker<TiendaProyecto.Entidades.Pais>()
                .RuleFor(u => u.Id, f => f.IndexFaker)
                .RuleFor(u => u.Nombre, f => f.Address.Country())
                .Generate(100);

            return View(paises);
        }

        public IActionResult Pares()
        {
            // Usar Bogus para generar 100 pares de ParMoneda
            List<ParMoneda> pares = new Bogus.Faker<TiendaProyecto.Entidades.ParMoneda>()
                .RuleFor(u => u.Id, f => f.IndexFaker)
                .RuleFor(u => u.MonedaOrigen, f => f.Finance.Currency().Code)
                .RuleFor(u => u.MonedaDestino, f => f.Finance.Currency().Code)
                .RuleFor(u => u.FactorConversion, f => f.Random.Decimal(0.5M, 2.0M))
                .Generate(100);


            return View(pares);
        }
    }
}
