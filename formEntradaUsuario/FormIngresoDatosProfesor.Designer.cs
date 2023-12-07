namespace formEntradaUsuario
{
    partial class FormIngresoDatosProfesor
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
            txt_Apellido = new TextBox();
            txt_Nombre = new TextBox();
            txt_contrasenia = new TextBox();
            txt_Correo = new TextBox();
            txt_Telefono = new TextBox();
            txt_direccion = new TextBox();
            btn_Cancelar = new Button();
            btn_guardar = new Button();
            SuspendLayout();
            // 
            // txt_Apellido
            // 
            txt_Apellido.BackColor = Color.Lavender;
            txt_Apellido.Location = new Point(270, 50);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.PlaceholderText = " Apellido";
            txt_Apellido.Size = new Size(182, 23);
            txt_Apellido.TabIndex = 6;
            txt_Apellido.Leave += txt_Apellido_Leave;
            // 
            // txt_Nombre
            // 
            txt_Nombre.BackColor = Color.Lavender;
            txt_Nombre.Location = new Point(54, 50);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.PlaceholderText = "Nombre";
            txt_Nombre.Size = new Size(182, 23);
            txt_Nombre.TabIndex = 5;
            txt_Nombre.Leave += txt_Nombre_Leave;
            // 
            // txt_contrasenia
            // 
            txt_contrasenia.BackColor = Color.Lavender;
            txt_contrasenia.Location = new Point(270, 99);
            txt_contrasenia.Name = "txt_contrasenia";
            txt_contrasenia.PasswordChar = '*';
            txt_contrasenia.PlaceholderText = "Contraseña";
            txt_contrasenia.Size = new Size(182, 23);
            txt_contrasenia.TabIndex = 13;
            txt_contrasenia.Leave += txt_contrasenia_Leave;
            // 
            // txt_Correo
            // 
            txt_Correo.BackColor = Color.Lavender;
            txt_Correo.Location = new Point(54, 99);
            txt_Correo.Name = "txt_Correo";
            txt_Correo.PlaceholderText = "Correo";
            txt_Correo.Size = new Size(182, 23);
            txt_Correo.TabIndex = 12;
            txt_Correo.Leave += txt_Correo_Leave;
            // 
            // txt_Telefono
            // 
            txt_Telefono.BackColor = Color.Lavender;
            txt_Telefono.Location = new Point(54, 153);
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.PlaceholderText = " Teléfono";
            txt_Telefono.Size = new Size(182, 23);
            txt_Telefono.TabIndex = 15;
            txt_Telefono.Leave += txt_Telefono_Leave;
            // 
            // txt_direccion
            // 
            txt_direccion.BackColor = Color.Lavender;
            txt_direccion.Location = new Point(270, 153);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.PlaceholderText = "Dirección";
            txt_direccion.Size = new Size(182, 23);
            txt_direccion.TabIndex = 14;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.Gray;
            btn_Cancelar.Location = new Point(278, 206);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(100, 37);
            btn_Cancelar.TabIndex = 17;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.Gray;
            btn_guardar.Location = new Point(143, 206);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(93, 37);
            btn_guardar.TabIndex = 16;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // FormIngresoDatosProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 268);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_guardar);
            Controls.Add(txt_Telefono);
            Controls.Add(txt_direccion);
            Controls.Add(txt_contrasenia);
            Controls.Add(txt_Correo);
            Controls.Add(txt_Apellido);
            Controls.Add(txt_Nombre);
            Name = "FormIngresoDatosProfesor";
            Text = "FormIngresoDatosProfesor";
            Load += FormIngresoDatosProfesor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Apellido;
        private TextBox txt_Nombre;
        private TextBox txt_contrasenia;
        private TextBox txt_Correo;
        private TextBox txt_Telefono;
        private TextBox txt_direccion;
        private Button btn_Cancelar;
        private Button btn_guardar;
    }
}