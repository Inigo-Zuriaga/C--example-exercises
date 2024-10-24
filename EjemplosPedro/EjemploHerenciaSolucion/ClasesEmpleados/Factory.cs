namespace ClasesEmpleados
{
    public class Factory : Worker , ITurnos
    {
        public Factory(string nombre, int años) : base(nombre, años)
        {
        }

        public string Turno { get; set; }

        public override string ToString()
        {
            return $"Factory: {Nombre} ({Años} años)";
        }

        public override string ObtenerNumeroEmpleado()
        {
            return "Factory-" + Id.ToString();
        }
    }
}
