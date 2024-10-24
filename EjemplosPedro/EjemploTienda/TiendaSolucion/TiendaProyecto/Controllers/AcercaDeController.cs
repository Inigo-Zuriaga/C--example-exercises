using TiendaProyecto.Servicios;

namespace TiendaProyecto.Controllers;

public class AcercaDeController : Controller
{
    private readonly IProveedorCafe _proveedorCafe;
    private readonly IMessageService _messageService;
    public AcercaDeController(IProveedorCafe proveedorCafe, IMessageService messageService)
    {
        _proveedorCafe = proveedorCafe;
        _messageService = messageService;
    }

    public IActionResult Index()
    {   
        //var proveedorMarcilla = new ProveedorCafeMarcilla();
        _proveedorCafe.TipoCafe = "Café molido";
        _proveedorCafe.HoraEntrega = "06:00";
        _messageService.SendMessage("Mensaje desde el controlador","123456");
        return View();
    }

    public IActionResult Index2()
    {
        //var proveedorMarcilla = new ProveedorCafeMarcilla();
        _proveedorCafe.TipoCafe = "Café molido";
        _proveedorCafe.HoraEntrega = "06:00";
        _messageService.SendMessage("Mensaje desde el controlador", "123456");
        return View();
    }

    public IActionResult Index3()
    {
        //var proveedorMarcilla = new ProveedorCafeMarcilla();
        _proveedorCafe.TipoCafe = "Café molido";
        _proveedorCafe.HoraEntrega = "06:00";
        _messageService.SendMessage("Mensaje desde el controlador", "123456");
        return View();
    }
}
