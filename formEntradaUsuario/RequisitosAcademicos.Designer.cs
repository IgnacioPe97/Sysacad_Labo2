namespace formEntradaUsuario
{
    partial class RequisitosAcademicos
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
            label2 = new Label();
            label3 = new Label();
            comboBox_MateriaCorrelativa = new ComboBox();
            comboBox_Creditos = new ComboBox();
            txt_Promedio = new TextBox();
            btn_AgregarRequisitos = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lbl_NombreMateria = new Label();
            btn_BorrarRequisitos = new Button();
            btn_Salir = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 184);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 3;
            label1.Text = "Materias Correlativas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 184);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Creditos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(300, 184);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 5;
            label3.Text = "Promedio minimo";
            // 
            // comboBox_MateriaCorrelativa
            // 
            comboBox_MateriaCorrelativa.FormattingEnabled = true;
            comboBox_MateriaCorrelativa.Location = new Point(11, 202);
            comboBox_MateriaCorrelativa.Name = "comboBox_MateriaCorrelativa";
            comboBox_MateriaCorrelativa.Size = new Size(121, 23);
            comboBox_MateriaCorrelativa.TabIndex = 6;
            // 
            // comboBox_Creditos
            // 
            comboBox_Creditos.FormattingEnabled = true;
            comboBox_Creditos.Location = new Point(154, 202);
            comboBox_Creditos.Name = "comboBox_Creditos";
            comboBox_Creditos.Size = new Size(121, 23);
            comboBox_Creditos.TabIndex = 7;
            // 
            // txt_Promedio
            // 
            txt_Promedio.Location = new Point(293, 202);
            txt_Promedio.Name = "txt_Promedio";
            txt_Promedio.Size = new Size(121, 23);
            txt_Promedio.TabIndex = 8;
            txt_Promedio.Leave += txt_Promedio_Leave;
            // 
            // btn_AgregarRequisitos
            // 
            btn_AgregarRequisitos.Location = new Point(90, 271);
            btn_AgregarRequisitos.Name = "btn_AgregarRequisitos";
            btn_AgregarRequisitos.Size = new Size(130, 23);
            btn_AgregarRequisitos.TabIndex = 9;
            btn_AgregarRequisitos.Text = "Agregar Requisitos";
            btn_AgregarRequisitos.UseVisualStyleBackColor = true;
            btn_AgregarRequisitos.Click += btn_AgregarRequisitos_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(479, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(548, 537);
            panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(542, 531);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbl_NombreMateria
            // 
            lbl_NombreMateria.AutoSize = true;
            lbl_NombreMateria.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_NombreMateria.Location = new Point(12, 12);
            lbl_NombreMateria.Name = "lbl_NombreMateria";
            lbl_NombreMateria.Size = new Size(231, 37);
            lbl_NombreMateria.TabIndex = 11;
            lbl_NombreMateria.Text = "Nombre Materia";
            // 
            // btn_BorrarRequisitos
            // 
            btn_BorrarRequisitos.Location = new Point(233, 271);
            btn_BorrarRequisitos.Name = "btn_BorrarRequisitos";
            btn_BorrarRequisitos.Size = new Size(130, 23);
            btn_BorrarRequisitos.TabIndex = 14;
            btn_BorrarRequisitos.Text = "Borrar Requisitos";
            btn_BorrarRequisitos.UseVisualStyleBackColor = true;
            btn_BorrarRequisitos.Click += btn_BorrarRequisitos_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor = Color.DimGray;
            btn_Salir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Salir.Location = new Point(11, 523);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(130, 23);
            btn_Salir.TabIndex = 15;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = false;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // RequisitosAcademicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 561);
            Controls.Add(btn_Salir);
            Controls.Add(btn_BorrarRequisitos);
            Controls.Add(lbl_NombreMateria);
            Controls.Add(panel1);
            Controls.Add(btn_AgregarRequisitos);
            Controls.Add(txt_Promedio);
            Controls.Add(comboBox_Creditos);
            Controls.Add(comboBox_MateriaCorrelativa);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RequisitosAcademicos";
            Text = "RequisitosAcademicos";
            Load += RequisitosAcademicos_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox_MateriaCorrelativa;
        private ComboBox comboBox_Creditos;
        private TextBox txt_Promedio;
        private Button btn_AgregarRequisitos;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lbl_NombreMateria;
        private Button btn_BorrarRequisitos;
        private Button btn_Salir;
    }
}