namespace GestionCitasMedicas
{
    partial class FormProgramarCita
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelPaciente;
        private Label labelFecha;
        private TextBox txtHora;
        private Label labelMedico;
        private Label labelHora;
        private DateTimePicker dtpFecha;
        private ComboBox cmbPacientes;
        private ComboBox cmbMedicos;
        private Button btnProgramarCita;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelPaciente = new Label();
            labelFecha = new Label();
            txtHora = new TextBox();
            labelMedico = new Label();
            labelHora = new Label();
            dtpFecha = new DateTimePicker();
            cmbPacientes = new ComboBox();
            cmbMedicos = new ComboBox();
            btnProgramarCita = new Button();
            citaLabel = new Label();
            SuspendLayout();
            // 
            // labelPaciente
            // 
            labelPaciente.AutoSize = true;
            labelPaciente.Location = new Point(81, 91);
            labelPaciente.Name = "labelPaciente";
            labelPaciente.Size = new Size(146, 20);
            labelPaciente.TabIndex = 0;
            labelPaciente.Text = "Seleccionar paciente";
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Location = new Point(81, 158);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(190, 20);
            labelFecha.TabIndex = 1;
            labelFecha.Text = "Seleccionar fecha de la cita";
            // 
            // txtHora
            // 
            txtHora.Location = new Point(297, 231);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(335, 27);
            txtHora.TabIndex = 2;
            // 
            // labelMedico
            // 
            labelMedico.AutoSize = true;
            labelMedico.Location = new Point(81, 309);
            labelMedico.Name = "labelMedico";
            labelMedico.Size = new Size(139, 20);
            labelMedico.TabIndex = 3;
            labelMedico.Text = "Seleccionar médico";
            // 
            // labelHora
            // 
            labelHora.AutoSize = true;
            labelHora.Location = new Point(81, 234);
            labelHora.Name = "labelHora";
            labelHora.Size = new Size(107, 20);
            labelHora.TabIndex = 4;
            labelHora.Text = "Hora de la cita";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(297, 158);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(335, 27);
            dtpFecha.TabIndex = 5;
            // 
            // cmbPacientes
            // 
            cmbPacientes.FormattingEnabled = true;
            cmbPacientes.Location = new Point(297, 88);
            cmbPacientes.Name = "cmbPacientes";
            cmbPacientes.Size = new Size(335, 28);
            cmbPacientes.TabIndex = 6;
            // 
            // cmbMedicos
            // 
            cmbMedicos.FormattingEnabled = true;
            cmbMedicos.Location = new Point(297, 312);
            cmbMedicos.Name = "cmbMedicos";
            cmbMedicos.Size = new Size(339, 28);
            cmbMedicos.TabIndex = 7;
            // 
            // btnProgramarCita
            // 
            btnProgramarCita.Location = new Point(395, 384);
            btnProgramarCita.Name = "btnProgramarCita";
            btnProgramarCita.Size = new Size(159, 29);
            btnProgramarCita.TabIndex = 8;
            btnProgramarCita.Text = "Programar cita";
            btnProgramarCita.UseVisualStyleBackColor = true;
            btnProgramarCita.Click += btnProgramarCita_Click;
            // 
            // citaLabel
            // 
            citaLabel.AutoSize = true;
            citaLabel.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            citaLabel.Location = new Point(376, 33);
            citaLabel.Name = "citaLabel";
            citaLabel.Size = new Size(163, 26);
            citaLabel.TabIndex = 9;
            citaLabel.Text = "Agregar Cita";
            // 
            // FormProgramarCita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(citaLabel);
            Controls.Add(btnProgramarCita);
            Controls.Add(cmbMedicos);
            Controls.Add(cmbPacientes);
            Controls.Add(dtpFecha);
            Controls.Add(labelHora);
            Controls.Add(labelMedico);
            Controls.Add(txtHora);
            Controls.Add(labelFecha);
            Controls.Add(labelPaciente);
            Name = "FormProgramarCita";
            Text = "FormProgramarCita";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label citaLabel;
    }
}
