using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GestionCitasMedicas
{
    public partial class FormRegistroPaciente : Form
    {
        public Action<object, Paciente>? PacienteRegistrado { get; internal set; }

        public FormRegistroPaciente()
        {
            InitializeComponent();
        }

        private void btnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int edad = int.Parse(txtEdad.Text);
            string contacto = txtContacto.Text;
            Paciente paciente = new Paciente(nombre, edad, contacto);
            OnPacienteRegistrado(paciente);
        }

        protected virtual void OnPacienteRegistrado(Paciente paciente)
        {
            PacienteRegistrado?.Invoke(this, paciente);
        }
    }

}
