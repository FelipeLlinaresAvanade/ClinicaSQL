using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSQL
{
    public class Cita
    {
        public int? Id { get; set; }

        public string paciente { get; set; }

        public DateTime fechaYhora { get; set; }

        public string medico { get; set; }

        public int numeroConsulta { get; set; }
    }
}
