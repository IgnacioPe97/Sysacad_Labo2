using CapaDatos;
using LogicaDeNegocio;
using Org.BouncyCastle.Tsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formEntradaUsuario
{
    public partial class FormMuestraCuotas : Form
    {
        Estudiante estudiante;
        List<Pagos> pagosPendientes;
        List<Pagos> pagosAPagar;
        string rutaImagenCarrito = @"C:\Users\Ignacio Pereyra\Desktop\Solution C#\formEntradaUsuario\Imagenes\carrito.png";
        public FormMuestraCuotas(Estudiante unEstudiante)
        {
            InitializeComponent();
            estudiante = unEstudiante;
            pagosAPagar = new List<Pagos>();
            pagosPendientes = new List<Pagos>();
            CambiarTamanioImagen();




            if (BuscaCuotasDeDeuda(EstudianteDB.ObtieneListaPagosDeUnAlumno(estudiante.Dni)))
            {
                dataGridView1.Visible = true;
                dataGridView1.DataSource = pagosPendientes;
            }
            else
            {
                dataGridView1.Visible = false;
                MessageBox.Show("No tiene cuotas que pagar");
            }
        }
        private void CambiarTamanioImagen()
        {
            Image imagenCarrito = Image.FromFile(rutaImagenCarrito);
            picture_carrito.SizeMode = PictureBoxSizeMode.CenterImage;
            int ancho = 30;
            int alto = 30;
            imagenCarrito = new Bitmap(imagenCarrito, ancho, alto);
            picture_carrito.Image = imagenCarrito;
            picture_carrito.Size = new Size(ancho, alto);

        }
        private bool BuscaCuotasDeDeuda(List<Pagos> pagos)
        {
            bool retorno = false;
            foreach (Pagos item in pagos)
            {
                if (item.EstaPago == false)
                {
                    pagosPendientes.Add(item);
                    retorno = true;
                }
            }
            return retorno;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Pagos unPago = pagosPendientes[e.RowIndex];
                pagosAPagar.Add(unPago);

                DialogResult result = MessageBox.Show($"¿Quieres ir a carrito?", "Confirmación de eliminación", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    MuestraCuotas();
                }
                else
                {
                    pagosAPagar.Clear();
                }
            }
        }
        private bool MuestraCuotas()
        {
            FormParaPagarCuotas formCuotas = new FormParaPagarCuotas(pagosAPagar,estudiante.Dni);
            DialogResult dialogResult = formCuotas.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                MessageBox.Show("Cuotas pagadas con exito");
                return true;
            }
            else
            {
                MessageBox.Show("No se pudieron pagar las cuotas");
                return false;
            }
        }

        private void picture_carrito_Click(object sender, EventArgs e)
        {
            MuestraCuotas();
        }
    }
}
