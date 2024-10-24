// Es una aplicaci�n de consola que se ejecuta en el servidor y act�a como el punto de entrada de la aplicaci�n.

// Construye la aplicaci�n. (builder)
var builder = WebApplication.CreateBuilder(args);

#region 1-Servicios de la aplicaci�n

// 1-Agrega servicios al contenedor.
// =================================

// Agrega Modelo Vista Controlador a la aplicacion
builder.Services.AddControllersWithViews();


#endregion

// Construye la aplicaci�n.
var app = builder.Build();

#region 2-Configuraci�n de la aplicaci�n


// 2-Configura el pipeline de solicitudes HTTP.
// ============================================

// Comprueba si estamos en desarrollo o produccion
if (!app.Environment.IsDevelopment())
{
    // Muestra la pagina de error en caso de error
    // Pero solo en desarrollo
    // En produccion se muestra una pagina de error generica
    // sin datos seguros
    app.UseExceptionHandler("/Home/Error");
}



/// <summary>
/// Habilita el uso de archivos est�ticos.
/// Para ver imagenes, css, js, etc.
/// </summary>
app.UseStaticFiles();

/// <summary>
/// Habilita el enrutamiento.
/// Significa que cuando el usuario navega a una URL,
/// redirige la solicitud al controlador correspondiente.
/// </summary>
app.UseRouting();

/// <summary>
/// Habilita la autorizaci�n. Permite restringir el acceso a ciertas partes de la aplicaci�n.
/// </summary>
app.UseAuthorization();

/// <summary>
/// Configura la ruta predeterminada del controlador.
/// La ruta predeterminada sera Home/Index que es el controlador y la accion.
/// Controlador/Accion/Id
/// Ejemplos
/// Home/Index
/// Home/Privacy
/// etc
/// </summary>
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

#endregion


// Ejecuta la aplicaci�n.
app.Run();
