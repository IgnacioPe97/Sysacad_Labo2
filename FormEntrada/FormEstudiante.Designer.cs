namespace formEntradaUsuario
{
    partial class FormEstudiante
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
            label1 = new Label();
            btn_Inscripcion = new Button();
            btn_Horarios = new Button();
            btn_RealizarPagos = new Button();
            picture_Estudiante = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picture_Estudiante).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 23);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre estudiante";
            // 
            // btn_Inscripcion
            // 
            btn_Inscripcion.Location = new Point(42, 77);
            btn_Inscripcion.Name = "btn_Inscripcion";
            btn_Inscripcion.Size = new Size(119, 38);
            btn_Inscripcion.TabIndex = 1;
            btn_Inscripcion.Text = "Inscripcion de materias";
            btn_Inscripcion.UseVisualStyleBackColor = true;
            btn_Inscripcion.Click += btn_Inscripcion_Click;
            // 
            // btn_Horarios
            // 
            btn_Horarios.Location = new Point(42, 137);
            btn_Horarios.Name = "btn_Horarios";
            btn_Horarios.Size = new Size(119, 38);
            btn_Horarios.TabIndex = 2;
            btn_Horarios.Text = "Consultar Horario";
            btn_Horarios.UseVisualStyleBackColor = true;
            btn_Horarios.Click += btn_Horarios_Click;
            // 
            // btn_RealizarPagos
            // 
            btn_RealizarPagos.Location = new Point(214, 109);
            btn_RealizarPagos.Name = "btn_RealizarPagos";
            btn_RealizarPagos.Size = new Size(119, 38);
            btn_RealizarPagos.TabIndex = 3;
            btn_RealizarPagos.Text = "Realizar Pagos";
            btn_RealizarPagos.UseVisualStyleBackColor = true;
            btn_RealizarPagos.Click += btn_RealizarPagos_Click;
            // 
            // picture_Estudiante
            // 
            picture_Estudiante.Location = new Point(25, 23);
            picture_Estudiante.Name = "picture_Estudiante";
            picture_Estudiante.Size = new Size(45, 38);
            picture_Estudiante.TabIndex = 4;
            picture_Estudiante.TabStop = false;
            // 
            // FormEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(429, 285);
            Controls.Add(picture_Estudiante);
            Controls.Add(btn_RealizarPagos);
            Controls.Add(btn_Horarios);
            Controls.Add(btn_Inscripcion);
            Controls.Add(label1);
            Name = "FormEstudiante";
            Text = "FormEstudiante";
            FormClosing += FormEstudiante_FormClosing;
            FormClosed += FormEstudiante_FormClosed;
            Load += FormEstudiante_Load;
            ((System.ComponentModel.ISupportInitialize)picture_Estudiante).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Inscripcion;
        private Button btn_Horarios;
        private Button btn_RealizarPagos;
        private PictureBox picture_Estudiante;
    }
}