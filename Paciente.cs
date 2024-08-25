using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCitasMedicas
{
    public class Paciente
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Contacto { get; set; }

        public Paciente(string nombre, int edad, string contacto)
        {
            Nombre = nombre;
            Edad = edad;
            Contacto = contacto;
        }
    }
}
