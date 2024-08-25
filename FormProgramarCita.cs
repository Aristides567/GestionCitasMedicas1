using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestionCitasMedicas
{
    public partial class FormProgramarCita : Form
    {
        public event EventHandler<Cita>? CitaProgramada;
        public List<Paciente> pacientes;

        public FormProgramarCita(List<Paciente> pacientes)
        {
            InitializeComponent();
            this.pacientes = pacientes;

            // Inicializar controles
            cmbPacientes.DataSource = pacientes;
            cmbPacientes.DisplayMember = "Nombre";
            cmbMedicos.Items.AddRange(new string[] { "Dr. Smith", "Dr. Johnson", "Dr. Lee" });

            // Asegurar la inicialización del evento
            CitaProgramada += (sender, e) => { };
        }

        protected virtual void OnCitaProgramada(Cita cita)
        {
            // Disparar el evento si hay suscriptores
            CitaProgramada?.Invoke(this, cita);
        }

        private void btnProgramarCita_Click(object sender, EventArgs e)
        {
                // Verificar que el paciente esté seleccionado
                Paciente? paciente = (Paciente?)cmbPacientes.SelectedItem;
                if (paciente == null)
                {
                    MessageBox.Show("Por favor, selecciona un paciente.");
                    return;
                }

                // Verificar que el médico esté seleccionado
                string? medico = cmbMedicos.SelectedItem?.ToString();
                if (medico == null)
                {
                    MessageBox.Show("Por favor, selecciona un médico.");
                    return;
                }

                // Crear la cita y disparar el evento
                DateTime fecha = dtpFecha.Value;
                string hora = txtHora.Text;
                Cita cita = new Cita(paciente, fecha, hora, medico);
                OnCitaProgramada(cita);

        }
    }
}
