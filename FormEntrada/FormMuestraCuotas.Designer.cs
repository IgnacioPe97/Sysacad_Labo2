namespace formEntradaUsuario
{
    partial class FormMuestraCuotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMuestraCuotas));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            picture_carrito = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture_carrito).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(364, 395);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 15);
            label1.Name = "label1";
            label1.Size = new Size(157, 25);
            label1.TabIndex = 1;
            label1.Text = "Seleccione Cuota";
            // 
            // picture_carrito
            // 
            picture_carrito.ErrorImage = (Image)resources.GetObject("picture_carrito.ErrorImage");
            picture_carrito.Image = Properties.Resources.carrito;
            picture_carrito.Location = new Point(351, 7);
            picture_carrito.Name = "picture_carrito";
            picture_carrito.Size = new Size(35, 30);
            picture_carrito.TabIndex = 2;
            picture_carrito.TabStop = false;
            picture_carrito.Click += picture_carrito_Click;
            // 
            // FormMuestraCuotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(426, 451);
            Controls.Add(picture_carrito);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FormMuestraCuotas";
            Text = "FormMuestraCuotas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture_carrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private PictureBox picture_carrito;
    }
}