namespace formEntradaUsuario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btn_Ingresar = new Button();
            btn_Administrador = new Button();
            txt_Usuario = new TextBox();
            txt_Contrasenia = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightCyan;
            label1.Location = new Point(143, 43);
            label1.Name = "label1";
            label1.Size = new Size(247, 32);
            label1.TabIndex = 2;
            label1.Text = "Bienvenido a Sysacad";
            // 
            // btn_Ingresar
            // 
            btn_Ingresar.Location = new Point(81, 203);
            btn_Ingresar.Name = "btn_Ingresar";
            btn_Ingresar.Size = new Size(100, 39);
            btn_Ingresar.TabIndex = 3;
            btn_Ingresar.Text = "Ingreso Estudiante";
            btn_Ingresar.UseVisualStyleBackColor = true;
            btn_Ingresar.Click += btn_Ingresar_Click;
            // 
            // btn_Administrador
            // 
            btn_Administrador.Location = new Point(337, 203);
            btn_Administrador.Name = "btn_Administrador";
            btn_Administrador.Size = new Size(100, 39);
            btn_Administrador.TabIndex = 5;
            btn_Administrador.Text = "Ingreso Administrador";
            btn_Administrador.UseVisualStyleBackColor = true;
            btn_Administrador.Click += btn_Administrador_Click;
            // 
            // txt_Usuario
            // 
            txt_Usuario.Location = new Point(167, 105);
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.PlaceholderText = "Usuario";
            txt_Usuario.Size = new Size(204, 23);
            txt_Usuario.TabIndex = 6;
            // 
            // txt_Contrasenia
            // 
            txt_Contrasenia.Location = new Point(167, 143);
            txt_Contrasenia.Name = "txt_Contrasenia";
            txt_Contrasenia.PasswordChar = '*';
            txt_Contrasenia.PlaceholderText = "Contraseña";
            txt_Contrasenia.Size = new Size(204, 23);
            txt_Contrasenia.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(544, 300);
            Controls.Add(txt_Contrasenia);
            Controls.Add(txt_Usuario);
            Controls.Add(btn_Administrador);
            Controls.Add(btn_Ingresar);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ingreso a sistema";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btn_Ingresar;
        private Button btn_Administrador;
        private TextBox txt_Usuario;
        private TextBox txt_Contrasenia;
    }
}