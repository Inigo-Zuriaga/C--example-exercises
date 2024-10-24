using EjermploConversorMoneda.Services;
using Microsoft.AspNetCore.Mvc;

public class CurrencyController : Controller
{
    private readonly CurrencyConverterService _currencyConverterService;
    private readonly CurrencyQueryDbContext _dbContext;

    public CurrencyController(CurrencyConverterService currencyConverterService, CurrencyQueryDbContext dbContext)
    {
        _currencyConverterService = currencyConverterService;
        _dbContext = dbContext;
    }


    [HttpGet]
    public async Task<IActionResult> ConvertAsync()
    {
        // Crear un nuevo modelo de vista
        var model = new CurrencyConversionViewModel
        {
            // Llenar la lista con códigos de moneda válidos
            ValidCurrencyCodes = await _currencyConverterService.GetCurrencyList()
        };

        // Devolver la vista con el modelo
        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Convert([Bind("Amount,SourceCurrency,TargetCurrency")] CurrencyConversionViewModel model)
    //public async Task<IActionResult> Convert(CurrencyConversionViewModel model)


    {

        //ModelState.Remove("ValidCurrencyCodes"); // Remover el error del campo ValidCurrencyCodes
        //var resultado = TryValidateModel(model);

        if (!ModelState.IsValid)
        {
    
            return View(model);
        }

        var result = await _currencyConverterService.ConvertCurrency(model.Amount, model.SourceCurrency, model.TargetCurrency);
        model.Result = result;

        // Almacenar la consulta en la base de datos
        var query = new CurrencyQuery
        {
            FromCurrency = model.SourceCurrency,
            ToCurrency = model.TargetCurrency,
            Amount = model.Amount,
            Result = result,
            QueryDate = DateTime.Now
        };
        _dbContext.CurrencyQueries.Add(query);
        await _dbContext.SaveChangesAsync();

        // Llenar la lista con códigos de moneda válidos
        model.ValidCurrencyCodes = await _currencyConverterService.GetCurrencyList();

        return View(model);
    }
    [HttpGet]
    public IActionResult History()
    {
        var lastQueries = _dbContext.CurrencyQueries
            .OrderByDescending(q => q.QueryDate)
            .Take(10)
            .ToList();

        return View(lastQueries);
    }
}
