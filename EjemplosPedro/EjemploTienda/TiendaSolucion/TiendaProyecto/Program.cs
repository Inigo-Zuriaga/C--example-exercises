var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configurar el repositorio
// Indicamos al sistema qué hacer 
// cuando pedimos la interfaz, lo que queremos 
// es una instancia de la clase que implementa la interfaz
// Tenemos IMonedaRepositorio, pero queremos una instancia
// de MonedaRepositorioEnMemoria

/*
 * Imagina que tienes una tienda de café y contratas a un proveedor específico que te entrega granos de café todos los días. Tu tienda depende de ese proveedor para funcionar. Si un día el proveedor no puede entregar el café, o si decides que quieres cambiar de proveedor, tendrías un gran problema porque tu tienda está "atrapada" con ese único proveedor. ¡No puedes hacer nada sin él!

Ahora bien, si usas el principio de inversión de dependencias, lo que harías es no depender directamente de ese proveedor específico. En lugar de eso, creas un "contrato" (una lista de cosas que un proveedor debe hacer, como entregar café de cierta calidad a cierta hora). Así, cualquier proveedor que cumpla con ese contrato puede trabajar contigo.

Por ejemplo, tienes un contrato que dice: "Entrega café de buena calidad todos los días". Y ahora puedes contratar a cualquier proveedor que pueda cumplir con ese contrato, ya sea el proveedor A, B o C. Si quieres cambiar de proveedor, lo haces fácilmente sin tener que cambiar todo el funcionamiento de tu tienda, solo aseguras que el nuevo proveedor cumpla con el contrato.
 *  
 * 
 */


builder.Services.AddSingleton<IMonedaRepositorio, MonedaRepositorioEnMemoria>();

builder.Services.AddSingleton<IProveedorCafe, ProveedorCafeEstrella>();
// builder.Services.AddSingleton<IProveedorCafe, ProveedorCafeSaimaza>();

// Agregar servicio de correo electrónico
builder.Services.AddSingleton<IMessageService, EmailService>();

// Agregar servicio de SMS
//builder.Services.AddSingleton<IMessageService, SmsService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
