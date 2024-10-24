namespace ClasesEmpleados
{
    public class SeniorMgMt : Manager
    {
        public SeniorMgMt(string nombre, int años) : base(nombre, años)
        {
        }

        public override string ToString()
        {
            return $"Senior Management: {Nombre} ({Años} años)";
        }
        public override string ObtenerNumeroEmpleado()
        {
            return "Senior-" + Id.ToString();
        }
    }
}
