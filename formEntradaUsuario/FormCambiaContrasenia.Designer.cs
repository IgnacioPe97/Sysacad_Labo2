namespace formEntradaUsuario
{
    partial class FormCambiaContrasenia
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
            btn_Guardar = new Button();
            txt_ = new TextBox();
            txt_confirmaContra = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_Guardar
            // 
            btn_Guardar.Location = new Point(65, 135);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(75, 23);
            btn_Guardar.TabIndex = 0;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // txt_
            // 
            txt_.Location = new Point(31, 28);
            txt_.Name = "txt_";
            txt_.PasswordChar = '*';
            txt_.PlaceholderText = "Contraseña nueva";
            txt_.Size = new Size(159, 23);
            txt_.TabIndex = 1;
            txt_.Leave += txt__Leave;
            // 
            // txt_confirmaContra
            // 
            txt_confirmaContra.Location = new Point(31, 73);
            txt_confirmaContra.Name = "txt_confirmaContra";
            txt_confirmaContra.PasswordChar = '*';
            txt_confirmaContra.PlaceholderText = "Confirmar Contraseña";
            txt_confirmaContra.Size = new Size(159, 23);
            txt_confirmaContra.TabIndex = 2;
            txt_confirmaContra.Leave += txt_confirmaContra_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(28, 99);
            label1.Name = "label1";
            label1.Size = new Size(162, 15);
            label1.TabIndex = 3;
            label1.Text = "Las contraseñas no coinciden";
            // 
            // FormCambiaContrasenia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(218, 186);
            Controls.Add(label1);
            Controls.Add(txt_confirmaContra);
            Controls.Add(txt_);
            Controls.Add(btn_Guardar);
            ForeColor = SystemColors.ControlText;
            Name = "FormCambiaContrasenia";
            Text = "FormCambiaContrasenia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Guardar;
        private TextBox txt_;
        private TextBox txt_confirmaContra;
        private Label label1;
    }
}