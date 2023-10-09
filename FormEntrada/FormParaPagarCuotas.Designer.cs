namespace formEntradaUsuario
{
    partial class FormParaPagarCuotas
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
            txt_NumeroTarjeta = new TextBox();
            txt_CodigoTarjeta = new TextBox();
            btn_Pagar = new Button();
            btn_Cancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(85, 22);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // txt_NumeroTarjeta
            // 
            txt_NumeroTarjeta.Location = new Point(12, 59);
            txt_NumeroTarjeta.Name = "txt_NumeroTarjeta";
            txt_NumeroTarjeta.PlaceholderText = "Ingrese N° tarjeta";
            txt_NumeroTarjeta.Size = new Size(201, 23);
            txt_NumeroTarjeta.TabIndex = 1;
            txt_NumeroTarjeta.Leave += txt_NumeroTarjeta_Leave;
            // 
            // txt_CodigoTarjeta
            // 
            txt_CodigoTarjeta.Location = new Point(12, 88);
            txt_CodigoTarjeta.Name = "txt_CodigoTarjeta";
            txt_CodigoTarjeta.PasswordChar = '*';
            txt_CodigoTarjeta.PlaceholderText = "Codigo";
            txt_CodigoTarjeta.Size = new Size(100, 23);
            txt_CodigoTarjeta.TabIndex = 2;
            txt_CodigoTarjeta.Leave += txt_CodigoTarjeta_Leave;
            // 
            // btn_Pagar
            // 
            btn_Pagar.Location = new Point(37, 155);
            btn_Pagar.Name = "btn_Pagar";
            btn_Pagar.Size = new Size(75, 23);
            btn_Pagar.TabIndex = 3;
            btn_Pagar.Text = "Pagar";
            btn_Pagar.UseVisualStyleBackColor = true;
            btn_Pagar.Click += btn_Pagar_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(168, 155);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(75, 23);
            btn_Cancelar.TabIndex = 4;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // FormParaPagarCuotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(323, 209);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Pagar);
            Controls.Add(txt_CodigoTarjeta);
            Controls.Add(txt_NumeroTarjeta);
            Controls.Add(label1);
            Name = "FormParaPagarCuotas";
            Text = "FormParaPagarCuotas";
            FormClosed += FormParaPagarCuotas_FormClosed;
            Load += FormParaPagarCuotas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_NumeroTarjeta;
        private TextBox txt_CodigoTarjeta;
        private Button btn_Pagar;
        private Button btn_Cancelar;
    }
}