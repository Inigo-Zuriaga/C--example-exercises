var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configurar el repositorio
// Indicamos al sistema qu� hacer 
// cuando pedimos la interfaz, lo que queremos 
// es una instancia de la clase que implementa la interfaz
// Tenemos IMonedaRepositorio, pero queremos una instancia
// de MonedaRepositorioEnMemoria

/*
 * Imagina que tienes una tienda de caf� y contratas a un proveedor espec�fico que te entrega granos de caf� todos los d�as. Tu tienda depende de ese proveedor para funcionar. Si un d�a el proveedor no puede entregar el caf�, o si decides que quieres cambiar de proveedor, tendr�as un gran problema porque tu tienda est� "atrapada" con ese �nico proveedor. �No puedes hacer nada sin �l!

Ahora bien, si usas el principio de inversi�n de dependencias, lo que har�as es no depender directamente de ese proveedor espec�fico. En lugar de eso, creas un "contrato" (una lista de cosas que un proveedor debe hacer, como entregar caf� de cierta calidad a cierta hora). As�, cualquier proveedor que cumpla con ese contrato puede trabajar contigo.

Por ejemplo, tienes un contrato que dice: "Entrega caf� de buena calidad todos los d�as". Y ahora puedes contratar a cualquier proveedor que pueda cumplir con ese contrato, ya sea el proveedor A, B o C. Si quieres cambiar de proveedor, lo haces f�cilmente sin tener que cambiar todo el funcionamiento de tu tienda, solo aseguras que el nuevo proveedor cumpla con el contrato.
 *  
 * 
 */


builder.Services.AddSingleton<IMonedaRepositorio, MonedaRepositorioEnMemoria>();

builder.Services.AddSingleton<IProveedorCafe, ProveedorCafeEstrella>();
// builder.Services.AddSingleton<IProveedorCafe, ProveedorCafeSaimaza>();

// Agregar servicio de correo electr�nico
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
