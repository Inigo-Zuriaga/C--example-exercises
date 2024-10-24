namespace ClasesEmpleados
{
    public class MiddleMgMt : Manager
    {
        public MiddleMgMt(string nombre, int años) : base(nombre, años)
        {
        }

        public override string ToString()
        {
            return $"Middle Management: {Nombre} ({Años} años)";
        }

        public override string ObtenerNumeroEmpleado()
        {
            return "Middle-" + Id.ToString();
        }
    }
}
