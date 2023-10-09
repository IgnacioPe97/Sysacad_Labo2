namespace formEntradaUsuario
{
    partial class FormABMGenerico
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
            btn_Alta = new Button();
            btn_Modificacion = new Button();
            btn_Baja = new Button();
            SuspendLayout();
            // 
            // btn_Alta
            // 
            btn_Alta.Location = new Point(12, 68);
            btn_Alta.Name = "btn_Alta";
            btn_Alta.Size = new Size(113, 41);
            btn_Alta.TabIndex = 0;
            btn_Alta.Text = "Alta";
            btn_Alta.UseVisualStyleBackColor = true;
            btn_Alta.Click += btn_Alta_Click;
            // 
            // btn_Modificacion
            // 
            btn_Modificacion.Location = new Point(155, 68);
            btn_Modificacion.Name = "btn_Modificacion";
            btn_Modificacion.Size = new Size(113, 41);
            btn_Modificacion.TabIndex = 1;
            btn_Modificacion.Text = "Modificacion";
            btn_Modificacion.UseVisualStyleBackColor = true;
            btn_Modificacion.Click += btn_Modificacion_Click;
            // 
            // btn_Baja
            // 
            btn_Baja.Location = new Point(303, 68);
            btn_Baja.Name = "btn_Baja";
            btn_Baja.Size = new Size(113, 41);
            btn_Baja.TabIndex = 2;
            btn_Baja.Text = "Baja";
            btn_Baja.UseVisualStyleBackColor = true;
            btn_Baja.Click += btn_Baja_Click;
            // 
            // FormABMGenerico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 175);
            Controls.Add(btn_Baja);
            Controls.Add(btn_Modificacion);
            Controls.Add(btn_Alta);
            Name = "FormABMGenerico";
            Text = "FormABMGenerico";
            ResumeLayout(false);
        }

        #endregion
        protected Button btn_Alta;
        protected Button btn_Modificacion;
        protected Button btn_Baja;
    }
}