namespace formEntradaUsuario
{
    partial class FormIngresoDatosEstudiante
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
            txt_Nombre = new TextBox();
            txt_Correo = new TextBox();
            txt_direccion = new TextBox();
            txt_Apellido = new TextBox();
            txt_Telefono = new TextBox();
            txt_DNI = new TextBox();
            comboBox_Carrera = new ComboBox();
            label_PreferenciaCarrera = new Label();
            btn_guardar = new Button();
            btn_Cancelar = new Button();
            txt_contrasenia = new TextBox();
            checkBox_cambiaContraseña = new CheckBox();
            comboBox_Turno = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txt_Nombre
            // 
            txt_Nombre.BackColor = Color.Lavender;
            txt_Nombre.Location = new Point(27, 31);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.PlaceholderText = "Nombre";
            txt_Nombre.Size = new Size(182, 23);
            txt_Nombre.TabIndex = 0;
            txt_Nombre.TextChanged += txt_Nombre_TextChanged;
            txt_Nombre.Leave += txt_Nombre_Leave;
            // 
            // txt_Correo
            // 
            txt_Correo.BackColor = Color.Lavender;
            txt_Correo.Location = new Point(27, 72);
            txt_Correo.Name = "txt_Correo";
            txt_Correo.PlaceholderText = "Correo";
            txt_Correo.Size = new Size(182, 23);
            txt_Correo.TabIndex = 1;
            txt_Correo.TextChanged += txt_Correo_TextChanged;
            txt_Correo.Leave += txt_Correo_Leave;
            // 
            // txt_direccion
            // 
            txt_direccion.BackColor = Color.Lavender;
            txt_direccion.Location = new Point(27, 141);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.PlaceholderText = "Dirección";
            txt_direccion.Size = new Size(182, 23);
            txt_direccion.TabIndex = 2;
            txt_direccion.TextChanged += textBox3_TextChanged;
            txt_direccion.Leave += textBox3_Leave;
            // 
            // txt_Apellido
            // 
            txt_Apellido.BackColor = Color.Lavender;
            txt_Apellido.Location = new Point(243, 31);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.PlaceholderText = " Apellido";
            txt_Apellido.Size = new Size(182, 23);
            txt_Apellido.TabIndex = 4;
            txt_Apellido.TextChanged += txt_Apellido_TextChanged;
            txt_Apellido.Leave += txt_Apellido_Leave;
            // 
            // txt_Telefono
            // 
            txt_Telefono.BackColor = Color.Lavender;
            txt_Telefono.Location = new Point(27, 105);
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.PlaceholderText = " Teléfono";
            txt_Telefono.Size = new Size(182, 23);
            txt_Telefono.TabIndex = 5;
            txt_Telefono.TextChanged += txt_Telefono_TextChanged;
            txt_Telefono.Leave += txt_Telefono_Leave;
            // 
            // txt_DNI
            // 
            txt_DNI.BackColor = Color.Lavender;
            txt_DNI.Location = new Point(243, 141);
            txt_DNI.Name = "txt_DNI";
            txt_DNI.PlaceholderText = "DNI";
            txt_DNI.Size = new Size(182, 23);
            txt_DNI.TabIndex = 6;
            txt_DNI.TextChanged += txt_DNI_TextChanged;
            txt_DNI.Leave += txt_DNI_Leave;
            // 
            // comboBox_Carrera
            // 
            comboBox_Carrera.BackColor = Color.Lavender;
            comboBox_Carrera.FormattingEnabled = true;
            comboBox_Carrera.Location = new Point(265, 200);
            comboBox_Carrera.Name = "comboBox_Carrera";
            comboBox_Carrera.Size = new Size(261, 23);
            comboBox_Carrera.TabIndex = 7;
            comboBox_Carrera.Leave += comboBox_Carrera_Leave;
            // 
            // label_PreferenciaCarrera
            // 
            label_PreferenciaCarrera.AutoSize = true;
            label_PreferenciaCarrera.BackColor = Color.Lavender;
            label_PreferenciaCarrera.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_PreferenciaCarrera.Location = new Point(265, 176);
            label_PreferenciaCarrera.Name = "label_PreferenciaCarrera";
            label_PreferenciaCarrera.Size = new Size(62, 21);
            label_PreferenciaCarrera.TabIndex = 8;
            label_PreferenciaCarrera.Text = "Carrera";
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.Gray;
            btn_guardar.Location = new Point(130, 240);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(93, 37);
            btn_guardar.TabIndex = 9;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.Gray;
            btn_Cancelar.Location = new Point(265, 240);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(100, 37);
            btn_Cancelar.TabIndex = 10;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // txt_contrasenia
            // 
            txt_contrasenia.BackColor = Color.Lavender;
            txt_contrasenia.Location = new Point(243, 72);
            txt_contrasenia.Name = "txt_contrasenia";
            txt_contrasenia.PasswordChar = '*';
            txt_contrasenia.PlaceholderText = "Contraseña";
            txt_contrasenia.Size = new Size(182, 23);
            txt_contrasenia.TabIndex = 11;
            txt_contrasenia.Leave += textBox1_Leave;
            // 
            // checkBox_cambiaContraseña
            // 
            checkBox_cambiaContraseña.AutoSize = true;
            checkBox_cambiaContraseña.BackColor = Color.Lavender;
            checkBox_cambiaContraseña.Location = new Point(243, 101);
            checkBox_cambiaContraseña.Name = "checkBox_cambiaContraseña";
            checkBox_cambiaContraseña.Size = new Size(134, 19);
            checkBox_cambiaContraseña.TabIndex = 12;
            checkBox_cambiaContraseña.Text = "Cambiar Contraseña";
            checkBox_cambiaContraseña.UseVisualStyleBackColor = false;
            // 
            // comboBox_Turno
            // 
            comboBox_Turno.FormattingEnabled = true;
            comboBox_Turno.Location = new Point(27, 200);
            comboBox_Turno.Name = "comboBox_Turno";
            comboBox_Turno.Size = new Size(182, 23);
            comboBox_Turno.TabIndex = 13;
            comboBox_Turno.Leave += comboBox_Turno_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lavender;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 176);
            label1.Name = "label1";
            label1.Size = new Size(51, 21);
            label1.TabIndex = 14;
            label1.Text = "Turno";
            // 
            // FormIngresoDatosEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(548, 306);
            Controls.Add(label1);
            Controls.Add(comboBox_Turno);
            Controls.Add(checkBox_cambiaContraseña);
            Controls.Add(txt_contrasenia);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_guardar);
            Controls.Add(label_PreferenciaCarrera);
            Controls.Add(comboBox_Carrera);
            Controls.Add(txt_DNI);
            Controls.Add(txt_Telefono);
            Controls.Add(txt_Apellido);
            Controls.Add(txt_direccion);
            Controls.Add(txt_Correo);
            Controls.Add(txt_Nombre);
            ForeColor = SystemColors.ControlText;
            Name = "FormIngresoDatosEstudiante";
            Text = "FormIngresoDatosEstudiante";
            Load += FormIngresoDatosEstudiante_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Nombre;
        private TextBox txt_Correo;
        private TextBox txt_direccion;
        private TextBox txt_Apellido;
        private TextBox txt_Telefono;
        private TextBox txt_DNI;
        private ComboBox comboBox_Carrera;
        private Label label_PreferenciaCarrera;
        private Button btn_guardar;
        private Button btn_Cancelar;
        private TextBox txt_contrasenia;
        private CheckBox checkBox_cambiaContraseña;
        private ComboBox comboBox_Turno;
        private Label label1;
    }
}