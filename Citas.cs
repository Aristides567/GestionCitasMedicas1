using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCitasMedicas
{
    public class Cita
    {
        public Paciente Paciente { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public string Medico { get; set; }

        public Cita(Paciente paciente, DateTime fecha, string hora, string medico)
        {
            Paciente = paciente;
            Fecha = fecha;
            Hora = hora;
            Medico = medico;
        }

        internal static void Add(Cita e)
        {
            throw new NotImplementedException();
        }
    }
}
