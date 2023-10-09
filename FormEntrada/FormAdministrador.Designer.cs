namespace formEntradaUsuario
{
    partial class FormAdministrador
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
            components = new System.ComponentModel.Container();
            imageList1 = new ImageList(components);
            txt_nombreUsuario = new Label();
            btn_Registrar = new Button();
            btn_GestionarCursos = new Button();
            picture_Admin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picture_Admin).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // txt_nombreUsuario
            // 
            txt_nombreUsuario.AutoSize = true;
            txt_nombreUsuario.Location = new Point(98, 46);
            txt_nombreUsuario.Name = "txt_nombreUsuario";
            txt_nombreUsuario.Size = new Size(128, 15);
            txt_nombreUsuario.TabIndex = 0;
            txt_nombreUsuario.Text = "Nombre administrador";
            // 
            // btn_Registrar
            // 
            btn_Registrar.BackColor = Color.Beige;
            btn_Registrar.Location = new Point(44, 98);
            btn_Registrar.Name = "btn_Registrar";
            btn_Registrar.Size = new Size(109, 38);
            btn_Registrar.TabIndex = 1;
            btn_Registrar.Text = "Registrar Estudiante";
            btn_Registrar.UseVisualStyleBackColor = false;
            btn_Registrar.Click += btn_Registrar_Click;
            // 
            // btn_GestionarCursos
            // 
            btn_GestionarCursos.BackColor = Color.Beige;
            btn_GestionarCursos.Location = new Point(44, 157);
            btn_GestionarCursos.Name = "btn_GestionarCursos";
            btn_GestionarCursos.Size = new Size(109, 38);
            btn_GestionarCursos.TabIndex = 2;
            btn_GestionarCursos.Text = "Gestionar Cursos";
            btn_GestionarCursos.UseVisualStyleBackColor = false;
            btn_GestionarCursos.Click += btn_GestionarCursos_Click;
            // 
            // picture_Admin
            // 
            picture_Admin.Location = new Point(27, 12);
            picture_Admin.Name = "picture_Admin";
            picture_Admin.Size = new Size(55, 69);
            picture_Admin.TabIndex = 3;
            picture_Admin.TabStop = false;
            // 
            // FormAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(486, 316);
            Controls.Add(picture_Admin);
            Controls.Add(btn_GestionarCursos);
            Controls.Add(btn_Registrar);
            Controls.Add(txt_nombreUsuario);
            Name = "FormAdministrador";
            Text = "FormAdministrador";
            FormClosing += FormAdministrador_FormClosing;
            FormClosed += FormAdministrador_FormClosed;
            Load += FormAdministrador_Load;
            ((System.ComponentModel.ISupportInitialize)picture_Admin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList imageList1;
        private Label txt_nombreUsuario;
        private Button btn_Registrar;
        private Button btn_GestionarCursos;
        private PictureBox picture_Admin;
    }
}