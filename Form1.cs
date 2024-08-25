namespace GestionCitasMedicas

{
    public partial class Form1 : Form
    {

        private List<Paciente> pacientes = new List<Paciente>();
        private List<Cita> citas = new List<Cita>();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrirRegistroPaciente_Click(object sender, EventArgs e)
        {
            FormRegistroPaciente formRegistro = new FormRegistroPaciente();
            formRegistro.PacienteRegistrado += FormRegistro_PacienteRegistrado;
            formRegistro.Show();
        }

        private void FormRegistro_PacienteRegistrado(object sender, Paciente e)
        {
            pacientes.Add(e);
            MessageBox.Show($"Paciente registrado: {e.Nombre}");
        }

        private void FormCita_CitaProgramada(object? sender, Cita e)
        {
            citas.Add(e);
            MessageBox.Show($"Cita programada para {e.Paciente.Nombre} con el Dr. {e.Medico} el {e.Fecha} a las {e.Hora}");
        }

        private void btnAbrirProgramarCita_Click_1(object sender, EventArgs e)
        {
            FormProgramarCita formCita = new FormProgramarCita(pacientes);
            formCita.CitaProgramada += FormCita_CitaProgramada;
            formCita.Show();
        }
    }
}
