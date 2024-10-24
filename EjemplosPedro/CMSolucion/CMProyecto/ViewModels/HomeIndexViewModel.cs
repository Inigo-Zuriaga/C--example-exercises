namespace CMProyecto.ViewModels
{
    // Datos a mostrar en la pagina de inicio
    // -Nombre de empresa
    // -Nombre de la aplicacion
    // -Version de la aplicacion
    // -Fecha de creacion
    // -Autor
    // -Descripcion de la aplicacion

    public class HomeIndexViewModel
    {
        public string Empresa { get; set; }

        public string NombreApp { get; set; }
        public string Version { get; set; }

        public DateTime Fecha { get; set; }
        public string Autor { get; set; }
        public string Descripcion { get; set; }

        public int Multiplicacion { get; set; }

        public string Poblacion { get; set; }


    }
}
