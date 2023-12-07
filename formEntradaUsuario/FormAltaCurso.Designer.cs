namespace formEntradaUsuario
{
    partial class FormAltaCurso
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
            txt_NombreCurso = new TextBox();
            txt_codigo = new TextBox();
            txt_cupoMaximo = new TextBox();
            rich_Descripcion = new RichTextBox();
            label1 = new Label();
            txt_CargaHoraria = new TextBox();
            btn_GuardarCurso = new Button();
            btn_Cancelar = new Button();
            SuspendLayout();
            // 
            // txt_NombreCurso
            // 
            txt_NombreCurso.Location = new Point(30, 36);
            txt_NombreCurso.Name = "txt_NombreCurso";
            txt_NombreCurso.PlaceholderText = "Nombre de Curso";
            txt_NombreCurso.Size = new Size(148, 23);
            txt_NombreCurso.TabIndex = 0;
            txt_NombreCurso.TextChanged += txt_NombreCurso_TextChanged;
            txt_NombreCurso.Leave += txt_NombreCurso_Leave;
            // 
            // txt_codigo
            // 
            txt_codigo.Location = new Point(30, 73);
            txt_codigo.Name = "txt_codigo";
            txt_codigo.PlaceholderText = "Codigo de curso";
            txt_codigo.Size = new Size(148, 23);
            txt_codigo.TabIndex = 1;
            txt_codigo.Leave += txt_codigo_Leave;
            // 
            // txt_cupoMaximo
            // 
            txt_cupoMaximo.Location = new Point(30, 110);
            txt_cupoMaximo.Name = "txt_cupoMaximo";
            txt_cupoMaximo.PlaceholderText = "Cupo maximo";
            txt_cupoMaximo.Size = new Size(148, 23);
            txt_cupoMaximo.TabIndex = 2;
            txt_cupoMaximo.Leave += txt_cupoMaximo_Leave;
            // 
            // rich_Descripcion
            // 
            rich_Descripcion.Location = new Point(200, 56);
            rich_Descripcion.Name = "rich_Descripcion";
            rich_Descripcion.Size = new Size(165, 103);
            rich_Descripcion.TabIndex = 6;
            rich_Descripcion.Text = "";
            rich_Descripcion.TextChanged += rich_Descripcion_TextChanged;
            rich_Descripcion.Leave += rich_Descripcion_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 38);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 7;
            label1.Text = "Descripción  ";
            // 
            // txt_CargaHoraria
            // 
            txt_CargaHoraria.Location = new Point(30, 144);
            txt_CargaHoraria.Name = "txt_CargaHoraria";
            txt_CargaHoraria.PlaceholderText = "Carga Horaria";
            txt_CargaHoraria.Size = new Size(148, 23);
            txt_CargaHoraria.TabIndex = 8;
            txt_CargaHoraria.Leave += txt_CargaHoraria_Leave;
            // 
            // btn_GuardarCurso
            // 
            btn_GuardarCurso.BackColor = Color.DimGray;
            btn_GuardarCurso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_GuardarCurso.ForeColor = SystemColors.ButtonFace;
            btn_GuardarCurso.Location = new Point(68, 190);
            btn_GuardarCurso.Name = "btn_GuardarCurso";
            btn_GuardarCurso.Size = new Size(110, 36);
            btn_GuardarCurso.TabIndex = 9;
            btn_GuardarCurso.Text = "Guardar Curso";
            btn_GuardarCurso.UseVisualStyleBackColor = false;
            btn_GuardarCurso.Click += btn_GuardarCurso_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.DimGray;
            btn_Cancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Cancelar.ForeColor = SystemColors.ButtonFace;
            btn_Cancelar.Location = new Point(255, 190);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(110, 36);
            btn_Cancelar.TabIndex = 10;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // FormAltaCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(451, 264);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_GuardarCurso);
            Controls.Add(txt_CargaHoraria);
            Controls.Add(label1);
            Controls.Add(rich_Descripcion);
            Controls.Add(txt_cupoMaximo);
            Controls.Add(txt_codigo);
            Controls.Add(txt_NombreCurso);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAltaCurso";
            Text = "FormAltaCurso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_NombreCurso;
        private TextBox txt_codigo;
        private TextBox txt_cupoMaximo;
        private RichTextBox rich_Descripcion;
        private Label label1;
        private TextBox txt_CargaHoraria;
        private Button btn_GuardarCurso;
        private Button btn_Cancelar;
    }
}