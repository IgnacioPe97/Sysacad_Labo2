namespace formEntradaUsuario
{
    partial class FormParaListaEspera
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
            dataGridView1 = new DataGridView();
            btn_AgregaEstudiante = new Button();
            btn_EliminarEstudiante = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(652, 418);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // btn_AgregaEstudiante
            // 
            btn_AgregaEstudiante.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_AgregaEstudiante.Location = new Point(111, 107);
            btn_AgregaEstudiante.Name = "btn_AgregaEstudiante";
            btn_AgregaEstudiante.Size = new Size(168, 53);
            btn_AgregaEstudiante.TabIndex = 1;
            btn_AgregaEstudiante.Text = "AGREGAR ESTUDIANTE";
            btn_AgregaEstudiante.UseVisualStyleBackColor = true;
            btn_AgregaEstudiante.Click += btn_AgregaEstudiante_Click;
            // 
            // btn_EliminarEstudiante
            // 
            btn_EliminarEstudiante.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_EliminarEstudiante.Location = new Point(111, 235);
            btn_EliminarEstudiante.Name = "btn_EliminarEstudiante";
            btn_EliminarEstudiante.Size = new Size(168, 53);
            btn_EliminarEstudiante.TabIndex = 2;
            btn_EliminarEstudiante.Text = "ELIMINAR ESTUDIANTE";
            btn_EliminarEstudiante.UseVisualStyleBackColor = true;
            btn_EliminarEstudiante.Click += btn_EliminarEstudiante_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(388, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(658, 427);
            panel1.TabIndex = 3;
            panel1.Visible = false;
            // 
            // FormParaListaEspera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1064, 523);
            Controls.Add(panel1);
            Controls.Add(btn_EliminarEstudiante);
            Controls.Add(btn_AgregaEstudiante);
            Name = "FormParaListaEspera";
            Text = "FormParaListaEspera";
            FormClosing += FormParaListaEspera_FormClosing;
            Load += FormParaListaEspera_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_AgregaEstudiante;
        private Button btn_EliminarEstudiante;
        private Panel panel1;
    }
}