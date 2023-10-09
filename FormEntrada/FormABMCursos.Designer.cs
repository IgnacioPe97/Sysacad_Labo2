namespace formEntradaUsuario
{
    partial class FormABMCursos
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
            btn_AltaCurso = new Button();
            btn_ModificacionCurso = new Button();
            btn_BajaCurso = new Button();
            SuspendLayout();
            // 
            // btn_AltaCurso
            // 
            btn_AltaCurso.BackColor = Color.DarkGray;
            btn_AltaCurso.Font = new Font("Ebrima", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_AltaCurso.Location = new Point(25, 103);
            btn_AltaCurso.Name = "btn_AltaCurso";
            btn_AltaCurso.Size = new Size(136, 39);
            btn_AltaCurso.TabIndex = 0;
            btn_AltaCurso.Text = "Alta Curso";
            btn_AltaCurso.UseVisualStyleBackColor = false;
            btn_AltaCurso.Click += btn_AltaCurso_Click;
            // 
            // btn_ModificacionCurso
            // 
            btn_ModificacionCurso.BackColor = Color.DarkGray;
            btn_ModificacionCurso.Font = new Font("Ebrima", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_ModificacionCurso.Location = new Point(179, 103);
            btn_ModificacionCurso.Name = "btn_ModificacionCurso";
            btn_ModificacionCurso.Size = new Size(136, 39);
            btn_ModificacionCurso.TabIndex = 1;
            btn_ModificacionCurso.Text = "Modificacion Curso";
            btn_ModificacionCurso.UseVisualStyleBackColor = false;
            btn_ModificacionCurso.Click += btn_ModificacionCurso_Click;
            // 
            // btn_BajaCurso
            // 
            btn_BajaCurso.BackColor = Color.DarkGray;
            btn_BajaCurso.Font = new Font("Ebrima", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_BajaCurso.Location = new Point(341, 103);
            btn_BajaCurso.Name = "btn_BajaCurso";
            btn_BajaCurso.Size = new Size(136, 39);
            btn_BajaCurso.TabIndex = 2;
            btn_BajaCurso.Text = "Baja Curso";
            btn_BajaCurso.UseVisualStyleBackColor = false;
            btn_BajaCurso.Click += btn_BajaCurso_Click;
            // 
            // FormABMCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(511, 236);
            Controls.Add(btn_BajaCurso);
            Controls.Add(btn_ModificacionCurso);
            Controls.Add(btn_AltaCurso);
            Name = "FormABMCursos";
            Text = "FormABMCursos";
            FormClosing += FormABMCursos_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_AltaCurso;
        private Button btn_ModificacionCurso;
        private Button btn_BajaCurso;
    }
}