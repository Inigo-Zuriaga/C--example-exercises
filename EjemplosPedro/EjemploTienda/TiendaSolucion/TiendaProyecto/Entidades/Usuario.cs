namespace TiendaProyecto.Entidades;

// Entidad para tratar con usuarios
public class Usuario
{
    // Identificador del usuario
    public int Id { get; set; }
    // Nombre del usuario
    public string Nombre { get; set; }
    // Apellidos del usuario
    public string Apellidos { get; set; }
    // Correo electrónico del usuario
    public string Email { get; set; }
    // Contraseña del usuario
    public string Contrasena { get; set; }
    // Rol del usuario
    public string Rol { get; set; }
    // Fecha de creación del usuario
    public DateTime FechaCreacion { get; set; }

    public string Telefono { get; set; }

}
