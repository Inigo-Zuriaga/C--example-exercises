using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

public class CurrencyConversionViewModel
{
    public CurrencyConversionViewModel()
    {
        // Inicializar las propiedades con un valor por defecto
        SourceCurrency = string.Empty;
        TargetCurrency = string.Empty;
        ValidCurrencyCodes = new List<string>();
    }

    // Lista de códigos de moneda válidos
    [BindNever]
    public List<string> ValidCurrencyCodes { get; set; }

    // La cantidad de dinero que el usuario quiere convertir
    [Required]
    [Range(0.01, double.MaxValue, ErrorMessage = "El importe debe ser mayor que 0")]
    public decimal Amount { get; set; }

    // La divisa de origen que el usuario quiere convertir
    [Required]
    [StringLength(3, ErrorMessage = "La divisa de origen debe ser de 3 caracteres")]
    public string SourceCurrency { get; set; }

    // La divisa de destino a la que el usuario quiere convertir
    [Required]
    [StringLength(3, ErrorMessage = "La divisa de destino debe ser de 3 caracteres")]
    public string TargetCurrency { get; set; }

    // El resultado de la conversión de divisa
    public decimal Result { get; set; }


}



