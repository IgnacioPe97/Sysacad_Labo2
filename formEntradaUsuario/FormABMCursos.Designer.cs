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
            btn_BajaCurso = new Button();
            btn_ModificacionCurso = new Button();
            btn_AltaCurso = new Button();
            SuspendLayout();
            // 
            // btn_BajaCurso
            // 
            btn_BajaCurso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_BajaCurso.BackColor = Color.DarkGray;
            btn_BajaCurso.Font = new Font("Ebrima", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_BajaCurso.Location = new Point(0, 51);
            btn_BajaCurso.Name = "btn_BajaCurso";
            btn_BajaCurso.Size = new Size(165, 31);
            btn_BajaCurso.TabIndex = 8;
            btn_BajaCurso.Text = "Baja Curso";
            btn_BajaCurso.UseVisualStyleBackColor = false;
            // 
            // btn_ModificacionCurso
            // 
            btn_ModificacionCurso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_ModificacionCurso.BackColor = Color.DarkGray;
            btn_ModificacionCurso.Font = new Font("Ebrima", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_ModificacionCurso.Location = new Point(0, 26);
            btn_ModificacionCurso.Name = "btn_ModificacionCurso";
            btn_ModificacionCurso.Size = new Size(165, 31);
            btn_ModificacionCurso.TabIndex = 7;
            btn_ModificacionCurso.Text = "Modificacion Curso";
            btn_ModificacionCurso.UseVisualStyleBackColor = false;
            // 
            // btn_AltaCurso
            // 
            btn_AltaCurso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_AltaCurso.BackColor = Color.DarkGray;
            btn_AltaCurso.Font = new Font("Ebrima", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_AltaCurso.Location = new Point(0, 0);
            btn_AltaCurso.Name = "btn_AltaCurso";
            btn_AltaCurso.Size = new Size(165, 31);
            btn_AltaCurso.TabIndex = 6;
            btn_AltaCurso.Text = "Alta Curso";
            btn_AltaCurso.UseVisualStyleBackColor = false;
            // 
            // FormABMCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(165, 117);
            Controls.Add(btn_BajaCurso);
            Controls.Add(btn_ModificacionCurso);
            Controls.Add(btn_AltaCurso);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormABMCursos";
            Text = "FormABMCursos";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_BajaCurso;
        private Button btn_ModificacionCurso;
        private Button btn_AltaCurso;
    }
}