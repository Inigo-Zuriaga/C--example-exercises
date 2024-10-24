using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploAulaProyecto
{
    public class Coche
    {
        public int NumeroPuertas { get; set; }
        public int Cilindrada { get; set; }

        private string NumeroBastidor;

        public void GrabarNumeroBastidor()
        {
            // GUID  - Globally Unique Identifier
            this.NumeroBastidor = Guid.NewGuid().ToString();
        }
    }
}
