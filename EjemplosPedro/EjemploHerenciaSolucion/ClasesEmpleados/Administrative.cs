using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEmpleados
{
    public class Administrative : Worker, ITurnos
    {
        public string Turno { get; set; }

        public Administrative(string nombre, int años) : base(nombre, años)
        {
        }

        public override string ToString()
        {
            return $"Administrative: {Nombre} ({Años} años)";
        }

        public override string ObtenerNumeroEmpleado()
        {
            return "Admin-" + Id.ToString();
        }

        public override void CalcularVacaciones()
        {
            base.CalcularVacaciones();
            numeroDiasVacaciones += 6;
        }
    }
}
