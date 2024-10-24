namespace TiendaProyecto.Genericos;

public class Caja<T>
{
    public T Contenido { get; private set; }

    public Caja(T contenidoInicial)
    {
        Contenido = contenidoInicial;
    }

    public void ActualizarContenido(T nuevoContenido)
    {
        Contenido = nuevoContenido;
    }
}
