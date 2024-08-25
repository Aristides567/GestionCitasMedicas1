namespace GestionCitasMedicas
{
    partial class FormRegistroPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelNombre = new Label();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            labelEdad = new Label();
            txtContacto = new TextBox();
            labelContacto = new Label();
            btnRegistrarPaciente = new Button();
            pacienteLabel = new Label();
            SuspendLayout();
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(107, 127);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(150, 20);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "Nombre del paciente";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(271, 124);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(340, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(271, 175);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(340, 27);
            txtEdad.TabIndex = 3;
            // 
            // labelEdad
            // 
            labelEdad.AutoSize = true;
            labelEdad.Location = new Point(107, 178);
            labelEdad.Name = "labelEdad";
            labelEdad.Size = new Size(129, 20);
            labelEdad.TabIndex = 2;
            labelEdad.Text = "Edad del paciente";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(271, 225);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(340, 27);
            txtContacto.TabIndex = 5;
            // 
            // labelContacto
            // 
            labelContacto.AutoSize = true;
            labelContacto.Location = new Point(107, 228);
            labelContacto.Name = "labelContacto";
            labelContacto.Size = new Size(158, 20);
            labelContacto.TabIndex = 4;
            labelContacto.Text = "Contacto del paciente:";
            // 
            // btnRegistrarPaciente
            // 
            btnRegistrarPaciente.Location = new Point(323, 298);
            btnRegistrarPaciente.Name = "btnRegistrarPaciente";
            btnRegistrarPaciente.Size = new Size(225, 29);
            btnRegistrarPaciente.TabIndex = 6;
            btnRegistrarPaciente.Text = "Registrar paciente";
            btnRegistrarPaciente.UseVisualStyleBackColor = true;
            btnRegistrarPaciente.Click += btnRegistrarPaciente_Click;
            // 
            // pacienteLabel
            // 
            pacienteLabel.AutoSize = true;
            pacienteLabel.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            pacienteLabel.Location = new Point(306, 59);
            pacienteLabel.Name = "pacienteLabel";
            pacienteLabel.Size = new Size(282, 29);
            pacienteLabel.TabIndex = 7;
            pacienteLabel.Text = "Registro del paciente";
            // 
            // FormRegistroPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pacienteLabel);
            Controls.Add(btnRegistrarPaciente);
            Controls.Add(txtContacto);
            Controls.Add(labelContacto);
            Controls.Add(txtEdad);
            Controls.Add(labelEdad);
            Controls.Add(txtNombre);
            Controls.Add(labelNombre);
            Name = "FormRegistroPaciente";
            Text = "FormRegistroPaciente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNombre;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private Label labelEdad;
        private TextBox txtContacto;
        private Label labelContacto;
        private Button btnRegistrarPaciente;
        private Label pacienteLabel;
    }
}